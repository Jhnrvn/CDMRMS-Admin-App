Imports MySql.Data.MySqlClient


Public Class Admin_Main

    ' Database Connection
    Private Shared ConnectionString As String = "server=localhost; port=3306; database=cdmregistrarmanagementsystem; uid=root; password=;"
    Private Shared connection As New MySqlConnection(ConnectionString)



    Private Sub Admin_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dropdown_Panel.Size = Dropdown_Panel.MinimumSize
        Instructor_Panel.Hide()
        InstructorData()

    End Sub

    Dim MenuCollapsed As Boolean = True
    Private Sub Dropdown_Timer_Tick(sender As Object, e As EventArgs) Handles DropdownTimer.Tick
        If MenuCollapsed Then

            Dropdown_Panel.Height += 10
            If Dropdown_Panel.Size = Dropdown_Panel.MaximumSize Then

                DropdownTimer.Stop()
                MenuCollapsed = False
            End If

        Else

            Instructor_Panel.Hide()

            Dropdown_Panel.Height -= 10
            If Dropdown_Panel.Size = Dropdown_Panel.MinimumSize Then

                DropdownTimer.Stop()
                MenuCollapsed = True
            End If

        End If
    End Sub

    Private Sub Menu_Btn_Click(sender As Object, e As EventArgs) Handles Menu_Btn.Click
        DropdownTimer.Start()

    End Sub

    Private Sub InstructorData()
        Try
            connection.Open()

            Dim selectQuery As String = "SELECT `firstname`, `middlename`, `lastname`, `instructorid` FROM instructors"
            Dim command As New MySqlCommand(selectQuery, connection)


            Dim datatable As New DataTable()
            Using adapter As New MySqlDataAdapter(command)
                adapter.Fill(datatable)
                InstructorsDataTable.DataSource = datatable
            End Using


        Catch ex As Exception
            MessageBox.Show("Error fetching data: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim searchTerm As String = InstructorSearchBar.Text.Trim()
        If searchTerm <> "" Then
            Try
                connection.Open()

                Dim query As String = "SELECT * FROM instructors WHERE lastname LIKE @searchTerm"
                Dim command As New MySqlCommand(query, connection)

                command.Parameters.AddWithValue("@searchTerm", "%" & searchTerm & "%")

                Dim dataTable As New DataTable()

                Dim adapter As New MySqlDataAdapter(command)
                adapter.Fill(dataTable)
                InstructorsDataTable.DataSource = dataTable
            Catch ex As Exception
                MessageBox.Show("Error searching data: " & ex.Message)
            Finally
                connection.Close()

            End Try
        Else
            MessageBox.Show("Please enter a search term.")
        End If

    End Sub

    Private Sub Instructor_Btn_Click(sender As Object, e As EventArgs) Handles Instructor_Btn.Click
        Instructor_Panel.Show
    End Sub

    Private Sub InstructorSearchBar_textChanged(sender As Object, e As EventArgs) Handles InstructorSearchBar.TextChanged
        If String.IsNullOrEmpty(InstructorSearchBar.Text.Trim()) Then
            InstructorData()
        End If
    End Sub



    Private Sub InstructorsDataTable_SelectionChanged(sender As Object, e As EventArgs) Handles InstructorsDataTable.SelectionChanged
        InstructorsDataTable.ClearSelection()
    End Sub
End Class