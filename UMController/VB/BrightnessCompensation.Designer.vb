<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BrightnessCompensation
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CalibrationGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph()
        Me.WaveformPlot1 = New NationalInstruments.UI.WaveformPlot()
        Me.XAxis1 = New NationalInstruments.UI.XAxis()
        Me.YAxis1 = New NationalInstruments.UI.YAxis()
        Me.AlphaSlider = New NationalInstruments.UI.WindowsForms.Slide()
        Me.GammaSlider = New NationalInstruments.UI.WindowsForms.Slide()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonHorizontal = New System.Windows.Forms.RadioButton()
        Me.ButtonVertical = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BRCorrONOFF = New System.Windows.Forms.CheckBox()
        Me.Clip16BitCheckBox = New System.Windows.Forms.CheckBox()
        CType(Me.CalibrationGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlphaSlider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GammaSlider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CalibrationGraph
        '
        Me.CalibrationGraph.Border = NationalInstruments.UI.Border.None
        Me.CalibrationGraph.Enabled = False
        Me.CalibrationGraph.InteractionMode = NationalInstruments.UI.GraphInteractionModes.None
        Me.CalibrationGraph.Location = New System.Drawing.Point(4, 5)
        Me.CalibrationGraph.Margin = New System.Windows.Forms.Padding(4)
        Me.CalibrationGraph.Name = "CalibrationGraph"
        Me.CalibrationGraph.PlotAreaBorder = NationalInstruments.UI.Border.Solid
        Me.CalibrationGraph.PlotAreaColor = System.Drawing.Color.White
        Me.CalibrationGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.WaveformPlot1})
        Me.CalibrationGraph.Size = New System.Drawing.Size(397, 204)
        Me.CalibrationGraph.TabIndex = 0
        Me.CalibrationGraph.TabStop = False
        Me.CalibrationGraph.UseColorGenerator = True
        Me.CalibrationGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.XAxis1})
        Me.CalibrationGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.YAxis1})
        Me.CalibrationGraph.ZoomAnimation = False
        '
        'WaveformPlot1
        '
        Me.WaveformPlot1.CanScaleYAxis = False
        Me.WaveformPlot1.LineColor = System.Drawing.Color.MediumBlue
        Me.WaveformPlot1.LineColorPrecedence = NationalInstruments.UI.ColorPrecedence.UserDefinedColor
        Me.WaveformPlot1.LineWidth = 2.0!
        Me.WaveformPlot1.PointColor = System.Drawing.Color.Black
        Me.WaveformPlot1.XAxis = Me.XAxis1
        Me.WaveformPlot1.YAxis = Me.YAxis1
        '
        'XAxis1
        '
        Me.XAxis1.InteractionMode = NationalInstruments.UI.ScaleInteractionMode.None
        Me.XAxis1.MajorDivisions.GridColor = System.Drawing.Color.DarkGray
        Me.XAxis1.MajorDivisions.GridLineStyle = NationalInstruments.UI.LineStyle.Dot
        Me.XAxis1.MajorDivisions.GridVisible = True
        Me.XAxis1.MajorDivisions.TickVisible = False
        Me.XAxis1.Mode = NationalInstruments.UI.AxisMode.Fixed
        Me.XAxis1.Range = New NationalInstruments.UI.Range(0.0R, 2048.0R)
        '
        'YAxis1
        '
        Me.YAxis1.InteractionMode = NationalInstruments.UI.ScaleInteractionMode.None
        Me.YAxis1.MajorDivisions.GridColor = System.Drawing.Color.DarkGray
        Me.YAxis1.MajorDivisions.GridLineStyle = NationalInstruments.UI.LineStyle.Dot
        Me.YAxis1.MajorDivisions.GridVisible = True
        Me.YAxis1.MajorDivisions.Interval = 10.0R
        Me.YAxis1.MajorDivisions.TickVisible = False
        Me.YAxis1.Range = New NationalInstruments.UI.Range(1.0R, 11.0R)
        '
        'AlphaSlider
        '
        Me.AlphaSlider.Enabled = False
        Me.AlphaSlider.InteractionMode = NationalInstruments.UI.LinearNumericPointerInteractionModes.DragPointer
        Me.AlphaSlider.Location = New System.Drawing.Point(6, 236)
        Me.AlphaSlider.MajorDivisions.TickVisible = False
        Me.AlphaSlider.Margin = New System.Windows.Forms.Padding(4)
        Me.AlphaSlider.MinorDivisions.TickVisible = False
        Me.AlphaSlider.Name = "AlphaSlider"
        Me.AlphaSlider.Range = New NationalInstruments.UI.Range(1.0R, 10.0R)
        Me.AlphaSlider.ScalePosition = NationalInstruments.UI.NumericScalePosition.Bottom
        Me.AlphaSlider.Size = New System.Drawing.Size(389, 44)
        Me.AlphaSlider.SlideStyle = NationalInstruments.UI.SlideStyle.SunkenWithGrip
        Me.AlphaSlider.TabIndex = 1
        Me.AlphaSlider.Value = 1.0R
        '
        'GammaSlider
        '
        Me.GammaSlider.Enabled = False
        Me.GammaSlider.Location = New System.Drawing.Point(6, 303)
        Me.GammaSlider.MajorDivisions.TickVisible = False
        Me.GammaSlider.Margin = New System.Windows.Forms.Padding(4)
        Me.GammaSlider.MinorDivisions.TickVisible = False
        Me.GammaSlider.Name = "GammaSlider"
        Me.GammaSlider.Range = New NationalInstruments.UI.Range(0.20000000000000001R, 5.0R)
        Me.GammaSlider.ScalePosition = NationalInstruments.UI.NumericScalePosition.Bottom
        Me.GammaSlider.ScaleType = NationalInstruments.UI.ScaleType.Logarithmic
        Me.GammaSlider.Size = New System.Drawing.Size(389, 44)
        Me.GammaSlider.SlideStyle = NationalInstruments.UI.SlideStyle.SunkenWithGrip
        Me.GammaSlider.TabIndex = 2
        Me.GammaSlider.Value = 1.0R
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(24, 389)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 32)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(75, 389)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(39, 32)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(124, 389)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(39, 32)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(172, 389)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(61, 32)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "flat"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 361)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "function type"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(306, 443)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(81, 32)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "close"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 215)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "magnitude"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 285)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "curvature"
        '
        'ButtonHorizontal
        '
        Me.ButtonHorizontal.AutoSize = True
        Me.ButtonHorizontal.Checked = True
        Me.ButtonHorizontal.Enabled = False
        Me.ButtonHorizontal.Location = New System.Drawing.Point(251, 384)
        Me.ButtonHorizontal.Name = "ButtonHorizontal"
        Me.ButtonHorizontal.Size = New System.Drawing.Size(70, 17)
        Me.ButtonHorizontal.TabIndex = 12
        Me.ButtonHorizontal.TabStop = True
        Me.ButtonHorizontal.Text = "horizontal"
        Me.ButtonHorizontal.UseVisualStyleBackColor = True
        '
        'ButtonVertical
        '
        Me.ButtonVertical.AutoSize = True
        Me.ButtonVertical.Enabled = False
        Me.ButtonVertical.Location = New System.Drawing.Point(251, 406)
        Me.ButtonVertical.Name = "ButtonVertical"
        Me.ButtonVertical.Size = New System.Drawing.Size(59, 17)
        Me.ButtonVertical.TabIndex = 13
        Me.ButtonVertical.Text = "vertical"
        Me.ButtonVertical.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(248, 361)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "direction:"
        '
        'BRCorrONOFF
        '
        Me.BRCorrONOFF.AutoSize = True
        Me.BRCorrONOFF.Location = New System.Drawing.Point(24, 461)
        Me.BRCorrONOFF.Name = "BRCorrONOFF"
        Me.BRCorrONOFF.Size = New System.Drawing.Size(174, 17)
        Me.BRCorrONOFF.TabIndex = 15
        Me.BRCorrONOFF.Text = "Apply brightness loss correction"
        Me.BRCorrONOFF.UseVisualStyleBackColor = True
        '
        'Clip16BitCheckBox
        '
        Me.Clip16BitCheckBox.AutoSize = True
        Me.Clip16BitCheckBox.Enabled = False
        Me.Clip16BitCheckBox.Location = New System.Drawing.Point(24, 438)
        Me.Clip16BitCheckBox.Name = "Clip16BitCheckBox"
        Me.Clip16BitCheckBox.Size = New System.Drawing.Size(189, 17)
        Me.Clip16BitCheckBox.TabIndex = 16
        Me.Clip16BitCheckBox.Text = "Clip to 16 bit range (preview mode)"
        Me.Clip16BitCheckBox.UseVisualStyleBackColor = True
        '
        'BrightnessCompensation
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(400, 488)
        Me.ControlBox = False
        Me.Controls.Add(Me.Clip16BitCheckBox)
        Me.Controls.Add(Me.BRCorrONOFF)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ButtonVertical)
        Me.Controls.Add(Me.ButtonHorizontal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GammaSlider)
        Me.Controls.Add(Me.AlphaSlider)
        Me.Controls.Add(Me.CalibrationGraph)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BrightnessCompensation"
        Me.ShowInTaskbar = False
        Me.Text = "BrightnessCompensation"
        Me.TopMost = True
        CType(Me.CalibrationGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlphaSlider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GammaSlider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CalibrationGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    Friend WithEvents WaveformPlot1 As NationalInstruments.UI.WaveformPlot
    Friend WithEvents XAxis1 As NationalInstruments.UI.XAxis
    Friend WithEvents YAxis1 As NationalInstruments.UI.YAxis
    Friend WithEvents AlphaSlider As NationalInstruments.UI.WindowsForms.Slide
    Friend WithEvents GammaSlider As NationalInstruments.UI.WindowsForms.Slide
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ButtonHorizontal As System.Windows.Forms.RadioButton
    Friend WithEvents ButtonVertical As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BRCorrONOFF As System.Windows.Forms.CheckBox
    Friend WithEvents Clip16BitCheckBox As System.Windows.Forms.CheckBox
End Class
