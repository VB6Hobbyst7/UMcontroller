Imports fieldoffset = System.Runtime.InteropServices.FieldOffsetAttribute
Imports Layoutkind = System.Runtime.InteropServices.LayoutKind
Imports StructLayout = System.Runtime.InteropServices.StructLayoutAttribute

Module Utilities
    Private counter As New System.Diagnostics.Stopwatch

    <StructLayout(Layoutkind.Explicit)> Public Structure HiLoCalc
        <fieldoffset(0)> Dim Ushort0 As UShort
        <fieldoffset(0)> Dim Byte0 As Byte
        <fieldoffset(1)> Dim Byte1 As Byte

        'LoByte (Byte Nr. 0) eines Ushort berechnen
        Public Function LoByte(ByVal Value As UShort) As Byte
            Ushort0 = Value
            Return Byte0
        End Function

        'HiByte (Byte Nr. 1) eines Ushort berechnen
        Public Function HiByte(ByVal Value As UShort) As Byte
            Ushort0 = Value
            Return Byte1
        End Function
    End Structure

    Public Function KeyPressed(ByVal iKey As Integer) As Boolean

        If NativeMethods.GetAsyncKeyState(iKey) < 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    'creates a registry key in HKEY\CURRENT_USER and sets it to a default value if the key does not already exist.
    Sub MakeDefaultRegKey(path As String, key As String, value As String)

        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\" & path, key, Nothing) Is Nothing Then
            My.Computer.Registry.CurrentUser.CreateSubKey(path)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\" & path, key, value, Microsoft.Win32.RegistryValueKind.String)
        End If
    End Sub

    Public Sub Wait(ms As Long)

        counter.Start()
        Do
            Application.DoEvents()
        Loop Until counter.ElapsedMilliseconds >= ms
        counter.Reset()
    End Sub

    Public Function TopMostMessageBox(ByVal title As String, ByVal message As String, ByVal buttons As MessageBoxButtons, ByVal icons As MessageBoxIcon) As DialogResult
        ' Create a host form that is a TopMost window which will be the parent of the MessageBox.
        ' new form should not be visible so position it off the visible screen and make it as small as possible

        Dim topmostForm As New Form With {
            .Size = New System.Drawing.Size(1, 1),
            .StartPosition = FormStartPosition.Manual
        }

        Dim rect As System.Drawing.Rectangle = SystemInformation.VirtualScreen
        topmostForm.Location = New System.Drawing.Point(rect.Bottom + 10, rect.Right + 10)
        topmostForm.Show()

        ' Make this form the active form and make it TopMost
        topmostForm.Focus()
        topmostForm.BringToFront()
        topmostForm.TopMost = True

        ' Finally show the MessageBox with the form just created as its owner
        Dim result As DialogResult = MessageBox.Show(topmostForm, message, title, buttons, icons)

        'clean it up all the way
        topmostForm.Dispose()

        Return result
    End Function

End Module