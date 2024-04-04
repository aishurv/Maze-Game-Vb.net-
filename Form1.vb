Public Class Form1

    Public Sub New()
        InitializeComponent()
        MoveToStart()
    End Sub
    Private Sub MoveToStart()
        Dim Startingpoint = Panel1.Location()
        Startingpoint.Offset(10, 10)
        Cursor.Position = PointToScreen(Startingpoint)

    End Sub

    Private Sub Label38_Click(sender As Object, e As EventArgs) Handles Label38.Click
        MessageBox.Show("Well done")
        Close()
    End Sub
    

    Private Sub Wall_MouseEnter(sender As Object, e As EventArgs) Handles Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label4.MouseEnter, Label37.MouseEnter, Label36.MouseEnter, Label33.MouseEnter, Label32.MouseEnter, Label30.MouseEnter, Label3.MouseEnter, Label29.MouseEnter, Label28.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label12.MouseEnter, Label10.MouseEnter, Label1.MouseEnter, Label8.MouseClick, Label7.MouseClick, Label6.MouseClick, Label5.MouseClick, Label4.MouseClick, Label37.MouseClick, Label36.MouseClick, Label35.MouseClick, Label33.MouseClick, Label32.MouseClick, Label30.MouseClick, Label29.MouseClick, Label28.MouseClick, Label26.MouseClick, Label25.MouseClick, Label24.MouseClick, Label23.MouseClick, Label22.MouseClick, Label21.MouseClick, Label20.MouseClick, Label19.MouseClick, Label18.MouseClick, Label17.MouseClick, Label16.MouseClick, Label15.MouseClick, Label14.MouseClick, Label12.MouseClick, Label10.MouseClick, Label1.MouseClick
        MoveToStart()
    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs)
        Rules.Show()
    End Sub

    Private Sub ToolStripTextBox2_Click(sender As Object, e As EventArgs)
        Level.Show()
    End Sub

    Private Sub ToolStripTextBox3_Click(sender As Object, e As EventArgs)
        AboutBox1.Show()
    End Sub

    Private Sub ToolStripComboBox1_Click(sender As Object, e As EventArgs)
        LCase(0)
        Level.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Level.Show()

    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        AboutBox1.Show()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Rules.Show()
    End Sub

    Private Sub ToolStripComboBox1_Click_1(sender As Object, e As EventArgs) Handles ToolStripComboBox1.Click
Case1:
        Level.Show()
Case2:
        Level.Show()
Case3:
        Level.Show()
Case4:
        Level.Show()
Case5:
        Level.Show()
Case6:
        Level.Show()


    End Sub


    Private Sub Wall_MouseEnter(sender As Object, e As MouseEventArgs)
        MoveToStart()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub
End Class
