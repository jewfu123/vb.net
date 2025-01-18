Imports GFXII.GDI

Public Class Form1
    Private ImgMan As New ImageManager
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        ImgMan.LoadImage("Sample", "Sample.jpg")
        ImgMan.LoadImage("Sample2", "Sample2.png")
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ImgMan.DrawImage(Me, "Sample", New Point(0, 0), New Point(Me.Width, Me.Height))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ImgMan.DrawImage(PictureBox1, "Sample2", New Point(0, 0), New Point(PictureBox1.Width, PictureBox1.Height))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ImgMan.RemoveImage("Sample2")
        PictureBox1.Refresh()
    End Sub
End Class
