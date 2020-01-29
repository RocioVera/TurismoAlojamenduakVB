Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Public Class Leiho3_ErabiltzaileKudeaketa
    Dim dr As MySqlDataReader
    Dim komando As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim data As New DataSet
    Dim cnn1 As MySqlConnection
    Dim direccion As String = "server=localhost;user=root;database=3262035_ostatuagrad;port=3306;"
    Dim pass As String = "encriptado"
    Dim lista As New ArrayList
    Public hautatutakoBezeroa As Bezeroa

    'importante 
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.btnAtzera.BackColor = Color.OldLace
        Me.btnEzabatu.BackColor = Color.OldLace
        Me.btnAldatu.BackColor = Color.OldLace
        Me.ListView1.BackColor = Color.Gray
        Me.ListView1.View = View.Details
        Me.ListView1.GridLines = True

        Me.ListView1.Anchor = AnchorStyles.Bottom + AnchorStyles.Left + AnchorStyles.Right + AnchorStyles.Top
        TaulaAtera() ' llamamos al metodo para cargar los datos
        ListView1.BackColor = ColorTranslator.FromHtml("#FCFEFE")
        'ListView1.BackColor = Color.White


    End Sub

    'metodo para cargar los datos en el textview 
    Private Sub TaulaAtera()
        Try
            cnn1 = New MySqlConnection(direccion)
            Dim SQL As String = "SELECT NAN , ERABIL_IZENA , ABIZENAK , BAIMENA , ERABIL_EMAIL , ERABIL_TELEFONO FROM erabiltzaileak"
            komando.Connection = cnn1
            komando.CommandText = SQL
            adapter.SelectCommand = komando
            cnn1.Open()
            dr = komando.ExecuteReader
            data.Clear()
            ListView1.Clear()
            'ListViiew configurazioa
            ListView1.Columns.Add("NAN", 60, HorizontalAlignment.Left)  'ZUTABEEN IZENAK 
            ListView1.Columns.Add("IZENA", 85, HorizontalAlignment.Left)
            ListView1.Columns.Add("ABIZENAK", 120, HorizontalAlignment.Left)
            ListView1.Columns.Add("BAIMENA", 60, HorizontalAlignment.Left)
            ListView1.Columns.Add("EMAIL", 170, HorizontalAlignment.Left)
            ListView1.Columns.Add("TLF", 67, HorizontalAlignment.Left)

            Dim z As Integer

            While dr.Read
                ListView1.Items.Add(AES_Decrypt(dr.Item(0), pass))    'lerro bat gehitzen dut - Items
                ListView1.Items(z).SubItems.Add(AES_Decrypt(dr.Item(1), pass)) 'zutabe bat gehitzen dut- SubItems
                ListView1.Items(z).SubItems.Add(AES_Decrypt(dr.Item(2), pass)) 'zutabe bat gehitzen dut- SubItems
                ListView1.Items(z).SubItems.Add(dr.Item(3)) 'zutabe bat gehitzen dut- SubItems
                ListView1.Items(z).SubItems.Add(AES_Decrypt(dr.Item(4), pass)) 'zutabe bat gehitzen dut- SubItems
                ListView1.Items(z).SubItems.Add(AES_Decrypt(dr.Item(5), pass)) 'zutabe bat gehitzen dut- SubItems

                If z Mod 2 = 0 Then
                    ListView1.Items(z).BackColor = ColorTranslator.FromHtml("#B7D7EE")
                End If
                z += 1
            End While
            dr.Close()
        Catch ex As ArgumentOutOfRangeException
            MsgBox(ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'delete en el boton 
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEzabatu.Click
        Try
            Dim nan = ListView1.SelectedItems(0).SubItems(0).Text
            Dim nan_E = AES_Encrypt(nan, pass)
            cnn1 = New MySqlConnection(direccion)
            Dim SQL2 As New MySqlCommand("DELETE FROM erabiltzaileak WHERE NAN = '" & nan_E & "'", cnn1)
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAldatu.Click
        bestePantaila()
    End Sub

    Private Sub bestePantaila()
        Try
            hautatutakoBezeroa = New Bezeroa(ListView1.SelectedItems(0).SubItems(0).Text, ListView1.SelectedItems(0).SubItems(1).Text, ListView1.SelectedItems(0).SubItems(2).Text, ListView1.SelectedItems(0).SubItems(3).Text, ListView1.SelectedItems(0).SubItems(4).Text, ListView1.SelectedItems(0).SubItems(5).Text)

            Dim up As New Leiho5_ErabiltzaileUpdate
            up.datuakJaso(hautatutakoBezeroa)
            up.Show()
            Me.Hide()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAtzera.Click
        Me.Hide()
        Dim f1 As New Leiho2_AurkeraAdmin
        f1.Show()
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnGehitu.Click
        Me.Hide()
        Dim ei As New Leiho4_ErabiltzaileInsert
        ei.Show()
    End Sub

    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs)
        Try
            hautatutakoBezeroa = New Bezeroa(ListView1.SelectedItems(0).SubItems(0).Text, ListView1.SelectedItems(0).SubItems(1).Text, ListView1.SelectedItems(0).SubItems(2).Text, ListView1.SelectedItems(0).SubItems(3).Text, ListView1.SelectedItems(0).SubItems(4).Text, ListView1.SelectedItems(0).SubItems(5).Text)

            Dim up As New Leiho5_ErabiltzaileUpdate
            up.datuakJaso(hautatutakoBezeroa)
            up.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox("Hautatu bat!")
        End Try


    End Sub

    Public Function AES_Encrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim encrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
            Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(input)
            encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return encrypted
        Catch ex As Exception
        End Try
    End Function

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        bestePantaila()
    End Sub
End Class