Public Class SaveFormatDialog

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

        ImageProcessing.PresentImage.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Tiff)
    End Sub

    Private Sub SaveFileDialog2_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog2.FileOk

        ImageProcessing.Save_TIFF16(ImageProcessing.Bit32Data, SaveFileDialog2.FileName, Settings.SaveFullRangeCheckBox.Checked)
    End Sub

    Private Sub SaveFileDialog3_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog3.FileOk

        ImageProcessing.Save_TiffUint32(ImageProcessing.Bit32Data, SaveFileDialog3.FileName)
    End Sub

    Private Sub SaveFloatButton_Click(sender As Object, e As EventArgs) Handles SaveFloatButton.Click

        Me.Close()
        SaveFileDialog3.ShowDialog()
    End Sub

    Private Sub SaveRAWButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveRAWButton.Click

        Me.Close()
        SaveFileDialog2.ShowDialog()
    End Sub

    Private Sub SaveTIFFButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveTIFFButton.Click

        Me.Close()
        SaveFileDialog1.ShowDialog()
    End Sub

End Class