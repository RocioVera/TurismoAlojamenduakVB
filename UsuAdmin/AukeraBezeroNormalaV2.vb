Public Class AukeraBezeroNormalaV2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOstatuakIkusi.Click
        Me.Hide()
        Dim f1 As New OstatuakIkusiV2
        f1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnErabiltzaileakIkusi.Click
        Me.Hide()
        Dim f1 As New ErabiltzaileakIkusiEZ
        f1.Show()
    End Sub

    Private Sub btnAtzera_Click(sender As Object, e As EventArgs) Handles btnAtzera.Click
        Me.Hide()
        Dim f1 As New Leiho1_InicioSesion
        f1.Show()
    End Sub
End Class