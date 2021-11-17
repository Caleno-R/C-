Imports MySqlConnector

Public Class RegistrationForm
    Private _table As DataSet

    Private Sub TextBoxFirstName_Enter(sender As Object, e As EventArgs) Handles TextBoxFirstName.Enter
        LabelFN.ForeColor = Color.Red

    End Sub

    Private Sub TextBoxFirstName_Leave(sender As Object, e As EventArgs) Handles TextBoxFirstName.Leave
        LabelFN.ForeColor = Color.White

    End Sub

    Private Sub TextBoxLastName_Enter(sender As Object, e As EventArgs) Handles TextBoxLastName.Enter
        LabelLN.ForeColor = Color.Red

    End Sub

    Private Sub TextBoxLastName_Leave(sender As Object, e As EventArgs) Handles TextBoxLastName.Leave
        LabelLN.ForeColor = Color.White

    End Sub

    Private Sub TextBoxUsername_Enter(sender As Object, e As EventArgs) Handles TextBoxUsername.Enter
        LabelUN.ForeColor = Color.Red

    End Sub

    Private Sub TextBoxUsername_Leave(sender As Object, e As EventArgs) Handles TextBoxUsername.Leave
        LabelUN.ForeColor = Color.White

    End Sub

    Private Sub TextBoxEmail_Enter(sender As Object, e As EventArgs) Handles TextBoxEmail.Enter
        LabelEM.ForeColor = Color.Red
    End Sub

    Private Sub TextBoxEmail_Leave(sender As Object, e As EventArgs) Handles TextBoxEmail.Leave
        LabelEM.ForeColor = Color.White

    End Sub

    Private Sub TextBoxPassword_Enter(sender As Object, e As EventArgs) Handles TextBoxPassword.Enter
        LabelPass1.ForeColor = Color.Red

    End Sub

    Private Sub TextBoxPassword_Leave(sender As Object, e As EventArgs) Handles TextBoxPassword.Leave
        LabelPass1.ForeColor = Color.White
    End Sub

    Private Sub TextBoxConfirmPassword_Enter(sender As Object, e As EventArgs) Handles TextBoxConfirmPassword.Enter
        LabelPass2.ForeColor = Color.Red

    End Sub

    Private Sub TextBoxConfirmPassword_Leave(sender As Object, e As EventArgs) Handles TextBoxConfirmPassword.Leave
        LabelPass2.ForeColor = Color.White

    End Sub

    Private Sub ButtonSignUp_Click(sender As Object, e As EventArgs) Handles ButtonSignUp.Click
        ' check if the fields are empty
        ' check if the password = the confirm password
        ' check if the username already exists

        ' get textboxes values
        Dim fname As String = TextBoxFirstName.Text
        Dim lname As String = TextBoxLastName.Text
        Dim username As String = TextBoxUsername.Text
        Dim email As String = TextBoxEmail.Text
        Dim password As String = TextBoxPassword.Text
        Dim cpassword As String = TextBoxConfirmPassword.Text

        If fname.Trim() = "" Or lname.Trim() = "" Or username.Trim() Or email.Trim() Or password.Trim() Then

            MessageBox.Show("One or more fields are empty", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        ElseIf Not password >= cpassword Then

            MessageBox.Show("Wrong confirmation password", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf Not usernameExists(username) Then

            MessageBox.Show("This Username Already Exists, Choose Another One", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

            ' add the new user
            Dim conn As New MY_CONNECTION()
            Dim command As New MySqlConnector.MySqlCommand("", conn.getConnection())


            command.Parameters.Add("@fn", MySqlConnector.MySqlDbType.VarChar).Value = fname
            command.Parameters.Add("@ln", MySqlConnector.MySqlDbType.VarChar).Value = lname
            command.Parameters.Add("@mail", MySqlConnector.MySqlDbType.VarChar).Value = email
            command.Parameters.Add("@usn", MySqlConnector.MySqlDbType.VarChar).Value = username
            command.Parameters.Add("@pass", MySqlConnector.MySqlDbType.VarChar).Value = password

            conn.openConnection()

            If command.ExecuteNonQuery() = 1 Then

                MessageBox.Show("Registration Completed Successfully", " User Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conn.closeConnection()

            Else

                MessageBox.Show("Something Happened", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.closeConnection()

            End If




        End If

    End Sub

    ' create a function that checks if the username already 
    Public Function usernameExists(ByVal username As String) As Boolean

        Dim con As MY_CONNECTION()
        Dim table As DataTable()
        Dim adapter As New MySqlConnector.MySqlDataAdapter()
        Dim command As New MySqlConnector.MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn", con.getConnection())
        command.Parameters.Add("@usn", MySqlConnector.MySqlDbType.VarChar).Value = username

        adapter.SelectCommand = command
        adapter.Fill(table)

        ' if the username exist return true
        If table.Rows.Count > 0 Then
            Return True

            ' if not return false
        Else
            Return False

        End If

    End Function

    Private Sub LabelGoToSignIn_MouseEnter(sender As Object, e As EventArgs) Handles LabelGoToSignIn.MouseEnter
        LabelGoToSignIn.ForeColor = Color.White

    End Sub

    Private Sub LabelGoToSignIn_MouseLeave(sender As Object, e As EventArgs) Handles LabelGoToSignIn.MouseLeave
        LabelGoToSignIn.ForeColor = Color.Black

    End Sub

    Private Sub LabelGoToSignIn_Click(sender As Object, e As EventArgs) Handles LabelGoToSignIn.Click

        Me.Hide()
        Dim lform As Login_Form()
        lform.Show()

    End Sub
End Class

Friend Class MY_CONNECTION
    Friend Sub openConnection()
        Throw New NotImplementedException()
    End Sub

    Friend Sub closeConnection()
        Throw New NotImplementedException()
    End Sub

    Friend Function getConnection() As MySqlTransaction
        Throw New NotImplementedException()
    End Function
End Class
