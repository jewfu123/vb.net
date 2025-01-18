Imports System.Drawing

Namespace GDI
    Public Class ImageManager
        Public Images As New Dictionary(Of String, Image)
        Public Sub LoadImage(Name As String, Path As String)
            If Images.ContainsKey(Name) Then
                Exit Sub
            Else
                Try
                    Dim i As Image = Image.FromFile(Path)
                    Images.Add(Name, i)
                Catch ex As Exception

                End Try
            End If
        End Sub

        Public Sub RemoveImage(Name As String)
            If Images.ContainsKey(Name) Then Images.Remove(Name)
        End Sub

        Public Sub DrawImage(Surface As Object, Name As String, Position As Point, Optional Size As Point = Nothing)
            Try
                If Images.ContainsKey(Name) Then
                    Dim G As Graphics = Surface.CreateGraphics
                    If Size.IsEmpty Then
                        G.DrawImage(Images(Name), Position)
                    Else
                        G.DrawImage(Images(Name), New Rectangle(Position.X, Position.Y, Size.X, Size.Y))

                    End If
                End If
            Catch ex As Exception

            End Try
        End Sub
    End Class
End Namespace

