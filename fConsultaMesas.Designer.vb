<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fConsultaMesas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fConsultaMesas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.pnlEdicion = New System.Windows.Forms.Panel()
        Me.lblMensajes = New System.Windows.Forms.Label()
        Me.HelpProviderHG = New System.Windows.Forms.HelpProvider()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlEdicion.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(11, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Selecciona una mesa para tomar la orden:"
        '
        'btnAgregar
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnAgregar, "fConsultaMesas.htm#btnAgregar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnAgregar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(3, 3)
        Me.btnAgregar.Name = "btnAgregar"
        Me.HelpProviderHG.SetShowHelp(Me.btnAgregar, True)
        Me.btnAgregar.Size = New System.Drawing.Size(42, 45)
        Me.btnAgregar.TabIndex = 51
        Me.ToolTip1.SetToolTip(Me.btnAgregar, "Agregar")
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnEliminar, "fConsultaMesas.htm#btnEliminar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnEliminar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(51, 3)
        Me.btnEliminar.Name = "btnEliminar"
        Me.HelpProviderHG.SetShowHelp(Me.btnEliminar, True)
        Me.btnEliminar.Size = New System.Drawing.Size(42, 45)
        Me.btnEliminar.TabIndex = 52
        Me.ToolTip1.SetToolTip(Me.btnEliminar, "Eliminar")
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'pnlEdicion
        '
        Me.pnlEdicion.BackColor = System.Drawing.Color.Gold
        Me.pnlEdicion.Controls.Add(Me.btnAgregar)
        Me.pnlEdicion.Controls.Add(Me.btnEliminar)
        Me.pnlEdicion.Location = New System.Drawing.Point(14, 39)
        Me.pnlEdicion.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlEdicion.Name = "pnlEdicion"
        Me.pnlEdicion.Size = New System.Drawing.Size(97, 58)
        Me.pnlEdicion.TabIndex = 70
        '
        'lblMensajes
        '
        Me.lblMensajes.AutoSize = True
        Me.lblMensajes.ForeColor = System.Drawing.Color.Navy
        Me.lblMensajes.Location = New System.Drawing.Point(14, 7)
        Me.lblMensajes.Name = "lblMensajes"
        Me.lblMensajes.Size = New System.Drawing.Size(10, 13)
        Me.lblMensajes.TabIndex = 71
        Me.lblMensajes.Text = "."
        '
        'HelpProviderHG
        '
        Me.HelpProviderHG.HelpNamespace = "Proyecto_BD_Final.chm"
        '
        'Timer1
        '
        '
        'fConsultaMesas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OliveDrab
        Me.ClientSize = New System.Drawing.Size(688, 344)
        Me.Controls.Add(Me.lblMensajes)
        Me.Controls.Add(Me.pnlEdicion)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.HelpProviderHG.SetHelpKeyword(Me, "fConsultaMesas.htm")
        Me.HelpProviderHG.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.Topic)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fConsultaMesas"
        Me.HelpProviderHG.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Mesas"
        Me.pnlEdicion.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents pnlEdicion As System.Windows.Forms.Panel
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents lblMensajes As System.Windows.Forms.Label
    Friend WithEvents HelpProviderHG As System.Windows.Forms.HelpProvider
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
