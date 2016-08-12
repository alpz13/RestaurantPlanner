<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginScreen
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
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnValidar = New System.Windows.Forms.Button()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblResultadoValidacion = New System.Windows.Forms.Label()
        Me.HelpProviderHG = New System.Windows.Forms.HelpProvider()
        Me.SuspendLayout()
        '
        'btnLimpiar
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnLimpiar, "LoginScreen.htm#btnLimpiar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnLimpiar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnLimpiar.Location = New System.Drawing.Point(343, 69)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.HelpProviderHG.SetShowHelp(Me.btnLimpiar, True)
        Me.btnLimpiar.Size = New System.Drawing.Size(100, 28)
        Me.btnLimpiar.TabIndex = 11
        Me.btnLimpiar.Text = "Limpiar"
        Me.ToolTip1.SetToolTip(Me.btnLimpiar, "Borrar el texto ingresado.")
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnValidar
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnValidar, "LoginScreen.htm#btnValidar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnValidar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnValidar.Location = New System.Drawing.Point(343, 39)
        Me.btnValidar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnValidar.Name = "btnValidar"
        Me.HelpProviderHG.SetShowHelp(Me.btnValidar, True)
        Me.btnValidar.Size = New System.Drawing.Size(100, 28)
        Me.btnValidar.TabIndex = 10
        Me.btnValidar.Text = "Validar"
        Me.ToolTip1.SetToolTip(Me.btnValidar, "Validar el usuario y contraseña ingresados para así iniciar la sesión del usuario" & _
        ".")
        Me.btnValidar.UseVisualStyleBackColor = True
        '
        'TxtPass
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.TxtPass, "LoginScreen.htm#Label2")
        Me.HelpProviderHG.SetHelpNavigator(Me.TxtPass, System.Windows.Forms.HelpNavigator.Topic)
        Me.TxtPass.Location = New System.Drawing.Point(141, 78)
        Me.TxtPass.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.HelpProviderHG.SetShowHelp(Me.TxtPass, True)
        Me.TxtPass.Size = New System.Drawing.Size(197, 22)
        Me.TxtPass.TabIndex = 9
        Me.TxtPass.Text = "30948423"
        '
        'txtUsuario
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.txtUsuario, "LoginScreen.htm#Label1")
        Me.HelpProviderHG.SetHelpNavigator(Me.txtUsuario, System.Windows.Forms.HelpNavigator.Topic)
        Me.txtUsuario.Location = New System.Drawing.Point(141, 46)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsuario.Name = "txtUsuario"
        Me.HelpProviderHG.SetShowHelp(Me.txtUsuario, True)
        Me.txtUsuario.Size = New System.Drawing.Size(192, 22)
        Me.txtUsuario.TabIndex = 8
        Me.txtUsuario.Text = "30948423"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 81)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 52)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Usuario"
        '
        'lblResultadoValidacion
        '
        Me.lblResultadoValidacion.AutoSize = True
        Me.lblResultadoValidacion.ForeColor = System.Drawing.Color.DarkRed
        Me.lblResultadoValidacion.Location = New System.Drawing.Point(61, 14)
        Me.lblResultadoValidacion.Name = "lblResultadoValidacion"
        Me.lblResultadoValidacion.Size = New System.Drawing.Size(12, 17)
        Me.lblResultadoValidacion.TabIndex = 12
        Me.lblResultadoValidacion.Text = "."
        '
        'HelpProviderHG
        '
        Me.HelpProviderHG.HelpNamespace = "Proyecto_BD_Final.chm"
        '
        'LoginScreen
        '
        Me.AcceptButton = Me.btnValidar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 146)
        Me.Controls.Add(Me.lblResultadoValidacion)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnValidar)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.HelpProviderHG.SetHelpKeyword(Me, "LoginScreen.htm")
        Me.HelpProviderHG.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.Topic)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginScreen"
        Me.HelpProviderHG.SetShowHelp(Me, True)
        Me.Text = "Control de Acceso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnValidar As System.Windows.Forms.Button
    Friend WithEvents TxtPass As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblResultadoValidacion As System.Windows.Forms.Label
    Friend WithEvents HelpProviderHG As System.Windows.Forms.HelpProvider
End Class
