Imports MySql.Data.MySqlClient


Public Class Admin_Main


    Private Shared ConnectionString As String = "server=localhost; port=3306; database=cdmregistrarmanagementsystem; uid=root; password=;"
    Private Shared connection As New MySqlConnection(ConnectionString)



    Private Sub Admin_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dropdown_Panel.Size = Dropdown_Panel.MinimumSize

        Try
            connection.Open()

            Dim selectQuery As String = "SELECT * FROM instructors"
            Dim command As New MySqlCommand(selectQuery, connection)

            Dim adapter As New MySqlDataAdapter(command)
            Dim datatable As New DataTable()

            adapter.Fill(datatable)
            DataGridView1.DataSource = datatable

        Catch ex As Exception
            MessageBox.Show("Error fetching data: " & ex.Message)
        Finally
            ' Close the connection
            connection.Close()
        End Try

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

            MyProfile_Panel.Hide()

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





End Class