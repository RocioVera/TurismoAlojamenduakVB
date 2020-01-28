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
        HerriKodeGuztiakKargatu()
        PostaKodeakGuztiakKargatu()


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

    Private Sub cbHerria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbHerria.SelectedIndexChanged
        Dim sql As String

        If cbHerria.Text = "" And cbProbintzia.Text = "" Then
            HerriKodeGuztiakKargatu()
        Else
            If cbHerria.Text <> "" Then
                sql = "SELECT DISTINCT(herri_kodea) FROM posta_kodeak WHERE upper(herri_izena) LIKE upper( '" & cbHerria.Text & "') "

                If cbProbintzia.Text <> "" Then
                    sql += "AND upper(PROBINTZIA) LIKE '" & cbProbintzia.Text.ToUpper & "' "
                End If

                sql += "ORDER BY herri_kodea ASC"
                HerriKodeakDropDownGehitu(sql)
                sql = "SELECT DISTINCT(posta_kodea) FROM posta_kodeak WHERE upper(PROBINTZIA) LIKE '" & cbProbintzia.Text.ToUpper & "' ORDER BY posta_kodea ASC"
                PostaKodeakDropDownGehitu(sql)
            Else
                If cbProbintzia.Text <> "" Then
                    sql += "SELECT DISTINCT(herri_kodea) FROM posta_kodeak WHERE upper(PROBINTZIA) LIKE '" & cbProbintzia.Text.ToUpper & "' "
                Else
                    sql += "SELECT DISTINCT(herri_kodea) FROM posta_kodeak "
                End If

                sql += " ORDER BY herri_kodea ASC"
                HerriKodeakDropDownGehitu(sql)
                sql = "SELECT DISTINCT(posta_kodea) FROM posta_kodeak WHERE upper(PROBINTZIA) LIKE '" & cbProbintzia.Text.ToUpper & "' ORDER BY posta_kodea ASC"
                PostaKodeakDropDownGehitu(sql)
            End If

        End If
        cbHerriKodea.Text = ""
        cbPostaKodea.Text = ""
        cbHerriKodea.Enabled = True
        cbPostaKodea.Enabled = False
    End Sub

    Private Sub PostaKodeakGuztiakKargatu()
        Dim sql As String
        sql = "SELECT DISTINCT(posta_kodea) FROM posta_kodeak ORDER BY posta_kodea ASC"
        PostaKodeakDropDownGehitu(sql)
    End Sub
    Private Sub HerriKodeGuztiakKargatu()
        Dim sql As String
        sql = "SELECT DISTINCT(herri_kodea) FROM posta_kodeak  like araba ORDER BY herri_kodea ASC"
        HerriKodeakDropDownGehitu(sql)
    End Sub

    Private Sub HerriKodeakDropDownGehitu(sql As String)
        Try
            cbHerriKodea.Items.Clear()
            'defektuzko balorea gehitzen da
            Dim das1 As New DataSet
            cnn1 = New MySqlConnection(server)
            cnn1.Open()

            Dim cmd1 = New MySqlCommand(sql, cnn1)
            Dim adap1 = New MySqlDataAdapter(cmd1)

            das1.Clear()

            Dim dr As MySqlDataReader
            dr = cmd1.ExecuteReader

            While dr.Read
                If (dr.Item(0) <> "HUTSIK") Then
                    cbHerriKodea.Items.Add(dr.Item(0))
                End If
            End While

            dr.Close()
        Catch ex As Exception
            cnn1.Close()
        End Try
    End Sub


    Private Sub PostaKodeakDropDownGehitu(sql As String)
        Try
            cbPostaKodea.Items.Clear()
            'defektuzko balorea gehitzen da
            Dim das1 As New DataSet
            cnn1 = New MySqlConnection(server)
            cnn1.Open()

            Dim cmd1 = New MySqlCommand(sql, cnn1)
            Dim adap1 = New MySqlDataAdapter(cmd1)

            das1.Clear()

            Dim dr As MySqlDataReader
            dr = cmd1.ExecuteReader

            While dr.Read
                If (dr.Item(0) <> "1000") Then
                    cbPostaKodea.Items.Add(dr.Item(0))
                End If
            End While

            dr.Close()
        Catch ex As Exception
            cnn1.Close()
        End Try

    End Sub

    Private Sub cbHerriKodea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbHerriKodea.SelectedIndexChanged
        If cbHerria.Text = "Herri kodeak" Then
            PostaKodeakGuztiakKargatu()
        Else
            Dim sql = "SELECT DISTINCT(posta_kodea) FROM posta_kodeak WHERE herri_kodea = '" & cbHerriKodea.SelectedValue & "' ORDER BY posta_kodea ASC"
            PostaKodeakDropDownGehitu(sql)
        End If
        cbPostaKodea.Text = ""
        cbPostaKodea.Enabled = True
    End Sub

    Private Sub cbProbintzia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProbintzia.SelectedIndexChanged
        If cbProbintzia.Text <> "" Then
            Dim sql As String
            sql = "Select DISTINCT(HERRI_IZENA) FROM posta_kodeak WHERE upper(PROBINTZIA) Like '" & cbProbintzia.Text.ToUpper & "' ORDER BY HERRI_IZENA ASC"
            HerriDropDownGehitu(sql)
            sql = "SELECT DISTINCT(herri_kodea) FROM posta_kodeak WHERE upper(PROBINTZIA) LIKE '" & cbProbintzia.Text.ToUpper & "' ORDER BY herri_kodea ASC"
            HerriKodeakDropDownGehitu(sql)
            sql = "SELECT DISTINCT(posta_kodea) FROM posta_kodeak WHERE upper(PROBINTZIA) LIKE '" & cbProbintzia.Text.ToUpper & "' ORDER BY posta_kodea ASC"
            PostaKodeakDropDownGehitu(sql)

        Else
            HerriaGuztiakKargatu()
            HerriKodeGuztiakKargatu()
            PostaKodeakGuztiakKargatu()
        End If
        cbHerria.Text = ""
        cbHerriKodea.Text = ""
        cbPostaKodea.Text = ""
        cbHerria.Enabled = True
        cbHerriKodea.Enabled = False
        cbPostaKodea.Enabled = False
    End Sub

    Private Sub HerriDropDownGehitu(sql As String)
        Try
            cbHerria.Items.Clear()
            'defektuzko balorea gehitzen da
            Dim das1 As New DataSet
            cnn1 = New MySqlConnection(server)
            cnn1.Open()

            Dim cmd1 = New MySqlCommand(sql, cnn1)
            Dim adap1 = New MySqlDataAdapter(cmd1)

            das1.Clear()

            Dim dr As MySqlDataReader
            dr = cmd1.ExecuteReader
            While dr.Read
                If (dr.Item(0) <> "HUTSIK") Then
                    cbHerria.Items.Add(dr.Item(0))
                End If
            End While
            dr.Close()
        Catch ex As Exception
            cnn1.Close()
        End Try
    End Sub
    Private Sub HerriaGuztiakKargatu()
        Dim sql As String
        sql = "SELECT DISTINCT(herri_izena) FROM posta_kodeak ORDER BY herri_izena ASC"
        HerriDropDownGehitu(sql)
    End Sub

    Private Sub KeyUp(sender As Object, e As KeyEventArgs) Handles cbProbintzia.KeyUp, cbPostaKodea.KeyUp, cbHerriKodea.KeyUp, cbHerria.KeyUp
        cbProbintzia.Text = ""
    End Sub


End Class