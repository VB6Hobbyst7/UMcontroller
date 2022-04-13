Public Class Stepper
    Private Shared SavedPosition As String = "undefined"

    Public Shared Function Calibrate() As Integer

        Try
            __MicosPort.Write("1 ncal ")
            __MicosPort.DiscardOutBuffer()
        Catch
        End Try
    End Function

    Public Shared Function GetStepperPos() As Double

        Try
            __MicosPort.WriteLine("1 np ")
            __MicosPort.DiscardOutBuffer()

            Dim posstr As String = __MicosPort.ReadLine()
            __MicosPort.DiscardInBuffer()

            Return CDbl(Val(posstr))
        Catch
        End Try
    End Function

    Shared Sub Init()

        Try
            If Not __MicosPort.IsOpen Then
                __MicosPort.ReadTimeout = 1000
                __MicosPort.Open()
            End If
        Catch
        End Try

        SetParameters(Settings.StepperVel.Value, Settings.StepperAcc.Value)
    End Sub

    'restore current stepper position
    Public Shared Sub RestorePos()

        Try
            If SavedPosition <> "undefined" Then
                __MicosPort.WriteLine(SavedPosition & " 1 nm ")
                __MicosPort.DiscardOutBuffer()
            Else
                Beep()
            End If
        Catch
        End Try
    End Sub

    'store current stepper poition
    Public Shared Sub SavePos()

        Try
            __MicosPort.WriteLine("1 np ")
            __MicosPort.DiscardOutBuffer()

            SavedPosition = __MicosPort.ReadLine().Replace(",", ".")
            __MicosPort.DiscardInBuffer()

            If SavedPosition.Contains(".") = False Then
                SavedPosition &= ".000000"
            End If
        Catch
        End Try
    End Sub

    Public Shared Sub SetParameters(ByVal vel As Decimal, ByVal acc As Decimal)

        Dim command As String

        Try
            'Stepper velocity
            command = CInt(vel).ToString.Replace(",", ".") & ".0 1 snv "
            __MicosPort.WriteLine(command)
            __MicosPort.DiscardOutBuffer()

            'Stepper acceleration
            command = CInt(acc).ToString & ".0 1 sna a"
            __MicosPort.WriteLine(command)
            __MicosPort.DiscardOutBuffer()
        Catch
        End Try
    End Sub

    Public Shared Sub SetStepperPosAbs(pos As Double)

        Try
            Dim posstr As String = pos.ToString("F5", New System.Globalization.CultureInfo("en-US"))
            __MicosPort.WriteLine(posstr & " 1 nm ")
            __MicosPort.DiscardOutBuffer()
        Catch
        End Try
    End Sub

    Public Shared Sub SetZeroPos()

        Try
            __MicosPort.WriteLine("0.0 1 setnpos ")
            __MicosPort.DiscardOutBuffer()
        Catch
        End Try
    End Sub

    Public Shared Sub StepRel(ByVal nsteps As Double) 'input in mm

        Dim command As String

        command = nsteps.ToString.Replace(",", ".") & " 1 nr "

        Try
            __MicosPort.WriteLine(command)
            __MicosPort.DiscardOutBuffer()
        Catch
        End Try
    End Sub

    Public Shared Sub WaitUntilFinished()

        Try
            Do
                __MicosPort.WriteLine("1 nst ")
                __MicosPort.DiscardOutBuffer()
            Loop Until CInt(__MicosPort.ReadLine()) = 0
        Catch
        End Try
    End Sub

End Class