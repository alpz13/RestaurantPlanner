
Public Class Cliente
    Inherits Objetos

    Public numero, ancho As Integer
    Public seleccionado As Boolean
    Public productos As List(Of Producto)

    Public Sub New(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer, ByVal d As Integer)

        MyBase.New(b, c, Application.StartupPath & "\Clientes.PNG")
        numero = a
        productos = New List(Of Producto)
        seleccionado = False
        ancho = d
    End Sub

    Public Sub dibujaNombre(ByVal g As Graphics)

        g.DrawString("Cliente " & numero, SystemFonts.CaptionFont, Brushes.White, New Point(x + 50, y - dy))

    End Sub

    Public Overrides Function getBounds() As Rectangle
        Return New Rectangle(x + dx, y - dy, ancho, image.Height)
    End Function

    Public Sub dibujaVerde(ByVal g As Graphics, ByVal b As Bitmap)

        g.DrawImage(b, x + 140, y - dy)

    End Sub

End Class
