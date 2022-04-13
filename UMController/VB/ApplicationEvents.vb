Namespace My

    ' Für MyApplication sind folgende Ereignisse verfügbar:
    '
    ' Startup: Wird beim Starten der Anwendung noch vor dem Erstellen des Startformulars ausgelöst.
    ' Shutdown: Wird nach dem Schließen aller Anwendungsformulare ausgelöst. Dieses Ereignis wird nicht ausgelöst, wenn die Anwendung nicht normal beendet wird.
    ' UnhandledException: Wird ausgelöst, wenn in der Anwendung eine unbehandelte Ausnahme auftritt.
    ' StartupNextInstance: Wird beim Starten einer Einzelinstanzanwendung ausgelöst, wenn diese bereits aktiv ist.
    ' NetworkAvailabilityChanged: Wird beim Herstellen oder Trennen der Netzwerkverbindung ausgelöst.
    Partial Friend Class MyApplication

        Protected Overrides Function OnInitialize(ByVal commandLineArgs As System.Collections.ObjectModel.ReadOnlyCollection(Of String)) As Boolean

            'Set the splash screen timeout.

            Me.MinimumSplashScreenDisplayTime = 4000
            Return MyBase.OnInitialize(commandLineArgs)

        End Function

        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup

        End Sub

    End Class

End Namespace