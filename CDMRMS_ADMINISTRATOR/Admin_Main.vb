Imports MySql.Data.MySqlClient

Public Class Admin_Main



    ' FORM LOAD - START
    Private Sub Admin_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Menu_Panel.Size = Menu_Panel.MinimumSize

        PinLock_Panel.Show()
        NavLinksHide()
        Menu_Btn.Hide()

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
            Menu_Panel.Height += 15
            If Menu_Panel.Size = Menu_Panel.MaximumSize Then

                DropdownTimer.Stop()
                MenuCollapsed = False

            End If
        Else

            Menu_Panel.Height -= 15
            If Menu_Panel.Size = Menu_Panel.MinimumSize Then

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


    ' NAVIGATION BAR LINKS - START
    Private Sub NavLinksHide()
        Home_link.Visible = False
        Dashboard_Link.Visible = False
        Instructors_Link.Visible = False
        Students_link.Visible = False
    End Sub

    Private Sub Home_link_MouseHover(sender As Object, e As EventArgs) Handles Home_link.MouseHover
        Home_link.LinkColor = Color.FromArgb(255, 201, 48)
    End Sub

    Private Sub Dashboard_link_MouseHover(sender As Object, e As EventArgs) Handles Dashboard_Link.MouseHover
        Dashboard_Link.LinkColor = Color.FromArgb(255, 201, 48)
    End Sub

    Private Sub Instructors_link_MouseHover(sender As Object, e As EventArgs) Handles Instructors_Link.MouseHover
        Instructors_Link.LinkColor = Color.FromArgb(255, 201, 48)
    End Sub

    Private Sub Students_link_MouseHover(sender As Object, e As EventArgs) Handles Students_link.MouseHover
        Students_link.LinkColor = Color.FromArgb(255, 201, 48)
    End Sub

    Private Sub Home_link_MouseLeave(sender As Object, e As EventArgs) Handles Home_link.MouseLeave, Dashboard_Link.MouseLeave, Instructors_Link.MouseLeave, Students_link.MouseLeave

        Home_link.LinkColor = Color.White
        Dashboard_Link.LinkColor = Color.White
        Instructors_Link.LinkColor = Color.White
        Students_link.LinkColor = Color.White

    End Sub

    Private Sub Home_link_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Home_link.LinkClicked
        Dashboard_Panel.Hide()
        Instructor_Panel.Hide()
        Student_Panel.Hide()
    End Sub

    Private Sub Dashboard_Link_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Dashboard_Link.LinkClicked
        Dashboard_Panel.Show()
        Instructor_Panel.Hide()
        Student_Panel.Hide()
    End Sub

    Private Sub Instructors_Link_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Instructors_Link.LinkClicked
        Instructor_Panel.Show()
        Dashboard_Panel.Hide()
        Student_Panel.Hide()
    End Sub

    Private Sub Students_link_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Students_link.LinkClicked
        Student_Panel.Show()
        Dashboard_Panel.Hide()
        Instructor_Panel.Hide()
    End Sub
    ' NAVIGATION BAR LINKS - END



    ' ADMIN PIN  - START
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

        If Not String.IsNullOrEmpty(Pin_1.Text) And Not String.IsNullOrEmpty(Pin_2.Text) And Not String.IsNullOrEmpty(Pin_3.Text) And Not String.IsNullOrEmpty(Pin_4.Text) Then
            Dim pin As String = "1111"
            Dim userPin As String = Pin_1.Text + Pin_2.Text + Pin_3.Text + Pin_4.Text

            If userPin = pin Then

                MessageBox.Show("PIN verified successfully. You may proceed.", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                PinLock_Panel.Hide()
                Menu_Btn.Show()
                Student_Panel.Enabled = True
                Instructor_Panel.Enabled = True

                Home_link.Visible = True
                Dashboard_Link.Visible = True
                Instructors_Link.Visible = True
                Students_link.Visible = True

                Lock_Btn.Enabled = True

                Pin_1.Clear()
                Pin_2.Clear()
                Pin_3.Clear()
                Pin_4.Clear()
            Else

                MessageBox.Show("The PIN you entered is incorrect. Please try again.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Pin_1.Clear()
                Pin_2.Clear()
                Pin_3.Clear()
                Pin_4.Clear()
                Pin_1.Focus()
            End If
        End If

    End Sub

    Private Sub Lock_Btn_Click(sender As Object, e As EventArgs) Handles Lock_Btn.Click
        Dim choice As DialogResult = MessageBox.Show("Are you sure you want to proceed with locking the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


        If choice = DialogResult.Yes Then
            PinLock_Panel.Show()

            Menu_Panel.Size = Menu_Panel.MinimumSize
            MenuCollapsed = True
            Student_Panel.Enabled = False
            Instructor_Panel.Enabled = False
            Menu_Btn.Hide()

            Dashboard_Panel.Hide()
            Instructor_Panel.Hide()
            Student_Panel.Hide()
            Lock_Btn.Enabled = False

            NavLinksHide()
        End If

    End Sub
    ' ADMIN LOCK


    ' DASHBOARD PANEL - START

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

                Dim query As String = "SELECT `Student ID`, `Student Name`, `Program`, `Year`, `Section`, `GWA` FROM deanslist WHERE `Student ID` LIKE @searchTerm OR `Student Name` LIKE @searchTerm OR `Program` LIKE @searchTerm OR `Year` LIKE @searchTerm  OR `Section` LIKE @searchTerm OR `GWA` LIKE @searchTerm ORDER BY `GWA` ASC"
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
                InstructorsDataTable.Columns("firstname").Width = 128
                InstructorsDataTable.Columns("middlename").Width = 120
                InstructorsDataTable.Columns("lastname").Width = 128
                InstructorsDataTable.Columns("instructorid").Width = 139

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

    ' Courses handled by instructor
    Private Sub AssignedCourse(instructorid)

        ' Display Assigned Course
        Dim CourseQuery As String = "SELECT `course` FROM `assignedcourse` WHERE instructor_id = @instructorid"
        Using connection As New MySqlConnection(ConnectionString)
            connection.Open()

            Using CourseCommand As New MySqlCommand(CourseQuery, connection)
                CourseCommand.Parameters.AddWithValue("@instructorid", instructorid)
                Using reader As MySqlDataReader = CourseCommand.ExecuteReader()
                    Instructor_Courses.Items.Clear()

                    While reader.Read()
                        Instructor_Courses.Items.Add(reader("course").ToString)
                    End While

                End Using
            End Using
        End Using
    End Sub

    Private Sub Instructor_Courses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Instructor_Courses.SelectedIndexChanged
        Dim selectedCourse As String = Instructor_Courses.Text.Trim
        Dim Instructor As String = instructorid
        Try
            connection.Open()
            Dim SectionQuery As String = $"SELECT * FROM assignedcourse WHERE course = @selectedCourse AND instructor_id = @instructorId"
            Dim command As New MySqlCommand(SectionQuery, connection)
            command.Parameters.AddWithValue("@selectedCourse", selectedCourse)
            command.Parameters.AddWithValue("@instructorId", Instructor)
            Dim reader As MySqlDataReader = command.ExecuteReader()

            While reader.Read()
                Section1.Text = reader("section_1").ToString()
                Section2.Text = reader("section_2").ToString()
                Section3.Text = reader("section_3").ToString()
                Section4.Text = reader("section_4").ToString()
                Section5.Text = reader("section_5").ToString()
                Section6.text = reader("section_6").ToString()
                Section7.Text = reader("section_7").ToString()
                Section8.Text = reader("section_8").ToString()
                Section9.Text = reader("section_9").ToString()
                Section10.text = reader("section_10").ToString()
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub

    ' Changing Grade Request Button
    Private Sub ChangeGradeReq_Btn_Click(sender As Object, e As EventArgs) Handles ReviewUserRequest_Btn.Click

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
                ReviewUserRequest_Btn.Image = My.Resources.Review_User_Request_Icon
            ElseIf count = 1 Then
                ReviewUserRequest_Btn.Image = My.Resources.Notification_1
            ElseIf count = 2 Then
                ReviewUserRequest_Btn.Image = My.Resources.Notification_2
            ElseIf count = 3 Then
                ReviewUserRequest_Btn.Image = My.Resources.Notification_3
            ElseIf count = 4 Then
                ReviewUserRequest_Btn.Image = My.Resources.Notification_4
            ElseIf count = 5 Then
                ReviewUserRequest_Btn.Image = My.Resources.Notification_5
            ElseIf count = 6 Then
                ReviewUserRequest_Btn.Image = My.Resources.Notification_6
            ElseIf count = 7 Then
                ReviewUserRequest_Btn.Image = My.Resources.Notification_7
            ElseIf count = 8 Then
                ReviewUserRequest_Btn.Image = My.Resources.Notification_8
            ElseIf count = 9 Then
                ReviewUserRequest_Btn.Image = My.Resources.Notification_9
            ElseIf count > 9 Then
                ReviewUserRequest_Btn.Image = My.Resources.Notification_9_
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
                StudentlistTable.Columns("Student ID").Width = 110
                StudentlistTable.Columns("Student Name").Width = 204
                StudentlistTable.Columns("Program").Width = 80
                StudentlistTable.Columns("ID").Visible = False
                StudentlistTable.Columns("1st Year 1st Sem Honor Status").Visible = False
                StudentlistTable.Columns("2nd Year 1st Sem Honor Status").Visible = False
                StudentlistTable.Columns("3rd Year 1st Sem Honor Status").Visible = False
                StudentlistTable.Columns("4th Year 1st Sem Honor Status").Visible = False
                StudentlistTable.Columns("1st Year 2nd Sem Honor Status").Visible = False
                StudentlistTable.Columns("2nd Year 2nd Sem Honor Status").Visible = False
                StudentlistTable.Columns("3rd Year 2nd Sem Honor Status").Visible = False
                StudentlistTable.Columns("4th Year 2nd Sem Honor Status").Visible = False

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
                StudentlistTable.Columns("1st Year 2nd Sem Honor Status").Visible = False
                StudentlistTable.Columns("2nd Year 2nd Sem Honor Status").Visible = False
                StudentlistTable.Columns("3rd Year 2nd Sem Honor Status").Visible = False
                StudentlistTable.Columns("4th Year 2nd Sem Honor Status").Visible = False

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



    Private Sub StudentlistTable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentlistTable.CellClick

        Course_Label1.Text = ""
        Course_Label2.Text = ""
        Course_Label3.Text = ""
        Course_Label4.Text = ""
        Course_Label5.Text = ""
        Course_Label6.Text = ""
        Course_Label7.Text = ""
        Course_Label8.Text = ""

        Grade_TB1.Clear()
        Grade_TB2.Clear()
        Grade_TB3.Clear()
        Grade_TB4.Clear()
        Grade_TB5.Clear()
        Grade_TB6.Clear()
        Grade_TB7.Clear()
        Grade_TB8.Clear()
        Grade_TB9.Clear()

        If e.RowIndex >= 0 Then

            Dim selectedRow As DataGridViewRow = StudentlistTable.Rows(e.RowIndex)
            Dim studentid As String = selectedRow.Cells("Student ID").Value.ToString()
            Dim program As String = selectedRow.Cells("Program").Value.ToString()


            Dim sectionQuery As String = $"SELECT * FROM `{program}` WHERE `Student ID` = @studentid"
            Dim sectionAdapter As New MySqlDataAdapter(sectionQuery, connection)
            sectionAdapter.SelectCommand.Parameters.AddWithValue("@studentid", studentid)


            Using connection As New MySqlConnection(ConnectionString)
                Using command As New MySqlCommand(sectionQuery, connection)

                    command.Parameters.AddWithValue("@studentid", studentid)

                    Try
                        connection.Open()

                        Using reader As MySqlDataReader = command.ExecuteReader

                            If reader.Read Then

                                If program = "BSIT" Then
                                    If Year_CB.Text = "1st" And Sem_CB.Text = "1st" Then

                                        Course_Label1.Text = "IT COMP"
                                        Course_Label2.Text = "PROG 1"
                                        Course_Label3.Text = "GE 2"
                                        Course_Label4.Text = "GE MATH"
                                        Course_Label5.Text = "GE 1"
                                        Course_Label6.Text = "GE FIL 1"
                                        Course_Label7.Text = "PE 1"
                                        Course_Label8.Text = "NSTP 1"

                                        Grade_TB1.Text = reader("ITCOMP").ToString()
                                        Grade_TB2.Text = reader("PROG 1").ToString()
                                        Grade_TB3.Text = reader("GE 2").ToString()
                                        Grade_TB4.Text = reader("GE MATH").ToString()
                                        Grade_TB5.Text = reader("GE 1").ToString()
                                        Grade_TB6.Text = reader("GE FIL 1").ToString()
                                        Grade_TB7.Text = reader("PE 1").ToString()
                                        Grade_TB8.Text = reader("NSTP 1").ToString()
                                        Grade_TB9.Text = reader("1st Year 1st Sem GWA")

                                    ElseIf Year_CB.Text = "1st" And Sem_CB.Text = "2nd" Then

                                        Course_Label1.Text = "DISCRETE"
                                        Course_Label2.Text = "PROG 2"
                                        Course_Label3.Text = "GE 3"
                                        Course_Label4.Text = "HUM"
                                        Course_Label5.Text = "GE FIL 2"
                                        Course_Label6.Text = "GEEL 2"
                                        Course_Label7.Text = "PE 2"
                                        Course_Label8.Text = "NSTP 2"

                                        Grade_TB1.Text = reader("DISCRETE").ToString()
                                        Grade_TB2.Text = reader("PROG 2").ToString()
                                        Grade_TB3.Text = reader("GE 3").ToString()
                                        Grade_TB4.Text = reader("HUM").ToString()
                                        Grade_TB5.Text = reader("GE FIL 2").ToString()
                                        Grade_TB6.Text = reader("GEEL 2").ToString()
                                        Grade_TB7.Text = reader("PE 2").ToString()
                                        Grade_TB8.Text = reader("NSTP 2").ToString()
                                        Grade_TB9.Text = reader("1st Year 2nd Sem GWA")

                                    ElseIf Year_CB.Text = "2nd" And Sem_CB.Text = "1st" Then

                                        Course_Label1.Text = "PROG 3"
                                        Course_Label2.Text = "ELECT 1"
                                        Course_Label3.Text = "GE 4"
                                        Course_Label4.Text = "GE 12"
                                        Course_Label5.Text = "SIA 1"
                                        Course_Label6.Text = "SP"
                                        Course_Label7.Text = "GE SCI"
                                        Course_Label8.Text = "PE 3"

                                        Grade_TB1.Text = reader("PROG 3").ToString()
                                        Grade_TB2.Text = reader("ELECT 1").ToString()
                                        Grade_TB3.Text = reader("GE 4").ToString()
                                        Grade_TB4.Text = reader("GE 12").ToString()
                                        Grade_TB5.Text = reader("SIA 1").ToString()
                                        Grade_TB6.Text = reader("SP").ToString()
                                        Grade_TB7.Text = reader("GE SCI").ToString()
                                        Grade_TB8.Text = reader("PE 3").ToString()
                                        Grade_TB9.Text = reader("2nd Year 1st Sem GWA")

                                    ElseIf Year_CB.Text = "2nd" And Sem_CB.Text = "2nd" Then

                                        Course_Label1.Text = "ACSS"
                                        Course_Label2.Text = "ELECT 2"
                                        Course_Label3.Text = "NET 1"
                                        Course_Label4.Text = "GE 5"
                                        Course_Label5.Text = "FUDBS"
                                        Course_Label6.Text = "SSD"
                                        Course_Label7.Text = "IPTECH"
                                        Course_Label8.Text = "PE 4"

                                        Grade_TB1.Text = reader("ACSS").ToString()
                                        Grade_TB2.Text = reader("ELECT 2").ToString()
                                        Grade_TB3.Text = reader("NET 1").ToString()
                                        Grade_TB4.Text = reader("GE 5").ToString()
                                        Grade_TB5.Text = reader("FUDBS").ToString()
                                        Grade_TB6.Text = reader("SSD").ToString()
                                        Grade_TB7.Text = reader("IPTECH").ToString()
                                        Grade_TB8.Text = reader("PE 4").ToString()
                                        Grade_TB9.Text = reader("2nd Year 2nd Sem GWA")

                                    ElseIf Year_CB.Text = "3rd" And Sem_CB.Text = "1st" Then

                                        Course_Label1.Text = "NET 2"
                                        Course_Label2.Text = "IM 1"
                                        Course_Label3.Text = "APPSDEV 1"
                                        Course_Label4.Text = "OS"
                                        Course_Label5.Text = "IAS 1"
                                        Course_Label6.Text = "HCI"
                                        Course_Label7.Text = "ADBS"
                                        Course_Label8.Text = "ELECT 3"

                                        Grade_TB1.Text = reader("NET 2").ToString()
                                        Grade_TB2.Text = reader("IM 1").ToString()
                                        Grade_TB3.Text = reader("APPSDEV 1").ToString()
                                        Grade_TB4.Text = reader("OS").ToString()
                                        Grade_TB5.Text = reader("IAS 1").ToString()
                                        Grade_TB6.Text = reader("HCI").ToString()
                                        Grade_TB7.Text = reader("ADBS").ToString()
                                        Grade_TB8.Text = reader("ELECT 3").ToString()
                                        Grade_TB9.Text = reader("3rd Year 1st Sem GWA")

                                    ElseIf Year_CB.Text = "3rd" And Sem_CB.Text = "2nd" Then

                                        Course_Label1.Text = "GE RIZAL"
                                        Course_Label2.Text = "IM 2"
                                        Course_Label3.Text = "QM"
                                        Course_Label4.Text = "SA"
                                        Course_Label5.Text = "IAS 2"
                                        Course_Label6.Text = "CAPSTONE 1"
                                        Course_Label7.Text = "ELECT 4"

                                        Grade_TB1.Text = reader("GE RIZAL").ToString()
                                        Grade_TB2.Text = reader("IM 2").ToString()
                                        Grade_TB3.Text = reader("QM").ToString()
                                        Grade_TB4.Text = reader("SA").ToString()
                                        Grade_TB5.Text = reader("IAS 2").ToString()
                                        Grade_TB6.Text = reader("CAPSTONE 1").ToString()
                                        Grade_TB7.Text = reader("ELECT 4").ToString()
                                        Grade_TB9.Text = reader("3rd Year 2nd Sem GWA")

                                    ElseIf Year_CB.Text = "4th" And Sem_CB.Text = "1st" Then

                                        Course_Label1.Text = "CAPSTONE 2"

                                        Grade_TB1.Text = reader("CAPSTONE 2").ToString()
                                        Grade_TB9.Text = reader("4th Year 1st Sem GWA")

                                    ElseIf Year_CB.Text = "4th" And Sem_CB.Text = "2nd" Then
                                        Course_Label1.Text = " PRACTICUM"

                                        Grade_TB1.Text = reader("PRACTICUM").ToString()
                                        Grade_TB9.Text = reader("4th Year 2nd Sem GWA")
                                    End If
                                ElseIf program = "BSCPE" Then
                                    If Year_CB.Text = "1st" And Sem_CB.Text = "1st" Then

                                        Course_Label1.Text = "Subject 1"
                                        Course_Label2.Text = "Subject 2"
                                        Course_Label3.Text = "Subject 3"
                                        Course_Label4.Text = "Subject 4"
                                        Course_Label5.Text = "Subject 5"
                                        Course_Label6.Text = "Subject 6"
                                        Course_Label7.Text = "PE 1"
                                        Course_Label8.Text = "NSTP 1"

                                        Grade_TB1.Text = reader("SUBJECT 1").ToString()
                                        Grade_TB2.Text = reader("SUBJECT 2").ToString()
                                        Grade_TB3.Text = reader("SUBJECT 3").ToString()
                                        Grade_TB4.Text = reader("SUBJECT 4").ToString()
                                        Grade_TB5.Text = reader("SUBJECT 5").ToString()
                                        Grade_TB6.Text = reader("SUBJECT 6").ToString()
                                        Grade_TB7.Text = reader("PE 1").ToString()
                                        Grade_TB8.Text = reader("NSTP 1").ToString()
                                        Grade_TB9.Text = reader("1st Year 1st Sem GWA")

                                    ElseIf Year_CB.Text = "1st" And Sem_CB.Text = "2nd" Then

                                        Course_Label1.Text = "Subject 7"
                                        Course_Label2.Text = "Subject 8"
                                        Course_Label3.Text = "Subject 9"
                                        Course_Label4.Text = "Subject 10"
                                        Course_Label5.Text = "Subject 11"
                                        Course_Label6.Text = "Subject 12"
                                        Course_Label7.Text = "PE 2"
                                        Course_Label8.Text = "NSTP 2"

                                        Grade_TB1.Text = reader("SUBJECT 7").ToString()
                                        Grade_TB2.Text = reader("SUBJECT 8").ToString()
                                        Grade_TB3.Text = reader("SUBJECT 9").ToString()
                                        Grade_TB4.Text = reader("SUBJECT 10").ToString()
                                        Grade_TB5.Text = reader("SUBJECT 11").ToString()
                                        Grade_TB6.Text = reader("SUBJECT 12").ToString()
                                        Grade_TB7.Text = reader("PE 2").ToString()
                                        Grade_TB8.Text = reader("NSTP 2").ToString()
                                        Grade_TB9.Text = reader("1st Year 2nd Sem GWA")

                                    ElseIf Year_CB.Text = "2nd" And Sem_CB.Text = "1st" Then

                                        Course_Label1.Text = "Subject 13"
                                        Course_Label2.Text = "Subject 14"
                                        Course_Label3.Text = "Subject 15"
                                        Course_Label4.Text = "Subject 16"
                                        Course_Label5.Text = "Subject 17"
                                        Course_Label6.Text = "Subject 18"
                                        Course_Label7.Text = "Subject 19"
                                        Course_Label8.Text = "PE 3"

                                        Grade_TB1.Text = reader("SUBJECT 13").ToString()
                                        Grade_TB2.Text = reader("SUBJECT 14").ToString()
                                        Grade_TB3.Text = reader("SUBJECT 15").ToString()
                                        Grade_TB4.Text = reader("SUBJECT 16").ToString()
                                        Grade_TB5.Text = reader("SUBJECT 17").ToString()
                                        Grade_TB6.Text = reader("SUBJECT 18").ToString()
                                        Grade_TB7.Text = reader("SUBJECT 19").ToString()
                                        Grade_TB8.Text = reader("PE 3").ToString()
                                        Grade_TB9.Text = reader("2nd Year 1st Sem GWA")

                                    ElseIf Year_CB.Text = "2nd" And Sem_CB.Text = "2nd" Then

                                        Course_Label1.Text = "Subject 20"
                                        Course_Label2.Text = "Subject 21"
                                        Course_Label3.Text = "Subject 22"
                                        Course_Label4.Text = "Subject 23"
                                        Course_Label5.Text = "Subject 24"
                                        Course_Label6.Text = "Subject 25"
                                        Course_Label7.Text = "Subject 26"
                                        Course_Label8.Text = "PE 4"

                                        Grade_TB1.Text = reader("SUBJECT 20").ToString()
                                        Grade_TB2.Text = reader("SUBJECT 21").ToString()
                                        Grade_TB3.Text = reader("SUBJECT 22").ToString()
                                        Grade_TB4.Text = reader("SUBJECT 23").ToString()
                                        Grade_TB5.Text = reader("SUBJECT 24").ToString()
                                        Grade_TB6.Text = reader("SUBJECT 25").ToString()
                                        Grade_TB7.Text = reader("SUBJECT 26").ToString()
                                        Grade_TB8.Text = reader("PE 4").ToString()
                                        Grade_TB9.Text = reader("2nd Year 2nd Sem GWA")


                                    ElseIf Year_CB.Text = "3rd" And Sem_CB.Text = "1st" Then

                                        Course_Label1.Text = "Subject 27"
                                        Course_Label2.Text = "Subject 28"
                                        Course_Label3.Text = "Subject 29"
                                        Course_Label4.Text = "Subject 30"
                                        Course_Label5.Text = "Subject 31"
                                        Course_Label6.Text = "Subject 32"
                                        Course_Label7.Text = "Subject 33"
                                        Course_Label8.Text = "Subject 34"

                                        Grade_TB1.Text = reader("SUBJECT 27").ToString()
                                        Grade_TB2.Text = reader("SUBJECT 28").ToString()
                                        Grade_TB3.Text = reader("SUBJECT 29").ToString()
                                        Grade_TB4.Text = reader("SUBJECT 30").ToString()
                                        Grade_TB5.Text = reader("SUBJECT 31").ToString()
                                        Grade_TB6.Text = reader("SUBJECT 32").ToString()
                                        Grade_TB7.Text = reader("SUBJECT 33").ToString()
                                        Grade_TB8.Text = reader("SUBJECT 34").ToString()
                                        Grade_TB9.Text = reader("3rd Year 1st Sem GWA")

                                    ElseIf Year_CB.Text = "3rd" And Sem_CB.Text = "2nd" Then

                                        Course_Label1.Text = "Subject 35"
                                        Course_Label2.Text = "Subject 36"
                                        Course_Label3.Text = "Subject 37"
                                        Course_Label4.Text = "Subject 38"
                                        Course_Label5.Text = "Subject 39"
                                        Course_Label6.Text = "Subject 40"
                                        Course_Label7.Text = "Subject 41"
                                        Course_Label8.Text = "Subject 42"

                                        Grade_TB1.Text = reader("SUBJECT 35").ToString()
                                        Grade_TB2.Text = reader("SUBJECT 36").ToString()
                                        Grade_TB3.Text = reader("SUBJECT 37").ToString()
                                        Grade_TB4.Text = reader("SUBJECT 38").ToString()
                                        Grade_TB5.Text = reader("SUBJECT 39").ToString()
                                        Grade_TB6.Text = reader("SUBJECT 40").ToString()
                                        Grade_TB7.Text = reader("SUBJECT 41").ToString()
                                        Grade_TB8.Text = reader("SUBJECT 41").ToString()
                                        Grade_TB9.Text = reader("3rd Year 2nd Sem GWA")

                                    ElseIf Year_CB.Text = "4th" And Sem_CB.Text = "1st" Then

                                        Course_Label1.Text = "Subject 43"
                                        Course_Label2.Text = "Subject 44"
                                        Course_Label3.Text = "Subject 45"
                                        Course_Label4.Text = "Subject 46"
                                        Course_Label5.Text = "Subject 47"
                                        Course_Label6.Text = "Subject 48"
                                        Course_Label7.Text = "Subject 49"
                                        Course_Label8.Text = "Subject 50"

                                        Grade_TB1.Text = reader("SUBJECT 43").ToString()
                                        Grade_TB2.Text = reader("SUBJECT 44").ToString()
                                        Grade_TB3.Text = reader("SUBJECT 45").ToString()
                                        Grade_TB4.Text = reader("SUBJECT 46").ToString()
                                        Grade_TB5.Text = reader("SUBJECT 47").ToString()
                                        Grade_TB6.Text = reader("SUBJECT 48").ToString()
                                        Grade_TB7.Text = reader("SUBJECT 49").ToString()
                                        Grade_TB8.Text = reader("SUBJECT 50").ToString()
                                        Grade_TB9.Text = reader("4th Year 1st Sem GWA")

                                    ElseIf Year_CB.Text = "4th" And Sem_CB.Text = "2nd" Then

                                        Course_Label1.Text = "Subject 51"
                                        Course_Label2.Text = "Subject 52"
                                        Course_Label3.Text = "Subject 53"
                                        Course_Label4.Text = "Subject 54"
                                        Course_Label5.Text = "Subject 55"
                                        Course_Label6.Text = "Subject 56"
                                        Course_Label7.Text = "Subject 57"
                                        Course_Label8.Text = "Subject 58"

                                        Grade_TB1.Text = reader("SUBJECT 51").ToString()
                                        Grade_TB2.Text = reader("SUBJECT 52").ToString()
                                        Grade_TB3.Text = reader("SUBJECT 53").ToString()
                                        Grade_TB4.Text = reader("SUBJECT 54").ToString()
                                        Grade_TB5.Text = reader("SUBJECT 55").ToString()
                                        Grade_TB6.Text = reader("SUBJECT 56").ToString()
                                        Grade_TB7.Text = reader("SUBJECT 57").ToString()
                                        Grade_TB8.Text = reader("SUBJECT 58").ToString()
                                        Grade_TB9.Text = reader("4th Year 2nd Sem GWA")

                                    End If
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
    ' STUDENT PANEL - END


End Class