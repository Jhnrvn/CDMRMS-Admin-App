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



    Private Sub Instructor_Btn_Click(sender As Object, e As EventArgs) Handles Instructor_Btn.Click
        Instructor_Panel.Show()

    End Sub

    Private Sub InstructorSearchBar_textChanged(sender As Object, e As EventArgs) Handles InstructorSearchBar.TextChanged
        Dim searchTerm As String = InstructorSearchBar.Text.Trim()
        If searchTerm <> "" Then
            Try
                connection.Open()

                Dim query As String = "SELECT * FROM instructors WHERE firstname LIKE @searchTerm OR middlename LIKE @searchTerm OR lastname LIKE @searchTerm OR instructorid LIKE @searchTerm"
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
        End If

        If String.IsNullOrEmpty(InstructorSearchBar.Text.Trim()) Then
            InstructorData()
        End If
    End Sub


    Private Sub InstructorsDataTable_SelectionChanged(sender As Object, e As EventArgs)
        InstructorsDataTable.ClearSelection()
    End Sub

    Private Sub Clear_Btn_Click(sender As Object, e As EventArgs) Handles Clear_Btn.Click
        InstructorSearchBar.Clear()
    End Sub

    Private Sub ViewInstructorInfo_Click(sender As Object, e As EventArgs) Handles ViewInstructorInfo.Click
        If InstructorsDataTable.SelectedRows.Count > 0 Then

            Dim selectedRow As DataGridViewRow = InstructorsDataTable.SelectedRows(0)
            Dim instructorid As String
            instructorid = selectedRow.Cells("instructorid").Value.ToString()

            AdminInstructorsInfo(instructorid)
        End If

    End Sub

    Private Sub AdminInstructorsInfo(instructorid)
        Dim query As String = "SELECT * FROM `instructors` WHERE instructorid = @instructorid"
        Using connection As New MySqlConnection(ConnectionString)
            Using command As New MySqlCommand(query, connection)

                command.Parameters.AddWithValue("@instructorid", instructorid)

                Try

                    connection.Open()

                    Using reader As MySqlDataReader = command.ExecuteReader

                        If reader.Read Then

                            Dim dateOnly As Date = Convert.ToDateTime(reader("birthday"))

                            InstructorsID_TB.Text = reader("instructorid").ToString()
                            FN_TB.Text = reader("firstname").ToString()
                            MN_TB.Text = reader("middlename").ToString()
                            LN_TB.Text = reader("lastname").ToString()
                            Sex_TB.Text = reader("gender").ToString()
                            CN_TB.Text = reader("contact#").ToString()
                            Birthday_TB.Text = dateOnly.ToString("MM-dd-yyyy")
                            Email_TB.Text = reader("email").ToString()


                        End If
                    End Using

                Catch ex As Exception

                End Try
            End Using
        End Using
        connection.Close()

    End Sub

    Private Sub ChangeGradeReq_Btn_Click(sender As Object, e As EventArgs) Handles ChangeGradeReq_Btn.Click
        ChangingGradeRequest.Show()
        Me.Enabled = False
    End Sub


End Class