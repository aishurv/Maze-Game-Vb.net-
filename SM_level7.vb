Public Class SM_level7
    Public Sub New()
        InitializeComponent()
        MoveToStart()
    End Sub
    Private Sub MoveToStart()
        Dim Startingpoint = Panel1.Location()
        Startingpoint.Offset(10, 10)
        Cursor.Position = PointToScreen(Startingpoint)

    End Sub

    Private Sub SM_level7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label38_Click(sender As Object, e As EventArgs) Handles Label38.Click
        MessageBox.Show("   .....Congratuations ....You Win Level 7 .. .. ")
    End Sub

    Private Sub Wall_MouseEnter(sender As Object, e As EventArgs) Handles Label9.MouseMove, Label8.MouseMove, Label7.MouseMove, Label63.MouseMove, Label62.MouseMove, Label61.MouseMove, Label60.MouseMove, Label6.MouseMove, Label59.MouseMove, Label58.MouseMove, Label57.MouseMove, Label56.MouseMove, Label55.MouseMove, Label54.MouseMove, Label53.MouseMove, Label52.MouseMove, Label51.MouseMove, Label50.MouseMove, Label5.MouseMove, Label49.MouseMove, Label48.MouseMove, Label47.MouseMove, Label46.MouseMove, Label45.MouseMove, Label44.MouseMove, Label43.MouseMove, Label42.MouseMove, Label41.MouseMove, Label40.MouseMove, Label4.MouseMove, Label37.MouseMove, Label36.MouseMove, Label35.MouseMove, Label34.MouseMove, Label33.MouseMove, Label32.MouseMove, Label31.MouseMove, Label30.MouseMove, Label3.MouseMove, Label29.MouseMove, Label28.MouseMove, Label27.MouseMove, Label26.MouseMove, Label25.MouseMove, Label24.MouseMove, Label23.MouseMove, Label22.MouseMove, Label21.MouseMove, Label20.MouseMove, Label2.MouseMove, Label19.MouseMove, Label18.MouseMove, Label17.MouseMove, Label16.MouseMove, Label15.MouseMove, Label14.MouseMove, Label13.MouseMove, Label12.MouseMove, Label11.MouseMove, Label10.MouseMove, Label1.MouseMove
        MoveToStart()
    End Sub
End Class