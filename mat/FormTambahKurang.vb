Imports System.Drawing.Drawing2D

Public Class TambahKurang
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hasil1.Enabled = False
        hasil2.Enabled = False
        hasil3.Enabled = False
        hasil4.Enabled = False
        hasil5.Enabled = False
        hasil6.Enabled = False
        hasil7.Enabled = False
        hasil8.Enabled = False
        hasil9.Enabled = False
    End Sub
    Private Sub ProsesOperasi()
        ' Matriks matA
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

        ' Matriks matB
        Dim matB(2, 2) As Integer
        matB(0, 0) = Val(matB1.Text)
        matB(0, 1) = Val(matB2.Text)
        matB(0, 2) = Val(matB3.Text)
        matB(1, 0) = Val(matB4.Text)
        matB(1, 1) = Val(matB5.Text)
        matB(1, 2) = Val(matB6.Text)
        matB(2, 0) = Val(matB7.Text)
        matB(2, 1) = Val(matB8.Text)
        matB(2, 2) = Val(matB9.Text)

        ' Matriks hasil operasi
        Dim hasilMatriks(2, 2) As Integer

        ' Melakukan operasi pertambahan atau pengurangan matriks
        For i As Integer = 0 To matA.GetLength(0) - 1
            For j As Integer = 0 To matA.GetLength(1) - 1
                If ComboBox1.SelectedItem.ToString() = "+" Then
                    hasilMatriks(i, j) = matA(i, j) + matB(i, j)
                ElseIf ComboBox1.SelectedItem.ToString() = "-" Then
                    hasilMatriks(i, j) = matA(i, j) - matB(i, j)
                End If
            Next
        Next

        ' Menampilkan hasil pada TextBox hasil1, hasil2, ..., hasil9
        hasil1.Text = hasilMatriks(0, 0).ToString()
        hasil2.Text = hasilMatriks(0, 1).ToString()
        hasil3.Text = hasilMatriks(0, 2).ToString()
        hasil4.Text = hasilMatriks(1, 0).ToString()
        hasil5.Text = hasilMatriks(1, 1).ToString()
        hasil6.Text = hasilMatriks(1, 2).ToString()
        hasil7.Text = hasilMatriks(2, 0).ToString()
        hasil8.Text = hasilMatriks(2, 1).ToString()
        hasil9.Text = hasilMatriks(2, 2).ToString()
    End Sub

    Private Sub samaDengan_Click(sender As Object, e As EventArgs) Handles samaDengan.Click
        ProsesOperasi()
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = ""
            End If
        Next
        ComboBox1.Text = "Operasi"
    End Sub

    Private Sub KembaliKeMenuUtamaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KembaliKeMenuUtamaToolStripMenuItem.Click
        MenuUtama.Show()
        Me.Hide()
    End Sub
    Private Sub DeterminanMatriks3x3MetodeEkspansiKofaktorToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles DeterminanMatriks3x3MetodeEkspansiKofaktorToolStripMenuItem.Click
        Determinan.Show()
        Me.Hide()
    End Sub
    Private Sub TentangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TentangToolStripMenuItem.Click
        Tentang.Show()
        Me.Hide()
    End Sub
    Private Sub TransformasiVektorLinierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransformasiVektorLinierToolStripMenuItem1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menutup aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
