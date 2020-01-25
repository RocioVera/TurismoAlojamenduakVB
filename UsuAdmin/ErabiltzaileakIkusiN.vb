Imports MySql.Data.MySqlClient

Public Class ErabiltzaileakIkusiN
    Dim dr As MySqlDataReader
    Dim komando As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim data As New DataSet
    Dim cnn1 As MySqlConnection
    Dim direccion As String = "server=localhost;user=root;database=datubasea;port=3306;"


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        TaulaAtera() ' llamamos al metodo para cargar los datos
    End Sub

    Private Sub TaulaAtera()

        Dim pathTot As String = System.AppDomain.CurrentDomain.BaseDirectory, path As String
        Dim array() As String = Split(pathTot, "\")

        For i As Integer = 0 To array.Length - 5
            If array(i) <> "" Then
                path = path & array(i).ToString & "\"
            End If
        Next

        Try
            cnn1 = New MySqlConnection(direccion)

            Dim SQL As String = "SELECT NAN , ERABIL_IZENA , ABIZENAK , BAIMENA , ERABIL_EMAIL , ERABIL_TELEFONO FROM erabiltzaileak"

            komando.Connection = cnn1
            komando.CommandText = SQL
            adapter.SelectCommand = komando
            cnn1.Open()

            data.Clear()
            adapter.Fill(data, "fila")

            Me.DataGridView1.DataSource = data.Tables("fila")
            Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.CadetBlue
            dr = komando.ExecuteReader






            dr.Close()
            cnn1.Close()
        Catch ex As ArgumentOutOfRangeException
            MsgBox(ex.Message)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        adapter.Update(data, "fila")
    End Sub
End Class