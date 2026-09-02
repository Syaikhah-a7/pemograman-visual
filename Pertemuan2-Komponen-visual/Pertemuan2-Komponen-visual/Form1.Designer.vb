<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        lblNama = New Label()
        txtNama = New TextBox()
        lblNIM = New Label()
        txtNIM = New TextBox()
        lblKom = New Label()
        txtKom = New TextBox()
        btnTampilkan_Click = New Button()
        txtHapus_Click = New Button()
        btnKeluar_Click = New Button()
        SuspendLayout()
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(166, 68)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(68, 25)
        lblNama.TabIndex = 0
        lblNama.Text = "Nama :"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(249, 65)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(150, 31)
        txtNama.TabIndex = 1
        ' 
        ' lblNIM
        ' 
        lblNIM.AutoSize = True
        lblNIM.Location = New Point(166, 118)
        lblNIM.Name = "lblNIM"
        lblNIM.Size = New Size(65, 25)
        lblNIM.TabIndex = 2
        lblNIM.Text = "NIM   :"
        ' 
        ' txtNIM
        ' 
        txtNIM.Location = New Point(249, 115)
        txtNIM.Name = "txtNIM"
        txtNIM.Size = New Size(150, 31)
        txtNIM.TabIndex = 3
        ' 
        ' lblKom
        ' 
        lblKom.AutoSize = True
        lblKom.Location = New Point(166, 171)
        lblKom.Name = "lblKom"
        lblKom.Size = New Size(63, 25)
        lblKom.TabIndex = 4
        lblKom.Text = "Kom  :"
        ' 
        ' txtKom
        ' 
        txtKom.Location = New Point(249, 173)
        txtKom.Name = "txtKom"
        txtKom.Size = New Size(150, 31)
        txtKom.TabIndex = 5
        ' 
        ' btnTampilkan_Click
        ' 
        btnTampilkan_Click.Location = New Point(149, 267)
        btnTampilkan_Click.Name = "btnTampilkan_Click"
        btnTampilkan_Click.Size = New Size(112, 34)
        btnTampilkan_Click.TabIndex = 6
        btnTampilkan_Click.Text = "Tampilkan"
        btnTampilkan_Click.UseVisualStyleBackColor = True
        ' 
        ' txtHapus_Click
        ' 
        txtHapus_Click.Location = New Point(302, 268)
        txtHapus_Click.Name = "txtHapus_Click"
        txtHapus_Click.Size = New Size(112, 34)
        txtHapus_Click.TabIndex = 7
        txtHapus_Click.Text = "Hapus"
        txtHapus_Click.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar_Click
        ' 
        btnKeluar_Click.BackColor = SystemColors.ActiveBorder
        btnKeluar_Click.Location = New Point(225, 328)
        btnKeluar_Click.Name = "btnKeluar_Click"
        btnKeluar_Click.Size = New Size(112, 34)
        btnKeluar_Click.TabIndex = 8
        btnKeluar_Click.Text = "Keluar"
        btnKeluar_Click.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(564, 450)
        Controls.Add(btnKeluar_Click)
        Controls.Add(txtHapus_Click)
        Controls.Add(btnTampilkan_Click)
        Controls.Add(txtKom)
        Controls.Add(lblKom)
        Controls.Add(txtNIM)
        Controls.Add(lblNIM)
        Controls.Add(txtNama)
        Controls.Add(lblNama)
        Name = "Form1"
        Text = "Profile Mahasiswa"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblNIM As Label
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents lblKom As Label
    Friend WithEvents txtKom As TextBox
    Friend WithEvents btnTampilkan_Click As Button
    Friend WithEvents txtHapus_Click As Button
    Friend WithEvents btnKeluar_Click As Button

End Class
