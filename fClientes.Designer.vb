<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fClientes))
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Colonia = New System.Windows.Forms.TextBox()
        Me.CP = New System.Windows.Forms.TextBox()
        Me.Direccion = New System.Windows.Forms.TextBox()
        Me.Nombre = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbCiudad = New System.Windows.Forms.ComboBox()
        Me.btnAgregarCiudad = New System.Windows.Forms.Button()
        Me.pnlOtros = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.pnlEdicion = New System.Windows.Forms.Panel()
        Me.errores = New System.Windows.Forms.Label()
        Me.cmbRFC = New System.Windows.Forms.ComboBox()
        Me.HelpProviderHG = New System.Windows.Forms.HelpProvider()
        Me.pnlOtros.SuspendLayout()
        Me.pnlEdicion.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.FormattingEnabled = True
        Me.HelpProviderHG.SetHelpKeyword(Me.cmbEstado, "fClientes.htm#Label7")
        Me.HelpProviderHG.SetHelpNavigator(Me.cmbEstado, System.Windows.Forms.HelpNavigator.Topic)
        Me.cmbEstado.Location = New System.Drawing.Point(135, 277)
        Me.cmbEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbEstado.Name = "cmbEstado"
        Me.HelpProviderHG.SetShowHelp(Me.cmbEstado, True)
        Me.cmbEstado.Size = New System.Drawing.Size(160, 24)
        Me.cmbEstado.TabIndex = 30
        '
        'Colonia
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.Colonia, "fClientes.htm#Label6")
        Me.HelpProviderHG.SetHelpNavigator(Me.Colonia, System.Windows.Forms.HelpNavigator.Topic)
        Me.Colonia.Location = New System.Drawing.Point(135, 185)
        Me.Colonia.Margin = New System.Windows.Forms.Padding(4)
        Me.Colonia.MaxLength = 60
        Me.Colonia.Name = "Colonia"
        Me.HelpProviderHG.SetShowHelp(Me.Colonia, True)
        Me.Colonia.Size = New System.Drawing.Size(380, 22)
        Me.Colonia.TabIndex = 28
        '
        'CP
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.CP, "fClientes.htm#Label5")
        Me.HelpProviderHG.SetHelpNavigator(Me.CP, System.Windows.Forms.HelpNavigator.Topic)
        Me.CP.Location = New System.Drawing.Point(135, 230)
        Me.CP.Margin = New System.Windows.Forms.Padding(4)
        Me.CP.MaxLength = 6
        Me.CP.Name = "CP"
        Me.HelpProviderHG.SetShowHelp(Me.CP, True)
        Me.CP.Size = New System.Drawing.Size(160, 22)
        Me.CP.TabIndex = 29
        '
        'Direccion
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.Direccion, "fClientes.htm#Label4")
        Me.HelpProviderHG.SetHelpNavigator(Me.Direccion, System.Windows.Forms.HelpNavigator.Topic)
        Me.Direccion.Location = New System.Drawing.Point(135, 138)
        Me.Direccion.Margin = New System.Windows.Forms.Padding(4)
        Me.Direccion.MaxLength = 60
        Me.Direccion.Name = "Direccion"
        Me.HelpProviderHG.SetShowHelp(Me.Direccion, True)
        Me.Direccion.Size = New System.Drawing.Size(380, 22)
        Me.Direccion.TabIndex = 27
        '
        'Nombre
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.Nombre, "fClientes.htm#Label3")
        Me.HelpProviderHG.SetHelpNavigator(Me.Nombre, System.Windows.Forms.HelpNavigator.Topic)
        Me.Nombre.Location = New System.Drawing.Point(135, 89)
        Me.Nombre.Margin = New System.Windows.Forms.Padding(4)
        Me.Nombre.MaxLength = 60
        Me.Nombre.Name = "Nombre"
        Me.HelpProviderHG.SetShowHelp(Me.Nombre, True)
        Me.Nombre.Size = New System.Drawing.Size(380, 22)
        Me.Nombre.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 281)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 17)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Estado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 187)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 17)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Colonia"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 234)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 17)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "C. P."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 142)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Dirección"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 91)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 38)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "RFC"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 331)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Ciudad"
        '
        'cmbCiudad
        '
        Me.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCiudad.FormattingEnabled = True
        Me.HelpProviderHG.SetHelpKeyword(Me.cmbCiudad, "fClientes.htm#Label1")
        Me.HelpProviderHG.SetHelpNavigator(Me.cmbCiudad, System.Windows.Forms.HelpNavigator.Topic)
        Me.cmbCiudad.Location = New System.Drawing.Point(135, 322)
        Me.cmbCiudad.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCiudad.Name = "cmbCiudad"
        Me.HelpProviderHG.SetShowHelp(Me.cmbCiudad, True)
        Me.cmbCiudad.Size = New System.Drawing.Size(160, 24)
        Me.cmbCiudad.TabIndex = 31
        '
        'btnAgregarCiudad
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnAgregarCiudad, "fClientes.htm#btnAgregarCiudad")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnAgregarCiudad, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnAgregarCiudad.Location = New System.Drawing.Point(4, 14)
        Me.btnAgregarCiudad.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregarCiudad.Name = "btnAgregarCiudad"
        Me.HelpProviderHG.SetShowHelp(Me.btnAgregarCiudad, True)
        Me.btnAgregarCiudad.Size = New System.Drawing.Size(135, 28)
        Me.btnAgregarCiudad.TabIndex = 38
        Me.btnAgregarCiudad.Text = "Agregar Ciudad"
        Me.btnAgregarCiudad.UseVisualStyleBackColor = True
        '
        'pnlOtros
        '
        Me.pnlOtros.Controls.Add(Me.btnAgregarCiudad)
        Me.pnlOtros.Enabled = False
        Me.pnlOtros.Location = New System.Drawing.Point(339, 230)
        Me.pnlOtros.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlOtros.Name = "pnlOtros"
        Me.pnlOtros.Size = New System.Drawing.Size(147, 54)
        Me.pnlOtros.TabIndex = 60
        Me.pnlOtros.Visible = False
        '
        'btnEliminar
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnEliminar, "fClientes.htm#btnEliminar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnEliminar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(4, 62)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.HelpProviderHG.SetShowHelp(Me.btnEliminar, True)
        Me.btnEliminar.Size = New System.Drawing.Size(56, 44)
        Me.btnEliminar.TabIndex = 36
        Me.ToolTip1.SetToolTip(Me.btnEliminar, "Eliminar")
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnAgregar, "fClientes.htm#btnAgregar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnAgregar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(4, 9)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.HelpProviderHG.SetShowHelp(Me.btnAgregar, True)
        Me.btnAgregar.Size = New System.Drawing.Size(56, 46)
        Me.btnAgregar.TabIndex = 35
        Me.ToolTip1.SetToolTip(Me.btnAgregar, "Agregar")
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnRegresar, "fClientes.htm#btnRegresar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnRegresar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnRegresar.Image = CType(resources.GetObject("btnRegresar.Image"), System.Drawing.Image)
        Me.btnRegresar.Location = New System.Drawing.Point(555, 113)
        Me.btnRegresar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRegresar.Name = "btnRegresar"
        Me.HelpProviderHG.SetShowHelp(Me.btnRegresar, True)
        Me.btnRegresar.Size = New System.Drawing.Size(56, 44)
        Me.btnRegresar.TabIndex = 33
        Me.ToolTip1.SetToolTip(Me.btnRegresar, "Regresar a la ventana anterior.")
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnClear, "fClientes.htm#btnClear")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnClear, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.Location = New System.Drawing.Point(555, 167)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.HelpProviderHG.SetShowHelp(Me.btnClear, True)
        Me.btnClear.Size = New System.Drawing.Size(56, 44)
        Me.btnClear.TabIndex = 34
        Me.ToolTip1.SetToolTip(Me.btnClear, "Borrar todos los textos introducidos en la ventana.")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnBuscar, "fClientes.htm#btnBuscar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnBuscar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(555, 64)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.HelpProviderHG.SetShowHelp(Me.btnBuscar, True)
        Me.btnBuscar.Size = New System.Drawing.Size(56, 42)
        Me.btnBuscar.TabIndex = 32
        Me.ToolTip1.SetToolTip(Me.btnBuscar, "Buscar")
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'pnlEdicion
        '
        Me.pnlEdicion.Controls.Add(Me.btnEliminar)
        Me.pnlEdicion.Controls.Add(Me.btnAgregar)
        Me.pnlEdicion.Enabled = False
        Me.pnlEdicion.Location = New System.Drawing.Point(555, 218)
        Me.pnlEdicion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlEdicion.Name = "pnlEdicion"
        Me.pnlEdicion.Size = New System.Drawing.Size(63, 113)
        Me.pnlEdicion.TabIndex = 71
        Me.pnlEdicion.Visible = False
        '
        'errores
        '
        Me.errores.AutoSize = True
        Me.errores.ForeColor = System.Drawing.Color.Brown
        Me.errores.Location = New System.Drawing.Point(35, 14)
        Me.errores.Name = "errores"
        Me.errores.Size = New System.Drawing.Size(12, 17)
        Me.errores.TabIndex = 76
        Me.errores.Text = "."
        '
        'cmbRFC
        '
        Me.cmbRFC.FormattingEnabled = True
        Me.HelpProviderHG.SetHelpKeyword(Me.cmbRFC, "fClientes.htm#Label2")
        Me.HelpProviderHG.SetHelpNavigator(Me.cmbRFC, System.Windows.Forms.HelpNavigator.Topic)
        Me.cmbRFC.Location = New System.Drawing.Point(135, 34)
        Me.cmbRFC.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbRFC.MaxLength = 13
        Me.cmbRFC.Name = "cmbRFC"
        Me.HelpProviderHG.SetShowHelp(Me.cmbRFC, True)
        Me.cmbRFC.Size = New System.Drawing.Size(160, 24)
        Me.cmbRFC.TabIndex = 78
        '
        'HelpProviderHG
        '
        Me.HelpProviderHG.HelpNamespace = "Proyecto_BD_Final.chm"
        '
        'fClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 386)
        Me.Controls.Add(Me.cmbRFC)
        Me.Controls.Add(Me.errores)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.pnlEdicion)
        Me.Controls.Add(Me.pnlOtros)
        Me.Controls.Add(Me.cmbCiudad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbEstado)
        Me.Controls.Add(Me.Colonia)
        Me.Controls.Add(Me.CP)
        Me.Controls.Add(Me.Direccion)
        Me.Controls.Add(Me.Nombre)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.HelpProviderHG.SetHelpKeyword(Me, "fClientes.htm")
        Me.HelpProviderHG.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.Topic)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fClientes"
        Me.HelpProviderHG.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Clientes"
        Me.pnlOtros.ResumeLayout(False)
        Me.pnlEdicion.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Colonia As System.Windows.Forms.TextBox
    Friend WithEvents CP As System.Windows.Forms.TextBox
    Friend WithEvents Direccion As System.Windows.Forms.TextBox
    Friend WithEvents Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbCiudad As System.Windows.Forms.ComboBox
    Friend WithEvents btnAgregarCiudad As System.Windows.Forms.Button
    Friend WithEvents pnlOtros As System.Windows.Forms.Panel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents pnlEdicion As System.Windows.Forms.Panel
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnRegresar As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents errores As System.Windows.Forms.Label
    Friend WithEvents cmbRFC As System.Windows.Forms.ComboBox
    Friend WithEvents HelpProviderHG As System.Windows.Forms.HelpProvider
End Class
