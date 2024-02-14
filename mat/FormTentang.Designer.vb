<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tentang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tentang))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PertambahandanPenguranganDuaMatriks3x3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeterminanMatriks3x3MetodeEkspansiKofaktorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransformasiVektorLinierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KembaliKeMenuUtamaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ubuntu Light", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(92, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(392, 41)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Aplikasi Operasi Matriks"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(109, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Aplikasi ini dibuat oleh:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(572, 28)
        Me.MenuStrip1.TabIndex = 40
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PertambahandanPenguranganDuaMatriks3x3ToolStripMenuItem, Me.DeterminanMatriks3x3MetodeEkspansiKofaktorToolStripMenuItem, Me.TransformasiVektorLinierToolStripMenuItem, Me.KembaliKeMenuUtamaToolStripMenuItem})
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(111, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 120)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Nama" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "NIM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Kelas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Prodi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Matkul" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Dosen" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(192, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(274, 120)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = ": Adi Septiandi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ": 220401010197" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ": IT102" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ": S1 - PJJ Informatika" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ": Aljabar Linea" &
    "r" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ": Fesa Asy Syifa Nurul Haq, S.Kom, MMSI" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(142, 323)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(274, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'Tentang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Tentang"
        Me.Text = "Tentang"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PertambahandanPenguranganDuaMatriks3x3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeterminanMatriks3x3MetodeEkspansiKofaktorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransformasiVektorLinierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KembaliKeMenuUtamaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
