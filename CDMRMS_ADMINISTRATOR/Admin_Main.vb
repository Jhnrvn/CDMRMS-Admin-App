Imports MySql.Data.MySqlClient

Public Class Admin_Main



    ' FORM LOAD - START
    Private Sub Admin_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dropdown_Panel.Size = Dropdown_Panel.MinimumSize
        Instructor_Panel.Hide()
        InstructorData()

    End Sub
    ' FORM LOAD - END



    ' DATABASE CONNECTION - START
    Private Shared ConnectionString As String = "server=localhost; port=3306; database=cdmregistrarmanagementsystem; uid=root; password=;"
    Private Shared connection As New MySqlConnection(ConnectionString)
    ' DATABASE CONNECTION - END



    ' DROP-DOWN MENU ANIMATION - START
    Dim MenuCollapsed As Boolean = True
    Private Sub Dropdown_Timer_Tick(sender As Object, e As EventArgs) Handles DropdownTimer.Tick
        If MenuCollapsed Then

            ' Change image of Menu button to Arrow Down
            Menu_Btn.Image = Image.FromFile("D:\Development Projects\Visual Basic\CDM Registrar Management System\CDMRMS_ADMINISTRATOR\Assets\Main\Arrow Down.png")
            Dropdown_Panel.Height += 10
            If Dropdown_Panel.Size = Dropdown_Panel.MaximumSize Then

                DropdownTimer.Stop()
                MenuCollapsed = False

            End If
        Else
            ' Hide Instructor Panel
            Instructor_Panel.Hide()

            ' Clear textbox that display instructors information 
            InstructorsID_TB.Clear()
            FN_TB.Clear()
            MN_TB.Clear()
            LN_TB.Clear()
            Sex_TB.Clear()
            CN_TB.Clear()
            Birthday_TB.Clear()
            Email_TB.Clear()

            ' Clear the table for assigned course and section
            AssignedCourseTable.DataSource = Nothing

            ' Change image of Menu button to arrow right
            Menu_Btn.Image = Image.FromFile("D:\Development Projects\Visual Basic\CDM Registrar Management System\CDMRMS_ADMINISTRATOR\Assets\Main\Arrow Right.png")

            Dropdown_Panel.Height -= 10
            If Dropdown_Panel.Size = Dropdown_Panel.MinimumSize Then

                DropdownTimer.Stop()
                MenuCollapsed = True

            End If
        End If

    End Sub

    ' Drop-down Menu button 
    Private Sub Menu_Btn_Click(sender As Object, e As EventArgs) Handles Menu_Btn.Click
        DropdownTimer.Start()

    End Sub
    ' DROP-DOWN MENU ANIMATION - END



    ' INSTRUCTOR PANEL - START
    Private Sub Instructor_Btn_Click(sender As Object, e As EventArgs) Handles Instructor_Btn.Click
        Instructor_Panel.Show()

    End Sub


    ' Query to display Instructor Name and Instructor ID
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


    ' Search Function for CDM Instructor Table
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


    ' Clear search bar button
    Private Sub Clear_Btn_Click(sender As Object, e As EventArgs) Handles Clear_Btn.Click
        InstructorSearchBar.Clear()
    End Sub

    Private Sub ViewInstructorInfo_Click(sender As Object, e As EventArgs) Handles ViewInstructorInfo.Click
        If InstructorsDataTable.SelectedRows.Count > 0 Then

            Dim selectedRow As DataGridViewRow = InstructorsDataTable.SelectedRows(0)
            Dim instructorid As String
            instructorid = selectedRow.Cells("instructorid").Value.ToString()

            AdminInstructorsInfo(instructorid)
            AssignedCourseAndSection(instructorid)
        End If

    End Sub


    ' Display instructor Information when you click the row from CDM instructor table
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


    ' Assigned Course and Section Table on Instructors Information  
    Private Sub AssignedCourseAndSection(instructorid)

        ' Display Assigned Course
        Dim query As String = "SELECT `course` FROM `assignedcourse` WHERE instructor_id = @instructorid"
        Using connection As New MySqlConnection(ConnectionString)
            connection.Open()

            Using coursecommand As New MySqlCommand(query, connection)
                coursecommand.Parameters.AddWithValue("@instructorid", instructorid)
                Dim dataTable As New DataTable()
                dataTable.Load(coursecommand.ExecuteReader())

                AssignedCourseTable.DataSource = dataTable
                AssignedCourseTable.Columns("course").Width = 218

            End Using

            Using sectioncommand As New MySqlCommand(query, connection)

            End Using

        End Using


        ' Display Assigned Section 

    End Sub


    ' Changing Grade Request Button
    Private Sub ChangeGradeReq_Btn_Click(sender As Object, e As EventArgs) Handles ChangeGradeReq_Btn.Click

        ChangingGradeRequest.Show()
        Me.Enabled = False

    End Sub


    ' Instructor Submitted Grade Button
    Private Sub InstructorSubmittedGrade_Btn_Click(sender As Object, e As EventArgs) Handles InstructorSubmittedGrade_Btn.Click

        InstructorSubmittedGrade.Show()
        Me.Enabled = False

    End Sub


    ' Assiged Course and Section Button
    Private Sub AssignedCourse_Btn_Click(sender As Object, e As EventArgs) Handles AssignedCourse_Btn.Click

        AssignedCourse_Section.Show()
        Me.Enabled = False

    End Sub
    ' INSTRUCTOR PANEL - END

End Class