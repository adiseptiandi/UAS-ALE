Public Class Tentang
    Private Sub KembaliKeMenuUtamaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KembaliKeMenuUtamaToolStripMenuItem.Click
        MenuUtama.Show()
        Me.Hide()
    End Sub

    Private Sub DeterminanMatriks3x3MetodeEkspansiKofaktorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeterminanMatriks3x3MetodeEkspansiKofaktorToolStripMenuItem.Click
        Determinan.Show()
        Me.Hide()
    End Sub

    Private Sub PertambahandanPenguranganDuaMatriks3x3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PertambahandanPenguranganDuaMatriks3x3ToolStripMenuItem.Click
        TambahKurang.Show()
        Me.Hide()
    End Sub
    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menutup aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class