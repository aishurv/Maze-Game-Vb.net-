Public Class TM_level3

  
    Public Sub New()
        InitializeComponent()
        MoveToStart()
    End Sub
    Private Sub MoveToStart()
        Dim Startingpoint1 = Panel1.Location()
        Startingpoint1.Offset(10, 10)
        Cursor.Position = PointToScreen(Startingpoint1)
    End Sub
    Private Sub Wall_MouseEnter(sender As Object, e As EventArgs) Handles Label9.MouseMove, Label8.MouseMove, Label7.MouseMove, Label6.MouseMove, Label5.MouseMove, Label4.MouseMove, Label37.MouseMove, Label36.MouseMove, Label35.MouseMove, Label34.MouseMove, Label33.MouseMove, Label32.MouseMove, Label31.MouseMove, Label30.MouseMove, Label3.MouseMove, Label29.MouseMove, Label28.MouseMove, Label27.MouseMove, Label26.MouseMove, Label25.MouseMove, Label24.MouseMove, Label23.MouseMove, Label22.MouseMove, Label21.MouseMove, Label20.MouseMove, Label2.MouseMove, Label19.MouseMove, Label18.MouseMove, Label17.MouseMove, Label16.MouseMove, Label15.MouseMove, Label14.MouseMove, Label13.MouseMove, Label12.MouseMove, Label11.MouseMove, Label10.MouseMove, Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label4.MouseEnter, Label37.MouseEnter, Label36.MouseEnter, Label35.MouseEnter, Label34.MouseEnter, Label33.MouseEnter, Label32.MouseEnter, Label31.MouseEnter, Label30.MouseEnter, Label3.MouseEnter, Label29.MouseEnter, Label28.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label2.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter
        MoveToStart()
    End Sub
    Private Sub Label38_Click(sender As Object, e As EventArgs) Handles Label38.Click
        If (TextBox1.Text < 60) Then
            MessageBox.Show("Congratulations .... You Win Timer Leval 3 ..")
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

End Class