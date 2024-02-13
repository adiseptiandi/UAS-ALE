Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Drawing.Drawing2D

Public Class Determinan
    Private Sub Determinan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = ""
            End If
        Next
    End Sub
End Class