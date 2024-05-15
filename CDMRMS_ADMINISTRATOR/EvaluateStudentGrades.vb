
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

        Dim selectquery As String = "SELECT * FROM bsit "
        Dim command As New MySqlCommand(selectquery, connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        connection.Open()
        adapter.Fill(table)
        connection.Close()

        For Each row As DataRow In table.Rows
            Dim studentID As String = Convert.ToString(row("Student ID"))
            Dim itcomp As Double = Convert.ToDouble(row("ITCOMP"))
            Dim prog1 As Double = Convert.ToDouble(row("PROG 1"))
            Dim ge2 As Double = Convert.ToDouble(row("GE 2"))
            Dim gemath As Double = Convert.ToDouble(row("GE MATH"))
            Dim ge1 As Double = Convert.ToDouble(row("GE 1"))
            Dim gefil1 As Double = Convert.ToDouble(row("GE FIL 1"))



            Dim grade As Double = (prog1 + itcomp + ge2 + gemath + ge1 + gefil1) / 6

            row("1st Year 1st Sem GWA") = grade
        Next

        connection.Open()

        For Each row As DataRow In table.Rows

            Dim studentID As String = Convert.ToString(row("Student ID"))
            Dim grade As Double = Convert.ToDouble(row("1st Year 1st Sem GWA"))

            Dim updatequery As String = "UPDATE bsit SET `1st Year 1st Sem GWA` = @grade WHERE `Student ID` = @studentid"
            Dim updatecommand As New MySqlCommand(updatequery, connection)

            updatecommand.Parameters.AddWithValue("@grade", Math.Round(grade, 2))
            updatecommand.Parameters.AddWithValue("@studentid", studentID)

            updatecommand.ExecuteNonQuery()

        Next
        MsgBox("update successfully!")
        connection.Close()


    End Sub

    ' Close form
    Private Sub Close_Btn_Click(sender As Object, e As EventArgs) Handles Close_Btn.Click
        Me.Close()
        Admin_Main.Enabled = True
        Admin_Main.BringToFront()
    End Sub


End Class