Imports MySql.Data.MySqlClient

Public Class OstatuakIkusiV2

    Dim dr As MySqlDataReader
    Dim komando As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim data As New DataSet
    Dim cnn1 As MySqlConnection
    Dim server As String = "server=localhost;user=root;database=datubasea;port=3306;"
    'Dim server As String = "server=192.168.13.15;user=root;database=3262035_ostatuagrad;port=3306;"



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ListView1.View = View.Details
        Me.ListView1.GridLines = True

        Me.ListView1.Anchor = AnchorStyles.Bottom + AnchorStyles.Left + AnchorStyles.Right + AnchorStyles.Top
        TaulaAtera() ' llamamos al metodo para cargar los datos
    End Sub



    Private Sub TaulaAtera()

        Try
            cnn1 = New MySqlConnection(server)

            Dim SQL As String = "SELECT  `ID_SIGNATURA`, `OSTATU_IZENA`, `DESKRIBAPENA`, `OSTATU_HELBIDEA`, `MARKA`, `OSTATU_EMAIL`, `OSTATU_TELEFONOA`, `PERTSONA_TOT`, `LATITUDE`, `LONGITUDE`, `MOTA`, `WEB_URL`, `ADISKIDETSU_URL`, `ZIP_URL`, `POSTA_KODEA`, `HERRI_KODEA` FROM ostatuak"

            komando.Connection = cnn1
            komando.CommandText = SQL
            adapter.SelectCommand = komando
            cnn1.Open()
            dr = komando.ExecuteReader

            data.Clear()

            ListView1.Clear()

            'ListViiew configurazioa
            ListView1.Columns.Add("ID_SIGNATURA", 70, HorizontalAlignment.Left)  'ZUTABEEN IZENAK 
            ListView1.Columns.Add("OSTATU_IZENA", 80, HorizontalAlignment.Left)
            ListView1.Columns.Add("DESKRIBAPENA", 120, HorizontalAlignment.Left)
            ListView1.Columns.Add("HELBIDEA", 70, HorizontalAlignment.Left)
            ListView1.Columns.Add("MARKA", 170, HorizontalAlignment.Left)
            ListView1.Columns.Add("EMAIL", 70, HorizontalAlignment.Left)
            ListView1.Columns.Add("TLF", 70, HorizontalAlignment.Left)
            ListView1.Columns.Add("PERTSONA_TOTALA", 70, HorizontalAlignment.Left)
            ListView1.Columns.Add("LATITUDEA", 70, HorizontalAlignment.Left)
            ListView1.Columns.Add("LONGITUDEA", 70, HorizontalAlignment.Left)
            ListView1.Columns.Add("MOTA", 70, HorizontalAlignment.Left)
            ListView1.Columns.Add("WEB_URL", 70, HorizontalAlignment.Left)
            ListView1.Columns.Add("ADISKIDE_URL", 70, HorizontalAlignment.Left)
            ListView1.Columns.Add("ZIP_URL", 70, HorizontalAlignment.Left)
            ListView1.Columns.Add("POSTA_KODEA", 70, HorizontalAlignment.Left)
            ListView1.Columns.Add("HERRI_KODEA", 70, HorizontalAlignment.Left)


            Dim z As Integer

            While dr.Read
                ListView1.Items.Add(dr.Item(0))    'lerro bat gehitzen dut - Items
                ListView1.Items(z).SubItems.Add(dr.Item(1)) 'zutabe bat gehitzen dut- SubItems
                ListView1.Items(z).SubItems.Add(dr.Item(2)) 'zutabe bat gehitzen dut- SubItems
                ListView1.Items(z).SubItems.Add(dr.Item(3)) 'zutabe bat gehitzen dut- SubItems
                ListView1.Items(z).SubItems.Add(dr.Item(4)) 'zutabe bat gehitzen dut- SubItems
                ListView1.Items(z).SubItems.Add(dr.Item(5)) 'zutabe bat gehitzen dut- SubItems
                ListView1.Items(z).SubItems.Add(dr.Item(6)) 'zutabe bat gehitzen dut- SubItems
                ListView1.Items(z).SubItems.Add(dr.Item(7)) 'zutabe bat gehitzen dut- SubItems
                ListView1.Items(z).SubItems.Add(dr.Item(8)) 'zutabe bat gehitzen dut- SubItems
                ListView1.Items(z).SubItems.Add(dr.Item(9)) 'zutabe bat gehitzen dut- SubItems
                ListView1.Items(z).SubItems.Add(dr.Item(10)) 'zutabe bat gehitzen dut- SubItems
                ListView1.Items(z).SubItems.Add(dr.Item(11)) 'zutabe bat gehitzen dut- SubItems
                ListView1.Items(z).SubItems.Add(dr.Item(12)) 'zutabe bat gehitzen dut- SubItems
                ListView1.Items(z).SubItems.Add(dr.Item(13)) 'zutabe bat gehitzen dut- SubItems
                ListView1.Items(z).SubItems.Add(dr.Item(14)) 'zutabe bat gehitzen dut- SubItems
                ListView1.Items(z).SubItems.Add(dr.Item(15)) 'zutabe bat gehitzen dut- SubItems
                ListView1.Items(z).SubItems.Add(dr.Item(16)) 'zutabe bat gehitzen dut- SubItems

                If z Mod 2 = 0 Then

                    ListView1.Items(z).BackColor = Color.DarkGray


                End If
                z += 1
            End While
            dr.Close()
            cnn1.Close()
        Catch ex As ArgumentOutOfRangeException
            MsgBox(ex.Message)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim er As New ErreserbaV2
        er.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim bukatu As New AukeraBezeroNormalaV2
        bukatu.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnHotela.Click
        Dim mota As String = "Hotela"
        Actualizar(mota)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnAlbergue.Click
        Dim mota As String = "Albergue"
        Actualizar(mota)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnEtxea.Click
        Dim mota As String = "Etxea"
        Actualizar(mota)
    End Sub


    Private Sub Actualizar(ByRef mota)

        Try
            cnn1 = New MySqlConnection(server)



            Dim SQL As String = "SELECT * FROM ostatuak WHERE  mota = '" & mota & "'"

            komando.Connection = cnn1
            komando.CommandText = SQL
            adapter.SelectCommand = komando
            cnn1.Open()
            dr = komando.ExecuteReader

            data.Clear()

            ListView1.Clear()

            ' ListViiew configurazioa
            ListView1.Columns.Add("ID_SIGNATURA", 70, HorizontalAlignment.Left)  'ZUTABEEN IZENAK 
            ListView1.Columns.Add("OSTATU_IZENA", 80, HorizontalAlignment.Left)
            ListView1.Columns.Add("DESKRIBAPENA", 120, HorizontalAlignment.Left)
            ListView1.Columns.Add("HELBIDEA", 70, HorizontalAlignment.Left)
            ListView1.Columns.Add("MARKA", 170, HorizontalAlignment.Left)
            ListView1.Columns.Add("EMAIL", 70, HorizontalAlignment.Left)
            ListView1.Columns.Add("TLF", 70, HorizontalAlignment.Left)
            ListView1.Columns.Add("PERTSONA_TOTALA", 70, HorizontalAlignment.Left)
            ListView1.Columns.Add("LATITUDEA", 70, HorizontalAlignment.Left)
            ListView1.Columns.Add("LONGITUDEA", 70, HorizontalAlignment.Left)
            ListView1.Columns.Add("MOTA", 70, HorizontalAlignment.Left)
            ListView1.Columns.Add("WEB_URL", 70, HorizontalAlignment.Left)
            ListView1.Columns.Add("ADISKIDE_URL", 70, HorizontalAlignment.Left)
            ListView1.Columns.Add("ZIP_URL", 70, HorizontalAlignment.Left)
            ListView1.Columns.Add("POSTA_KODEA", 70, HorizontalAlignment.Left)
            ListView1.Columns.Add("HERRI_KODEA", 70, HorizontalAlignment.Left)


            Dim z As Integer

            While dr.Read
                ListView1.Items.Add(dr.Item(0))    'lerro bat gehitzen dut - Items
                ListView1.Items(z).SubItems.Add(dr.Item(1)) 'zutabe bat gehitzen dut- SubItems
                ListView1.Items(z).SubItems.Add(dr.Item(2)) 'zutabe bat gehitzen dut- SubItems
                ListView1.Items(z).SubItems.Add(dr.Item(3)) 'zutabe bat gehitzen dut- SubItems
                ListView1.Items(z).SubItems.Add(dr.Item(4)) 'zutabe bat gehitzen dut- SubItems
                ListView1.Items(z).SubItems.Add(dr.Item(5)) 'zutabe bat gehitzen dut- SubItems
                ListView1.Items(z).SubItems.Add(dr.Item(6)) 'zutabe bat gehitzen dut- SubItems
                ListView1.Items(z).SubItems.Add(dr.Item(7)) 'zutabe bat gehitzen dut- SubItems
                ListView1.Items(z).SubItems.Add(dr.Item(8)) 'zutabe bat gehitzen dut- SubItems
                ListView1.Items(z).SubItems.Add(dr.Item(9)) 'zutabe bat gehitzen dut- SubItems
                ListView1.Items(z).SubItems.Add(dr.Item(10)) 'zutabe bat gehitzen dut- SubItems
                ListView1.Items(z).SubItems.Add(dr.Item(11)) 'zutabe bat gehitzen dut- SubItems
                ListView1.Items(z).SubItems.Add(dr.Item(12)) 'zutabe bat gehitzen dut- SubItems
                ListView1.Items(z).SubItems.Add(dr.Item(13)) 'zutabe bat gehitzen dut- SubItems
                ListView1.Items(z).SubItems.Add(dr.Item(14)) 'zutabe bat gehitzen dut- SubItems
                ListView1.Items(z).SubItems.Add(dr.Item(15)) 'zutabe bat gehitzen dut- SubItems
                ListView1.Items(z).SubItems.Add(dr.Item(16)) 'zutabe bat gehitzen dut- SubItems

                If z Mod 2 = 0 Then

                    ListView1.Items(z).BackColor = Color.DarkGray

                End If
                z += 1
            End While
            dr.Close()
            cnn1.Close()
        Catch ex As ArgumentOutOfRangeException
            MsgBox(ex.Message)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAtzera_Click(sender As Object, e As EventArgs) Handles btnAtzera.Click
        Me.Hide()
        Dim f1 As New Leiho1_InicioSesion
        f1.Show()
    End Sub
End Class