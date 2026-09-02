Public Class Form1
    Private Sub txtNIM_TextChanged(sender As Object, e As EventArgs) Handles txtNIM.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblKom.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTampilkan_Click.Click
        MessageBox.Show("Halo Selamat Datang !" & vbCrLf &
                        "Nama : " & txtNama.Text & vbCrLf &
                        "NIM : " & txtNIM.Text & vbCrLf &
                        "Kom : " & txtKom.Text
    )
    End Sub

    Private Sub txtNama_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged

    End Sub

    Private Sub txtHapus_Click_Click(sender As Object, e As EventArgs) Handles txtHapus_Click.Click
        txtNama.Clear()
        txtNIM.Clear()
        txtKom.Clear()
    End Sub

    Private Sub btnKeluar_Click_Click(sender As Object, e As EventArgs) Handles btnKeluar_Click.Click
        Me.Close()
    End Sub
End Class
