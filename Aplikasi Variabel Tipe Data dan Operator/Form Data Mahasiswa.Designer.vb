<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Data_Mahasiswa
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
        Me.BSimpan = New System.Windows.Forms.Button()
        Me.TbNIRM = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbKelas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LvTabelMahasiswa = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BHapusTerpilih = New System.Windows.Forms.Button()
        Me.BHapusSemua = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BSimpan
        '
        Me.BSimpan.Font = New System.Drawing.Font("Mongolian Baiti", 32.0!, System.Drawing.FontStyle.Bold)
        Me.BSimpan.Location = New System.Drawing.Point(254, 322)
        Me.BSimpan.Name = "BSimpan"
        Me.BSimpan.Size = New System.Drawing.Size(262, 90)
        Me.BSimpan.TabIndex = 26
        Me.BSimpan.Text = "Simpan"
        Me.BSimpan.UseVisualStyleBackColor = True
        '
        'TbNIRM
        '
        Me.TbNIRM.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbNIRM.Location = New System.Drawing.Point(254, 16)
        Me.TbNIRM.Name = "TbNIRM"
        Me.TbNIRM.Size = New System.Drawing.Size(430, 77)
        Me.TbNIRM.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 64)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "NIRM :"
        '
        'TbNama
        '
        Me.TbNama.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbNama.Location = New System.Drawing.Point(254, 118)
        Me.TbNama.Name = "TbNama"
        Me.TbNama.Size = New System.Drawing.Size(884, 77)
        Me.TbNama.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 64)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Nama :"
        '
        'TbKelas
        '
        Me.TbKelas.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbKelas.Location = New System.Drawing.Point(254, 226)
        Me.TbKelas.Name = "TbKelas"
        Me.TbKelas.Size = New System.Drawing.Size(296, 77)
        Me.TbKelas.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(49, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 64)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Kelas :"
        '
        'LvTabelMahasiswa
        '
        Me.LvTabelMahasiswa.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.LvTabelMahasiswa.Font = New System.Drawing.Font("Mongolian Baiti", 32.0!, System.Drawing.FontStyle.Bold)
        Me.LvTabelMahasiswa.FullRowSelect = True
        Me.LvTabelMahasiswa.GridLines = True
        Me.LvTabelMahasiswa.Location = New System.Drawing.Point(12, 439)
        Me.LvTabelMahasiswa.Name = "LvTabelMahasiswa"
        Me.LvTabelMahasiswa.Size = New System.Drawing.Size(982, 284)
        Me.LvTabelMahasiswa.TabIndex = 33
        Me.LvTabelMahasiswa.UseCompatibleStateImageBehavior = False
        Me.LvTabelMahasiswa.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "NIRM"
        Me.ColumnHeader1.Width = 196
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama"
        Me.ColumnHeader2.Width = 424
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Kelas"
        Me.ColumnHeader3.Width = 271
        '
        'BHapusTerpilih
        '
        Me.BHapusTerpilih.Font = New System.Drawing.Font("Mongolian Baiti", 32.0!, System.Drawing.FontStyle.Bold)
        Me.BHapusTerpilih.Location = New System.Drawing.Point(997, 439)
        Me.BHapusTerpilih.Name = "BHapusTerpilih"
        Me.BHapusTerpilih.Size = New System.Drawing.Size(267, 141)
        Me.BHapusTerpilih.TabIndex = 34
        Me.BHapusTerpilih.Text = "Hapus Terpilih"
        Me.BHapusTerpilih.UseVisualStyleBackColor = True
        '
        'BHapusSemua
        '
        Me.BHapusSemua.Font = New System.Drawing.Font("Mongolian Baiti", 32.0!, System.Drawing.FontStyle.Bold)
        Me.BHapusSemua.Location = New System.Drawing.Point(1000, 586)
        Me.BHapusSemua.Name = "BHapusSemua"
        Me.BHapusSemua.Size = New System.Drawing.Size(267, 141)
        Me.BHapusSemua.TabIndex = 34
        Me.BHapusSemua.Text = "Hapus Semua"
        Me.BHapusSemua.UseVisualStyleBackColor = True
        '
        'Form_Data_Mahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 735)
        Me.Controls.Add(Me.BHapusSemua)
        Me.Controls.Add(Me.BHapusTerpilih)
        Me.Controls.Add(Me.LvTabelMahasiswa)
        Me.Controls.Add(Me.TbKelas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TbNama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TbNIRM)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BSimpan)
        Me.Name = "Form_Data_Mahasiswa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Data Mahasiswa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BSimpan As System.Windows.Forms.Button
    Friend WithEvents TbNIRM As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TbNama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TbKelas As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LvTabelMahasiswa As System.Windows.Forms.ListView
    Friend WithEvents BHapusTerpilih As System.Windows.Forms.Button
    Friend WithEvents BHapusSemua As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
End Class
