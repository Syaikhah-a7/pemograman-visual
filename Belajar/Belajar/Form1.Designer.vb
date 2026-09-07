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
        picRole = New PictureBox()
        lblRole = New Label()
        lblName = New Label()
        lblNim = New Label()
        cmbRole = New ComboBox()
        txtName = New TextBox()
        txtNim = New TextBox()
        btnLogin = New Button()
        CType(picRole, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picRole
        ' 
        picRole.Location = New Point(332, 25)
        picRole.Name = "picRole"
        picRole.Size = New Size(150, 75)
        picRole.SizeMode = PictureBoxSizeMode.Zoom
        picRole.TabIndex = 0
        picRole.TabStop = False
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Location = New Point(229, 150)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(75, 25)
        lblRole.TabIndex = 1
        lblRole.Text = "Role     :"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(229, 200)
        lblName.Name = "lblName"
        lblName.Size = New Size(78, 25)
        lblName.TabIndex = 2
        lblName.Text = "Nama   :"
        ' 
        ' lblNim
        ' 
        lblNim.AutoSize = True
        lblNim.Location = New Point(229, 263)
        lblNim.Name = "lblNim"
        lblNim.Size = New Size(75, 25)
        lblNim.TabIndex = 3
        lblNim.Text = "NIM     :"
        ' 
        ' cmbRole
        ' 
        cmbRole.FormattingEnabled = True
        cmbRole.Items.AddRange(New Object() {"Manajer", "Staf"})
        cmbRole.Location = New Point(318, 142)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(182, 33)
        cmbRole.TabIndex = 4
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(318, 200)
        txtName.Name = "txtName"
        txtName.Size = New Size(182, 31)
        txtName.TabIndex = 5
        ' 
        ' txtNim
        ' 
        txtNim.Location = New Point(318, 257)
        txtNim.Name = "txtNim"
        txtNim.Size = New Size(178, 31)
        txtNim.TabIndex = 6
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = SystemColors.ActiveCaption
        btnLogin.Location = New Point(346, 337)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(112, 34)
        btnLogin.TabIndex = 7
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnLogin)
        Controls.Add(txtNim)
        Controls.Add(txtName)
        Controls.Add(cmbRole)
        Controls.Add(lblNim)
        Controls.Add(lblName)
        Controls.Add(lblRole)
        Controls.Add(picRole)
        Name = "Form1"
        Text = "Login"
        CType(picRole, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picRole As PictureBox
    Friend WithEvents lblRole As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblNim As Label
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtNim As TextBox
    Friend WithEvents btnLogin As Button

End Class
