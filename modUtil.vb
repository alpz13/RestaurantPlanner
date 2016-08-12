Imports System.Data
Imports System.Data.SqlClient

Module modUtil

    Private connection As SqlConnection

    '---------------------------------------------------------------------------------------------------------'
    '  Despliega un MessageBox de error que muestra el mensaje pasado como parámetro                          '
    '                                                                                                         '
    '  @param err  El error a desplegar                                                                       '
    '---------------------------------------------------------------------------------------------------------'

    Public Sub msgError(ByVal err As String)
        MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, False)
    End Sub

    Public Sub llenarCombo(ByRef cmb As ComboBox, ByVal s As String)

        Dim Table As DataTable = getDataTable(s)

        If Table IsNot Nothing Then
            For i = 0 To Table.Rows.Count - 1

                cmb.Items.Add(Table.Rows(i).Item(0))

            Next


        Else
            cmb.Items.Clear()
        End If

    End Sub

    Function getDataAdapter(ByVal query As String) As SqlDataAdapter
        Return New SqlDataAdapter(query, connection)
    End Function


    '---------------------------------------------------------------------------------------------------------'
    '  Crea una conexión con el servidor pasado como parámetro utilizando el nombre de usuario y password     '
    '  pasados como parámetro y se conecta al catálogo pasado como parámetro.                                 '
    '                                                                                                         '
    '  @param servidor  El servidor al que se va a conectar                                                   '
    '  @param catalogo  El catalogo al que se va a conectar                                                   '
    '  @param user      El nombre de usuario con el que te conectas                                           '
    '  @param pass      El password del usuario                                                               '
    '---------------------------------------------------------------------------------------------------------'


    Public Sub createConnection(ByVal servidor As String, ByVal catalogo As String, _
                         ByVal user As String, ByVal pass As String)
        Try
            connection = New SqlConnection()
            connection.ConnectionString = "Data Source=" & servidor & ",1433;" & _
                                          "Network Library=DBMSSOCN;" & _
                                          "Initial Catalog=" & catalogo & ";" & _
                                          "User ID=" & user & ";" & _
                                          "Password=" & pass & ";"

            connection.Open()
            connection.Close()

        Catch sqlex As SqlException
            Dim Err As String
            Err = "Error al realizar la conexión con " & servidor & vbCrLf & _
                  sqlex.Message
            msgError(Err)
        Catch ex As Exception
            msgError("Error al intentar abrir conexión")
        End Try

    End Sub


    'Function execute(ByVal dml As String) As Boolean
    '   Try
    'Dim command As New SqlCommand(dml, connection)
    '       connection.Open()
    '      command.ExecuteNonQuery()
    '     connection.Close()
    '    Return True
    'Catch sqlex As SqlException
    'Dim Err As String
    '       Err = "Error de la base de datos al ejecutar el comando" & vbCrLf & sqlex.Message
    '      msgError(Err)
    '     Return False
    'Catch ex As Exception
    'Dim Err As String
    '      Err = "Error al ejecutar el comando" & vbCrLf & ex.Message
    '       msgError(Err)
    '     Return False
    'End Try
    'End Function

    '---------------------------------------------------------------------------------------------------------'
    '  Esta función utiliza la conexión abierta para realizar el query pasado como parámetro y regresa un     '
    '  DataReader con los datos leídos                                                                        '
    '                                                                                                         '
    '  @param  query  El query que se va a ejecutar en la base de datos                                       '
    '  @return  Un SqlDataReader con los datos leídos de la base de datos al ejecutar el query                '
    '---------------------------------------------------------------------------------------------------------'


    Public Function getDataReader(ByVal query As String) As SqlDataReader
        Dim command As New SqlCommand(query, connection)
        Try
            Return command.ExecuteReader(CommandBehavior.CloseConnection)
        Catch sqlex As SqlException
            Dim err As String
            err = "Error de base de datos al ejecutar el query" & vbCrLf & _
                  sqlex.Message
            msgError(err)
        Catch ex As Exception
            msgError("Error al ejecutar el query")
        End Try
        Return Nothing
    End Function



    '---------------------------------------------------------------------------------------------------------'
    '  Esta función utiliza la conexión abierta para realizar el query pasado como parámetro y regresa un     '
    '  DataTable con los datos leídos                                                                         '
    '                                                                                                         '
    '  @param  query  El query que se va a ejecutar en la base de datos                                       '
    '  @return  Un DataTable con los datos leídos de la base de datos al ejecutar el query                    '
    '---------------------------------------------------------------------------------------------------------'
    Public Function getDataTable(ByVal query As String) As DataTable
        Dim command As New SqlCommand(query, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable

        Try
            adapter.Fill(table)
            If table.Rows.Count > 0 Then
                Return table
            Else
                Return Nothing
            End If
        Catch sqlex As SqlException
            Dim err As String
            err = "Error de base de datos al ejecutar el query" & vbCrLf & _
                  sqlex.Message
            msgError(err)
        Catch ex As Exception
            msgError("Error al ejecutar el query")
        End Try
        Return Nothing
    End Function


    '---------------------------------------------------------------------------------------------------------'
    '  Llena la forma pasada como parámetro utilizando el query pasado como parámetro. Dentro de la forma     '
    '  deben haber controles que tengan los mismos nombres que las columnas que se encuentran en el query.    '
    '  Por ejemplo, si el query es 'SELECT nombre FROM usuarios' debe haber un control llamado 'nombre' entre '
    '  los controles de la forma                                                                              '
    '                                                                                                         '
    '  @param  query  El query que se quiere ejecutar en la base de datos.                                    '
    '  @param  form   La forma que se quiere llenar con los datos                                              '
    '---------------------------------------------------------------------------------------------------------'
    Public Sub showData(ByVal query As String, ByVal form As Form)
        Dim dt As DataTable
        Dim ctrl As Control
        dt = getDataTable(query)
        If Not dt Is Nothing Then
            For Each ctrl In form.Controls
                If dt.Columns.Contains(ctrl.Name) Then
                    If TypeOf (ctrl) Is TextBox Or TypeOf (ctrl) Is MaskedTextBox Then
                        ctrl.Text = dt.Rows(0)(ctrl.Name)
                    ElseIf TypeOf (ctrl) Is ComboBox Or TypeOf (ctrl) Is ListBox Then
                        DirectCast(ctrl, ComboBox).SelectedValue = dt.Rows(0)(ctrl.Name)
                    ElseIf TypeOf (ctrl) Is DateTimePicker Then
                        DirectCast(ctrl, DateTimePicker).Value = dt.Rows(0)(ctrl.Name)
                    Else
                        Try
                            ctrl.Text = dt.Rows(0)(ctrl.Name)
                        Catch ex As Exception
                        End Try
                    End If
                End If
            Next
        End If
    End Sub


    '---------------------------------------------------------------------------------------------------------'
    '  Llena el ComboBox pasado como parámetro con los datos que se recuperan del query pasado como parámetro.'
    '  El ComboBox se va a llenar mediante su ValueMember y su DisplayMember con la primera y segunda columna '
    '  regresadas del query respectivamente.                                                                  '
    '                                                                                                         '
    '  @param  lst    El ComboBox que se va a llenar con los datos del query                                  '
    '  @param  query  El query que se quiere ejecutar en la base de datos. El query debe tener la forma       '
    '                 SELECT INTEGER, $ FROM Tabla [...]                                                      '
    '                 en donde $ es un dato de cualquier tipo.                                                '
    '---------------------------------------------------------------------------------------------------------'
    Public Sub fillList(ByVal lst As Windows.Forms.ComboBox, ByVal query As String)
        Dim table As DataTable
        table = getDataTable(query)
        If Not table Is Nothing Then
            lst.DataSource = Nothing
            lst.Items.Clear()
            lst.DataSource = table
            If table.Columns.Count = 2 Then
                lst.ValueMember = table.Columns(0).ToString
                lst.DisplayMember = table.Columns(1).ToString
            Else
                lst.DisplayMember = table.Columns(0).ToString
            End If
        End If
    End Sub


    '---------------------------------------------------------------------------------------------------------'
    '  Llena el ListBox pasado como parámetro con los datos que se recuperan del query pasado como parámetro. '
    '  El ListBox se va a llenar mediante su ValueMember y su DisplayMember con la primera y segunda columna  '
    '  regresadas del query respectivamente.                                                                  '
    '                                                                                                         '
    '  @param  lst    El ListBox que se va a llenar con los datos del query                                   '
    '  @param  query  El query que se quiere ejecutar en la base de datos. El query debe tener la forma       '
    '                 SELECT INTEGER, $ FROM Tabla [...]                                                      ' 
    '                 en donde $ es un dato de cualquier tipo.                                               '
    '---------------------------------------------------------------------------------------------------------'
    Public Sub fillList(ByRef lst As Windows.Forms.ListBox, ByVal query As String)
        Dim table As DataTable
        table = getDataTable(query)
        If Not table Is Nothing Then
            lst.DataSource = table
            If table.Columns.Count = 2 Then
                lst.ValueMember = table.Columns(0).ToString
                lst.DisplayMember = table.Columns(1).ToString
            Else
                lst.ValueMember = table.Columns(0).ToString
            End If
        End If
    End Sub

    '---------------------------------------------------------------------------------------------------------'
    '  Llena el DataGrid pasado como parámetro con los datos que se recuperan del query pasado como           '
    '  parámetro.                                                                                             '
    '                                                                                                         '
    '  @param  grid   El DataGrid que se va a llenar con los datos del query                                  '
    '  @param  query  El query que se quiere ejecutar en la base de datos.                                    '
    '---------------------------------------------------------------------------------------------------------'
    Public Sub fillGrid(ByVal grid As Windows.Forms.DataGridView, ByVal query As String)
        Dim table As DataTable
        table = getDataTable(query)
        If Not table Is Nothing Then
            grid.DataSource = table
        End If
    End Sub

    '---------------------------------------------------------------------------------------------------------'
    '  Cambia el formato del objeto pasado como parámetro a un formato que entiende SQL Server                '
    '                                                                                                         '
    '  @param  param  El objeto que se quiere convertir a formato de SQL Server                               '
    '  @return  Un String que representa al objeto con un formato comprensible por SQL Server                 '
    '---------------------------------------------------------------------------------------------------------'
    Public Function sqlFormat(ByVal param As Object) As String
        If TypeOf param Is String Then
            Dim sParam As String
            sParam = DirectCast(param, String)
            Return ("'" & Replace(sParam, "'", "\'") & "'")
        ElseIf TypeOf param Is Date Then
            Dim dParam As Date
            dParam = DirectCast(param, Date)
            If DirectCast(param, Date).Hour > 11 Then
                Return "'" & Format(dParam, "yyyy-MM-dd hh:mm:ss") & " pm'"
            Else
                Return "'" & Format(dParam, "yyyy-MM-dd hh:mm:ss") & " am'"
            End If

        ElseIf param Is Nothing Then
            Return "Null"
        Else
            Try
                Return param.ToString
            Catch ex As Exception
                Throw ex
            End Try
        End If
    End Function

    Public Function execute(ByVal dml As String) As Boolean
        Try
            Dim command As New SqlCommand(dml, connection)
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
            Return True
        Catch sqlex As SqlException
            msgError(sqlex.Message)
            connection.Close()
            Return False
        Catch ex As Exception
            msgError(ex.Message)
            connection.Close()
            Return False
        End Try
    End Function

    Public Function executeValidado(ByVal dml As String) As Boolean
        Dim validado As Integer
        Try
            Dim command As New SqlCommand(dml, connection)
            connection.Open()
            validado = command.ExecuteScalar()
            connection.Close()

            If validado = 1 Then
                Return True
            Else
                Return False
            End If

        Catch sqlex As SqlException
            msgError(sqlex.Message)
            connection.Close()
            Return False
        Catch ex As Exception
            msgError(ex.Message)
            connection.Close()
            Return False
        End Try
    End Function

    Public Sub executeStoredProcedure(ByVal name As String, ByVal ParamArray parameters() As Object)
        Dim command As String

        command = "EXECUTE " & name & " "
        For Each param As Object In parameters
            command = command & sqlFormat(param) & ", "
        Next
        execute(command.Remove(command.Length - 2))
    End Sub

    Public Function numeroAceptable(ByVal text As String, ByVal n As Integer)

        Try

            If text <> "" And text <= n And text > 0 Then

                Return True

            Else

                Return False

            End If
        Catch e As Exception

            Return False

        End Try


    End Function

End Module
