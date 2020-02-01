Imports MySql.Data.MySqlClient

Public Class Leiho5_OstatuUpdate
    Dim lista As String

    Public v_izena As String
    Dim dr As MySqlDataReader
    Dim komando As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim data As New DataSet
    Dim cnn1 As MySqlConnection
    'Dim server As String = "server=localhost;user=root;database=3262035_ostatuagrad;port=3306;"
    Dim server As String = "server=192.168.13.15;user=root;database=3262035_ostatuagrad;port=3306;"

    Dim hautatutakoOstatua As Ostatuak
    Dim herrikod, probintzia As String


    Private Sub OstatuUpdatea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SacarSignatura(v_izena, lista)
        PostaKodeakGuztiakKargatu()
        HerriaGuztiakKargatu()
        HerriKodeGuztiakKargatu()
        ProbintziaHerriaAtera()
        gehituDatuak()
    End Sub

    Sub ProbintziaHerriaAtera()
        Try
            cnn1 = New MySqlConnection(server)
            Dim sqlString As String = "SELECT probintzia, herri_izena FROM `posta_kodeak` WHERE HERRI_KODEA = '" & hautatutakoOstatua.HerriKodea & "' AND POSTA_KODEA=" & hautatutakoOstatua.PostaKodea
            Dim SQL As New MySqlCommand(sqlString, cnn1)

            SQL.Connection = cnn1
            ' komando.CommandText = SQL
            adapter.SelectCommand = komando
            cnn1.Open()
            dr = SQL.ExecuteReader

            While dr.Read()
                probintzia = dr.GetString(0)
                herrikod = dr.GetString(1)
            End While
        Catch ex As Exception

        Finally
            cnn1.Close()
        End Try
        cbProbintzia.Text = probintzia
        cbHerria.Text = herrikod
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
        cbHerriKodea.Text = hautatutakoOstatua.HerriKodea
        cbPostaKodea.Text = hautatutakoOstatua.PostaKodea
    End Sub

    Public Sub OstatuJaso(ostatua As Ostatuak)
        hautatutakoOstatua = ostatua
    End Sub

    Private Sub btnAldatu_Click(sender As Object, e As EventArgs) Handles btnAldatu.Click
        gorde()

    End Sub

    Private Sub gorde()
        'LAS VARIABLES A USAR
        Dim v_describapena As String = deskribapena.Text.ToString
        Dim v_helbidea As String = helbidea.Text.ToString
        Dim v_marka As String = marka.Text.ToString
        Dim v_email As String = email.Text.ToString
        Dim v_telefono As String = telefonoa.Text.ToString
        Dim v_pertsonatot As Integer = pertsonatot.Value.ToString
        Dim v_latitude As String = latitudea.Text.ToString
        Dim v_longitude As String = longitudea.Text.ToString
        Dim v_mota As String = mota.Text.ToString
        Dim v_webuerl As String = weburl.Text.ToString
        Dim v_adiskidetsu As String = adiskidetsuurl.Text.ToString
        Dim v_zip As String = zipurl.Text.ToString
        Dim v_postakodea As String = cbPostaKodea.Text
        Dim v_herrikodea As String = cbHerriKodea.Text
        Dim v_izena As String = izena.Text

        'LA UPDATE 
        Try
            cnn1 = New MySqlConnection(server)

            Dim SQLstring As String = "UPDATE ostatuak set OSTATU_IZENA = '" & v_izena & "' , DESKRIBAPENA = '" & v_describapena & "' , OSTATU_HELBIDEA = '" & v_helbidea & "' , OSTATU_TELEFONOA = '" & v_telefono & "' , MARKA = '" & v_marka & "' , OSTATU_EMAIL = '" & v_email & "', PERTSONA_TOT = '" & v_pertsonatot & "', LATITUDE = '" & v_latitude & "', LONGITUDE = '" & v_longitude & "' , MOTA = '" & v_mota & "', WEB_URL = '" & v_webuerl & "', ADISKIDETSU_URL = '" & v_adiskidetsu & "', ZIP_URL = '" & v_zip & "', POSTA_KODEA = '" & v_postakodea & "', HERRI_KODEA = '" & v_herrikodea & "' WHERE ID_SIGNATURA = '" & hautatutakoOstatua.IdSignatura & "'"
            Dim SQL2 As New MySqlCommand(SQLstring, cnn1)
            ' importante para la conexion y ejecutar las sentencias sql
            komando.Connection = cnn1
            cnn1.Open()
            SQL2.ExecuteNonQuery()
            ' limpiar
            data.Clear()

        Catch ex As Exception
            MsgBox(ex.Message) ' para sacar los fallos de la update 
        Finally
            cnn1.Close()
        End Try

        Me.Hide()
        Dim otk As New Leiho3_OstatuKudeaketa
        otk.Show()
    End Sub

    Sub SacarSignatura(ByRef ostatuIzena, ByRef lista)
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
    End Sub

    Private Sub cbProbintzia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProbintzia.SelectedIndexChanged
        Dim sql As String
        sql = "Select DISTINCT(HERRI_IZENA) FROM posta_kodeak WHERE upper(PROBINTZIA) LIKE '" & cbProbintzia.Text.ToUpper & "' ORDER BY HERRI_IZENA ASC"
        HerriDropDownGehitu(sql)
        sql = "SELECT DISTINCT(herri_kodea) FROM posta_kodeak WHERE upper(PROBINTZIA) LIKE '" & cbProbintzia.Text.ToUpper & "' ORDER BY herri_kodea ASC"
        HerriKodeakDropDownGehitu(sql)
        sql = "SELECT DISTINCT(posta_kodea) FROM posta_kodeak WHERE upper(PROBINTZIA) LIKE '" & cbProbintzia.Text.ToUpper & "' ORDER BY posta_kodea ASC"
        PostaKodeakDropDownGehitu(sql)
        cbHerriKodea.Text = ""
        cbPostaKodea.Text = ""
        cbHerria.Text = ""
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

        If cbHerria.Text <> "" Then
            sql = "SELECT DISTINCT(herri_kodea) FROM posta_kodeak WHERE upper(herri_izena) LIKE upper( '" & cbHerria.Text & "') "

            If cbProbintzia.Text <> "Probintzia" Then
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
        cbHerriKodea.Enabled = True
        cbPostaKodea.Enabled = False
        cbHerriKodea.Text = ""
        cbPostaKodea.Text = ""
    End Sub

    Private Sub cbHerriKodea_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim sql = "SELECT DISTINCT(posta_kodea) FROM posta_kodeak WHERE herri_kodea = '" & cbHerriKodea.SelectedValue & "' ORDER BY posta_kodea ASC"
        PostaKodeakDropDownGehitu(sql)
        cbPostaKodea.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnAtzera.Click
        atzera()
    End Sub

    Private Sub atzera()
        Me.Hide()
        Dim f1 As New Leiho3_OstatuKudeaketa
        f1.Show()
    End Sub

    Private Sub cbHerriKodea_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbHerriKodea.SelectedIndexChanged
        Dim sql = "SELECT DISTINCT(posta_kodea) FROM posta_kodeak WHERE herri_kodea = '" & cbHerriKodea.Text & "' ORDER BY posta_kodea ASC"
        PostaKodeakDropDownGehitu(sql)
        cbPostaKodea.Enabled = True
        cbPostaKodea.Text = ""

    End Sub

    Private Sub izena_KeyDown(sender As Object, e As KeyEventArgs) Handles zipurl.KeyDown, weburl.KeyDown, telefonoa.KeyDown, pertsonatot.KeyDown, mota.KeyDown, marka.KeyDown, longitudea.KeyDown, latitudea.KeyDown, izena.KeyDown, helbidea.KeyDown, email.KeyDown, deskribapena.KeyDown, cbProbintzia.KeyDown, cbPostaKodea.KeyDown, cbHerriKodea.KeyDown, cbHerria.KeyDown, adiskidetsuurl.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                gorde()
            Case Keys.Escape
                atzera()
        End Select
    End Sub

    Private Sub Leiho5_OstatuUpdate_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                gorde()
            Case Keys.Escape
                atzera()
        End Select
    End Sub
End Class