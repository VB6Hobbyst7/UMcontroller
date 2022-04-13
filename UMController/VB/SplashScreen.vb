Imports System.Reflection.Assembly

Public NotInheritable Class SplashScreen

    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles Me.Load

        VersionLabel.Text = "UMController V" + GetExecutingAssembly().GetName().Version.Major.ToString _
             + "." + GetExecutingAssembly().GetName().Version.Minor.ToString _
             + " build " + GetExecutingAssembly().GetName().Version.Build.ToString
    End Sub

End Class