Public Class Form1
    Private Sub btn_check_Click(sender As Object, e As EventArgs) Handles btn_check.Click
        Dim inputVal As Integer
        inputVal = CInt(tb_input.Text)
        Select Case inputVal
            Case Is = 0
                MsgBox("sb is : 0")
            Case Is = 1
                MsgBox("sb is : 1")
            Case Is = 2
                MsgBox("sb is : 2")
            Case 10 To 20
                MsgBox("sb is : 10-20")
            Case Else
                MsgBox("others!")
        End Select

    End Sub

    Private Sub btn_for_Click(sender As Object, e As EventArgs) Handles btn_for.Click
        Dim ii As Integer
        Dim randNum As System.Random
        Dim x As Integer
        Dim stOut As String
        Dim strArray(9) As String



        If tb_input.Text.Length <= 0 Then
            MsgBox("Please input the number!")
            Exit Sub
        End If

        Try
            ii = CInt(tb_input.Text)
            randNum = New System.Random()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        For i = 1 To ii Step 2
            x = randNum.Next(1, ii)
            Beep()
            Threading.Thread.Sleep(1000 * x)
            Console.WriteLine("random number is:" & x)
            stOut = stOut & i & vbNewLine
            strArray(i) = x
            'MsgBox(i)
        Next

        MsgBox(stOut)
        MsgBox(strArray.ToString)

    End Sub

    Private Sub btn_go_database_Click(sender As Object, e As EventArgs) Handles btn_go_database.Click
        'frm_Database.Show()

    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Application.Exit()
    End Sub

    Private Sub btn_go_db2_Click(sender As Object, e As EventArgs) Handles btn_go_db2.Click
        'frmDb2.Show()
        Form2.Show()

    End Sub

    Private Sub btn_3mdb_Click(sender As Object, e As EventArgs) Handles btn_3mdb.Click
        'frm_3mdb.Show()
    End Sub
End Class
