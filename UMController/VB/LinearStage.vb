Public Class LinearStage

    'provide six buffers to store linear stage positions. positions 0-4 are associated with the 5 filter wheel positions.
    'Position 5 is user defined.
    Private Shared SavedPositions(1) As String

    Public Enum SelectStage
        LeftStage = 1
        RightStage = 2
    End Enum

    Public Shared Function GetPos(stagenr As Integer) As Double

        Try
            If stagenr = SelectStage.LeftStage Then
                __MicosPort.WriteLine("2 np ")
            ElseIf stagenr = SelectStage.RightStage Then
                __MicosPort.WriteLine("3 np ")
            End If

            __MicosPort.DiscardOutBuffer()
            Dim posstr As String = __MicosPort.ReadLine()
            __MicosPort.DiscardInBuffer()
            Return CDbl(Val(posstr))
        Catch
        End Try
    End Function

    Public Shared Sub Init()

        Try
            If Not __MicosPort.IsOpen Then
                __MicosPort.ReadTimeout = 1000
                __MicosPort.Open()
            End If

            SavedPositions(0) = "undefined"
            SavedPositions(1) = "undefined"

            'load current position of linear stage in all buffers exept the user defined one

            If __NumLienarStages >= 1 Then
                LinearStage.SavePos(1)
            End If
                If __NumLienarStages >= 2 Then
                LinearStage.SavePos(2)
            End If

        Catch
        End Try
    End Sub

    Public Shared Sub MoveLeft(ByVal StageNr As Integer, ByVal millimeter As Double) 'input in mm

        Dim command As String
        command = (-millimeter).ToString.Replace(",", ".")

        If command.Contains(".") = False Then
            command &= ".00"
        End If

        If command.Length > command.IndexOf(".") + 6 Then
            command = command.Substring(0, command.IndexOf(".") + 6)
        End If

        Select Case StageNr
            Case SelectStage.LeftStage
                command &= " 2 nr "
            Case SelectStage.RightStage
                command &= " 3 nr "
        End Select

        Try
            __MicosPort.WriteLine(command)
            __MicosPort.DiscardOutBuffer()
        Catch
        End Try
    End Sub

    Public Shared Sub MoveRight(ByVal StageNr As Integer, ByVal millimeter As Double) 'input in mm

        MoveLeft(StageNr, -millimeter)
    End Sub

    Public Shared Sub ReferenceDrive(stagenr As Integer)

        Dim Command As String

        If stagenr = 1 Then
            Command = "2 ncal"
        Else
            Command = "3 ncal"
        End If

        Try
            __MicosPort.WriteLine(Command)
            __MicosPort.DiscardOutBuffer()
        Catch
        End Try
    End Sub

    Public Shared Sub RestorePos(ByVal StageNr As Integer)

        Try
            If SavedPositions(StageNr - 1) <> "undefined" Then
                Select Case StageNr
                    Case SelectStage.LeftStage
                        __MicosPort.WriteLine(SavedPositions(StageNr - 1) & " 2 nm ")
                    Case SelectStage.RightStage
                        __MicosPort.WriteLine(SavedPositions(StageNr - 1) & " 3 nm ")
                End Select
                __MicosPort.DiscardOutBuffer()
            Else
                Beep()
            End If
        Catch
        End Try
    End Sub

    Public Shared Sub SavePos(ByVal StageNr As Integer)

        Try
            Select Case StageNr
                Case SelectStage.LeftStage
                    __MicosPort.WriteLine("2 np ")
                    SavedPositions(0) = __MicosPort.ReadLine().Replace(",", ".")
                    If SavedPositions(0).Contains(".") = False Then
                        SavedPositions(0) = SavedPositions(0) & ".00"
                    End If
                Case SelectStage.RightStage
                    __MicosPort.WriteLine("3 np ")
                    SavedPositions(1) = __MicosPort.ReadLine().Replace(",", ".")
                    If SavedPositions(1).Contains(".") = False Then
                        SavedPositions(1) = SavedPositions(1) & ".00"
                    End If
            End Select
            __MicosPort.DiscardOutBuffer()
        Catch
        End Try
    End Sub

    Public Shared Sub SetParameters(ByVal vel As Decimal, ByVal acc As Decimal, stagenr As Integer)

        Dim command1 As String = ""
        Dim command2 As String = ""

        Try
            'Stepper velocity
            If stagenr = SelectStage.LeftStage Then
                command1 = CInt(vel).ToString.Replace(",", ".") & ".0 2 snv "
                command2 = CInt(acc).ToString.Replace(",", ".") & ".0 2 sna a"
            ElseIf stagenr = SelectStage.RightStage Then
                command1 = CInt(vel).ToString.Replace(",", ".") & ".0 3 snv "
                command2 = CInt(acc).ToString.Replace(",", ".") & ".0 3 sna a"
            End If

            __MicosPort.WriteLine(command1)
            __MicosPort.WriteLine(command2)
            __MicosPort.DiscardOutBuffer()
        Catch
        End Try
    End Sub

    Public Shared Sub SetStagePosAbs(pos As Double, stagenr As Integer)

        Try
            Dim posstr As String = pos.ToString("F5", New System.Globalization.CultureInfo("en-US"))
            If stagenr = SelectStage.LeftStage Then
                __MicosPort.WriteLine(posstr & " 2 nm ")
            ElseIf stagenr = SelectStage.RightStage Then
                __MicosPort.WriteLine(posstr & " 3 nm ")
            End If
            __MicosPort.DiscardOutBuffer()
        Catch
        End Try
    End Sub

    Public Shared Sub SetZeroPos(stagenr As Integer)

        Try
            If stagenr = 1 Then
                __MicosPort.WriteLine("0.0 2 setnpos ")
            Else
                __MicosPort.WriteLine("0.0 3 setnpos ")
            End If
            __MicosPort.DiscardOutBuffer()
        Catch
        End Try
    End Sub

    Public Shared Sub WaitUntilFinished(stagenr As Integer)

        Try
            Do
                If stagenr = SelectStage.LeftStage Then
                    __MicosPort.WriteLine("2 nst ")
                ElseIf stagenr = SelectStage.RightStage Then
                    __MicosPort.WriteLine("3 nst ")
                End If

                __MicosPort.DiscardOutBuffer()
            Loop Until CInt(__MicosPort.ReadLine()) = 0
        Catch
        End Try
    End Sub

End Class