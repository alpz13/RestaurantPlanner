Public NotInheritable Class SplashScreen

    Private Sub TiempoSplash_Tick(sender As System.Object, e As System.EventArgs) Handles TiempoSplash.Tick
        TiempoSplash.Enabled = False
        Me.Hide()
        LoginScreen.Show()
    End Sub
End Class
