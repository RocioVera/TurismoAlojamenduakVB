Imports MySql.Data.MySqlClient

Public Class Leiho5_OstatuUpdate
    Dim v_signatura As String 'PRUEBAN 
    Dim lista As String

    Public v_izena As String
    Dim dr As MySqlDataReader
    Dim komando As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim data As New DataSet
    Dim cnn1 As MySqlConnection
    Dim server As String = "server=localhost;user=root;database=3262035_ostatuagrad;port=3306;"
    Dim listaTxt As New List(Of TextBox)
    Dim ok As New Leiho3_OstatuKudeaketa
    Dim hautatutakoOstatua As Ostatuak

    Private Sub OstatuUpdatea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SacarSignatura(v_izena, lista)
        PostaKodeakGuztiakKargatu()
        HerriaGuztiakKargatu()
        HerriKodeGuztiakKargatu()

        gehituDatuak()

    End Sub

    Private Sub gehituDatuak()
        signatura.Text = hautatutakoOstatua.IdSignatura
        izena.Text = hautatutakoOstatua.OstatuIzena
        helbidea.Text = hautatutakoOstatua.OstatuHelbidea
        email.Text = hautatutakoOstatua.OstatuEmail
        telefonoa.Text = hautatutakoOstatua.OstatuTelefonoa
        marka.Text = hautatutakoOstatua.Marka
        mota.Text = hautatutakoOstatua.Mota
        deskribapena.Text = hautatutakoOstatua.Deskribapena
        pertsonatot.Text = hautatutakoOstatua.PertsonaTot
        latitudea.Text = hautatutakoOstatua.Latitude
        longitudea.Text = hautatutakoOstatua.Longitude
        weburl.Text = hautatutakoOstatua.WebUrl
        adiskidetsuurl.Text = hautatutakoOstatua.AdiskidetsuUrl
        zipurl.Text = hautatutakoOstatua.ZipUrl

        'cbHerria.Text
        'cbProbintzia.Text
        cbHerriKodea.Text = hautatutakoOstatua.HerriKodea
        cbPostaKodea.Text = hautatutakoOstatua.PostaKodea
    End Sub

    Public Sub OstatuJaso(ostatua As Ostatuak)
        hautatutakoOstatua = ostatua
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'LAS VARIABLES A USAR
        Dim v_describapena As String
        Dim v_helbidea As String
        Dim v_marka As String
        Dim v_email As String
        Dim v_telefono As String
        Dim v_pertsonatot As Integer
        Dim v_latitude As String
        Dim v_longitude As String
        Dim v_mota As String
        Dim v_webuerl As String
        Dim v_adiskidetsu As String
        Dim v_zip As String
        Dim v_postakodea As String
        Dim v_herrikodea As String

        'DAR VALOR A LAS VARIABLES
        v_describapena = deskribapena.Text.ToString
        v_helbidea = helbidea.Text.ToString
        v_marka = marka.Text.ToString
        v_email = email.Text.ToString
        v_telefono = telefonoa.Text.ToString
        v_pertsonatot = pertsonatot.Value.ToString
        v_latitude = latitudea.Text.ToString
        v_longitude = longitudea.Text.ToString
        v_mota = mota.Text.ToString
        v_webuerl = weburl.Text.ToString
        v_adiskidetsu = adiskidetsuurl.Text.ToString
        v_zip = zipurl.Text.ToString
        v_postakodea = cbPostaKodea.SelectedValue
        v_herrikodea = cbHerriKodea.SelectedValue
        'LA UPDATE 
        Try
            cnn1 = New MySqlConnection(server)
            Dim SQL2 As New MySqlCommand("UPDATE ostatuak set ID_SIGNATURA = '" & v_signatura & "' , OSTATU_IZENA = '" & v_helbidea & " ' , DESKRIBAPENA = '" & v_describapena & "' , OSTATU_HELBIDEA = '" & v_email & "' , OSTATU_TELEFONOA = '" & v_telefono & "' , MARKA = '" & v_marka & "'  , OSTATU_EMAIL = '" & v_email & "', PERTSONA_TOT = '" & v_pertsonatot & " ', LATITUDE = '" & v_latitude & "', LONGITUDE = '" & v_longitude & "' , MOTA = '" & v_mota & "', WEB_URL = '" & v_webuerl & "', ADISKIDETSU_URL = '" & v_adiskidetsu & "', ZIP_URL = '" & v_zip & "', POSTA_KODEA = '" & v_postakodea & "', HERRI_KODEA = '" & v_herrikodea & "' WHERE OSTATU_IZENA  = '" & v_izena & "'", cnn1)
            ' importante para la conexion y ejecutar las sentencias sql
            komando.Connection = cnn1
            cnn1.Open()
            SQL2.ExecuteNonQuery()
            ' limpiar
            data.Clear()
            cnn1.Close()
        Catch ex As Exception
            MsgBox(ex.Message) ' para sacar los fallos de la update 
        End Try
        Me.Hide()
        ' ok.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        'ok.Show()
    End Sub

    Function SacarSignatura(ByRef ostatuIzena, ByRef lista)
        Try
            cnn1 = New MySqlConnection(server)
            Dim SQL As New MySqlCommand("SELECT ID_SIGNATURA FROM ostatuak WHERE OSTATU_IZENA = '" & ostatuIzena & "'", cnn1)

            SQL.Connection = cnn1
            ' komando.CommandText = SQL
            adapter.SelectCommand = komando
            cnn1.Open()
            dr = SQL.ExecuteReader

            While dr.Read()
                lista = dr.GetString(0)

            End While
            cnn1.Close()
        Catch ex As Exception

        End Try
        'Return lista
    End Function

    Private Sub cbProbintzia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProbintzia.SelectedIndexChanged
        If cbProbintzia.Text <> "Probintzia" Then
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
    End Sub

    Private Sub HerriDropDownGehitu(sql As String)
        Try
            cbHerria.Items.Clear()
            'defektuzko balorea gehitzen da
            cbHerria.Items.Add("Herriak")
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

    Private Sub HerriKodeakDropDownGehitu(sql As String)
        Try
            cbHerriKodea.Items.Clear()
            'defektuzko balorea gehitzen da
            cbHerriKodea.Items.Add("Herri kodeak")
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
            cbPostaKodea.Items.Add("Posta kodeak")
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

    Private Sub PostaKodeakGuztiakKargatu()
        Dim sql As String
        sql = "SELECT DISTINCT(posta_kodea) FROM posta_kodeak ORDER BY posta_kodea ASC"
        PostaKodeakDropDownGehitu(sql)
    End Sub

    Private Sub HerriaGuztiakKargatu()
        Dim sql As String
        sql = "SELECT DISTINCT(herri_izena) FROM posta_kodeak ORDER BY herri_izena ASC"
        HerriDropDownGehitu(sql)
    End Sub

    Private Sub HerriKodeGuztiakKargatu()
        Dim sql As String
        sql = "SELECT DISTINCT(herri_kodea) FROM posta_kodeak ORDER BY herri_kodea ASC"
        HerriKodeakDropDownGehitu(sql)
    End Sub

    Private Sub cbHerria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbHerria.SelectedIndexChanged
        Dim sql As String

        If cbHerria.Text = "Herriak" And cbProbintzia.Text = "Probintzia" Then
            HerriKodeGuztiakKargatu()
        Else
            If cbHerria.Text <> "Herriak" Then
                sql = "SELECT DISTINCT(herri_kodea) FROM posta_kodeak WHERE upper(herri_izena) LIKE upper( '" & cbHerria.Text & "') "

                If cbProbintzia.Text <> "Probintzia" Then
                    sql += "AND upper(PROBINTZIA) LIKE '" & cbProbintzia.Text.ToUpper & "' "
                End If

                sql += "ORDER BY herri_kodea ASC"
                HerriKodeakDropDownGehitu(sql)
                sql = "SELECT DISTINCT(posta_kodea) FROM posta_kodeak WHERE upper(PROBINTZIA) LIKE '" & cbProbintzia.Text.ToUpper & "' ORDER BY posta_kodea ASC"
                PostaKodeakDropDownGehitu(sql)
            Else
                If cbProbintzia.Text <> "Probintzia" Then
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
    End Sub

    Private Sub cbHerriKodea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbHerriKodea.SelectedIndexChanged
        If cbHerria.Text = "Herri kodeak" Then
            PostaKodeakGuztiakKargatu()
        Else
            Dim sql = "SELECT DISTINCT(posta_kodea) FROM posta_kodeak WHERE herri_kodea = '" & cbHerriKodea.SelectedValue & "' ORDER BY posta_kodea ASC"
            PostaKodeakDropDownGehitu(sql)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Dim f1 As New Leiho3_OstatuKudeaketa
        f1.Show()
    End Sub


End Class