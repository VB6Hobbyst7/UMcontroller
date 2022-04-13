<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LoadColorMapFileBox = New System.Windows.Forms.OpenFileDialog()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.EditUnderExpLimit = New System.Windows.Forms.NumericUpDown()
        Me.EditOverExpLimit = New System.Windows.Forms.NumericUpDown()
        Me.HRIratio = New System.Windows.Forms.NumericUpDown()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.HDRICLIP = New System.Windows.Forms.NumericUpDown()
        Me.HDRION = New System.Windows.Forms.CheckBox()
        Me.SaveFullRangeCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.SelectCamBackground = New System.Windows.Forms.NumericUpDown()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.SelectCameraType = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SelectCameraGain = New System.Windows.Forms.ComboBox()
        Me.LengthOfScalebar = New System.Windows.Forms.ComboBox()
        Me.SettingsOK = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LensStepWidth = New System.Windows.Forms.NumericUpDown()
        Me.StepperWaittime = New System.Windows.Forms.NumericUpDown()
        Me.StepperStep = New System.Windows.Forms.NumericUpDown()
        Me.StepperAcc = New System.Windows.Forms.NumericUpDown()
        Me.StepperVel = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox2.SuspendLayout()
        CType(Me.EditUnderExpLimit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EditOverExpLimit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HRIratio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HDRICLIP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectCamBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LensStepWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StepperWaittime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StepperStep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StepperAcc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StepperVel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoadColorMapFileBox
        '
        Me.LoadColorMapFileBox.DefaultExt = "*.ctb"
        Me.LoadColorMapFileBox.Filter = "Colormaps|*.ctb"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 25)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 13)
        Me.Label5.TabIndex = 206
        Me.Label5.Text = "length of scalebar [µm]"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.EditUnderExpLimit)
        Me.GroupBox2.Controls.Add(Me.EditOverExpLimit)
        Me.GroupBox2.Controls.Add(Me.HRIratio)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.HDRICLIP)
        Me.GroupBox2.Controls.Add(Me.HDRION)
        Me.GroupBox2.Controls.Add(Me.SaveFullRangeCheckBox)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.SelectCamBackground)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.SelectCameraType)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.SelectCameraGain)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.LengthOfScalebar)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 149)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(767, 167)
        Me.GroupBox2.TabIndex = 217
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Display and camera"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(287, 139)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(154, 13)
        Me.Label26.TabIndex = 233
        Me.Label26.Text = "over exposure indicator limit (%)"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(30, 139)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(160, 13)
        Me.Label25.TabIndex = 232
        Me.Label25.Text = "under exposure indicator limit (%)"
        '
        'EditUnderExpLimit
        '
        Me.EditUnderExpLimit.Location = New System.Drawing.Point(198, 135)
        Me.EditUnderExpLimit.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.EditUnderExpLimit.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.EditUnderExpLimit.Name = "EditUnderExpLimit"
        Me.EditUnderExpLimit.Size = New System.Drawing.Size(53, 20)
        Me.EditUnderExpLimit.TabIndex = 231
        Me.EditUnderExpLimit.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'EditOverExpLimit
        '
        Me.EditOverExpLimit.Location = New System.Drawing.Point(452, 135)
        Me.EditOverExpLimit.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.EditOverExpLimit.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.EditOverExpLimit.Name = "EditOverExpLimit"
        Me.EditOverExpLimit.Size = New System.Drawing.Size(53, 20)
        Me.EditOverExpLimit.TabIndex = 230
        Me.EditOverExpLimit.Value = New Decimal(New Integer() {99, 0, 0, 0})
        '
        'HRIratio
        '
        Me.HRIratio.Location = New System.Drawing.Point(408, 95)
        Me.HRIratio.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.HRIratio.Name = "HRIratio"
        Me.HRIratio.Size = New System.Drawing.Size(53, 20)
        Me.HRIratio.TabIndex = 229
        Me.HRIratio.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(334, 99)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(67, 13)
        Me.Label21.TabIndex = 228
        Me.Label21.Text = "HDRI factor:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(135, 99)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(90, 13)
        Me.Label20.TabIndex = 227
        Me.Label20.Text = "HDRI clip limit (%)"
        '
        'HDRICLIP
        '
        Me.HDRICLIP.Location = New System.Drawing.Point(234, 95)
        Me.HDRICLIP.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.HDRICLIP.Name = "HDRICLIP"
        Me.HDRICLIP.Size = New System.Drawing.Size(65, 20)
        Me.HDRICLIP.TabIndex = 226
        Me.HDRICLIP.Value = New Decimal(New Integer() {90, 0, 0, 0})
        '
        'HDRION
        '
        Me.HDRION.AutoSize = True
        Me.HDRION.Location = New System.Drawing.Point(32, 97)
        Me.HDRION.Name = "HDRION"
        Me.HDRION.Size = New System.Drawing.Size(94, 17)
        Me.HDRION.TabIndex = 225
        Me.HDRION.Text = "activate HDRI"
        Me.HDRION.UseVisualStyleBackColor = True
        '
        'SaveFullRangeCheckBox
        '
        Me.SaveFullRangeCheckBox.AutoSize = True
        Me.SaveFullRangeCheckBox.Location = New System.Drawing.Point(32, 59)
        Me.SaveFullRangeCheckBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SaveFullRangeCheckBox.Name = "SaveFullRangeCheckBox"
        Me.SaveFullRangeCheckBox.Size = New System.Drawing.Size(346, 17)
        Me.SaveFullRangeCheckBox.TabIndex = 224
        Me.SaveFullRangeCheckBox.Text = "If possible always save data as full range 16 bit TIFFs (not for HDRI)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.SaveFullRangeCheckBox.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(525, 99)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(104, 13)
        Me.Label27.TabIndex = 221
        Me.Label27.Text = "Camera Background"
        '
        'SelectCamBackground
        '
        Me.SelectCamBackground.Location = New System.Drawing.Point(639, 95)
        Me.SelectCamBackground.Margin = New System.Windows.Forms.Padding(4)
        Me.SelectCamBackground.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.SelectCamBackground.Name = "SelectCamBackground"
        Me.SelectCamBackground.Size = New System.Drawing.Size(104, 20)
        Me.SelectCamBackground.TabIndex = 220
        Me.SelectCamBackground.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(487, 25)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(70, 13)
        Me.Label19.TabIndex = 219
        Me.Label19.Text = "Camera Type"
        '
        'SelectCameraType
        '
        Me.SelectCameraType.FormattingEnabled = True
        Me.SelectCameraType.Items.AddRange(New Object() {"AndorNeo", "AndorZyla", "DemoMode"})
        Me.SelectCameraType.Location = New System.Drawing.Point(566, 21)
        Me.SelectCameraType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SelectCameraType.Name = "SelectCameraType"
        Me.SelectCameraType.Size = New System.Drawing.Size(177, 21)
        Me.SelectCameraType.TabIndex = 218
        Me.SelectCameraType.Text = "DemoMode"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(489, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 217
        Me.Label6.Text = "Camera Gain"
        '
        'SelectCameraGain
        '
        Me.SelectCameraGain.FormattingEnabled = True
        Me.SelectCameraGain.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7"})
        Me.SelectCameraGain.Location = New System.Drawing.Point(566, 57)
        Me.SelectCameraGain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SelectCameraGain.Name = "SelectCameraGain"
        Me.SelectCameraGain.Size = New System.Drawing.Size(177, 21)
        Me.SelectCameraGain.TabIndex = 216
        '
        'LengthOfScalebar
        '
        Me.LengthOfScalebar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LengthOfScalebar.FormattingEnabled = True
        Me.LengthOfScalebar.Items.AddRange(New Object() {"0", "20", "50", "100", "200", "500", "750", "1000"})
        Me.LengthOfScalebar.Location = New System.Drawing.Point(151, 21)
        Me.LengthOfScalebar.Margin = New System.Windows.Forms.Padding(4)
        Me.LengthOfScalebar.Name = "LengthOfScalebar"
        Me.LengthOfScalebar.Size = New System.Drawing.Size(103, 21)
        Me.LengthOfScalebar.TabIndex = 205
        '
        'SettingsOK
        '
        Me.SettingsOK.Location = New System.Drawing.Point(296, 333)
        Me.SettingsOK.Margin = New System.Windows.Forms.Padding(4)
        Me.SettingsOK.Name = "SettingsOK"
        Me.SettingsOK.Size = New System.Drawing.Size(200, 35)
        Me.SettingsOK.TabIndex = 219
        Me.SettingsOK.Text = "Accept"
        Me.SettingsOK.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Stepper velocity (0.0001-2000)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(431, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Stepper acceleration (1...2000)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 58)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Stepper step width [µm]"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(431, 58)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Stepper wait time"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 90)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Lens step width [µm] /step"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LensStepWidth)
        Me.GroupBox1.Controls.Add(Me.StepperWaittime)
        Me.GroupBox1.Controls.Add(Me.StepperStep)
        Me.GroupBox1.Controls.Add(Me.StepperAcc)
        Me.GroupBox1.Controls.Add(Me.StepperVel)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(771, 127)
        Me.GroupBox1.TabIndex = 216
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Step motors"
        '
        'LensStepWidth
        '
        Me.LensStepWidth.Location = New System.Drawing.Point(255, 86)
        Me.LensStepWidth.Margin = New System.Windows.Forms.Padding(4)
        Me.LensStepWidth.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.LensStepWidth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.LensStepWidth.Name = "LensStepWidth"
        Me.LensStepWidth.Size = New System.Drawing.Size(104, 20)
        Me.LensStepWidth.TabIndex = 212
        Me.LensStepWidth.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'StepperWaittime
        '
        Me.StepperWaittime.Location = New System.Drawing.Point(639, 54)
        Me.StepperWaittime.Margin = New System.Windows.Forms.Padding(4)
        Me.StepperWaittime.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.StepperWaittime.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.StepperWaittime.Name = "StepperWaittime"
        Me.StepperWaittime.Size = New System.Drawing.Size(104, 20)
        Me.StepperWaittime.TabIndex = 211
        Me.StepperWaittime.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'StepperStep
        '
        Me.StepperStep.DecimalPlaces = 1
        Me.StepperStep.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.StepperStep.Location = New System.Drawing.Point(255, 54)
        Me.StepperStep.Margin = New System.Windows.Forms.Padding(4)
        Me.StepperStep.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.StepperStep.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.StepperStep.Name = "StepperStep"
        Me.StepperStep.Size = New System.Drawing.Size(104, 20)
        Me.StepperStep.TabIndex = 210
        Me.StepperStep.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'StepperAcc
        '
        Me.StepperAcc.Location = New System.Drawing.Point(639, 22)
        Me.StepperAcc.Margin = New System.Windows.Forms.Padding(4)
        Me.StepperAcc.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.StepperAcc.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.StepperAcc.Name = "StepperAcc"
        Me.StepperAcc.Size = New System.Drawing.Size(104, 20)
        Me.StepperAcc.TabIndex = 209
        Me.StepperAcc.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'StepperVel
        '
        Me.StepperVel.Location = New System.Drawing.Point(255, 22)
        Me.StepperVel.Margin = New System.Windows.Forms.Padding(4)
        Me.StepperVel.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.StepperVel.Minimum = New Decimal(New Integer() {1, 0, 0, 262144})
        Me.StepperVel.Name = "StepperVel"
        Me.StepperVel.Size = New System.Drawing.Size(104, 20)
        Me.StepperVel.TabIndex = 208
        Me.StepperVel.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'Settings
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(792, 376)
        Me.ControlBox = False
        Me.Controls.Add(Me.SettingsOK)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Settings"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.TopMost = True
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.EditUnderExpLimit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EditOverExpLimit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HRIratio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HDRICLIP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectCamBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.LensStepWidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StepperWaittime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StepperStep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StepperAcc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StepperVel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LoadColorMapFileBox As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LengthOfScalebar As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents SettingsOK As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents StepperVel As NumericUpDown
    Friend WithEvents StepperAcc As NumericUpDown
    Friend WithEvents StepperStep As NumericUpDown
    Friend WithEvents StepperWaittime As NumericUpDown
    Friend WithEvents LensStepWidth As NumericUpDown
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SelectCameraGain As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents SelectCameraType As System.Windows.Forms.ComboBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents SelectCamBackground As NumericUpDown
    Friend WithEvents SaveFullRangeCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents HRIratio As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents HDRICLIP As System.Windows.Forms.NumericUpDown
    Friend WithEvents HDRION As System.Windows.Forms.CheckBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents EditUnderExpLimit As System.Windows.Forms.NumericUpDown
    Friend WithEvents EditOverExpLimit As System.Windows.Forms.NumericUpDown
End Class
