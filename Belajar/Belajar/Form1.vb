Public Class Form1
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbRole.SelectedItem = "Staf"
    End Sub

    Private Sub txtNim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNim.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRole.SelectedIndexChanged
        Dim path As String = Application.StartupPath & "\assets\"

        If cmbRole.SelectedItem.ToString() = "Manajer" Then
            picRole.Image = Image.FromFile(path & "staf.jpg")
        ElseIf cmbRole.SelectedItem.ToString() = "Staf" Then
            picRole.Image = Image.FromFile(path & "pegawai.jpg")
        End If
    End Sub

    Private validAccounts As New List(Of (Nama As String, NIM As String)) From {
        ("syaikhah", "241712037"),
        ("ririn", "241712011"),
        ("lia", "241712009")
    }
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If cmbRole.SelectedItem Is Nothing OrElse txtName.Text = "" OrElse txtNim.Text = "" Then
            MessageBox.Show("Semua field harus diisi!")
            Exit Sub
        End If

        Dim namaInput As String = txtName.Text.ToLower().Trim()
        Dim nimInput As String = txtNim.Text.Trim()

        Dim isValid As Boolean = False
        For Each akun In validAccounts
            If akun.Nama.ToLower() = namaInput AndAlso akun.NIM = nimInput Then
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


