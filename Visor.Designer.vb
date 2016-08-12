<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Visor
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
        Me.crvViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.HelpProviderHG = New System.Windows.Forms.HelpProvider()
        Me.SuspendLayout()
        '
        'crvViewer
        '
        Me.crvViewer.ActiveViewIndex = -1
        Me.crvViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpProviderHG.SetHelpKeyword(Me.crvViewer, "Visor.htm#crvViewer")
        Me.HelpProviderHG.SetHelpNavigator(Me.crvViewer, System.Windows.Forms.HelpNavigator.Topic)
        Me.crvViewer.Location = New System.Drawing.Point(0, 0)
        Me.crvViewer.Name = "crvViewer"
        Me.HelpProviderHG.SetShowHelp(Me.crvViewer, True)
        Me.crvViewer.Size = New System.Drawing.Size(509, 409)
        Me.crvViewer.TabIndex = 0
        '
        'HelpProviderHG
        '
        Me.HelpProviderHG.HelpNamespace = "Proyecto_BD_Final.chm"
        '
        'Visor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 409)
        Me.Controls.Add(Me.crvViewer)
        Me.HelpProviderHG.SetHelpKeyword(Me, "Visor.htm")
        Me.HelpProviderHG.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.Topic)
        Me.Name = "Visor"
        Me.HelpProviderHG.SetShowHelp(Me, True)
        Me.Text = "Visor"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents HelpProviderHG As System.Windows.Forms.HelpProvider
End Class
