Imports MySql.Data.MySqlClient
Public Class Leiho4_ErabiltzaileInsert
    Dim komando As New MySqlCommand
    Dim cnn1 As MySqlConnection
    'Dim server As String = "server=localhost;user=root;database=3262035_ostatuagrad;port=3306;"
    Dim server As String = "server=192.168.13.15;user=root;database=3262035_ostatuagrad;port=3306;"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        atzera()
    End Sub

    Private Sub atzera()
        Me.Hide()
        Dim ek As New Leiho3_ErabiltzaileKudeaketa
        ek.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        insert()
    End Sub

    Public Sub insert()
        Dim v_baimena As Integer = 2
        If cbBaimena.SelectedIndex = 1 Then
            v_baimena = 0
        End If
        Dim v_NAN_E = AES_Encrypt(nan.Text.ToString, "encriptado")
        Dim v_izena_E = AES_Encrypt(txtIzena.Text.ToString, "encriptado")
        Dim v_abizena_E = AES_Encrypt(txtAbizena.Text.ToString, "encriptado")
        Dim v_email_E = AES_Encrypt(txtEmail.Text.ToString, "encriptado")
        Dim v_telefono_E = AES_Encrypt(txtTlf.Text.ToString, "encriptado")
        Dim v_paas_E = AES_Encrypt(txtPass.Text.ToString, "encriptado")

        Try
            cnn1 = New MySqlConnection(server)
            Dim SQL2 As New MySqlCommand("INSERT INTO erabiltzaileak (NAN, ERABIL_IZENA, ABIZENAK, PASAHITZA, BAIMENA, ERABIL_EMAIL, ERABIL_TELEFONO) VALUES ( '" & v_NAN_E & "','" & v_izena_E & "', '" & v_abizena_E & "','" & v_paas_E & "'," & v_baimena & ",'" & v_email_E & "','" & v_telefono_E & "')", cnn1)

            'importante para la conexion y ejecutar las sentencias sql
            komando.Connection = cnn1
            cnn1.Open()

            SQL2.ExecuteNonQuery()
            'limpiar 
            cnn1.Close()
        Catch ex As Exception
            MsgBox(ex.Message) 'para sacar los fallos de la update 
        End Try

        Me.Hide()
        Dim aldatu As New Leiho3_ErabiltzaileKudeaketa
        aldatu.Show()
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

    Private Sub Leiho4_ErabiltzaileInsert_Load(sender As Object, e As EventArgs)
        cbBaimena.SelectedIndex = 0
    End Sub

    Private Sub txtTlf_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTlf.KeyDown, txtPass.KeyDown, txtIzena.KeyDown, txtEmail.KeyDown, txtAbizena.KeyDown, nan.KeyDown, MyBase.KeyDown, cbBaimena.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                insert()
            Case Keys.Escape
                atzera()
        End Select
    End Sub
End Class