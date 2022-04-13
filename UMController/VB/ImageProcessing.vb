Imports System.Runtime.InteropServices
Imports System.Threading.Tasks
Imports BitMiracle.LibTiff.Classic
Imports PixelFormat = System.Drawing.Imaging.PixelFormat

Public Class ImageProcessing

    'define variables for Histogram
    Const _numclasses As Integer = 25

    'Holds the recorded image data
    Private Shared _bit32(), _temp32() As UInteger

    'Buffer for live image
    Private Shared _bit8image As Bitmap

    'Holds the display screen.
    Private Shared _bytes() As Byte

    Private Shared _camera_present As Boolean
    Private Shared _hist_input(_ximage * _yimage - 1), _log_histogram(_numclasses - 1), _cw(_numclasses) As Double
    Private Shared _I_max, _nbits As UShort
    Private Shared _image_recording_stopped As Boolean
    Private Shared _MinPixel, _MaxPixel As Double
    Private Shared _overexposure_mask(), _underexposure_mask() As Boolean
    Private Shared _temp16() As UShort

    'various variables/flags
    Private Shared _ximage, _yimage As Integer

    'define task for screen generation
    Private Shared CalculateScreenTask As New ComponentModel.BackgroundWorker

    'Task for Histogram Calculation
    Private Shared HistogramCalculationTask As New ComponentModel.BackgroundWorker

    'define task for background recording
    Private Shared ImageRecordingTask As New ComponentModel.BackgroundWorker

    Public Enum Cameras
        AndorNeo = 0
        AndorZyla = 1
        DemoMode = 2
    End Enum

    ' Bildgröße für Cf Kamera
    Public Enum Scanningmode
        singlescan = 0
        multiscan3 = 1
        multiscan5 = 2
    End Enum

    'returns last image data (16-bit)
    Public Shared ReadOnly Property Bit32Data() As UInteger()
        Get
            Return _bit32
        End Get
    End Property

    'checks if camera is connected
    Public Shared ReadOnly Property CameraPresent() As Boolean
        Get
            Return _camera_present
        End Get
    End Property

    Public Shared ReadOnly Property GetNBits() As UShort
        Get
            Return _nbits
        End Get
    End Property

    'get maximal theoretical intensity value according to current camera settings
    Public Shared ReadOnly Property MaxI() As Integer
        Get
            Return _I_max
        End Get
    End Property

    'returns the current image as bitmap
    Public Shared ReadOnly Property PresentImage() As Bitmap
        Get
            Return _bit8image
        End Get
    End Property

    'get image x-resolution
    Public Shared ReadOnly Property Xres() As Integer
        Get
            Return _ximage
        End Get
    End Property

    'get image y-resolution
    Public Shared ReadOnly Property Yres() As Integer
        Get
            Return _yimage
        End Get
    End Property

    Public Shared Sub GetCameraImage(exposure As UShort, scanningmode As Scanningmode)
        'gets one camera image and performs background correction

        If _camera_present Then
            Select Case scanningmode
                Case Scanningmode.singlescan
                    NativeMethods.GrabImage(_temp16, exposure)
                Case Scanningmode.multiscan3
                    GrabMultiscanImage3(_temp16, exposure)
                Case Scanningmode.multiscan5
                    GrabMultiscanImage5(_temp16, exposure)
            End Select

            'Correct for uneven background
            Parallel.For(0, _ximage * _yimage - 1,
            Sub(i)
                If _temp16(i) > __CameraBackground Then
                    _bit32(i) = _temp16(i) - __CameraBackground
                Else
                    _bit32(i) = 0
                End If
            End Sub)
        Else
            GenerateTestPattern()
        End If
    End Sub

    'Kills image recording background process
    Public Shared Sub ImageRecordingTaskClose()

        ImageProcessing.ImageRecordingTaskStop()
        ImageRecordingTask.Dispose()

        'Shut down the camera
        If _camera_present Then
            NativeMethods.CloseCam()
        End If

        _bit8image = Nothing
    End Sub

    'Turn on background image recording
    Public Shared Sub ImagerecordingTaskStart()

        If Not ImageRecordingTask.IsBusy Then
            _image_recording_stopped = False
            ImageRecordingTask.RunWorkerAsync()
        End If
    End Sub

    'stop background image recording
    Public Shared Sub ImageRecordingTaskStop()

        CalculateScreenTask.CancelAsync()
        HistogramCalculationTask.CancelAsync()

        _image_recording_stopped = True
        While ImageRecordingTask.IsBusy
            Application.DoEvents()
        End While
    End Sub

    'initialize camera / image recording
    Public Shared Sub Init()

        'Initialize Image Recording Task
        ImageRecordingTask.WorkerSupportsCancellation = True
        ImageRecordingTask.WorkerReportsProgress = True
        AddHandler ImageRecordingTask.DoWork, AddressOf ImageRecordingTask_DoWork
        AddHandler ImageRecordingTask.ProgressChanged, AddressOf ImageRecordingTask_ProgressChanged

        'Initialize Screen Generation Task
        CalculateScreenTask.WorkerSupportsCancellation = True
        CalculateScreenTask.WorkerReportsProgress = False
        AddHandler CalculateScreenTask.DoWork, AddressOf CalculateScreenTask_DoWork

        'Initialize Histogram Task
        HistogramCalculationTask.WorkerSupportsCancellation = True
        HistogramCalculationTask.WorkerReportsProgress = False
        AddHandler HistogramCalculationTask.DoWork, AddressOf HistogramCalculationTask_DoWork

        'try to initialize camera
        Dim err As Integer
        Dim xr, yr As UShort

        Select Case __CameraType
            Case Cameras.AndorNeo 'Do initializations for Andor Neo camera if selected
                Try
                    err = NativeMethods.InitCam(__CameraMode)
                    If err <> 0 Then
                        GoTo CAMERROR
                    Else
                        err = NativeMethods.GetRes(xr, yr)
                        If err <> 0 Then
                            GoTo CAMERROR
                        End If
                    End If
                Catch
                    GoTo CAMERROR
                End Try

                _camera_present = True
                _ximage = xr
                _yimage = yr

                Select Case __CameraMode
                    Case 1, 2, 3, 4 '8 Gain 1 - Gain 4
                        _nbits = 11
                        _I_max = 1800
                    Case 5 ' Gain 1 Gain 3
                        _nbits = 14
                        _I_max = 11000
                    Case 6 ' Gain 1 Gain 4
                        _nbits = 16
                        _I_max = 48000
                    Case 7 ' Gain 2 Gain 3
                        _nbits = 14
                        _I_max = 10000
                    Case 8 ' Gain 2 Gain 4
                        _nbits = 16
                        _I_max = 48000
                End Select

            Case Cameras.AndorZyla 'Do initializations for Andor Zyla camera if selected
                Try
                    err = NativeMethods.InitCam(__CameraMode)
                    If err <> 0 Then
                        GoTo CAMERROR
                    Else
                        err = NativeMethods.GetRes(xr, yr)
                        If err <> 0 Then
                            GoTo CAMERROR
                        End If
                    End If
                Catch
                    GoTo CAMERROR
                End Try

                _camera_present = True
                _ximage = xr
                _yimage = yr

                Select Case __CameraMode
                    Case 1, 3
                        _nbits = 11
                        _I_max = 2047
                    Case 2, 4
                        _nbits = 12
                        _I_max = 4095
                    Case 5
                        _nbits = 16
                        _I_max = 65535
                End Select
            Case Else
                'no valid camera type or in case of error
CAMERROR:
                _nbits = 12
                _I_max = 4095
                _ximage = 1392
                _yimage = 1040
                _camera_present = False
        End Select

        'Dimension image buffers according to image size
        ReDim _bit32(_ximage * _yimage - 1)
        ReDim _temp32(_ximage * _yimage - 1)
        ReDim _bytes(_ximage * _yimage - 1)
        ReDim _temp16(_ximage * _yimage - 1)
        ReDim _overexposure_mask(_ximage * _yimage - 1)
        ReDim _underexposure_mask(_ximage * _yimage - 1)

        'initialize brightness correction
        ReDim __BrightnessCorrFactors(_ximage - 1)
        For i As Integer = 0 To UBound(__BrightnessCorrFactors)
            __BrightnessCorrFactors(i) = 1
        Next

        Dim xrange As New NationalInstruments.UI.Range(0, ImageProcessing.Xres)
        BrightnessCompensation.CalibrationGraph.XAxes.Item(0).Range = xrange

        'allocate buffer for screen image
        Dim scan0 As IntPtr = GCHandle.Alloc(_bytes, GCHandleType.Pinned).AddrOfPinnedObject
        _bit8image = New Bitmap(_ximage, _yimage, _ximage, PixelFormat.Format8bppIndexed, scan0)

        'Ensure that color palette is correctly initialized
        SetContrast(0, 255)
    End Sub

    'checks wether camera is busy
    Public Shared Function IsRecording() As Boolean

        If ImageRecordingTask.IsBusy Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Sub PresentImageSetPixel(x As Integer, y As Integer, value As Byte)

        _bytes(y * _ximage + x) = value
    End Sub

    'records one image, calculates screen and histogram
    Public Shared Sub Record_one_image(ByVal exposure As UShort, scanningmode As Scanningmode)

        If Not __HDRIon Then
            'record 16bit image
            GetCameraImage(exposure, scanningmode)
            Parallel.For(0, _ximage * _yimage - 1,
            Sub(i)
                If __ShowOverExposed Or __ShowUnderExposed Then
                    If _bit32(i) > _I_max * __OverExoposureLimit * 0.01 Then
                        _overexposure_mask(i) = True
                        _underexposure_mask(i) = False
                    ElseIf _bit32(i) < _I_max * __UnderExposureLimit * 0.01 Then
                        _overexposure_mask(i) = False
                        _underexposure_mask(i) = True
                    Else
                        _overexposure_mask(i) = False
                        _underexposure_mask(i) = False
                    End If
                End If

                'Perform brightness shift correction
                If __BrCorrEnabled Then
                    Select Case __BrightnessCorrDirection
                        Case 1
                            _bit32(i) = CUInt(_bit32(i) * __BrightnessCorrFactors(i Mod _ximage))
                        Case 2
                            _bit32(i) = CUInt(_bit32(i) * __BrightnessCorrFactors(i \ _ximage))
                    End Select
                End If
            End Sub)
        Else
            'record first HDRI image
            GetCameraImage(CUShort(exposure \ __HRratio), scanningmode) 'short illumination first
            Parallel.For(0, _ximage * _yimage - 1,
            Sub(i)
                _temp32(i) = _bit32(i)
                If __ShowOverExposed Or __ShowUnderExposed Then
                    If _temp32(i) > _I_max * __OverExoposureLimit * 0.01 Then
                        _overexposure_mask(i) = True
                    Else
                        _overexposure_mask(i) = False
                    End If
                End If
            End Sub)

            'record second HDRI image
            GetCameraImage(CUShort(exposure), scanningmode) 'long illumination image

            Parallel.For(0, _ximage * _yimage - 1,
            Sub(i)
                If __ShowOverExposed Or __ShowUnderExposed Then
                    If _bit32(i) < _I_max * __UnderExposureLimit * 0.01 Then
                        _underexposure_mask(i) = True
                    Else
                        _underexposure_mask(i) = False
                    End If
                End If
                If _bit32(i) > (__HDRIclip * 0.01 * _I_max) Then
                    _bit32(i) = _temp32(i) * __HRratio
                End If

                'Perform brightness shift correction
                If __BrCorrEnabled Then
                    Select Case __BrightnessCorrDirection
                        Case 1
                            _bit32(i) = CUInt(_bit32(i) * __BrightnessCorrFactors(i Mod _ximage))
                        Case 2
                            _bit32(i) = CUInt(_bit32(i) * __BrightnessCorrFactors(i \ _ximage))
                    End Select
                End If
            End Sub)
        End If

        'start histogram calculation task
        _hist_input = CType(DataConverter.Convert(_bit32, GetType(Double())), Double())
        _MaxPixel = NationalInstruments.Analysis.Math.ArrayOperation.GetMax(_hist_input)
        _MinPixel = NationalInstruments.Analysis.Math.ArrayOperation.GetMin(_hist_input)
        HistogramCalculationTask.RunWorkerAsync()

        'start screen calculation task
        CalculateScreenTask.RunWorkerAsync()

        Do 'ensure that prvious calculations are finished
            Application.DoEvents() 'is necessary to prevent crash in module image series recording.
        Loop While CalculateScreenTask.IsBusy Or HistogramCalculationTask.IsBusy
    End Sub

    'save a single image as a 8 or 16bit TIFF
    Public Shared Sub Save_TIFF16(ByVal data() As UInteger, ByVal path As String, fullrange As Boolean)

        Using output As Tiff = Tiff.Open(path, "w")
            output.SetField(TiffTag.IMAGEWIDTH, _ximage)
            output.SetField(TiffTag.IMAGELENGTH, _yimage)
            output.SetField(TiffTag.SAMPLESPERPIXEL, 1)
            output.SetField(TiffTag.BITSPERSAMPLE, 16)
            output.SetField(TiffTag.SAMPLEFORMAT, SampleFormat.UINT) ' line added at 14.7.2016
            output.SetField(TiffTag.ORIENTATION, Orientation.TOPLEFT)
            output.SetField(TiffTag.ROWSPERSTRIP, _yimage)
            output.SetField(TiffTag.XRESOLUTION, 118.0)
            output.SetField(TiffTag.YRESOLUTION, 118.0)
            output.SetField(TiffTag.RESOLUTIONUNIT, ResUnit.CENTIMETER)
            output.SetField(TiffTag.PLANARCONFIG, PlanarConfig.CONTIG)
            output.SetField(TiffTag.PHOTOMETRIC, Photometric.MINISBLACK)
            output.SetField(TiffTag.COMPRESSION, Compression.LZW)
            output.SetField(TiffTag.FILLORDER, FillOrder.MSB2LSB)
            output.SetField(TiffTag.SAMPLEFORMAT, BitMiracle.LibTiff.Classic.SampleFormat.UINT)

            Dim scanline(_ximage - 1) As UShort
            Dim buf(scanline.Length * 2 - 1) As Byte
            Dim row, col As Integer

            Dim factor As UShort
            If fullrange Then
                factor = CUShort(2 ^ (16 - ImageProcessing.GetNBits))
            Else
                factor = 1
            End If

            Dim pixel As Double
            For row = 0 To _yimage - 1
                For col = 0 To _ximage - 1
                    pixel = data(row * _ximage + col) * factor
                    'protect against large values
                    If pixel > 65535 Then
                        pixel = 65535
                    End If
                    scanline(col) = CUShort(pixel)
                Next
                Buffer.BlockCopy(scanline, 0, buf, 0, buf.Length)
                output.WriteScanline(buf, row)
            Next
        End Using
    End Sub

    Public Shared Sub Save_TiffUint32(ByVal data() As UInteger, ByVal path As String)

        Using output As Tiff = Tiff.Open(path, "w")
            output.SetField(TiffTag.IMAGEWIDTH, _ximage)
            output.SetField(TiffTag.IMAGELENGTH, _yimage)
            output.SetField(TiffTag.SAMPLESPERPIXEL, 1)
            output.SetField(TiffTag.BITSPERSAMPLE, 32)
            output.SetField(TiffTag.SAMPLEFORMAT, SampleFormat.IEEEFP)
            output.SetField(TiffTag.ORIENTATION, Orientation.TOPLEFT)
            output.SetField(TiffTag.ROWSPERSTRIP, _yimage)
            output.SetField(TiffTag.XRESOLUTION, 118.0)
            output.SetField(TiffTag.YRESOLUTION, 118.0)
            output.SetField(TiffTag.RESOLUTIONUNIT, ResUnit.CENTIMETER)
            output.SetField(TiffTag.PLANARCONFIG, PlanarConfig.CONTIG)
            output.SetField(TiffTag.PHOTOMETRIC, Photometric.MINISBLACK)
            output.SetField(TiffTag.COMPRESSION, Compression.LZW)
            output.SetField(TiffTag.FILLORDER, FillOrder.MSB2LSB)
            output.SetField(TiffTag.SAMPLEFORMAT, BitMiracle.LibTiff.Classic.SampleFormat.UINT)

            Dim scanline(_ximage - 1) As UInt32
            Dim buf(scanline.Length * 4 - 1) As Byte
            Dim row, col As Integer

            For row = 0 To _yimage - 1
                For col = 0 To _ximage - 1
                    scanline(col) = CUInt(data(row * _ximage + col))
                Next
                Buffer.BlockCopy(scanline, 0, buf, 0, buf.Length)
                output.WriteScanline(buf, row)
            Next
        End Using
    End Sub

    'set contrast of display
    Public Shared Sub SetContrast(ByVal Imin As Integer, ByVal Imax As Integer)

        Dim z As Byte
        Dim PT As System.Drawing.Imaging.ColorPalette = _bit8image.Palette

        For i As Integer = 0 To 255
            If i < Imin Then
                z = 0
            ElseIf i > Imax Then
                z = 254
            Else
                z = CByte((i - Imin) / (Imax - Imin) * 254)
            End If
            PT.Entries(i) = Color.FromArgb(z, z, z)
        Next

        If __ShowUnderExposed Then
            PT.Entries(0) = Color.FromArgb(0, 0, 255)
        End If
        If __ShowOverExposed Then
            PT.Entries(255) = Color.FromArgb(255, 0, 0)
        End If

        _bit8image.Palette = PT
    End Sub

    Public Shared Sub UpdateScreen()

        'refresh image
        MainForm.MyViewerWindow.SetImage(_bit8image)

        ' stack size in recording window
        If RecordingWindow.Visible Then
            RecordingWindow.xyvoxel.Text = __xyVoxelsize.ToString & " µm"
            RecordingWindow.zvoxel.Text = __zVoxelsize.ToString & " µm"
            RecordingWindow.Stacksize.Text = CStr(CInt(RecordingWindow.NumberOfImages.Value * __zVoxelsize)) & " µm"
        End If

        'Update Intensity Histogram
        MainForm.IntensityDistribution.PlotXY(_cw, _log_histogram)
        MainForm.MinIntensityBox.Text = Math.Round(_MinPixel, 0).ToString
        MainForm.MaxIntensityBox.Text = Math.Round(_MaxPixel, 0).ToString

        Application.DoEvents()
    End Sub

    'background task for screen calculation, transfers data to 8bit screen image
    Private Shared Sub CalculateScreenTask_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)

        Dim f As Double = 254 / _I_max

        If __HDRIon Then
            f /= __HRratio
        End If

        If __BrCorrEnabled AndAlso Not __BrCorrClip16 Then 'clipping of displayed values instead of adapting the multipliocation fator if BRCORR_CLIP16 is set to true
            f /= __BrightnessCorrFactorsMax
        End If

        Parallel.For(0, _ximage * _yimage - 1,
        Sub(i)
            If __ShowOverExposed AndAlso _overexposure_mask(i) Then
                _bytes(i) = 255
            ElseIf __ShowUnderExposed AndAlso _underexposure_mask(i) Then
                _bytes(i) = 0
            Else
                Dim value As Double = Int(_bit32(i) * f) 'can be > 255 if BRCORR_CLIP16 enabled. Definition von value innerhalb der Schleife erforderlich.
                If value > 254 Then
                    _bytes(i) = 254
                Else
                    _bytes(i) = CByte(value)
                End If

            End If
        End Sub)

        DrawScalebar()
    End Sub

    Private Shared Sub DrawScalebar()

        Dim barlen As Integer
        If __ScalebarLength > 0 Then
            Select Case __ScalebarLength
                Case 1
                    barlen = 20
                Case 2
                    barlen = 50
                Case 3
                    barlen = 100
                Case 4
                    barlen = 200
                Case 5
                    barlen = 500
                Case 6
                    barlen = 750
                Case 7
                    barlen = 1000
            End Select

            Dim laenge As Integer = CInt(barlen / __xyVoxelsize)
            Dim xstart As Integer = 60
            Dim ystart As Integer = _yimage - 68
            Dim breite As Integer = 3

            For j As Integer = ystart To ystart + breite
                For i As Integer = j * _ximage + xstart To j * _ximage + xstart + laenge
                    _bytes(i) = 254
                Next
            Next
        End If
    End Sub

    Private Shared Sub GenerateTestPattern()

        Static start As Integer = 0

        Dim line As Integer
        Dim bk As UShort = 100

        For i As Integer = 0 To (_ximage * _yimage) - 1
            line = i \ _ximage
            If (line >= start) And (line < start + 150) Then
                _bit32(i) = CUShort(((i Mod _ximage) * 2.5 + bk))
            Else
                _bit32(i) = bk
            End If
        Next

        start += 10
        If start > _yimage - 150 Then start = 0
    End Sub

    Private Shared Sub GrabMultiscanImage3(ByVal image() As UShort, exposure As UShort)

        Dim img1(_ximage * _yimage - 1), img2(_ximage * _yimage - 1), img3(_ximage * _yimage - 1) As UShort

        Dim StripeWidth As Double
        If Not __CameraIsRotated Then
            StripeWidth = __xyVoxelsize * _ximage / 10
        Else
            StripeWidth = __xyVoxelsize * _yimage / 10
        End If

        'get image left from center (img1)
        Select Case RecordingWindow.RecordingModeBox.SelectedIndex
            Case RecordingWindow.IlluminationDirection.LeftSided
                LinearStage.MoveLeft(LinearStage.SelectStage.LeftStage, 3 * StripeWidth / 1000)
            Case RecordingWindow.IlluminationDirection.RightSided
                LinearStage.MoveRight(LinearStage.SelectStage.RightStage, 3 * StripeWidth / 1000)
            Case RecordingWindow.IlluminationDirection.DoubleSided
                LinearStage.MoveLeft(LinearStage.SelectStage.LeftStage, 3 * StripeWidth / 1000)
                LinearStage.MoveRight(LinearStage.SelectStage.RightStage, 3 * StripeWidth / 1000)
        End Select
        Application.DoEvents()
        LinearStage.WaitUntilFinished(LinearStage.SelectStage.LeftStage)
        LinearStage.WaitUntilFinished(LinearStage.SelectStage.RightStage)
        Utilities.Wait(__WaitForStages)
        NativeMethods.GrabImage(img1, exposure)

        'get image right from center (img3)
        Select Case RecordingWindow.RecordingModeBox.SelectedIndex
            Case RecordingWindow.IlluminationDirection.LeftSided
                LinearStage.MoveRight(LinearStage.SelectStage.LeftStage, 6 * StripeWidth / 1000)
            Case RecordingWindow.IlluminationDirection.RightSided
                LinearStage.MoveLeft(LinearStage.SelectStage.RightStage, 6 * StripeWidth / 1000)
            Case RecordingWindow.IlluminationDirection.DoubleSided
                LinearStage.MoveRight(LinearStage.SelectStage.LeftStage, 6 * StripeWidth / 1000)
                LinearStage.MoveLeft(LinearStage.SelectStage.RightStage, 6 * StripeWidth / 1000)
        End Select

        Application.DoEvents()
        LinearStage.WaitUntilFinished(LinearStage.SelectStage.LeftStage)
        LinearStage.WaitUntilFinished(LinearStage.SelectStage.RightStage)
        Utilities.Wait(__WaitForStages)
        NativeMethods.GrabImage(img3, exposure)

        'get image at center (img2)
        Select Case RecordingWindow.RecordingModeBox.SelectedIndex
            Case RecordingWindow.IlluminationDirection.LeftSided
                LinearStage.MoveLeft(LinearStage.SelectStage.LeftStage, 3 * StripeWidth / 1000)
            Case RecordingWindow.IlluminationDirection.RightSided
                LinearStage.MoveRight(LinearStage.SelectStage.RightStage, 3 * StripeWidth / 1000)
            Case RecordingWindow.IlluminationDirection.DoubleSided
                LinearStage.MoveLeft(LinearStage.SelectStage.LeftStage, 3 * StripeWidth / 1000)
                LinearStage.MoveRight(LinearStage.SelectStage.RightStage, 3 * StripeWidth / 1000)
        End Select

        Application.DoEvents()
        LinearStage.WaitUntilFinished(LinearStage.SelectStage.LeftStage)
        LinearStage.WaitUntilFinished(LinearStage.SelectStage.RightStage)
        Utilities.Wait(__WaitForStages)
        NativeMethods.GrabImage(img2, exposure)

        'combine the  image regions in focus
        Select Case __CameraIsRotated
            Case False
                Dim x1, x2, index As Integer
                Dim a As Double
                For j As Integer = 0 To _yimage - 1
                    x1 = 0 : x2 = CInt(3 / 10 * _ximage)
                    For i As Integer = x1 To x2 - 1
                        index = j * _ximage + i
                        image(index) = img1(index)
                    Next
                    x1 = x2 : x2 = CInt(4 / 10 * _ximage)
                    For i As Integer = x1 To x2 - 1
                        a = (i - x1) / (x2 - x1 - 1)
                        index = j * _ximage + i
                        image(index) = CUShort((1 - a) * img1(index) + a * img2(index))
                        'image(index) = CUShort((img1(index) + img2(index)) / 2)
                    Next
                    x1 = x2 : x2 = CInt(6 / 10 * _ximage)
                    For i As Integer = x1 To x2 - 1
                        index = j * _ximage + i
                        image(index) = img2(index)
                    Next
                    x1 = x2 : x2 = CInt(7 / 10 * _ximage)
                    For i As Integer = x1 To x2 - 1
                        a = (i - x1) / (x2 - x1 - 1)
                        index = j * _ximage + i
                        image(index) = CUShort((1 - a) * img2(index) + a * img3(index))
                        'image(index) = CUShort((img2(index) + img3(index)) / 2)
                    Next
                    x1 = x2 : x2 = _ximage
                    For i As Integer = x1 To x2 - 1
                        index = j * _ximage + i
                        image(index) = img3(index)
                    Next
                Next

            Case True
                Dim y1, y2, index As Integer
                Dim a As Double

                For j As Integer = 0 To _ximage - 1
                    y1 = 0 : y2 = CInt(3 / 10 * _yimage)
                    For i As Integer = y1 To y2 - 1
                        index = i * _ximage + j
                        image(index) = img1(index)
                    Next
                    y1 = y2 : y2 = CInt(4 / 10 * _yimage)
                    For i As Integer = y1 To y2 - 1
                        a = (i - y1) / (y2 - y1 - 1)
                        index = i * _ximage + j
                        image(index) = CUShort((1 - a) * img1(index) + a * img2(index))
                    Next
                    y1 = y2 : y2 = CInt(6 / 10 * _yimage)
                    For i As Integer = y1 To y2 - 1
                        index = i * _ximage + j
                        image(index) = img2(index)
                    Next
                    y1 = y2 : y2 = CInt(7 / 10 * _yimage)
                    For i As Integer = y1 To y2 - 1
                        a = (i - y1) / (y2 - y1 - 1)
                        index = i * _ximage + j
                        image(index) = CUShort((1 - a) * img2(index) + a * img3(index))
                    Next
                    y1 = y2 : y2 = _yimage
                    For i As Integer = y1 To y2 - 1
                        index = i * _ximage + j
                        image(index) = img3(index)
                    Next
                Next
        End Select
    End Sub

    Private Shared Sub GrabMultiscanImage5(ByVal image() As UShort, exposure As UShort)

        Dim img1(_ximage * _yimage - 1), img2(_ximage * _yimage - 1), img3(_ximage * _yimage - 1), img4(_ximage * _yimage - 1),
        img5(_ximage * _yimage - 1) As UShort

        Dim StripeWidth As Double
        If Not __CameraIsRotated Then
            StripeWidth = __xyVoxelsize * _ximage / 16
        Else
            StripeWidth = __xyVoxelsize * _yimage / 16
        End If

        'get img2
        Select Case RecordingWindow.RecordingModeBox.SelectedIndex
            Case RecordingWindow.IlluminationDirection.LeftSided
                LinearStage.MoveLeft(LinearStage.SelectStage.LeftStage, 3 * StripeWidth / 1000)
            Case RecordingWindow.IlluminationDirection.RightSided
                LinearStage.MoveRight(LinearStage.SelectStage.RightStage, 3 * StripeWidth / 1000)
            Case RecordingWindow.IlluminationDirection.DoubleSided
                LinearStage.MoveLeft(LinearStage.SelectStage.LeftStage, 3 * StripeWidth / 1000)
                LinearStage.MoveRight(LinearStage.SelectStage.RightStage, 3 * StripeWidth / 1000)
        End Select
        Application.DoEvents()
        LinearStage.WaitUntilFinished(LinearStage.SelectStage.LeftStage)
        LinearStage.WaitUntilFinished(LinearStage.SelectStage.RightStage)

        Utilities.Wait(__WaitForStages)
        NativeMethods.GrabImage(img2, exposure)

        'get img 1
        Select Case RecordingWindow.RecordingModeBox.SelectedIndex
            Case RecordingWindow.IlluminationDirection.LeftSided
                LinearStage.MoveLeft(LinearStage.SelectStage.LeftStage, 3 * StripeWidth / 1000)
            Case RecordingWindow.IlluminationDirection.RightSided
                LinearStage.MoveRight(LinearStage.SelectStage.RightStage, 3 * StripeWidth / 1000)
            Case RecordingWindow.IlluminationDirection.DoubleSided
                LinearStage.MoveLeft(LinearStage.SelectStage.LeftStage, 3 * StripeWidth / 1000)
                LinearStage.MoveRight(LinearStage.SelectStage.RightStage, 3 * StripeWidth / 1000)
        End Select

        Application.DoEvents()
        LinearStage.WaitUntilFinished(LinearStage.SelectStage.LeftStage)
        LinearStage.WaitUntilFinished(LinearStage.SelectStage.RightStage)
        Utilities.Wait(__WaitForStages)

        NativeMethods.GrabImage(img1, exposure)

        'get img 5
        Select Case RecordingWindow.RecordingModeBox.SelectedIndex
            Case RecordingWindow.IlluminationDirection.LeftSided
                LinearStage.MoveRight(LinearStage.SelectStage.LeftStage, 12 * StripeWidth / 1000)
            Case RecordingWindow.IlluminationDirection.RightSided
                LinearStage.MoveLeft(LinearStage.SelectStage.RightStage, 12 * StripeWidth / 1000)
            Case RecordingWindow.IlluminationDirection.DoubleSided
                LinearStage.MoveRight(LinearStage.SelectStage.LeftStage, 12 * StripeWidth / 1000)
                LinearStage.MoveLeft(LinearStage.SelectStage.RightStage, 12 * StripeWidth / 1000)
        End Select

        Application.DoEvents()
        LinearStage.WaitUntilFinished(LinearStage.SelectStage.LeftStage)
        LinearStage.WaitUntilFinished(LinearStage.SelectStage.RightStage)
        Utilities.Wait(__WaitForStages)
        NativeMethods.GrabImage(img5, exposure)

        'get img 4
        Select Case RecordingWindow.RecordingModeBox.SelectedIndex
            Case RecordingWindow.IlluminationDirection.LeftSided
                LinearStage.MoveLeft(LinearStage.SelectStage.LeftStage, 3 * StripeWidth / 1000)
            Case RecordingWindow.IlluminationDirection.RightSided
                LinearStage.MoveRight(LinearStage.SelectStage.RightStage, 3 * StripeWidth / 1000)
            Case RecordingWindow.IlluminationDirection.DoubleSided
                LinearStage.MoveLeft(LinearStage.SelectStage.LeftStage, 3 * StripeWidth / 1000)
                LinearStage.MoveRight(LinearStage.SelectStage.RightStage, 3 * StripeWidth / 1000)
        End Select

        Application.DoEvents()
        LinearStage.WaitUntilFinished(LinearStage.SelectStage.LeftStage)
        LinearStage.WaitUntilFinished(LinearStage.SelectStage.RightStage)
        Utilities.Wait(__WaitForStages)
        NativeMethods.GrabImage(img4, exposure)

        'get img 3 (center image)
        Select Case RecordingWindow.RecordingModeBox.SelectedIndex
            Case RecordingWindow.IlluminationDirection.LeftSided
                LinearStage.MoveLeft(LinearStage.SelectStage.LeftStage, 3 * StripeWidth / 1000)
            Case RecordingWindow.IlluminationDirection.RightSided
                LinearStage.MoveRight(LinearStage.SelectStage.RightStage, 3 * StripeWidth / 1000)
            Case RecordingWindow.IlluminationDirection.DoubleSided
                LinearStage.MoveLeft(LinearStage.SelectStage.LeftStage, 3 * StripeWidth / 1000)
                LinearStage.MoveRight(LinearStage.SelectStage.RightStage, 3 * StripeWidth / 1000)
        End Select

        Application.DoEvents()
        LinearStage.WaitUntilFinished(LinearStage.SelectStage.LeftStage)
        LinearStage.WaitUntilFinished(LinearStage.SelectStage.RightStage)
        Utilities.Wait(__WaitForStages)

        NativeMethods.GrabImage(img3, exposure)

        'combine the  image regions in focus
        Select Case __CameraIsRotated
            Case False
                Dim x1, x2, index As Integer
                Dim a As Double
                For j As Integer = 0 To _yimage - 1
                    x1 = 0 : x2 = CInt(3 / 16 * _ximage) '0 to 3/16
                    For i As Integer = x1 To x2 - 1
                        index = j * _ximage + i
                        image(index) = img1(index)
                    Next
                    x1 = x2 : x2 = CInt(4 / 16 * _ximage) '3/16 to 4/16
                    For i As Integer = x1 To x2 - 1
                        a = (i - x1) / (x2 - x1 - 1)
                        index = j * _ximage + i
                        image(index) = CUShort((1 - a) * img1(index) + a * img2(index))
                        'image(index) = CUShort((img1(index) + img2(index)) / 2)
                    Next
                    x1 = x2 : x2 = CInt(6 / 16 * _ximage) '4/16 to 6/16
                    For i As Integer = x1 To x2 - 1
                        index = j * _ximage + i
                        image(index) = img2(index)
                    Next
                    x1 = x2 : x2 = CInt(7 / 16 * _ximage) '6/16 to 7/16
                    For i As Integer = x1 To x2 - 1
                        a = (i - x1) / (x2 - x1 - 1)
                        index = j * _ximage + i
                        image(index) = CUShort((1 - a) * img2(index) + a * img3(index))
                        'image(index) = CUShort((img2(index) + img3(index)) / 2)
                    Next
                    x1 = x2 : x2 = CInt(9 / 16 * _ximage) '7/16 to 9/16
                    For i As Integer = x1 To x2 - 1
                        index = CInt(j * _ximage + i)
                        image(index) = img3(index)
                    Next
                    x1 = x2 : x2 = CInt(10 / 16 * _ximage) '9/16 to 10/16
                    For i As Integer = x1 To x2 - 1
                        a = (i - x1) / (x2 - x1 - 1)
                        index = j * _ximage + i
                        image(index) = CUShort((1 - a) * img3(index) + a * img4(index))
                        'image(index) = CUShort((img3(index) + img4(index)) / 2)
                    Next
                    x1 = x2 : x2 = CInt(12 / 16 * _ximage) '10/16 to 12/16
                    For i As Integer = x1 To x2 - 1
                        index = j * _ximage + i
                        image(index) = img4(index)
                    Next
                    x1 = x2 : x2 = CInt(13 / 16 * _ximage) '12/16 to 13/16
                    For i As Integer = x1 To x2 - 1
                        a = (i - x1) / (x2 - x1 - 1)
                        index = j * _ximage + i
                        image(index) = CUShort((1 - a) * img4(index) + a * img5(index))
                        'image(index) = CUShort((img4(index) + img5(index)) / 2)
                    Next
                    x1 = x2 : x2 = _ximage
                    For i As Integer = x1 To x2 - 1 '13/16 to 16/16
                        index = j * _ximage + i
                        image(index) = img5(index)
                    Next
                Next

            Case True
                Dim y1, y2, index As Integer
                Dim a As Double
                For j As Integer = 0 To _ximage - 1
                    y1 = 0 : y2 = CInt(3 / 16 * _yimage) '0 to 3/16
                    For i As Integer = y1 To y2 - 1
                        index = i * _ximage + j
                        image(index) = img1(index)
                    Next
                    y1 = y2 : y2 = CInt(4 / 16 * _yimage) '3/16 to 4/16
                    For i As Integer = y1 To y2 - 1
                        a = (i - y1) / (y2 - y1 - 1)
                        index = i * _ximage + j
                        image(index) = CUShort((1 - a) * img1(index) + a * img2(index))
                    Next
                    y1 = y2 : y2 = CInt(6 / 16 * _yimage) '4/16 to 6/16
                    For i As Integer = y1 To y2 - 1
                        index = i * _ximage + j
                        image(index) = img2(index)
                    Next
                    y1 = y2 : y2 = CInt(7 / 16 * _yimage) '6/16 to 7/16
                    For i As Integer = y1 To y2 - 1
                        a = (i - y1) / (y2 - y1 - 1)
                        index = i * _ximage + j
                        image(index) = CUShort((1 - a) * img2(index) + a * img3(index))
                    Next
                    y1 = y2 : y2 = CInt(9 / 16 * _yimage) '7/16 to 9/16
                    For i As Integer = y1 To y2 - 1
                        index = CInt(i * _ximage + j)
                        image(index) = img3(index)
                    Next
                    y1 = y2 : y2 = CInt(10 / 16 * _yimage) '9/16 to 10/16
                    For i As Integer = y1 To y2 - 1
                        a = (i - y1) / (y2 - y1 - 1)
                        index = i * _ximage + j
                        image(index) = CUShort((1 - a) * img3(index) + a * img4(index))
                    Next
                    y1 = y2 : y2 = CInt(12 / 16 * _yimage) '10/16 to 12/16
                    For i As Integer = y1 To y2 - 1
                        index = i * _ximage + j
                        image(index) = img4(index)
                    Next
                    y1 = y2 : y2 = CInt(13 / 16 * _yimage) '12/16 to 13/16
                    For i As Integer = y1 To y2 - 1
                        a = (i - y1) / (y2 - y1 - 1)
                        index = i * _ximage + j
                        image(index) = CUShort((1 - a) * img4(index) + a * img5(index))
                    Next
                    y1 = y2 : y2 = _yimage
                    For i As Integer = y1 To y2 - 1 '13/16 to 16/16
                        index = i * _ximage + j
                        image(index) = img5(index)
                    Next
                Next
        End Select
    End Sub

    'background task for histogram calculation
    Private Shared Sub HistogramCalculationTask_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)

        Dim histogram() As Integer = NationalInstruments.Analysis.Math.Statistics.Histogram(_hist_input, 0, _MaxPixel, _numclasses, _cw)

        For i As Integer = 0 To UBound(histogram)
            If histogram(i) > 0 Then
                _log_histogram(i) = Math.Log10(histogram(i))
            Else
                _log_histogram(i) = 0
            End If
        Next
    End Sub

    'background task for image recording loop
    Private Shared Sub ImageRecordingTask_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)

        Do
            ImageProcessing.Record_one_image(__CurrentExposure, Scanningmode.singlescan)
            ImageRecordingTask.ReportProgress(0)
        Loop Until _image_recording_stopped
    End Sub

    'evoked from background process after each recorded image - does update of GUI
    Private Shared Sub ImageRecordingTask_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs)

        UpdateScreen()
    End Sub

End Class