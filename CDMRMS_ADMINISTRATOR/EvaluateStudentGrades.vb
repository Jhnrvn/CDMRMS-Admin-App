Imports MySql.Data.MySqlClient

Public Class EvaluateStudentGrades

    Private Sub EvaluateStudentGrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    ' DATABASE CONNECTION - START
    Private Shared ConnectionString As String = "server=localhost; port=3306; database=cdmregistrarmanagementsystem; uid=root; password=;"
    Private Shared connection As New MySqlConnection(ConnectionString)
    ' DATABASE CONNECTION - END


    Private Sub Evaluate_Btn_Click(sender As Object, e As EventArgs) Handles Evaluate_Btn.Click

        If SemesterSelector.Text = "1st Semester" Then

            FirstSemBSIT()

        ElseIf SemesterSelector.Text = "2nd Semester" Then

            SecondSemBSIT()

        Else
            MessageBox.Show("Please choose an option from the dropdown menu.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If


    End Sub

    ' BSIT First Semester Grade Evalauation
    Private Sub FirstSemBSIT()

        Dim selectquery As String = "SELECT * FROM bsit "
        Dim command As New MySqlCommand(selectquery, connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        connection.Open()
        adapter.Fill(table)
        connection.Close()

        For Each row As DataRow In table.Rows

            Dim studentID As String = Convert.ToString(row("Student ID"))
            Dim year As String = Convert.ToString(row("Year"))

            ' 1st Year 1st Semester Subjects/Courses
            Dim itcomp As Double = Convert.ToDouble(row("ITCOMP"))
            Dim prog1 As Double = Convert.ToDouble(row("PROG 1"))
            Dim ge2 As Double = Convert.ToDouble(row("GE 2"))
            Dim gemath As Double = Convert.ToDouble(row("GE MATH"))
            Dim ge1 As Double = Convert.ToDouble(row("GE 1"))
            Dim gefil1 As Double = Convert.ToDouble(row("GE FIL 1"))

            ' 2nd Year 1st Semester Subjects/Courses
            Dim prog3 As Double = Convert.ToDouble(row("PROG 3"))
            Dim elect1 As Double = Convert.ToDouble(row("ELECT 1"))
            Dim ge4 As Double = Convert.ToDouble(row("GE 4"))
            Dim ge12 As Double = Convert.ToDouble(row("GE 12"))
            Dim sia1 As Double = Convert.ToDouble(row("SIA 1"))
            Dim sp As Double = Convert.ToDouble(row("SP"))
            Dim gesci As Double = Convert.ToDouble(row("GE SCI"))

            '3rd Year 1st Semester Subjects/Courses
            Dim net2 As Double = Convert.ToDouble(row("NET 2"))
            Dim im1 As Double = Convert.ToDouble(row("IM 1"))
            Dim appsdev1 As Double = Convert.ToDouble(row("APPSDEV 1"))
            Dim os As Double = Convert.ToDouble(row("OS"))
            Dim ias1 As Double = Convert.ToDouble(row("IAS 1"))
            Dim hci As Double = Convert.ToDouble(row("HCI"))
            Dim adbs As Double = Convert.ToDouble(row("ADBS"))
            Dim elect3 As Double = Convert.ToDouble(row("ELECT 3"))

            '4th Year 1st Semester Subject/Courses
            Dim capstone2 As Double = Convert.ToDouble(row("CAPSTONE 2"))

            Dim grade As Double
            If year = "1st Year" Then
                grade = (prog1 + itcomp + ge2 + gemath + ge1 + gefil1) / 6
                row("1st Year 1st Sem GWA") = grade

            ElseIf year = "2nd Year" Then

                grade = (prog3 + elect1 + ge4 + ge12 + sia1 + sp + gesci) / 7
                row("2nd Year 1st Sem GWA") = grade

            ElseIf year = "3rd Year" Then

                grade = (net2 + im1 + appsdev1 + os + ias1 + hci + adbs + elect3) / 8
                row("3rd Year 1st Sem GWA") = grade

            ElseIf year = "4th Year" Then
                grade = capstone2
                row("4th Year 1st Sem GWA") = grade
            End If

        Next

        connection.Open()

        For Each row As DataRow In table.Rows


            Dim studentID As String = Convert.ToString(row("Student ID"))
            Dim year As String = Convert.ToString(row("Year"))

            Dim grade As Double
            Dim updatequery As String = ""

            If year = "1st Year" Then
                grade = Convert.ToDouble(row("1st Year 1st Sem GWA"))
                updatequery = "UPDATE bsit SET `1st Year 1st Sem GWA` = @grade WHERE `Student ID` = @studentid"

            ElseIf year = "2nd Year" Then
                grade = Convert.ToDouble(row("2nd Year 1st Sem GWA"))
                updatequery = "UPDATE bsit SET `2nd Year 1st Sem GWA` = @grade WHERE `Student ID` = @studentid"

            ElseIf year = "3rd Year" Then
                grade = Convert.ToDouble(row("3rd Year 1st Sem GWA"))
                updatequery = "UPDATE bsit SET `3rd Year 1st Sem GWA` = @grade WHERE `Student ID` = @studentid"

            ElseIf year = "4th Year" Then
                grade = Convert.ToDouble(row("4th Year 1st Sem GWA"))
                updatequery = "UPDATE bsit SET `4th Year 1st Sem GWA` = @grade WHERE `Student ID` = @studentid"

            End If

            Dim updatecommand As New MySqlCommand(updatequery, connection)

            updatecommand.Parameters.AddWithValue("@grade", Math.Round(grade, 2))
            updatecommand.Parameters.AddWithValue("@studentid", studentID)

            updatecommand.ExecuteNonQuery()

        Next
        MessageBox.Show("Successfully evaluated all grades from 1st Semester.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        connection.Close()
        Admin_Main.StudentList()
    End Sub


    ' BSIT Second Semester Grade Evaluation
    Private Sub SecondSemBSIT()

        Dim selectquery As String = "SELECT * FROM bsit "
        Dim command As New MySqlCommand(selectquery, connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        connection.Open()
        adapter.Fill(table)
        connection.Close()

        For Each row As DataRow In table.Rows

            Dim studentID As String = Convert.ToString(row("Student ID"))
            Dim year As String = Convert.ToString(row("Year"))

            ' 1st Year 2nd Semester Subjects/Courses
            Dim discrete As Double = Convert.ToDouble(row("DISCRETE"))
            Dim prog2 As Double = Convert.ToDouble(row("PROG 2"))
            Dim ge3 As Double = Convert.ToDouble(row("GE 3"))
            Dim hum As Double = Convert.ToDouble(row("HUM"))
            Dim geel2 As Double = Convert.ToDouble(row("GEEL 2"))
            Dim gefil2 As Double = Convert.ToDouble(row("GE FIL 2"))

            ' 2nd Year 2nd Semester Subjects/Courses
            Dim acss As Double = Convert.ToDouble(row("ACSS"))
            Dim elect2 As Double = Convert.ToDouble(row("ELECT 2"))
            Dim net1 As Double = Convert.ToDouble(row("NET 1"))
            Dim ge5 As Double = Convert.ToDouble(row("GE 5"))
            Dim fudbs As Double = Convert.ToDouble(row("FUDBS"))
            Dim ssd As Double = Convert.ToDouble(row("SSD"))
            Dim ipt As Double = Convert.ToDouble(row("IPTECH"))

            '3rd Year 2nd Semester Subjects/Courses
            Dim gerizal As Double = Convert.ToDouble(row("GE RIZAL"))
            Dim im2 As Double = Convert.ToDouble(row("IM 2"))
            Dim qm As Double = Convert.ToDouble(row("QM"))
            Dim sa As Double = Convert.ToDouble(row("SA"))
            Dim ias2 As Double = Convert.ToDouble(row("IAS 2"))
            Dim capstone1 As Double = Convert.ToDouble(row("CAPSTONE 1"))
            Dim elect4 As Double = Convert.ToDouble(row("ELECT 4"))


            '4th Year 2nd Semester Subject/Courses
            Dim practicum As Double = Convert.ToDouble(row("PRACTICUM"))

            Dim grade As Double
            If year = "1st Year" Then
                grade = (discrete + prog2 + ge3 + hum + geel2 + gefil2) / 6
                row("1st Year 2nd Sem GWA") = grade

            ElseIf year = "2nd Year" Then

                grade = (acss + elect2 + net1 + ge5 + fudbs + ssd + ipt) / 7
                row("2nd Year 2nd Sem GWA") = grade

            ElseIf year = "3rd Year" Then

                grade = (gerizal + im2 + qm + sa + ias2 + capstone1 + elect4) / 7
                row("3rd Year 2nd Sem GWA") = grade

            ElseIf year = "4th Year" Then
                grade = practicum
                row("4th Year 2nd Sem GWA") = grade
            End If

        Next

        connection.Open()

        For Each row As DataRow In table.Rows

            Dim studentID As String = Convert.ToString(row("Student ID"))
            Dim year As String = Convert.ToString(row("Year"))

            Dim grade As Double
            Dim updatequery As String = ""

            If year = "1st Year" Then
                grade = Convert.ToDouble(row("1st Year 2nd Sem GWA"))
                updatequery = "UPDATE bsit SET `1st Year 2nd Sem GWA` = @grade WHERE `Student ID` = @studentid"

            ElseIf year = "2nd Year" Then
                grade = Convert.ToDouble(row("2nd Year 2nd Sem GWA"))
                updatequery = "UPDATE bsit SET `2nd Year 2nd Sem GWA` = @grade WHERE `Student ID` = @studentid"

            ElseIf year = "3rd Year" Then
                grade = Convert.ToDouble(row("3rd Year 2nd Sem GWA"))
                updatequery = "UPDATE bsit SET `3rd Year 2nd Sem GWA` = @grade WHERE `Student ID` = @studentid"

            ElseIf year = "4th Year" Then
                grade = Convert.ToDouble(row("4th Year 2nd Sem GWA"))
                updatequery = "UPDATE bsit SET `4th Year 2nd Sem GWA` = @grade WHERE `Student ID` = @studentid"

            End If

            Dim updatecommand As New MySqlCommand(updatequery, connection)

            updatecommand.Parameters.AddWithValue("@grade", Math.Round(grade, 2))
            updatecommand.Parameters.AddWithValue("@studentid", studentID)

            updatecommand.ExecuteNonQuery()

        Next
        MessageBox.Show("Successfully evaluated all grades from 2nd Semester.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        connection.Close()
        Admin_Main.StudentList()

    End Sub



    ' Close form
    Private Sub Close_Btn_Click(sender As Object, e As EventArgs) Handles Close_Btn.Click
        Me.Close()
        Admin_Main.Enabled = True
        Admin_Main.BringToFront()
    End Sub

End Class