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
        Dashboard_Panel.Hide()
        InstructorData()

        DeansListTable()
        Dashboard_Timer.Interval = 3000
        Dashboard_Timer.Start()

        Notification_Timer.Interval = 3000
        Notification_Timer.Start()

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
            Dashboard_Panel.Hide()
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

            MessageBox.Show("PIN validation successful. Access granted.", "PIN Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PinLock_Panel.Hide()
            Lock_Btn.Show()
            Menu_Btn.Enabled = True
            Student_Panel.Enabled = True
            Instructor_Panel.Enabled = True

            Pin_1.Clear()
            Pin_2.Clear()
            Pin_3.Clear()
            Pin_4.Clear()
        Else

            MessageBox.Show("Incorrect PIN. Access denied. Please retry.", "PIN Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Pin_1.Clear()
            Pin_2.Clear()
            Pin_3.Clear()
            Pin_4.Clear()
            Pin_1.Focus()
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
        Dim choice As DialogResult = MessageBox.Show("Are you sure you want to proceed with locking the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If choice = DialogResult.Yes Then
            If Dropdown_Panel.Size = Dropdown_Panel.MaximumSize Then
                Menu_Btn.PerformClick()
            End If

            PinLock_Panel.Show()
            Menu_Btn.Enabled = False
            Student_Panel.Enabled = False
            Instructor_Panel.Enabled = False
            Lock_Btn.Hide()


        End If

    End Sub
    ' ADMIN LOCK


    ' DASHBOARD PANEL - START
    Private Sub Dashboard_Btn_Click(sender As Object, e As EventArgs) Handles Dashboard_Btn.Click
        Dashboard_Panel.Show()
        Student_Panel.Hide()
        Instructor_Panel.Hide()

    End Sub

    Public Sub DeansListTable()

        Try
            connection.Open()

            Dim query As String = "SELECT * FROM deanslist ORDER BY `GWA` ASC"

            Dim command As New MySqlCommand(query, connection)

            Dim datatable As New DataTable()
            Using adapter As New MySqlDataAdapter(command)

                adapter.Fill(datatable)


                DeansList_Table.DataSource = datatable
                DeansList_Table.Columns("ID").Visible = False
                DeansList_Table.Columns("Student Name").Width = 150
                DeansList_Table.Columns("GWA").Width = 82

            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()

        End Try

    End Sub


    Private Sub Dashboard()

        Dim CountRow1, CountRow2, CountRow3, CountRow4 As Integer

        Try
            connection.Open()

            Dim query As String = "SELECT COUNT(*) FROM bsit"
            Dim command As New MySqlCommand(query, connection)

            CountRow1 = Convert.ToInt32(command.ExecuteScalar())

            BSITStudents_TB.Text = CountRow1
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
        End Try

        Try
            connection.Open()

            Dim query As String = "SELECT COUNT(*) FROM bscpe"
            Dim command As New MySqlCommand(query, connection)

            CountRow2 = Convert.ToInt32(command.ExecuteScalar())

            BSCPEStudents_TB.Text = CountRow2
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
        End Try

        Try
            connection.Open()

            Dim query As String = "SELECT COUNT(*) FROM deanslist"
            Dim command As New MySqlCommand(query, connection)

            CountRow3 = Convert.ToInt32(command.ExecuteScalar())

            DeansList_TB.Text = CountRow3

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
        End Try

        TotalStudents_TB.Text = CountRow1 + CountRow2

        Try
            connection.Open()

            Dim query As String = "SELECT COUNT(*) FROM instructors"
            Dim command As New MySqlCommand(query, connection)

            CountRow4 = Convert.ToInt32(command.ExecuteScalar())

            CDMInstrutors_TB.Text = CountRow4

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()

        End Try

    End Sub

    Private Sub Dashboard_Timer_Tick(sender As Object, e As EventArgs) Handles Dashboard_Timer.Tick
        Dashboard()

    End Sub

    Private Sub DashboardStudentSearchBar_textChanged(sender As Object, e As EventArgs) Handles DashboardStudentSearchBar.TextChanged
        Dim searchTerm As String = DashboardStudentSearchBar.Text.Trim

        If searchTerm <> "" Then
            Try
                connection.Open()

                Dim query As String = "SELECT `Student ID`, `Student Name`, `Program`, `Year`, `Section`, `GWA` FROM deanslist WHERE `Student ID` LIKE @searchTerm OR `Student Name` LIKE @searchTerm OR `Program` LIKE @searchTerm OR `Year` LIKE @searchTerm  OR `Section` LIKE @searchTerm OR `GWA` LIKE @searchTerm"
                Dim command As New MySqlCommand(query, connection)

                command.Parameters.AddWithValue("@searchTerm", "%" & searchTerm & "%")

                Dim dataTable As New DataTable()

                Dim adapter As New MySqlDataAdapter(command)
                adapter.Fill(dataTable)
                DeansList_Table.DataSource = dataTable
            Catch ex As Exception
                MessageBox.Show("Error searching data: " & ex.Message)
            Finally
                connection.Close()

            End Try
        End If

        If String.IsNullOrEmpty(DashboardStudentSearchBar.Text.Trim()) Then
            DeansListTable()
        End If

    End Sub
    Private Sub DBClear_Btn_Click(sender As Object, e As EventArgs) Handles DBClear_Btn.Click
        DashboardStudentSearchBar.Clear()
    End Sub


    ' DASHBOARD PANEL - END


    ' INSTRUCTOR PANEL - START
    Private Sub Instructor_Btn_Click(sender As Object, e As EventArgs) Handles Instructor_Btn.Click
        Instructor_Panel.Show()
        Student_Panel.Hide()
        Dashboard_Panel.Hide()

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

                Dim query As String = "SELECT `firstname`, `middlename`, `lastname`, `instructorid` FROM instructors WHERE firstname LIKE @searchTerm OR middlename LIKE @searchTerm OR lastname LIKE @searchTerm OR instructorid LIKE @searchTerm"
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


    ' Display instructor Information when you click the row from CDM instructor table
    Dim instructorid As String
    Private Sub InstructorsDataTable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles InstructorsDataTable.CellClick
        If e.RowIndex >= 0 Then

            Dim selectedRow As DataGridViewRow = InstructorsDataTable.Rows(e.RowIndex)
            instructorid = selectedRow.Cells("instructorid").Value.ToString()

            Dim sectionQuery As String = "SELECT * FROM instructors WHERE instructorid = @instructorid"
            Dim sectionAdapter As New MySqlDataAdapter(sectionQuery, connection)
            sectionAdapter.SelectCommand.Parameters.AddWithValue("@instructorid", instructorid)

            Using connection As New MySqlConnection(ConnectionString)
                Using command As New MySqlCommand(sectionQuery, connection)

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

                                If InstructorsDataTable.SelectedRows.Count > 0 Then


                                    Dim instructorid As String
                                    instructorid = selectedRow.Cells("instructorid").Value.ToString()


                                    AssignedCourse(instructorid)
                                End If
                            End If
                        End Using

                    Catch ex As Exception

                    End Try
                End Using
            End Using
            connection.Close()

        End If
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
                AssignedCourseTable.RowTemplate.Height = 30
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
            AssignedSectionTable.Columns("Program").Visible = False
        End If
    End Sub


    ' Changing Grade Request Button
    Private Sub ChangeGradeReq_Btn_Click(sender As Object, e As EventArgs) Handles ChangeGradeReq_Btn.Click

        ChangingGradeRequest.Show()
        Me.Enabled = False

    End Sub

    ' Notification Counter 
    Private Sub NotificationCounter()

        Using connection As New MySqlConnection(ConnectionString)
            connection.Open()

            Dim query As String = "SELECT COUNT(*) FROM `request`"
            Dim command As New MySqlCommand(query, connection)
            Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

            If count = 0 Then
                ChangeGradeReq_Btn.Image = Image.FromFile("D:\Development Projects\Visual Basic\CDM Registrar Management System\CDMRMS_ADMINISTRATOR\Assets\Main\Update Grade Button Icon.png")
            ElseIf count = 1 Then
                ChangeGradeReq_Btn.Image = Image.FromFile("D:\Development Projects\Visual Basic\CDM Registrar Management System\CDMRMS_ADMINISTRATOR\Assets\Main\Notification Counter\Notification Counter 1.png")
            ElseIf count = 2 Then
                ChangeGradeReq_Btn.Image = Image.FromFile("D:\Development Projects\Visual Basic\CDM Registrar Management System\CDMRMS_ADMINISTRATOR\Assets\Main\Notification Counter\Notification Counter 2.png")
            ElseIf count = 3 Then
                ChangeGradeReq_Btn.Image = Image.FromFile("D:\Development Projects\Visual Basic\CDM Registrar Management System\CDMRMS_ADMINISTRATOR\Assets\Main\Notification Counter\Notification Counter 3.png")
            ElseIf count = 4 Then
                ChangeGradeReq_Btn.Image = Image.FromFile("D:\Development Projects\Visual Basic\CDM Registrar Management System\CDMRMS_ADMINISTRATOR\Assets\Main\Notification Counter\Notification Counter 4.png")
            ElseIf count = 5 Then
                ChangeGradeReq_Btn.Image = Image.FromFile("D:\Development Projects\Visual Basic\CDM Registrar Management System\CDMRMS_ADMINISTRATOR\Assets\Main\Notification Counter\Notification Counter 5.png")
            ElseIf count = 6 Then
                ChangeGradeReq_Btn.Image = Image.FromFile("D:\Development Projects\Visual Basic\CDM Registrar Management System\CDMRMS_ADMINISTRATOR\Assets\Main\Notification Counter\Notification Counter 6.png")
            ElseIf count = 7 Then
                ChangeGradeReq_Btn.Image = Image.FromFile("D:\Development Projects\Visual Basic\CDM Registrar Management System\CDMRMS_ADMINISTRATOR\Assets\Main\Notification Counter\Notification Counter 7.png")
            ElseIf count = 8 Then
                ChangeGradeReq_Btn.Image = Image.FromFile("D:\Development Projects\Visual Basic\CDM Registrar Management System\CDMRMS_ADMINISTRATOR\Assets\Main\Notification Counter\Notification Counter 8.png")
            ElseIf count = 9 Then
                ChangeGradeReq_Btn.Image = Image.FromFile("D:\Development Projects\Visual Basic\CDM Registrar Management System\CDMRMS_ADMINISTRATOR\Assets\Main\Notification Counter\Notification Counter 9.png")
            ElseIf count > 9 Then
                ChangeGradeReq_Btn.Image = Image.FromFile("D:\Development Projects\Visual Basic\CDM Registrar Management System\CDMRMS_ADMINISTRATOR\Assets\Main\Notification Counter\Notification Counter 9+.png")
            End If

        End Using
        connection.Close()

    End Sub

    ' Notification Counter Timer
    Private Sub Notification_Timer_Tick(sender As Object, e As EventArgs) Handles Notification_Timer.Tick
        NotificationCounter()
    End Sub



    ' Assiged Course and Section Button
    Private Sub AssignedCourse_Btn_Click(sender As Object, e As EventArgs) Handles AssignedCourse_Btn.Click

        AssignedCourse_Section.Show()
        Me.Enabled = False

    End Sub



    ' INSTRUCTOR PANEL - END

    ' STUDENT PANEL - START

    Private Sub Student_Btn_Click(sender As Object, e As EventArgs) Handles Student_Btn.Click
        Student_Panel.Show()
        Instructor_Panel.Hide()
        Dashboard_Panel.Hide()
    End Sub


    Private adapter As New MySqlDataAdapter
    Private dataTable As New DataTable()


    ' Student list Table
    Public Sub StudentList()

        If CollegeProgramSelector.Text = "BSIT" Then

            dataTable = New DataTable

            Try
                dataTable.Clear()
                connection.Open()

                Dim selectQuery As String = "SELECT * FROM bsit"


                adapter = New MySqlDataAdapter(selectQuery, connection)
                adapter.Fill(dataTable)

                StudentlistTable.DataSource = dataTable
                StudentlistTable.Columns("Student ID").Width = 121
                StudentlistTable.Columns("Student Name").Width = 220
                StudentlistTable.Columns("ID").Visible = False
                StudentlistTable.Columns("1st Year 1st Sem Honor Status").Visible = False
                StudentlistTable.Columns("2nd Year 1st Sem Honor Status").Visible = False
                StudentlistTable.Columns("3rd Year 1st Sem Honor Status").Visible = False
                StudentlistTable.Columns("4th Year 1st Sem Honor Status").Visible = False

            Catch ex As Exception
                MessageBox.Show("Error fetching data: " & ex.Message)
            Finally
                connection.Close()
            End Try

        ElseIf CollegeProgramSelector.Text = "BSCPE" Then

            dataTable = New DataTable

            Try
                dataTable.Clear()
                connection.Open()

                Dim selectQuery As String = "SELECT * FROM bscpe"

                adapter = New MySqlDataAdapter(selectQuery, connection)

                adapter.Fill(dataTable)

                StudentlistTable.DataSource = dataTable
                StudentlistTable.Columns("Student ID").Width = 121
                StudentlistTable.Columns("Student Name").Width = 220
                StudentlistTable.Columns("ID").Visible = False
                StudentlistTable.Columns("1st Year 1st Sem Honor Status").Visible = False
                StudentlistTable.Columns("2nd Year 1st Sem Honor Status").Visible = False
                StudentlistTable.Columns("3rd Year 1st Sem Honor Status").Visible = False
                StudentlistTable.Columns("4th Year 1st Sem Honor Status").Visible = False

                Dim cmb As New DataGridViewComboBoxCell()
            Catch ex As Exception
                MessageBox.Show("Error fetching data: " & ex.Message)
            Finally
                connection.Close()
            End Try

        End If

        SaveData(dataTable)

    End Sub

    Private Sub SaveData(dataTable)

        Try

            Dim builder As New MySqlCommandBuilder(adapter)
            adapter.Update(dataTable)

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub


    ' Student Search Function
    Private Sub StudentSearchBar_TextChanged(sender As Object, e As EventArgs) Handles StudentSearchBar.TextChanged
        Dim searchTerm As String = StudentSearchBar.Text.Trim()

        If CollegeProgramSelector.Text = "BSIT" Then
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

        ElseIf CollegeProgramSelector.Text = "BSCPE" Then
            If searchTerm <> "" Then
                Try
                    connection.Open()

                    Dim query As String = "SELECT * FROM bscpe WHERE `Student ID` LIKE @searchTerm OR `Student Name` LIKE @searchTerm OR `Year` LIKE @searchTerm OR `Section` LIKE @searchTerm"
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
        End If

        If String.IsNullOrEmpty(StudentSearchBar.Text.Trim()) Then

            dataTable.Clear()
            StudentList()

        End If

    End Sub

    ' Delete Row from Student list Table
    Private Sub Delete_Btn_Click(sender As Object, e As EventArgs) Handles Delete_Btn.Click

        Dim choice As DialogResult = MessageBox.Show("Are you sure you want to delete this row?.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

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
        MessageBox.Show("Edit enabled.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        StudentlistTable.AllowUserToAddRows = True
        Delete_Btn.Enabled = False

        If CollegeProgramSelector.Text = "BSIT" Then

            ' Combobox For Program Columns
            For Each row1 As DataGridViewRow In StudentlistTable.Rows
                Dim ComboBoxCell As New DataGridViewComboBoxCell()

                ComboBoxCell.Items.Add("BSIT")

                row1.Cells("Program") = ComboBoxCell
            Next

        ElseIf CollegeProgramSelector.Text = "BSCPE" Then
            ' Combobox For Program Columns
            For Each row2 As DataGridViewRow In StudentlistTable.Rows
                Dim ComboBoxCell As New DataGridViewComboBoxCell()

                ComboBoxCell.Items.Add("BSCPE")

                row2.Cells("Program") = ComboBoxCell
            Next

        End If

        ' Combobox For Year Columns
        For Each row3 As DataGridViewRow In StudentlistTable.Rows
            Dim comboboxcell As New DataGridViewComboBoxCell()

            comboboxcell.Items.Add("1st Year")
            comboboxcell.Items.Add("2nd Year")
            comboboxcell.Items.Add("3rd Year")
            comboboxcell.Items.Add("4th Year")

            row3.Cells("Year") = comboboxcell

        Next

        ' Combobox For Semester Columns
        For Each row4 As DataGridViewRow In StudentlistTable.Rows
            Dim comboboxcell As New DataGridViewComboBoxCell()

            comboboxcell.Items.Add("1st Sem")
            comboboxcell.Items.Add("2nd Sem")

            row4.Cells("Semester") = comboboxcell

        Next

    End Sub

    Private Sub Save_Btn_Click(sender As Object, e As EventArgs) Handles Save_Btn.Click

        SaveData(dataTable)
        StudentlistTable.ReadOnly = True
        MessageBox.Show("Save successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        dataTable.Clear()
        StudentList()
        StudentlistTable.AllowUserToAddRows = False
        Delete_Btn.Enabled = True

    End Sub


    Private Sub CollegeProgramSelector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CollegeProgramSelector.SelectedIndexChanged
        StudentList()
    End Sub



    Private Sub EvaluateGrade_Btn_Click(sender As Object, e As EventArgs) Handles EvaluateGrade_Btn.Click
        EvaluateStudentGrades.Show()
        Me.Enabled = False
    End Sub



    ' STUDENT PANEL - END


    ' ABOUT PANEL - START
    Private Sub About_Btn_Click(sender As Object, e As EventArgs) Handles About_Btn.Click
        About.Show()

    End Sub
    ' ABOUT PANEL - END


End Class