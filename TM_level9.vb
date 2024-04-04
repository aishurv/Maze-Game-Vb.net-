Public Class TM_level9

    Private Sub Wall_MouseEnter(sender As Object, e As EventArgs) Handles Panel2.MouseEnter, Panel1.MouseEnter, Label99.MouseEnter, Label98.MouseEnter, Label97.MouseEnter, Label96.MouseEnter, Label95.MouseEnter, Label94.MouseEnter, Label93.MouseEnter, Label92.MouseEnter, Label91.MouseEnter, Label90.MouseEnter, Label9.MouseEnter, Label89.MouseEnter, Label88.MouseEnter, Label87.MouseEnter, Label86.MouseEnter, Label85.MouseEnter, Label84.MouseEnter, Label83.MouseEnter, Label82.MouseEnter, Label81.MouseEnter, Label80.MouseEnter, Label8.MouseEnter, Label79.MouseEnter, Label78.MouseEnter, Label77.MouseEnter, Label76.MouseEnter, Label75.MouseEnter, Label74.MouseEnter, Label73.MouseEnter, Label72.MouseEnter, Label71.MouseEnter, Label70.MouseEnter, Label7.MouseEnter, Label69.MouseEnter, Label68.MouseEnter, Label67.MouseEnter, Label66.MouseEnter, Label65.MouseEnter, Label64.MouseEnter, Label63.MouseEnter, Label62.MouseEnter, Label61.MouseEnter, Label60.MouseEnter, Label6.MouseEnter, Label59.MouseEnter, Label58.MouseEnter, Label57.MouseEnter, Label56.MouseEnter, Label55.MouseEnter, Label54.MouseEnter, Label53.MouseEnter, Label52.MouseEnter, Label51.MouseEnter, Label50.MouseEnter, Label5.MouseEnter, Label49.MouseEnter, Label48.MouseEnter, Label47.MouseEnter, Label46.MouseEnter, Label45.MouseEnter, Label44.MouseEnter, Label43.MouseEnter, Label42.MouseEnter, Label41.MouseEnter, Label40.MouseEnter, Label4.MouseEnter, Label39.MouseEnter, Label38.MouseEnter, Label37.MouseEnter, Label36.MouseEnter, Label35.MouseEnter, Label34.MouseEnter, Label33.MouseEnter, Label32.MouseEnter, Label31.MouseEnter, Label30.MouseEnter, Label3.MouseEnter, Label29.MouseEnter, Label28.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label2.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label119.MouseEnter, Label118.MouseEnter, Label117.MouseEnter, Label116.MouseEnter, Label115.MouseEnter, Label114.MouseEnter, Label113.MouseEnter, Label112.MouseEnter, Label111.MouseEnter, Label110.MouseEnter, Label11.MouseEnter, Label109.MouseEnter, Label108.MouseEnter, Label107.MouseEnter, Label106.MouseEnter, Label105.MouseEnter, Label104.MouseEnter, Label103.MouseEnter, Label102.MouseEnter, Label101.MouseEnter, Label100.MouseEnter, Label10.MouseEnter, Panel2.MouseMove, Panel1.MouseMove, Label99.MouseMove, Label98.MouseMove, Label97.MouseMove, Label96.MouseMove, Label95.MouseMove, Label94.MouseMove, Label93.MouseMove, Label92.MouseMove, Label91.MouseMove, Label90.MouseMove, Label9.MouseMove, Label89.MouseMove, Label88.MouseMove, Label87.MouseMove, Label86.MouseMove, Label85.MouseMove, Label84.MouseMove, Label83.MouseMove, Label82.MouseMove, Label81.MouseMove, Label80.MouseMove, Label8.MouseMove, Label79.MouseMove, Label78.MouseMove, Label77.MouseMove, Label76.MouseMove, Label75.MouseMove, Label74.MouseMove, Label73.MouseMove, Label72.MouseMove, Label71.MouseMove, Label70.MouseMove, Label7.MouseMove, Label69.MouseMove, Label68.MouseMove, Label67.MouseMove, Label66.MouseMove, Label65.MouseMove, Label64.MouseMove, Label63.MouseMove, Label62.MouseMove, Label61.MouseMove, Label60.MouseMove, Label6.MouseMove, Label59.MouseMove, Label58.MouseMove, Label57.MouseMove, Label56.MouseMove, Label55.MouseMove, Label54.MouseMove, Label53.MouseMove, Label52.MouseMove, Label51.MouseMove, Label50.MouseMove, Label5.MouseMove, Label49.MouseMove, Label48.MouseMove, Label47.MouseMove, Label46.MouseMove, Label45.MouseMove, Label44.MouseMove, Label43.MouseMove, Label42.MouseMove, Label41.MouseMove, Label40.MouseMove, Label4.MouseMove, Label39.MouseMove, Label38.MouseMove, Label37.MouseMove, Label36.MouseMove, Label35.MouseMove, Label34.MouseMove, Label33.MouseMove, Label32.MouseMove, Label31.MouseMove, Label30.MouseMove, Label3.MouseMove, Label29.MouseMove, Label28.MouseMove, Label27.MouseMove, Label26.MouseMove, Label25.MouseMove, Label24.MouseMove, Label23.MouseMove, Label21.MouseMove, Label20.MouseMove, Label2.MouseMove, Label19.MouseMove, Label18.MouseMove, Label17.MouseMove, Label16.MouseMove, Label15.MouseMove, Label14.MouseMove, Label13.MouseMove, Label12.MouseMove, Label119.MouseMove, Label118.MouseMove, Label117.MouseMove, Label116.MouseMove, Label115.MouseMove, Label114.MouseMove, Label113.MouseMove, Label112.MouseMove, Label111.MouseMove, Label110.MouseMove, Label11.MouseMove, Label109.MouseMove, Label108.MouseMove, Label107.MouseMove, Label106.MouseMove, Label105.MouseMove, Label104.MouseMove, Label103.MouseMove, Label102.MouseMove, Label101.MouseMove, Label100.MouseMove, Label10.MouseMove
        MoveToStart()
    End Sub

    Public Sub New()
        InitializeComponent()
        MoveToStart()
    End Sub
    Private Sub MoveToStart()
        Dim Startingpoint1 = Panel2.Location()
        Startingpoint1.Offset(10, 10)
        Cursor.Position = PointToScreen(Startingpoint1)
    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click
        If (TextBox1.Text < 60) Then
            MessageBox.Show("Congratulations .... You Win Timer Leval 9 ..")
            Timer1.Stop()
        End If
    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs)
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