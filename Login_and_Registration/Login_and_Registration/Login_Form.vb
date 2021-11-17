Public Class Login_Form
    Private Sub Login_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(123, 234, 90, 0)
        Panel2.BackColor = Color.FromArgb(120, 0, 0, 0)
        ButtonClose.BackColor = Color.FromArgb(100, 0, 0, 0)

    End Sub

    Private Sub ButtonClose_MouseLeave(sender As Object, e As EventArgs) Handles ButtonClose.MouseLeave
        ButtonClose.ForeColor = Color.White

    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Application.Exit()
    End Sub

    Private Sub ButtonClose_MouseEnter(sender As Object, e As EventArgs) Handles ButtonClose.MouseEnter
        ButtonClose.ForeColor = Color.LightGray

    End Sub

    Private Sub TextBoxUsername_Enter(sender As Object, e As EventArgs) Handles TextBoxUsername.Enter
        ' clear the textbox when the textbox get the focus
        Dim username As String = TextBoxUsername.Text
        ' check if the textbox is empty
        ' check the textbox contains the default value "username"
        If username.Trim().ToLower() = "username" Or username.Trim() = "" Then

            ' clear the textbox
            TextBoxUsername.Text = ""
            ' change the color of the textbox
            TextBoxUsername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBoxUsername_Leave(sender As Object, e As EventArgs) Handles TextBoxUsername.Leave
        ' when the textbox get lost the focus
        Dim username As String = TextBoxUsername.Text
        ' check if the textbox is empty
        ' check the textbox contains the default value "username"
        If username.Trim().ToLower() = "username" Or username.Trim() = "" Then

            ' set the textbox text
            TextBoxUsername.Text = "username"
            ' change the color of the textbox
            TextBoxUsername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBoxPassword_Leave(sender As Object, e As EventArgs) Handles TextBoxPassword.Leave
        ' when the textbox password has lost focus
        Dim pass As String = TextBoxPassword.Text
        If pass.Trim().ToLower() = "password" Or pass.Trim() = "" Then

            ' set the textbox text
            TextBoxPassword.Text = "password"
            ' change the textbox font color
            TextBoxPassword.ForeColor = Color.Black
            ' set the system password to False
            TextBoxPassword.UseSystemPasswordChar = False


        End If
    End Sub

    Private Sub TextBoxPassword_Enter(sender As Object, e As EventArgs) Handles TextBoxPassword.Enter
        ' when the textbox password has focus
        Dim pass As String = TextBoxPassword.Text
        If pass.Trim().ToLower() = "password" Or pass.Trim() = "" Then

            ' clear the textbox text
            TextBoxPassword.Text = ""
            ' change the textbox font color
            TextBoxPassword.ForeColor = Color.Black
            ' use system password
            TextBoxPassword.UseSystemPasswordChar = True


        End If
    End Sub

    ' button login
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click

        ' before the user can login we need to check if the text boxes are empty
        ' if they contain the default values( username & password)
        ' check if this user exits in the database

        Dim conn As New CONNECTION()
        Dim adapter As New MySqlConnector.MySqlDataAdapter()
        Dim table As DataTable()
        Dim command As New MySqlConnector.MySqlCommand("SELECT `username`, `password`, FROM `users` WHERE `username` = @usn AND `password` = @pass", conn.getConnection())

        command.Parameters.Add("@usn", MySqlConnector.MySqlDbType.VarChar).Value = TextBoxUsername.Text
        command.Parameters.Add("@pass", MySqlConnector.MySqlDbType.VarChar).Value = TextBoxPassword.Text

        If TextBoxUsername.Text.Trim() = "" Or TextBoxUsername.Text.Trim().ToLower() = "username" Then

            MessageBox.Show("Enter Your Username To Login", "Missing Username", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf TextBoxPassword.Text.Trim() = "" Or TextBoxPassword.Text.Trim().ToLower() = "password" Then

            MessageBox.Show("Enter Your Password To Login", "Missing Password", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            adapter.SelectCommand = command
            adapter.Fill(table)


            If table.Row.Count > 0 Then

                MessageBox.Show("Welcome MUCHACHO!", "Logged In Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else

                MessageBox.Show("Wrong credentials AMIGO!", " Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        End If

    End Sub

    Private Sub LabelGoToSignUp_MouseEnter(sender As Object, e As EventArgs) Handles LabelGoToSignUp.MouseEnter
        LabelGoToSignUp.ForeColor = Color.White

    End Sub

    Private Sub LabelGoToSignUp_MouseLeave(sender As Object, e As EventArgs) Handles LabelGoToSignUp.MouseLeave
        LabelGoToSignUp.ForeColor = Color.Black

    End Sub

    Private Sub LabelGoToSignUp_Click(sender As Object, e As EventArgs) Handles LabelGoToSignUp.Click

        Me.Hide()
        Dim rform As RegistrationForm()
        rform.Show()





    End Sub
End Class