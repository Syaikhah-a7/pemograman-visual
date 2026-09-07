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
        lblPajak1 = New Label()
        lblPajak2 = New Label()
        lblPajak3 = New Label()
        lblFee = New Label()
        lblRupiah = New Label()
        txtFee = New TextBox()
        btnCount = New Button()
        SuspendLayout()
        ' 
        ' lblPajak1
        ' 
        lblPajak1.AutoSize = True
        lblPajak1.Location = New Point(225, 44)
        lblPajak1.Name = "lblPajak1"
        lblPajak1.Size = New Size(323, 25)
        lblPajak1.TabIndex = 0
        lblPajak1.Text = "Pendapatan lebih dari 5 juta, 10% pajak"
        ' 
        ' lblPajak2
        ' 
        lblPajak2.AutoSize = True
        lblPajak2.Location = New Point(225, 84)
        lblPajak2.Name = "lblPajak2"
        lblPajak2.Size = New Size(333, 25)
        lblPajak2.TabIndex = 1
        lblPajak2.Text = "Pendapatan lebih dari 30 juta, 20% pajak"
        ' 
        ' lblPajak3
        ' 
        lblPajak3.AutoSize = True
        lblPajak3.Location = New Point(228, 125)
        lblPajak3.Name = "lblPajak3"
        lblPajak3.Size = New Size(343, 25)
        lblPajak3.TabIndex = 2
        lblPajak3.Text = "Pendapatan lebih dari 100 juta, 30% pajak"
        ' 
        ' lblFee
        ' 
        lblFee.AutoSize = True
        lblFee.Location = New Point(295, 185)
        lblFee.Name = "lblFee"
        lblFee.Size = New Size(199, 25)
        lblFee.TabIndex = 3
        lblFee.Text = "Masukkan Pendapatan :"
        ' 
        ' lblRupiah
        ' 
        lblRupiah.AutoSize = True
        lblRupiah.Location = New Point(227, 239)
        lblRupiah.Name = "lblRupiah"
        lblRupiah.Size = New Size(43, 25)
        lblRupiah.TabIndex = 4
        lblRupiah.Text = "Rp ."
        ' 
        ' txtFee
        ' 
        txtFee.Location = New Point(295, 233)
        txtFee.Name = "txtFee"
        txtFee.Size = New Size(199, 31)
        txtFee.TabIndex = 5
        ' 
        ' btnCount
        ' 
        btnCount.BackColor = SystemColors.ActiveCaption
        btnCount.Location = New Point(326, 290)
        btnCount.Name = "btnCount"
        btnCount.Size = New Size(112, 34)
        btnCount.TabIndex = 6
        btnCount.Text = "Hitung"
        btnCount.UseVisualStyleBackColor = False
        ' 
        ' pajak
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCount)
        Controls.Add(txtFee)
        Controls.Add(lblRupiah)
        Controls.Add(lblFee)
        Controls.Add(lblPajak3)
        Controls.Add(lblPajak2)
        Controls.Add(lblPajak1)
        Name = "pajak"
        Text = "Pajak"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblPajak1 As Label
    Friend WithEvents lblPajak2 As Label
    Friend WithEvents lblPajak3 As Label
    Friend WithEvents lblFee As Label
    Friend WithEvents lblRupiah As Label
    Friend WithEvents txtFee As TextBox
    Friend WithEvents btnCount As Button
End Class
