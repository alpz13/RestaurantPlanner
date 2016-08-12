<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fEmpleados
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fEmpleados))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Nombre = New System.Windows.Forms.TextBox()
        Me.Direccion = New System.Windows.Forms.TextBox()
        Me.Telefono = New System.Windows.Forms.TextBox()
        Me.Correo = New System.Windows.Forms.TextBox()
        Me.cmbPuesto = New System.Windows.Forms.ComboBox()
        Me.btnRoles = New System.Windows.Forms.Button()
        Me.pnlOtros = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnAgregaUs = New System.Windows.Forms.Button()
        Me.pnlEdicion = New System.Windows.Forms.Panel()
        Me.errores = New System.Windows.Forms.Label()
        Me.asignaUsuario = New System.Windows.Forms.Panel()
        Me.txtRecordatorio = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.cmbRol = New System.Windows.Forms.ComboBox()
        Me.Nomina = New System.Windows.Forms.ComboBox()
        Me.HelpProviderHG = New System.Windows.Forms.HelpProvider()
        Me.pnlOtros.SuspendLayout()
        Me.pnlEdicion.SuspendLayout()
        Me.asignaUsuario.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 54)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nomina"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 110)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 150)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Dirección"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 295)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Teléfono"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(56, 249)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Correo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(56, 345)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Puesto"
        '
        'Nombre
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.Nombre, "fEmpleados.htm#Label3")
        Me.HelpProviderHG.SetHelpNavigator(Me.Nombre, System.Windows.Forms.HelpNavigator.Topic)
        Me.Nombre.Location = New System.Drawing.Point(159, 105)
        Me.Nombre.Margin = New System.Windows.Forms.Padding(4)
        Me.Nombre.MaxLength = 60
        Me.Nombre.Name = "Nombre"
        Me.HelpProviderHG.SetShowHelp(Me.Nombre, True)
        Me.Nombre.Size = New System.Drawing.Size(380, 22)
        Me.Nombre.TabIndex = 2
        '
        'Direccion
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.Direccion, "fEmpleados.htm#Label4")
        Me.HelpProviderHG.SetHelpNavigator(Me.Direccion, System.Windows.Forms.HelpNavigator.Topic)
        Me.Direccion.Location = New System.Drawing.Point(159, 146)
        Me.Direccion.Margin = New System.Windows.Forms.Padding(4)
        Me.Direccion.MaxLength = 100
        Me.Direccion.Multiline = True
        Me.Direccion.Name = "Direccion"
        Me.HelpProviderHG.SetShowHelp(Me.Direccion, True)
        Me.Direccion.Size = New System.Drawing.Size(380, 79)
        Me.Direccion.TabIndex = 3
        '
        'Telefono
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.Telefono, "fEmpleados.htm#Label5")
        Me.HelpProviderHG.SetHelpNavigator(Me.Telefono, System.Windows.Forms.HelpNavigator.Topic)
        Me.Telefono.Location = New System.Drawing.Point(159, 293)
        Me.Telefono.Margin = New System.Windows.Forms.Padding(4)
        Me.Telefono.MaxLength = 15
        Me.Telefono.Name = "Telefono"
        Me.HelpProviderHG.SetShowHelp(Me.Telefono, True)
        Me.Telefono.Size = New System.Drawing.Size(160, 22)
        Me.Telefono.TabIndex = 5
        '
        'Correo
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.Correo, "fEmpleados.htm#Label6")
        Me.HelpProviderHG.SetHelpNavigator(Me.Correo, System.Windows.Forms.HelpNavigator.Topic)
        Me.Correo.Location = New System.Drawing.Point(159, 244)
        Me.Correo.Margin = New System.Windows.Forms.Padding(4)
        Me.Correo.MaxLength = 40
        Me.Correo.Name = "Correo"
        Me.HelpProviderHG.SetShowHelp(Me.Correo, True)
        Me.Correo.Size = New System.Drawing.Size(380, 22)
        Me.Correo.TabIndex = 4
        '
        'cmbPuesto
        '
        Me.cmbPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPuesto.FormattingEnabled = True
        Me.HelpProviderHG.SetHelpKeyword(Me.cmbPuesto, "fEmpleados.htm#Label7")
        Me.HelpProviderHG.SetHelpNavigator(Me.cmbPuesto, System.Windows.Forms.HelpNavigator.Topic)
        Me.cmbPuesto.Location = New System.Drawing.Point(159, 341)
        Me.cmbPuesto.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbPuesto.Name = "cmbPuesto"
        Me.HelpProviderHG.SetShowHelp(Me.cmbPuesto, True)
        Me.cmbPuesto.Size = New System.Drawing.Size(160, 24)
        Me.cmbPuesto.TabIndex = 6
        '
        'btnRoles
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnRoles, "fEmpleados.htm#btnRoles")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnRoles, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnRoles.Location = New System.Drawing.Point(4, 7)
        Me.btnRoles.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRoles.Name = "btnRoles"
        Me.HelpProviderHG.SetShowHelp(Me.btnRoles, True)
        Me.btnRoles.Size = New System.Drawing.Size(100, 28)
        Me.btnRoles.TabIndex = 12
        Me.btnRoles.Text = "Roles"
        Me.btnRoles.UseVisualStyleBackColor = True
        '
        'pnlOtros
        '
        Me.pnlOtros.Controls.Add(Me.btnRoles)
        Me.pnlOtros.Enabled = False
        Me.pnlOtros.Location = New System.Drawing.Point(360, 271)
        Me.pnlOtros.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlOtros.Name = "pnlOtros"
        Me.pnlOtros.Size = New System.Drawing.Size(113, 41)
        Me.pnlOtros.TabIndex = 60
        Me.pnlOtros.Visible = False
        '
        'btnClear
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnClear, "fEmpleados.htm#btnClear")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnClear, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.Location = New System.Drawing.Point(580, 118)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.HelpProviderHG.SetShowHelp(Me.btnClear, True)
        Me.btnClear.Size = New System.Drawing.Size(56, 44)
        Me.btnClear.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.btnClear, "Borrar todos los textos introducidos en la ventana.")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnBuscar, "fEmpleados.htm#btnBuscar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnBuscar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(580, 15)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.HelpProviderHG.SetShowHelp(Me.btnBuscar, True)
        Me.btnBuscar.Size = New System.Drawing.Size(56, 42)
        Me.btnBuscar.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.btnBuscar, "Buscar")
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnRegresar, "fEmpleados.htm#btnRegresar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnRegresar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnRegresar.Image = CType(resources.GetObject("btnRegresar.Image"), System.Drawing.Image)
        Me.btnRegresar.Location = New System.Drawing.Point(580, 65)
        Me.btnRegresar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRegresar.Name = "btnRegresar"
        Me.HelpProviderHG.SetShowHelp(Me.btnRegresar, True)
        Me.btnRegresar.Size = New System.Drawing.Size(56, 44)
        Me.btnRegresar.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.btnRegresar, "Regresar a la ventana anterior.")
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnEliminar, "fEmpleados.htm#btnEliminar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnEliminar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(4, 62)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.HelpProviderHG.SetShowHelp(Me.btnEliminar, True)
        Me.btnEliminar.Size = New System.Drawing.Size(56, 44)
        Me.btnEliminar.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.btnEliminar, "Eliminar")
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnAgregar, "fEmpleados.htm#btnAgregar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnAgregar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(4, 9)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.HelpProviderHG.SetShowHelp(Me.btnAgregar, True)
        Me.btnAgregar.Size = New System.Drawing.Size(56, 46)
        Me.btnAgregar.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.btnAgregar, "Agregar")
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnAgregaUs
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnAgregaUs, "fEmpleados.htm#btnAgregaUs")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnAgregaUs, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnAgregaUs.Image = CType(resources.GetObject("btnAgregaUs.Image"), System.Drawing.Image)
        Me.btnAgregaUs.Location = New System.Drawing.Point(291, 128)
        Me.btnAgregaUs.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregaUs.Name = "btnAgregaUs"
        Me.HelpProviderHG.SetShowHelp(Me.btnAgregaUs, True)
        Me.btnAgregaUs.Size = New System.Drawing.Size(56, 46)
        Me.btnAgregaUs.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.btnAgregaUs, "Agregar")
        Me.btnAgregaUs.UseVisualStyleBackColor = True
        '
        'pnlEdicion
        '
        Me.pnlEdicion.Controls.Add(Me.btnEliminar)
        Me.pnlEdicion.Controls.Add(Me.btnAgregar)
        Me.pnlEdicion.Enabled = False
        Me.pnlEdicion.Location = New System.Drawing.Point(580, 169)
        Me.pnlEdicion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlEdicion.Name = "pnlEdicion"
        Me.pnlEdicion.Size = New System.Drawing.Size(63, 116)
        Me.pnlEdicion.TabIndex = 81
        Me.pnlEdicion.Visible = False
        '
        'errores
        '
        Me.errores.AutoSize = True
        Me.errores.ForeColor = System.Drawing.Color.Brown
        Me.errores.Location = New System.Drawing.Point(59, 14)
        Me.errores.Name = "errores"
        Me.errores.Size = New System.Drawing.Size(12, 17)
        Me.errores.TabIndex = 86
        Me.errores.Text = "."
        '
        'asignaUsuario
        '
        Me.asignaUsuario.Controls.Add(Me.btnAgregaUs)
        Me.asignaUsuario.Controls.Add(Me.txtRecordatorio)
        Me.asignaUsuario.Controls.Add(Me.Label10)
        Me.asignaUsuario.Controls.Add(Me.Label9)
        Me.asignaUsuario.Controls.Add(Me.Label8)
        Me.asignaUsuario.Controls.Add(Me.Label1)
        Me.asignaUsuario.Controls.Add(Me.txtContrasena)
        Me.asignaUsuario.Controls.Add(Me.txtUsuario)
        Me.asignaUsuario.Controls.Add(Me.cmbRol)
        Me.asignaUsuario.Enabled = False
        Me.asignaUsuario.Location = New System.Drawing.Point(345, 318)
        Me.asignaUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.asignaUsuario.Name = "asignaUsuario"
        Me.asignaUsuario.Size = New System.Drawing.Size(373, 190)
        Me.asignaUsuario.TabIndex = 87
        '
        'txtRecordatorio
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.txtRecordatorio, "fEmpleados.htm#Label10")
        Me.HelpProviderHG.SetHelpNavigator(Me.txtRecordatorio, System.Windows.Forms.HelpNavigator.Topic)
        Me.txtRecordatorio.Location = New System.Drawing.Point(121, 110)
        Me.txtRecordatorio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRecordatorio.MaxLength = 100
        Me.txtRecordatorio.Name = "txtRecordatorio"
        Me.HelpProviderHG.SetShowHelp(Me.txtRecordatorio, True)
        Me.txtRecordatorio.Size = New System.Drawing.Size(160, 22)
        Me.txtRecordatorio.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 113)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 17)
        Me.Label10.TabIndex = 92
        Me.Label10.Text = "Recordatorio"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 151)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 17)
        Me.Label9.TabIndex = 91
        Me.Label9.Text = "RolAsignado"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 69)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 17)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Usuario"
        '
        'txtContrasena
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.txtContrasena, "fEmpleados.htm#Label8")
        Me.HelpProviderHG.SetHelpNavigator(Me.txtContrasena, System.Windows.Forms.HelpNavigator.Topic)
        Me.txtContrasena.Location = New System.Drawing.Point(121, 65)
        Me.txtContrasena.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContrasena.MaxLength = 10
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.HelpProviderHG.SetShowHelp(Me.txtContrasena, True)
        Me.txtContrasena.Size = New System.Drawing.Size(160, 22)
        Me.txtContrasena.TabIndex = 14
        '
        'txtUsuario
        '
        Me.txtUsuario.Enabled = False
        Me.HelpProviderHG.SetHelpKeyword(Me.txtUsuario, "fEmpleados.htm#Label1")
        Me.HelpProviderHG.SetHelpNavigator(Me.txtUsuario, System.Windows.Forms.HelpNavigator.Topic)
        Me.txtUsuario.Location = New System.Drawing.Point(121, 20)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsuario.Name = "txtUsuario"
        Me.HelpProviderHG.SetShowHelp(Me.txtUsuario, True)
        Me.txtUsuario.Size = New System.Drawing.Size(160, 22)
        Me.txtUsuario.TabIndex = 13
        '
        'cmbRol
        '
        Me.cmbRol.Enabled = False
        Me.cmbRol.FormattingEnabled = True
        Me.HelpProviderHG.SetHelpKeyword(Me.cmbRol, "fEmpleados.htm#Label9")
        Me.HelpProviderHG.SetHelpNavigator(Me.cmbRol, System.Windows.Forms.HelpNavigator.Topic)
        Me.cmbRol.Location = New System.Drawing.Point(121, 148)
        Me.cmbRol.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbRol.Name = "cmbRol"
        Me.HelpProviderHG.SetShowHelp(Me.cmbRol, True)
        Me.cmbRol.Size = New System.Drawing.Size(160, 24)
        Me.cmbRol.TabIndex = 16
        '
        'Nomina
        '
        Me.Nomina.FormattingEnabled = True
        Me.HelpProviderHG.SetHelpKeyword(Me.Nomina, "fEmpleados.htm#Label2")
        Me.HelpProviderHG.SetHelpNavigator(Me.Nomina, System.Windows.Forms.HelpNavigator.Topic)
        Me.Nomina.Location = New System.Drawing.Point(159, 50)
        Me.Nomina.Margin = New System.Windows.Forms.Padding(4)
        Me.Nomina.MaxLength = 8
        Me.Nomina.Name = "Nomina"
        Me.HelpProviderHG.SetShowHelp(Me.Nomina, True)
        Me.Nomina.Size = New System.Drawing.Size(160, 24)
        Me.Nomina.TabIndex = 89
        '
        'HelpProviderHG
        '
        Me.HelpProviderHG.HelpNamespace = "Proyecto_BD_Final.chm"
        '
        'fEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 550)
        Me.Controls.Add(Me.Nomina)
        Me.Controls.Add(Me.asignaUsuario)
        Me.Controls.Add(Me.errores)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.pnlEdicion)
        Me.Controls.Add(Me.pnlOtros)
        Me.Controls.Add(Me.cmbPuesto)
        Me.Controls.Add(Me.Correo)
        Me.Controls.Add(Me.Telefono)
        Me.Controls.Add(Me.Direccion)
        Me.Controls.Add(Me.Nombre)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.HelpProviderHG.SetHelpKeyword(Me, "fEmpleados.htm")
        Me.HelpProviderHG.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.Topic)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fEmpleados"
        Me.HelpProviderHG.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Empleados"
        Me.pnlOtros.ResumeLayout(False)
        Me.pnlEdicion.ResumeLayout(False)
        Me.asignaUsuario.ResumeLayout(False)
        Me.asignaUsuario.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Direccion As System.Windows.Forms.TextBox
    Friend WithEvents Telefono As System.Windows.Forms.TextBox
    Friend WithEvents Correo As System.Windows.Forms.TextBox
    Friend WithEvents cmbPuesto As System.Windows.Forms.ComboBox
    Friend WithEvents btnRoles As System.Windows.Forms.Button
    Friend WithEvents pnlOtros As System.Windows.Forms.Panel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnRegresar As System.Windows.Forms.Button
    Friend WithEvents pnlEdicion As System.Windows.Forms.Panel
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents errores As System.Windows.Forms.Label
    Friend WithEvents asignaUsuario As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtContrasena As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents cmbRol As System.Windows.Forms.ComboBox
    Friend WithEvents btnAgregaUs As System.Windows.Forms.Button
    Friend WithEvents txtRecordatorio As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Nomina As System.Windows.Forms.ComboBox
    Friend WithEvents HelpProviderHG As System.Windows.Forms.HelpProvider
End Class
