<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class data_dosen
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
        Me.BHapusSemua = New System.Windows.Forms.Button()
        Me.BHapusTerpilih = New System.Windows.Forms.Button()
        Me.LvTabeldosen = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TbProdi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbNamaDosen = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbNIDN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BSimpan = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbPengalaman = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Bhitunggaji = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Tbgaji = New System.Windows.Forms.TextBox()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'BHapusSemua
        '
        Me.BHapusSemua.Font = New System.Drawing.Font("Mongolian Baiti", 32.0!, System.Drawing.FontStyle.Bold)
        Me.BHapusSemua.Location = New System.Drawing.Point(1010, 727)
        Me.BHapusSemua.Margin = New System.Windows.Forms.Padding(2)
        Me.BHapusSemua.Name = "BHapusSemua"
        Me.BHapusSemua.Size = New System.Drawing.Size(200, 115)
        Me.BHapusSemua.TabIndex = 43
        Me.BHapusSemua.Text = "Hapus Semua"
        Me.BHapusSemua.UseVisualStyleBackColor = True
        '
        'BHapusTerpilih
        '
        Me.BHapusTerpilih.Font = New System.Drawing.Font("Mongolian Baiti", 32.0!, System.Drawing.FontStyle.Bold)
        Me.BHapusTerpilih.Location = New System.Drawing.Point(1010, 608)
        Me.BHapusTerpilih.Margin = New System.Windows.Forms.Padding(2)
        Me.BHapusTerpilih.Name = "BHapusTerpilih"
        Me.BHapusTerpilih.Size = New System.Drawing.Size(200, 115)
        Me.BHapusTerpilih.TabIndex = 44
        Me.BHapusTerpilih.Text = "Hapus Terpilih"
        Me.BHapusTerpilih.UseVisualStyleBackColor = True
        '
        'LvTabeldosen
        '
        Me.LvTabeldosen.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader4})
        Me.LvTabeldosen.Font = New System.Drawing.Font("Mongolian Baiti", 32.0!, System.Drawing.FontStyle.Bold)
        Me.LvTabeldosen.FullRowSelect = True
        Me.LvTabeldosen.GridLines = True
        Me.LvTabeldosen.Location = New System.Drawing.Point(61, 610)
        Me.LvTabeldosen.Margin = New System.Windows.Forms.Padding(2)
        Me.LvTabeldosen.Name = "LvTabeldosen"
        Me.LvTabeldosen.Size = New System.Drawing.Size(929, 232)
        Me.LvTabeldosen.TabIndex = 42
        Me.LvTabeldosen.UseCompatibleStateImageBehavior = False
        Me.LvTabeldosen.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "NIDN"
        Me.ColumnHeader1.Width = 143
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama Dosen"
        Me.ColumnHeader2.Width = 247
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Prodi"
        Me.ColumnHeader3.Width = 127
        '
        'TbProdi
        '
        Me.TbProdi.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbProdi.Location = New System.Drawing.Point(364, 194)
        Me.TbProdi.Margin = New System.Windows.Forms.Padding(2)
        Me.TbProdi.Name = "TbProdi"
        Me.TbProdi.Size = New System.Drawing.Size(223, 63)
        Me.TbProdi.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(57, 197)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 50)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Prodi :"
        '
        'TbNamaDosen
        '
        Me.TbNamaDosen.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbNamaDosen.Location = New System.Drawing.Point(364, 118)
        Me.TbNamaDosen.Margin = New System.Windows.Forms.Padding(2)
        Me.TbNamaDosen.Name = "TbNamaDosen"
        Me.TbNamaDosen.Size = New System.Drawing.Size(664, 63)
        Me.TbNamaDosen.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 121)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(308, 50)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Nama  Dosen:"
        '
        'TbNIDN
        '
        Me.TbNIDN.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbNIDN.Location = New System.Drawing.Point(364, 35)
        Me.TbNIDN.Margin = New System.Windows.Forms.Padding(2)
        Me.TbNIDN.Name = "TbNIDN"
        Me.TbNIDN.Size = New System.Drawing.Size(324, 63)
        Me.TbNIDN.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 50)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "NIDN"
        '
        'BSimpan
        '
        Me.BSimpan.Font = New System.Drawing.Font("Mongolian Baiti", 32.0!, System.Drawing.FontStyle.Bold)
        Me.BSimpan.Location = New System.Drawing.Point(364, 531)
        Me.BSimpan.Margin = New System.Windows.Forms.Padding(2)
        Me.BSimpan.Name = "BSimpan"
        Me.BSimpan.Size = New System.Drawing.Size(196, 73)
        Me.BSimpan.TabIndex = 35
        Me.BSimpan.Text = "Simpan"
        Me.BSimpan.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(52, 302)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(279, 50)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Pengalaman:"
        '
        'TbPengalaman
        '
        Me.TbPengalaman.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbPengalaman.Location = New System.Drawing.Point(364, 299)
        Me.TbPengalaman.Margin = New System.Windows.Forms.Padding(2)
        Me.TbPengalaman.Name = "TbPengalaman"
        Me.TbPengalaman.Size = New System.Drawing.Size(223, 63)
        Me.TbPengalaman.TabIndex = 46
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(618, 302)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 50)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Tahun"
        '
        'Bhitunggaji
        '
        Me.Bhitunggaji.Font = New System.Drawing.Font("Mongolian Baiti", 32.0!, System.Drawing.FontStyle.Bold)
        Me.Bhitunggaji.Location = New System.Drawing.Point(364, 366)
        Me.Bhitunggaji.Margin = New System.Windows.Forms.Padding(2)
        Me.Bhitunggaji.Name = "Bhitunggaji"
        Me.Bhitunggaji.Size = New System.Drawing.Size(313, 73)
        Me.Bhitunggaji.TabIndex = 48
        Me.Bhitunggaji.Text = "hitung gaji"
        Me.Bhitunggaji.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(220, 459)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 50)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "gaji:"
        '
        'Tbgaji
        '
        Me.Tbgaji.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbgaji.Location = New System.Drawing.Point(364, 456)
        Me.Tbgaji.Margin = New System.Windows.Forms.Padding(2)
        Me.Tbgaji.Name = "Tbgaji"
        Me.Tbgaji.Size = New System.Drawing.Size(223, 63)
        Me.Tbgaji.TabIndex = 50
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Pengalaman"
        Me.ColumnHeader5.Width = 249
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "gaji"
        Me.ColumnHeader4.Width = 164
        '
        'data_dosen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1221, 851)
        Me.Controls.Add(Me.Tbgaji)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Bhitunggaji)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TbPengalaman)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BHapusSemua)
        Me.Controls.Add(Me.BHapusTerpilih)
        Me.Controls.Add(Me.LvTabeldosen)
        Me.Controls.Add(Me.TbProdi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TbNamaDosen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TbNIDN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BSimpan)
        Me.Name = "data_dosen"
        Me.Text = "data_dosen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BHapusSemua As System.Windows.Forms.Button
    Friend WithEvents BHapusTerpilih As System.Windows.Forms.Button
    Friend WithEvents LvTabeldosen As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TbProdi As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TbNamaDosen As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TbNIDN As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BSimpan As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TbPengalaman As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Bhitunggaji As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Tbgaji As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
End Class
