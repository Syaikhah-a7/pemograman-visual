<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pajak
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
        btnHitung = New Button()
        txtPendapatan = New TextBox()
        lblRupiah = New Label()
        lblPendapatan = New Label()
        lblLimaJuta = New Label()
        lblTigaPuluhJuta = New Label()
        lblSeratusJuta = New Label()
        btnKeluar = New Button()
        SuspendLayout()
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(342, 303)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(112, 34)
        btnHitung.TabIndex = 0
        btnHitung.Text = "Hitung"
        btnHitung.TextImageRelation = TextImageRelation.ImageAboveText
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' txtPendapatan
        ' 
        txtPendapatan.Location = New Point(323, 252)
        txtPendapatan.Name = "txtPendapatan"
        txtPendapatan.Size = New Size(150, 31)
        txtPendapatan.TabIndex = 1
        ' 
        ' lblRupiah
        ' 
        lblRupiah.AutoSize = True
        lblRupiah.Location = New Point(252, 255)
        lblRupiah.Name = "lblRupiah"
        lblRupiah.Size = New Size(34, 25)
        lblRupiah.TabIndex = 2
        lblRupiah.Text = "Rp"
        ' 
        ' lblPendapatan
        ' 
        lblPendapatan.AutoSize = True
        lblPendapatan.Location = New Point(308, 203)
        lblPendapatan.Name = "lblPendapatan"
        lblPendapatan.Size = New Size(199, 25)
        lblPendapatan.TabIndex = 3
        lblPendapatan.Text = "Masukkan Pendapatan :"
        ' 
        ' lblLimaJuta
        ' 
        lblLimaJuta.AutoSize = True
        lblLimaJuta.Location = New Point(240, 38)
        lblLimaJuta.Name = "lblLimaJuta"
        lblLimaJuta.Size = New Size(326, 25)
        lblLimaJuta.TabIndex = 4
        lblLimaJuta.Text = "Pendapatan lebih dari 5 juta, 10 % Pajak"
        ' 
        ' lblTigaPuluhJuta
        ' 
        lblTigaPuluhJuta.AutoSize = True
        lblTigaPuluhJuta.Location = New Point(242, 81)
        lblTigaPuluhJuta.Name = "lblTigaPuluhJuta"
        lblTigaPuluhJuta.Size = New Size(331, 25)
        lblTigaPuluhJuta.TabIndex = 5
        lblTigaPuluhJuta.Text = "Pendapatan lebih dari 30 juta, 20% Pajak"
        ' 
        ' lblSeratusJuta
        ' 
        lblSeratusJuta.AutoSize = True
        lblSeratusJuta.Location = New Point(238, 124)
        lblSeratusJuta.Name = "lblSeratusJuta"
        lblSeratusJuta.Size = New Size(341, 25)
        lblSeratusJuta.TabIndex = 6
        lblSeratusJuta.Text = "Pendapatan lebih dari 100 juta, 30% Pajak"
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(342, 360)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(112, 34)
        btnKeluar.TabIndex = 7
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' pajak
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnKeluar)
        Controls.Add(lblSeratusJuta)
        Controls.Add(lblTigaPuluhJuta)
        Controls.Add(lblLimaJuta)
        Controls.Add(lblPendapatan)
        Controls.Add(lblRupiah)
        Controls.Add(txtPendapatan)
        Controls.Add(btnHitung)
        Name = "pajak"
        Text = "pajak"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnHitung As Button
    Friend WithEvents txtPendapatan As TextBox
    Friend WithEvents lblRupiah As Label
    Friend WithEvents lblPendapatan As Label
    Friend WithEvents lblLimaJuta As Label
    Friend WithEvents lblTigaPuluhJuta As Label
    Friend WithEvents lblSeratusJuta As Label
    Friend WithEvents btnKeluar As Button

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim pendapatan As Double
        Dim pajak As Double
        Dim persentase As Double

        If Not Double.TryParse(txtPendapatan.Text, pendapatan) Then
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

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Dim formLogin As New Form1()
        formLogin.Show()
        Me.Close()
    End Sub
End Class
