Public Class TM_level1
    Public Sub New()
        InitializeComponent()
        MoveToStart()
    End Sub
    Private Sub MoveToStart()
        Dim Startingpoint1 = Panel2.Location()
        Startingpoint1.Offset(10, 10)
        Cursor.Position = PointToScreen(Startingpoint1)
    End Sub
    Private Sub Label46_Click(sender As Object, e As EventArgs) Handles Label46.Click
        Timer1.Enabled = True
        TextBox1.Text = 60
        Timer1.Interval = 600
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox1.Text = TextBox1.Text - 1
        If (TextBox1.Text = 0) Then
            Timer1.Stop()
            MessageBox.Show("Time Up ... Try Again ..")
            TextBox1.Text = 60
            MoveToStart()
        End If
    End Sub

    Private Sub Label47_Click(sender As Object, e As EventArgs) Handles Label47.Click
        If (TextBox1.Text < 60) Then
            MessageBox.Show("Congratulations .... You Win Timer Leval 1 ..")
            Timer1.Stop()
        End If
    End Sub

    Private Sub Label56_Click(sender As Object, e As EventArgs) Handles Label56.Click
        MoveToStart()
    End Sub

    Private Sub Wall_MouseEnter(sender As Object, e As MouseEventArgs) Handles Label68.MouseMove, Label66.MouseMove, Label63.MouseMove, Label62.MouseMove, Label61.MouseMove, Label59.MouseMove, Label58.MouseMove, Label57.MouseMove, Label56.MouseMove, Label55.MouseMove, Label54.MouseMove, Label53.MouseMove, Label52.MouseMove, Label51.MouseMove, Label50.MouseMove, Label49.MouseMove, Label45.MouseMove, Label44.MouseMove, Label43.MouseMove, Label36.MouseMove, Label34.MouseMove, Label29.MouseMove, Label28.MouseMove
        MoveToStart()
    End Sub

    Private Sub Wsll_MouseEnter(sender As Object, e As EventArgs)
        MoveToStart()
    End Sub

    Private Sub Wall_touch(sender As Object, e As EventArgs) Handles Label68.MouseEnter, Label66.MouseEnter, Label63.MouseEnter, Label62.MouseEnter, Label61.MouseEnter, Label59.MouseEnter, Label58.MouseEnter, Label57.MouseEnter, Label56.MouseEnter, Label55.MouseEnter, Label54.MouseEnter, Label53.MouseEnter, Label52.MouseEnter, Label51.MouseEnter, Label50.MouseEnter, Label49.MouseEnter, Label45.MouseEnter, Label44.MouseEnter, Label43.MouseEnter, Label36.MouseEnter, Label34.MouseEnter, Label29.MouseEnter, Label28.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label57_Click(sender As Object, e As EventArgs) Handles Label57.Click
        MoveToStart()
    End Sub

    Private Sub Label28_Click(sender As Object, e As EventArgs) Handles Label28.Click
        MoveToStart()
    End Sub

    Private Sub Label58_Click(sender As Object, e As EventArgs) Handles Label58.Click
        MoveToStart()
    End Sub

    Private Sub Label53_Click(sender As Object, e As EventArgs) Handles Label53.Click
        MoveToStart()
    End Sub

    Private Sub Label59_Click(sender As Object, e As EventArgs) Handles Label59.Click
        MoveToStart()
    End Sub

    Private Sub Label49_Click(sender As Object, e As EventArgs) Handles Label49.Click
        MoveToStart()
    End Sub

    Private Sub Label51_Click(sender As Object, e As EventArgs) Handles Label51.Click
        MoveToStart()
    End Sub

    Private Sub Label62_Click(sender As Object, e As EventArgs) Handles Label62.Click
        MoveToStart()
    End Sub

    Private Sub Label44_Click(sender As Object, e As EventArgs) Handles Label44.Click
        MoveToStart()
    End Sub

    Private Sub Label50_Click(sender As Object, e As EventArgs) Handles Label50.Click
        MoveToStart()
    End Sub

    Private Sub Label43_Click(sender As Object, e As EventArgs) Handles Label43.Click
        MoveToStart()
    End Sub

    Private Sub Label29_Click(sender As Object, e As EventArgs) Handles Label29.Click
        MoveToStart()
    End Sub

    Private Sub Label63_Click(sender As Object, e As EventArgs) Handles Label63.Click
        MoveToStart()
    End Sub

    Private Sub Label36_Click(sender As Object, e As EventArgs) Handles Label36.Click
        MoveToStart()
    End Sub

    Private Sub Label45_Click(sender As Object, e As EventArgs) Handles Label45.Click
        MoveToStart()
    End Sub

    Private Sub Label61_Click(sender As Object, e As EventArgs) Handles Label61.Click
        MoveToStart()
    End Sub

    Private Sub Label34_Click(sender As Object, e As EventArgs) Handles Label34.Click
        MoveToStart()
    End Sub

    Private Sub Label55_Click(sender As Object, e As EventArgs) Handles Label55.Click
        MoveToStart()
    End Sub

    Private Sub Label54_Click(sender As Object, e As EventArgs) Handles Label54.Click
        MoveToStart()
    End Sub

    Private Sub Label68_Click(sender As Object, e As EventArgs) Handles Label68.Click
        MoveToStart()
    End Sub

    Private Sub Label66_Click(sender As Object, e As EventArgs) Handles Label66.Click
        MoveToStart()
    End Sub

    Private Sub Label52_Click(sender As Object, e As EventArgs) Handles Label52.Click
        MoveToStart()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        MoveToStart()
    End Sub
End Class