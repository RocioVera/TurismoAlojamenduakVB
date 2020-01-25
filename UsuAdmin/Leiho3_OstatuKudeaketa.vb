Imports MySql.Data.MySqlClient

Public Class Leiho3_OstatuKudeaketa

    Dim dr As MySqlDataReader
    Dim komando As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim data As New DataSet
    Dim cnn1 As MySqlConnection
    Dim direccion As String = "server=localhost;user=root;database=3262035_ostatuagrad;port=3306;"
    Dim hautatutakoOstatua As Ostatuak


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ListView1.View = View.Details
        Me.ListView1.GridLines = True

        Me.ListView1.Anchor = AnchorStyles.Bottom + AnchorStyles.Left + AnchorStyles.Right + AnchorStyles.Top
        TaulaAtera() ' llamamos al metodo para cargar los datos

    End Sub

    Private Sub TaulaAtera()
        Try
            cnn1 = New MySqlConnection(direccion)

            Dim SQL As String = "SELECT * FROM ostatuak"

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
                'ListView1.Items(z).SubItems.Add(dr.Item(16)) 'zutabe bat gehitzen dut- SubItems

                If z Mod 2 = 0 Then

                    ListView1.Items(z).BackColor = Color.DarkGray

                End If
                z += 1
            End While
            dr.Close()
        Catch ex As ArgumentOutOfRangeException
            MsgBox(ex.Message)
        Catch ex As Exception

        End Try
    End Sub

    'boton para regresar a la aukera
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAtzera.Click
        Me.Hide()
        Dim f1 As New Leiho2_AurkeraAdmin
        f1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEzabatu.Click
        Dim id = ListView1.SelectedItems(0).SubItems(0).Text
        Try
            cnn1 = New MySqlConnection(direccion)
            Dim SQL2 As New MySqlCommand("DELETE FROM ostatuak  WHERE ID_SIGNATURA = '" & id & "'", cnn1)

            'importante para la conexion y ejecutar las sentencias sql
            komando.Connection = cnn1
            cnn1.Open()
            SQL2.ExecuteNonQuery()

            'limpiar 
            data.Clear()
            ListView1.Clear()
            cnn1.Close()
            TaulaAtera()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAldatu.Click
        aldatuPantaila()
    End Sub


    Private Sub aldatuPantaila()
        Try
            hautatutakoOstatua = New Ostatuak(ListView1.SelectedItems(0).SubItems(0).Text,
                                              ListView1.SelectedItems(0).SubItems(1).Text,
                                              ListView1.SelectedItems(0).SubItems(2).Text,
                                              ListView1.SelectedItems(0).SubItems(3).Text,
                                              ListView1.SelectedItems(0).SubItems(4).Text,
                                              ListView1.SelectedItems(0).SubItems(5).Text,
                                              ListView1.SelectedItems(0).SubItems(6).Text,
                                              ListView1.SelectedItems(0).SubItems(7).Text,
                                              ListView1.SelectedItems(0).SubItems(8).Text,
                                              ListView1.SelectedItems(0).SubItems(9).Text,
                                              ListView1.SelectedItems(0).SubItems(10).Text,
                                              ListView1.SelectedItems(0).SubItems(11).Text,
                                              ListView1.SelectedItems(0).SubItems(12).Text,
                                              ListView1.SelectedItems(0).SubItems(13).Text,
                                              ListView1.SelectedItems(0).SubItems(14).Text,
                                              ListView1.SelectedItems(0).SubItems(15).Text)
            Dim up As New Leiho5_OstatuUpdate
            up.OstatuJaso(hautatutakoOstatua)
            up.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox("Hautatu bat!")
        End Try
    End Sub


    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)
        ListView1.SelectedItems(0).SubItems(0).Text.ToString() 'para usar el boble click 
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnGehitu.Click
        Me.Hide()
        Dim oi As New Leiho4_OstatuInsert
        oi.Show()
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        aldatuPantaila()
    End Sub
End Class