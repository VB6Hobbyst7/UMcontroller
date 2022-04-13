Imports System.Math

Public Class BrightnessCompensation

    Private alpha, gamma As Double
    Private functionType As Integer = 1

    Public Sub GetFunctionparameters(ByRef alpha_value As Double, ByRef gamma_value As Double, ByRef eq As String)
        alpha_value = alpha
        gamma_value = gamma

        Select Case __BrightnessCorrDirection
            Case 1
                Select Case functionType
                    Case 1
                        eq = "y = (alpha - 1) * (x / xmax) ^ gamma + 1"
                    Case 2
                        eq = "y = (alpha - 1) * ((xmax - x) / xmax) ^ gamma + 1"
                    Case 3
                        eq = "y = alpha - (alpha - 1) / Abs((xmax / 2) ^ gamma) * Abs((Abs(x - xmax / 2)) ^ gamma)"
                End Select

            Case 2
                Select Case functionType
                    Case 1
                        eq = "y = (alpha - 1) * (x / ymax) ^ gamma + 1"
                    Case 2
                        eq = "y = (alpha - 1) * ((ymax - x) / ymax) ^ gamma + 1"
                    Case 3
                        eq = "y = alpha - (alpha - 1) / Abs((ymax / 2) ^ gamma) * Abs((Abs(x - ymax / 2)) ^ gamma)"
                End Select
        End Select
    End Sub

    Private Sub AlphaSlider_AfterChangeValue(sender As Object, e As EventArgs) Handles AlphaSlider.AfterChangeValue

        alpha = AlphaSlider.Value
        gamma = GammaSlider.Value

        Dim i As Integer
        Dim xmax As Integer = ImageProcessing.Xres
        Dim ymax As Integer = ImageProcessing.Yres

        __BrightnessCorrFactorsMax = 0
        Select Case __BrightnessCorrDirection
            Case 1
                For i = 0 To xmax - 1
                    Select Case functionType
                        Case 1
                            __BrightnessCorrFactors(i) = (alpha - 1) * (i / xmax) ^ gamma + 1
                        Case 2
                            __BrightnessCorrFactors(i) = (alpha - 1) * ((xmax - i) / xmax) ^ gamma + 1
                        Case 3
                            __BrightnessCorrFactors(i) = alpha - (alpha - 1) / Abs((xmax / 2) ^ gamma) * Abs((Abs(i - xmax / 2)) ^ gamma)
                    End Select

                    'get maximum brightness correction factor
                    If __BrightnessCorrFactors(i) > __BrightnessCorrFactorsMax Then
                        __BrightnessCorrFactorsMax = __BrightnessCorrFactors(i)
                    End If
                Next

            Case 2
                'ReDim BRIGHTNESSCORR_FACTORS(ymax - 1)
                For i = 0 To ymax - 1
                    Select Case functionType
                        Case 1
                            __BrightnessCorrFactors(i) = (alpha - 1) * (i / ymax) ^ gamma + 1
                        Case 2
                            __BrightnessCorrFactors(i) = (alpha - 1) * ((ymax - i) / ymax) ^ gamma + 1
                        Case 3
                            __BrightnessCorrFactors(i) = alpha - (alpha - 1) / Abs((ymax / 2) ^ gamma) * Abs((Abs(i - ymax / 2)) ^ gamma)
                    End Select

                    'get maximum brightness correction factor
                    If __BrightnessCorrFactors(i) > __BrightnessCorrFactorsMax Then
                        __BrightnessCorrFactorsMax = __BrightnessCorrFactors(i)
                    End If
                Next
        End Select

        CalibrationGraph.PlotY(__BrightnessCorrFactors)
    End Sub

    Private Sub AlphaSlider_KeyDown(sender As Object, e As KeyEventArgs) Handles AlphaSlider.KeyDown

        MainForm.MainForm_KeyDown(sender, e)
    End Sub

    Private Sub BRCorrONOFF_CheckedChanged(sender As Object, e As EventArgs) Handles BRCorrONOFF.CheckedChanged

        If BRCorrONOFF.Checked Then
            CalibrationGraph.Enabled = True
            AlphaSlider.Enabled = True
            GammaSlider.Enabled = True
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
            ButtonHorizontal.Enabled = True
            ButtonVertical.Enabled = True
            __BrCorrEnabled = True
            Clip16BitCheckBox.Enabled = True
        Else
            Button4_Click(sender, e)
            CalibrationGraph.Enabled = False
            AlphaSlider.Enabled = False
            GammaSlider.Enabled = False
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            ButtonHorizontal.Enabled = False
            ButtonVertical.Enabled = False
            __BrCorrEnabled = False
            Clip16BitCheckBox.Enabled = False
        End If
    End Sub

    Private Sub BrightnessCompensation_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        MainForm.MainForm_KeyDown(sender, e)
    End Sub

    Private Sub BrightnessCompensation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AlphaSlider_AfterChangeValue(sender, e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        functionType = 1
        Dim dummy As AfterChangeNumericValueEventArgs = Nothing
        AlphaSlider_AfterChangeValue(sender, dummy)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        functionType = 2
        Dim dummy As AfterChangeNumericValueEventArgs = Nothing
        AlphaSlider_AfterChangeValue(sender, dummy)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        functionType = 3
        Dim dummy As AfterChangeNumericValueEventArgs = Nothing
        AlphaSlider_AfterChangeValue(sender, dummy)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim i As Integer
        For i = 0 To UBound(__BrightnessCorrFactors)
            __BrightnessCorrFactors(i) = 1
        Next

        AlphaSlider.Value = 1
        GammaSlider.Value = 1
        Dim dummy As AfterChangeNumericValueEventArgs = Nothing
        AlphaSlider_AfterChangeValue(sender, dummy)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Me.Hide()
    End Sub

    Private Sub ButtonHorizontal_CheckedChanged(sender As Object, e As EventArgs) Handles ButtonHorizontal.CheckedChanged

        Dim xrange As New NationalInstruments.UI.Range(0, ImageProcessing.Xres - 1)
        Dim yrange As New NationalInstruments.UI.Range(0, ImageProcessing.Yres - 1)

        If ButtonHorizontal.Checked Then
            __BrightnessCorrDirection = 1
            ButtonVertical.Checked = False
            CalibrationGraph.XAxes.Item(0).Range = xrange
        Else
            __BrightnessCorrDirection = 2
            ButtonVertical.Checked = True
            CalibrationGraph.XAxes.Item(0).Range = yrange
        End If
        AlphaSlider_AfterChangeValue(sender, e)
    End Sub

    Private Sub ButtonVertical_CheckedChanged(sender As Object, e As EventArgs) Handles ButtonVertical.CheckedChanged

        Dim xrange As New NationalInstruments.UI.Range(0, ImageProcessing.Xres - 1)
        Dim yrange As New NationalInstruments.UI.Range(0, ImageProcessing.Yres - 1)

        If ButtonVertical.Checked Then
            __BrightnessCorrDirection = 2
            ButtonHorizontal.Checked = False
            CalibrationGraph.XAxes.Item(0).Range = yrange
        Else
            __BrightnessCorrDirection = 1
            ButtonHorizontal.Checked = True
            CalibrationGraph.XAxes.Item(0).Range = xrange
        End If
        AlphaSlider_AfterChangeValue(sender, e)
    End Sub

    Private Sub Clip16BitCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Clip16BitCheckBox.CheckedChanged

        If Clip16BitCheckBox.Checked Then
            __BrCorrClip16 = True
        Else
            __BrCorrClip16 = False
        End If
    End Sub

    Private Sub GammaSlider_AfterChangeValue(sender As Object, e As EventArgs) Handles GammaSlider.AfterChangeValue

        AlphaSlider_AfterChangeValue(sender, e)
    End Sub

    Private Sub GammaSlider_KeyDown(sender As Object, e As KeyEventArgs) Handles GammaSlider.KeyDown

        MainForm.MainForm_KeyDown(sender, e)
    End Sub

    Private Sub Slide2_AfterChangeValue(sender As Object, e As AfterChangeNumericValueEventArgs) Handles GammaSlider.AfterChangeValue

        AlphaSlider_AfterChangeValue(sender, e)
    End Sub

End Class