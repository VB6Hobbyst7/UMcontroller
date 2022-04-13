Public Class RecordingWindow
    Public _Imin_Global, _Imax_Global As Double

    Public Enum IlluminationDirection
        LeftSided = 0
        RightSided = 1
        DoubleSided = 2
    End Enum

    Private Sub AddToList(item As String)

        If FolderList.Items.Count > 25 Then
            FolderList.Items.RemoveAt(0)
        End If

        FolderList.Items.Add(item)
        FolderList.SelectedIndex = FolderList.Items.Count - 1
        WriteFileList()
    End Sub

    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click

        Me.Hide()
    End Sub

    Private Sub CheckCameraRotated_CheckedChanged(sender As Object, e As EventArgs) Handles CheckCameraRotated.CheckedChanged

        If CheckCameraRotated.Checked Then
            __CameraIsRotated = True
        Else
            __CameraIsRotated = False
        End If
    End Sub

    Private Sub NumberOfImages_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumberOfImages.ValueChanged

        Stacksize.Text = CStr(NumberOfImages.Value * __zVoxelsize)
    End Sub

    Private Sub ReadFileList()

        Dim appPath As String = Application.StartupPath()
        Dim fname As String = appPath & "\PathInfo.dat"
        Dim finfo As New System.IO.FileInfo(fname)

        Try
            If finfo.Exists Then
                Dim reader As New System.IO.StreamReader(fname)

                FolderList.Items.Clear()
                While Not reader.EndOfStream
                    FolderList.Items.Add(reader.ReadLine)
                End While
                reader.Close()
            Else
                FolderList.Items.Add(Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString)
            End If
        Catch
            ImageProcessing.ImageRecordingTaskStop()
            Utilities.TopMostMessageBox("ERROR", "Error reading file path list!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ImageProcessing.ImagerecordingTaskStart()
        End Try
    End Sub

    Private Sub RecordingWindow_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        SelectFolderDialog.RootFolder = Environment.SpecialFolder.Desktop
        SelectFolderDialog.ShowNewFolderButton = True
        SelectFolderDialog.Description = "Please select directory where new image folder should be stored"

        ReadFileList()
        If FolderList.Items.Count = 0 Then
            FolderList.Items.Add(Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString)
        End If
        FolderList.SetSelected(FolderList.Items.Count - 1, True)
    End Sub

    Private Sub RemoveItem_Click(sender As Object, e As EventArgs) Handles RemoveItem.Click

        Dim index As Integer
        If FolderList.Items.Count > 0 Then
            index = FolderList.SelectedIndex
            FolderList.Items.RemoveAt(index)
        End If
        If FolderList.Items.Count = 0 Then
            FolderList.Items.Add(Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString)
            FolderList.SelectedIndex = 0
        End If
        If index <= FolderList.Items.Count - 1 Then
            FolderList.SelectedIndex = index
        Else
            FolderList.SelectedIndex = index - 1
        End If

        WriteFileList()
    End Sub

    Private Sub SelectFolderButton_Click(sender As Object, e As EventArgs) Handles SelectFolderButton.Click

        Dim path As String
        Dim result As DialogResult = SelectFolderDialog.ShowDialog()

        If result = Windows.Forms.DialogResult.OK Then
            path = SelectFolderDialog.SelectedPath
            Dim dir As New System.IO.DirectoryInfo(path)
            If dir.Exists Then
                AddToList(path)
            End If
        End If
    End Sub

    Private Sub StartRecording_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartRecording.Click

        Dim i, j, k As Integer
        Dim name, fname As String
        Dim DIRPATH As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString
        Dim RecordingList(4) As Integer
        Dim angle As Double

        'check for at least 50GB free disk space otherwise exit
        Dim driveinfo As New System.IO.DriveInfo(DIRPATH.Substring(0, 2))
        If driveinfo.AvailableFreeSpace < 20 * 1000000000.0 Then
            Utilities.TopMostMessageBox("ERROR", "There are less than 20GB free space on the selected drive! Please clean up first!!!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim DirPathInfo As New IO.DirectoryInfo(FolderList.SelectedItem.ToString + "\")
        DIRPATH = FolderList.SelectedItem.ToString + "\" + DirName.Text.Trim + "\"
        Dim dir As New System.IO.DirectoryInfo(DIRPATH)

        Try
            If Not DirPathInfo.Exists Then
                ImageProcessing.ImageRecordingTaskStop()
                Utilities.TopMostMessageBox("ERROR", "Selected path cannot be accessed. Perhaps network drive is not ready!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ImageProcessing.ImagerecordingTaskStart()
                Exit Sub
            End If
            If dir.Exists Or DirName.Text.Trim = "" Then
                ImageProcessing.ImageRecordingTaskStop()
                Utilities.TopMostMessageBox("ERROR", "Directory already exists!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ImageProcessing.ImagerecordingTaskStart()
                Exit Sub
            End If
        Catch
            ImageProcessing.ImageRecordingTaskStop()
            Utilities.TopMostMessageBox("ERROR", "Cannot create data folder!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ImageProcessing.ImagerecordingTaskStart()
            Exit Sub
        End Try

        'update various buttons
        MainForm.StartButton.BackColor = Color.Red
        MainForm.StartButton.Text = "Rec"

        'create parent directory
        dir.Create()

        'Angle for cover slide scanning
        angle = CoverSlideAngle.Value * Math.PI / 180.0

        'z-correction
        Dim deltaZ As Double = Gradient.Value * __zVoxelsize '(ms / µm)
        Dim deltaZtot As Double = 0

        Dim StepperWaitTime As Integer = CInt(Settings.StepperWaittime.Value)

        Me.Hide()
        'stop camera background recording mode
        ImageProcessing.ImageRecordingTaskStop()

        'Min/Max values in entire stack
        _Imax_Global = Integer.MinValue
        _Imin_Global = Integer.MaxValue

        'begin stack recording
        For i = CInt(StartNumber.Value - 1) To CInt(StartNumber.Value + NumberOfImages.Value - 2)

            'refresh various controls in main window
            MainForm.ImageNumberBox.Text = (i + 1).ToString

            'wait additional time for specimen chamber to be quiet
            Utilities.Wait(StepperWaitTime)

            'ensure that all MICOS devices have stopped moving before recording
            Stepper.WaitUntilFinished()
            LinearStage.WaitUntilFinished(LinearStage.SelectStage.LeftStage)
            LinearStage.WaitUntilFinished(LinearStage.SelectStage.RightStage)

            'record next image
            Select Case ScanningModeBox.SelectedIndex
                Case 0
                    ImageProcessing.Record_one_image(CUShort(__CurrentExposure - deltaZtot), ImageProcessing.Scanningmode.singlescan)
                Case 1
                    ImageProcessing.Record_one_image(CUShort(__CurrentExposure - deltaZtot), ImageProcessing.Scanningmode.multiscan3)
                Case 2
                    ImageProcessing.Record_one_image(CUShort(__CurrentExposure - deltaZtot), ImageProcessing.Scanningmode.multiscan5)
            End Select
            ImageProcessing.UpdateScreen()

            'transfer image to BUFFER and trigger update of camera display
            MainForm.MyViewerWindow.SetImage(ImageProcessing.PresentImage)

            'Save image to disk
            name = (i + 1).ToString
            While name.Length < 5
                name = "0" & name
            End While
            fname = DIRPATH & name & ".tif"

            'find global min and max
            For k = 0 To ImageProcessing.Xres * ImageProcessing.Yres - 1
                If ImageProcessing.Bit32Data(k) > _Imax_Global Then
                    _Imax_Global = ImageProcessing.Bit32Data(k)
                ElseIf ImageProcessing.Bit32Data(k) < _Imin_Global Then
                    _Imin_Global = ImageProcessing.Bit32Data(k)
                End If
            Next

            If Not (__HDRIon Or __BrCorrEnabled) Then
                ImageProcessing.Save_TIFF16(ImageProcessing.Bit32Data, fname, Settings.SaveFullRangeCheckBox.Checked)
            Else
                ImageProcessing.Save_TiffUint32(ImageProcessing.Bit32Data, fname)
            End If

            'Stop: if ESC-key has been pressed exit the recording loop
            If KeyPressed(27) Then
                Dim answer As DialogResult
                answer = Utilities.TopMostMessageBox("ALERT", "Realy stop recording?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If answer = DialogResult.Yes Then
                    GoTo RECORDING_STOPPED
                End If
            End If

            'Increment z-correction factor:
            deltaZtot += deltaZ

            'move stepper one step down
            Stepper.StepRel(-__zVoxelsize * 0.001) 'convert to mm
            MainForm.JackPosDispl.Value = Stepper.GetStepperPos()

            'shift cylinder lens in case of cover slide recording
            If angle < 0 Then
                Select Case Me.RecordingModeBox.SelectedIndex
                    Case IlluminationDirection.LeftSided
                        LinearStage.MoveLeft(LinearStage.SelectStage.LeftStage, __zVoxelsize * Math.Tan(-angle) / 1000)
                    Case IlluminationDirection.RightSided
                        LinearStage.MoveLeft(LinearStage.SelectStage.RightStage, __zVoxelsize * Math.Tan(-angle) / 1000)
                End Select
            ElseIf angle > 0 Then
                Select Case Me.RecordingModeBox.SelectedIndex
                    Case IlluminationDirection.LeftSided
                        LinearStage.MoveRight(LinearStage.SelectStage.LeftStage, __zVoxelsize * Math.Tan(angle) / 1000)
                    Case IlluminationDirection.RightSided
                        LinearStage.MoveRight(LinearStage.SelectStage.RightStage, __zVoxelsize * Math.Tan(angle) / 1000)
                End Select
            End If
        Next

RECORDING_STOPPED:
        'write info-file
        WriteInfoFile(DIRPATH, DirName.Text & ".txt")

        'Restart camera background mode again
        ImageProcessing.ImagerecordingTaskStart()

        'update buttons in control window
        MainForm.StartButton.Text = "Start"
        MainForm.StartButton.BackColor = Color.LightGray
    End Sub

    Private Sub WriteFileList()

        Dim appPath As String = Application.StartupPath()
        Dim fname As String = appPath & "\PathInfo.dat"
        Dim writer As New System.IO.StreamWriter(fname, False)

        Try
            Dim i As Integer
            For i = 0 To FolderList.Items.Count - 1
                writer.WriteLine(FolderList.Items(i))
            Next
            writer.Close()
        Catch
            ImageProcessing.ImageRecordingTaskStop()
            Utilities.TopMostMessageBox("ERROR", "Error writing file path list.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ImageProcessing.ImagerecordingTaskStart()
        End Try
    End Sub

    Private Sub WriteInfoFile(ByVal path As String, ByVal name As String)

        Dim logfile As New System.IO.StreamWriter(path & name, False)
        logfile.WriteLine("recording date: " & System.DateTime.Today)
        logfile.WriteLine("projekt number.: " & project.Text)
        logfile.WriteLine("experiment number: " & experiment.Text)
        logfile.WriteLine("specimen number: " & specimen.Text)
        logfile.WriteLine("perfusion date: " & perfusiondate.Text)
        logfile.WriteLine("detail: " & detail.Text)
        logfile.WriteLine("camera resolution: " & ImageProcessing.Xres.ToString & " x " & ImageProcessing.Yres.ToString)
        logfile.WriteLine("voxel size " & __xyVoxelsize.ToString & "µm x " & __xyVoxelsize.ToString & "µm x " & __zVoxelsize.ToString & "µm")

        If __CameraType = ImageProcessing.Cameras.AndorNeo Then
            logfile.WriteLine("AndorNeo")
            Select Case __CameraMode
                Case 0
                    logfile.WriteLine("Gain 1 (11 bit)")
                Case 1
                    logfile.WriteLine("Gain 2 (11 bit)")
                Case 2
                    logfile.WriteLine("Gain 3 (11 bit)")
                Case 3
                    logfile.WriteLine("Gain 4 (11 bit)")
                Case 4
                    logfile.WriteLine("Gain 1 Gain 3 (14 bit)")
                Case 5
                    logfile.WriteLine("Gain 1 Gain 4 (16 bit)")
                Case 6
                    logfile.WriteLine("Gain 2 Gain 3 (14 bit)")
                Case 7
                    logfile.WriteLine("Gain 2 Gain 4 (16 bit)")
            End Select
        End If

        If Settings.SaveFullRangeCheckBox.Checked Then
            logfile.WriteLine("Intensity values expanded to fit full 16 bit range (0-65535")
        End If

        logfile.WriteLine("laser type: " & wavelength.Text)
        logfile.WriteLine("laser power: " & power.Text)
        logfile.WriteLine("microscope: " & microscope.Text)
        logfile.WriteLine("objective: " & objective.Text)
        logfile.WriteLine("post magnification: " & postmagnification.Text)
        logfile.WriteLine("cylindrical lens: " & cylinderlens.Text)
        logfile.Write("illumination direction: ")
        logfile.WriteLine("slit aperture: " & slitaperture.Text)

        Select Case Me.RecordingModeBox.SelectedIndex
            Case IlluminationDirection.LeftSided
                logfile.WriteLine("left sided")
            Case IlluminationDirection.RightSided
                logfile.WriteLine("right sided")
            Case IlluminationDirection.DoubleSided
                logfile.WriteLine("double sided")
        End Select

        Select Case Me.ScanningModeBox.SelectedIndex
            Case ImageProcessing.Scanningmode.singlescan
                logfile.WriteLine("single scan")
            Case ImageProcessing.Scanningmode.multiscan3
                logfile.WriteLine("multiscan 3-fold")
            Case ImageProcessing.Scanningmode.multiscan5
                logfile.WriteLine("multiscan 5-fold")
        End Select

        'Exposure times
        logfile.WriteLine(__CurrentExposure.ToString & " ms")

        logfile.WriteLine()
        logfile.WriteLine("z-correction: " & Gradient.Value.ToString & " ms/µm")

        'Global Intensity Maxima/Minima
        logfile.WriteLine("Highest intensity value in this data set: " & _Imax_Global.ToString)
        logfile.WriteLine("Lowest intensity value in this data set: " & _Imin_Global.ToString)

        'Brightness compensation parameters
        Dim alpha As Double = 0
        Dim gamma As Double = 0
        Dim eq As String = ""
        BrightnessCompensation.GetFunctionparameters(alpha, gamma, eq)

        logfile.WriteLine()
        logfile.WriteLine("Brightness compensation parameters:")
        logfile.WriteLine("equation: " & eq)
        logfile.WriteLine("with alpha = " & CStr(alpha) & " and gamma = " & CStr(gamma))
        logfile.WriteLine("xmax = number of image columns")
        logfile.WriteLine()
        logfile.WriteLine("comments: " & comments.Text)
        logfile.Close()
    End Sub

End Class