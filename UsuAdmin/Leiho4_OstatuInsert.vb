Imports MySql.Data.MySqlClient

Public Class Leiho4_OstatuInsert
    Public v_izena As String
    Dim komando As New MySqlCommand
    Dim data As New DataSet
    Dim cnn1 As MySqlConnection
    Dim server As String = "server=localhost;user=root;database=3262035_ostatuagrad;port=3306;"
    Dim v_signatura As String
    Private Sub Leiho4_OstatuInsert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' v_signatura recoge
    End Sub

    Private Sub btnGehitu_Click(sender As Object, e As EventArgs) Handles btnGehitu.Click
        'LAS VARIABLES A USAR
        Try
            cnn1.Open()

            Dim sql As String = "INSERT INTO `ostatuak`(`ID_SIGNATURA`, `OSTATU_IZENA`, `DESKRIBAPENA`, `OSTATU_HELBIDEA`, `MARKA`, `OSTATU_EMAIL`, `OSTATU_TELEFONOA`, `PERTSONA_TOT`, `LATITUDE`, `LONGITUDE`, `MOTA`, `WEB_URL`,`ADISKIDETSU_URL`, `ZIP_URL`, `POSTA_KODEA`, `HERRI_KODEA`) VALUES ('"
            sql += signatura.Text & "', '" & izena.Text.ToUpper & "', '" & deskribapena.Text.ToUpper & "', '" & helbidea.Text.ToUpper & "', '"
            sql += marka.Text.ToUpper & "', '" & email.Text & "', '" & telefonoa.Text & "', " & pertsonatot.Value.ToString & ", '" & latitudea.Text & "', '"
            sql += longitudea.Text & "', '" & mota.Text.ToUpper & "', '" & weburl.Text & "', '" & adiskidetsuurl.Text & "', '" & zipurl.Text
            sql += "', " & cbPostaKodea.SelectedValue & ", '" & cbHerriKodea.SelectedValue & "')"

            Dim command As New MySqlCommand(sql, cnn1)
            If command.ExecuteNonQuery() = 1 Then
                Me.Hide()
                Dim f1 As New Leiho3_OstatuKudeaketa
                f1.Show()
            End If
        Catch ex As Exception
        Finally
            cnn1.Close()
        End Try

    End Sub

    Private Sub btnEzeztatu_Click(sender As Object, e As EventArgs) Handles btnEzeztatu.Click
        Me.Hide()
        Dim f1 As New Leiho3_OstatuKudeaketa
        f1.Show()
    End Sub
End Class