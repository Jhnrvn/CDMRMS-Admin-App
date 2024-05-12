Imports MySql.Data.MySqlClient

Public Class ChangingGradeRequest



    ' FORM LOAD - START
    Private Sub ChangingGradeRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInstructorRequest()

    End Sub
    ' FORM LOAD - END


    ' DATABASE CONNECTION - START
    Private Shared ConnectionString As String = "server=localhost; port=3306; database=cdmregistrarmanagementsystem; uid=root; password=;"
    Private Shared connection As New MySqlConnection(ConnectionString)
    ' DATABASE CONNECTION - END


    Private Sub LoadInstructorRequest()
        Try
            connection.Open()

            Dim selectQuery As String = "SELECT `Instructor ID`, `Instructor Name` FROM `request`"
            Dim command As New MySqlCommand(selectQuery, connection)


            Dim datatable As New DataTable()
            Using adapter As New MySqlDataAdapter(command)

                adapter.Fill(datatable)


                PendingRequestTable.DataSource = datatable
                PendingRequestTable.Columns("Instructor ID").Width = 291
                PendingRequestTable.Columns("Instructor Name").Width = 292

            End Using


        Catch ex As Exception
            MessageBox.Show("Error fetching data: " & ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub


    Private Sub Approve_Btn_Click(sender As Object, e As EventArgs) Handles Approve_Btn.Click
        Dim choice As DialogResult = MsgBox("Approve Request?", MessageBoxButtons.YesNo)

        If choice = DialogResult.Yes Then

            If PendingRequestTable.SelectedRows.Count > 0 Then

                Dim selectedRow As DataGridViewRow = PendingRequestTable.SelectedRows(0)
                Dim instructorid As String
                instructorid = selectedRow.Cells("Instructor ID").Value.ToString()


                Dim status As Boolean = True

                Dim ApprovedQuery As String = " UPDATE instructors SET Status = @status WHERE instructorid = @instructorid "
                Dim DeleteQuery As String = " DELETE FROM request WHERE `Instructor ID` = @instructorid "
                Try
                    connection.Open()

                    Using ApprovedCommand As New MySqlCommand(ApprovedQuery, connection)
                        ApprovedCommand.Parameters.AddWithValue("@status", status)
                        ApprovedCommand.Parameters.AddWithValue("@instructorid", instructorid)
                        ApprovedCommand.ExecuteNonQuery()

                    End Using

                    Using DeleteCommand As New MySqlCommand(DeleteQuery, connection)
                        DeleteCommand.Parameters.AddWithValue("@instructorid", instructorid)
                        DeleteCommand.ExecuteNonQuery()

                    End Using

                    MsgBox("Request Approved")

                Catch ex As Exception

                    MsgBox("error" & ex.Message)

                Finally
                    connection.Close()

                End Try
                LoadInstructorRequest()

            End If

        End If


    End Sub


    Private Sub Decline_Btn_Click(sender As Object, e As EventArgs) Handles Decline_Btn.Click

        Dim choice As DialogResult = MsgBox("Decline Request?", MessageBoxButtons.YesNo)

        If choice = DialogResult.Yes Then

            If PendingRequestTable.SelectedRows.Count > 0 Then

                Dim selectedRow As DataGridViewRow = PendingRequestTable.SelectedRows(0)
                Dim instructorid As String
                instructorid = selectedRow.Cells("Instructor ID").Value.ToString()

                Dim DeleteQuery As String = " DELETE FROM request WHERE `Instructor ID` = @instructorid "
                Try
                    connection.Open()

                    Using DeleteCommand As New MySqlCommand(DeleteQuery, connection)
                        DeleteCommand.Parameters.AddWithValue("@instructorid", instructorid)
                        DeleteCommand.ExecuteNonQuery()

                    End Using
                    MsgBox("Request Declined.")

                Catch ex As Exception

                    MsgBox("error" & ex.Message)

                Finally
                    connection.Close()

                End Try
                LoadInstructorRequest()



            End If
        End If

    End Sub


    ' Close button for Changing Grade Request
    Private Sub Close_Btn_Click(sender As Object, e As EventArgs) Handles Close_Btn.Click

        Me.Close()
        Admin_Main.Enabled = True
        Admin_Main.BringToFront()

    End Sub


End Class