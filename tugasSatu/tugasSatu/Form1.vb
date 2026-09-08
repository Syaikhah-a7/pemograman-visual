Public Class Form1
    Private Sub cmbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRole.SelectedIndexChanged
        If cmbRole.SelectedItem.ToString() = "Manajer" Then
            picImage.Image = Image.FromFile("Assets\manajer.png")
        ElseIf cmbRole.SelectedItem.ToString() = "Staf" Then
            picImage.Image = Image.FromFile("Assets\staf.png")
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> " "c Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNim.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private validAccounts As New List(Of (Role As String, Nama As String, NIM As String)) From {
     ("Manajer", "Syaikhah Azzahra Nasir", "241712037"),
     ("Staf", "nadya", "241712040")
    }

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If cmbRole.SelectedItem Is Nothing OrElse txtNama.Text = " " OrElse txtNim.Text = " " Then
            MessageBox.Show("Semua field harus diisi!")
            Exit Sub
        End If

        Dim namaInput As String = txtNama.Text.ToLower().Trim()
        Dim nimInput As String = txtNim.Text.Trim()
        Dim roleInput As String = cmbRole.SelectedItem.ToString()

        Dim isValid As Boolean = False
        For Each akun In validAccounts
            If akun.Nama.ToLower() = namaInput AndAlso akun.NIM = nimInput AndAlso akun.Role = roleInput Then
                isValid = True
                Exit For
            End If
        Next

        If Not isValid Then
            MessageBox.Show("Masukkan akun yang benar")
            Exit Sub
        End If

        Dim formPajak As New pajak()
        formPajak.Show()
        Me.Hide()

    End Sub

End Class
