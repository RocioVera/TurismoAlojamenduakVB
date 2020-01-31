Imports MySql.Data.MySqlClient

Public Class Leiho5_ErreserbaUpdate
    Dim komando As New MySqlCommand
    Dim cnn1 As MySqlConnection
    ' Dim direccion As String = "server=localhost;user=root;database=3262035_ostatuagrad;port=3306;"
    Dim server As String = "server=192.168.13.15;user=root;database=3262035_ostatuagrad;port=3306;"
    Dim ek As New Leiho3_ErreserbaKudeaketa
    Dim v_id_erreserba As Integer
    Dim hautatutakoErreserba As Erreserbak

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim v_dataamaiera As String = amaieradata.SelectionEnd.ToShortDateString
        Dim v_datahasieras As String = hasieradata.SelectionEnd.ToShortDateString
        Dim v_preziotot As Integer = prezioa.Text
        Dim v_pertsonakant As String = p_cant.Value

        'update sentencia
        Try
            cnn1 = New MySqlConnection(direccion)
            Dim sql As String = "UPDATE erreserbak set DATA_AMAIERA = '" & v_dataamaiera & "' , DATA_HASIERA =  '" & v_datahasieras & "' , ERRESERBA_PREZIO_TOT =" & v_preziotot & " , PERTSONA_KANT_ERRES =" & v_pertsonakant & "  WHERE ID_ERRESERBA = " & hautatutakoErreserba.IdErreserba & ""
            Dim SQL2 As New MySqlCommand(sql, cnn1)
            'importante para la conexion y ejecutar las sentencias sql
            komando.Connection = cnn1
            cnn1.Open()
            SQL2.ExecuteNonQuery()
            cnn1.Close()
            Me.Hide()
            ek.Show()
        Catch ex As Exception
            MsgBox(ex.Message) 'para sacar los fallos de la update 
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        ek.Show()
    End Sub

    Public Sub ErreserbaJaso(hb As Erreserbak)
        hautatutakoErreserba = hb
    End Sub

    Private Sub Leiho5_ErreserbaUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hasieradata.SelectionEnd = hautatutakoErreserba.DataHasiera
        amaieradata.SelectionEnd = hautatutakoErreserba.DataAmaiera
        prezioa.Text = hautatutakoErreserba.ErreserbaPrezioa
        p_cant.Value = hautatutakoErreserba.PertsonaKant
    End Sub

    Private Sub p_cant_ValueChanged(sender As Object, e As EventArgs) Handles p_cant.ValueChanged
        Randomize()
        Dim erreserbaPrezioa As Double = CInt(Int((Rnd() * 300.0) + 80.0)) * p_cant.Value
        prezioa.Text = erreserbaPrezioa
    End Sub
End Class