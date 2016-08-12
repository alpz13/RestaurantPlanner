
Public Class Mesa
    Inherits Objetos

    Public idMesa, capacidadMax, idTipo, idEstadoMesa As Integer
    Public visible As Boolean
    Public clientes As List(Of Cliente)
    Public ImEstado, ImTipo As Bitmap

    Public Sub New(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer, ByVal d As Integer, ByVal e As Integer, _
                    ByVal f As Integer, ByVal g As Boolean, ByVal h As String, ByVal i As Bitmap, ByVal j As Bitmap)

        MyBase.New(d, e, h)
        idMesa = a
        idTipo = b
        capacidadMax = c
        idEstadoMesa = f
        ImEstado = i
        ImTipo = j
        visible = g
        clientes = New List(Of Cliente)



    End Sub

    Public Overrides Function clone() As Object
        Return New Mesa(idMesa, idTipo, capacidadMax, x, y, idEstadoMesa, visible, ruta, ImEstado, ImTipo)
    End Function

    Public Overrides Sub dibuja(ByVal g As Graphics)

        image.MakeTransparent(Color.White)

        g.DrawImage(image, New Point(x, y))
        g.DrawImage(ImTipo, New Point(x + image.Height - ImTipo.Height, y))
        g.DrawImage(ImEstado, New Point(x, y + image.Height - ImEstado.Height))
        g.DrawString(idMesa, SystemFonts.CaptionFont, Brushes.Black, New Point(x + (image.Width / 4), y + (image.Height / 4)))


    End Sub

    Public Sub dibujaRectangulo(ByVal g As Graphics)

        g.DrawRectangle(Pens.BlanchedAlmond, x + dx, y - dy, image.Width, image.Height)

    End Sub

End Class
