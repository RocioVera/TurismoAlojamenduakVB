Imports MySql.Data.MySqlClient

Public Class Leiho3_ErreserbaKudeaketa

    Dim dr As MySqlDataReader
    Dim komando As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim data As New DataSet
    Dim cnn1 As MySqlConnection
    'Dim server As String = "server=localhost;user=root;database=3262035_ostatuagrad;port=3306;"
    Dim server As String = "server=192.168.13.15;user=root;database=3262035_ostatuagrad;port=3306;"
    Dim pass As String = "encriptado"
    Dim hautatutakoErreserba As Erreserbak

    Private Sub ErreserbaKudeaketa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ListView1.View = View.Details
        Me.ListView1.GridLines = True


        Me.ListView1.Anchor = AnchorStyles.Bottom + AnchorStyles.Left + AnchorStyles.Right + AnchorStyles.Top
        TaulaAtera() ' llamamos al metodo para cargar los datos
        ListView1.BackColor = ColorTranslator.FromHtml("#FCFEFE")


    End Sub

    Private Sub TaulaAtera()
        Try
            cnn1 = New MySqlConnection(server)
            Dim SQL As String = "SELECT * FROM erreserbak"

            komando.Connection = cnn1
            komando.CommandText = SQL
            adapter.SelectCommand = komando
            cnn1.Open()
            dr = komando.ExecuteReader
            data.Clear()
            ListView1.Clear()

            'ListViiew configurazioa
            ListView1.Columns.Add("ID_ERRESERBA", 70, HorizontalAlignment.Left)  'ZUTABEEN IZENAK 
            ListView1.Columns.Add("DATA AMAIERA", 80, HorizontalAlignment.Left)
            ListView1.Columns.Add("DATA HASIERA", 80, HorizontalAlignment.Left)
            ListView1.Columns.Add("PREZIOA", 70, HorizontalAlignment.Left)
            ListView1.Columns.Add("PERTSONA KANT", 70, HorizontalAlignment.Left)
            ListView1.Columns.Add("SIGNATURA", 70, HorizontalAlignment.Left)
            ListView1.Columns.Add("ERABILTZAILE_NAN", 170, HorizontalAlignment.Left)

            Dim z As Integer
            While dr.Read
                ListView1.Items.Add(dr.Item(0))    'lerro bat gehitzen dut - Items
                ListView1.Items(z).SubItems.Add(dr.Item(1)) 'zutabe bat gehitzen dut- SubItems
                ListView1.Items(z).SubItems.Add(dr.Item(2)) 'zutabe bat gehitzen dut- SubItems
                ListView1.Items(z).SubItems.Add(dr.Item(3)) 'zutabe bat gehitzen dut- SubItems
                ListView1.Items(z).SubItems.Add(dr.Item(4)) 'zutabe bat gehitzen dut- SubItems
                ListView1.Items(z).SubItems.Add(dr.Item(5)) 'zutabe bat gehitzen dut- SubItems
                ListView1.Items(z).SubItems.Add(AES_Decrypt(dr.Item(6), pass)) 'zutabe bat gehitzen dut- SubItems

                If z Mod 2 = 0 Then
                    ListView1.Items(z).BackColor = ColorTranslator.FromHtml("#B7D7EE")
                End If
                z += 1
            End While
            dr.Close()
        Catch ex As ArgumentOutOfRangeException
            MsgBox(ex.Message)
        Catch ex As Exception
        End Try
    End Sub

    Public Function AES_Decrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim decrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
            Dim Buffer As Byte() = Convert.FromBase64String(input)
            decrypted = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return decrypted
        Catch ex As Exception
        End Try

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEzabatu.Click
        Try
            cnn1 = New MySqlConnection(server)

            Dim id As String = ListView1.SelectedItems(0).SubItems(0).Text

            Dim SQL2 As New MySqlCommand("DELETE FROM erreserbak  WHERE ID_ERRESERBA = '" & id & "'", cnn1)

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
            errorea()
        End Try
    End Sub

    Private Sub errorea()
        If lblErrorea.Visible = True Then
            lblErrorea.BackColor = Color.Red
        Else
            lblErrorea.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAtzera.Click
        atzera()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAldatu.Click
        bestePantaila()
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs)
        bestePantaila()
    End Sub

    Private Sub bestePantaila()
        Try
            hautatutakoErreserba = New Erreserbak(ListView1.SelectedItems(0).SubItems(0).Text, ListView1.SelectedItems(0).SubItems(1).Text, ListView1.SelectedItems(0).SubItems(2).Text, ListView1.SelectedItems(0).SubItems(3).Text, ListView1.SelectedItems(0).SubItems(4).Text, ListView1.SelectedItems(0).SubItems(5).Text, ListView1.SelectedItems(0).SubItems(6).Text)

            Dim up As New Leiho5_ErreserbaUpdate
            up.ErreserbaJaso(hautatutakoErreserba)
            up.Show()
            Me.Hide()
        Catch ex As Exception
            errorea()
        End Try
    End Sub

    Private Sub ListView1_DoubleClick_1(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        bestePantaila()
    End Sub

    Private Sub Leiho3_ErreserbaKudeaketa_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown, ListView1.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                bestePantaila()
            Case Keys.Escape
                atzera()
        End Select
    End Sub

    Private Sub atzera()
        Me.Hide()
        Dim f1 As New Leiho2_AurkeraAdmin
        f1.Show()
    End Sub

End Class