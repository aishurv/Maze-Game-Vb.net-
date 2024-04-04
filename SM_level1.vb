Public Class SM_level1
    Public Sub New()
        InitializeComponent()
        MoveToStart()
    End Sub
    Private Sub MoveToStart()
        Dim Startingpoint1 = Panel2.Location()
        Startingpoint1.Offset(10, 10)
        Cursor.Position = PointToScreen(Startingpoint1)
    End Sub
    

    Private Sub Label47_Click(sender As Object, e As EventArgs) Handles Label47.Click
        MessageBox.Show("   .....Congratuations ....You Win Level 1 .. .. ")
    End Sub

    Private Sub Wall_MouseEnter(sender As Object, e As EventArgs) Handles Label68.MouseEnter, Label68.MouseClick, Label66.MouseEnter, Label66.MouseClick, Label63.MouseEnter, Label63.MouseClick, Label62.MouseEnter, Label62.MouseClick, Label61.MouseEnter, Label61.MouseClick, Label59.MouseEnter, Label59.MouseClick, Label58.MouseEnter, Label58.MouseClick, Label57.MouseEnter, Label57.MouseClick, Label56.MouseEnter, Label56.MouseClick, Label55.MouseEnter, Label55.MouseClick, Label54.MouseEnter, Label54.MouseClick, Label53.MouseEnter, Label53.MouseClick, Label52.MouseEnter, Label52.MouseClick, Label51.MouseEnter, Label51.MouseClick, Label50.MouseEnter, Label50.MouseClick, Label49.MouseEnter, Label49.MouseClick, Label45.MouseEnter, Label45.MouseClick, Label44.MouseEnter, Label44.MouseClick, Label43.MouseEnter, Label43.MouseClick, Label36.MouseEnter, Label36.MouseClick, Label34.MouseEnter, Label34.MouseClick, Label29.MouseEnter, Label29.MouseClick, Label28.MouseEnter, Label28.MouseClick
        MoveToStart()
    End Sub

    
End Class