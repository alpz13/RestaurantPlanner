Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class fProductos


    Dim da As SqlDataAdapter
    Private dsProducto As New DataSet
    Private row As DataRow
    Private pos As Integer = 0
    Private agregar As Boolean
    Dim fileName As String


    Dim descuentos As fDescuentos

    Private Sub muestra()
        fileName = ""

        Dim data() As Byte

        If row("Foto") IsNot System.DBNull.Value Then
            Try
                data = row("Foto")
                Foto.Visible = True
                fileName = "temp.jpg"

                Dim fs As New FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write)

                fs.Write(data, 0, UBound(data))
                fs.Close()
                Foto.Load(fileName)

                Kill(fileName)
                errores.Text = "."
            Catch ex As Exception
                errores.Text = ex.Message
            End Try
        Else
            Foto.Visible = False

        End If

    End Sub


    Private Sub btnDescuento_Click(sender As System.Object, e As System.EventArgs) Handles btnDescuento.Click
        If descuentos Is Nothing Then
            descuentos = New fDescuentos
            descuentos.MdiParent = loginscreen.main
        End If
        descuentos.Show()
    End Sub



    Private Sub fProductos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        da = getDataAdapter("Select * from Productos")
        da.FillSchema(dsProducto, SchemaType.Source, "Productos")
        da.Fill(dsProducto, "Productos")

        Dim command As New SqlCommandBuilder(da)
        da.InsertCommand = command.GetInsertCommand
        da.DeleteCommand = command.GetDeleteCommand

        'CHECAR ESTA LINEA SI REALMENTE ES 0 EN ROWS'
        row = dsProducto.Tables("Productos").Rows(0)

        modUtil.fillList(cboTipoComida, "select tip.idTipoComida, tip.Descripcion from tipocomida tip")


       

    End Sub

    Delegate Function SetTextCallback(ByVal text As String) As Boolean

    Private Sub fProductos_Leave(sender As System.Object, e As System.EventArgs) Handles MyBase.Leave
        'Me.Hide()
    End Sub

    Private Sub fProductos_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel() = True
        Me.Hide()
    End Sub



    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        Nombre.Text = ""
        Descripcion.Text = ""
        PrecioAnual.Text = ""
        errores.Text = "."
        fileName = ""
        Foto.Visible = False

        
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        If Not Nombre.Text = "" Then
            showData("select Nombre, Descripcion, precioAnual from productos where nombre like '" & Nombre.Text & "%'", Me)
            errores.Text = "."

            Dim rows As DataRow()
            rows = dsProducto.Tables("Productos").Select("Nombre = '" & Nombre.Text & "'")
            row = rows(0)
            muestra()

            If Descripcion.Text = "" Then
                errores.Text = "Valor no encontrado."
            End If
        Else
            errores.Text = "Coloca un nombre para realizar la búsqueda"
        End If

    End Sub

    Private Sub btnRegresar_Click(sender As System.Object, e As System.EventArgs) Handles btnRegresar.Click
        Me.Hide()
    End Sub

    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
        row = dsProducto.Tables("Productos").NewRow
        leerRow()
        'INTENTA AGREGAR A LA BASE DE DATOS'


        Try
            dsProducto.Tables("Productos").Rows.Add(row)
            da.Update(dsProducto, "Productos")
            MsgBox("SE HA AGREGADO CON EXITO")

        Catch ex As ConstraintException
            msgError("Error al momento de agregar")
        End Try
    End Sub

    Private Sub btnCambiar_Click(sender As System.Object, e As System.EventArgs) Handles btnCambiar.Click
        ofdOpen.Filter = "Imagenes|*.jpg"
        If ofdOpen.ShowDialog = Windows.Forms.DialogResult.OK Then
            fileName = ofdOpen.FileName
            Foto.Load(ofdOpen.FileName)
            Foto.Visible = True
        End If
    End Sub

    Private Sub leerRow()
        Try
            Dim dt As New DataTable
            Dim prueba As Integer
            dt = getDataTable("select idProducto from Productos ")
            prueba = dt.Rows.Count + 1

            row.BeginEdit()
            row("idProducto") = prueba
            row("Nombre") = Nombre.Text
            row("Descripcion") = Descripcion.Text
            row("PrecioAnual") = PrecioAnual.Text
            row("Foto") = System.DBNull.Value
            row("idDescuento") = "5%"
            row("idTipoComida") = cboTipoComida.SelectedValue


            If fileName <> "" Then

                Dim fs As New FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read)
                Dim data(fs.Length) As Byte
                fs.Read(data, 0, fs.Length)
                fs.Close()

                row("Foto") = data

            End If

        Catch ex As Exception
            errores.Text = ex.Message
        End Try

    End Sub

    Private Sub btnModificar_Click(sender As System.Object, e As System.EventArgs) Handles btnModificar.Click
        'row = dsAlumnos.Tables("Alumnos").NewRow

        leerRow()


        'Intento actualizar la base de datos 
        Try
            da.Update(dsProducto, "Productos")
            errores.Text = "El registro fue actualizado de manera correcta"
        Catch ex As ConstraintException
            msgError("Error al actualizar.")
        End Try
    End Sub


    Private Sub Descripcion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Descripcion.KeyPress
        If (Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Or Char.IsNumber(e.KeyChar)) Then
            Exit Sub
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Nombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Nombre.KeyPress
        If (Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Or Char.IsNumber(e.KeyChar)) Then
            Exit Sub
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub PrecioAnual_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PrecioAnual.KeyPress
        If (Char.IsControl(e.KeyChar) Or Char.IsNumber(e.KeyChar)) Then
            Exit Sub
        Else
            e.Handled = True
        End If
    End Sub
End Class