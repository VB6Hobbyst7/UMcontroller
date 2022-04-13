Public Class LeicaStageControl

    Public Shared Sub StageDown(steps As UInteger)

        If __MotorFocusPresent Then
            Dim command As String

            command = "7049" & "10" & (-steps).ToString
            __LeicaPort.WriteLine(command)
        End If
    End Sub

    Public Shared Sub StageUp(steps As UInteger)

        If __MotorFocusPresent Then
            Dim command As String

            command = "7049" & "10" & steps.ToString
            __LeicaPort.WriteLine(command)
        End If
    End Sub

End Class