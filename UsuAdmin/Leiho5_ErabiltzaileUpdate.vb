Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class Leiho5_ErabiltzaileUpdate
    Dim komando As New MySqlCommand
    Dim cnn1 As MySqlConnection
    Dim server As String = "server=localhost;user=root;database=3262035_ostatuagrad;port=3306;"
    'Dim server As String = "server=192.168.13.15;user=root;database=3262035_ostatuagrad;port=3306;"

    Public hautatutakoBezeroa As Bezeroa

    Private Sub ErabiltzaileUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nan.Text = hautatutakoBezeroa.nan
        abizena.Text = hautatutakoBezeroa.abizenak
        If hautatutakoBezeroa.baimena = 0 Then
            cbBaimena.SelectedIndex = 1
        ElseIf hautatutakoBezeroa.baimena = 1 Then
            cbBaimena.SelectedIndex = 2
        Else
            cbBaimena.SelectedIndex = 0
        End If

        email.Text = hautatutakoBezeroa.email
        izena.Text = hautatutakoBezeroa.erabil_izena
        telefono.Text = hautatutakoBezeroa.telefonoa
    End Sub

    Public Sub datuakJaso(hb As Bezeroa)
        hautatutakoBezeroa = hb
    End Sub


    Private Sub izena_KeyDown(sender As Object, e As KeyEventArgs) Handles telefono.KeyDown, izena.KeyDown, email.KeyDown, cbBaimena.KeyDown, abizena.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                updatear()
            Case Keys.Escape
                atzera()
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGorde.Click
        updatear()
    End Sub

    Public Sub updatear()
        'datuak gordetzeko aldagaiak 
        Dim v_NAN As Integer
        Dim v_izena As String
        Dim v_abizena As String
        Dim v_baimena As Integer = 2
        Dim baimena = cbBaimena.Text
        If baimena = "Administratzailea" Then
            v_baimena = 0
        ElseIf baimena = "Gonbidatua" Then
            v_baimena = 1
        ElseIf baimena = "Bezero normala" Then
            v_baimena = 2
        Else
            v_baimena = -1

        End If
        Dim v_email As String
        Dim v_telefono As Integer
        Dim NAN_introducido As String

        'VARIABLES DE LOS DATOS ENCRIPTADOS 
        Dim v_NAN_E As String
        Dim v_izena_E As String
        Dim v_abizena_E As String
        Dim v_email_E As String
        Dim v_telefono_E As String
        Dim cont As Integer = 0

        ' DATUAK TEXTBOXETIK HARTU 
        Try
            v_NAN = Integer.Parse(Me.nan.Text.ToString)
            nan.BackColor = Color.Green
        Catch ex As Exception
            nan.Text = ""
            nan.Focus()
            nan.BackColor = Color.Red
            cont += 1
        End Try

        Try
            v_izena = Me.izena.Text.ToString
            izena.BackColor = Color.Green
        Catch ex As Exception
            izena.Text = ""
            izena.Focus()
            izena.BackColor = Color.Red
            cont += 1
        End Try

        Try
            v_abizena = Me.abizena.Text.ToString
            abizena.BackColor = Color.Green
        Catch ex As Exception
            abizena.Text = ""
            abizena.Focus()
            abizena.BackColor = Color.Red
            cont += 1
        End Try

        If (validar_Mail(email.Text.ToString) = True) Then 'korreoa balidatu
            Try
                v_email = Me.email.Text.ToString
                email.BackColor = Color.Green
            Catch ex As Exception
                email.Focus()
                email.BackColor = Color.Red
                cont += 1
            End Try
        Else
            email.Focus()
            email.BackColor = Color.Red
            cont += 1
        End If

        Try
            v_telefono = Integer.Parse(Me.telefono.Text.ToString)
            telefono.BackColor = Color.Green
        Catch ex As Exception
            telefono.Text = ""
            telefono.Focus()
            telefono.BackColor = Color.Red
            cont += 1
        End Try

        If v_baimena = -1 Then
            cbBaimena.Focus()
            cbBaimena.BackColor = Color.Red
            cont += 1
        Else
            cbBaimena.BackColor = Color.Green
        End If

        'ENCRIPTAMOS LOS DATOS 
        v_NAN_E = AES_Encrypt(v_NAN, "encriptado")
        v_izena_E = AES_Encrypt(v_izena, "encriptado")
        v_abizena_E = AES_Encrypt(v_abizena, "encriptado")
        v_email_E = AES_Encrypt(v_email, "encriptado")
        v_telefono_E = AES_Encrypt(v_telefono, "encriptado")

        If cont = 0 Then
            Try
                cnn1 = New MySqlConnection(server)
                Dim SQL As String = "UPDATE erabiltzaileak set ERABIL_IZENA = '" & v_izena_E & "' , ABIZENAK = '" & v_abizena_E & "' , BAIMENA = " & v_baimena & ", ERABIL_EMAIL = '" & v_email_E & "', ERABIL_TELEFONO = '" & v_telefono_E & "' WHERE NAN = '" & AES_Encrypt(Me.nan.Text.ToString, "encriptado") & "'"
                Dim SQL2 As New MySqlCommand(SQL, cnn1)
                'importante para la conexion y ejecutar las sentencias sql
                komando.Connection = cnn1
                cnn1.Open()
                SQL2.ExecuteNonQuery()
                Me.Hide()
                Dim aldatu As New Leiho3_ErabiltzaileKudeaketa
                aldatu.Show()
            Catch ex As Exception
                'MsgBox(ex.Message) 'para sacar los fallos de la update 
            Finally
                cnn1.Close()
            End Try
        Else
            lblErrorea.Visible = True
            cont = 0
        End If
    End Sub

    Public Function validar_Mail(ByVal sMail As String) As Boolean
        Return Regex.IsMatch(sMail, "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        atzera()
    End Sub

    Private Sub atzera()
        Me.Hide()
        Dim ez As New Leiho3_ErabiltzaileKudeaketa
        ez.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) _
        Handles izena.TextChanged, abizena.TextChanged, email.TextChanged, telefono.TextChanged
        btnGorde.Enabled = ((nan.Text.Length > 0) And (izena.TextLength > 0) And (abizena.TextLength > 0) And (email.TextLength > 0) And (telefono.TextLength > 0))
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

End Class