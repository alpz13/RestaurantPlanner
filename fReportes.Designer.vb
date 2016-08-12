<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fReportes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fReportes))
        Me.ProvedoresBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProvedoresBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.cboReporte = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.errores = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnlEntre = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtHasta = New System.Windows.Forms.TextBox()
        Me.txtEntre = New System.Windows.Forms.TextBox()
        Me.pnlMenor = New System.Windows.Forms.Panel()
        Me.txtMenor = New System.Windows.Forms.TextBox()
        Me.pnlMayor = New System.Windows.Forms.Panel()
        Me.txtMayor = New System.Windows.Forms.TextBox()
        Me.cmbMate = New System.Windows.Forms.ComboBox()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.cmbProducto = New System.Windows.Forms.ComboBox()
        Me.chkProducto = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmbFolio = New System.Windows.Forms.ComboBox()
        Me.cmbRFC = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnFactura = New System.Windows.Forms.Button()
        Me.HelpProviderHG = New System.Windows.Forms.HelpProvider()
        CType(Me.ProvedoresBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProvedoresBindingNavigator.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlEntre.SuspendLayout()
        Me.pnlMenor.SuspendLayout()
        Me.pnlMayor.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProvedoresBindingNavigator
        '
        Me.ProvedoresBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProvedoresBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProvedoresBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProvedoresBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProvedoresBindingNavigatorSaveItem})
        Me.ProvedoresBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProvedoresBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProvedoresBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProvedoresBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProvedoresBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProvedoresBindingNavigator.Name = "ProvedoresBindingNavigator"
        Me.ProvedoresBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProvedoresBindingNavigator.Size = New System.Drawing.Size(704, 25)
        Me.ProvedoresBindingNavigator.TabIndex = 4
        Me.ProvedoresBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(38, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ProvedoresBindingNavigatorSaveItem
        '
        Me.ProvedoresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProvedoresBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProvedoresBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProvedoresBindingNavigatorSaveItem.Name = "ProvedoresBindingNavigatorSaveItem"
        Me.ProvedoresBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ProvedoresBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'cboReporte
        '
        Me.cboReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReporte.FormattingEnabled = True
        Me.HelpProviderHG.SetHelpKeyword(Me.cboReporte, "fReportes.htm#Label1")
        Me.HelpProviderHG.SetHelpNavigator(Me.cboReporte, System.Windows.Forms.HelpNavigator.Topic)
        Me.cboReporte.Items.AddRange(New Object() {"Consulta Genérica", "Factura"})
        Me.cboReporte.Location = New System.Drawing.Point(60, 49)
        Me.cboReporte.Margin = New System.Windows.Forms.Padding(2)
        Me.cboReporte.Name = "cboReporte"
        Me.HelpProviderHG.SetShowHelp(Me.cboReporte, True)
        Me.cboReporte.Size = New System.Drawing.Size(92, 21)
        Me.cboReporte.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.cboReporte, "Selecciona el tipo de reporte a mostrar")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Reporte"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(192, 51)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Periodo"
        '
        'dtpDesde
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.dtpDesde, "fReportes.htm#Label2")
        Me.HelpProviderHG.SetHelpNavigator(Me.dtpDesde, System.Windows.Forms.HelpNavigator.Topic)
        Me.dtpDesde.Location = New System.Drawing.Point(239, 49)
        Me.dtpDesde.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpDesde.Name = "dtpDesde"
        Me.HelpProviderHG.SetShowHelp(Me.dtpDesde, True)
        Me.dtpDesde.Size = New System.Drawing.Size(202, 20)
        Me.dtpDesde.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.dtpDesde, "Selecciona la fecha inicial del periodo a desplegar en el reporte.")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(458, 51)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "a"
        '
        'dtpHasta
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.dtpHasta, "fReportes.htm#Label3")
        Me.HelpProviderHG.SetHelpNavigator(Me.dtpHasta, System.Windows.Forms.HelpNavigator.Topic)
        Me.dtpHasta.Location = New System.Drawing.Point(474, 49)
        Me.dtpHasta.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpHasta.Name = "dtpHasta"
        Me.HelpProviderHG.SetShowHelp(Me.dtpHasta, True)
        Me.dtpHasta.Size = New System.Drawing.Size(202, 20)
        Me.dtpHasta.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.dtpHasta, "Selecciona la fecha final del periodo a desplegar en el reporte.")
        '
        'errores
        '
        Me.errores.AutoSize = True
        Me.errores.ForeColor = System.Drawing.Color.Brown
        Me.errores.Location = New System.Drawing.Point(12, 25)
        Me.errores.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.errores.Name = "errores"
        Me.errores.Size = New System.Drawing.Size(10, 13)
        Me.errores.TabIndex = 12
        Me.errores.Text = "."
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.pnlEntre)
        Me.Panel1.Controls.Add(Me.pnlMenor)
        Me.Panel1.Controls.Add(Me.pnlMayor)
        Me.Panel1.Controls.Add(Me.cmbMate)
        Me.Panel1.Controls.Add(Me.btnReporte)
        Me.Panel1.Controls.Add(Me.cmbProducto)
        Me.Panel1.Controls.Add(Me.chkProducto)
        Me.Panel1.Location = New System.Drawing.Point(18, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(658, 152)
        Me.Panel1.TabIndex = 13
        Me.Panel1.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(240, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Cantidad"
        '
        'pnlEntre
        '
        Me.pnlEntre.Controls.Add(Me.Label7)
        Me.pnlEntre.Controls.Add(Me.txtHasta)
        Me.pnlEntre.Controls.Add(Me.txtEntre)
        Me.pnlEntre.Location = New System.Drawing.Point(383, 68)
        Me.pnlEntre.Name = "pnlEntre"
        Me.pnlEntre.Size = New System.Drawing.Size(257, 59)
        Me.pnlEntre.TabIndex = 7
        Me.pnlEntre.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(119, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "a"
        '
        'txtHasta
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.txtHasta, "fReportes.htm#Label7")
        Me.HelpProviderHG.SetHelpNavigator(Me.txtHasta, System.Windows.Forms.HelpNavigator.Topic)
        Me.txtHasta.Location = New System.Drawing.Point(157, 17)
        Me.txtHasta.Name = "txtHasta"
        Me.HelpProviderHG.SetShowHelp(Me.txtHasta, True)
        Me.txtHasta.Size = New System.Drawing.Size(83, 20)
        Me.txtHasta.TabIndex = 3
        '
        'txtEntre
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.txtEntre, "fReportes.htm#txtEntre")
        Me.HelpProviderHG.SetHelpNavigator(Me.txtEntre, System.Windows.Forms.HelpNavigator.Topic)
        Me.txtEntre.Location = New System.Drawing.Point(14, 17)
        Me.txtEntre.Name = "txtEntre"
        Me.HelpProviderHG.SetShowHelp(Me.txtEntre, True)
        Me.txtEntre.Size = New System.Drawing.Size(83, 20)
        Me.txtEntre.TabIndex = 2
        '
        'pnlMenor
        '
        Me.pnlMenor.Controls.Add(Me.txtMenor)
        Me.pnlMenor.Location = New System.Drawing.Point(203, 68)
        Me.pnlMenor.Name = "pnlMenor"
        Me.pnlMenor.Size = New System.Drawing.Size(174, 59)
        Me.pnlMenor.TabIndex = 6
        Me.pnlMenor.Visible = False
        '
        'txtMenor
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.txtMenor, "fReportes.htm#txtMenor")
        Me.HelpProviderHG.SetHelpNavigator(Me.txtMenor, System.Windows.Forms.HelpNavigator.Topic)
        Me.txtMenor.Location = New System.Drawing.Point(88, 17)
        Me.txtMenor.Name = "txtMenor"
        Me.HelpProviderHG.SetShowHelp(Me.txtMenor, True)
        Me.txtMenor.Size = New System.Drawing.Size(83, 20)
        Me.txtMenor.TabIndex = 1
        '
        'pnlMayor
        '
        Me.pnlMayor.Controls.Add(Me.txtMayor)
        Me.pnlMayor.Location = New System.Drawing.Point(21, 68)
        Me.pnlMayor.Name = "pnlMayor"
        Me.pnlMayor.Size = New System.Drawing.Size(175, 59)
        Me.pnlMayor.TabIndex = 5
        Me.pnlMayor.Visible = False
        '
        'txtMayor
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.txtMayor, "fReportes.htm#txtMayor")
        Me.HelpProviderHG.SetHelpNavigator(Me.txtMayor, System.Windows.Forms.HelpNavigator.Topic)
        Me.txtMayor.Location = New System.Drawing.Point(75, 17)
        Me.txtMayor.Name = "txtMayor"
        Me.HelpProviderHG.SetShowHelp(Me.txtMayor, True)
        Me.txtMayor.Size = New System.Drawing.Size(83, 20)
        Me.txtMayor.TabIndex = 0
        '
        'cmbMate
        '
        Me.cmbMate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMate.FormattingEnabled = True
        Me.HelpProviderHG.SetHelpKeyword(Me.cmbMate, "fReportes.htm#Label6")
        Me.HelpProviderHG.SetHelpNavigator(Me.cmbMate, System.Windows.Forms.HelpNavigator.Topic)
        Me.cmbMate.Items.AddRange(New Object() {"Mayor A", "Menor A", "Entre"})
        Me.cmbMate.Location = New System.Drawing.Point(302, 13)
        Me.cmbMate.Name = "cmbMate"
        Me.HelpProviderHG.SetShowHelp(Me.cmbMate, True)
        Me.cmbMate.Size = New System.Drawing.Size(121, 21)
        Me.cmbMate.TabIndex = 4
        '
        'btnReporte
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnReporte, "fReportes.htm#btnReporte")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnReporte, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnReporte.Location = New System.Drawing.Point(518, 13)
        Me.btnReporte.Name = "btnReporte"
        Me.HelpProviderHG.SetShowHelp(Me.btnReporte, True)
        Me.btnReporte.Size = New System.Drawing.Size(75, 23)
        Me.btnReporte.TabIndex = 3
        Me.btnReporte.Text = "Reporte"
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'cmbProducto
        '
        Me.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProducto.Enabled = False
        Me.cmbProducto.FormattingEnabled = True
        Me.HelpProviderHG.SetHelpKeyword(Me.cmbProducto, "fReportes.htm#cmbProducto")
        Me.HelpProviderHG.SetHelpNavigator(Me.cmbProducto, System.Windows.Forms.HelpNavigator.Topic)
        Me.cmbProducto.Location = New System.Drawing.Point(96, 13)
        Me.cmbProducto.Name = "cmbProducto"
        Me.HelpProviderHG.SetShowHelp(Me.cmbProducto, True)
        Me.cmbProducto.Size = New System.Drawing.Size(121, 21)
        Me.cmbProducto.TabIndex = 2
        '
        'chkProducto
        '
        Me.chkProducto.AutoSize = True
        Me.HelpProviderHG.SetHelpKeyword(Me.chkProducto, "fReportes.htm#chkProducto")
        Me.HelpProviderHG.SetHelpNavigator(Me.chkProducto, System.Windows.Forms.HelpNavigator.Topic)
        Me.chkProducto.Location = New System.Drawing.Point(16, 15)
        Me.chkProducto.Name = "chkProducto"
        Me.HelpProviderHG.SetShowHelp(Me.chkProducto, True)
        Me.chkProducto.Size = New System.Drawing.Size(69, 17)
        Me.chkProducto.TabIndex = 1
        Me.chkProducto.Text = "Producto"
        Me.chkProducto.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cmbFolio)
        Me.Panel2.Controls.Add(Me.cmbRFC)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.btnFactura)
        Me.Panel2.Location = New System.Drawing.Point(18, 247)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(347, 133)
        Me.Panel2.TabIndex = 14
        Me.Panel2.Visible = False
        '
        'cmbFolio
        '
        Me.cmbFolio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFolio.FormattingEnabled = True
        Me.cmbFolio.Location = New System.Drawing.Point(96, 55)
        Me.cmbFolio.Name = "cmbFolio"
        Me.cmbFolio.Size = New System.Drawing.Size(121, 21)
        Me.cmbFolio.TabIndex = 15
        '
        'cmbRFC
        '
        Me.cmbRFC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRFC.Location = New System.Drawing.Point(96, 19)
        Me.cmbRFC.Name = "cmbRFC"
        Me.cmbRFC.Size = New System.Drawing.Size(121, 21)
        Me.cmbRFC.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "RFC"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Folio"
        '
        'btnFactura
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnFactura, "fReportes.htm#btnFactura")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnFactura, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnFactura.Location = New System.Drawing.Point(243, 77)
        Me.btnFactura.Name = "btnFactura"
        Me.HelpProviderHG.SetShowHelp(Me.btnFactura, True)
        Me.btnFactura.Size = New System.Drawing.Size(75, 23)
        Me.btnFactura.TabIndex = 1
        Me.btnFactura.Text = "Facturar"
        Me.btnFactura.UseVisualStyleBackColor = True
        '
        'HelpProviderHG
        '
        Me.HelpProviderHG.HelpNamespace = "Proyecto_BD_Final.chm"
        '
        'fReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 629)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.errores)
        Me.Controls.Add(Me.dtpHasta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpDesde)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboReporte)
        Me.Controls.Add(Me.ProvedoresBindingNavigator)
        Me.HelpProviderHG.SetHelpKeyword(Me, "fReportes.htm")
        Me.HelpProviderHG.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.Topic)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "fReportes"
        Me.HelpProviderHG.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.ProvedoresBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProvedoresBindingNavigator.ResumeLayout(False)
        Me.ProvedoresBindingNavigator.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlEntre.ResumeLayout(False)
        Me.pnlEntre.PerformLayout()
        Me.pnlMenor.ResumeLayout(False)
        Me.pnlMenor.PerformLayout()
        Me.pnlMayor.ResumeLayout(False)
        Me.pnlMayor.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProvedoresBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ProvedoresBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents cboReporte As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents errores As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmbProducto As System.Windows.Forms.ComboBox
    Friend WithEvents chkProducto As System.Windows.Forms.CheckBox
    Friend WithEvents btnReporte As System.Windows.Forms.Button
    Friend WithEvents btnFactura As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbMate As System.Windows.Forms.ComboBox
    Friend WithEvents pnlMenor As System.Windows.Forms.Panel
    Friend WithEvents pnlMayor As System.Windows.Forms.Panel
    Friend WithEvents pnlEntre As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtEntre As System.Windows.Forms.TextBox
    Friend WithEvents txtMenor As System.Windows.Forms.TextBox
    Friend WithEvents txtMayor As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtHasta As System.Windows.Forms.TextBox
    Friend WithEvents HelpProviderHG As System.Windows.Forms.HelpProvider
    Friend WithEvents cmbRFC As System.Windows.Forms.ComboBox
    Friend WithEvents cmbFolio As System.Windows.Forms.ComboBox
End Class
