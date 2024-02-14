<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUtama
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnTambahKurang = New System.Windows.Forms.Button()
        Me.BtnDeterminan = New System.Windows.Forms.Button()
        Me.BtnVector = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PertambahandanPenguranganDuaMatriks3x3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeterminanMatriks3x3MetodeEkspansiKofaktorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransformasiVektorLinierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TentangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ubuntu Light", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(206, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(392, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Aplikasi Operasi Matriks"
        '
        'BtnTambahKurang
        '
        Me.BtnTambahKurang.Location = New System.Drawing.Point(237, 134)
        Me.BtnTambahKurang.Name = "BtnTambahKurang"
        Me.BtnTambahKurang.Size = New System.Drawing.Size(330, 76)
        Me.BtnTambahKurang.TabIndex = 1
        Me.BtnTambahKurang.Text = "Pertambahan dan Pengurangan Dua Matriks 3x3"
        Me.BtnTambahKurang.UseVisualStyleBackColor = True
        '
        'BtnDeterminan
        '
        Me.BtnDeterminan.Location = New System.Drawing.Point(237, 229)
        Me.BtnDeterminan.Name = "BtnDeterminan"
        Me.BtnDeterminan.Size = New System.Drawing.Size(330, 76)
        Me.BtnDeterminan.TabIndex = 2
        Me.BtnDeterminan.Text = "Determinan Matriks 3x3 Metode Ekspansi Kofaktor"
        Me.BtnDeterminan.UseVisualStyleBackColor = True
        '
        'BtnVector
        '
        Me.BtnVector.Location = New System.Drawing.Point(237, 326)
        Me.BtnVector.Name = "BtnVector"
        Me.BtnVector.Size = New System.Drawing.Size(330, 76)
        Me.BtnVector.TabIndex = 3
        Me.BtnVector.Text = "Transformasi Vektor Linier"
        Me.BtnVector.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.TentangToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 39
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PertambahandanPenguranganDuaMatriks3x3ToolStripMenuItem, Me.DeterminanMatriks3x3MetodeEkspansiKofaktorToolStripMenuItem, Me.TransformasiVektorLinierToolStripMenuItem})
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
        'TransformasiVektorLinierToolStripMenuItem
        '
        Me.TransformasiVektorLinierToolStripMenuItem.Name = "TransformasiVektorLinierToolStripMenuItem"
        Me.TransformasiVektorLinierToolStripMenuItem.Size = New System.Drawing.Size(426, 26)
        Me.TransformasiVektorLinierToolStripMenuItem.Text = "Transformasi Vektor Linier"
        '
        'TentangToolStripMenuItem
        '
        Me.TentangToolStripMenuItem.Name = "TentangToolStripMenuItem"
        Me.TentangToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.TentangToolStripMenuItem.Text = "Tentang"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(65, 24)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.BtnVector)
        Me.Controls.Add(Me.BtnDeterminan)
        Me.Controls.Add(Me.BtnTambahKurang)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MenuUtama"
        Me.Text = "Aplikasi Operasi Matriks"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnTambahKurang As Button
    Friend WithEvents BtnDeterminan As Button
    Friend WithEvents BtnVector As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PertambahandanPenguranganDuaMatriks3x3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeterminanMatriks3x3MetodeEkspansiKofaktorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransformasiVektorLinierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TentangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
End Class
