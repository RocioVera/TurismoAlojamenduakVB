Public Class Leiho2_AukeraBezeroNormala
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOstatuakIkusi.Click
        Me.Hide()
        Dim f1 As New Leiho3_OstatuakIkusiN
        f1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnErabiltzaileakIkusi.Click
        Me.Hide()
        Dim f1 As New ErabiltzaileakIkusiN
        f1.Show()
    End Sub

    Private Sub btnAtzera_Click(sender As Object, e As EventArgs) Handles btnAtzera.Click
        Me.Hide()
        Dim f1 As New Leiho1_InicioSesion
        f1.Show()
    End Sub
End Class