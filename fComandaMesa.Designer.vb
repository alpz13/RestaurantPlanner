<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fComandaMesa
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fComandaMesa))
        Me.btnFacturar = New System.Windows.Forms.Button()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.cmbEstados = New System.Windows.Forms.ComboBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.btnComenzar = New System.Windows.Forms.Button()
        Me.btnTerminar = New System.Windows.Forms.Button()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.HelpProviderHG = New System.Windows.Forms.HelpProvider()
        Me.tabClientes = New System.Windows.Forms.TabControl()
        Me.tabClients = New System.Windows.Forms.TabPage()
        Me.vsbCliente = New System.Windows.Forms.VScrollBar()
        Me.chkTodo = New System.Windows.Forms.CheckBox()
        Me.lblMensajes = New System.Windows.Forms.Label()
        Me.Seleccionado = New System.Windows.Forms.CheckBox()
        Me.cmbRFC = New System.Windows.Forms.ComboBox()
        Me.lblRfc = New System.Windows.Forms.Label()
        Me.lstComida = New System.Windows.Forms.ListBox()
        Me.tabClientes.SuspendLayout()
        Me.tabClients.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnFacturar
        '
        Me.btnFacturar.Enabled = False
        Me.HelpProviderHG.SetHelpKeyword(Me.btnFacturar, "fComandaMesa.htm#btnFacturar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnFacturar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnFacturar.Image = CType(resources.GetObject("btnFacturar.Image"), System.Drawing.Image)
        Me.btnFacturar.Location = New System.Drawing.Point(282, 301)
        Me.btnFacturar.Name = "btnFacturar"
        Me.HelpProviderHG.SetShowHelp(Me.btnFacturar, True)
        Me.btnFacturar.Size = New System.Drawing.Size(42, 42)
        Me.btnFacturar.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.btnFacturar, "Generar la cuenta")
        Me.btnFacturar.UseVisualStyleBackColor = True
        '
        'btnPagar
        '
        Me.btnPagar.Enabled = False
        Me.HelpProviderHG.SetHelpKeyword(Me.btnPagar, "fComandaMesa.htm#btnPagar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnPagar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnPagar.Image = CType(resources.GetObject("btnPagar.Image"), System.Drawing.Image)
        Me.btnPagar.Location = New System.Drawing.Point(282, 240)
        Me.btnPagar.Name = "btnPagar"
        Me.HelpProviderHG.SetShowHelp(Me.btnPagar, True)
        Me.btnPagar.Size = New System.Drawing.Size(42, 42)
        Me.btnPagar.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.btnPagar, "Pagar comanda de la mesa.")
        Me.btnPagar.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnRegresar, "fComandaMesa.htm#btnRegresar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnRegresar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnRegresar.Image = CType(resources.GetObject("btnRegresar.Image"), System.Drawing.Image)
        Me.btnRegresar.Location = New System.Drawing.Point(784, 272)
        Me.btnRegresar.Name = "btnRegresar"
        Me.HelpProviderHG.SetShowHelp(Me.btnRegresar, True)
        Me.btnRegresar.Size = New System.Drawing.Size(42, 36)
        Me.btnRegresar.TabIndex = 56
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Enabled = False
        Me.HelpProviderHG.SetHelpKeyword(Me.btnAgregar, "fComandaMesa.htm#btnAgregar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnAgregar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(282, 182)
        Me.btnAgregar.Name = "btnAgregar"
        Me.HelpProviderHG.SetShowHelp(Me.btnAgregar, True)
        Me.btnAgregar.Size = New System.Drawing.Size(42, 42)
        Me.btnAgregar.TabIndex = 57
        Me.ToolTip1.SetToolTip(Me.btnAgregar, "Agregar cliente")
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.HelpProviderHG.SetHelpKeyword(Me.btnEliminar, "fComandaMesa.htm#btnEliminar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnEliminar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(282, 370)
        Me.btnEliminar.Name = "btnEliminar"
        Me.HelpProviderHG.SetShowHelp(Me.btnEliminar, True)
        Me.btnEliminar.Size = New System.Drawing.Size(42, 42)
        Me.btnEliminar.TabIndex = 58
        Me.ToolTip1.SetToolTip(Me.btnEliminar, "Retirar clientes")
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'cmbEstados
        '
        Me.cmbEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstados.FormattingEnabled = True
        Me.HelpProviderHG.SetHelpKeyword(Me.cmbEstados, "fComandaMesa.htm#lblEstado")
        Me.HelpProviderHG.SetHelpNavigator(Me.cmbEstados, System.Windows.Forms.HelpNavigator.Topic)
        Me.cmbEstados.Location = New System.Drawing.Point(41, 42)
        Me.cmbEstados.Name = "cmbEstados"
        Me.HelpProviderHG.SetShowHelp(Me.cmbEstados, True)
        Me.cmbEstados.Size = New System.Drawing.Size(135, 21)
        Me.cmbEstados.TabIndex = 59
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.White
        Me.lblEstado.Location = New System.Drawing.Point(52, 16)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(51, 16)
        Me.lblEstado.TabIndex = 60
        Me.lblEstado.Text = "Estado"
        '
        'btnComenzar
        '
        Me.btnComenzar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProviderHG.SetHelpKeyword(Me.btnComenzar, "fComandaMesa.htm#btnComenzar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnComenzar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnComenzar.Location = New System.Drawing.Point(231, 12)
        Me.btnComenzar.Name = "btnComenzar"
        Me.HelpProviderHG.SetShowHelp(Me.btnComenzar, True)
        Me.btnComenzar.Size = New System.Drawing.Size(85, 25)
        Me.btnComenzar.TabIndex = 61
        Me.btnComenzar.Text = "Comenzar"
        Me.btnComenzar.UseVisualStyleBackColor = True
        '
        'btnTerminar
        '
        Me.btnTerminar.Enabled = False
        Me.btnTerminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTerminar.ForeColor = System.Drawing.Color.Black
        Me.HelpProviderHG.SetHelpKeyword(Me.btnTerminar, "fComandaMesa.htm#btnTerminar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnTerminar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnTerminar.Location = New System.Drawing.Point(231, 53)
        Me.btnTerminar.Name = "btnTerminar"
        Me.HelpProviderHG.SetShowHelp(Me.btnTerminar, True)
        Me.btnTerminar.Size = New System.Drawing.Size(85, 25)
        Me.btnTerminar.TabIndex = 62
        Me.btnTerminar.Text = "Terminar"
        Me.btnTerminar.UseVisualStyleBackColor = True
        '
        'btnHide
        '
        Me.btnHide.BackColor = System.Drawing.Color.Yellow
        Me.HelpProviderHG.SetHelpKeyword(Me.btnHide, "fComandaMesa.htm#Button1")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnHide, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnHide.Image = CType(resources.GetObject("btnHide.Image"), System.Drawing.Image)
        Me.btnHide.Location = New System.Drawing.Point(469, 27)
        Me.btnHide.Name = "btnHide"
        Me.HelpProviderHG.SetShowHelp(Me.btnHide, True)
        Me.btnHide.Size = New System.Drawing.Size(42, 36)
        Me.btnHide.TabIndex = 64
        Me.btnHide.UseVisualStyleBackColor = False
        '
        'HelpProviderHG
        '
        Me.HelpProviderHG.HelpNamespace = "Proyecto_BD_Final.chm"
        '
        'tabClientes
        '
        Me.tabClientes.Controls.Add(Me.tabClients)
        Me.tabClientes.Location = New System.Drawing.Point(26, 160)
        Me.tabClientes.Name = "tabClientes"
        Me.tabClientes.SelectedIndex = 0
        Me.tabClientes.Size = New System.Drawing.Size(229, 259)
        Me.tabClientes.TabIndex = 65
        '
        'tabClients
        '
        Me.tabClients.BackColor = System.Drawing.Color.Black
        Me.tabClients.Controls.Add(Me.vsbCliente)
        Me.tabClients.Location = New System.Drawing.Point(4, 22)
        Me.tabClients.Name = "tabClients"
        Me.tabClients.Padding = New System.Windows.Forms.Padding(3)
        Me.tabClients.Size = New System.Drawing.Size(221, 233)
        Me.tabClients.TabIndex = 0
        Me.tabClients.Text = "Clientes"
        '
        'vsbCliente
        '
        Me.vsbCliente.Dock = System.Windows.Forms.DockStyle.Right
        Me.vsbCliente.Enabled = False
        Me.vsbCliente.LargeChange = 1
        Me.vsbCliente.Location = New System.Drawing.Point(201, 3)
        Me.vsbCliente.Maximum = 0
        Me.vsbCliente.Name = "vsbCliente"
        Me.vsbCliente.Size = New System.Drawing.Size(17, 227)
        Me.vsbCliente.TabIndex = 0
        Me.vsbCliente.Visible = False
        '
        'chkTodo
        '
        Me.chkTodo.AutoSize = True
        Me.chkTodo.Enabled = False
        Me.chkTodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTodo.ForeColor = System.Drawing.Color.White
        Me.chkTodo.Location = New System.Drawing.Point(41, 123)
        Me.chkTodo.Name = "chkTodo"
        Me.chkTodo.Size = New System.Drawing.Size(128, 19)
        Me.chkTodo.TabIndex = 66
        Me.chkTodo.Text = "Seleccionar Todos"
        Me.chkTodo.UseVisualStyleBackColor = True
        '
        'lblMensajes
        '
        Me.lblMensajes.AutoSize = True
        Me.lblMensajes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensajes.ForeColor = System.Drawing.Color.White
        Me.lblMensajes.Location = New System.Drawing.Point(359, 151)
        Me.lblMensajes.Name = "lblMensajes"
        Me.lblMensajes.Size = New System.Drawing.Size(0, 16)
        Me.lblMensajes.TabIndex = 67
        '
        'Seleccionado
        '
        Me.Seleccionado.AutoSize = True
        Me.Seleccionado.Enabled = False
        Me.Seleccionado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Seleccionado.ForeColor = System.Drawing.Color.White
        Me.Seleccionado.Location = New System.Drawing.Point(41, 98)
        Me.Seleccionado.Name = "Seleccionado"
        Me.Seleccionado.Size = New System.Drawing.Size(150, 19)
        Me.Seleccionado.TabIndex = 68
        Me.Seleccionado.Text = "Habilitar Seleccionado"
        Me.Seleccionado.UseVisualStyleBackColor = True
        '
        'cmbRFC
        '
        Me.cmbRFC.DropDownHeight = 70
        Me.cmbRFC.Enabled = False
        Me.cmbRFC.FormattingEnabled = True
        Me.cmbRFC.IntegralHeight = False
        Me.cmbRFC.Location = New System.Drawing.Point(362, 99)
        Me.cmbRFC.Name = "cmbRFC"
        Me.cmbRFC.Size = New System.Drawing.Size(149, 21)
        Me.cmbRFC.TabIndex = 69
        '
        'lblRfc
        '
        Me.lblRfc.AutoSize = True
        Me.lblRfc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRfc.ForeColor = System.Drawing.Color.White
        Me.lblRfc.Location = New System.Drawing.Point(359, 76)
        Me.lblRfc.Name = "lblRfc"
        Me.lblRfc.Size = New System.Drawing.Size(35, 16)
        Me.lblRfc.TabIndex = 70
        Me.lblRfc.Text = "RFC"
        '
        'lstComida
        '
        Me.lstComida.BackColor = System.Drawing.Color.Black
        Me.lstComida.ForeColor = System.Drawing.Color.White
        Me.lstComida.FormattingEnabled = True
        Me.lstComida.Location = New System.Drawing.Point(352, 181)
        Me.lstComida.Name = "lstComida"
        Me.lstComida.Size = New System.Drawing.Size(194, 238)
        Me.lstComida.TabIndex = 71
        '
        'fComandaMesa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(561, 431)
        Me.ControlBox = False
        Me.Controls.Add(Me.lstComida)
        Me.Controls.Add(Me.lblRfc)
        Me.Controls.Add(Me.cmbRFC)
        Me.Controls.Add(Me.Seleccionado)
        Me.Controls.Add(Me.lblMensajes)
        Me.Controls.Add(Me.chkTodo)
        Me.Controls.Add(Me.tabClientes)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.btnTerminar)
        Me.Controls.Add(Me.btnComenzar)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.cmbEstados)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnFacturar)
        Me.Controls.Add(Me.btnPagar)
        Me.DoubleBuffered = True
        Me.HelpProviderHG.SetHelpKeyword(Me, "fComandaMesa.htm")
        Me.HelpProviderHG.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.Topic)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fComandaMesa"
        Me.HelpProviderHG.SetShowHelp(Me, True)
        Me.Text = "Comanda Mesa"
        Me.tabClientes.ResumeLayout(False)
        Me.tabClients.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFacturar As System.Windows.Forms.Button
    Friend WithEvents btnPagar As System.Windows.Forms.Button
    Friend WithEvents btnRegresar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents cmbEstados As System.Windows.Forms.ComboBox
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents btnComenzar As System.Windows.Forms.Button
    Friend WithEvents btnTerminar As System.Windows.Forms.Button
    Friend WithEvents btnHide As System.Windows.Forms.Button
    Friend WithEvents HelpProviderHG As System.Windows.Forms.HelpProvider
    Friend WithEvents tabClientes As System.Windows.Forms.TabControl
    Friend WithEvents tabClients As System.Windows.Forms.TabPage
    Friend WithEvents vsbCliente As System.Windows.Forms.VScrollBar
    Friend WithEvents chkTodo As System.Windows.Forms.CheckBox
    Friend WithEvents lblMensajes As System.Windows.Forms.Label
    Friend WithEvents Seleccionado As System.Windows.Forms.CheckBox
    Friend WithEvents cmbRFC As System.Windows.Forms.ComboBox
    Friend WithEvents lblRfc As System.Windows.Forms.Label
    Friend WithEvents lstComida As System.Windows.Forms.ListBox
End Class
