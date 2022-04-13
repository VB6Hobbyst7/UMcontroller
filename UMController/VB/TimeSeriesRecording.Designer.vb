<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimeSeriesRecording
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
        Me.components = New System.ComponentModel.Container()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Form2_Cancel_But = New System.Windows.Forms.Button()
        Me.StartRecording = New System.Windows.Forms.Button()
        Me.Dirname = New System.Windows.Forms.TextBox()
        Me.NumberOfImages = New System.Windows.Forms.NumericUpDown()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TimeGap = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RecordingModeBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SelectPath = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.NumberOfImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeGap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(23, 14)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(131, 17)
        Me.Label15.TabIndex = 92
        Me.Label15.Text = "output folder name:"
        '
        'Form2_Cancel_But
        '
        Me.Form2_Cancel_But.Location = New System.Drawing.Point(208, 223)
        Me.Form2_Cancel_But.Margin = New System.Windows.Forms.Padding(4)
        Me.Form2_Cancel_But.Name = "Form2_Cancel_But"
        Me.Form2_Cancel_But.Size = New System.Drawing.Size(97, 32)
        Me.Form2_Cancel_But.TabIndex = 88
        Me.Form2_Cancel_But.Text = "Cancel"
        Me.Form2_Cancel_But.UseVisualStyleBackColor = True
        '
        'StartRecording
        '
        Me.StartRecording.Location = New System.Drawing.Point(319, 223)
        Me.StartRecording.Margin = New System.Windows.Forms.Padding(4)
        Me.StartRecording.Name = "StartRecording"
        Me.StartRecording.Size = New System.Drawing.Size(97, 32)
        Me.StartRecording.TabIndex = 89
        Me.StartRecording.Text = "Start"
        Me.StartRecording.UseVisualStyleBackColor = True
        '
        'Dirname
        '
        Me.Dirname.Location = New System.Drawing.Point(19, 38)
        Me.Dirname.Margin = New System.Windows.Forms.Padding(4)
        Me.Dirname.Name = "Dirname"
        Me.Dirname.Size = New System.Drawing.Size(397, 20)
        Me.Dirname.TabIndex = 90
        '
        'NumberOfImages
        '
        Me.NumberOfImages.Location = New System.Drawing.Point(249, 82)
        Me.NumberOfImages.Margin = New System.Windows.Forms.Padding(4)
        Me.NumberOfImages.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.NumberOfImages.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumberOfImages.Name = "NumberOfImages"
        Me.NumberOfImages.Size = New System.Drawing.Size(168, 20)
        Me.NumberOfImages.TabIndex = 112
        Me.NumberOfImages.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(17, 80)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(125, 17)
        Me.Label16.TabIndex = 93
        Me.Label16.Text = "number of images:"
        '
        'TimeGap
        '
        Me.TimeGap.Location = New System.Drawing.Point(249, 128)
        Me.TimeGap.Margin = New System.Windows.Forms.Padding(4)
        Me.TimeGap.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.TimeGap.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.TimeGap.Name = "TimeGap"
        Me.TimeGap.Size = New System.Drawing.Size(168, 20)
        Me.TimeGap.TabIndex = 116
        Me.TimeGap.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 131)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 17)
        Me.Label1.TabIndex = 117
        Me.Label1.Text = "time between images [s]"
        '
        'Timer1
        '
        Me.Timer1.Interval = 300000
        '
        'RecordingModeBox
        '
        Me.RecordingModeBox.FormattingEnabled = True
        Me.RecordingModeBox.Items.AddRange(New Object() {"left sided", "right sided", "double sided"})
        Me.RecordingModeBox.Location = New System.Drawing.Point(249, 175)
        Me.RecordingModeBox.Margin = New System.Windows.Forms.Padding(4)
        Me.RecordingModeBox.Name = "RecordingModeBox"
        Me.RecordingModeBox.Size = New System.Drawing.Size(167, 21)
        Me.RecordingModeBox.TabIndex = 121
        Me.RecordingModeBox.Text = "left sided"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 178)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 16)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "recording mode"
        '
        'SelectPath
        '
        Me.SelectPath.Location = New System.Drawing.Point(17, 223)
        Me.SelectPath.Margin = New System.Windows.Forms.Padding(4)
        Me.SelectPath.Name = "SelectPath"
        Me.SelectPath.Size = New System.Drawing.Size(157, 32)
        Me.SelectPath.TabIndex = 124
        Me.SelectPath.Text = "Select new path..."
        Me.SelectPath.UseVisualStyleBackColor = True
        '
        'FolderBrowserDialog
        '
        Me.FolderBrowserDialog.Description = "select path for data folder"
        Me.FolderBrowserDialog.SelectedPath = "C:\Users\klaus\Desktop"
        '
        'TimeSeriesRecording
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(432, 262)
        Me.Controls.Add(Me.SelectPath)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RecordingModeBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TimeGap)
        Me.Controls.Add(Me.NumberOfImages)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Form2_Cancel_But)
        Me.Controls.Add(Me.StartRecording)
        Me.Controls.Add(Me.Dirname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TimeSeriesRecording"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RecordingWindow"
        Me.TopMost = True
        CType(Me.NumberOfImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeGap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Form2_Cancel_But As System.Windows.Forms.Button
    Friend WithEvents StartRecording As System.Windows.Forms.Button
    Friend WithEvents Dirname As System.Windows.Forms.TextBox
    Friend WithEvents NumberOfImages As NumericUpDown
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TimeGap As NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer   
    Friend WithEvents RecordingModeBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SelectPath As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
End Class
