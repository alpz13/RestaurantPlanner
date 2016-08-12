Imports System
Imports System.Drawing
Imports System.Windows.Forms

Public Class Objetos
    Implements ICloneable

    Public x, y, dx, dy As Integer
    Public ruta As String
    Public image As Bitmap

    Public Sub New(ByVal a As Integer, ByVal b As Integer, ByVal c As String)
        x = a
        y = b
        ruta = c
        image = New Bitmap(c)
        dx = 0
        dy = 0

    End Sub

    Public Sub New(ByVal a As Integer, ByVal b As Integer, ByVal c As Bitmap)
        x = a
        y = b
        ruta = ""
        image = c
        dx = 0
        dy = 0

    End Sub

    Public Overridable Function getBounds() As Rectangle

        Return New Rectangle(x + dx, y - dy, image.Width, image.Height)
    End Function

    Public Overridable Sub dibuja(ByVal g As Graphics)

        g.DrawImage(image, New Point(x + dx, y - dy))

    End Sub

    Public Overridable Function clone() As Object Implements ICloneable.Clone

        Return New Objetos(x, y, ruta)

    End Function

End Class

