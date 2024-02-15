<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Determinan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.matA1 = New System.Windows.Forms.TextBox()
        Me.matA2 = New System.Windows.Forms.TextBox()
        Me.matA3 = New System.Windows.Forms.TextBox()
        Me.matA6 = New System.Windows.Forms.TextBox()
        Me.matA5 = New System.Windows.Forms.TextBox()
        Me.matA4 = New System.Windows.Forms.TextBox()
        Me.matA9 = New System.Windows.Forms.TextBox()
        Me.matA8 = New System.Windows.Forms.TextBox()
        Me.matA7 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.hasilDetA = New System.Windows.Forms.TextBox()
        Me.detA = New System.Windows.Forms.Button()
        Me.clear = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PertambahandanPenguranganDuaMatriks3x3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransformasiVektorLinierToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.KembaliKeMenuUtamaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TentangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'matA1
        '
        Me.matA1.Location = New System.Drawing.Point(138, 175)
        Me.matA1.Name = "matA1"
        Me.matA1.Size = New System.Drawing.Size(46, 27)
        Me.matA1.TabIndex = 0
        '
        'matA2
        '
        Me.matA2.Location = New System.Drawing.Point(190, 175)
        Me.matA2.Name = "matA2"
        Me.matA2.Size = New System.Drawing.Size(46, 27)
        Me.matA2.TabIndex = 1
        '
        'matA3
        '
        Me.matA3.Location = New System.Drawing.Point(242, 175)
        Me.matA3.Name = "matA3"
        Me.matA3.Size = New System.Drawing.Size(46, 27)
        Me.matA3.TabIndex = 2
        '
        'matA6
        '
        Me.matA6.Location = New System.Drawing.Point(242, 208)
        Me.matA6.Name = "matA6"
        Me.matA6.Size = New System.Drawing.Size(46, 27)
        Me.matA6.TabIndex = 5
        '
        'matA5
        '
        Me.matA5.Location = New System.Drawing.Point(190, 208)
        Me.matA5.Name = "matA5"
        Me.matA5.Size = New System.Drawing.Size(46, 27)
        Me.matA5.TabIndex = 4
        '
        'matA4
        '
        Me.matA4.Location = New System.Drawing.Point(138, 208)
        Me.matA4.Name = "matA4"
        Me.matA4.Size = New System.Drawing.Size(46, 27)
        Me.matA4.TabIndex = 3
        '
        'matA9
        '
        Me.matA9.Location = New System.Drawing.Point(242, 241)
        Me.matA9.Name = "matA9"
        Me.matA9.Size = New System.Drawing.Size(46, 27)
        Me.matA9.TabIndex = 8
        '
        'matA8
        '
        Me.matA8.Location = New System.Drawing.Point(190, 241)
        Me.matA8.Name = "matA8"
        Me.matA8.Size = New System.Drawing.Size(46, 27)
        Me.matA8.TabIndex = 7
        '
        'matA7
        '
        Me.matA7.Location = New System.Drawing.Point(138, 241)
        Me.matA7.Name = "matA7"
        Me.matA7.Size = New System.Drawing.Size(46, 27)
        Me.matA7.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(180, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Matriks A"
        '
        'hasilDetA
        '
        Me.hasilDetA.Location = New System.Drawing.Point(164, 331)
        Me.hasilDetA.Multiline = True
        Me.hasilDetA.Name = "hasilDetA"
        Me.hasilDetA.Size = New System.Drawing.Size(100, 33)
        Me.hasilDetA.TabIndex = 33
        '
        'detA
        '
        Me.detA.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.detA.Location = New System.Drawing.Point(180, 286)
        Me.detA.Name = "detA"
        Me.detA.Size = New System.Drawing.Size(68, 39)
        Me.detA.TabIndex = 35
        Me.detA.Text = "det(A)"
        Me.detA.UseVisualStyleBackColor = True
        '
        'clear
        '
        Me.clear.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.clear.Location = New System.Drawing.Point(382, 359)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(68, 39)
        Me.clear.TabIndex = 37
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.TentangToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(462, 28)
        Me.MenuStrip1.TabIndex = 40
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PertambahandanPenguranganDuaMatriks3x3ToolStripMenuItem, Me.TransformasiVektorLinierToolStripMenuItem1, Me.KembaliKeMenuUtamaToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(60, 24)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'PertambahandanPenguranganDuaMatriks3x3ToolStripMenuItem
        '
        Me.PertambahandanPenguranganDuaMatriks3x3ToolStripMenuItem.Name = "PertambahandanPenguranganDuaMatriks3x3ToolStripMenuItem"
        Me.PertambahandanPenguranganDuaMatriks3x3ToolStripMenuItem.Size = New System.Drawing.Size(408, 26)
        Me.PertambahandanPenguranganDuaMatriks3x3ToolStripMenuItem.Text = "Pertambahan dan Pengurangan Dua Matriks 3x3"
        '
        'TransformasiVektorLinierToolStripMenuItem1
        '
        Me.TransformasiVektorLinierToolStripMenuItem1.Name = "TransformasiVektorLinierToolStripMenuItem1"
        Me.TransformasiVektorLinierToolStripMenuItem1.Size = New System.Drawing.Size(408, 26)
        Me.TransformasiVektorLinierToolStripMenuItem1.Text = "Transformasi Vektor Linier"
        '
        'KembaliKeMenuUtamaToolStripMenuItem
        '
        Me.KembaliKeMenuUtamaToolStripMenuItem.Name = "KembaliKeMenuUtamaToolStripMenuItem"
        Me.KembaliKeMenuUtamaToolStripMenuItem.Size = New System.Drawing.Size(408, 26)
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ubuntu Light", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(83, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(294, 56)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Determinan Matriks 3x3 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Metode Ekspansi Kofaktor"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Determinan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 410)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.detA)
        Me.Controls.Add(Me.hasilDetA)
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
        Me.Name = "Determinan"
        Me.Text = "Determinan Ekspansi Kofaktor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents matA1 As TextBox
    Friend WithEvents matA2 As TextBox
    Friend WithEvents matA3 As TextBox
    Friend WithEvents matA6 As TextBox
    Friend WithEvents matA5 As TextBox
    Friend WithEvents matA4 As TextBox
    Friend WithEvents matA9 As TextBox
    Friend WithEvents matA8 As TextBox
    Friend WithEvents matA7 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents hasilDetA As TextBox
    Friend WithEvents detA As Button
    Friend WithEvents clear As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KembaliKeMenuUtamaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PertambahandanPenguranganDuaMatriks3x3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransformasiVektorLinierToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TentangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label4 As Label
End Class
