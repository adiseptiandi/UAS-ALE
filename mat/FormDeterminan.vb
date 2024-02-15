Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Drawing.Drawing2D

Public Class Determinan
    Private Sub Determinan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hasilDetA.Enabled = False
    End Sub
    Private Sub detA_Click(sender As Object, e As EventArgs) Handles detA.Click
        Dim matA(2, 2) As Integer
        matA(0, 0) = Val(matA1.Text)
        matA(0, 1) = Val(matA2.Text)
        matA(0, 2) = Val(matA3.Text)
        matA(1, 0) = Val(matA4.Text)
        matA(1, 1) = Val(matA5.Text)
        matA(1, 2) = Val(matA6.Text)
        matA(2, 0) = Val(matA7.Text)
        matA(2, 1) = Val(matA8.Text)
        matA(2, 2) = Val(matA9.Text)

        Dim determinanA As Integer = (matA(0, 0) * 1 * (matA(1, 1) * matA(2, 2) - matA(1, 2) * matA(2, 1))) + (matA(0, 1) * -1 * (matA(1, 0) * matA(2, 2) - matA(1, 2) * matA(2, 0))) + (matA(0, 2) * 1 * (matA(1, 0) * matA(2, 1) - matA(1, 1) * matA(2, 0)))
        hasilDetA.Text = determinanA.ToString()
    End Sub
    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        matA1.Text = ""
        matA2.Text = ""
        matA3.Text = ""
        matA4.Text = ""
        matA5.Text = ""
        matA6.Text = ""
        matA7.Text = ""
        matA8.Text = ""
        matA9.Text = ""
        hasilDetA.Text = ""
    End Sub
    Private Sub KembaliKeMenuUtamaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KembaliKeMenuUtamaToolStripMenuItem.Click
        MenuUtama.Show()
        Me.Hide()
    End Sub

    Private Sub PertambahandanPenguranganDuaMatriks3x3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PertambahandanPenguranganDuaMatriks3x3ToolStripMenuItem.Click
        TambahKurang.Show()
        Me.Hide()
    End Sub

    Private Sub TentangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TentangToolStripMenuItem.Click
        Tentang.Show()
        Me.Hide()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menutup aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class