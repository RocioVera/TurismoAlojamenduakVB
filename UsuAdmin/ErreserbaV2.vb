Imports MySql.Data.MySqlClient

Public Class ErreserbaV2
    Dim lista As New ArrayList
    Dim dr As MySqlDataReader
    Dim komando As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim data As New DataSet
    Dim cnn1 As MySqlConnection
    Dim server As String = "server=localhost;user=root;database=datubasea;port=3306;"

    Private Sub Erreserba_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        geter() 'llamamos al metodo para que se cargue el dni automaticamente
        numAleatorios()
    End Sub

    Public Function geter() ' recojer los datos del inicio de sesion y ponerlos en el textbox
        Dim dniUsu As String = Leiho1_InicioSesion.txtBezeroa.Text.ToString

        TextBox1.Text = dniUsu
    End Function


    'METODO PARA GENERAR NUM ALEATORIOS
    Sub numAleatorios()
        Randomize()
        Dim zbkErreserba As Integer = Rnd() * 100
        TextBox2.Text = zbkErreserba

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim cancel As New OstatuakIkusiV2
        cancel.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Randomize()
        Dim ostatuIzena As String = TextBox3.Text.ToString
        Dim signatura As String
        SacarSignatura(ostatuIzena)
        signatura = lista(0)
        Dim dataAmaiera As String = MonthCalendar2.SelectionRange.Start.ToShortDateString()
        Dim DAtaHasiera As String = MonthCalendar1.SelectionRange.Start.ToShortDateString()
        Dim prezioa As String = Rnd() * 100
        Dim pertsonaKant As Integer = ComboBox1.SelectedItem
        Dim erabiltzaileNan As String = Leiho1_InicioSesion.txtBezeroa.Text.ToString


        'hacemos el  insert
        'sentencia sql para la insert
        ' insert INTO `erreserbak`(`ID_ERRESERBA`, `DATA_AMAIERA`, `DATA_HASIERA`, `ERRESERBA_PREZIO_TOT`, `PERTSONA_KANT_ERRES`, `OSTATUAK_ID_SIGNATURA`, `ERABILTZAILEAK_NAN`) VALUES ([value-1],[value-2],[value-3],[value-4],[value-5],[value-6],[value-7])


    End Sub



    Function SacarSignatura(ByRef ostatuIzena)



        Try

            cnn1 = New MySqlConnection(server)

            Dim SQL As New MySqlCommand
            SQL = "SELECT ID_SIGNATURA FROM ostatuak WHERE OSTATU_IZENA = '" & ostatuIzena & "'"

            SQL.Connection = cnn1
            ' komando.CommandText = SQL
            adapter.SelectCommand = komando
            cnn1.Open()
            dr = SQL.ExecuteReader

            While dr.Read()
                lista.Add(dr.GetString(0))

            End While

            cnn1.Close()
        Catch ex As Exception

        End Try



    End Function


End Class