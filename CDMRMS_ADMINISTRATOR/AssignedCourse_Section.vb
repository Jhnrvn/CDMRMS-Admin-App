Imports MySql.Data.MySqlClient

Public Class AssignedCourse_Section


    ' FORM LOAD - START
    Private Sub AssignedCourse_Section_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AssignedCourse()
        AssignedCourseTable.ReadOnly = True
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
            adapter.Fill(dataTable)

            AssignedCourseTable.DataSource = dataTable
            AssignedCourseTable.Columns(0).Width = 100

            AssignedCourseTable.Columns("id").Visible = False
            AssignedCourseTable.Columns("instructor").Width = 150

        Catch ex As Exception
            MessageBox.Show("Error fetching data: " & ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub


    Private Sub SaveData()
        Dim builder As New MySqlCommandBuilder(adapter)
        adapter.Update(DataTable)
    End Sub

    Private Sub Save_Btn_Click(sender As Object, e As EventArgs) Handles Save_Btn.Click
        SaveData()
        AssignedCourseTable.ReadOnly = True
        MsgBox("Update successful!", MessageBoxIcon.Information)
        dataTable.Clear()
        AssignedCourse()
    End Sub

    Private Sub Edit_Btn_Click(sender As Object, e As EventArgs) Handles Edit_Btn.Click
        AssignedCourseTable.ReadOnly = False
    End Sub


    Private Sub Close_Btn_Click(sender As Object, e As EventArgs) Handles Close_Btn.Click
        Me.Close()
        Admin_Main.Enabled = True
    End Sub


End Class