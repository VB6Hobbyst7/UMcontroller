Public Class Settings

    Private _previous_cammode As Integer
    Private _previous_camtype As Integer

    Private Sub LengthOfScalebar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LengthOfScalebar.SelectedIndexChanged

        __ScalebarLength = LengthOfScalebar.SelectedIndex
    End Sub

    Private Sub SelectCamBackground_ValueChanged(sender As Object, e As EventArgs) Handles SelectCamBackground.ValueChanged

        __CameraBackground = CUShort(SelectCamBackground.Value)
    End Sub

    Private Sub SelectCameraType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SelectCameraType.SelectedIndexChanged

        SelectCameraGain.Items.Clear()

        Select Case SelectCameraType.SelectedIndex
            Case 0 'Neo
                SelectCameraGain.Items.Add("Gain 1 (11 bit)")
                SelectCameraGain.Items.Add("Gain 2 (11 bit)")
                SelectCameraGain.Items.Add("Gain 3 (11 bit)")
                SelectCameraGain.Items.Add("Gain 4 (11 bit)")
                SelectCameraGain.Items.Add("Gain 1 Gain 3 (14 bit)")
                SelectCameraGain.Items.Add("Gain 1 Gain 4 (16 bit)")
                SelectCameraGain.Items.Add("Gain 2 Gain 3 (14 bit)")
                SelectCameraGain.Items.Add("Gain 2 Gain 4 (16 bit)")
            Case 1 ' Zyla
                SelectCameraGain.Items.Add("11-bit (high well capacity)")
                SelectCameraGain.Items.Add("12-bit (high well capacity)")
                SelectCameraGain.Items.Add("11-bit (low noise)")
                SelectCameraGain.Items.Add("12-bit (low noise)")
                SelectCameraGain.Items.Add("16-bit (low noise & high well capacity)")
            Case 2 ' Demo mode
                SelectCameraGain.Items.Add("-------------------")
        End Select
        SelectCameraGain.SelectedIndex = 0
    End Sub

    Private Sub Settings_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged

        'procedure only exectues when form has been shown
        If Me.Visible = False Then
            Exit Sub
        End If
        ImageProcessing.ImageRecordingTaskStop()

        _previous_cammode = __CameraMode
        _previous_camtype = __CameraType

        Select Case __CameraType
            Case ImageProcessing.Cameras.AndorNeo
                SelectCameraType.SelectedIndex = 0
            Case ImageProcessing.Cameras.AndorZyla
                SelectCameraType.SelectedIndex = 1
            Case ImageProcessing.Cameras.DemoMode
                SelectCameraType.SelectedIndex = 2
        End Select

        SelectCameraGain.SelectedIndex = __CameraMode - 1
    End Sub

    Private Sub SettingsOK_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsOK.Click

        'copy some of the variables into global variables
        Globals.__HDRIon = Me.HDRION.Checked
        Globals.__HDRIclip = CInt(Me.HDRICLIP.Value)
        Globals.__HRratio = CUInt(Me.HRIratio.Value)
        Globals.__UnderExposureLimit = CInt(Me.EditUnderExpLimit.Value)
        Globals.__OverExoposureLimit = CInt(Me.EditOverExpLimit.Value)

        'set camera type and mode
        Select Case SelectCameraType.SelectedIndex
            Case 0
                __CameraType = ImageProcessing.Cameras.AndorNeo
                If SelectCameraGain.SelectedIndex + 1 <= 8 Then
                    __CameraMode = SelectCameraGain.SelectedIndex + 1
                Else
                    __CameraMode = 1
                End If
            Case 1
                __CameraType = ImageProcessing.Cameras.AndorZyla
                If SelectCameraGain.SelectedIndex + 1 <= 5 Then
                    __CameraMode = SelectCameraGain.SelectedIndex + 1
                Else
                    __CameraMode = 1
                End If
            Case 2
                __CameraType = ImageProcessing.Cameras.DemoMode
                __CameraMode = 1
        End Select
        __CameraMode = SelectCameraGain.SelectedIndex + 1

        'prevent clicking "ok" twice if it takes  a longer time..
        Me.Enabled = False

        'Restart program if camera type was changed
        If (__CameraType <> _previous_camtype) Or (__CameraMode <> _previous_cammode) Then
            Defaults.SaveDefaults()
            Utilities.TopMostMessageBox("RESTART", "Program must be restarted to activate changes.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            MainForm.Close_program()
        End If

        'initialize stepper for the case stepper velocity or accelaration has changed
        Stepper.SetParameters(Me.StepperVel.Value, Me.StepperAcc.Value)

        Me.Enabled = True
        ImageProcessing.ImagerecordingTaskStart()

        Me.Close()
    End Sub

End Class