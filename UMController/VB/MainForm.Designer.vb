<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Literale nicht als lokalisierte Parameter übergeben", MessageId:="System.Windows.Forms.ToolStripItem.set_Text(System.String)")> <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.InrLabel = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.label5 = New System.Windows.Forms.Label()
        Me.StageUpButton = New System.Windows.Forms.Button()
        Me.StageDownButton = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.ImageNumberBox = New System.Windows.Forms.TextBox()
        Me.Zylleft1 = New System.Windows.Forms.Button()
        Me.Zylright1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.StagePosStoreButton = New System.Windows.Forms.Button()
        Me.StagePosRecallButton = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ZeroStageButton = New System.Windows.Forms.Button()
        Me.JackPosDispl = New NationalInstruments.UI.WindowsForms.NumericEdit()
        Me.ZylLeft1PosRecallButton = New System.Windows.Forms.Button()
        Me.ZylLeft1PosStoreButton = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.ZeroRightCylButton = New System.Windows.Forms.Button()
        Me.ZeroLeftCylButton = New System.Windows.Forms.Button()
        Me.RightCylPosDispl = New NationalInstruments.UI.WindowsForms.NumericEdit()
        Me.LeftCylPosDispl = New NationalInstruments.UI.WindowsForms.NumericEdit()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Zyl2store = New System.Windows.Forms.Button()
        Me.Zyl2Recall = New System.Windows.Forms.Button()
        Me.Zylright2 = New System.Windows.Forms.Button()
        Me.Zylleft2 = New System.Windows.Forms.Button()
        Me.FirstLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeSeriesRecordingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrightnessLossCompensationMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadConfigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveConfigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreCameraWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntensityDistribution = New NationalInstruments.UI.WindowsForms.ScatterGraph()
        Me.ScatterPlot1 = New NationalInstruments.UI.ScatterPlot()
        Me.XAxis1 = New NationalInstruments.UI.XAxis()
        Me.YAxis1 = New NationalInstruments.UI.YAxis()
        Me.MinIntensityBox = New System.Windows.Forms.TextBox()
        Me.MaxIntensityBox = New System.Windows.Forms.TextBox()
        Me.xyvoxelbutton = New NationalInstruments.UI.WindowsForms.NumericEdit()
        Me.setstepsize = New NationalInstruments.UI.WindowsForms.NumericEdit()
        Me.SetExposureBox = New NationalInstruments.UI.WindowsForms.NumericEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Contrast_max_bar = New System.Windows.Forms.TrackBar()
        Me.Contrast_min_bar = New System.Windows.Forms.TrackBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.UnderexposedCheckBox = New System.Windows.Forms.CheckBox()
        Me.OverexposedCheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox4.SuspendLayout()
        CType(Me.JackPosDispl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.RightCylPosDispl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftCylPosDispl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.IntensityDistribution, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xyvoxelbutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setstepsize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SetExposureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Contrast_max_bar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Contrast_min_bar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InrLabel
        '
        Me.InrLabel.AutoSize = True
        Me.InrLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InrLabel.Location = New System.Drawing.Point(162, 98)
        Me.InrLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.InrLabel.Name = "InrLabel"
        Me.InrLabel.Size = New System.Drawing.Size(89, 16)
        Me.InrLabel.TabIndex = 143
        Me.InrLabel.Text = "current image"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(158, 32)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(113, 16)
        Me.label1.TabIndex = 138
        Me.label1.Text = "voxel size (z) [µm]"
        '
        'StartButton
        '
        Me.StartButton.BackColor = System.Drawing.Color.LightGray
        Me.StartButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartButton.Location = New System.Drawing.Point(60, 726)
        Me.StartButton.Margin = New System.Windows.Forms.Padding(4)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(176, 41)
        Me.StartButton.TabIndex = 136
        Me.StartButton.Text = "start recording..."
        Me.StartButton.UseVisualStyleBackColor = False
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.Color.Blue
        Me.label5.Location = New System.Drawing.Point(98, 95)
        Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(76, 16)
        Me.label5.TabIndex = 112
        Me.label5.Text = "jack control"
        '
        'StageUpButton
        '
        Me.StageUpButton.Location = New System.Drawing.Point(79, 15)
        Me.StageUpButton.Margin = New System.Windows.Forms.Padding(4)
        Me.StageUpButton.Name = "StageUpButton"
        Me.StageUpButton.Size = New System.Drawing.Size(53, 43)
        Me.StageUpButton.TabIndex = 102
        Me.StageUpButton.Text = "up [8]"
        Me.StageUpButton.UseVisualStyleBackColor = True
        '
        'StageDownButton
        '
        Me.StageDownButton.Location = New System.Drawing.Point(11, 15)
        Me.StageDownButton.Margin = New System.Windows.Forms.Padding(4)
        Me.StageDownButton.Name = "StageDownButton"
        Me.StageDownButton.Size = New System.Drawing.Size(53, 43)
        Me.StageDownButton.TabIndex = 101
        Me.StageDownButton.Text = "down [2]"
        Me.StageDownButton.UseVisualStyleBackColor = True
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(13, 98)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(74, 16)
        Me.label2.TabIndex = 104
        Me.label2.Text = "exposure 1"
        '
        'ImageNumberBox
        '
        Me.ImageNumberBox.BackColor = System.Drawing.Color.LightGray
        Me.ImageNumberBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ImageNumberBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.ImageNumberBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImageNumberBox.Location = New System.Drawing.Point(160, 122)
        Me.ImageNumberBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ImageNumberBox.Name = "ImageNumberBox"
        Me.ImageNumberBox.ReadOnly = True
        Me.ImageNumberBox.Size = New System.Drawing.Size(125, 22)
        Me.ImageNumberBox.TabIndex = 144
        Me.ImageNumberBox.TabStop = False
        Me.ImageNumberBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Zylleft1
        '
        Me.Zylleft1.Location = New System.Drawing.Point(23, 436)
        Me.Zylleft1.Margin = New System.Windows.Forms.Padding(4)
        Me.Zylleft1.Name = "Zylleft1"
        Me.Zylleft1.Size = New System.Drawing.Size(53, 24)
        Me.Zylleft1.TabIndex = 169
        Me.Zylleft1.Text = "left [4]"
        Me.Zylleft1.UseVisualStyleBackColor = True
        '
        'Zylright1
        '
        Me.Zylright1.Location = New System.Drawing.Point(84, 436)
        Me.Zylright1.Margin = New System.Windows.Forms.Padding(4)
        Me.Zylright1.Name = "Zylright1"
        Me.Zylright1.Size = New System.Drawing.Size(53, 24)
        Me.Zylright1.TabIndex = 170
        Me.Zylright1.Text = "right [6]"
        Me.Zylright1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 122)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 16)
        Me.Label9.TabIndex = 171
        Me.Label9.Text = "left cyl. lens"
        '
        'StagePosStoreButton
        '
        Me.StagePosStoreButton.Location = New System.Drawing.Point(147, 15)
        Me.StagePosStoreButton.Margin = New System.Windows.Forms.Padding(4)
        Me.StagePosStoreButton.Name = "StagePosStoreButton"
        Me.StagePosStoreButton.Size = New System.Drawing.Size(53, 43)
        Me.StagePosStoreButton.TabIndex = 185
        Me.StagePosStoreButton.Text = "store"
        Me.StagePosStoreButton.UseVisualStyleBackColor = True
        '
        'StagePosRecallButton
        '
        Me.StagePosRecallButton.Location = New System.Drawing.Point(215, 15)
        Me.StagePosRecallButton.Margin = New System.Windows.Forms.Padding(4)
        Me.StagePosRecallButton.Name = "StagePosRecallButton"
        Me.StagePosRecallButton.Size = New System.Drawing.Size(53, 43)
        Me.StagePosRecallButton.TabIndex = 186
        Me.StagePosRecallButton.Text = "recall"
        Me.StagePosRecallButton.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ZeroStageButton)
        Me.GroupBox4.Controls.Add(Me.JackPosDispl)
        Me.GroupBox4.Controls.Add(Me.label5)
        Me.GroupBox4.Controls.Add(Me.StagePosRecallButton)
        Me.GroupBox4.Controls.Add(Me.StagePosStoreButton)
        Me.GroupBox4.Controls.Add(Me.StageUpButton)
        Me.GroupBox4.Controls.Add(Me.StageDownButton)
        Me.GroupBox4.Location = New System.Drawing.Point(10, 603)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(277, 118)
        Me.GroupBox4.TabIndex = 187
        Me.GroupBox4.TabStop = False
        '
        'ZeroStageButton
        '
        Me.ZeroStageButton.Location = New System.Drawing.Point(14, 68)
        Me.ZeroStageButton.Name = "ZeroStageButton"
        Me.ZeroStageButton.Size = New System.Drawing.Size(18, 23)
        Me.ZeroStageButton.TabIndex = 240
        Me.ZeroStageButton.Text = "0"
        Me.ZeroStageButton.UseVisualStyleBackColor = True
        '
        'JackPosDispl
        '
        Me.JackPosDispl.CoercionInterval = 0.1R
        Me.JackPosDispl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JackPosDispl.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(4)
        Me.JackPosDispl.Location = New System.Drawing.Point(39, 68)
        Me.JackPosDispl.Name = "JackPosDispl"
        Me.JackPosDispl.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.JackPosDispl.Range = New NationalInstruments.UI.Range(-500.0R, 500.0R)
        Me.JackPosDispl.Size = New System.Drawing.Size(85, 22)
        Me.JackPosDispl.TabIndex = 234
        Me.JackPosDispl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.JackPosDispl.ValidationMode = NationalInstruments.UI.NumericEditValidationMode.WhenChanged
        '
        'ZylLeft1PosRecallButton
        '
        Me.ZylLeft1PosRecallButton.Location = New System.Drawing.Point(84, 470)
        Me.ZylLeft1PosRecallButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ZylLeft1PosRecallButton.Name = "ZylLeft1PosRecallButton"
        Me.ZylLeft1PosRecallButton.Size = New System.Drawing.Size(53, 28)
        Me.ZylLeft1PosRecallButton.TabIndex = 189
        Me.ZylLeft1PosRecallButton.Text = "recall"
        Me.ZylLeft1PosRecallButton.UseVisualStyleBackColor = True
        '
        'ZylLeft1PosStoreButton
        '
        Me.ZylLeft1PosStoreButton.Location = New System.Drawing.Point(23, 470)
        Me.ZylLeft1PosStoreButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ZylLeft1PosStoreButton.Name = "ZylLeft1PosStoreButton"
        Me.ZylLeft1PosStoreButton.Size = New System.Drawing.Size(53, 28)
        Me.ZylLeft1PosStoreButton.TabIndex = 188
        Me.ZylLeft1PosStoreButton.Text = "store"
        Me.ZylLeft1PosStoreButton.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.ZeroRightCylButton)
        Me.GroupBox5.Controls.Add(Me.ZeroLeftCylButton)
        Me.GroupBox5.Controls.Add(Me.RightCylPosDispl)
        Me.GroupBox5.Controls.Add(Me.LeftCylPosDispl)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Zyl2store)
        Me.GroupBox5.Location = New System.Drawing.Point(9, 423)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(1)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(287, 178)
        Me.GroupBox5.TabIndex = 188
        Me.GroupBox5.TabStop = False
        '
        'ZeroRightCylButton
        '
        Me.ZeroRightCylButton.Location = New System.Drawing.Point(159, 87)
        Me.ZeroRightCylButton.Name = "ZeroRightCylButton"
        Me.ZeroRightCylButton.Size = New System.Drawing.Size(18, 23)
        Me.ZeroRightCylButton.TabIndex = 240
        Me.ZeroRightCylButton.Text = "0"
        Me.ZeroRightCylButton.UseVisualStyleBackColor = True
        '
        'ZeroLeftCylButton
        '
        Me.ZeroLeftCylButton.Location = New System.Drawing.Point(15, 87)
        Me.ZeroLeftCylButton.Name = "ZeroLeftCylButton"
        Me.ZeroLeftCylButton.Size = New System.Drawing.Size(18, 23)
        Me.ZeroLeftCylButton.TabIndex = 239
        Me.ZeroLeftCylButton.Text = "0"
        Me.ZeroLeftCylButton.UseVisualStyleBackColor = True
        '
        'RightCylPosDispl
        '
        Me.RightCylPosDispl.CoercionInterval = 0.1R
        Me.RightCylPosDispl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RightCylPosDispl.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(4)
        Me.RightCylPosDispl.Location = New System.Drawing.Point(183, 88)
        Me.RightCylPosDispl.Name = "RightCylPosDispl"
        Me.RightCylPosDispl.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.RightCylPosDispl.Range = New NationalInstruments.UI.Range(-50.0R, 50.0R)
        Me.RightCylPosDispl.Size = New System.Drawing.Size(88, 22)
        Me.RightCylPosDispl.TabIndex = 234
        Me.RightCylPosDispl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RightCylPosDispl.ValidationMode = NationalInstruments.UI.NumericEditValidationMode.WhenChanged
        '
        'LeftCylPosDispl
        '
        Me.LeftCylPosDispl.CoercionInterval = 0.1R
        Me.LeftCylPosDispl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LeftCylPosDispl.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(4)
        Me.LeftCylPosDispl.Location = New System.Drawing.Point(40, 88)
        Me.LeftCylPosDispl.Name = "LeftCylPosDispl"
        Me.LeftCylPosDispl.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.LeftCylPosDispl.Range = New NationalInstruments.UI.Range(-50.0R, 50.0R)
        Me.LeftCylPosDispl.Size = New System.Drawing.Size(87, 22)
        Me.LeftCylPosDispl.TabIndex = 233
        Me.LeftCylPosDispl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.LeftCylPosDispl.ValidationMode = NationalInstruments.UI.NumericEditValidationMode.WhenChanged
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(103, 149)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 16)
        Me.Label10.TabIndex = 222
        Me.Label10.Text = "lens control"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(161, 122)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 16)
        Me.Label3.TabIndex = 172
        Me.Label3.Text = "right cyl. lens"
        '
        'Zyl2store
        '
        Me.Zyl2store.Location = New System.Drawing.Point(159, 47)
        Me.Zyl2store.Margin = New System.Windows.Forms.Padding(4)
        Me.Zyl2store.Name = "Zyl2store"
        Me.Zyl2store.Size = New System.Drawing.Size(53, 28)
        Me.Zyl2store.TabIndex = 193
        Me.Zyl2store.Text = "store"
        Me.Zyl2store.UseVisualStyleBackColor = True
        '
        'Zyl2recall
        '
        Me.Zyl2Recall.Location = New System.Drawing.Point(230, 470)
        Me.Zyl2Recall.Margin = New System.Windows.Forms.Padding(4)
        Me.Zyl2Recall.Name = "Zyl2recall"
        Me.Zyl2Recall.Size = New System.Drawing.Size(51, 27)
        Me.Zyl2Recall.TabIndex = 194
        Me.Zyl2Recall.Text = "recall"
        Me.Zyl2Recall.UseVisualStyleBackColor = True
        '
        'Zylright2
        '
        Me.Zylright2.Location = New System.Drawing.Point(230, 437)
        Me.Zylright2.Margin = New System.Windows.Forms.Padding(4)
        Me.Zylright2.Name = "Zylright2"
        Me.Zylright2.Size = New System.Drawing.Size(51, 23)
        Me.Zylright2.TabIndex = 191
        Me.Zylright2.Text = "right [9]"
        Me.Zylright2.UseVisualStyleBackColor = True
        '
        'Zylleft2
        '
        Me.Zylleft2.Location = New System.Drawing.Point(168, 437)
        Me.Zylleft2.Margin = New System.Windows.Forms.Padding(4)
        Me.Zylleft2.Name = "Zylleft2"
        Me.Zylleft2.Size = New System.Drawing.Size(53, 23)
        Me.Zylleft2.TabIndex = 190
        Me.Zylleft2.Text = "left [7]"
        Me.Zylleft2.UseVisualStyleBackColor = True
        '
        'FirstLabel
        '
        Me.FirstLabel.AutoSize = True
        Me.FirstLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstLabel.Location = New System.Drawing.Point(13, 33)
        Me.FirstLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FirstLabel.Name = "FirstLabel"
        Me.FirstLabel.Size = New System.Drawing.Size(120, 16)
        Me.FirstLabel.TabIndex = 207
        Me.FirstLabel.Text = "voxel size (xy) [µm]"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ImageToolStripMenuItem, Me.OptionsToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(297, 24)
        Me.MenuStrip1.TabIndex = 212
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveImageToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveImageToolStripMenuItem
        '
        Me.SaveImageToolStripMenuItem.Name = "SaveImageToolStripMenuItem"
        Me.SaveImageToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.SaveImageToolStripMenuItem.Text = "Save Image"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ImageToolStripMenuItem
        '
        Me.ImageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TimeSeriesRecordingToolStripMenuItem, Me.BrightnessLossCompensationMenuItem})
        Me.ImageToolStripMenuItem.Name = "ImageToolStripMenuItem"
        Me.ImageToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.ImageToolStripMenuItem.Text = "Image"
        '
        'TimeSeriesRecordingToolStripMenuItem
        '
        Me.TimeSeriesRecordingToolStripMenuItem.Name = "TimeSeriesRecordingToolStripMenuItem"
        Me.TimeSeriesRecordingToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.TimeSeriesRecordingToolStripMenuItem.Text = "TimeSeriesRecording"
        '
        'BrightnessLossCompensationToolStripMenuItem
        '
        Me.BrightnessLossCompensationMenuItem.Name = "BrightnessLossCompensationToolStripMenuItem"
        Me.BrightnessLossCompensationMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.BrightnessLossCompensationMenuItem.Text = "Brightness Loss Compensation"
        '
        'OptionsToolStripMenuItem1
        '
        Me.OptionsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadConfigurationToolStripMenuItem, Me.SaveConfigurationToolStripMenuItem, Me.RestoreCameraWindowToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.OptionsToolStripMenuItem1.Name = "OptionsToolStripMenuItem1"
        Me.OptionsToolStripMenuItem1.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem1.Text = "Options"
        '
        'LoadConfigurationToolStripMenuItem
        '
        Me.LoadConfigurationToolStripMenuItem.Name = "LoadConfigurationToolStripMenuItem"
        Me.LoadConfigurationToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.LoadConfigurationToolStripMenuItem.Text = "Load Configuration"
        '
        'SaveConfigurationToolStripMenuItem
        '
        Me.SaveConfigurationToolStripMenuItem.Name = "SaveConfigurationToolStripMenuItem"
        Me.SaveConfigurationToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.SaveConfigurationToolStripMenuItem.Text = "Save Configuration as"
        '
        'RestoreCameraWindowToolStripMenuItem
        '
        Me.RestoreCameraWindowToolStripMenuItem.Name = "RestoreCameraWindowToolStripMenuItem"
        Me.RestoreCameraWindowToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.RestoreCameraWindowToolStripMenuItem.Text = "Restore Camera Window"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'IntensityDistribution
        '
        Me.IntensityDistribution.Border = NationalInstruments.UI.Border.None
        Me.IntensityDistribution.InteractionMode = NationalInstruments.UI.GraphInteractionModes.None
        Me.IntensityDistribution.Location = New System.Drawing.Point(4, 157)
        Me.IntensityDistribution.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IntensityDistribution.Name = "IntensityDistribution"
        Me.IntensityDistribution.PlotAreaBorder = NationalInstruments.UI.Border.Solid
        Me.IntensityDistribution.PlotAreaColor = System.Drawing.Color.White
        Me.IntensityDistribution.Plots.AddRange(New NationalInstruments.UI.ScatterPlot() {Me.ScatterPlot1})
        Me.IntensityDistribution.Size = New System.Drawing.Size(296, 160)
        Me.IntensityDistribution.TabIndex = 225
        Me.IntensityDistribution.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.XAxis1})
        Me.IntensityDistribution.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.YAxis1})
        '
        'ScatterPlot1
        '
        Me.ScatterPlot1.FillMode = NationalInstruments.UI.PlotFillMode.FillAndBins
        Me.ScatterPlot1.FillToBaseColor = System.Drawing.Color.DarkGray
        Me.ScatterPlot1.LineColor = System.Drawing.Color.DarkGray
        Me.ScatterPlot1.LineColorPrecedence = NationalInstruments.UI.ColorPrecedence.UserDefinedColor
        Me.ScatterPlot1.LineStep = NationalInstruments.UI.LineStep.CenteredXYStep
        Me.ScatterPlot1.LineStyle = NationalInstruments.UI.LineStyle.None
        Me.ScatterPlot1.LineToBaseColor = System.Drawing.Color.White
        Me.ScatterPlot1.LineWidth = 2.0!
        Me.ScatterPlot1.PointColor = System.Drawing.Color.Firebrick
        Me.ScatterPlot1.XAxis = Me.XAxis1
        Me.ScatterPlot1.YAxis = Me.YAxis1
        '
        'XAxis1
        '
        Me.XAxis1.Caption = "intensity"
        Me.XAxis1.InteractionMode = NationalInstruments.UI.ScaleInteractionMode.None
        Me.XAxis1.Range = New NationalInstruments.UI.Range(1.0R, 65535.0R)
        '
        'YAxis1
        '
        Me.YAxis1.Caption = "log(frequency) "
        Me.YAxis1.InteractionMode = NationalInstruments.UI.ScaleInteractionMode.None
        Me.YAxis1.Range = New NationalInstruments.UI.Range(0R, 4.0R)
        '
        'MinIntensityBox
        '
        Me.MinIntensityBox.BackColor = System.Drawing.Color.LightGray
        Me.MinIntensityBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MinIntensityBox.Location = New System.Drawing.Point(22, 303)
        Me.MinIntensityBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinIntensityBox.Name = "MinIntensityBox"
        Me.MinIntensityBox.ReadOnly = True
        Me.MinIntensityBox.Size = New System.Drawing.Size(72, 13)
        Me.MinIntensityBox.TabIndex = 227
        Me.MinIntensityBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MaxIntensityBox
        '
        Me.MaxIntensityBox.BackColor = System.Drawing.Color.LightGray
        Me.MaxIntensityBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaxIntensityBox.Location = New System.Drawing.Point(215, 303)
        Me.MaxIntensityBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaxIntensityBox.Name = "MaxIntensityBox"
        Me.MaxIntensityBox.ReadOnly = True
        Me.MaxIntensityBox.Size = New System.Drawing.Size(72, 13)
        Me.MaxIntensityBox.TabIndex = 229
        Me.MaxIntensityBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xyvoxelbutton
        '
        Me.xyvoxelbutton.CoercionInterval = 0.1R
        Me.xyvoxelbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xyvoxelbutton.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3)
        Me.xyvoxelbutton.Location = New System.Drawing.Point(16, 55)
        Me.xyvoxelbutton.Name = "xyvoxelbutton"
        Me.xyvoxelbutton.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.xyvoxelbutton.Range = New NationalInstruments.UI.Range(0.1R, 100.0R)
        Me.xyvoxelbutton.Size = New System.Drawing.Size(128, 29)
        Me.xyvoxelbutton.TabIndex = 228
        Me.xyvoxelbutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.xyvoxelbutton.ValidationMode = NationalInstruments.UI.NumericEditValidationMode.WhenChanged
        Me.xyvoxelbutton.Value = 3.0R
        '
        'setstepsize
        '
        Me.setstepsize.CoercionInterval = 0.1R
        Me.setstepsize.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.setstepsize.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3)
        Me.setstepsize.Location = New System.Drawing.Point(159, 55)
        Me.setstepsize.Name = "setstepsize"
        Me.setstepsize.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.setstepsize.Range = New NationalInstruments.UI.Range(0.1R, 100.0R)
        Me.setstepsize.Size = New System.Drawing.Size(128, 29)
        Me.setstepsize.TabIndex = 231
        Me.setstepsize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.setstepsize.ValidationMode = NationalInstruments.UI.NumericEditValidationMode.WhenChanged
        Me.setstepsize.Value = 6.0R
        '
        'SetExposureBox
        '
        Me.SetExposureBox.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.UMController.My.MySettings.Default, "EXPOSURE", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.SetExposureBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetExposureBox.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.SetExposureBox.ImmediateUpdates = True
        Me.SetExposureBox.Location = New System.Drawing.Point(16, 115)
        Me.SetExposureBox.Name = "SetExposureBox"
        Me.SetExposureBox.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.SetExposureBox.Range = New NationalInstruments.UI.Range(1.0R, 10000.0R)
        Me.SetExposureBox.Size = New System.Drawing.Size(128, 29)
        Me.SetExposureBox.TabIndex = 232
        Me.SetExposureBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SetExposureBox.ValidationMode = NationalInstruments.UI.NumericEditValidationMode.WhenChanged
        Me.SetExposureBox.Value = Global.UMController.My.MySettings.Default.EXPOSURE
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(99, 304)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 237
        Me.Label6.Text = "min"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(185, 304)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(26, 13)
        Me.Label12.TabIndex = 238
        Me.Label12.Text = "max"
        '
        'Contrast_max_bar
        '
        Me.Contrast_max_bar.Location = New System.Drawing.Point(43, 392)
        Me.Contrast_max_bar.Margin = New System.Windows.Forms.Padding(4)
        Me.Contrast_max_bar.Maximum = 254
        Me.Contrast_max_bar.Minimum = 1
        Me.Contrast_max_bar.Name = "Contrast_max_bar"
        Me.Contrast_max_bar.Size = New System.Drawing.Size(254, 45)
        Me.Contrast_max_bar.TabIndex = 240
        Me.Contrast_max_bar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.Contrast_max_bar.Value = 254
        '
        'Contrast_min_bar
        '
        Me.Contrast_min_bar.Location = New System.Drawing.Point(43, 362)
        Me.Contrast_min_bar.Margin = New System.Windows.Forms.Padding(4)
        Me.Contrast_min_bar.Maximum = 254
        Me.Contrast_min_bar.Name = "Contrast_min_bar"
        Me.Contrast_min_bar.Size = New System.Drawing.Size(254, 45)
        Me.Contrast_min_bar.TabIndex = 239
        Me.Contrast_min_bar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 364)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 188
        Me.Label4.Text = "min"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(18, 394)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(26, 13)
        Me.Label13.TabIndex = 242
        Me.Label13.Text = "max"
        '
        'UnderexposedCheckBox
        '
        Me.UnderexposedCheckBox.AutoSize = True
        Me.UnderexposedCheckBox.Location = New System.Drawing.Point(17, 333)
        Me.UnderexposedCheckBox.Name = "UnderexposedCheckBox"
        Me.UnderexposedCheckBox.Size = New System.Drawing.Size(124, 17)
        Me.UnderexposedCheckBox.TabIndex = 243
        Me.UnderexposedCheckBox.Text = "show  underexposed"
        Me.UnderexposedCheckBox.UseVisualStyleBackColor = True
        '
        'OverexposedCheckBox
        '
        Me.OverexposedCheckBox.AutoSize = True
        Me.OverexposedCheckBox.Location = New System.Drawing.Point(144, 333)
        Me.OverexposedCheckBox.Name = "OverexposedCheckBox"
        Me.OverexposedCheckBox.Size = New System.Drawing.Size(118, 17)
        Me.OverexposedCheckBox.TabIndex = 244
        Me.OverexposedCheckBox.Text = "show  overexposed"
        Me.OverexposedCheckBox.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(297, 772)
        Me.Controls.Add(Me.OverexposedCheckBox)
        Me.Controls.Add(Me.UnderexposedCheckBox)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.SetExposureBox)
        Me.Controls.Add(Me.setstepsize)
        Me.Controls.Add(Me.xyvoxelbutton)
        Me.Controls.Add(Me.MaxIntensityBox)
        Me.Controls.Add(Me.MinIntensityBox)
        Me.Controls.Add(Me.IntensityDistribution)
        Me.Controls.Add(Me.FirstLabel)
        Me.Controls.Add(Me.Zyl2Recall)
        Me.Controls.Add(Me.Zylright2)
        Me.Controls.Add(Me.Zylleft2)
        Me.Controls.Add(Me.ZylLeft1PosRecallButton)
        Me.Controls.Add(Me.ZylLeft1PosStoreButton)
        Me.Controls.Add(Me.Zylright1)
        Me.Controls.Add(Me.Zylleft1)
        Me.Controls.Add(Me.ImageNumberBox)
        Me.Controls.Add(Me.InrLabel)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Contrast_max_bar)
        Me.Controls.Add(Me.Contrast_min_bar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(20, 20)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "UMController"
        Me.TopMost = True
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.JackPosDispl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.RightCylPosDispl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftCylPosDispl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.IntensityDistribution, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xyvoxelbutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setstepsize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SetExposureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Contrast_max_bar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Contrast_min_bar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents InrLabel As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents StageUpButton As System.Windows.Forms.Button
    Private WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents ImageNumberBox As System.Windows.Forms.TextBox
    Friend WithEvents StartButton As System.Windows.Forms.Button
    Public WithEvents StageDownButton As System.Windows.Forms.Button
    'Friend WithEvents AxSlider1 As Axmscomctl.AxSlider
    'Friend WithEvents AxSlider2 As Axmscomctl.AxSlider
    Public WithEvents Zylleft1 As System.Windows.Forms.Button
    Public WithEvents Zylright1 As System.Windows.Forms.Button
    Private WithEvents Label9 As System.Windows.Forms.Label
    'Friend WithEvents GammaSlider As Axmscomctl.AxSlider
    Public WithEvents StagePosStoreButton As System.Windows.Forms.Button
    Public WithEvents StagePosRecallButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Public WithEvents ZylLeft1PosRecallButton As System.Windows.Forms.Button
    Public WithEvents ZylLeft1PosStoreButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Public WithEvents Zyl2Recall As System.Windows.Forms.Button
    Public WithEvents Zyl2store As System.Windows.Forms.Button
    Public WithEvents Zylright2 As System.Windows.Forms.Button
    Public WithEvents Zylleft2 As System.Windows.Forms.Button
    Private WithEvents FirstLabel As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveImageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestoreCameraWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TimeSeriesRecordingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadConfigurationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveConfigurationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BrightnessLossCompensationMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IntensityDistribution As NationalInstruments.UI.WindowsForms.ScatterGraph
    Friend WithEvents ScatterPlot1 As NationalInstruments.UI.ScatterPlot
    Friend WithEvents XAxis1 As NationalInstruments.UI.XAxis
    Friend WithEvents YAxis1 As NationalInstruments.UI.YAxis
    Friend WithEvents MinIntensityBox As System.Windows.Forms.TextBox
    Friend WithEvents MaxIntensityBox As System.Windows.Forms.TextBox
    Friend WithEvents xyvoxelbutton As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents setstepsize As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents SetExposureBox As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents RightCylPosDispl As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents LeftCylPosDispl As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents JackPosDispl As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ZeroStageButton As System.Windows.Forms.Button
    Friend WithEvents ZeroRightCylButton As System.Windows.Forms.Button
    Friend WithEvents ZeroLeftCylButton As System.Windows.Forms.Button
    Friend WithEvents Contrast_max_bar As System.Windows.Forms.TrackBar
    Friend WithEvents Contrast_min_bar As System.Windows.Forms.TrackBar
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents UnderexposedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents OverexposedCheckBox As System.Windows.Forms.CheckBox

End Class
