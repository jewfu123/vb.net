Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'MallmanagementDataSet.login' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.LoginTableAdapter.Fill(Me.MallmanagementDataSet.login)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            Me.LoginBindingSource.EndEdit()
            Me.LoginTableAdapter.Update(Me.MallmanagementDataSet.login)
        Catch ex As Exception

        End Try

    End Sub
End Class