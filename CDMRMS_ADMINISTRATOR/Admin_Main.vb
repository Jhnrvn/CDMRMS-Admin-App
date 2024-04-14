Imports MySql.Data.MySqlClient


Public Class Admin_Main


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


                datatable.Columns("firstname").ColumnName = "First Name"
                datatable.Columns("middlename").ColumnName = "Middle Name"
                datatable.Columns("lastname").ColumnName = "Last Name"
                datatable.Columns("instructorid").ColumnName = "Instructor ID"

                InstructorsDataTable.DataSource = datatable
            End Using

            InstructorsDataTable.Columns("First Name").Width = 130
            InstructorsDataTable.Columns("Middle Name").Width = 130
            InstructorsDataTable.Columns("Last Name").Width = 130
            InstructorsDataTable.Columns("instructor ID").Width = 130

        Catch ex As Exception
            MessageBox.Show("Error fetching data: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Dim DataTable As New DataTable


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim search As String = InstructorSearchBar.Text.Trim

        If String.IsNullOrEmpty(search) Then
            InstructorsDataTable.DataSource = DataTable

        Else

            Dim unused As New DataTable()
            Dim filteredData As DataTable = DataTable.Clone()

            For Each row As DataRow In DataTable.Rows
                For Each column As DataColumn In DataTable.Columns
                    If row(column.ColumnName).ToString().Contains(search) Then

                        filteredData.ImportRow(row)
                        Exit For
                    End If
                Next
            Next

            InstructorsDataTable.DataSource = filteredData
        End If

    End Sub

    Private Sub Instructor_Btn_Click(sender As Object, e As EventArgs) Handles Instructor_Btn.Click
        Instructor_Panel.Show
    End Sub
End Class