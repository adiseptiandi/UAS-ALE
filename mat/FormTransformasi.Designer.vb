<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transformasi
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
        Me.TentangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.matA9 = New System.Windows.Forms.TextBox()
        Me.matA8 = New System.Windows.Forms.TextBox()
        Me.matA7 = New System.Windows.Forms.TextBox()
        Me.matA6 = New System.Windows.Forms.TextBox()
        Me.matA5 = New System.Windows.Forms.TextBox()
        Me.matA4 = New System.Windows.Forms.TextBox()
        Me.matA3 = New System.Windows.Forms.TextBox()
        Me.matA2 = New System.Windows.Forms.TextBox()
        Me.matA1 = New System.Windows.Forms.TextBox()
        Me.vec3 = New System.Windows.Forms.TextBox()
        Me.vec2 = New System.Windows.Forms.TextBox()
        Me.vec1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Transform = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.clear = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.TentangToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(549, 28)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(93, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Matriks"
        '
        'matA9
        '
        Me.matA9.Location = New System.Drawing.Point(155, 215)
        Me.matA9.Name = "matA9"
        Me.matA9.Size = New System.Drawing.Size(46, 27)
        Me.matA9.TabIndex = 50
        '
        'matA8
        '
        Me.matA8.Location = New System.Drawing.Point(103, 215)
        Me.matA8.Name = "matA8"
        Me.matA8.Size = New System.Drawing.Size(46, 27)
        Me.matA8.TabIndex = 49
        '
        'matA7
        '
        Me.matA7.Location = New System.Drawing.Point(51, 215)
        Me.matA7.Name = "matA7"
        Me.matA7.Size = New System.Drawing.Size(46, 27)
        Me.matA7.TabIndex = 48
        '
        'matA6
        '
        Me.matA6.Location = New System.Drawing.Point(155, 182)
        Me.matA6.Name = "matA6"
        Me.matA6.Size = New System.Drawing.Size(46, 27)
        Me.matA6.TabIndex = 47
        '
        'matA5
        '
        Me.matA5.Location = New System.Drawing.Point(103, 182)
        Me.matA5.Name = "matA5"
        Me.matA5.Size = New System.Drawing.Size(46, 27)
        Me.matA5.TabIndex = 46
        '
        'matA4
        '
        Me.matA4.Location = New System.Drawing.Point(51, 182)
        Me.matA4.Name = "matA4"
        Me.matA4.Size = New System.Drawing.Size(46, 27)
        Me.matA4.TabIndex = 45
        '
        'matA3
        '
        Me.matA3.Location = New System.Drawing.Point(155, 149)
        Me.matA3.Name = "matA3"
        Me.matA3.Size = New System.Drawing.Size(46, 27)
        Me.matA3.TabIndex = 44
        '
        'matA2
        '
        Me.matA2.Location = New System.Drawing.Point(103, 149)
        Me.matA2.Name = "matA2"
        Me.matA2.Size = New System.Drawing.Size(46, 27)
        Me.matA2.TabIndex = 43
        '
        'matA1
        '
        Me.matA1.Location = New System.Drawing.Point(51, 149)
        Me.matA1.Name = "matA1"
        Me.matA1.Size = New System.Drawing.Size(46, 27)
        Me.matA1.TabIndex = 42
        '
        'vec3
        '
        Me.vec3.Location = New System.Drawing.Point(241, 215)
        Me.vec3.Name = "vec3"
        Me.vec3.Size = New System.Drawing.Size(46, 27)
        Me.vec3.TabIndex = 54
        '
        'vec2
        '
        Me.vec2.Location = New System.Drawing.Point(241, 182)
        Me.vec2.Name = "vec2"
        Me.vec2.Size = New System.Drawing.Size(46, 27)
        Me.vec2.TabIndex = 53
        '
        'vec1
        '
        Me.vec1.Location = New System.Drawing.Point(241, 149)
        Me.vec1.Name = "vec1"
        Me.vec1.Size = New System.Drawing.Size(46, 27)
        Me.vec1.TabIndex = 52
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(234, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Vektor"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(410, 158)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(91, 84)
        Me.ListBox1.TabIndex = 56
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(434, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 20)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Hasil"
        '
        'Transform
        '
        Me.Transform.Location = New System.Drawing.Point(299, 185)
        Me.Transform.Name = "Transform"
        Me.Transform.Size = New System.Drawing.Size(95, 29)
        Me.Transform.TabIndex = 58
        Me.Transform.Text = "Transform"
        Me.Transform.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ubuntu Light", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(125, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(292, 28)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Transformasi Vektor Linier"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'clear
        '
        Me.clear.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.clear.Location = New System.Drawing.Point(469, 264)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(68, 39)
        Me.clear.TabIndex = 60
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = True
        '
        'Transformasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 315)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Transform)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.vec3)
        Me.Controls.Add(Me.vec2)
        Me.Controls.Add(Me.vec1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.matA9)
        Me.Controls.Add(Me.matA8)
        Me.Controls.Add(Me.matA7)
        Me.Controls.Add(Me.matA6)
        Me.Controls.Add(Me.matA5)
        Me.Controls.Add(Me.matA4)
        Me.Controls.Add(Me.matA3)
        Me.Controls.Add(Me.matA2)
        Me.Controls.Add(Me.matA1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Transformasi"
        Me.Text = "Transformasi Vektor Linier"
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
    Friend WithEvents Label1 As Label
    Friend WithEvents matA9 As TextBox
    Friend WithEvents matA8 As TextBox
    Friend WithEvents matA7 As TextBox
    Friend WithEvents matA6 As TextBox
    Friend WithEvents matA5 As TextBox
    Friend WithEvents matA4 As TextBox
    Friend WithEvents matA3 As TextBox
    Friend WithEvents matA2 As TextBox
    Friend WithEvents matA1 As TextBox
    Friend WithEvents vec3 As TextBox
    Friend WithEvents vec2 As TextBox
    Friend WithEvents vec1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Transform As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents clear As Button
End Class
