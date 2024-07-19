Public Class data_dosen

    Private Sub BSimpan_Click(sender As Object, e As EventArgs) Handles BSimpan.Click
        Dim data As New ListViewItem
        data.Text = TbNIDN.Text()
        data.SubItems.Add(TbNamaDosen.Text)
        data.SubItems.Add(TbProdi.Text)
        data.SubItems.Add(TbPengalaman.Text)
        data.SubItems.Add(Tbgaji.Text)

        If TbNIDN.Text = "" Or TbNamaDosen.Text = "" Or TbProdi.Text = "" Or TbPengalaman.Text = "" Or Tbgaji.Text = "" Then
            MsgBox("Data tidak boleh kosong.", MsgBoxStyle.Critical)
        Else
            LvTabeldosen.Items.Add(data)
            TbNIDN.Clear()
            TbNamaDosen.Clear()
            TbProdi.Clear()
            TbPengalaman.Clear()
            Tbgaji.Clear()
            MsgBox("Data berhasil disimpan.")
        End If
    End Sub

    Private Sub Bhitunggaji_Click(sender As Object, e As EventArgs) Handles Bhitunggaji.Click
        Dim pengalaman As Integer = TbPengalaman.Text


        Dim hasil As Integer
        hasil = 200000 + (50000 * pengalaman)

        Tbgaji.Text = hasil
    End Sub

    Private Sub BHapusTerpilih_Click(sender As Object, e As EventArgs) Handles BHapusTerpilih.Click
        If LvTabeldosen.SelectedItems.Count = 0 Then
            MsgBox("Pilih data terlebih dahulu!", MsgBoxStyle.Critical)
        Else
            Dim pesan As String
            pesan = MsgBox("Yakin hapus data terpilih?", MsgBoxStyle.YesNo)
            If pesan = vbYes Then
                LvTabeldosen.SelectedItems(0).Remove()
            End If
        End If

    End Sub

    Private Sub BHapusSemua_Click(sender As Object, e As EventArgs) Handles BHapusSemua.Click
        Dim pesan As String
        pesan = MsgBox("Yakin hapus semua data?", MsgBoxStyle.YesNo)
        If pesan = vbYes Then
            LvTabeldosen.Items.Clear()
        End If
    End Sub
End Class