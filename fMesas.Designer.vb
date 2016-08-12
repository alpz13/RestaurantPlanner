<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fMesas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fMesas))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbTipoMesa = New System.Windows.Forms.ComboBox()
        Me.txtCapacidad = New System.Windows.Forms.TextBox()
        Me.cmbEstadoMesa = New System.Windows.Forms.ComboBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.idMesaText = New System.Windows.Forms.TextBox()
        Me.pnlEdicion = New System.Windows.Forms.Panel()
        Me.lblMensajes = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.HelpProviderHG = New System.Windows.Forms.HelpProvider()
        Me.pnlEdicion.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 52)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Número de Mesa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 105)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Tipo de Mesa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 156)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Capacidad de Personas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 210)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Estado de Mesa"
        '
        'cmbTipoMesa
        '
        Me.cmbTipoMesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoMesa.FormattingEnabled = True
        Me.HelpProviderHG.SetHelpKeyword(Me.cmbTipoMesa, "fMesas.htm#Label1")
        Me.HelpProviderHG.SetHelpNavigator(Me.cmbTipoMesa, System.Windows.Forms.HelpNavigator.Topic)
        Me.cmbTipoMesa.Items.AddRange(New Object() {"Mesa", "Barra"})
        Me.cmbTipoMesa.Location = New System.Drawing.Point(197, 101)
        Me.cmbTipoMesa.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTipoMesa.Name = "cmbTipoMesa"
        Me.HelpProviderHG.SetShowHelp(Me.cmbTipoMesa, True)
        Me.cmbTipoMesa.Size = New System.Drawing.Size(187, 24)
        Me.cmbTipoMesa.TabIndex = 14
        '
        'txtCapacidad
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.txtCapacidad, "fMesas.htm#Label2")
        Me.HelpProviderHG.SetHelpNavigator(Me.txtCapacidad, System.Windows.Forms.HelpNavigator.Topic)
        Me.txtCapacidad.Location = New System.Drawing.Point(197, 153)
        Me.txtCapacidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCapacidad.Name = "txtCapacidad"
        Me.HelpProviderHG.SetShowHelp(Me.txtCapacidad, True)
        Me.txtCapacidad.Size = New System.Drawing.Size(187, 22)
        Me.txtCapacidad.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.txtCapacidad, "Este elemento describe cuantas personas puede alojar la mesa.")
        '
        'cmbEstadoMesa
        '
        Me.cmbEstadoMesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstadoMesa.FormattingEnabled = True
        Me.HelpProviderHG.SetHelpKeyword(Me.cmbEstadoMesa, "fMesas.htm#Label4")
        Me.HelpProviderHG.SetHelpNavigator(Me.cmbEstadoMesa, System.Windows.Forms.HelpNavigator.Topic)
        Me.cmbEstadoMesa.Items.AddRange(New Object() {"Disponible", "Ocupada", "Reservada", "Dañada"})
        Me.cmbEstadoMesa.Location = New System.Drawing.Point(197, 201)
        Me.cmbEstadoMesa.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbEstadoMesa.Name = "cmbEstadoMesa"
        Me.HelpProviderHG.SetShowHelp(Me.cmbEstadoMesa, True)
        Me.cmbEstadoMesa.Size = New System.Drawing.Size(187, 24)
        Me.cmbEstadoMesa.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.cmbEstadoMesa, "Estado en el que se encuentra la mesa.")
        '
        'btnClear
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnClear, "fMesas.htm#btnClear")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnClear, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.Location = New System.Drawing.Point(409, 97)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.HelpProviderHG.SetShowHelp(Me.btnClear, True)
        Me.btnClear.Size = New System.Drawing.Size(56, 44)
        Me.btnClear.TabIndex = 63
        Me.ToolTip1.SetToolTip(Me.btnClear, "Limpiar cajas de texto")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnBuscar, "fMesas.htm#btnBuscar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnBuscar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(409, 44)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.HelpProviderHG.SetShowHelp(Me.btnBuscar, True)
        Me.btnBuscar.Size = New System.Drawing.Size(56, 42)
        Me.btnBuscar.TabIndex = 61
        Me.ToolTip1.SetToolTip(Me.btnBuscar, "Buscar")
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnModificar, "fMesas.htm#btnModificar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnModificar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(4, 113)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModificar.Name = "btnModificar"
        Me.HelpProviderHG.SetShowHelp(Me.btnModificar, True)
        Me.btnModificar.Size = New System.Drawing.Size(56, 46)
        Me.btnModificar.TabIndex = 53
        Me.ToolTip1.SetToolTip(Me.btnModificar, "Modificar")
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnEliminar, "fMesas.htm#btnEliminar")
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
        Me.HelpProviderHG.SetHelpKeyword(Me.btnAgregar, "fMesas.htm#btnAgregar")
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
        'idMesaText
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.idMesaText, "fMesas.htm#Label3")
        Me.HelpProviderHG.SetHelpNavigator(Me.idMesaText, System.Windows.Forms.HelpNavigator.Topic)
        Me.idMesaText.Location = New System.Drawing.Point(197, 47)
        Me.idMesaText.Margin = New System.Windows.Forms.Padding(4)
        Me.idMesaText.Name = "idMesaText"
        Me.HelpProviderHG.SetShowHelp(Me.idMesaText, True)
        Me.idMesaText.Size = New System.Drawing.Size(187, 22)
        Me.idMesaText.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.idMesaText, "identificador único de la mesa")
        '
        'pnlEdicion
        '
        Me.pnlEdicion.Controls.Add(Me.btnModificar)
        Me.pnlEdicion.Controls.Add(Me.btnEliminar)
        Me.pnlEdicion.Controls.Add(Me.btnAgregar)
        Me.pnlEdicion.Enabled = False
        Me.pnlEdicion.Location = New System.Drawing.Point(472, 36)
        Me.pnlEdicion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlEdicion.Name = "pnlEdicion"
        Me.pnlEdicion.Size = New System.Drawing.Size(63, 165)
        Me.pnlEdicion.TabIndex = 69
        '
        'lblMensajes
        '
        Me.lblMensajes.AutoSize = True
        Me.lblMensajes.Location = New System.Drawing.Point(16, 11)
        Me.lblMensajes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMensajes.Name = "lblMensajes"
        Me.lblMensajes.Size = New System.Drawing.Size(0, 17)
        Me.lblMensajes.TabIndex = 70
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(360, 11)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 17)
        Me.lblTotal.TabIndex = 71
        '
        'HelpProviderHG
        '
        Me.HelpProviderHG.HelpNamespace = "Proyecto_BD_Final.chm"
        '
        'fMesas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 311)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblMensajes)
        Me.Controls.Add(Me.pnlEdicion)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.cmbEstadoMesa)
        Me.Controls.Add(Me.txtCapacidad)
        Me.Controls.Add(Me.cmbTipoMesa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.idMesaText)
        Me.HelpProviderHG.SetHelpKeyword(Me, "fMesas.htm")
        Me.HelpProviderHG.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.Topic)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fMesas"
        Me.HelpProviderHG.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Mesas"
        Me.pnlEdicion.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoMesa As System.Windows.Forms.ComboBox
    Friend WithEvents txtCapacidad As System.Windows.Forms.TextBox
    Friend WithEvents cmbEstadoMesa As System.Windows.Forms.ComboBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents pnlEdicion As System.Windows.Forms.Panel
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents idMesaText As System.Windows.Forms.TextBox
    Friend WithEvents lblMensajes As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents HelpProviderHG As System.Windows.Forms.HelpProvider
End Class
