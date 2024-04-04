Public Class SM_level9
    Public Sub New()
        InitializeComponent()
        MoveToStart()
    End Sub
    Private Sub MoveToStart()
        Dim Startingpoint = Panel1.Location()
        Startingpoint.Offset(10, 10)
        Cursor.Position = PointToScreen(Startingpoint)

    End Sub

    Private Sub Label38_Click_1(sender As Object, e As EventArgs) Handles Label38.Click, Label81.Click
        MessageBox.Show("   .....Congratuations ....You Win Level 9 .. .. ")
    End Sub

    Private Sub Wall_MouseEnter(sender As Object, e As EventArgs) Handles Label99.MouseEnter, Label98.MouseEnter, Label97.MouseEnter, Label96.MouseEnter, Label95.MouseEnter, Label94.MouseEnter, Label93.MouseEnter, Label92.MouseEnter, Label90.MouseEnter, Label89.MouseEnter, Label87.MouseEnter, Label86.MouseEnter, Label85.MouseEnter, Label84.MouseEnter, Label83.MouseEnter, Label82.MouseEnter, Label79.MouseEnter, Label78.MouseEnter, Label77.MouseEnter, Label76.MouseEnter, Label75.MouseEnter, Label74.MouseEnter, Label73.MouseEnter, Label72.MouseEnter, Label71.MouseEnter, Label70.MouseEnter, Label69.MouseEnter, Label68.MouseEnter, Label67.MouseEnter, Label66.MouseEnter, Label65.MouseEnter, Label64.MouseEnter, Label63.MouseEnter, Label62.MouseEnter, Label61.MouseEnter, Label60.MouseEnter, Label118.MouseEnter, Label117.MouseEnter, Label116.MouseEnter, Label115.MouseEnter, Label114.MouseEnter, Label113.MouseEnter, Label112.MouseEnter, Label111.MouseEnter, Label110.MouseEnter, Label109.MouseEnter, Label108.MouseEnter, Label107.MouseEnter, Label106.MouseEnter, Label105.MouseEnter, Label104.MouseEnter, Label103.MouseEnter, Label102.MouseEnter, Label101.MouseEnter, Label100.MouseEnter, Label99.MouseMove, Label98.MouseMove, Label97.MouseMove, Label96.MouseMove, Label95.MouseMove, Label94.MouseMove, Label93.MouseMove, Label92.MouseMove, Label90.MouseMove, Label89.MouseMove, Label87.MouseMove, Label86.MouseMove, Label85.MouseMove, Label84.MouseMove, Label83.MouseMove, Label82.MouseMove, Label79.MouseMove, Label78.MouseMove, Label77.MouseMove, Label76.MouseMove, Label75.MouseMove, Label74.MouseMove, Label73.MouseMove, Label72.MouseMove, Label71.MouseMove, Label70.MouseMove, Label69.MouseMove, Label68.MouseMove, Label67.MouseMove, Label66.MouseMove, Label65.MouseMove, Label64.MouseMove, Label63.MouseMove, Label62.MouseMove, Label61.MouseMove, Label60.MouseMove, Label118.MouseMove, Label117.MouseMove, Label116.MouseMove, Label115.MouseMove, Label114.MouseMove, Label113.MouseMove, Label112.MouseMove, Label111.MouseMove, Label110.MouseMove, Label109.MouseMove, Label108.MouseMove, Label107.MouseMove, Label106.MouseMove, Label105.MouseMove, Label104.MouseMove, Label103.MouseMove, Label102.MouseMove, Label101.MouseMove, Label100.MouseMove
        MoveToStart()
    End Sub

    Private Sub Wall_MouseEnter(sender As Object, e As MouseEventArgs)
        MoveToStart()
    End Sub
End Class