Public Class Leiho2_AurkeraAdmin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Erabiltzaile formera pasatu 
        Me.Hide()
        Dim f1 As New Leiho3_ErabiltzaileKudeaketa
        f1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'ostuen formera pasatu 
        Me.Hide()
        Dim f1 As New Leiho3_OstatuKudeaketa
        f1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim p As New ErreserbaV2
        p.Show()

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Dim er As New Leiho3_ErreserbaKudeaketa
        er.Show()
    End Sub

    Private Sub btnAtzera_Click(sender As Object, e As EventArgs) Handles btnAtzera.Click
        Me.Hide()
        Dim f1 As New Leiho1_InicioSesion
        f1.Show()
    End Sub
End Class