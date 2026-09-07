Public Class pajak

    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click
        Dim pendapatan As Double
        Dim pajak As Double
        Dim persentase As Double

        If Not Double.TryParse(txtFee.Text, pendapatan) Then
            MessageBox.Show("Masukkan angka yang valid!")
            Exit Sub
        End If

        Select Case pendapatan
            Case Is > 100000000
                persentase = 0.3
            Case Is > 30000000
                persentase = 0.2
            Case Is > 5000000
                persentase = 0.1
            Case Else
                persentase = 0
        End Select

        pajak = pendapatan * persentase

        MessageBox.Show("Pajak yang harus dibayar: Rp " & pajak.ToString("N0"))
    End Sub

End Class