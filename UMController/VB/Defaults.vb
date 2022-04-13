Imports System.IO

Module Defaults

    Public Sub ExportSettings()
        Dim sDialog As New SaveFileDialog With {
            .DefaultExt = ".AppSettings",
            .Filter = "Application Settings (*.AppSettings)|*AppSettings",
            .OverwritePrompt = False,
            .InitialDirectory = Application.StartupPath
        }

        'copy current settings to my.settings
        SaveDefaults()

        'write my.settings to a usere defined file
        If sDialog.ShowDialog() = DialogResult.OK Then
            Using sWriter As New StreamWriter(sDialog.FileName)
                For Each setting As System.Configuration.SettingsPropertyValue In My.Settings.PropertyValues
                    sWriter.WriteLine(setting.Name & "," & setting.PropertyValue.ToString())
                Next
            End Using
        End If
    End Sub

    Public Sub GetDefaults()
        My.Settings.Reload()
        Try
            MainForm.xyvoxelbutton.Value = My.Settings.XYVOXEL
            MainForm.setstepsize.Value = My.Settings.ZVOXEL
            Settings.LengthOfScalebar.SelectedIndex = My.Settings.SCALEBARLENGTH
            Settings.StepperVel.Value = My.Settings.STEPVEL
            Settings.StepperAcc.Value = My.Settings.STEPACC
            Settings.StepperStep.Value = My.Settings.STEPWIDTH
            Settings.StepperWaittime.Value = My.Settings.STEPWAIT
            Settings.LensStepWidth.Value = My.Settings.LENSSTEPWIDTH
            RecordingWindow.project.Text = My.Settings.PROJECTNR
            RecordingWindow.experiment.Text = My.Settings.EXPERIMENT
            RecordingWindow.specimen.Text = My.Settings.SPECIMEN
            RecordingWindow.perfusiondate.Text = My.Settings.PERFUSIONDATE
            RecordingWindow.detail.Text = My.Settings.DETAIL
            RecordingWindow.wavelength.Text = My.Settings.WAVELENGTH
            RecordingWindow.power.Text = My.Settings.LASERPOWER
            RecordingWindow.microscope.Text = My.Settings.MICROSCOPE
            RecordingWindow.objective.Text = My.Settings.OBJECTIVE
            RecordingWindow.postmagnification.Text = My.Settings.POSTMAG
            RecordingWindow.cylinderlens.Text = My.Settings.CYLLENS
            RecordingWindow.slitaperture.Text = My.Settings.SLIT
            RecordingWindow.comments.Text = My.Settings.COMMENTS
            RecordingWindow.RecordingModeBox.SelectedIndex = My.Settings.RECMODE
            RecordingWindow.NumberOfImages.Value = My.Settings.NIMAGES
            RecordingWindow.StartNumber.Value = My.Settings.STARTNUM
            RecordingWindow.ScanningModeBox.SelectedIndex = My.Settings.SCANMODE
            RecordingWindow.CheckCameraRotated.Checked = My.Settings.CAMERAROTATED
            Settings.SelectCamBackground.Value = My.Settings.CAMERABACKGROUND
            Settings.SaveFullRangeCheckBox.Checked = My.Settings.SAVEFULLRANGETIFFS
            Settings.HDRICLIP.Value = My.Settings.HDRICLIP
            Settings.HDRION.Checked = My.Settings.HDRION
            Settings.HRIratio.Value = My.Settings.HRIratio
            Settings.SelectCameraGain.SelectedIndex = My.Settings.CAMERAMODE
            Settings.SelectCameraType.SelectedIndex = My.Settings.CAMERATYPE
            __CameraMode = My.Settings.CAMERAMODE 'must be this way
            __CameraType = My.Settings.CAMERATYPE 'must be this way
            Settings.EditUnderExpLimit.Value = My.Settings.UNDEREXPLIMIT
            Settings.EditOverExpLimit.Value = My.Settings.OVEREXPLIMIT
        Catch
        End Try

        'copy some values additionally into global variables

        __HDRIon = My.Settings.HDRION
        __HDRIclip = My.Settings.HDRICLIP
        __HRratio = CUInt(My.Settings.HRIratio)

        __UnderExposureLimit = My.Settings.UNDEREXPLIMIT
        __OverExoposureLimit = My.Settings.OVEREXPLIMIT

    End Sub

    Public Sub ImportSettings()
        Dim input, dataSplit() As String
        Dim oDialog As New OpenFileDialog With {
            .Filter = "Application Settings (*.AppSettings)|*AppSettings",
            .InitialDirectory = Application.StartupPath
        }

        'sets all values in my.settings to the values retrieved from a user defined file
        If oDialog.ShowDialog() = DialogResult.OK Then
            Using sReader As New StreamReader(oDialog.FileName)
                While sReader.Peek() > 0
                    input = sReader.ReadLine()
                    ' Split comma delimited data ( SettingName,SettingValue )
                    dataSplit = Split(input, ",", 2)
                    My.Settings(dataSplit(0)) = Convert.ChangeType(dataSplit(1), My.Settings(dataSplit(0)).GetType)  'Setting and Value
                End While
            End Using

            Utilities.TopMostMessageBox("RESTART", "Program must be restarted to activate changes.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            MainForm.Close_program()
        End If
    End Sub

    Public Sub SaveDefaults()

        My.Settings.XYVOXEL = MainForm.xyvoxelbutton.Value
        My.Settings.ZVOXEL = MainForm.setstepsize.Value
        My.Settings.SCALEBARLENGTH = Settings.LengthOfScalebar.SelectedIndex
        My.Settings.STEPVEL = Settings.StepperVel.Value
        My.Settings.STEPACC = Settings.StepperAcc.Value
        My.Settings.STEPWIDTH = Settings.StepperStep.Value
        My.Settings.STEPWAIT = Settings.StepperWaittime.Value
        My.Settings.LENSSTEPWIDTH = Settings.LensStepWidth.Value
        My.Settings.PROJECTNR = RecordingWindow.project.Text
        My.Settings.EXPERIMENT = RecordingWindow.experiment.Text
        My.Settings.SPECIMEN = RecordingWindow.specimen.Text
        My.Settings.PERFUSIONDATE = RecordingWindow.perfusiondate.Text
        My.Settings.DETAIL = RecordingWindow.detail.Text
        My.Settings.WAVELENGTH = RecordingWindow.wavelength.Text
        My.Settings.LASERPOWER = RecordingWindow.power.Text
        My.Settings.MICROSCOPE = RecordingWindow.microscope.Text
        My.Settings.OBJECTIVE = RecordingWindow.objective.Text
        My.Settings.POSTMAG = RecordingWindow.postmagnification.Text
        My.Settings.CYLLENS = RecordingWindow.cylinderlens.Text
        My.Settings.SLIT = RecordingWindow.slitaperture.Text
        My.Settings.COMMENTS = RecordingWindow.comments.Text
        My.Settings.RECMODE = RecordingWindow.RecordingModeBox.SelectedIndex
        My.Settings.NIMAGES = CInt(RecordingWindow.NumberOfImages.Value)
        My.Settings.STARTNUM = CInt(RecordingWindow.StartNumber.Value)
        My.Settings.SCANMODE = RecordingWindow.ScanningModeBox.SelectedIndex
        My.Settings.CAMERAROTATED = RecordingWindow.CheckCameraRotated.Checked
        My.Settings.CAMERAMODE = __CameraMode
        My.Settings.CAMERATYPE = __CameraType
        My.Settings.CAMERABACKGROUND = CUShort(Settings.SelectCamBackground.Value)
        My.Settings.SAVEFULLRANGETIFFS = Settings.SaveFullRangeCheckBox.Checked
        My.Settings.HDRICLIP = CInt(Settings.HDRICLIP.Value)
        My.Settings.HDRION = Settings.HDRION.Checked
        My.Settings.HRIratio = CInt(Settings.HRIratio.Value)
        My.Settings.UNDEREXPLIMIT = CInt(Settings.EditUnderExpLimit.Value)
        My.Settings.OVEREXPLIMIT = CInt(Settings.EditOverExpLimit.Value)

        My.Settings.Save()
    End Sub

End Module