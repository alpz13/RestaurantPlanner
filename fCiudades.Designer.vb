<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fCiudades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fCiudades))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.pnlEdicion = New System.Windows.Forms.Panel()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbMax = New System.Windows.Forms.ComboBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.HelpProviderHG = New System.Windows.Forms.HelpProvider()
        Me.pnlEdicion.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ciudad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 73)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Estado"
        '
        'txtCiudad
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.txtCiudad, "fCiudades.htm#Label1")
        Me.HelpProviderHG.SetHelpNavigator(Me.txtCiudad, System.Windows.Forms.HelpNavigator.Topic)
        Me.txtCiudad.Location = New System.Drawing.Point(149, 15)
        Me.txtCiudad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCiudad.MaxLength = 30
        Me.txtCiudad.Name = "txtCiudad"
        Me.HelpProviderHG.SetShowHelp(Me.txtCiudad, True)
        Me.txtCiudad.Size = New System.Drawing.Size(160, 22)
        Me.txtCiudad.TabIndex = 2
        '
        'cmbEstado
        '
        Me.cmbEstado.FormattingEnabled = True
        Me.HelpProviderHG.SetHelpKeyword(Me.cmbEstado, "fCiudades.htm#Label2")
        Me.HelpProviderHG.SetHelpNavigator(Me.cmbEstado, System.Windows.Forms.HelpNavigator.Topic)
        Me.cmbEstado.Location = New System.Drawing.Point(149, 63)
        Me.cmbEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbEstado.Name = "cmbEstado"
        Me.HelpProviderHG.SetShowHelp(Me.cmbEstado, True)
        Me.cmbEstado.Size = New System.Drawing.Size(160, 24)
        Me.cmbEstado.TabIndex = 3
        '
        'pnlEdicion
        '
        Me.pnlEdicion.Controls.Add(Me.btnEliminar)
        Me.pnlEdicion.Controls.Add(Me.btnAgregar)
        Me.pnlEdicion.Location = New System.Drawing.Point(407, 16)
        Me.pnlEdicion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlEdicion.Name = "pnlEdicion"
        Me.pnlEdicion.Size = New System.Drawing.Size(63, 118)
        Me.pnlEdicion.TabIndex = 66
        '
        'btnEliminar
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnEliminar, "fCiudades.htm#btnEliminar")
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
        'btnAgregar
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnAgregar, "fCiudades.htm#btnAgregar")
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
        'btnRegresar
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnRegresar, "fCiudades.htm#btnRegresar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnRegresar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnRegresar.Image = CType(resources.GetObject("btnRegresar.Image"), System.Drawing.Image)
        Me.btnRegresar.Location = New System.Drawing.Point(411, 140)
        Me.btnRegresar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRegresar.Name = "btnRegresar"
        Me.HelpProviderHG.SetShowHelp(Me.btnRegresar, True)
        Me.btnRegresar.Size = New System.Drawing.Size(56, 44)
        Me.btnRegresar.TabIndex = 68
        Me.ToolTip1.SetToolTip(Me.btnRegresar, "Regresar a la ventana anterior.")
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbMax)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(149, 105)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(180, 37)
        Me.Panel1.TabIndex = 72
        '
        'cmbMax
        '
        Me.cmbMax.Enabled = False
        Me.cmbMax.FormattingEnabled = True
        Me.HelpProviderHG.SetHelpKeyword(Me.cmbMax, "fCiudades.htm#cmbMax")
        Me.HelpProviderHG.SetHelpNavigator(Me.cmbMax, System.Windows.Forms.HelpNavigator.Topic)
        Me.cmbMax.Location = New System.Drawing.Point(4, 4)
        Me.cmbMax.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMax.Name = "cmbMax"
        Me.HelpProviderHG.SetShowHelp(Me.cmbMax, True)
        Me.cmbMax.Size = New System.Drawing.Size(160, 24)
        Me.cmbMax.TabIndex = 70
        '
        'txtId
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.txtId, "fCiudades.htm#Label3")
        Me.HelpProviderHG.SetHelpNavigator(Me.txtId, System.Windows.Forms.HelpNavigator.Topic)
        Me.txtId.Location = New System.Drawing.Point(149, 174)
        Me.txtId.Margin = New System.Windows.Forms.Padding(4)
        Me.txtId.MaxLength = 4
        Me.txtId.Name = "txtId"
        Me.HelpProviderHG.SetShowHelp(Me.txtId, True)
        Me.txtId.Size = New System.Drawing.Size(156, 22)
        Me.txtId.TabIndex = 76
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 177)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 17)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "id a Eliminar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 126)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 17)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "idAsignado"
        '
        'HelpProviderHG
        '
        Me.HelpProviderHG.HelpNamespace = "Proyecto_BD_Final.chm"
        '
        'fCiudades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 239)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.pnlEdicion)
        Me.Controls.Add(Me.cmbEstado)
        Me.Controls.Add(Me.txtCiudad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.HelpProviderHG.SetHelpKeyword(Me, "fCiudades.htm")
        Me.HelpProviderHG.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.Topic)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fCiudades"
        Me.HelpProviderHG.SetShowHelp(Me, True)
        Me.Text = "Ciudades"
        Me.pnlEdicion.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCiudad As System.Windows.Forms.TextBox
    Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents pnlEdicion As System.Windows.Forms.Panel
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnRegresar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbMax As System.Windows.Forms.ComboBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents HelpProviderHG As System.Windows.Forms.HelpProvider
End Class
