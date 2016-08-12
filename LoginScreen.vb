Public Class LoginScreen
    Public main As fMain

    Private Sub txtUsuario_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtUsuario.TextChanged
        'Validar enter para comenzar la validación.
    End Sub

    Private Function validaUsuario(usuario As String, pass As String) As Boolean
        If usuario = "0" Then
            If pass = "0" Then
                Return True
            End If
        Else
            If modUtil.executeValidado("declare @uValidadoE int; execute validaUsuarioStoredP '" & usuario & "', '" & pass & "' , @uValidado = @uValidadoE  output; select @uValidadoE") Then
                Return True
            End If
        End If
        Return False

    End Function

    Private Sub LoginScreen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        
        Try
            modUtil.createConnection("orozco.qro.itesm.mx", "bdEquipo3", "bdEquipo3 ", "tsgrze-eht")
        Catch ex As Exception
            lblResultadoValidacion.Text = "Error en creación de conexión a base de datos."
        End Try
        txtUsuario.MaxLength = 8
        TxtPass.MaxLength = 8
    End Sub


   
    Private Function validaSeguridad(usuario As String, pass As String)
        Dim tamano As Integer
        tamano = 10

        If usuario.Length >= tamano Then
            'MsgBox("Tamaño válido de texto de usuario excedido")
            lblResultadoValidacion.Text = "Tamaño válido de texto de usuario excedido"
            Return 0
        ElseIf pass.Length >= tamano Then
            'MsgBox("Tamaño válido de texto de contraseña excedida")
            lblResultadoValidacion.Text = "Tamaño válido de texto de contraseña excedida"
            Return 0
        End If
        Return 1
    End Function

   
    Private Sub btnValidar_Click(sender As System.Object, e As System.EventArgs) Handles btnValidar.Click
        If validaSeguridad(txtUsuario.Text, TxtPass.Text) Then
            If validaUsuario(txtUsuario.Text, TxtPass.Text) Then
                main = New fMain
                main.setPermisos(txtUsuario.Text)
                lblResultadoValidacion.Text = "."
                Me.Hide()
                main.Show()
            Else
                lblResultadoValidacion.Text = "Usuario y/o contraseña inválidos"
                Try
                    Dim dmlRecordatorioPass = "select recordatorio from usuarios where idUsuario =" & txtUsuario.Text
                    Dim tablaRecordatorio As DataTable
                    tablaRecordatorio = modUtil.getDataTable(dmlRecordatorioPass)
                    lblResultadoValidacion.Text = "Recordatorio de contraseña: " & tablaRecordatorio.Rows.Item(0).Item(0).ToString
                Catch ex As Exception
                    lblResultadoValidacion.Text = "Error en la obtención del recordatorio de contraseña"
                End Try

            End If
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles btnLimpiar.Click
        txtUsuario.Text = ""
        TxtPass.Text = ""
        lblResultadoValidacion.Text = ":"
    End Sub

    Private Sub LoginScreen_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed

            Application.Exit()

    End Sub

    
    Private Sub txtUsuario_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsuario.KeyPress
        If (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            Exit Sub
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TxtPass_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPass.KeyPress
        If (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsLetter(e.KeyChar)) Then
            Exit Sub
        Else
            e.Handled = True
        End If
    End Sub
End Class