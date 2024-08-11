Imports System.Data.SqlClient

Public Class Form1
    Private connectionString As String = "Server=localhost\SQLEXPRESS;Database=SimpleDB;Trusted_Connection=True;"
    Private sqlConnection As SqlConnection

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlConnection = New SqlConnection(connectionString)
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim query As String = "SELECT * FROM People"
        Dim dataAdapter As New SqlDataAdapter(query, sqlConnection)
        Dim dataTable As New DataTable()
        dataAdapter.Fill(dataTable)
        dataGridView1.DataSource = dataTable
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim query As String = "INSERT INTO People (FirstName, LastName) VALUES (@FirstName, @LastName)"
        Dim command As New SqlCommand(query, sqlConnection)
        command.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
        command.Parameters.AddWithValue("@LastName", txtLastName.Text)

        sqlConnection.Open()
        command.ExecuteNonQuery()
        sqlConnection.Close()

        LoadData()
        txtFirstName.Clear()
        txtLastName.Clear()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dataGridView1.SelectedRows.Count > 0 Then
            Dim id As Integer = Convert.ToInt32(dataGridView1.SelectedRows(0).Cells("Id").Value)
            Dim query As String = "DELETE FROM People WHERE Id = @Id"
            Dim command As New SqlCommand(query, sqlConnection)
            command.Parameters.AddWithValue("@Id", id)

            sqlConnection.Open()
            command.ExecuteNonQuery()
            sqlConnection.Close()

            LoadData()
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub
End Class
