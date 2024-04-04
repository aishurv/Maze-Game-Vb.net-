Public Class TM_level7
    Public Sub New()
        InitializeComponent()
        MoveToStart()
    End Sub
    Private Sub MoveToStart()
        Dim Startingpoint1 = Panel1.Location()
        Startingpoint1.Offset(10, 10)
        Cursor.Position = PointToScreen(Startingpoint1)
    End Sub
    Private Sub TM_level7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label38_Click(sender As Object, e As EventArgs) Handles Label38.Click
        If (TextBox1.Text < 60) Then
            MessageBox.Show("Congratulations .... You Win Timer Leval 7 ..")
            Timer1.Stop()
        End If
    End Sub

    Private Sub Label39_Click(sender As Object, e As EventArgs) Handles Label39.Click
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

    Private Sub Wall_MouseMove(sender As Object, e As MouseEventArgs) Handles Label9.MouseMove, Label8.MouseMove, Label7.MouseMove, Label64.MouseMove, Label63.MouseMove, Label62.MouseMove, Label61.MouseMove, Label60.MouseMove, Label6.MouseMove, Label59.MouseMove, Label58.MouseMove, Label57.MouseMove, Label56.MouseMove, Label54.MouseMove, Label53.MouseMove, Label52.MouseMove, Label51.MouseMove, Label50.MouseMove, Label5.MouseMove, Label49.MouseMove, Label48.MouseMove, Label47.MouseMove, Label46.MouseMove, Label45.MouseMove, Label44.MouseMove, Label43.MouseMove, Label42.MouseMove, Label41.MouseMove, Label40.MouseMove, Label4.MouseMove, Label37.MouseMove, Label36.MouseMove, Label35.MouseMove, Label34.MouseMove, Label33.MouseMove, Label32.MouseMove, Label31.MouseMove, Label30.MouseMove, Label3.MouseMove, Label29.MouseMove, Label28.MouseMove, Label27.MouseMove, Label26.MouseMove, Label24.MouseMove, Label23.MouseMove, Label22.MouseMove, Label21.MouseMove, Label20.MouseMove, Label2.MouseMove, Label19.MouseMove, Label18.MouseMove, Label17.MouseMove, Label16.MouseMove, Label15.MouseMove, Label14.MouseMove, Label13.MouseMove, Label12.MouseMove, Label11.MouseMove, Label10.MouseMove
        MoveToStart()
    End Sub
End Class