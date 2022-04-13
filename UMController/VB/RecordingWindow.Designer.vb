<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecordingWindow
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
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Stacksize = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.zvoxel = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.xyvoxel = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.StartRecording = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.RecordingModeBox = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CoverSlideAngle = New NationalInstruments.UI.WindowsForms.NumericEdit()
        Me.FolderList = New System.Windows.Forms.ListBox()
        Me.SelectFolderButton = New System.Windows.Forms.Button()
        Me.DirName = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.SelectFolderDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RemoveItem = New System.Windows.Forms.Button()
        Me.ScanningModeBox = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.StartNumber = New System.Windows.Forms.NumericUpDown()
        Me.NumberOfImages = New System.Windows.Forms.NumericUpDown()
        Me.project = New System.Windows.Forms.TextBox()
        Me.slitaperture = New System.Windows.Forms.TextBox()
        Me.cylinderlens = New System.Windows.Forms.TextBox()
        Me.postmagnification = New System.Windows.Forms.TextBox()
        Me.objective = New System.Windows.Forms.TextBox()
        Me.microscope = New System.Windows.Forms.TextBox()
        Me.power = New System.Windows.Forms.TextBox()
        Me.wavelength = New System.Windows.Forms.TextBox()
        Me.detail = New System.Windows.Forms.TextBox()
        Me.comments = New System.Windows.Forms.TextBox()
        Me.perfusiondate = New System.Windows.Forms.TextBox()
        Me.specimen = New System.Windows.Forms.TextBox()
        Me.experiment = New System.Windows.Forms.TextBox()
        Me.Gradient = New System.Windows.Forms.NumericUpDown()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.CheckCameraRotated = New System.Windows.Forms.CheckBox()
        CType(Me.CoverSlideAngle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumberOfImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gradient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(571, 209)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(85, 17)
        Me.Label21.TabIndex = 98
        Me.Label21.Text = "laser power:"
        '
        'Stacksize
        '
        Me.Stacksize.BackColor = System.Drawing.Color.LightGray
        Me.Stacksize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stacksize.ForeColor = System.Drawing.Color.Black
        Me.Stacksize.Location = New System.Drawing.Point(677, 706)
        Me.Stacksize.Margin = New System.Windows.Forms.Padding(4)
        Me.Stacksize.Name = "Stacksize"
        Me.Stacksize.ReadOnly = True
        Me.Stacksize.Size = New System.Drawing.Size(167, 20)
        Me.Stacksize.TabIndex = 85
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(532, 708)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(124, 17)
        Me.Label20.TabIndex = 97
        Me.Label20.Text = "thickness of stack:"
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(529, 674)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(127, 17)
        Me.Label19.TabIndex = 96
        Me.Label19.Text = "start numbering at:"
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(569, 441)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(87, 17)
        Me.Label18.TabIndex = 95
        Me.Label18.Text = "slit aperture:"
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(579, 407)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(77, 17)
        Me.Label17.TabIndex = 94
        Me.Label17.Text = "light sheet:"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(531, 641)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(125, 17)
        Me.Label16.TabIndex = 93
        Me.Label16.Text = "number of images:"
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(763, 752)
        Me.ButtonCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(97, 43)
        Me.ButtonCancel.TabIndex = 88
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(580, 475)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 17)
        Me.Label14.TabIndex = 91
        Me.Label14.Text = "comments:"
        '
        'zvoxel
        '
        Me.zvoxel.BackColor = System.Drawing.Color.LightGray
        Me.zvoxel.Location = New System.Drawing.Point(677, 340)
        Me.zvoxel.Margin = New System.Windows.Forms.Padding(4)
        Me.zvoxel.Name = "zvoxel"
        Me.zvoxel.ReadOnly = True
        Me.zvoxel.Size = New System.Drawing.Size(315, 20)
        Me.zvoxel.TabIndex = 80
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(572, 341)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 17)
        Me.Label13.TabIndex = 83
        Me.Label13.Text = "voxel size z:"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(530, 308)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(126, 17)
        Me.Label12.TabIndex = 82
        Me.Label12.Text = "post magnification:"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(588, 274)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 17)
        Me.Label11.TabIndex = 81
        Me.Label11.Text = "objective:"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(572, 242)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 17)
        Me.Label10.TabIndex = 79
        Me.Label10.Text = "microscope:"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(514, 176)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 17)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "excitaion wavelength:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(553, 110)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 17)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "perfusion date:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(610, 143)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 17)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "detail:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(584, 78)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "specimen:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(575, 44)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "experiment:"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(549, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "project number:"
        '
        'xyvoxel
        '
        Me.xyvoxel.BackColor = System.Drawing.Color.LightGray
        Me.xyvoxel.Location = New System.Drawing.Point(677, 373)
        Me.xyvoxel.Margin = New System.Windows.Forms.Padding(4)
        Me.xyvoxel.Name = "xyvoxel"
        Me.xyvoxel.ReadOnly = True
        Me.xyvoxel.Size = New System.Drawing.Size(315, 20)
        Me.xyvoxel.TabIndex = 116
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(566, 374)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 17)
        Me.Label6.TabIndex = 117
        Me.Label6.Text = "voxel size xy:"
        '
        'StartRecording
        '
        Me.StartRecording.Location = New System.Drawing.Point(895, 752)
        Me.StartRecording.Margin = New System.Windows.Forms.Padding(4)
        Me.StartRecording.Name = "StartRecording"
        Me.StartRecording.Size = New System.Drawing.Size(97, 43)
        Me.StartRecording.TabIndex = 118
        Me.StartRecording.Text = "Start"
        Me.StartRecording.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(516, 542)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(140, 17)
        Me.Label24.TabIndex = 119
        Me.Label24.Text = "illumination direction:"
        '
        'RecordingModeBox
        '
        Me.RecordingModeBox.FormattingEnabled = True
        Me.RecordingModeBox.Items.AddRange(New Object() {"left sided", "right sided", "double sided"})
        Me.RecordingModeBox.Location = New System.Drawing.Point(677, 539)
        Me.RecordingModeBox.Margin = New System.Windows.Forms.Padding(4)
        Me.RecordingModeBox.Name = "RecordingModeBox"
        Me.RecordingModeBox.Size = New System.Drawing.Size(167, 21)
        Me.RecordingModeBox.TabIndex = 120
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(28, 760)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(508, 17)
        Me.Label8.TabIndex = 131
        Me.Label8.Text = "angle for cover slide scanning (-60°to 60°, sign indicates direction of lens shif" &
    "t):"
        '
        'CoverSlideAngle
        '
        Me.CoverSlideAngle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoverSlideAngle.Location = New System.Drawing.Point(538, 758)
        Me.CoverSlideAngle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CoverSlideAngle.Name = "CoverSlideAngle"
        Me.CoverSlideAngle.Range = New NationalInstruments.UI.Range(-60.0R, 60.0R)
        Me.CoverSlideAngle.Size = New System.Drawing.Size(120, 23)
        Me.CoverSlideAngle.TabIndex = 132
        '
        'FolderList
        '
        Me.FolderList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FolderList.FormattingEnabled = True
        Me.FolderList.HorizontalScrollbar = True
        Me.FolderList.ItemHeight = 16
        Me.FolderList.Location = New System.Drawing.Point(31, 37)
        Me.FolderList.Margin = New System.Windows.Forms.Padding(4)
        Me.FolderList.Name = "FolderList"
        Me.FolderList.Size = New System.Drawing.Size(377, 484)
        Me.FolderList.TabIndex = 133
        '
        'SelectFolderButton
        '
        Me.SelectFolderButton.Location = New System.Drawing.Point(31, 546)
        Me.SelectFolderButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SelectFolderButton.Name = "SelectFolderButton"
        Me.SelectFolderButton.Size = New System.Drawing.Size(179, 39)
        Me.SelectFolderButton.TabIndex = 134
        Me.SelectFolderButton.Text = "Add new path..."
        Me.SelectFolderButton.UseVisualStyleBackColor = True
        '
        'DirName
        '
        Me.DirName.Location = New System.Drawing.Point(32, 643)
        Me.DirName.Margin = New System.Windows.Forms.Padding(4)
        Me.DirName.Name = "DirName"
        Me.DirName.Size = New System.Drawing.Size(376, 20)
        Me.DirName.TabIndex = 136
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(29, 618)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 16)
        Me.Label15.TabIndex = 137
        Me.Label15.Text = "data folder name:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(29, 11)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(161, 16)
        Me.Label9.TabIndex = 135
        Me.Label9.Text = "select path for data folder:"
        '
        'RemoveItem
        '
        Me.RemoveItem.Location = New System.Drawing.Point(229, 546)
        Me.RemoveItem.Margin = New System.Windows.Forms.Padding(4)
        Me.RemoveItem.Name = "RemoveItem"
        Me.RemoveItem.Size = New System.Drawing.Size(180, 39)
        Me.RemoveItem.TabIndex = 138
        Me.RemoveItem.Text = "Remove path"
        Me.RemoveItem.UseVisualStyleBackColor = True
        '
        'ScanningModeBox
        '
        Me.ScanningModeBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScanningModeBox.FormattingEnabled = True
        Me.ScanningModeBox.Items.AddRange(New Object() {"singlescan", "multiscan 3-fold", "multiscan 5-fold"})
        Me.ScanningModeBox.Location = New System.Drawing.Point(677, 606)
        Me.ScanningModeBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ScanningModeBox.Name = "ScanningModeBox"
        Me.ScanningModeBox.Size = New System.Drawing.Size(167, 21)
        Me.ScanningModeBox.TabIndex = 140
        Me.ScanningModeBox.Text = "singlescan"
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(548, 607)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(108, 17)
        Me.Label22.TabIndex = 141
        Me.Label22.Text = "scanning mode:"
        '
        'StartNumber
        '
        Me.StartNumber.Location = New System.Drawing.Point(677, 673)
        Me.StartNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.StartNumber.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.StartNumber.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.StartNumber.Name = "StartNumber"
        Me.StartNumber.Size = New System.Drawing.Size(167, 20)
        Me.StartNumber.TabIndex = 113
        Me.StartNumber.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NumberOfImages
        '
        Me.NumberOfImages.Location = New System.Drawing.Point(677, 640)
        Me.NumberOfImages.Margin = New System.Windows.Forms.Padding(4)
        Me.NumberOfImages.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NumberOfImages.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumberOfImages.Name = "NumberOfImages"
        Me.NumberOfImages.Size = New System.Drawing.Size(167, 20)
        Me.NumberOfImages.TabIndex = 112
        Me.NumberOfImages.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'project
        '
        Me.project.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.UMController.My.MySettings.Default, "PROJECTNR", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.project.Location = New System.Drawing.Point(677, 10)
        Me.project.Margin = New System.Windows.Forms.Padding(4)
        Me.project.Name = "project"
        Me.project.Size = New System.Drawing.Size(315, 20)
        Me.project.TabIndex = 129
        Me.project.Text = Global.UMController.My.MySettings.Default.PROJECTNR
        '
        'slitaperture
        '
        Me.slitaperture.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.UMController.My.MySettings.Default, "SLIT", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.slitaperture.Location = New System.Drawing.Point(677, 439)
        Me.slitaperture.Margin = New System.Windows.Forms.Padding(4)
        Me.slitaperture.Name = "slitaperture"
        Me.slitaperture.Size = New System.Drawing.Size(315, 20)
        Me.slitaperture.TabIndex = 128
        Me.slitaperture.Text = Global.UMController.My.MySettings.Default.SLIT
        '
        'cylinderlens
        '
        Me.cylinderlens.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.UMController.My.MySettings.Default, "CYLLENS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cylinderlens.Location = New System.Drawing.Point(677, 406)
        Me.cylinderlens.Margin = New System.Windows.Forms.Padding(4)
        Me.cylinderlens.Name = "cylinderlens"
        Me.cylinderlens.Size = New System.Drawing.Size(315, 20)
        Me.cylinderlens.TabIndex = 127
        Me.cylinderlens.Text = Global.UMController.My.MySettings.Default.CYLLENS
        '
        'postmagnification
        '
        Me.postmagnification.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.UMController.My.MySettings.Default, "POSTMAG", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.postmagnification.Location = New System.Drawing.Point(677, 306)
        Me.postmagnification.Margin = New System.Windows.Forms.Padding(4)
        Me.postmagnification.Name = "postmagnification"
        Me.postmagnification.Size = New System.Drawing.Size(315, 20)
        Me.postmagnification.TabIndex = 126
        Me.postmagnification.Text = Global.UMController.My.MySettings.Default.POSTMAG
        '
        'objective
        '
        Me.objective.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.UMController.My.MySettings.Default, "OBJECTIVE", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.objective.Location = New System.Drawing.Point(677, 274)
        Me.objective.Margin = New System.Windows.Forms.Padding(4)
        Me.objective.Name = "objective"
        Me.objective.Size = New System.Drawing.Size(315, 20)
        Me.objective.TabIndex = 125
        Me.objective.Text = Global.UMController.My.MySettings.Default.OBJECTIVE
        '
        'microscope
        '
        Me.microscope.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.UMController.My.MySettings.Default, "MICROSCOPE", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.microscope.Location = New System.Drawing.Point(677, 241)
        Me.microscope.Margin = New System.Windows.Forms.Padding(4)
        Me.microscope.Name = "microscope"
        Me.microscope.Size = New System.Drawing.Size(315, 20)
        Me.microscope.TabIndex = 124
        Me.microscope.Text = Global.UMController.My.MySettings.Default.MICROSCOPE
        '
        'power
        '
        Me.power.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.UMController.My.MySettings.Default, "LASERPOWER", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.power.Location = New System.Drawing.Point(677, 208)
        Me.power.Margin = New System.Windows.Forms.Padding(4)
        Me.power.Name = "power"
        Me.power.Size = New System.Drawing.Size(315, 20)
        Me.power.TabIndex = 123
        Me.power.Text = Global.UMController.My.MySettings.Default.LASERPOWER
        '
        'wavelength
        '
        Me.wavelength.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.UMController.My.MySettings.Default, "WAVELENGTH", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.wavelength.Location = New System.Drawing.Point(677, 175)
        Me.wavelength.Margin = New System.Windows.Forms.Padding(4)
        Me.wavelength.Name = "wavelength"
        Me.wavelength.Size = New System.Drawing.Size(315, 20)
        Me.wavelength.TabIndex = 122
        Me.wavelength.Text = Global.UMController.My.MySettings.Default.WAVELENGTH
        '
        'detail
        '
        Me.detail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.UMController.My.MySettings.Default, "DETAIL", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.detail.Location = New System.Drawing.Point(677, 142)
        Me.detail.Margin = New System.Windows.Forms.Padding(4)
        Me.detail.Name = "detail"
        Me.detail.Size = New System.Drawing.Size(315, 20)
        Me.detail.TabIndex = 121
        Me.detail.Text = Global.UMController.My.MySettings.Default.DETAIL
        '
        'comments
        '
        Me.comments.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.UMController.My.MySettings.Default, "COMMENTS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.comments.Location = New System.Drawing.Point(677, 475)
        Me.comments.Margin = New System.Windows.Forms.Padding(4)
        Me.comments.Multiline = True
        Me.comments.Name = "comments"
        Me.comments.Size = New System.Drawing.Size(315, 47)
        Me.comments.TabIndex = 84
        Me.comments.Text = Global.UMController.My.MySettings.Default.COMMENTS
        '
        'perfusiondate
        '
        Me.perfusiondate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.UMController.My.MySettings.Default, "PERFUSIONDATE", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.perfusiondate.Location = New System.Drawing.Point(677, 110)
        Me.perfusiondate.Margin = New System.Windows.Forms.Padding(4)
        Me.perfusiondate.Name = "perfusiondate"
        Me.perfusiondate.Size = New System.Drawing.Size(315, 20)
        Me.perfusiondate.TabIndex = 69
        Me.perfusiondate.Text = Global.UMController.My.MySettings.Default.PERFUSIONDATE
        '
        'specimen
        '
        Me.specimen.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.UMController.My.MySettings.Default, "SPECIMEN", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.specimen.Location = New System.Drawing.Point(677, 76)
        Me.specimen.Margin = New System.Windows.Forms.Padding(4)
        Me.specimen.Name = "specimen"
        Me.specimen.Size = New System.Drawing.Size(315, 20)
        Me.specimen.TabIndex = 68
        Me.specimen.Text = Global.UMController.My.MySettings.Default.SPECIMEN
        '
        'experiment
        '
        Me.experiment.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.UMController.My.MySettings.Default, "EXPERIMENT", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.experiment.Location = New System.Drawing.Point(677, 43)
        Me.experiment.Margin = New System.Windows.Forms.Padding(4)
        Me.experiment.Name = "experiment"
        Me.experiment.Size = New System.Drawing.Size(315, 20)
        Me.experiment.TabIndex = 66
        Me.experiment.Text = Global.UMController.My.MySettings.Default.EXPERIMENT
        '
        'Gradient
        '
        Me.Gradient.DecimalPlaces = 8
        Me.Gradient.Increment = New Decimal(New Integer() {1, 0, 0, 262144})
        Me.Gradient.Location = New System.Drawing.Point(677, 573)
        Me.Gradient.Margin = New System.Windows.Forms.Padding(4)
        Me.Gradient.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.Gradient.Name = "Gradient"
        Me.Gradient.Size = New System.Drawing.Size(167, 20)
        Me.Gradient.TabIndex = 142
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(460, 575)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(196, 17)
        Me.Label23.TabIndex = 143
        Me.Label23.Text = "z-intensity correction [ms/µm]:"
        '
        'CheckCameraRotated
        '
        Me.CheckCameraRotated.AutoSize = True
        Me.CheckCameraRotated.Location = New System.Drawing.Point(851, 609)
        Me.CheckCameraRotated.Name = "CheckCameraRotated"
        Me.CheckCameraRotated.Size = New System.Drawing.Size(140, 17)
        Me.CheckCameraRotated.TabIndex = 144
        Me.CheckCameraRotated.Text = "camera is rotated by 90°"
        Me.CheckCameraRotated.UseVisualStyleBackColor = True
        '
        'RecordingWindow
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1027, 807)
        Me.ControlBox = False
        Me.Controls.Add(Me.CheckCameraRotated)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Gradient)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.ScanningModeBox)
        Me.Controls.Add(Me.RemoveItem)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.DirName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.SelectFolderButton)
        Me.Controls.Add(Me.FolderList)
        Me.Controls.Add(Me.CoverSlideAngle)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.project)
        Me.Controls.Add(Me.slitaperture)
        Me.Controls.Add(Me.cylinderlens)
        Me.Controls.Add(Me.postmagnification)
        Me.Controls.Add(Me.objective)
        Me.Controls.Add(Me.microscope)
        Me.Controls.Add(Me.power)
        Me.Controls.Add(Me.wavelength)
        Me.Controls.Add(Me.detail)
        Me.Controls.Add(Me.RecordingModeBox)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.StartRecording)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.xyvoxel)
        Me.Controls.Add(Me.StartNumber)
        Me.Controls.Add(Me.NumberOfImages)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Stacksize)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.comments)
        Me.Controls.Add(Me.zvoxel)
        Me.Controls.Add(Me.perfusiondate)
        Me.Controls.Add(Me.specimen)
        Me.Controls.Add(Me.experiment)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RecordingWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recording parameters"
        Me.TopMost = True
        CType(Me.CoverSlideAngle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumberOfImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gradient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Stacksize As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents comments As System.Windows.Forms.TextBox
    Friend WithEvents zvoxel As System.Windows.Forms.TextBox
    Friend WithEvents perfusiondate As System.Windows.Forms.TextBox
    Friend WithEvents specimen As System.Windows.Forms.TextBox
    Friend WithEvents experiment As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumberOfImages As NumericUpDown
    Friend WithEvents StartNumber As NumericUpDown
    Friend WithEvents xyvoxel As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents StartRecording As System.Windows.Forms.Button
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents RecordingModeBox As System.Windows.Forms.ComboBox
    Friend WithEvents detail As System.Windows.Forms.TextBox
    Friend WithEvents wavelength As System.Windows.Forms.TextBox
    Friend WithEvents power As System.Windows.Forms.TextBox
    Friend WithEvents microscope As System.Windows.Forms.TextBox
    Friend WithEvents objective As System.Windows.Forms.TextBox
    Friend WithEvents postmagnification As System.Windows.Forms.TextBox
    Friend WithEvents cylinderlens As System.Windows.Forms.TextBox
    Friend WithEvents slitaperture As System.Windows.Forms.TextBox
    Friend WithEvents project As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CoverSlideAngle As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents FolderList As System.Windows.Forms.ListBox
    Friend WithEvents SelectFolderButton As System.Windows.Forms.Button
    Friend WithEvents DirName As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents SelectFolderDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents RemoveItem As System.Windows.Forms.Button
    Friend WithEvents ScanningModeBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Gradient As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents CheckCameraRotated As System.Windows.Forms.CheckBox
End Class
