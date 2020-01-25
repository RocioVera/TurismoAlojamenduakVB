Imports MySql.Data.MySqlClient

Public Class Leiho5_ErreserbaUpdate
    Dim komando As New MySqlCommand
    Dim cnn1 As MySqlConnection
    Dim direccion As String = "server=localhost;user=root;database=3262035_ostatuagrad;port=3306;"
    Dim ek As New Leiho3_ErreserbaKudeaketa
    Dim cont As New Integer
    Dim v_id_erreserba As Integer
    Dim hautatutakoErreserba As Erreserbak

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim v_dataamaiera As String
        Dim v_datahasieras As String
        Dim v_preziotot As Integer
        Dim v_pertsonakant As String

        v_dataamaiera = amaieradata.SelectionRange.Start.ToShortDateString
        v_datahasieras = hasieradata.SelectionRange.Start.ToShortDateString

        Try
            v_preziotot = prezioa.Text.ToString
            prezioa.BackColor = Color.Green
        Catch ex As Exception
            prezioa.BackColor = Color.Red
            cont += 1
        End Try

        v_pertsonakant = p_cant.Value.ToString

        'update sentencia
        If cont = 0 Then
            Try
                cnn1 = New MySqlConnection(direccion)
                Dim SQL2 As New MySqlCommand("UPDATE erreserbak set DATA_AMAIERA = '" & v_dataamaiera & " ' , DATA_HASIERA =  " & v_datahasieras & " , ERRESERBA_PREZIO_TOT = '" & v_preziotot & "' , PERTSONA_KANT_ERRES = '" & v_pertsonakant & "'  WHERE ID_ERRESERBA = '" & v_id_erreserba & "'", cnn1)
                'importante para la conexion y ejecutar las sentencias sql
                komando.Connection = cnn1
                cnn1.Open()
                SQL2.ExecuteNonQuery()
                cnn1.Close()
                Me.Hide()
                ek.Show()
            Catch ex As Exception
                'MsgBox(ex.Message) 'para sacar los fallos de la update 
            End Try
        Else
            cont = 0
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        ek.Show()
    End Sub

    Public Sub ErreserbaJaso(hb As Erreserbak)
        hautatutakoErreserba = hb
    End Sub

    Private Sub Leiho5_ErreserbaUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hasieradata.SelectionStart = hautatutakoErreserba.DataHasiera
        amaieradata.SelectionStart = hautatutakoErreserba.DataAmaiera
        prezioa.Text = hautatutakoErreserba.ErreserbaPrezioa
        p_cant.Value = hautatutakoErreserba.PertsonaKant
    End Sub

    Private Sub p_cant_ValueChanged(sender As Object, e As EventArgs) Handles p_cant.ValueChanged
        Randomize()
        Dim erreserbaPrezioa As Double = CInt(Int((Rnd() * 300.0) + 80.0)) * p_cant.Value
        prezioa.Text = erreserbaPrezioa
    End Sub
End Class