Public Class SM_level2

    Public Sub New()
        InitializeComponent()
        MoveToStart()
    End Sub
    Private Sub MoveToStart()
        Dim Startingpoint = Panel2.Location()
        Startingpoint.Offset(10, 10)
        Cursor.Position = PointToScreen(Startingpoint)

    End Sub

    Private Sub Wall_MouseEnter(sender As Object, e As EventArgs) Handles Label75.MouseEnter, Label74.MouseEnter, Label73.MouseEnter, Label72.MouseEnter, Label71.MouseEnter, Label70.MouseEnter, Label69.MouseEnter, Label68.MouseEnter, Label67.MouseEnter, Label66.MouseEnter, Label65.MouseEnter, Label64.MouseEnter, Label63.MouseEnter, Label62.MouseEnter, Label61.MouseEnter, Label60.MouseEnter, Label59.MouseEnter, Label58.MouseEnter, Label57.MouseEnter, Label56.MouseEnter, Label55.MouseEnter, Label54.MouseEnter, Label53.MouseEnter, Label50.MouseEnter, Label49.MouseEnter, Label48.MouseEnter, Label47.MouseEnter, Label46.MouseEnter, Label45.MouseEnter, Label44.MouseEnter, Label43.MouseEnter, Label42.MouseEnter, Label41.MouseEnter, Label40.MouseEnter, Label75.MouseMove, Label74.MouseMove, Label73.MouseMove, Label72.MouseMove, Label71.MouseMove, Label70.MouseMove, Label69.MouseMove, Label68.MouseMove, Label67.MouseMove, Label66.MouseMove, Label65.MouseMove, Label64.MouseMove, Label63.MouseMove, Label62.MouseMove, Label61.MouseMove, Label60.MouseMove, Label59.MouseMove, Label58.MouseMove, Label57.MouseMove, Label56.MouseMove, Label55.MouseMove, Label54.MouseMove, Label53.MouseMove, Label50.MouseMove, Label49.MouseMove, Label48.MouseMove, Label47.MouseMove, Label46.MouseMove, Label45.MouseMove, Label44.MouseMove, Label43.MouseMove, Label42.MouseMove, Label41.MouseMove, Label40.MouseMove
        MoveToStart()
    End Sub

    Private Sub Label52_Click(sender As Object, e As EventArgs) Handles Label52.Click
        MessageBox.Show("   .....Congratuations ....You Win Level 2 .. .. ")
    End Sub

End Class