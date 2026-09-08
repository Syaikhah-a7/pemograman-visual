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
        picImage = New PictureBox()
        lblNama = New Label()
        lblRole = New Label()
        lblNIM = New Label()
        cmbRole = New ComboBox()
        txtNama = New TextBox()
        txtNim = New TextBox()
        btnLogin = New Button()
        CType(picImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picImage
        ' 
        picImage.Location = New Point(318, 54)
        picImage.Name = "picImage"
        picImage.Size = New Size(150, 75)
        picImage.SizeMode = PictureBoxSizeMode.Zoom
        picImage.TabIndex = 0
        picImage.TabStop = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(162, 216)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(83, 25)
        lblNama.TabIndex = 1
        lblNama.Text = "Nama    :"
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Location = New Point(165, 171)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(80, 25)
        lblRole.TabIndex = 2
        lblRole.Text = "Role      :"
        ' 
        ' lblNIM
        ' 
        lblNIM.AutoSize = True
        lblNIM.Location = New Point(164, 269)
        lblNIM.Name = "lblNIM"
        lblNIM.Size = New Size(80, 25)
        lblNIM.TabIndex = 3
        lblNIM.Text = "NIM      :"
        ' 
        ' cmbRole
        ' 
        cmbRole.FormattingEnabled = True
        cmbRole.Items.AddRange(New Object() {"Manajer", "Staf"})
        cmbRole.Location = New Point(300, 163)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(182, 33)
        cmbRole.TabIndex = 4
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(300, 216)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(182, 31)
        txtNama.TabIndex = 5
        ' 
        ' txtNim
        ' 
        txtNim.Location = New Point(300, 263)
        txtNim.Name = "txtNim"
        txtNim.Size = New Size(182, 31)
        txtNim.TabIndex = 6
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(334, 351)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(112, 34)
        btnLogin.TabIndex = 7
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnLogin)
        Controls.Add(txtNim)
        Controls.Add(txtNama)
        Controls.Add(cmbRole)
        Controls.Add(lblNIM)
        Controls.Add(lblRole)
        Controls.Add(lblNama)
        Controls.Add(picImage)
        Name = "Form1"
        Text = "Login"
        CType(picImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picImage As PictureBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents lblNIM As Label
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNim As TextBox
    Friend WithEvents btnLogin As Button

End Class
