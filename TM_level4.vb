Public Class TM_level4
    Public Sub New()
        InitializeComponent()
        MoveToStart()
    End Sub
    Private Sub MoveToStart()
        Dim Startingpoint1 = Panel2.Location()
        Startingpoint1.Offset(10, 10)
        Cursor.Position = PointToScreen(Startingpoint1)
    End Sub

    Private Sub TM_level4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label45_Click(sender As Object, e As EventArgs) Handles Label45.Click
        If (TextBox1.Text < 60) Then
            MessageBox.Show("Congratulations .... You Win Timer Leval 4 ..")
            Timer1.Stop()
        End If
    End Sub

    Private Sub Label44_Click(sender As Object, e As EventArgs) Handles Label44.Click
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Wall_MouseMove(sender As Object, e As MouseEventArgs) Handles Label82.MouseMove, Label81.MouseMove, Label80.MouseMove, Label79.MouseMove, Label78.MouseMove, Label77.MouseMove, Label76.MouseMove, Label75.MouseMove, Label74.MouseMove, Label73.MouseMove, Label72.MouseMove, Label71.MouseMove, Label70.MouseMove, Label69.MouseMove, Label68.MouseMove, Label67.MouseMove, Label66.MouseMove, Label65.MouseMove, Label64.MouseMove, Label63.MouseMove, Label62.MouseMove, Label61.MouseMove, Label60.MouseMove, Label59.MouseMove, Label57.MouseMove, Label56.MouseMove, Label54.MouseMove, Label53.MouseMove, Label52.MouseMove, Label51.MouseMove, Label50.MouseMove, Label49.MouseMove, Label48.MouseMove, Label47.MouseMove, Label46.MouseMove, Label43.MouseMove, Label42.MouseMove
        MoveToStart()
    End Sub
End Class