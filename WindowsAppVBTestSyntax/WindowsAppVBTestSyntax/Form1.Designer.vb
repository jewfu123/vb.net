<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_check = New System.Windows.Forms.Button()
        Me.tb_input = New System.Windows.Forms.TextBox()
        Me.btn_for = New System.Windows.Forms.Button()
        Me.btn_go_database = New System.Windows.Forms.Button()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.btn_go_db2 = New System.Windows.Forms.Button()
        Me.btn_3mdb = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_check
        '
        Me.btn_check.Location = New System.Drawing.Point(64, 216)
        Me.btn_check.Name = "btn_check"
        Me.btn_check.Size = New System.Drawing.Size(126, 43)
        Me.btn_check.TabIndex = 0
        Me.btn_check.Text = "C&heck"
        Me.btn_check.UseVisualStyleBackColor = True
        '
        'tb_input
        '
        Me.tb_input.Location = New System.Drawing.Point(64, 111)
        Me.tb_input.Name = "tb_input"
        Me.tb_input.Size = New System.Drawing.Size(181, 25)
        Me.tb_input.TabIndex = 1
        '
        'btn_for
        '
        Me.btn_for.Location = New System.Drawing.Point(64, 163)
        Me.btn_for.Name = "btn_for"
        Me.btn_for.Size = New System.Drawing.Size(126, 36)
        Me.btn_for.TabIndex = 2
        Me.btn_for.Text = "For"
        Me.btn_for.UseVisualStyleBackColor = True
        '
        'btn_go_database
        '
        Me.btn_go_database.Location = New System.Drawing.Point(64, 284)
        Me.btn_go_database.Name = "btn_go_database"
        Me.btn_go_database.Size = New System.Drawing.Size(126, 44)
        Me.btn_go_database.TabIndex = 3
        Me.btn_go_database.Text = "Go Database"
        Me.btn_go_database.UseVisualStyleBackColor = True
        '
        'btn_Exit
        '
        Me.btn_Exit.Location = New System.Drawing.Point(659, 343)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(129, 56)
        Me.btn_Exit.TabIndex = 4
        Me.btn_Exit.Text = "Exit"
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'btn_go_db2
        '
        Me.btn_go_db2.Location = New System.Drawing.Point(64, 346)
        Me.btn_go_db2.Name = "btn_go_db2"
        Me.btn_go_db2.Size = New System.Drawing.Size(126, 40)
        Me.btn_go_db2.TabIndex = 5
        Me.btn_go_db2.Text = "Go Database2"
        Me.btn_go_db2.UseVisualStyleBackColor = True
        '
        'btn_3mdb
        '
        Me.btn_3mdb.Location = New System.Drawing.Point(66, 405)
        Me.btn_3mdb.Name = "btn_3mdb"
        Me.btn_3mdb.Size = New System.Drawing.Size(123, 34)
        Me.btn_3mdb.TabIndex = 6
        Me.btn_3mdb.Text = "3 mdb"
        Me.btn_3mdb.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_3mdb)
        Me.Controls.Add(Me.btn_go_db2)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.btn_go_database)
        Me.Controls.Add(Me.btn_for)
        Me.Controls.Add(Me.tb_input)
        Me.Controls.Add(Me.btn_check)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_check As Button
    Friend WithEvents tb_input As TextBox
    Friend WithEvents btn_for As Button
    Friend WithEvents btn_go_database As Button
    Friend WithEvents btn_Exit As Button
    Friend WithEvents btn_go_db2 As Button
    Friend WithEvents btn_3mdb As Button
End Class
