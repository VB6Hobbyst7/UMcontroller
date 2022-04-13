Public Class TimeSeriesRecording
    Private _ImageCounter As Integer = 0
    Private _path As String
    Private _SelectedPath As String = ""

    Public Sub Finish() 'is public for handling pressing escape in main window class

        'stop timer task
        _ImageCounter = 0
        Timer1.Stop()

        'update buttons in control window
        MainForm.StartButton.Text = "Start"
        MainForm.StartButton.BackColor = Color.LightGray
        MainForm.StartButton.Enabled = True

        'Restart camera background mode again
        ImageProcessing.ImagerecordingTaskStart()
    End Sub

    Private Sub Form2_Cancel_But_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Form2_Cancel_But.Click

        Me.Hide()
    End Sub

    Private Sub RecordImage()

        Dim n, j As Integer
        Dim sum, average, sdev, sem, var As Double

        _ImageCounter += 1

        'stop camera background recording mode and record one image
        Stepper.WaitUntilFinished()
        LinearStage.WaitUntilFinished(LinearStage.SelectStage.LeftStage)
        LinearStage.WaitUntilFinished(LinearStage.SelectStage.RightStage)

        ImageProcessing.Record_one_image(CUShort(__CurrentExposure), ImageProcessing.Scanningmode.singlescan)

        'Calculation of average
        n = ImageProcessing.Xres * ImageProcessing.Yres
        sum = 0
        For j = 0 To n - 1
            sum += ImageProcessing.Bit32Data(j)
        Next
        average = sum / n
        'Calculation of standard deviation
        var = 0.0
        For j = 0 To n - 1
            var += (ImageProcessing.Bit32Data(j) - average) ^ 2
        Next
        sdev = Math.Sqrt(var / (n - 1))
        'Calculation of standard error of the mean
        sem = sdev / Math.Sqrt(n)

        'write results to table
        Dim writer As New System.IO.StreamWriter(_path & "info.txt", True)
        writer.WriteLine(_ImageCounter & vbTab & average & vbTab & sdev & vbTab & sem)
        writer.Close()

        'save image
        Name = _ImageCounter.ToString
        While Name.Length < 5
            Name = "0" & Name
        End While

        Dim fname As String = _path & Name & ".tif"
        If Not (__HDRIon Or __BrCorrEnabled) Then
            ImageProcessing.Save_TIFF16(ImageProcessing.Bit32Data, fname, Settings.SaveFullRangeCheckBox.Checked)
        Else
            ImageProcessing.Save_TiffUint32(ImageProcessing.Bit32Data, fname)
        End If

        ImageProcessing.UpdateScreen()

        'Maximal number of recordings reached
        If _ImageCounter = CInt(NumberOfImages.Value) Then
            Finish()
        End If
    End Sub

    Private Sub SelectPath_Click(sender As Object, e As EventArgs) Handles SelectPath.Click

        Dim result As DialogResult = FolderBrowserDialog.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            _SelectedPath = FolderBrowserDialog.SelectedPath
        End If
    End Sub

    Private Sub StartRecording_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartRecording.Click

        If _SelectedPath = "" Then
            ImageProcessing.ImageRecordingTaskStop()
            Utilities.TopMostMessageBox("ERROR", "Please select a folder location first!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ImageProcessing.ImagerecordingTaskStart()
            Exit Sub
        Else
            _path = _SelectedPath + "\" + Dirname.Text.Trim & "\"
        End If

        Dim dir As New System.IO.DirectoryInfo(_path)
        If dir.Exists Then
            ImageProcessing.ImageRecordingTaskStop()
            Utilities.TopMostMessageBox("ERROR", "Directory already exists!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ImageProcessing.ImagerecordingTaskStart()
            Exit Sub
        End If

        Try
            dir.Create()
        Catch
            ImageProcessing.ImageRecordingTaskStop()
            Utilities.TopMostMessageBox("ERROR", "Directory can't be created!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ImageProcessing.ImagerecordingTaskStart()
            Exit Sub
        End Try

        'update gui
        MainForm.StartButton.BackColor = Color.Red
        MainForm.StartButton.Text = "Rec"
        MainForm.StartButton.Enabled = False
        Me.Hide()

        'generate protocol file
        Dim writer As New System.IO.StreamWriter(_path & "info.txt", False)

        'update various buttons
        MainForm.StartButton.BackColor = Color.Red
        MainForm.StartButton.Text = "Rec"

        'Write Info Header
        writer.WriteLine("interval " & TimeGap.Value & "s")
        writer.WriteLine("exposure time " & CUShort(__CurrentExposure) & "ms")
        writer.WriteLine("number" & vbTab & "average" & vbTab & "sdev" & vbTab & "SEM")
        writer.WriteLine("--------------------------------------------------------------")

        writer.Close()

        'record first image
        ImageProcessing.ImageRecordingTaskStop()

        ' record image 1
        RecordImage()

        'start counter and record images 2...n
        Timer1.Interval = CInt(TimeGap.Value) * 1000
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        RecordImage()
    End Sub

End Class