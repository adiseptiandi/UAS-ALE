<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PertambahandanPenguranganDuaMatriks3x3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeterminanMatriks3x3MetodeEkspansiKofaktorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KembaliKeMenuUtamaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TentangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.TentangToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 41
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PertambahandanPenguranganDuaMatriks3x3ToolStripMenuItem, Me.DeterminanMatriks3x3MetodeEkspansiKofaktorToolStripMenuItem, Me.KembaliKeMenuUtamaToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(60, 24)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'PertambahandanPenguranganDuaMatriks3x3ToolStripMenuItem
        '
        Me.PertambahandanPenguranganDuaMatriks3x3ToolStripMenuItem.Name = "PertambahandanPenguranganDuaMatriks3x3ToolStripMenuItem"
        Me.PertambahandanPenguranganDuaMatriks3x3ToolStripMenuItem.Size = New System.Drawing.Size(426, 26)
        Me.PertambahandanPenguranganDuaMatriks3x3ToolStripMenuItem.Text = "Pertambahan dan Pengurangan Dua Matriks 3x3"
        '
        'DeterminanMatriks3x3MetodeEkspansiKofaktorToolStripMenuItem
        '
        Me.DeterminanMatriks3x3MetodeEkspansiKofaktorToolStripMenuItem.Name = "DeterminanMatriks3x3MetodeEkspansiKofaktorToolStripMenuItem"
        Me.DeterminanMatriks3x3MetodeEkspansiKofaktorToolStripMenuItem.Size = New System.Drawing.Size(426, 26)
        Me.DeterminanMatriks3x3MetodeEkspansiKofaktorToolStripMenuItem.Text = "Determinan Matriks 3x3 Metode Ekspansi Kofaktor"
        '
        'KembaliKeMenuUtamaToolStripMenuItem
        '
        Me.KembaliKeMenuUtamaToolStripMenuItem.Name = "KembaliKeMenuUtamaToolStripMenuItem"
        Me.KembaliKeMenuUtamaToolStripMenuItem.Size = New System.Drawing.Size(426, 26)
        Me.KembaliKeMenuUtamaToolStripMenuItem.Text = "Kembali ke menu utama"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(65, 24)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'TentangToolStripMenuItem
        '
        Me.TentangToolStripMenuItem.Name = "TentangToolStripMenuItem"
        Me.TentangToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.TentangToolStripMenuItem.Text = "Tentang"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PertambahandanPenguranganDuaMatriks3x3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeterminanMatriks3x3MetodeEkspansiKofaktorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KembaliKeMenuUtamaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TentangToolStripMenuItem As ToolStripMenuItem
End Class
