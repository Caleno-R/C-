
Imports MySqlConnector

Public Class CONNECTION

    ' create the connection
    Private connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=vb.net users")

    ' return the connection
    ReadOnly Property getConnection() As MySqlConnection
        Get
            Return connection
        End Get
    End Property

    ' open the connection
    Sub openConnection()
        If connection.State = connection.State.Closed Then
            connection.Open()
        End If
    End Sub

    ' close the connection
    Sub closeConnection()
        If connection.State = connection.State.Open Then
            connection.Close()
        End If
    End Sub



End Class
