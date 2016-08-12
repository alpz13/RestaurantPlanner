<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fProductos))
        Me.Nombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Descripcion = New System.Windows.Forms.TextBox()
        Me.PrecioAnual = New System.Windows.Forms.TextBox()
        Me.btnDescuento = New System.Windows.Forms.Button()
        Me.btnTipoProductos = New System.Windows.Forms.Button()
        Me.pnlOtros = New System.Windows.Forms.Panel()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCambiar = New System.Windows.Forms.Button()
        Me.pnlEdicion = New System.Windows.Forms.Panel()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDeshacer = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.errores = New System.Windows.Forms.Label()
        Me.Foto = New System.Windows.Forms.PictureBox()
        Me.ofdOpen = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboTipoComida = New System.Windows.Forms.ComboBox()
        Me.HelpProviderHG = New System.Windows.Forms.HelpProvider()
        Me.pnlOtros.SuspendLayout()
        Me.pnlEdicion.SuspendLayout()
        CType(Me.Foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Nombre
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.Nombre, "fProductos.htm#Label3")
        Me.HelpProviderHG.SetHelpNavigator(Me.Nombre, System.Windows.Forms.HelpNavigator.Topic)
        Me.Nombre.Location = New System.Drawing.Point(149, 49)
        Me.Nombre.Margin = New System.Windows.Forms.Padding(4)
        Me.Nombre.MaxLength = 60
        Me.Nombre.Multiline = True
        Me.Nombre.Name = "Nombre"
        Me.HelpProviderHG.SetShowHelp(Me.Nombre, True)
        Me.Nombre.Size = New System.Drawing.Size(389, 43)
        Me.Nombre.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 49)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 110)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Descripción"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 223)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Precio Actual"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 305)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Foto"
        '
        'Descripcion
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.Descripcion, "fProductos.htm#Label4")
        Me.HelpProviderHG.SetHelpNavigator(Me.Descripcion, System.Windows.Forms.HelpNavigator.Topic)
        Me.Descripcion.Location = New System.Drawing.Point(149, 107)
        Me.Descripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.Descripcion.MaxLength = 400
        Me.Descripcion.Multiline = True
        Me.Descripcion.Name = "Descripcion"
        Me.HelpProviderHG.SetShowHelp(Me.Descripcion, True)
        Me.Descripcion.Size = New System.Drawing.Size(389, 102)
        Me.Descripcion.TabIndex = 7
        '
        'PrecioAnual
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.PrecioAnual, "fProductos.htm#Label5")
        Me.HelpProviderHG.SetHelpNavigator(Me.PrecioAnual, System.Windows.Forms.HelpNavigator.Topic)
        Me.PrecioAnual.Location = New System.Drawing.Point(149, 223)
        Me.PrecioAnual.Margin = New System.Windows.Forms.Padding(4)
        Me.PrecioAnual.MaxLength = 4
        Me.PrecioAnual.Name = "PrecioAnual"
        Me.HelpProviderHG.SetShowHelp(Me.PrecioAnual, True)
        Me.PrecioAnual.Size = New System.Drawing.Size(184, 22)
        Me.PrecioAnual.TabIndex = 8
        '
        'btnDescuento
        '
        Me.btnDescuento.Enabled = False
        Me.HelpProviderHG.SetHelpKeyword(Me.btnDescuento, "fProductos.htm#btnDescuento")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnDescuento, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnDescuento.Location = New System.Drawing.Point(27, 26)
        Me.btnDescuento.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDescuento.Name = "btnDescuento"
        Me.HelpProviderHG.SetShowHelp(Me.btnDescuento, True)
        Me.btnDescuento.Size = New System.Drawing.Size(144, 28)
        Me.btnDescuento.TabIndex = 46
        Me.btnDescuento.Text = "Descuento"
        Me.btnDescuento.UseVisualStyleBackColor = True
        Me.btnDescuento.Visible = False
        '
        'btnTipoProductos
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnTipoProductos, "fProductos.htm#btnTipoProductos")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnTipoProductos, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnTipoProductos.Location = New System.Drawing.Point(27, 62)
        Me.btnTipoProductos.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTipoProductos.Name = "btnTipoProductos"
        Me.HelpProviderHG.SetShowHelp(Me.btnTipoProductos, True)
        Me.btnTipoProductos.Size = New System.Drawing.Size(144, 28)
        Me.btnTipoProductos.TabIndex = 47
        Me.btnTipoProductos.Text = "Tipos de Productos"
        Me.btnTipoProductos.UseVisualStyleBackColor = True
        '
        'pnlOtros
        '
        Me.pnlOtros.Controls.Add(Me.btnModificar)
        Me.pnlOtros.Controls.Add(Me.btnDescuento)
        Me.pnlOtros.Controls.Add(Me.btnCambiar)
        Me.pnlOtros.Controls.Add(Me.btnTipoProductos)
        Me.pnlOtros.Enabled = False
        Me.pnlOtros.Location = New System.Drawing.Point(341, 223)
        Me.pnlOtros.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlOtros.Name = "pnlOtros"
        Me.pnlOtros.Size = New System.Drawing.Size(197, 178)
        Me.pnlOtros.TabIndex = 51
        Me.pnlOtros.Visible = False
        '
        'btnModificar
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnModificar, "fProductos.htm#btnModificar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnModificar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnModificar.Location = New System.Drawing.Point(27, 138)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModificar.Name = "btnModificar"
        Me.HelpProviderHG.SetShowHelp(Me.btnModificar, True)
        Me.btnModificar.Size = New System.Drawing.Size(144, 28)
        Me.btnModificar.TabIndex = 83
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnCambiar
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnCambiar, "fProductos.htm#btnCambiar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnCambiar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnCambiar.Location = New System.Drawing.Point(27, 102)
        Me.btnCambiar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCambiar.Name = "btnCambiar"
        Me.HelpProviderHG.SetShowHelp(Me.btnCambiar, True)
        Me.btnCambiar.Size = New System.Drawing.Size(144, 28)
        Me.btnCambiar.TabIndex = 82
        Me.btnCambiar.Text = "Buscar Imagen"
        Me.btnCambiar.UseVisualStyleBackColor = True
        '
        'pnlEdicion
        '
        Me.pnlEdicion.Controls.Add(Me.btnEliminar)
        Me.pnlEdicion.Controls.Add(Me.btnAgregar)
        Me.pnlEdicion.Enabled = False
        Me.pnlEdicion.Location = New System.Drawing.Point(555, 251)
        Me.pnlEdicion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlEdicion.Name = "pnlEdicion"
        Me.pnlEdicion.Size = New System.Drawing.Size(64, 102)
        Me.pnlEdicion.TabIndex = 52
        Me.pnlEdicion.Visible = False
        '
        'btnEliminar
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnEliminar, "fProductos.htm#btnEliminar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnEliminar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(4, 54)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.HelpProviderHG.SetShowHelp(Me.btnEliminar, True)
        Me.btnEliminar.Size = New System.Drawing.Size(56, 43)
        Me.btnEliminar.TabIndex = 52
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnAgregar, "fProductos.htm#btnAgregar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnAgregar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(4, 4)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.HelpProviderHG.SetShowHelp(Me.btnAgregar, True)
        Me.btnAgregar.Size = New System.Drawing.Size(56, 42)
        Me.btnAgregar.TabIndex = 51
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnClear, "fProductos.htm#btnClear")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnClear, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.Location = New System.Drawing.Point(559, 203)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.HelpProviderHG.SetShowHelp(Me.btnClear, True)
        Me.btnClear.Size = New System.Drawing.Size(56, 44)
        Me.btnClear.TabIndex = 79
        Me.ToolTip1.SetToolTip(Me.btnClear, "Borrar todos los textos introducidos en la ventana.")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDeshacer
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnDeshacer, "fProductos.htm#btnDeshacer")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnDeshacer, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnDeshacer.Image = CType(resources.GetObject("btnDeshacer.Image"), System.Drawing.Image)
        Me.btnDeshacer.Location = New System.Drawing.Point(559, 153)
        Me.btnDeshacer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeshacer.Name = "btnDeshacer"
        Me.HelpProviderHG.SetShowHelp(Me.btnDeshacer, True)
        Me.btnDeshacer.Size = New System.Drawing.Size(56, 44)
        Me.btnDeshacer.TabIndex = 78
        Me.ToolTip1.SetToolTip(Me.btnDeshacer, "Deshacer cambios.")
        Me.btnDeshacer.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnBuscar, "fProductos.htm#btnBuscar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnBuscar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(559, 50)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.HelpProviderHG.SetShowHelp(Me.btnBuscar, True)
        Me.btnBuscar.Size = New System.Drawing.Size(56, 42)
        Me.btnBuscar.TabIndex = 77
        Me.ToolTip1.SetToolTip(Me.btnBuscar, "Buscar")
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnRegresar, "fProductos.htm#btnRegresar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnRegresar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnRegresar.Image = CType(resources.GetObject("btnRegresar.Image"), System.Drawing.Image)
        Me.btnRegresar.Location = New System.Drawing.Point(559, 100)
        Me.btnRegresar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRegresar.Name = "btnRegresar"
        Me.HelpProviderHG.SetShowHelp(Me.btnRegresar, True)
        Me.btnRegresar.Size = New System.Drawing.Size(56, 44)
        Me.btnRegresar.TabIndex = 76
        Me.ToolTip1.SetToolTip(Me.btnRegresar, "Regresar a la ventana anterior.")
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'errores
        '
        Me.errores.AutoSize = True
        Me.errores.ForeColor = System.Drawing.Color.Brown
        Me.errores.Location = New System.Drawing.Point(28, 14)
        Me.errores.Name = "errores"
        Me.errores.Size = New System.Drawing.Size(12, 17)
        Me.errores.TabIndex = 80
        Me.errores.Text = "."
        '
        'Foto
        '
        Me.Foto.Location = New System.Drawing.Point(149, 305)
        Me.Foto.Margin = New System.Windows.Forms.Padding(4)
        Me.Foto.Name = "Foto"
        Me.Foto.Size = New System.Drawing.Size(185, 140)
        Me.Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Foto.TabIndex = 81
        Me.Foto.TabStop = False
        '
        'ofdOpen
        '
        Me.ofdOpen.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 268)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Tipo de Comida"
        '
        'cboTipoComida
        '
        Me.cboTipoComida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoComida.FormattingEnabled = True
        Me.HelpProviderHG.SetHelpKeyword(Me.cboTipoComida, "fProductos.htm#Label1")
        Me.HelpProviderHG.SetHelpNavigator(Me.cboTipoComida, System.Windows.Forms.HelpNavigator.Topic)
        Me.cboTipoComida.Location = New System.Drawing.Point(149, 257)
        Me.cboTipoComida.Margin = New System.Windows.Forms.Padding(4)
        Me.cboTipoComida.Name = "cboTipoComida"
        Me.HelpProviderHG.SetShowHelp(Me.cboTipoComida, True)
        Me.cboTipoComida.Size = New System.Drawing.Size(184, 24)
        Me.cboTipoComida.TabIndex = 83
        '
        'HelpProviderHG
        '
        Me.HelpProviderHG.HelpNamespace = "Proyecto_BD_Final.chm"
        '
        'fProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 463)
        Me.Controls.Add(Me.cboTipoComida)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Foto)
        Me.Controls.Add(Me.errores)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDeshacer)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.pnlEdicion)
        Me.Controls.Add(Me.pnlOtros)
        Me.Controls.Add(Me.PrecioAnual)
        Me.Controls.Add(Me.Descripcion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Nombre)
        Me.HelpProviderHG.SetHelpKeyword(Me, "fProductos.htm")
        Me.HelpProviderHG.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.Topic)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fProductos"
        Me.HelpProviderHG.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Productos"
        Me.pnlOtros.ResumeLayout(False)
        Me.pnlEdicion.ResumeLayout(False)
        CType(Me.Foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Descripcion As System.Windows.Forms.TextBox
    Friend WithEvents PrecioAnual As System.Windows.Forms.TextBox
    Friend WithEvents btnDescuento As System.Windows.Forms.Button
    Friend WithEvents btnTipoProductos As System.Windows.Forms.Button
    Friend WithEvents pnlOtros As System.Windows.Forms.Panel
    Friend WithEvents pnlEdicion As System.Windows.Forms.Panel
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnDeshacer As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnRegresar As System.Windows.Forms.Button
    Friend WithEvents errores As System.Windows.Forms.Label
    Friend WithEvents Foto As System.Windows.Forms.PictureBox
    Friend WithEvents ofdOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnCambiar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboTipoComida As System.Windows.Forms.ComboBox
    Friend WithEvents HelpProviderHG As System.Windows.Forms.HelpProvider
End Class
