Public Class ViewerWindow
    Inherits Form

    Private Shared aspect As Double
    Private Shared prevWidth As Integer
    Private MyZoomBox As New ZoomPictureBox

    Public Sub New(ByVal picture As System.Drawing.Image, ByVal WindowWidth As Integer)

        If picture IsNot Nothing Then
            MyZoomBox.Image = picture
            Init(WindowWidth)
        End If
    End Sub

    Public Sub SetImage(ByVal picture As System.Drawing.Image)

        If picture IsNot Nothing Then
            MyZoomBox.Image = picture
        End If
    End Sub

    Private Sub Init(width As Integer)

        aspect = MyZoomBox.Image.Height / MyZoomBox.Image.Width

        Me.MinimumSize = New Size(100, CInt(100 * aspect))
        Me.ClientSize = New Size(width, CInt(width * aspect))
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = True

        MyZoomBox.Location = New Point(0, 0)
        MyZoomBox.Size = Me.ClientSize
        MyZoomBox.BorderStyle = BorderStyle.None
        MyZoomBox.SizeMode = PictureBoxSizeMode.StretchImage
        MyZoomBox.Cursor = Cursors.SizeAll

        Me.Controls.Add(MyZoomBox)
        ActiveControl = MyZoomBox
    End Sub

    Private Sub ViewerWindow_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        MainForm.MainForm_KeyDown(sender, e)
    End Sub

    Private Sub ViewerWindow_ResizeBegin(sender As Object, e As EventArgs) Handles Me.ResizeBegin

        prevWidth = MyZoomBox.Width
    End Sub

    Private Sub ViewerWindow_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd

        Dim NewWidth, NewHeight As Integer

        If prevWidth = Me.ClientSize.Width Then
            NewWidth = CInt(Me.ClientSize.Height / aspect)
            Me.ClientSize = New Size(NewWidth, Me.ClientSize.Height)
        Else
            NewHeight = CInt(Me.ClientSize.Width * aspect)
            Me.ClientSize = New Size(Me.ClientSize.Width, NewHeight)
        End If

        MyZoomBox.ClientSize = Me.ClientSize
        MyZoomBox.ZoomFactor = 1
        MyZoomBox.Invalidate()
    End Sub

    Private Class ZoomPictureBox

        Inherits PictureBox

        Private zmLevel As Double = 1
        Private zmPt As Point

        Public Overloads Property Image() As Image
            Get
                Return MyBase.Image
            End Get

            Set(ByVal value As Image)
                MyBase.Image = value
            End Set
        End Property

        Public Property ZoomFactor As Double
            Get
                Return zmLevel
            End Get
            Set(value As Double)
                zmLevel = value
            End Set
        End Property

        Protected Overrides Sub OnPaint(ByVal pe As System.Windows.Forms.PaintEventArgs)

            Dim loc As Point
            Dim sz As Size

            If Me.Image IsNot Nothing Then
                pe.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic

                If zmLevel <> 1 Then
                    sz = New Size(CInt(Me.Image.Width / zmLevel), CInt(Me.Image.Height / zmLevel))

                    ' center on zmPt
                    loc = New Point(CInt(Me.Image.Width * (zmPt.X / Me.ClientRectangle.Width) - sz.Width / 2), CInt(Me.Image.Height * (zmPt.Y / Me.ClientRectangle.Height) - sz.Height / 2))

                    'prevent zooming outside the image borders
                    If loc.X < 0 Then
                        loc.X = 0
                    ElseIf loc.X + sz.Width > Image.Width Then
                        loc.X = Image.Width - sz.Width
                    End If
                    If loc.Y < 0 Then
                        loc.Y = 0
                    ElseIf loc.Y + sz.Height > Image.Height Then
                        loc.Y = Image.Height - sz.Height
                    End If
                Else
                    loc = New Point(0, 0)
                    sz = Me.Image.Size
                End If
            End If

            Dim rectSrc As New Rectangle(loc, sz)
            pe.Graphics.DrawImage(Me.Image, Me.ClientRectangle, rectSrc, GraphicsUnit.Pixel)

            If zmLevel = 1 Then
                Me.Cursor = Cursors.SizeAll
            Else
                Me.Cursor = Cursors.Default
            End If
        End Sub

        'ZoomPictureBox key down is not listed in the form designer window and is undocumented
        Private Sub ZoomPictureBox_KeyDown(sender As Object, e As EventArgs) Handles Me.KeyDown

            MainForm.MainForm_KeyDown(sender, CType(e, KeyEventArgs))
        End Sub

        Private Sub ZoomPictureBox_MouseWheel(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel

            If Me.zmLevel = 1 Then  ' can only anchor when unzoomed
                Me.zmPt = New Point(e.X, e.Y)
            End If

            If e.Delta > 0 Then
                If zmLevel < 30 Then
                    zmLevel += 0.5
                End If
            Else
                If e.Delta < 1 Then
                    If zmLevel > 1 Then
                        zmLevel -= 0.5
                    End If
                End If
            End If

            Me.Invalidate()
        End Sub

    End Class

End Class