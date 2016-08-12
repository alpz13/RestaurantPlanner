Public Class fMain

    Public frmConsultaMesa As New fConsultaMesas(Me)
    Public ventanaProductos As New fProductos
    Public ventanaMesas As New fMesas(Me)
    Public frmMesas As New fMesas(Me)
    Public frmClientes As New fClientes
    Public ventanaClientes As New fClientes
    Public frmProductos As New fProductos
    Public ventanaEmpleados As New fEmpleados
    Public frmReportes As New fReportes
    Public frmEmpleados As New fEmpleados
    Public frmOrden As New fOrden


    Private Sub fMain_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed

        Application.Exit()
        End
    End Sub

    Private Sub Productos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosToolStripMenuItem.Click

        hideAllVisible()
        frmProductos.Show()
    End Sub


    Private Sub Clientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click

        hideAllVisible()
        frmClientes.Show()
    End Sub

    Private Sub Mesas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        hideAllVisible()
        frmMesas.Show()
    End Sub

    Private Sub Empleados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpleadosToolStripMenuItem.Click

        hideAllVisible()
        frmEmpleados.Show()
    End Sub

    Private Sub Reportes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportesToolStripMenuItem.Click
        hideAllVisible()
        frmReportes.Show()
    End Sub

    

    Private Sub ComandaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MesasToolStripMenuItem.Click
        hideAllVisible()
        frmConsultaMesa.Show()

    End Sub

    Private Sub fMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        frmMesas.Show()
        frmMesas.Hide()
        frmOrden.Show()
        frmProductos.MdiParent = Me
        frmClientes.MdiParent = Me
        frmMesas.MdiParent = Me
        frmConsultaMesa.MdiParent = Me
        frmConsultaMesa.Dock = DockStyle.Fill
        frmConsultaMesa.Show()
        frmEmpleados.MdiParent = Me
        frmReportes.MdiParent = Me
        frmOrden.Hide()

    End Sub
    Private Sub hideAllVisible()

        For Each child As Form In Me.MdiChildren

            If Not TypeOf child Is fConsultaMesas Then
                child.Hide()
            End If

        Next

    End Sub

    Public Sub setPermisos(ByVal usuario As String)

        Dim sql = "select priv.idPrivilegio, priv.descripcion " _
        & "from usuarios as usu, rol as rol, privilegios as priv, conllevan as con " _
        & "where usu.idUsuario = '" & usuario & "' and usu.idrol= rol.idrol and rol.idrol = con.idrol " _
        & "and con.idPrivilegio = priv.idPrivilegio"

        activaPermisos(getDataTable(sql))

    End Sub

    Private Sub activaPermisos(ByVal tablaPermisos As DataTable)
        Dim errorDurante As Boolean = False
        If Not tablaPermisos Is Nothing Then

            Dim length = tablaPermisos.Rows.Count
            If Not length = 0 Then
                With tablaPermisos
                    For i = 0 To length - 1 Step +1
                        errores.Text = "Activando permiso: " & tablaPermisos.Rows.Item(i).Item(1).ToString
                        Select Case tablaPermisos.Rows.Item(i).Item(0)
                            Case 1
                                'errores.Text = "Permiso activado: " & tablaPermisos.Rows.Item(i).Item(1).ToString
                                'Alta y Baja de Mesas
                                frmConsultaMesa.pnlEdicion.Visible = True
                                frmConsultaMesa.pnlEdicion.Enabled = True

                            Case 2
                                'errores.Text = "Permiso activado: " & tablaPermisos.Rows.Item(i).Item(1).ToString
                                'Alta y Baja de Productos
                                frmProductos.pnlEdicion.Visible = True
                                frmProductos.pnlEdicion.Enabled = True
                                frmProductos.pnlOtros.Visible = True
                                frmProductos.pnlOtros.Enabled = True
                            Case (3)
                                'errores.Text = "Permiso activado: " & tablaPermisos.Rows.Item(i).Item(1).ToString
                                'Modificación de Descuento
                                frmProductos.btnDescuento.Enabled = True
                                frmProductos.btnDescuento.Visible = True
                            Case 4
                                'errores.Text = "Permiso activado: " & tablaPermisos.Rows.Item(i).Item(1).ToString
                                'Modificación de mesas
                                frmMesas.pnlEdicion.Enabled = True

                            Case 5
                                'errores.Text = "Permiso activado: " & tablaPermisos.Rows.Item(i).Item(1).ToString
                                'Modificación de costos
                                'Si puede modificar productos, no tiene chiste invalidar el poder alterar el costo.
                            Case 6
                                'errores.Text = "Permiso activado: " & tablaPermisos.Rows.Item(i).Item(1).ToString
                                'Alta y Baja de Clientes
                                frmClientes.pnlEdicion.Visible = True
                                frmClientes.pnlEdicion.Enabled = True
                                frmClientes.pnlOtros.Visible = True
                                frmClientes.pnlOtros.Enabled = True
                            Case 7
                                'errores.Text = "Permiso activado: " & tablaPermisos.Rows.Item(i).Item(1).ToString
                                'Modificación de fecha Descuento
                                'Si puede modificar descuentos, no tiene chiste invalidar el poder alterar la fecha del descuento.
                            Case 8
                                'errores.Text = "Permiso activado: " & tablaPermisos.Rows.Item(i).Item(1).ToString
                                'Alta y Baja de empleados
                                frmEmpleados.pnlEdicion.Visible = True
                                frmEmpleados.pnlEdicion.Enabled = True
                                frmEmpleados.pnlOtros.Visible = True
                                frmEmpleados.pnlOtros.Enabled = True
                            Case 9
                                'errores.Text = "Permiso activado: " & tablaPermisos.Rows.Item(i).Item(1).ToString
                                'Alta y Baja de privilegios

                            Case (10)
                                'Consultas
                                ReportesToolStripMenuItem.Enabled = True
                            Case (11)
                                'Asignación de usuarios
                                frmEmpleados.asignaUsuario.Enabled = True


                            Case Else
                                errores.Text = "idPrivilegio inválido: " + tablaPermisos.Rows.Item(i).Item(0).ToString
                                errorDurante = True
                        End Select
                    Next
                End With
            Else
                errores.Text = "Permisos vacíos."
            End If
            If Not errorDurante Then
                errores.Text = "."
            End If
        Else
            errores.Text = "Error en la obtención de los permisos del usuario."
        End If



    End Sub


    Private Sub CerrarSesiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesiónToolStripMenuItem.Click

        LoginScreen.Show()
        Me.Dispose()

    End Sub

 
End Class
