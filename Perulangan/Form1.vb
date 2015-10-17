Public Class Form1

    Private Sub ProblemBintangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProblemBintangToolStripMenuItem.Click
        Star.MdiParent = Me
        Star.Show()
    End Sub

    Private Sub MatriksKalkulatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MatriksKalkulatorToolStripMenuItem.Click
        Matriks.MdiParent = Me
        Matriks.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Environment.Exit(0)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MenuStrip2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip2.ItemClicked

    End Sub
End Class
