<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fRoles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fRoles))
        Me.txtRol = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.pnlEdicion = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdRol = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbMaxId = New System.Windows.Forms.ComboBox()
        Me.errores = New System.Windows.Forms.Label()
        Me.HelpProviderHG = New System.Windows.Forms.HelpProvider()
        Me.pnlEdicion.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtRol
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.txtRol, "fRoles.htm#Label5")
        Me.HelpProviderHG.SetHelpNavigator(Me.txtRol, System.Windows.Forms.HelpNavigator.Topic)
        Me.txtRol.Location = New System.Drawing.Point(100, 113)
        Me.txtRol.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRol.MaxLength = 60
        Me.txtRol.Name = "txtRol"
        Me.HelpProviderHG.SetShowHelp(Me.txtRol, True)
        Me.txtRol.Size = New System.Drawing.Size(255, 22)
        Me.txtRol.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 117)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Rol"
        '
        'btnRegresar
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnRegresar, "fRoles.htm#btnRegresar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnRegresar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnRegresar.Image = CType(resources.GetObject("btnRegresar.Image"), System.Drawing.Image)
        Me.btnRegresar.Location = New System.Drawing.Point(421, 137)
        Me.btnRegresar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRegresar.Name = "btnRegresar"
        Me.HelpProviderHG.SetShowHelp(Me.btnRegresar, True)
        Me.btnRegresar.Size = New System.Drawing.Size(56, 44)
        Me.btnRegresar.TabIndex = 72
        Me.ToolTip1.SetToolTip(Me.btnRegresar, "Regresar a la ventana anterior.")
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnEliminar, "fRoles.htm#btnEliminar")
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
        Me.HelpProviderHG.SetHelpKeyword(Me.btnAgregar, "fRoles.htm#btnAgregar")
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
        'pnlEdicion
        '
        Me.pnlEdicion.Controls.Add(Me.btnEliminar)
        Me.pnlEdicion.Controls.Add(Me.btnAgregar)
        Me.pnlEdicion.Location = New System.Drawing.Point(419, 17)
        Me.pnlEdicion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlEdicion.Name = "pnlEdicion"
        Me.pnlEdicion.Size = New System.Drawing.Size(63, 113)
        Me.pnlEdicion.TabIndex = 71
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 41)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "idRol"
        '
        'txtIdRol
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.txtIdRol, "fRoles.htm#Label2")
        Me.HelpProviderHG.SetHelpNavigator(Me.txtIdRol, System.Windows.Forms.HelpNavigator.Topic)
        Me.txtIdRol.Location = New System.Drawing.Point(100, 37)
        Me.txtIdRol.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdRol.MaxLength = 4
        Me.txtIdRol.Name = "txtIdRol"
        Me.HelpProviderHG.SetShowHelp(Me.txtIdRol, True)
        Me.txtIdRol.Size = New System.Drawing.Size(132, 22)
        Me.txtIdRol.TabIndex = 79
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 81)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "idAsignado"
        '
        'cmbMaxId
        '
        Me.cmbMaxId.Enabled = False
        Me.cmbMaxId.FormattingEnabled = True
        Me.HelpProviderHG.SetHelpKeyword(Me.cmbMaxId, "fRoles.htm#Label1")
        Me.HelpProviderHG.SetHelpNavigator(Me.cmbMaxId, System.Windows.Forms.HelpNavigator.Topic)
        Me.cmbMaxId.Location = New System.Drawing.Point(100, 78)
        Me.cmbMaxId.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMaxId.Name = "cmbMaxId"
        Me.HelpProviderHG.SetShowHelp(Me.cmbMaxId, True)
        Me.cmbMaxId.Size = New System.Drawing.Size(160, 24)
        Me.cmbMaxId.TabIndex = 77
        '
        'errores
        '
        Me.errores.AutoSize = True
        Me.errores.ForeColor = System.Drawing.Color.Brown
        Me.errores.Location = New System.Drawing.Point(16, 11)
        Me.errores.Name = "errores"
        Me.errores.Size = New System.Drawing.Size(12, 17)
        Me.errores.TabIndex = 82
        Me.errores.Text = "."
        '
        'HelpProviderHG
        '
        Me.HelpProviderHG.HelpNamespace = "Proyecto_BD_Final.chm"
        '
        'fRoles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 186)
        Me.Controls.Add(Me.errores)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIdRol)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbMaxId)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.pnlEdicion)
        Me.Controls.Add(Me.txtRol)
        Me.Controls.Add(Me.Label5)
        Me.HelpProviderHG.SetHelpKeyword(Me, "fRoles.htm")
        Me.HelpProviderHG.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.Topic)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fRoles"
        Me.HelpProviderHG.SetShowHelp(Me, True)
        Me.Text = "Roles"
        Me.pnlEdicion.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRol As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnRegresar As System.Windows.Forms.Button
    Friend WithEvents pnlEdicion As System.Windows.Forms.Panel
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtIdRol As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbMaxId As System.Windows.Forms.ComboBox
    Friend WithEvents errores As System.Windows.Forms.Label
    Friend WithEvents HelpProviderHG As System.Windows.Forms.HelpProvider
End Class
