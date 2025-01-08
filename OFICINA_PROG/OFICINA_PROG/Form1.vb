Public Class Form1
    Private Sub TiposDeMarcasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeMarcasToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub CarrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarrosToolStripMenuItem.Click
        Me.Hide()
        Form3.Show()
    End Sub
End Class
