<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fDescuentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fDescuentos))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.pnlEdicion = New System.Windows.Forms.Panel()
        Me.cmbProductos = New System.Windows.Forms.ComboBox()
        Me.cmbDescuentos = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HelpProviderHG = New System.Windows.Forms.HelpProvider()
        Me.pnlEdicion.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAgregar
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnAgregar, "fDescuentos.htm#btnAgregar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnAgregar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(4, 9)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.HelpProviderHG.SetShowHelp(Me.btnAgregar, True)
        Me.btnAgregar.Size = New System.Drawing.Size(56, 46)
        Me.btnAgregar.TabIndex = 51
        Me.ToolTip1.SetToolTip(Me.btnAgregar, "Agregar")
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnEliminar, "fDescuentos.htm#btnEliminar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnEliminar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(4, 62)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.HelpProviderHG.SetShowHelp(Me.btnEliminar, True)
        Me.btnEliminar.Size = New System.Drawing.Size(56, 44)
        Me.btnEliminar.TabIndex = 52
        Me.ToolTip1.SetToolTip(Me.btnEliminar, "Eliminar")
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnRegresar, "fDescuentos.htm#btnRegresar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnRegresar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnRegresar.Image = CType(resources.GetObject("btnRegresar.Image"), System.Drawing.Image)
        Me.btnRegresar.Location = New System.Drawing.Point(509, 132)
        Me.btnRegresar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRegresar.Name = "btnRegresar"
        Me.HelpProviderHG.SetShowHelp(Me.btnRegresar, True)
        Me.btnRegresar.Size = New System.Drawing.Size(56, 44)
        Me.btnRegresar.TabIndex = 77
        Me.ToolTip1.SetToolTip(Me.btnRegresar, "Regresar a la ventana anterior.")
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'pnlEdicion
        '
        Me.pnlEdicion.Controls.Add(Me.btnEliminar)
        Me.pnlEdicion.Controls.Add(Me.btnAgregar)
        Me.pnlEdicion.Enabled = False
        Me.pnlEdicion.Location = New System.Drawing.Point(505, 14)
        Me.pnlEdicion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlEdicion.Name = "pnlEdicion"
        Me.pnlEdicion.Size = New System.Drawing.Size(63, 112)
        Me.pnlEdicion.TabIndex = 76
        Me.pnlEdicion.Visible = False
        '
        'cmbProductos
        '
        Me.cmbProductos.FormattingEnabled = True
        Me.HelpProviderHG.SetHelpKeyword(Me.cmbProductos, "fDescuentos.htm#Label3")
        Me.HelpProviderHG.SetHelpNavigator(Me.cmbProductos, System.Windows.Forms.HelpNavigator.Topic)
        Me.cmbProductos.Location = New System.Drawing.Point(231, 48)
        Me.cmbProductos.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbProductos.Name = "cmbProductos"
        Me.HelpProviderHG.SetShowHelp(Me.cmbProductos, True)
        Me.cmbProductos.Size = New System.Drawing.Size(187, 24)
        Me.cmbProductos.TabIndex = 81
        '
        'cmbDescuentos
        '
        Me.cmbDescuentos.FormattingEnabled = True
        Me.HelpProviderHG.SetHelpKeyword(Me.cmbDescuentos, "fDescuentos.htm#Label1")
        Me.HelpProviderHG.SetHelpNavigator(Me.cmbDescuentos, System.Windows.Forms.HelpNavigator.Topic)
        Me.cmbDescuentos.Location = New System.Drawing.Point(231, 112)
        Me.cmbDescuentos.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbDescuentos.Name = "cmbDescuentos"
        Me.HelpProviderHG.SetShowHelp(Me.cmbDescuentos, True)
        Me.cmbDescuentos.Size = New System.Drawing.Size(187, 24)
        Me.cmbDescuentos.TabIndex = 79
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 52)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Producto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 112)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Descuento"
        '
        'HelpProviderHG
        '
        Me.HelpProviderHG.HelpNamespace = "Proyecto_BD_Final.chm"
        '
        'fDescuentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 190)
        Me.Controls.Add(Me.cmbProductos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbDescuentos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.pnlEdicion)
        Me.HelpProviderHG.SetHelpKeyword(Me, "fDescuentos.htm")
        Me.HelpProviderHG.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.Topic)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fDescuentos"
        Me.HelpProviderHG.SetShowHelp(Me, True)
        Me.Text = "Descuentos"
        Me.pnlEdicion.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents pnlEdicion As System.Windows.Forms.Panel
    Friend WithEvents btnRegresar As System.Windows.Forms.Button
    Friend WithEvents cmbProductos As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbDescuentos As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents HelpProviderHG As System.Windows.Forms.HelpProvider
End Class
