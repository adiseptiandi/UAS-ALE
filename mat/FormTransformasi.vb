Public Class Transformasi
    'Ketika tombol Transform diklik
    Private Sub Transform_Click(sender As Object, e As EventArgs) Handles Transform.Click
        Dim mat(2, 2) As Integer
        mat(0, 0) = Val(matA1.Text)
        mat(0, 1) = Val(matA2.Text)
        mat(0, 2) = Val(matA3.Text)
        mat(1, 0) = Val(matA4.Text)
        mat(1, 1) = Val(matA5.Text)
        mat(1, 2) = Val(matA6.Text)
        mat(2, 0) = Val(matA7.Text)
        mat(2, 1) = Val(matA8.Text)
        mat(2, 2) = Val(matA9.Text)

        Dim vec(2) As Integer
        vec(0) = Val(vec1.Text)
        vec(1) = Val(vec2.Text)
        vec(2) = Val(vec3.Text)

        ' Panggil fungsi transformasi linier
        Dim transVektor As List(Of Integer) = VektorTransformasiLinier(mat, vec)

        ' Tampilkan hasil transformasi dalam ListBox
        ListBox1.Items.Clear()
        For Each elemen As Integer In transVektor
            ListBox1.Items.Add(elemen)
        Next
    End Sub

    Function VektorTransformasiLinier(matrix As Integer(,), vektorTransformasi As Integer()) As List(Of Integer)
        Dim baris As Integer = matrix.GetLength(0)
        Dim kolom As Integer = matrix.GetLength(1)
        Dim hasil As New List(Of Integer)(baris)

        For i As Integer = 0 To baris - 1
            Dim total As Integer = 0
            For j As Integer = 0 To kolom - 1
                total += matrix(i, j) * vektorTransformasi(j)
            Next
            hasil.Add(total)
        Next

        Return hasil
    End Function
    'Ketika tombol Clear diklik
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
        vec1.Text = ""
        vec2.Text = ""
        vec3.Text = ""
        ListBox1.Items.Clear()
    End Sub
    Private Sub TentangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TentangToolStripMenuItem.Click
        Tentang.Show()
        Me.Hide()
    End Sub
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