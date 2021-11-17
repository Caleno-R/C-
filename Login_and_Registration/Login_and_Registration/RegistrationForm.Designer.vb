<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationForm
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
        Me.PanelRegistration = New System.Windows.Forms.Panel()
        Me.ButtonCloseRegister = New System.Windows.Forms.Button()
        Me.PanelRegister = New System.Windows.Forms.Panel()
        Me.LabelRegister = New System.Windows.Forms.Label()
        Me.ButtonSignUp = New System.Windows.Forms.Button()
        Me.TextBoxConfirmPassword = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.LabelPass2 = New System.Windows.Forms.Label()
        Me.LabelPass1 = New System.Windows.Forms.Label()
        Me.LabelEM = New System.Windows.Forms.Label()
        Me.LabelUN = New System.Windows.Forms.Label()
        Me.LabelLN = New System.Windows.Forms.Label()
        Me.LabelFN = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.TextBoxLastName = New System.Windows.Forms.TextBox()
        Me.TextBoxFirstName = New System.Windows.Forms.TextBox()
        Me.LabelGoToSignIn = New System.Windows.Forms.Label()
        Me.PanelRegistration.SuspendLayout()
        Me.PanelRegister.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelRegistration
        '
        Me.PanelRegistration.BackColor = System.Drawing.Color.BurlyWood
        Me.PanelRegistration.Controls.Add(Me.LabelGoToSignIn)
        Me.PanelRegistration.Controls.Add(Me.ButtonCloseRegister)
        Me.PanelRegistration.Controls.Add(Me.PanelRegister)
        Me.PanelRegistration.Controls.Add(Me.ButtonSignUp)
        Me.PanelRegistration.Controls.Add(Me.TextBoxConfirmPassword)
        Me.PanelRegistration.Controls.Add(Me.TextBoxPassword)
        Me.PanelRegistration.Controls.Add(Me.LabelPass2)
        Me.PanelRegistration.Controls.Add(Me.LabelPass1)
        Me.PanelRegistration.Controls.Add(Me.LabelEM)
        Me.PanelRegistration.Controls.Add(Me.LabelUN)
        Me.PanelRegistration.Controls.Add(Me.LabelLN)
        Me.PanelRegistration.Controls.Add(Me.LabelFN)
        Me.PanelRegistration.Controls.Add(Me.TextBoxEmail)
        Me.PanelRegistration.Controls.Add(Me.TextBoxUsername)
        Me.PanelRegistration.Controls.Add(Me.TextBoxLastName)
        Me.PanelRegistration.Controls.Add(Me.TextBoxFirstName)
        Me.PanelRegistration.ForeColor = System.Drawing.Color.Peru
        Me.PanelRegistration.Location = New System.Drawing.Point(0, 2)
        Me.PanelRegistration.Name = "PanelRegistration"
        Me.PanelRegistration.Size = New System.Drawing.Size(878, 634)
        Me.PanelRegistration.TabIndex = 13
        '
        'ButtonCloseRegister
        '
        Me.ButtonCloseRegister.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonCloseRegister.Location = New System.Drawing.Point(773, 0)
        Me.ButtonCloseRegister.Name = "ButtonCloseRegister"
        Me.ButtonCloseRegister.Size = New System.Drawing.Size(105, 65)
        Me.ButtonCloseRegister.TabIndex = 27
        Me.ButtonCloseRegister.Text = " X"
        Me.ButtonCloseRegister.UseVisualStyleBackColor = False
        '
        'PanelRegister
        '
        Me.PanelRegister.BackColor = System.Drawing.Color.DimGray
        Me.PanelRegister.Controls.Add(Me.LabelRegister)
        Me.PanelRegister.Location = New System.Drawing.Point(0, 0)
        Me.PanelRegister.Name = "PanelRegister"
        Me.PanelRegister.Size = New System.Drawing.Size(775, 65)
        Me.PanelRegister.TabIndex = 26
        '
        'LabelRegister
        '
        Me.LabelRegister.AutoSize = True
        Me.LabelRegister.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRegister.Location = New System.Drawing.Point(308, 18)
        Me.LabelRegister.Name = "LabelRegister"
        Me.LabelRegister.Size = New System.Drawing.Size(175, 32)
        Me.LabelRegister.TabIndex = 0
        Me.LabelRegister.Text = " REGISTER "
        '
        'ButtonSignUp
        '
        Me.ButtonSignUp.BackColor = System.Drawing.Color.MintCream
        Me.ButtonSignUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSignUp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSignUp.ForeColor = System.Drawing.Color.Peru
        Me.ButtonSignUp.Location = New System.Drawing.Point(140, 513)
        Me.ButtonSignUp.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonSignUp.Name = "ButtonSignUp"
        Me.ButtonSignUp.Size = New System.Drawing.Size(595, 67)
        Me.ButtonSignUp.TabIndex = 25
        Me.ButtonSignUp.Text = "SIGN UP"
        Me.ButtonSignUp.UseVisualStyleBackColor = False
        '
        'TextBoxConfirmPassword
        '
        Me.TextBoxConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxConfirmPassword.Location = New System.Drawing.Point(474, 426)
        Me.TextBoxConfirmPassword.Multiline = True
        Me.TextBoxConfirmPassword.Name = "TextBoxConfirmPassword"
        Me.TextBoxConfirmPassword.Size = New System.Drawing.Size(260, 50)
        Me.TextBoxConfirmPassword.TabIndex = 24
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxPassword.Location = New System.Drawing.Point(139, 426)
        Me.TextBoxPassword.Multiline = True
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(258, 50)
        Me.TextBoxPassword.TabIndex = 23
        '
        'LabelPass2
        '
        Me.LabelPass2.AutoSize = True
        Me.LabelPass2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPass2.Location = New System.Drawing.Point(470, 402)
        Me.LabelPass2.Name = "LabelPass2"
        Me.LabelPass2.Size = New System.Drawing.Size(186, 21)
        Me.LabelPass2.TabIndex = 22
        Me.LabelPass2.Text = "* Confirm Password"
        '
        'LabelPass1
        '
        Me.LabelPass1.AutoSize = True
        Me.LabelPass1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPass1.Location = New System.Drawing.Point(140, 402)
        Me.LabelPass1.Name = "LabelPass1"
        Me.LabelPass1.Size = New System.Drawing.Size(111, 21)
        Me.LabelPass1.TabIndex = 21
        Me.LabelPass1.Text = "* Password"
        '
        'LabelEM
        '
        Me.LabelEM.AutoSize = True
        Me.LabelEM.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEM.Location = New System.Drawing.Point(140, 304)
        Me.LabelEM.Name = "LabelEM"
        Me.LabelEM.Size = New System.Drawing.Size(72, 21)
        Me.LabelEM.TabIndex = 20
        Me.LabelEM.Text = "* Email"
        '
        'LabelUN
        '
        Me.LabelUN.AutoSize = True
        Me.LabelUN.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUN.Location = New System.Drawing.Point(136, 211)
        Me.LabelUN.Name = "LabelUN"
        Me.LabelUN.Size = New System.Drawing.Size(115, 21)
        Me.LabelUN.TabIndex = 19
        Me.LabelUN.Text = "* Username"
        '
        'LabelLN
        '
        Me.LabelLN.AutoSize = True
        Me.LabelLN.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLN.Location = New System.Drawing.Point(506, 104)
        Me.LabelLN.Name = "LabelLN"
        Me.LabelLN.Size = New System.Drawing.Size(118, 21)
        Me.LabelLN.TabIndex = 18
        Me.LabelLN.Text = "* Last Name"
        '
        'LabelFN
        '
        Me.LabelFN.AutoSize = True
        Me.LabelFN.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFN.Location = New System.Drawing.Point(140, 104)
        Me.LabelFN.Name = "LabelFN"
        Me.LabelFN.Size = New System.Drawing.Size(120, 21)
        Me.LabelFN.TabIndex = 17
        Me.LabelFN.Text = "* First Name"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxEmail.Location = New System.Drawing.Point(139, 328)
        Me.TextBoxEmail.Multiline = True
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(595, 50)
        Me.TextBoxEmail.TabIndex = 16
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxUsername.Location = New System.Drawing.Point(139, 235)
        Me.TextBoxUsername.Multiline = True
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(595, 50)
        Me.TextBoxUsername.TabIndex = 15
        '
        'TextBoxLastName
        '
        Me.TextBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxLastName.Location = New System.Drawing.Point(501, 128)
        Me.TextBoxLastName.Multiline = True
        Me.TextBoxLastName.Name = "TextBoxLastName"
        Me.TextBoxLastName.Size = New System.Drawing.Size(233, 50)
        Me.TextBoxLastName.TabIndex = 14
        '
        'TextBoxFirstName
        '
        Me.TextBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxFirstName.Location = New System.Drawing.Point(139, 128)
        Me.TextBoxFirstName.Multiline = True
        Me.TextBoxFirstName.Name = "TextBoxFirstName"
        Me.TextBoxFirstName.Size = New System.Drawing.Size(233, 50)
        Me.TextBoxFirstName.TabIndex = 13
        '
        'LabelGoToSignIn
        '
        Me.LabelGoToSignIn.AutoSize = True
        Me.LabelGoToSignIn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGoToSignIn.ForeColor = System.Drawing.Color.Sienna
        Me.LabelGoToSignIn.Location = New System.Drawing.Point(216, 592)
        Me.LabelGoToSignIn.Name = "LabelGoToSignIn"
        Me.LabelGoToSignIn.Size = New System.Drawing.Size(338, 23)
        Me.LabelGoToSignIn.TabIndex = 28
        Me.LabelGoToSignIn.Text = "Already have an account ? Sign In"
        '
        'RegistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 637)
        Me.Controls.Add(Me.PanelRegistration)
        Me.ForeColor = System.Drawing.Color.Peru
        Me.Name = "RegistrationForm"
        Me.Text = "RegistrationForm"
        Me.PanelRegistration.ResumeLayout(False)
        Me.PanelRegistration.PerformLayout()
        Me.PanelRegister.ResumeLayout(False)
        Me.PanelRegister.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelRegistration As Panel
    Friend WithEvents ButtonSignUp As Button
    Friend WithEvents TextBoxConfirmPassword As TextBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents LabelPass2 As Label
    Friend WithEvents LabelPass1 As Label
    Friend WithEvents LabelEM As Label
    Friend WithEvents LabelUN As Label
    Friend WithEvents LabelLN As Label
    Friend WithEvents LabelFN As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents TextBoxLastName As TextBox
    Friend WithEvents TextBoxFirstName As TextBox
    Friend WithEvents ButtonCloseRegister As Button
    Friend WithEvents PanelRegister As Panel
    Friend WithEvents LabelRegister As Label
    Friend WithEvents LabelGoToSignIn As Label
End Class
