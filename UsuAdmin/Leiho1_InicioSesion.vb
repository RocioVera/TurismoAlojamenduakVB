Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class Leiho1_InicioSesion
    Dim datos As New ArrayList
    Dim server As String = "server=192.168.13.15;user=root;database=3262035_ostatuagrad;port=3306;"
    'Dim server As String = "server=localhost;user=root;database=3262035_ostatuagrad;port=3306;"
    Dim konexion As MySqlConnection


    Private Sub Leiho1_InicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBezeroa.Select()
    End Sub

    Function saioaHasi()
        Dim bezeroa As String
        Dim pasahitza As String
        bezeroa = txtBezeroa.Text.ToString
        pasahitza = txtPasahitza.Text.ToString
        Try
            'Konexioa egin
            konexion = New MySqlConnection(server)
            'Konexioa zabaldu
            konexion.Open()
            'Konexioarekin komandoa egin
            Dim cmd1 = konexion.CreateCommand()
            'SQL komandoa
            cmd1.CommandText = "SELECT baimena FROM Erabiltzaileak WHERE nan = @user AND pasahitza=@pass"
            Dim userencriptado = AES_Encrypt(Me.txtBezeroa.Text, "encriptado")
            Dim psswencriptado = AES_Encrypt(Me.txtPasahitza.Text, "encriptado")
            'Erabiltzaile eremuko textua parametro bezala jarri
            cmd1.Parameters.AddWithValue("@user", userencriptado)
            'Pasahitza eremuko textua parametro bezala jarri
            cmd1.Parameters.AddWithValue("@pass", psswencriptado)
            'Lerro fluxuak irakurri
            Dim das1 As MySqlDataReader
            'Lerro fluxuen komandoa exekutatu
            das1 = cmd1.ExecuteReader()
            'Lerroak (datuak) badaude
            If das1.HasRows() Then
                While das1.Read()
                    If (das1.GetInt32(0) = 0) Then 'superAdmin
                        Me.Hide()
                        Dim ad As New Leiho2_AurkeraAdmin 'bidali  admin lehiora 
                        ad.Show()
                    ElseIf (das1.GetInt32(0) = 2) Then 'ostatu administratzaileak
                        Me.Hide()
                        Dim un As New Leiho2_AukeraBezeroNormala 'bidali erabiltzale normalaren lehiora
                        un.Show()
                    ElseIf (das1.GetInt32(0) = 1) Then 'gonbidatuak
                        MsgBox("Baimena gonbidatuak, ezin zara sartu")
                    End If
                End While
            Else
                lblErrorea.Visible = True
            End If

        Catch ex As Exception
            'Konexioa itxi
            konexion.Close()
            'Errore mezua
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub btnHasiSaioa_Click(sender As Object, e As EventArgs) Handles btnHasiSaioa.Click
        saioaHasi()
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

    Private Sub txtPasahitza_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPasahitza.KeyDown, txtBezeroa.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                saioaHasi()
        End Select
    End Sub

End Class
