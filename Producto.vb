
Public Class Producto
    Inherits Objetos

    Public nombre, descripcion, idDescuento As String
    Public idProducto, precioActual, cantidad As Integer


    Public Sub New(ByVal a As String, ByVal b As String, ByVal c As Integer, ByVal d As Integer, ByVal e As String, _
                   ByVal f As Integer, ByVal g As Integer, ByVal h As String)

        MyBase.New(f, g, h)
        nombre = a
        descripcion = b
        idProducto = c
        precioActual = d
        idDescuento = e
        x = f
        y = g
        cantidad = 1

    End Sub

    Public Sub New(ByVal a As String, ByVal b As String, ByVal c As Integer, ByVal d As Integer, ByVal e As String, _
                ByVal f As Integer, ByVal g As Integer, ByVal h As Bitmap)

        MyBase.New(f, g, h)
        nombre = a
        descripcion = b
        idProducto = c
        precioActual = d
        idDescuento = e
        x = f
        y = g
        cantidad = 1

    End Sub

    Public Overrides Function clone() As Object
        Return New Producto(nombre, descripcion, idProducto, precioActual, idDescuento, x, y, image)
    End Function


    Public Overrides Function getBounds() As Rectangle

        Return New Rectangle(x, y - dy, 350, image.Height)
    End Function

    Public Overrides Sub dibuja(ByVal g As Graphics)

        g.DrawImage(image, x, y - dy)
        g.DrawString(nombre, SystemFonts.CaptionFont, Brushes.Black, New Point(x + 50, y - dy))
        g.DrawString("$ " & precioActual & ".00", SystemFonts.CaptionFont, Brushes.Black, New Point(x + 200, y - dy))
    End Sub

    Public Sub dibuja2(ByVal g As Graphics)

        g.DrawImage(image, x, y - dy)
        g.DrawString(nombre, SystemFonts.CaptionFont, Brushes.Black, New Point(x + 100, y - dy))
        g.DrawString(cantidad, SystemFonts.CaptionFont, Brushes.Black, New Point(x + 250, y - dy))

    End Sub

    Public Sub dibujaSelected(ByVal g As Graphics, ByVal b As Bitmap)
       
        g.DrawImage(b, x + 280, y - dy)

    End Sub

End Class
