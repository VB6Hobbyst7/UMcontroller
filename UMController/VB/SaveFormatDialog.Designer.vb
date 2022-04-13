<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaveFormatDialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SaveRAWButton = New System.Windows.Forms.Button()
        Me.SaveTIFFButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SaveFileDialog2 = New System.Windows.Forms.SaveFileDialog()
        Me.SaveFloatButton = New System.Windows.Forms.Button()
        Me.SaveFileDialog3 = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'SaveRAWButton
        '
        Me.SaveRAWButton.Location = New System.Drawing.Point(144, 70)
        Me.SaveRAWButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SaveRAWButton.Name = "SaveRAWButton"
        Me.SaveRAWButton.Size = New System.Drawing.Size(100, 28)
        Me.SaveRAWButton.TabIndex = 0
        Me.SaveRAWButton.Text = "TIFF16 Grey"
        Me.SaveRAWButton.UseVisualStyleBackColor = True
        '
        'SaveTIFFButton
        '
        Me.SaveTIFFButton.Location = New System.Drawing.Point(24, 70)
        Me.SaveTIFFButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SaveTIFFButton.Name = "SaveTIFFButton"
        Me.SaveTIFFButton.Size = New System.Drawing.Size(100, 28)
        Me.SaveTIFFButton.TabIndex = 1
        Me.SaveTIFFButton.Text = "RGB TIFF32"
        Me.SaveTIFFButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Please select data format"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Tif-Dateien|*.tif"
        '
        'SaveFileDialog2
        '
        Me.SaveFileDialog2.Filter = "Tif16-Dateien|*.tif"
        '
        'SaveFloatButton
        '
        Me.SaveFloatButton.Location = New System.Drawing.Point(263, 70)
        Me.SaveFloatButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SaveFloatButton.Name = "SaveFloatButton"
        Me.SaveFloatButton.Size = New System.Drawing.Size(100, 28)
        Me.SaveFloatButton.TabIndex = 4
        Me.SaveFloatButton.Text = "TIFF 32 float"
        Me.SaveFloatButton.UseVisualStyleBackColor = True
        '
        'SaveFileDialog3
        '
        Me.SaveFileDialog3.Filter = "Tif16-Dateien|*.tif"
        '
        'SaveFormatDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(393, 121)
        Me.Controls.Add(Me.SaveFloatButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SaveTIFFButton)
        Me.Controls.Add(Me.SaveRAWButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SaveFormatDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Save Single Image"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SaveRAWButton As System.Windows.Forms.Button
    Friend WithEvents SaveTIFFButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents SaveFileDialog2 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents SaveFloatButton As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog3 As System.Windows.Forms.SaveFileDialog
End Class
