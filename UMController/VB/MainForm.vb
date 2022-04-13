
Imports Microsoft.Win32

Public Class MainForm
    Public MyViewerWindow As ViewerWindow

    'clean up at program closing
    Public Sub Close_program()
        ImageProcessing.ImageRecordingTaskClose()

        'Close serial port for MICOS devices
        Try
            __MicosPort.Close()
        Catch
        End Try

        System.Environment.Exit(0)
    End Sub

    'keybord shortcuts
    Public Sub MainForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If xyvoxelbutton.Focused Or setstepsize.Focused Or SetExposureBox.Focused Or LeftCylPosDispl.Focused Or
                    RightCylPosDispl.Focused Or JackPosDispl.Focused Then
            Exit Sub 'otherwise pressing 1 or 3 in imput bixes would move shutter (shortkey)
        End If

        Select Case e.KeyCode

            Case Keys.NumPad2 'move stage down
                StageDown(e)
                Stepper.WaitUntilFinished()
                Do
                Loop Until (Utilities.KeyPressed(e.KeyCode) = False)

            Case Keys.NumPad8 'move stage up
                StageUp(e)
                Stepper.WaitUntilFinished()
                Do
                Loop Until (Utilities.KeyPressed(e.KeyCode) = False)

            Case Keys.NumPad4 'move  left cylinder lens leftwards
                MoveZylLeft(e)

            Case Keys.NumPad6 'move left cylinderlens rightwards
                MoveZylRight(e)

            Case Keys.NumPad7 ' move right cylinder lens leftwards
                MoveZylRight2(e)

            Case Keys.NumPad9 ' move right cylinder lens rightwards
                MoveZylLeft2(e)

            Case Keys.Escape
                'standard recording mode handled elsewhere
                If TimeSeriesRecording.Timer1.Enabled Then
                    TimeSeriesRecording.Finish()
                End If
            Case Keys.Down
                LeicaStageControl.StageDown(10)
        End Select
    End Sub

    'generate live display window
    Public Sub MakeViewerWindow()

        'adopt viewer window size to camera type
        Dim size As Integer

        If ImageProcessing.CameraPresent Then

            Select Case __CameraType

                Case ImageProcessing.Cameras.AndorNeo '2560 x 2160 pixel
                    size = 1152

                Case ImageProcessing.Cameras.AndorZyla ' 2048 x 2048 pixel
                    size = 900

                Case ImageProcessing.Cameras.DemoMode 'Demo mode with 1392 x 1024 pixel
                    size = 1070

            End Select
        Else
            size = 1070 'no camera was found
        End If

        If MyViewerWindow Is Nothing Then
            MyViewerWindow = New ViewerWindow(ImageProcessing.PresentImage, size)
            MyViewerWindow.Show()
        Else
            If MyViewerWindow.IsDisposed Then
                MyViewerWindow = New ViewerWindow(ImageProcessing.PresentImage, size)
                MyViewerWindow.Show()
            End If
        End If

        MyViewerWindow.BringToFront()
        Me.MyViewerWindow.Text = "viewer window"
    End Sub

    Public Sub SetContrast()

        Dim min As Integer = Contrast_min_bar.Value
        Dim max As Integer = Contrast_max_bar.Value

        If min >= max Then
            min = 0
            max = 254
            Contrast_min_bar.Value = min
            Contrast_max_bar.Value = max
        End If

        ImageProcessing.SetContrast(min, max)
    End Sub

    Private Sub BrightnessLossCompensationMenuItem_Click(sender As Object, e As EventArgs) Handles BrightnessLossCompensationMenuItem.Click

        BrightnessCompensation.Show()
    End Sub

    Private Sub Contrast_max_bar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Contrast_max_bar.KeyDown

        Me.MainForm_KeyDown(sender, e)
    End Sub

    Private Sub Contrast_max_bar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Contrast_max_bar.Scroll

        SetContrast()
    End Sub

    Private Sub Contrast_min_bar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Contrast_min_bar.KeyDown

        Me.MainForm_KeyDown(sender, e)
    End Sub

    Private Sub Contrast_min_bar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Contrast_min_bar.Scroll

        SetContrast()
    End Sub

    'exit in strip menu clicked
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        Defaults.SaveDefaults()
        Close_program()
    End Sub

    Private Sub JackPosDispl_GotFocus(sender As Object, e As EventArgs) Handles JackPosDispl.GotFocus

        JackPosDispl.BackColor = Color.LightYellow
    End Sub

    Private Sub JackPosDispl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles JackPosDispl.KeyPress

        If e.KeyChar = Chr(13) Then
            FirstLabel.Focus()
        End If
    End Sub

    Private Sub JackPosDispl_LostFocus(sender As Object, e As EventArgs) Handles JackPosDispl.LostFocus

        JackPosDispl.BackColor = Color.White
    End Sub

    Private Sub JackPosDispl_Validated(sender As Object, e As EventArgs) Handles JackPosDispl.Validated

        If __StepperPresent Then
            Stepper.SetStepperPosAbs(JackPosDispl.Value)
            Stepper.WaitUntilFinished()
        End If
    End Sub

    Private Sub LeftCylPosDispl_GotFocus(sender As Object, e As EventArgs) Handles LeftCylPosDispl.GotFocus

        LeftCylPosDispl.BackColor = Color.LightYellow
    End Sub

    Private Sub LeftCylPosDispl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LeftCylPosDispl.KeyPress

        If e.KeyChar = Chr(13) Then
            FirstLabel.Focus()
        End If
    End Sub

    Private Sub LeftCylPosDispl_LostFocus(sender As Object, e As EventArgs) Handles LeftCylPosDispl.LostFocus

        LeftCylPosDispl.BackColor = Color.White
    End Sub

    Private Sub LeftCylPosDispl_Validated(sender As Object, e As EventArgs) Handles LeftCylPosDispl.Validated

        If __NumLienarStages >= 1 Then
            LinearStage.SetStagePosAbs(LeftCylPosDispl.Value, 1)
            LinearStage.WaitUntilFinished(1)
        End If
    End Sub

    Private Sub LoadConfigurationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadConfigurationToolStripMenuItem.Click

        Defaults.ImportSettings()
    End Sub

    'clean up when main form closed
    Private Sub MainForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        Defaults.SaveDefaults()
        Close_program()
    End Sub

    'All program initializations are done here.
    Private Sub MainForm_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged

        'procedure only exectues when form has been shown
        If Me.Visible = False Then
            Exit Sub
        End If

        'get settings from file
        Defaults.GetDefaults()

        'Initialize camera
        ImageProcessing.Init()

        'Generate registry keys if they do not already exist. Existing values are not overwrittten by this      
        Utilities.MakeDefaultRegKey("SOFTWARE\UMController", "LEICAMOTORFOCUS", "0")
        Utilities.MakeDefaultRegKey("SOFTWARE\UMController", "MICOSDEVICES", "0")
        Utilities.MakeDefaultRegKey("SOFTWARE\UMController", "NUM_LINEAR_STAGES", "0")
        Utilities.MakeDefaultRegKey("SOFTWARE\UMController", "STAGESACC", "500")
        Utilities.MakeDefaultRegKey("SOFTWARE\UMController", "STAGESVEL", "500")
        Utilities.MakeDefaultRegKey("SOFTWARE\UMController", "STEPPER", "0")
        Utilities.MakeDefaultRegKey("SOFTWARE\UMController", "WAITFORSTAGES", "100")

        Dim UMkey As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\UMController", False)

        'Initialize Leica Motorfocus
        Dim check As String = UMkey.GetValue("LEICAMOTORFOCUS", "0").ToString
        If CInt(check) = 0 Then
            __MotorFocusPresent = False
        Else
            __MotorFocusPresent = True
            __LeicaPort.Handshake = System.IO.Ports.Handshake.XOnXOff
        End If

        'waiting time after stages have been shifted in case of multiscan recording
        check = UMkey.GetValue("WAITFORSTAGES", "0").ToString
        __WaitForStages = CInt(check)

        'Acceleration of linear stages (1...2000)
        check = UMkey.GetValue("STAGESACC", "0").ToString
        __StagesAcc = CInt(check)

        'velocity of linear stages (1...2000)
        check = UMkey.GetValue("STAGESVEL", "0").ToString
        __StagesVel = CInt(check)

        'Initialize histogram display
        'Dim xrange As New NationalInstruments.UI.Range(0, ImageProcessing.MaxI)

        'Dim xrange As New NationalInstruments.UI.Range(0, 100000)
        'IntensityDistribution.XAxes.Item(0).Range = xrange

        'initialization of stepper
        check = UMkey.GetValue("STEPPER", "0").ToString
        If CInt(check) = 0 Then
            __StepperPresent = False
            StageDownButton.Enabled = False
            StageUpButton.Enabled = False
            StagePosStoreButton.Enabled = False
            StagePosRecallButton.Enabled = False
            JackPosDispl.Enabled = False
        Else
            Stepper.Init()
            Me.JackPosDispl.Value = CDec(Stepper.GetStepperPos)
        End If

        'initialization the two linear stages
        check = UMkey.GetValue("NUM_LINEAR_STAGES", "0").ToString
        __NumLienarStages = CInt(check)

        If __NumLienarStages >= 1 Then
            LinearStage.SetParameters(__StagesVel, __StagesAcc, 1)
        End If
        If __NumLienarStages >= 2 Then
            LinearStage.SetParameters(__StagesVel, __StagesAcc, 2)
        End If

        Select Case __NumLienarStages
            Case 0
                Zylleft1.Enabled = False
                Zylright1.Enabled = False
                ZylLeft1PosStoreButton.Enabled = False
                ZylLeft1PosRecallButton.Enabled = False
                LeftCylPosDispl.Enabled = False
                Zylleft2.Enabled = False
                Zylright2.Enabled = False
                Zyl2store.Enabled = False
                Zyl2Recall.Enabled = False
                RightCylPosDispl.Enabled = False

            Case 1
                LinearStage.Init()
                LeftCylPosDispl.Value = CDec(LinearStage.GetPos(1))
                Zylleft2.Enabled = False
                Zylright2.Enabled = False
                Zyl2store.Enabled = False
                Zyl2Recall.Enabled = False
                RightCylPosDispl.Enabled = False

            Case 2
                LinearStage.Init()
                LeftCylPosDispl.Value = CDec(LinearStage.GetPos(1))
                RightCylPosDispl.Value = CDec(LinearStage.GetPos(2))
        End Select

        'Close the registry database
        UMkey.Close()

        'make Viewer Window
        MakeViewerWindow()

        'IMPORTANT: initialize grayscale color palette of 8bit display
        ImageProcessing.SetContrast(0, 255)

        'StartImageRecording
        ImageProcessing.ImagerecordingTaskStart()
    End Sub

    Private Sub MoveZylLeft(e As System.Windows.Forms.KeyEventArgs)

        If __NumLienarStages >= 1 Then
            Dim shift As Double = Settings.LensStepWidth.Value
            If Not IsNothing(e) Then
                If e.Modifiers = Keys.Control Then
                    shift *= 5
                End If
            End If

            If shift > 100 Then
                shift = 100
            End If
            LinearStage.MoveLeft(LinearStage.SelectStage.LeftStage, shift * 0.001)
            Me.LeftCylPosDispl.Value = CDec(LinearStage.GetPos(1))
        End If
    End Sub

    Private Sub MoveZylLeft2(e As System.Windows.Forms.KeyEventArgs)

        If __NumLienarStages >= 2 Then
            Dim shift As Double = Settings.LensStepWidth.Value
            If Not IsNothing(e) Then
                If e.Modifiers = Keys.Control Then
                    shift *= 5
                End If
            End If
            If shift > 100 Then
                shift = 100
            End If
            LinearStage.MoveLeft(LinearStage.SelectStage.RightStage, shift * 0.001)
            Me.RightCylPosDispl.Value = CDec(LinearStage.GetPos(2))
        End If
    End Sub

    Private Sub MoveZylRight(e As System.Windows.Forms.KeyEventArgs)

        If __NumLienarStages >= 1 Then
            Dim shift As Double = Settings.LensStepWidth.Value
            If Not IsNothing(e) Then
                If e.Modifiers = Keys.Control Then
                    shift *= 5
                End If
            End If
            If shift > 100 Then
                shift = 100
            End If
            LinearStage.MoveRight(LinearStage.SelectStage.LeftStage, shift * 0.001)
            Me.LeftCylPosDispl.Value = CDec(LinearStage.GetPos(1))
        End If
    End Sub

    Private Sub MoveZylRight2(e As System.Windows.Forms.KeyEventArgs)

        If __NumLienarStages >= 2 Then
            Dim shift As Double = Settings.LensStepWidth.Value
            If Not IsNothing(e) Then
                If e.Modifiers = Keys.Control Then
                    shift *= 5
                End If
            End If

            If shift > 100 Then
                shift = 100
            End If
            LinearStage.MoveRight(LinearStage.SelectStage.RightStage, shift * 0.001)
            Me.RightCylPosDispl.Value = CDec(LinearStage.GetPos(2))
        End If
    End Sub

    Private Sub OverexposedCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles OverexposedCheckBox.CheckedChanged

        __ShowOverExposed = OverexposedCheckBox.Checked
        ImageProcessing.SetContrast(Contrast_min_bar.Value, Contrast_max_bar.Value)
    End Sub

    Private Sub RestoreCameraWindowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestoreCameraWindowToolStripMenuItem.Click

        Me.MakeViewerWindow()
    End Sub

    Private Sub RightCylPosDispl_GotFocus(sender As Object, e As EventArgs) Handles RightCylPosDispl.GotFocus

        RightCylPosDispl.BackColor = Color.LightYellow
    End Sub

    Private Sub RightCylPosDispl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RightCylPosDispl.KeyPress

        If e.KeyChar = Chr(13) Then
            FirstLabel.Focus()
        End If
    End Sub

    Private Sub RightCylPosDispl_LostFocus(sender As Object, e As EventArgs) Handles RightCylPosDispl.LostFocus

        RightCylPosDispl.BackColor = Color.White
    End Sub

    Private Sub RightCylPosDispl_Validated(sender As Object, e As EventArgs) Handles RightCylPosDispl.Validated

        If __NumLienarStages >= 2 Then
            LinearStage.SetStagePosAbs(RightCylPosDispl.Value, 2)
            LinearStage.WaitUntilFinished(2)
        End If
    End Sub

    Private Sub SaveConfigurationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveConfigurationToolStripMenuItem.Click

        Defaults.ExportSettings()
    End Sub

    'save single image
    Private Sub SaveImageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveImageToolStripMenuItem.Click

        Dim running As Boolean = ImageProcessing.IsRecording
        If running Then
            ImageProcessing.ImageRecordingTaskStop()
        End If
        SaveFormatDialog.ShowDialog()
        If running Then
            ImageProcessing.ImagerecordingTaskStart()
        End If
    End Sub

    Private Sub Setexposure2box_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SetExposureBox.KeyPress

        If e.KeyChar = Chr(13) Then
            Me.ActiveControl = Nothing
        End If
    End Sub

    Private Sub SetExposureBox_AfterChangeValue(sender As Object, e As AfterChangeNumericValueEventArgs) Handles SetExposureBox.AfterChangeValue

        __CurrentExposure = CUShort(SetExposureBox.Value)
    End Sub

    Private Sub Setexposurebox_GotFocus(sender As Object, e As EventArgs) Handles SetExposureBox.GotFocus

        SetExposureBox.BackColor = Color.LightYellow
    End Sub

    Private Sub SetExposureBox_Validated(sender As Object, e As EventArgs) Handles SetExposureBox.Validated

        __CurrentExposure = CUShort(SetExposureBox.Value) 'not SetExpsoureBox_value_changed! NO!
    End Sub

    Private Sub Setstepsize_AfterChangeValue(sender As Object, e As AfterChangeNumericValueEventArgs) Handles setstepsize.AfterChangeValue

        __zVoxelsize = setstepsize.Value
    End Sub

    Private Sub Setstepsize_GotFocus(sender As Object, e As EventArgs) Handles setstepsize.GotFocus
        setstepsize.BackColor = Color.LightYellow
    End Sub

    Private Sub Setstepsize_KeyPress(sender As Object, e As KeyPressEventArgs) Handles setstepsize.KeyPress

        If e.KeyChar = Chr(13) Then
            FirstLabel.Focus()
        End If
    End Sub

    Private Sub Setstepsize_LostFocus(sender As Object, e As EventArgs) Handles setstepsize.LostFocus

        setstepsize.BackColor = Color.White
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click

        Settings.ShowDialog()
    End Sub

    Private Sub StageDown(e As System.Windows.Forms.KeyEventArgs)

        If __StepperPresent Then
            Dim shift As Double = Settings.StepperStep.Value
            If Not IsNothing(e) Then
                If e.Modifiers = Keys.Control Then
                    shift *= 5
                End If
            End If
            If shift > 100 Then
                shift = 100
            End If
            Stepper.StepRel(-shift * 0.001)
            Me.JackPosDispl.Value = CDec(Stepper.GetStepperPos)
        End If
    End Sub

    Private Sub StageDownButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StageDownButton.Click

        StageDown(Nothing)
    End Sub

    Private Sub StagePosRecallButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StagePosRecallButton.Click

        If __StepperPresent Then
            ImageProcessing.ImageRecordingTaskStop()
            Dim answer As DialogResult
            answer = Utilities.TopMostMessageBox("ERROR", "Realy move to stored position?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            ImageProcessing.ImagerecordingTaskStart()

            If answer = DialogResult.No Then
                Exit Sub
            Else
                Stepper.RestorePos()
                Stepper.WaitUntilFinished()
                Me.JackPosDispl.Value = CDec(Stepper.GetStepperPos)
                Me.Update()
            End If
        End If
    End Sub

    'button to store position of jack
    Private Sub StagePosStoreButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StagePosStoreButton.Click

        If __StepperPresent Then
            Stepper.SavePos()
        End If
    End Sub

    Private Sub StageUp(e As System.Windows.Forms.KeyEventArgs)

        If __StepperPresent Then
            Dim shift As Double = Settings.StepperStep.Value
            If Not IsNothing(e) Then
                If e.Modifiers = Keys.Control Then
                    shift *= 5
                End If
            End If
            If shift > 100 Then
                shift = 100
            End If

            Stepper.StepRel(shift * 0.001)
            Me.JackPosDispl.Value = CDec(Stepper.GetStepperPos)
        End If
    End Sub

    'move jack up button clicked
    Private Sub StageUpButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StageUpButton.Click

        StageUp(Nothing)
    End Sub

    'start recording button clicked
    Private Sub StartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartButton.Click


        If Not RecordingWindow.Visible Then
            RecordingWindow.Show()
        End If
    End Sub

    Private Sub SetExposureBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SetExposureBox.KeyPress

        If e.KeyChar = Chr(13) Then
            Me.ActiveControl = Nothing
        End If
    End Sub

    'do time series recording
    Private Sub TimeSeriesRecordingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimeSeriesRecordingToolStripMenuItem.Click

        TimeSeriesRecording.ShowDialog()
    End Sub

    Private Sub UnderexposedCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles UnderexposedCheckBox.CheckedChanged

        __ShowUnderExposed = UnderexposedCheckBox.Checked
        ImageProcessing.SetContrast(Contrast_min_bar.Value, Contrast_max_bar.Value)
    End Sub

    Private Sub XYvoxelbutton_AfterChangeValue(sender As Object, e As AfterChangeNumericValueEventArgs) Handles xyvoxelbutton.AfterChangeValue
        __xyVoxelsize = xyvoxelbutton.Value
    End Sub

    Private Sub XYvoxelbutton_GotFocus(sender As Object, e As EventArgs) Handles xyvoxelbutton.GotFocus

        xyvoxelbutton.BackColor = Color.LightYellow
    End Sub

    Private Sub XYvoxelbutton_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xyvoxelbutton.KeyPress

        If e.KeyChar = Chr(13) Then
            FirstLabel.Focus()
        End If
    End Sub

    Private Sub XYvoxelbutton_LostFocus(sender As Object, e As EventArgs) Handles xyvoxelbutton.LostFocus

        xyvoxelbutton.BackColor = Color.White
    End Sub

    Private Sub ZeroLeftCylButton_Click(sender As Object, e As EventArgs) Handles ZeroLeftCylButton.Click

        LinearStage.SetZeroPos(1)
        Me.LeftCylPosDispl.Value = CDec(LinearStage.GetPos(1))
    End Sub

    Private Sub ZeroRightCylButton_Click(sender As Object, e As EventArgs) Handles ZeroRightCylButton.Click

        LinearStage.SetZeroPos(2)
        Me.RightCylPosDispl.Value = CDec(LinearStage.GetPos(2))
    End Sub

    Private Sub ZeroStageButton_Click(sender As Object, e As EventArgs) Handles ZeroStageButton.Click

        Stepper.SetZeroPos()
        Me.JackPosDispl.Value = CDec(Stepper.GetStepperPos)
    End Sub

    'button to recall position of cylindric lens 2
    Private Sub Zyl2Recall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Zyl2Recall.Click

        If __NumLienarStages >= 2 Then
            ImageProcessing.ImageRecordingTaskStop()
            Dim answer As DialogResult
            answer = Utilities.TopMostMessageBox("ERROR", "Realy move to stored position?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            ImageProcessing.ImagerecordingTaskStart()

            If answer = DialogResult.No Then
                Exit Sub
            Else
                LinearStage.RestorePos(2)
                LinearStage.WaitUntilFinished(2)
                Me.RightCylPosDispl.Value = CDec(LinearStage.GetPos(LinearStage.SelectStage.RightStage))
                Me.Update()
            End If
        End If
    End Sub

    'button to store position of cylindric lens 2
    Private Sub Zyl2store_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Zyl2store.Click

        If __NumLienarStages >= 2 Then
            LinearStage.SavePos(2)
        End If
    End Sub

    'move cylindric lens 1 left button
    Private Sub Zylleft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Zylleft1.Click

        MoveZylLeft(Nothing)
    End Sub

    'move cylindric lens 2 left button
    Private Sub Zylleft2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Zylleft2.Click

        MoveZylLeft2(Nothing)
    End Sub

    'button to recall position of cylindric lens 1
    Private Sub ZylLeftPosRecallButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZylLeft1PosRecallButton.Click

        If __NumLienarStages >= 1 Then
            ImageProcessing.ImageRecordingTaskStop()

            Dim answer As DialogResult
            answer = Utilities.TopMostMessageBox("ERROR", "Realy move to stored position?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            ImageProcessing.ImagerecordingTaskStart()

            If answer = DialogResult.No Then
                Exit Sub
            Else
                LinearStage.RestorePos(1)
                LinearStage.WaitUntilFinished(1)
                Me.LeftCylPosDispl.Value = CDec(LinearStage.GetPos(LinearStage.SelectStage.LeftStage))
                Me.Update()
            End If
        End If
    End Sub

    'button to store position of clindric lens 1
    Private Sub ZylLeftPosStoreButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZylLeft1PosStoreButton.Click

        If __NumLienarStages >= 1 Then
            LinearStage.SavePos(1)
        End If
    End Sub

    'move cylindric lens 1 right button
    Private Sub Zylright_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Zylright1.Click

        MoveZylRight(Nothing)
    End Sub

    'move cylindric lens 2 right button
    Private Sub Zylright2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Zylright2.Click

        MoveZylRight2(Nothing)
    End Sub
End Class