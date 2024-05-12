Imports MySql.Data.MySqlClient

Public Class EvaluateStudentGrades

    Private Sub EvaluateStudentGrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    ' DATABASE CONNECTION - START
    Private Shared ConnectionString As String = "server=localhost; port=3306; database=cdmregistrarmanagementsystem; uid=root; password=;"
    Private Shared connection As New MySqlConnection(ConnectionString)
    ' DATABASE CONNECTION - END


    Private Sub Evaluate_Btn_Click(sender As Object, e As EventArgs) Handles Evalaute_Btn.Click

        Dim CheckQuery As String = "SELECT `Student ID`, Year, Semester FROM bsit"
        Dim year As String = ""
        Dim semester As String = ""
        Dim studentID As String = ""
        Dim GWA As Double
        Using connection As New MySqlConnection(ConnectionString)
            Using checkcommand As New MySqlCommand(CheckQuery, connection)

                Try
                    connection.Open()
                    Dim reader As MySqlDataReader = checkcommand.ExecuteReader()

                    While reader.Read()

                        year = reader.GetString("Year")
                        semester = reader.GetString("Semester")

                    End While
                    reader.Close()

                Catch ex As Exception
                    MsgBox("error 1: " & ex.Message)
                Finally
                    connection.Close()

                End Try

                If year = "1st Year" And semester = "1st sem" Then


                    Dim query As String = "SELECT `Student ID`, `ITCOMP`, `PROG 1`, `GE 2`, `GE MATH`, `GE 1`, `GE FIL 1` FROM bsit"




                    Using command As New MySqlCommand(query, connection)
                        Try
                            connection.Open()

                            Dim coursereader As MySqlDataReader = command.ExecuteReader()

                            While coursereader.Read()

                                studentID = coursereader("Student ID")
                                Dim sub1 As Double = coursereader("ITCOMP")
                                Dim sub2 As Double = coursereader("PROG 1")
                                Dim sub3 As Double = coursereader("GE 2")
                                Dim sub4 As Double = coursereader("GE MATH")
                                Dim sub5 As Double = coursereader("GE 1")
                                Dim sub6 As Double = coursereader("GE FIL 1")

                                GWA = (sub1 + sub2 + sub3 + sub4 + sub5 + sub6) / 6

                                Dim updateQuery As String = "UPDATE bsit SET `1st Year 1st Sem GWA` = @GWA WHERE `Student ID` = @StudentID"

                                Using updateCommand As New MySqlCommand(updateQuery, connection)
                                    updateCommand.Parameters.AddWithValue("@GWA", GWA)
                                    updateCommand.Parameters.AddWithValue("@StudentID", studentID)

                                    updateCommand.ExecuteNonQuery()
                                    MsgBox("GWA computed Successfully!")
                                End Using

                            End While
                            coursereader.Close()

                        Catch ex As Exception
                            MsgBox("error1: " & ex.Message)
                        Finally
                            connection.Close()

                        End Try

                    End Using


                End If

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