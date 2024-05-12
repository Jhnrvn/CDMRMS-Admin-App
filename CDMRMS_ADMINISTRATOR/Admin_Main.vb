Imports MySql.Data.MySqlClient

Public Class Admin_Main



    ' FORM LOAD - START
    Private Sub Admin_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PinLock_Panel.Show()
        Lock_Btn.Hide()
        Menu_Btn.Enabled = False

        Dropdown_Panel.Size = Dropdown_Panel.MinimumSize
        Instructor_Panel.Hide()
        Student_Panel.Hide()
        InstructorData()



        StudentlistTable.ReadOnly = True
        StudentlistTable.AllowUserToAddRows = False

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
            Student_Panel.Hide()
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
            AssignedSectionTable.Columns.Clear()

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


    ' ADMIN PIN  - START

    Private Sub LockAdmin()

        Dim pin As String = "1111"
        Dim userPin As String = Pin_1.Text + Pin_2.Text + Pin_3.Text + Pin_4.Text

        If userPin = pin Then

            MsgBox("Correct Pin!", MessageBoxIcon.Information)
            PinLock_Panel.Hide()
            Lock_Btn.Show()
            Menu_Btn.Enabled = True

            Pin_1.Clear()
            Pin_2.Clear()
            Pin_3.Clear()
            Pin_4.Clear()
        Else

            MsgBox("Wrong Pin!", MessageBoxIcon.Error)

            Pin_1.Clear()
            Pin_2.Clear()
            Pin_3.Clear()
            Pin_4.Clear()

        End If
    End Sub

    Private Sub Pin_1_TextChanged(sender As Object, e As EventArgs) Handles Pin_1.TextChanged, Pin_2.TextChanged, Pin_3.TextChanged, Pin_4.TextChanged

        If Pin_1.Text.Length = 1 Then
            Pin_2.Focus()
        End If

        If Pin_2.Text.Length = 1 Then
            Pin_3.Focus()
        End If

        If Pin_3.Text.Length = 1 Then
            Pin_4.Focus()
        End If


    End Sub


    Private Sub Verify_Btn_Click(sender As Object, e As EventArgs) Handles Verify_Btn.Click

        LockAdmin()

    End Sub

    Private Sub Lock_Btn_Click(sender As Object, e As EventArgs) Handles Lock_Btn.Click
        Dim choice As DialogResult = MsgBox("Are you sure?", MessageBoxButtons.YesNo)

        If choice = DialogResult.Yes Then
            If Dropdown_Panel.Size = Dropdown_Panel.MaximumSize Then
                Menu_Btn.PerformClick()
            End If

            PinLock_Panel.Show()
            Menu_Btn.Enabled = False
            Lock_Btn.Hide()


        End If

    End Sub
    ' ADMIN LOCK



    ' INSTRUCTOR PANEL - START
    Private Sub Instructor_Btn_Click(sender As Object, e As EventArgs) Handles Instructor_Btn.Click
        Instructor_Panel.Show()
        Student_Panel.Hide()

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
                InstructorsDataTable.ColumnHeadersHeight = 200

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
            AssignedCourse(instructorid)
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


    ' Assigned Course Table on Instructors Information  
    Private Sub AssignedCourse(instructorid)

        ' Display Assigned Course
        Dim CourseQuery As String = "SELECT `course` FROM `assignedcourse` WHERE instructor_id = @instructorid"
        Using connection As New MySqlConnection(ConnectionString)
            connection.Open()

            Using CourseCommand As New MySqlCommand(CourseQuery, connection)
                CourseCommand.Parameters.AddWithValue("@instructorid", instructorid)
                Dim dataTable As New DataTable()
                dataTable.Load(CourseCommand.ExecuteReader())
                AssignedCourseTable.RowTemplate.Height = 36
                AssignedCourseTable.DataSource = dataTable

                AssignedCourseTable.Columns("course").Width = 295

            End Using

        End Using

    End Sub


    ' Will show the section handled by the instructor when you click the course from the course table on the Instructor Information
    Private Sub AssignedCourseTable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles AssignedCourseTable.CellClick
        If e.RowIndex >= 0 Then

            Dim selectedRow As DataGridViewRow = AssignedCourseTable.Rows(e.RowIndex)
            Dim course As String = selectedRow.Cells("course").Value.ToString()

            Dim sectionQuery As String = "SELECT * FROM assignedcourse WHERE course = @course"
            Dim sectionAdapter As New MySqlDataAdapter(sectionQuery, connection)
            sectionAdapter.SelectCommand.Parameters.AddWithValue("@course", course)
            Dim dataTable As New DataTable()
            AssignedSectionTable.RowTemplate.Height = 60
            sectionAdapter.Fill(dataTable)

            AssignedSectionTable.DataSource = dataTable
            AssignedSectionTable.Columns("id").Visible = False
            AssignedSectionTable.Columns("instructor_id").Visible = False
            AssignedSectionTable.Columns("Instructor").Visible = False
            AssignedSectionTable.Columns("course").Visible = False
        End If
    End Sub


    ' Changing Grade Request Button
    Private Sub ChangeGradeReq_Btn_Click(sender As Object, e As EventArgs) Handles ChangeGradeReq_Btn.Click

        ChangingGradeRequest.Show()
        Me.Enabled = False

    End Sub


    ' Assiged Course and Section Button
    Private Sub AssignedCourse_Btn_Click(sender As Object, e As EventArgs) Handles AssignedCourse_Btn.Click

        AssignedCourse_Section.Show()
        Me.Enabled = False

    End Sub

    Private Sub Student_Btn_Click(sender As Object, e As EventArgs) Handles Student_Btn.Click
        Student_Panel.Show()
        Instructor_Panel.Hide()
    End Sub

    ' INSTRUCTOR PANEL - END

    ' STUDENT PANEL - START

    Dim adapter As New MySqlDataAdapter
    Dim dataTable As New DataTable()

    ' Student list Table
    Private Sub StudentList()

        dataTable.Clear()

        If CollegeProgramSelector.Text = "BSIT" Then
            Try

                connection.Open()

                Dim selectQuery As String = "SELECT * FROM bsit"

                adapter = New MySqlDataAdapter(selectQuery, connection)
                adapter.Fill(dataTable)

                StudentlistTable.DataSource = dataTable
                StudentlistTable.Columns("Student ID").Width = 121
                StudentlistTable.Columns("Student Name").Width = 250
                StudentlistTable.Columns("ID").Visible = False

            Catch ex As Exception
                MessageBox.Show("Error fetching data: " & ex.Message)
            Finally
                connection.Close()
            End Try


        ElseIf CollegeProgramSelector.Text = "BSCPE" Then
            Try

                connection.Open()

                Dim selectQuery As String = "SELECT * FROM bscpe"

                adapter = New MySqlDataAdapter(selectQuery, connection)
                adapter.Fill(dataTable)

                StudentlistTable.DataSource = dataTable
                StudentlistTable.Columns("Student ID").Width = 121
                StudentlistTable.Columns("Student Name").Width = 250
                StudentlistTable.Columns("ID").Visible = False

            Catch ex As Exception
                MessageBox.Show("Error fetching data: " & ex.Message)
            Finally
                connection.Close()
            End Try

        End If



    End Sub

    Private Sub SaveData()
        Dim builder As New MySqlCommandBuilder(adapter)
        adapter.Update(dataTable)
    End Sub



    ' Student Search Function
    Private Sub StudentSearchBar_TextChanged(sender As Object, e As EventArgs) Handles StudentSearchBar.TextChanged
        Dim searchTerm As String = StudentSearchBar.Text.Trim()

        If searchTerm <> "" Then
            Try
                connection.Open()

                Dim query As String = "SELECT * FROM bsit WHERE `Student ID` LIKE @searchTerm OR `Student Name` LIKE @searchTerm OR `Year` LIKE @searchTerm OR `Section` LIKE @searchTerm"
                Dim command As New MySqlCommand(query, connection)

                command.Parameters.AddWithValue("@searchTerm", "%" & searchTerm & "%")

                Dim dataTable As New DataTable()

                Dim adapter As New MySqlDataAdapter(command)
                adapter.Fill(dataTable)
                StudentlistTable.DataSource = dataTable
            Catch ex As Exception
                MessageBox.Show("Error searching data: " & ex.Message)
            Finally
                connection.Close()

            End Try
        End If

        If String.IsNullOrEmpty(StudentSearchBar.Text.Trim()) Then
            dataTable.Clear()
            StudentList()

        End If
    End Sub

    ' Delete Row from Student list Table
    Private Sub Delete_Btn_Click(sender As Object, e As EventArgs) Handles Delete_Btn.Click

        Dim choice As DialogResult = MsgBox("Delete selected row?", MessageBoxButtons.YesNo)

        If choice = DialogResult.Yes Then

            If StudentlistTable.SelectedRows.Count > 0 Then

                Dim selectedRow As DataGridViewRow = StudentlistTable.SelectedRows(0)
                Dim ID As String
                ID = selectedRow.Cells("ID").Value.ToString()

                Dim DeleteQuery As String = ""

                If CollegeProgramSelector.Text = "BSIT" Then
                    DeleteQuery = " DELETE FROM bsit WHERE `ID` = @ID "

                ElseIf CollegeProgramSelector.Text = "BSCPE" Then
                    DeleteQuery = " DELETE FROM bscpe WHERE `ID` = @ID "

                End If

                Try

                    connection.Open()

                    Using DeleteCommand As New MySqlCommand(DeleteQuery, connection)
                        DeleteCommand.Parameters.AddWithValue("@ID", ID)
                        DeleteCommand.ExecuteNonQuery()

                    End Using

                    MsgBox("Row deleted successfully.", MessageBoxIcon.Information)

                Catch ex As Exception

                    MsgBox("error" & ex.Message)

                Finally
                    connection.Close()

                End Try
                dataTable.Clear()
                StudentList()

            End If

        End If
    End Sub

    ' Edit Student List Table
    Private Sub Edit_Btn_Click(sender As Object, e As EventArgs) Handles Edit_Btn.Click

        StudentlistTable.ReadOnly = False
        MsgBox("Edit Enabled.", MessageBoxIcon.Information)
        StudentlistTable.AllowUserToAddRows = True
        Delete_Btn.Enabled = False

    End Sub

    Private Sub Save_Btn_Click(sender As Object, e As EventArgs) Handles Save_Btn.Click

        SaveData()
        StudentlistTable.ReadOnly = True
        MsgBox("Update successful!", MessageBoxIcon.Information)
        dataTable.Clear()
        StudentList()
        StudentlistTable.AllowUserToAddRows = False
        Delete_Btn.Enabled = True
    End Sub


    Private Sub CollegeProgramSelector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CollegeProgramSelector.SelectedIndexChanged
        StudentList()
    End Sub

    Private Sub StudentSearchBar_Click(sender As Object, e As EventArgs) Handles StudentSearchBar.Click
        If String.IsNullOrEmpty(CollegeProgramSelector.Text) Then
            StudentSearchBar.Enabled = False
        Else
            StudentSearchBar.Enabled = True
        End If
    End Sub

    Private Sub EvaluateGrade_Btn_Click(sender As Object, e As EventArgs) Handles EvaluateGrade_Btn.Click
        EvaluateStudentGrades.Show()
        Me.Enabled = False
    End Sub




    ' STUDENT PANEL - END



End Class