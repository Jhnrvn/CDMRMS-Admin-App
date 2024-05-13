
Imports MySql.Data.MySqlClient

Public Class EvaluateStudentGrades

    Private Sub EvaluateStudentGrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    ' DATABASE CONNECTION - START
    Private Shared ConnectionString As String = "server=localhost; port=3306; database=cdmregistrarmanagementsystem; uid=root; password=;"
    Private Shared connection As New MySqlConnection(ConnectionString)
    ' DATABASE CONNECTION - END


    Private Sub Evaluate_Btn_Click(sender As Object, e As EventArgs) Handles Evaluate_Btn.Click

        FirstYear1stSem()

    End Sub


    Private Sub FirstYear1stSem()

        Dim query As String = "SELECT * FROM bsit"

        Using connection As New MySqlConnection(ConnectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()

                Dim reader As MySqlDataReader = command.ExecuteReader()

                While reader.Read()

                    Dim id As Integer = Convert.ToInt32(reader("ID"))
                    Dim sub1 As String = reader("PROG 1").ToString

                    sub1 = sub1 & "_updated"


                    Dim updatequery As String = "UPDATE bsit SET `2nd Year 1st Sem GWA` = @sub1 WHERE `ID` = @id "
                    Using UpdateCommand As New MySqlCommand(updatequery, connection)

                        UpdateCommand.Parameters.AddWithValue("@sub1", sub1)
                        UpdateCommand.Parameters.AddWithValue("@id", id)

                        UpdateCommand.ExecuteNonQuery()

                    End Using

                End While
                reader.Close()
                connection.Close()
            End Using
        End Using



    End Sub

    ' Close form
    Private Sub Close_Btn_Click(sender As Object, e As EventArgs) Handles Close_Btn.Click
        Me.Close()
        Admin_Main.Enabled = True
        Admin_Main.BringToFront()
    End Sub


End Class