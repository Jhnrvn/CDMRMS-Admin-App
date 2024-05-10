Imports MySql.Data.MySqlClient

Public Class AssignedCourse_Section


    ' FORM LOAD - START
    Private Sub AssignedCourse_Section_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AssignedCourse()
        AssignedCourseTable.ReadOnly = True
        AssignedCourseTable.AllowUserToAddRows = False

    End Sub
    ' FORM LOAD - END


    ' DATABASE CONNECTION - START
    Private Shared ConnectionString As String = "server=localhost; port=3306; database=cdmregistrarmanagementsystem; uid=root; password=;"
    Private Shared connection As New MySqlConnection(ConnectionString)
    Dim adapter As New MySqlDataAdapter()
    Dim dataTable As New DataTable()
    ' DATABASE CONNECTION - END


    Private Sub AssignedCourse()

        Try
            connection.Open()

            Dim selectQuery As String = "SELECT * FROM assignedcourse"

            adapter = New MySqlDataAdapter(selectQuery, connection)

            AssignedCourseTable.RowTemplate.Height = 30
            adapter.Fill(dataTable)

            AssignedCourseTable.DataSource = dataTable


            AssignedCourseTable.Columns("id").Visible = False
            AssignedCourseTable.Columns("instructor_id").Width = 150
            AssignedCourseTable.Columns("instructor").Width = 200
            AssignedCourseTable.Columns("course").Width = 133

        Catch ex As Exception
            MessageBox.Show("Error fetching data: " & ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub

    Private Sub InstructorSearchBar_TextChanged(sender As Object, e As EventArgs) Handles InstructorSearchBar.TextChanged
        Dim searchTerm As String = InstructorSearchBar.Text.Trim()
        If searchTerm <> "" Then
            Try
                connection.Open()

                Dim query As String = "SELECT * FROM assignedcourse WHERE instructor_id LIKE @searchTerm OR instructor LIKE @searchTerm OR course LIKE @searchTerm"
                Dim command As New MySqlCommand(query, connection)

                command.Parameters.AddWithValue("@searchTerm", "%" & searchTerm & "%")

                Dim dataTable As New DataTable()

                Dim adapter As New MySqlDataAdapter(command)
                AssignedCourseTable.RowTemplate.Height = 35
                adapter.Fill(dataTable)
                AssignedCourseTable.DataSource = dataTable
                AssignedCourseTable.Columns("instructor_id").Width = 150
                AssignedCourseTable.Columns("instructor").Width = 200
            Catch ex As Exception
                MessageBox.Show("Error searching data: " & ex.Message)
            Finally
                connection.Close()

            End Try
        End If

        If String.IsNullOrEmpty(InstructorSearchBar.Text.Trim()) Then
            AssignedCourse()
        End If
    End Sub


    Private Sub SaveData()
        Dim builder As New MySqlCommandBuilder(adapter)
        adapter.Update(DataTable)
    End Sub

    Private Sub Save_Btn_Click(sender As Object, e As EventArgs) Handles Save_Btn.Click

        SaveData()
        AssignedCourseTable.ReadOnly = True
        MsgBox("Update successful.", MessageBoxIcon.Information)
        dataTable.Clear()
        AssignedCourse()
        AssignedCourseTable.AllowUserToAddRows = False
        Delete_Btn.Enabled = True

    End Sub

    Private Sub Edit_Btn_Click(sender As Object, e As EventArgs) Handles Edit_Btn.Click

        AssignedCourseTable.ReadOnly = False
        MsgBox("Edit Enabled.", MessageBoxIcon.Information)
        AssignedCourseTable.AllowUserToAddRows = True
        Delete_Btn.Enabled = False

    End Sub

    Private Sub Delete_Btn_Click(sender As Object, e As EventArgs) Handles Delete_Btn.Click
        Dim choice As DialogResult = MsgBox("Delete selected row?", MessageBoxButtons.YesNo)

        If choice = DialogResult.Yes Then

            If AssignedCourseTable.SelectedRows.Count > 0 Then

                Dim selectedRow As DataGridViewRow = AssignedCourseTable.SelectedRows(0)
                Dim id As String
                id = selectedRow.Cells("id").Value.ToString()

                Dim DeleteQuery As String = " DELETE FROM assignedcourse WHERE `id` = @id "
                Try
                    connection.Open()

                    Using DeleteCommand As New MySqlCommand(DeleteQuery, connection)
                        DeleteCommand.Parameters.AddWithValue("@id", id)
                        DeleteCommand.ExecuteNonQuery()

                    End Using

                    MsgBox("Row deleted successfully.", MessageBoxIcon.Information)

                Catch ex As Exception

                    MsgBox("error" & ex.Message)

                Finally
                    connection.Close()

                End Try
                dataTable.Clear()
                AssignedCourse()

            End If

        End If
    End Sub


    Private Sub Close_Btn_Click(sender As Object, e As EventArgs) Handles Close_Btn.Click
        Me.Close()
        Admin_Main.Enabled = True
    End Sub


End Class