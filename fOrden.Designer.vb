<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fOrden
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fOrden))
        Me.tabOrden = New System.Windows.Forms.TabControl()
        Me.lblProductos = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabCliente = New System.Windows.Forms.TabPage()
        Me.vsbCliente = New System.Windows.Forms.VScrollBar()
        Me.btnMenos = New System.Windows.Forms.Button()
        Me.btnRetirar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMas = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.lblMensajes = New System.Windows.Forms.Label()
        Me.HelpProviderHG = New System.Windows.Forms.HelpProvider()
        Me.TabControl1.SuspendLayout()
        Me.tabCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabOrden
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.tabOrden, "fOrden.htm#tabOrden")
        Me.HelpProviderHG.SetHelpNavigator(Me.tabOrden, System.Windows.Forms.HelpNavigator.Topic)
        Me.tabOrden.Location = New System.Drawing.Point(15, 278)
        Me.tabOrden.Name = "tabOrden"
        Me.tabOrden.SelectedIndex = 0
        Me.HelpProviderHG.SetShowHelp(Me.tabOrden, True)
        Me.tabOrden.Size = New System.Drawing.Size(383, 207)
        Me.tabOrden.TabIndex = 0
        '
        'lblProductos
        '
        Me.lblProductos.AutoSize = True
        Me.lblProductos.Location = New System.Drawing.Point(12, 251)
        Me.lblProductos.Name = "lblProductos"
        Me.lblProductos.Size = New System.Drawing.Size(55, 13)
        Me.lblProductos.TabIndex = 1
        Me.lblProductos.Text = "Productos"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabCliente)
        Me.HelpProviderHG.SetHelpKeyword(Me.TabControl1, "fOrden.htm#TabControl1")
        Me.HelpProviderHG.SetHelpNavigator(Me.TabControl1, System.Windows.Forms.HelpNavigator.Topic)
        Me.TabControl1.Location = New System.Drawing.Point(15, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.HelpProviderHG.SetShowHelp(Me.TabControl1, True)
        Me.TabControl1.Size = New System.Drawing.Size(383, 219)
        Me.TabControl1.TabIndex = 2
        '
        'tabCliente
        '
        Me.tabCliente.Controls.Add(Me.vsbCliente)
        Me.HelpProviderHG.SetHelpKeyword(Me.tabCliente, "fOrden.htm#tabCliente_0")
        Me.HelpProviderHG.SetHelpNavigator(Me.tabCliente, System.Windows.Forms.HelpNavigator.Topic)
        Me.tabCliente.Location = New System.Drawing.Point(4, 22)
        Me.tabCliente.Name = "tabCliente"
        Me.tabCliente.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.HelpProviderHG.SetShowHelp(Me.tabCliente, True)
        Me.tabCliente.Size = New System.Drawing.Size(375, 193)
        Me.tabCliente.TabIndex = 0
        Me.tabCliente.Text = "Cliente"
        Me.tabCliente.UseVisualStyleBackColor = True
        '
        'vsbCliente
        '
        Me.vsbCliente.Dock = System.Windows.Forms.DockStyle.Right
        Me.vsbCliente.LargeChange = 1
        Me.vsbCliente.Location = New System.Drawing.Point(355, 3)
        Me.vsbCliente.Maximum = 0
        Me.vsbCliente.Name = "vsbCliente"
        Me.vsbCliente.Size = New System.Drawing.Size(17, 187)
        Me.vsbCliente.TabIndex = 0
        Me.vsbCliente.Visible = False
        '
        'btnMenos
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnMenos, "fOrden.htm#btnMenos")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnMenos, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnMenos.Location = New System.Drawing.Point(424, 128)
        Me.btnMenos.Name = "btnMenos"
        Me.HelpProviderHG.SetShowHelp(Me.btnMenos, True)
        Me.btnMenos.Size = New System.Drawing.Size(40, 40)
        Me.btnMenos.TabIndex = 3
        Me.btnMenos.UseVisualStyleBackColor = True
        '
        'btnRetirar
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnRetirar, "fOrden.htm#btnRetirar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnRetirar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnRetirar.Location = New System.Drawing.Point(424, 186)
        Me.btnRetirar.Name = "btnRetirar"
        Me.HelpProviderHG.SetShowHelp(Me.btnRetirar, True)
        Me.btnRetirar.Size = New System.Drawing.Size(88, 23)
        Me.btnRetirar.TabIndex = 4
        Me.btnRetirar.Text = "Retirar"
        Me.btnRetirar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(421, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Disminuir/Aumentar"
        '
        'btnMas
        '
        Me.btnMas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.HelpProviderHG.SetHelpKeyword(Me.btnMas, "fOrden.htm#btnMas")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnMas, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnMas.Location = New System.Drawing.Point(472, 128)
        Me.btnMas.Name = "btnMas"
        Me.HelpProviderHG.SetShowHelp(Me.btnMas, True)
        Me.btnMas.Size = New System.Drawing.Size(40, 40)
        Me.btnMas.TabIndex = 5
        Me.btnMas.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnRegresar, "fOrden.htm#btnRegresar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnRegresar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnRegresar.Image = CType(resources.GetObject("btnRegresar.Image"), System.Drawing.Image)
        Me.btnRegresar.Location = New System.Drawing.Point(444, 339)
        Me.btnRegresar.Name = "btnRegresar"
        Me.HelpProviderHG.SetShowHelp(Me.btnRegresar, True)
        Me.btnRegresar.Size = New System.Drawing.Size(42, 36)
        Me.btnRegresar.TabIndex = 57
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'lblMensajes
        '
        Me.lblMensajes.AutoSize = True
        Me.lblMensajes.Location = New System.Drawing.Point(82, 9)
        Me.lblMensajes.Name = "lblMensajes"
        Me.lblMensajes.Size = New System.Drawing.Size(0, 13)
        Me.lblMensajes.TabIndex = 1
        '
        'HelpProviderHG
        '
        Me.HelpProviderHG.HelpNamespace = "Proyecto_BD_Final.chm"
        '
        'fOrden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ClientSize = New System.Drawing.Size(523, 497)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblMensajes)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMas)
        Me.Controls.Add(Me.btnRetirar)
        Me.Controls.Add(Me.btnMenos)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lblProductos)
        Me.Controls.Add(Me.tabOrden)
        Me.DoubleBuffered = True
        Me.HelpProviderHG.SetHelpKeyword(Me, "fOrden.htm")
        Me.HelpProviderHG.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.Topic)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fOrden"
        Me.HelpProviderHG.SetShowHelp(Me, True)
        Me.Text = "Productos"
        Me.TabControl1.ResumeLayout(False)
        Me.tabCliente.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabOrden As System.Windows.Forms.TabControl
    Friend WithEvents lblProductos As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabCliente As System.Windows.Forms.TabPage
    Friend WithEvents btnMenos As System.Windows.Forms.Button
    Friend WithEvents btnRetirar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents vsbCliente As System.Windows.Forms.VScrollBar
    Friend WithEvents btnMas As System.Windows.Forms.Button
    Friend WithEvents btnRegresar As System.Windows.Forms.Button
    Friend WithEvents lblMensajes As System.Windows.Forms.Label
    Friend WithEvents HelpProviderHG As System.Windows.Forms.HelpProvider
End Class
