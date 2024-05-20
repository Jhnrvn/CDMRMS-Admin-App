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
            FirstSemBSCPE()
            MessageBox.Show("Successfully evaluated all grades for 1st Semester.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf SemesterSelector.Text = "2nd Semester" Then

            SecondSemBSIT()
            SecondSemBSCPE()
            MessageBox.Show("Successfully evaluated all grades for 2nd Semester.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)

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
            Dim honorStatus As Boolean = True

            If year = "1st Year" Then
                ' GWA Computation For 1st Year 1st Sem
                grade = (prog1 + itcomp + ge2 + gemath + ge1 + gefil1) / 6
                row("1st Year 1st Sem GWA") = grade

                ' Deans lister Validation for 1st Year 1st Sem BSIT
                If (prog1 > 2.0 Or prog1 < 1) Or (itcomp > 2.0 Or itcomp < 1) Or (ge2 > 2.0 Or ge2 < 1) Or (gemath > 2.0 Or gemath < 1) Or (ge1 > 2.0 Or ge1 < 1) Or (gefil1 > 2.0 Or gefil1 < 1) Then
                    row("1st Year 1st Sem Honor Status") = honorStatus = False

                Else
                    row("1st Year 1st Sem Honor Status") = honorStatus

                End If

            ElseIf year = "2nd Year" Then
                ' GWA Computation For 2nd Year 1st Sem
                grade = (prog3 + elect1 + ge4 + ge12 + sia1 + sp + gesci) / 7
                row("2nd Year 1st Sem GWA") = grade

                ' Deans Lister Validation For 2nd Year 1st Sem BSIT
                If (prog3 > 2.0 Or prog3 < 1) Or (elect1 > 2.0 Or elect1 < 1) Or (ge4 > 2.0 Or ge4 < 1) Or (ge12 > 2.0 Or ge12 < 1) Or (sia1 > 2.0 Or sia1 < 1) Or (sp > 2.0 Or sp < 1) Or (gesci > 2.0 Or gesci < 1) Then
                    row("2nd Year 1st Sem Honor Status") = honorStatus = False

                Else
                    row("2nd Year 1st Sem Honor Status") = honorStatus

                End If

            ElseIf year = "3rd Year" Then
                ' GWA Computation For 3rd Year 1st Sem
                grade = (net2 + im1 + appsdev1 + os + ias1 + hci + adbs + elect3) / 8
                row("3rd Year 1st Sem GWA") = grade

                ' Deans Lister Validation For 3rd Year 1st Sem BSIT
                If (net2 > 2.0 Or net2 < 1) Or (im1 > 2.0 Or im1 < 1) Or (appsdev1 > 2.0 Or appsdev1 < 1) Or (os > 2.0 Or os < 1) Or (ias1 > 2.0 Or ias1 < 1) Or (hci > 2.0 Or hci < 1) Or (adbs > 2.0 Or adbs < 1) Or (elect3 > 2.0 Or elect3 < 1) Then
                    row("3rd Year 1st Sem Honor Status") = honorStatus = False

                Else
                    row("3rd Year 1st Sem Honor Status") = honorStatus

                End If

            ElseIf year = "4th Year" Then
                ' GWA for 4th Year 1st Sem
                grade = capstone2
                row("4th Year 1st Sem GWA") = grade

                ' Deans Lister Validation For 3rd Year 1st Sem BSIT
                If capstone2 > 2.0 Or capstone2 < 1 Then
                    row("4th Year 1st Sem Honor Status") = honorStatus = False

                Else
                    row("4th Year 1st Sem Honor Status") = honorStatus

                End If
            End If

        Next

        connection.Open()

        For Each row As DataRow In table.Rows


            Dim studentID As String = Convert.ToString(row("Student ID"))
            Dim year As String = Convert.ToString(row("Year"))

            Dim grade As Double
            Dim honorStatus1 As Boolean = Convert.ToBoolean(row("1st Year 1st Sem Honor Status"))
            Dim honorStatus2 As Boolean = Convert.ToBoolean(row("2nd Year 1st Sem Honor Status"))
            Dim honorStatus3 As Boolean = Convert.ToBoolean(row("3rd Year 1st Sem Honor Status"))
            Dim honorStatus4 As Boolean = Convert.ToBoolean(row("4th Year 1st Sem Honor Status"))
            Dim updatequery As String


            If year = "1st Year" Then
                grade = Convert.ToDouble(row("1st Year 1st Sem GWA"))
                updatequery = "UPDATE bsit SET `1st Year 1st Sem GWA` = @grade, `1st Year 1st Sem Honor Status` = @honorStatus1 WHERE `Student ID` = @studentid"

                Dim updatecommand As New MySqlCommand(updatequery, connection)

                updatecommand.Parameters.AddWithValue("@grade", Math.Round(grade, 2))
                updatecommand.Parameters.AddWithValue("@honorStatus1", honorStatus1)
                updatecommand.Parameters.AddWithValue("@studentid", studentID)

                updatecommand.ExecuteNonQuery()

                ' 1st Year 1st Sem Deans Lister Insert Query 
                If honorStatus1 = True Then

                    Dim query As String = "INSERT INTO deanslist (`Student ID`, `Student Name`, `Program`,`Year`, `Section`, `GWA` ) SELECT `Student ID`, `Student Name`, `Program`, `Year`,`Section`,`1st Year 1st Sem GWA` FROM bsit WHERE `Student ID` = @studentID"
                    Dim insertcommand As New MySqlCommand(query, connection)
                    insertcommand.Parameters.AddWithValue("@studentID", studentID)
                    insertcommand.ExecuteNonQuery()

                End If

            ElseIf year = "2nd Year" Then
                grade = Convert.ToDouble(row("2nd Year 1st Sem GWA"))
                updatequery = "UPDATE bsit SET `2nd Year 1st Sem GWA` = @grade, `2nd Year 1st Sem Honor Status` = @honorStatus2 WHERE `Student ID` = @studentid"

                Dim updatecommand As New MySqlCommand(updatequery, connection)

                updatecommand.Parameters.AddWithValue("@grade", Math.Round(grade, 2))
                updatecommand.Parameters.AddWithValue("@honorStatus2", honorStatus2)
                updatecommand.Parameters.AddWithValue("@studentid", studentID)

                updatecommand.ExecuteNonQuery()

                ' 2nd Year 1st Sem Deans Lister Insert Query 
                If honorStatus2 = True Then

                    Dim query As String = "INSERT INTO deanslist (`Student ID`, `Student Name`, `Program`,`Year`, `Section`, `GWA` ) SELECT `Student ID`, `Student Name`, `Program`, `Year`,`Section`,`2nd Year 1st Sem GWA` FROM bsit WHERE `Student ID` = @studentID"
                    Dim insertcommand As New MySqlCommand(query, connection)
                    insertcommand.Parameters.AddWithValue("@studentID", studentID)
                    insertcommand.ExecuteNonQuery()

                End If

            ElseIf year = "3rd Year" Then
                grade = Convert.ToDouble(row("3rd Year 1st Sem GWA"))
                updatequery = "UPDATE bsit SET `2nd Year 1st Sem GWA` = @grade, `3rd Year 1st Sem Honor Status` = @honorStatus3 WHERE `Student ID` = @studentid"

                Dim updatecommand As New MySqlCommand(updatequery, connection)

                updatecommand.Parameters.AddWithValue("@grade", Math.Round(grade, 2))
                updatecommand.Parameters.AddWithValue("@honorStatus3", honorStatus3)
                updatecommand.Parameters.AddWithValue("@studentid", studentID)

                updatecommand.ExecuteNonQuery()

                ' 3rd Year 1st Sem Deans Lister Insert Query 
                If honorStatus3 = True Then

                    Dim query As String = "INSERT INTO deanslist (`Student ID`, `Student Name`, `Program`,`Year`, `Section`, `GWA` ) SELECT `Student ID`, `Student Name`, `Program`, `Year`,`Section`,`3rd Year 1st Sem GWA` FROM bsit WHERE `Student ID` = @studentID"
                    Dim insertcommand As New MySqlCommand(query, connection)
                    insertcommand.Parameters.AddWithValue("@studentID", studentID)
                    insertcommand.ExecuteNonQuery()

                End If

            ElseIf year = "4th Year" Then
                grade = Convert.ToDouble(row("4th Year 1st Sem GWA"))
                updatequery = "UPDATE bsit SET `2nd Year 1st Sem GWA` = @grade, `4th Year 1st Sem Honor Status` = @honorStatus4 WHERE `Student ID` = @studentid"

                Dim updatecommand As New MySqlCommand(updatequery, connection)

                updatecommand.Parameters.AddWithValue("@grade", Math.Round(grade, 2))
                updatecommand.Parameters.AddWithValue("@honorStatus4", honorStatus4)
                updatecommand.Parameters.AddWithValue("@studentid", studentID)

                updatecommand.ExecuteNonQuery()

                ' 4th Year 1st Sem Deans Lister Insert Query 
                If honorStatus4 = True Then

                    Dim query As String = "INSERT INTO deanslist (`Student ID`, `Student Name`, `Program`,`Year`, `Section`, `GWA` ) SELECT `Student ID`, `Student Name`, `Program`, `Year`,`Section`,`4th Year 1st Sem GWA` FROM bsit WHERE `Student ID` = @studentID"
                    Dim insertcommand As New MySqlCommand(query, connection)
                    insertcommand.Parameters.AddWithValue("@studentID", studentID)
                    insertcommand.ExecuteNonQuery()

                End If

            End If

        Next
        connection.Close()

        Admin_Main.StudentList()

    End Sub


    ' BSCPE First Semester Grade Evaluation
    Private Sub FirstSemBSCPE()

        Dim selectquery As String = "SELECT * FROM bscpe "
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
            Dim subject1 As Double = Convert.ToDouble(row("SUBJECT 1"))
            Dim subject2 As Double = Convert.ToDouble(row("SUBJECT 2"))
            Dim subject3 As Double = Convert.ToDouble(row("SUBJECT 3"))
            Dim subject4 As Double = Convert.ToDouble(row("SUBJECT 4"))
            Dim subject5 As Double = Convert.ToDouble(row("SUBJECT 5"))
            Dim subject6 As Double = Convert.ToDouble(row("SUBJECT 6"))

            ' 2nd Year 1st Semester Subjects/Courses
            Dim subject13 As Double = Convert.ToDouble(row("SUBJECT 13"))
            Dim subject14 As Double = Convert.ToDouble(row("SUBJECT 14"))
            Dim subject15 As Double = Convert.ToDouble(row("SUBJECT 15"))
            Dim subject16 As Double = Convert.ToDouble(row("SUBJECT 16"))
            Dim subject17 As Double = Convert.ToDouble(row("SUBJECT 17"))
            Dim subject18 As Double = Convert.ToDouble(row("SUBJECT 18"))
            Dim subject19 As Double = Convert.ToDouble(row("SUBJECT 19"))

            ' 3rd Year 1st Semester Subjects/Courses
            Dim subject27 As Double = Convert.ToDouble(row("SUBJECT 27"))
            Dim subject28 As Double = Convert.ToDouble(row("SUBJECT 28"))
            Dim subject29 As Double = Convert.ToDouble(row("SUBJECT 29"))
            Dim subject30 As Double = Convert.ToDouble(row("SUBJECT 30"))
            Dim subject31 As Double = Convert.ToDouble(row("SUBJECT 31"))
            Dim subject32 As Double = Convert.ToDouble(row("SUBJECT 32"))
            Dim subject33 As Double = Convert.ToDouble(row("SUBJECT 33"))
            Dim subject34 As Double = Convert.ToDouble(row("SUBJECT 34"))

            ' 4th Year 1st Semester Subjects/Courses
            Dim subject43 As Double = Convert.ToDouble(row("SUBJECT 43"))
            Dim subject44 As Double = Convert.ToDouble(row("SUBJECT 44"))
            Dim subject45 As Double = Convert.ToDouble(row("SUBJECT 45"))
            Dim subject46 As Double = Convert.ToDouble(row("SUBJECT 46"))
            Dim subject47 As Double = Convert.ToDouble(row("SUBJECT 47"))
            Dim subject48 As Double = Convert.ToDouble(row("SUBJECT 48"))
            Dim subject49 As Double = Convert.ToDouble(row("SUBJECT 49"))
            Dim subject50 As Double = Convert.ToDouble(row("SUBJECT 50"))

            Dim grade As Double
            Dim honorStatus As Boolean = True

            If year = "1st Year" Then
                ' GWA Computation For 1st Year 1st Sem
                grade = (subject1 + subject2 + subject3 + subject4 + subject5 + subject6) / 6
                row("1st Year 1st Sem GWA") = grade

                ' Deans Lister Validation For 1st Year 1st Sem BSCPE
                If (subject1 > 2.0 Or subject1 < 1) Or (subject2 > 2.0 Or subject2 < 1) Or (subject3 > 2.0 Or subject3 < 1) Or (subject4 > 2.0 Or subject4 < 1) Or (subject5 > 2.0 Or subject5 < 1) Or (subject6 > 2.0 Or subject6 < 1) Then
                    row("1st Year 1st Sem Honor Status") = honorStatus = False
                Else
                    row("1st Year 1st Sem Honor Status") = honorStatus

                End If

            ElseIf year = "2nd Year" Then
                ' GWA Computation For 2nd Year 1st Sem
                grade = (subject13 + subject14 + subject15 + subject16 + subject17 + subject18 + subject19) / 7
                row("2nd Year 1st Sem GWA") = grade

                ' Deans Lister Validation For 2nd Year 1st Sem BSCPE
                If (subject13 > 2.0 Or subject13 < 1) Or (subject14 > 2.0 Or subject14 < 1) Or (subject15 > 2.0 Or subject15 < 1) Or (subject16 > 2.0 Or subject16 < 1) Or (subject17 > 2.0 Or subject17 < 1) Or (subject18 > 2.0 Or subject18 < 1) Or (subject19 > 2.0 Or subject19 < 1) Then
                    row("2nd Year 1st Sem Honor Status") = honorStatus = False
                Else
                    row("2nd Year 1st Sem Honor Status") = honorStatus

                End If

            ElseIf year = "3rd Year" Then
                ' GWA Computation For 3rd Year 1st Sem
                grade = (subject27 + subject28 + subject29 + subject30 + subject31 + subject32 + subject33 + subject34) / 8
                row("3rd Year 1st Sem GWA") = grade

                ' Deans Lister Validation For 3rd Year 1st Sem BSCPE
                If (subject27 > 2.0 Or subject27 < 1) Or (subject28 > 2.0 Or subject28 < 1) Or (subject29 > 2.0 Or subject29 < 1) Or (subject30 > 2.0 Or subject30 < 1) Or (subject31 > 2.0 Or subject31 < 1) Or (subject32 > 2.0 Or subject32 < 1) Or (subject33 > 2.0 Or subject33 < 1) Or (subject34 > 2.0 Or subject34 < 1) Then
                    row("3rd Year 1st Sem Honor Status") = honorStatus = False
                Else
                    row("3rd Year 1st Sem Honor Status") = honorStatus

                End If

            ElseIf year = "4th Year" Then
                ' GWA Computation For 4th Year 1st Sem
                grade = (subject43 + subject44 + subject45 + subject46 + subject47 + subject48 + subject49 + subject50) / 8
                row("4th Year 1st Sem GWA") = grade

                ' Deans Lister Validation For 3rd Year 1st Sem BSCPE
                If (subject43 > 2.0 Or subject43 < 1) Or (subject44 > 2.0 Or subject44 < 1) Or (subject45 > 2.0 Or subject45 < 1) Or (subject46 > 2.0 Or subject46 < 1) Or (subject47 > 2.0 Or subject47 < 1) Or (subject48 > 2.0 Or subject48 < 1) Or (subject49 > 2.0 Or subject49 < 1) Or (subject50 > 2.0 Or subject50 < 1) Then
                    row("4th Year 1st Sem Honor Status") = honorStatus = False
                Else
                    row("4th Year 1st Sem Honor Status") = honorStatus

                End If

            End If
        Next

        connection.Open()

        For Each row As DataRow In table.Rows

            Dim studentID As String = Convert.ToString(row("Student ID"))
            Dim year As String = Convert.ToString(row("Year"))

            Dim grade As Double
            Dim honorStatus1 As Boolean = Convert.ToBoolean(row("1st Year 1st Sem Honor Status"))
            Dim honorStatus2 As Boolean = Convert.ToBoolean(row("2nd Year 1st Sem Honor Status"))
            Dim honorStatus3 As Boolean = Convert.ToBoolean(row("3rd Year 1st Sem Honor Status"))
            Dim honorStatus4 As Boolean = Convert.ToBoolean(row("4th Year 1st Sem Honor Status"))
            Dim updatequery As String

            If year = "1st Year" Then
                grade = Convert.ToDouble(row("1st Year 1st Sem GWA"))
                updatequery = "UPDATE bscpe SET `1st Year 1st Sem GWA` = @grade, `1st Year 1st Sem Honor Status` = @honorstatus1  WHERE `Student ID` = @studentid"

                Dim updatecommand As New MySqlCommand(updatequery, connection)

                updatecommand.Parameters.AddWithValue("@grade", Math.Round(grade, 2))
                updatecommand.Parameters.AddWithValue("@honorstatus1", honorStatus1)
                updatecommand.Parameters.AddWithValue("@studentid", studentID)

                updatecommand.ExecuteNonQuery()

                If honorStatus1 = True Then
                    Dim query As String = "INSERT INTO deanslist (`Student ID`, `Student Name`, `Program`,`Year`, `Section`, `GWA` ) SELECT `Student ID`, `Student Name`, `Program`, `Year`,`Section`,`1st Year 1st Sem GWA` FROM bscpe WHERE `Student ID` = @studentID"
                    Dim insertcommand As New MySqlCommand(query, connection)
                    insertcommand.Parameters.AddWithValue("@studentID", studentID)
                    insertcommand.ExecuteNonQuery()

                End If

            ElseIf year = "2nd Year" Then
                grade = Convert.ToDouble(row("2nd Year 1st Sem GWA"))
                updatequery = "UPDATE bscpe SET `2nd Year 1st Sem GWA` = @grade, `2nd Year 1st Sem Honor Status` = @honorstatus2 WHERE `Student ID` = @studentid"

                Dim updatecommand As New MySqlCommand(updatequery, connection)

                updatecommand.Parameters.AddWithValue("@grade", Math.Round(grade, 2))
                updatecommand.Parameters.AddWithValue("@honorstatus2", honorStatus2)
                updatecommand.Parameters.AddWithValue("@studentid", studentID)

                updatecommand.ExecuteNonQuery()

                If honorStatus2 = True Then
                    Dim query As String = "INSERT INTO deanslist (`Student ID`, `Student Name`, `Program`,`Year`, `Section`, `GWA` ) SELECT `Student ID`, `Student Name`, `Program`, `Year`,`Section`,`2nd Year 1st Sem GWA` FROM bscpe WHERE `Student ID` = @studentID"
                    Dim insertcommand As New MySqlCommand(query, connection)
                    insertcommand.Parameters.AddWithValue("@studentID", studentID)
                    insertcommand.ExecuteNonQuery()

                End If

            ElseIf year = "3rd Year" Then
                grade = Convert.ToDouble(row("3rd Year 1st Sem GWA"))
                updatequery = "UPDATE bscpe SET `3rd Year 1st Sem GWA` = @grade, `3rd Year 1st Sem Honor Status` = @honorstatus3 WHERE `Student ID` = @studentid"

                Dim updatecommand As New MySqlCommand(updatequery, connection)

                updatecommand.Parameters.AddWithValue("@grade", Math.Round(grade, 2))
                updatecommand.Parameters.AddWithValue("@honorstatus3", honorStatus3)
                updatecommand.Parameters.AddWithValue("@studentid", studentID)

                updatecommand.ExecuteNonQuery()

                If honorStatus3 = True Then
                    Dim query As String = "INSERT INTO deanslist (`Student ID`, `Student Name`, `Program`,`Year`, `Section`, `GWA` ) SELECT `Student ID`, `Student Name`, `Program`, `Year`,`Section`,`3rd Year 1st Sem GWA` FROM bscpe WHERE `Student ID` = @studentID"
                    Dim insertcommand As New MySqlCommand(query, connection)
                    insertcommand.Parameters.AddWithValue("@studentID", studentID)
                    insertcommand.ExecuteNonQuery()

                End If

            ElseIf year = "4th Year" Then
                grade = Convert.ToDouble(row("4th Year 1st Sem GWA"))
                updatequery = "UPDATE bscpe SET `4th Year 1st Sem GWA` = @grade, `4th Year 1st Sem Honor Status` = @honorstatus4 WHERE `Student ID` = @studentid"

                Dim updatecommand As New MySqlCommand(updatequery, connection)

                updatecommand.Parameters.AddWithValue("@grade", Math.Round(grade, 2))
                updatecommand.Parameters.AddWithValue("@honorstatus4", honorStatus4)
                updatecommand.Parameters.AddWithValue("@studentid", studentID)

                updatecommand.ExecuteNonQuery()

                If honorStatus4 = True Then
                    Dim query As String = "INSERT INTO deanslist (`Student ID`, `Student Name`, `Program`,`Year`, `Section`, `GWA` ) SELECT `Student ID`, `Student Name`, `Program`, `Year`,`Section`,`4th Year 1st Sem GWA` FROM bscpe WHERE `Student ID` = @studentID"
                    Dim insertcommand As New MySqlCommand(query, connection)
                    insertcommand.Parameters.AddWithValue("@studentID", studentID)
                    insertcommand.ExecuteNonQuery()

                End If

            End If

        Next
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
        connection.Close()
        Admin_Main.StudentList()

    End Sub


    ' BSCPE Second Semester Grade Evaluation
    Private Sub SecondSemBSCPE()

        Dim selectquery As String = "SELECT * FROM bscpe "
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
            Dim subject7 As Double = Convert.ToDouble(row("SUBJECT 7"))
            Dim subject8 As Double = Convert.ToDouble(row("SUBJECT 8"))
            Dim subject9 As Double = Convert.ToDouble(row("SUBJECT 9"))
            Dim subject10 As Double = Convert.ToDouble(row("SUBJECT 10"))
            Dim subject11 As Double = Convert.ToDouble(row("SUBJECT 11"))
            Dim subject12 As Double = Convert.ToDouble(row("SUBJECT 12"))

            ' 2nd Year 2nd Semester Subjects/Courses
            Dim subject20 As Double = Convert.ToDouble(row("SUBJECT 20"))
            Dim subject21 As Double = Convert.ToDouble(row("SUBJECT 21"))
            Dim subject22 As Double = Convert.ToDouble(row("SUBJECT 22"))
            Dim subject23 As Double = Convert.ToDouble(row("SUBJECT 23"))
            Dim subject24 As Double = Convert.ToDouble(row("SUBJECT 24"))
            Dim subject25 As Double = Convert.ToDouble(row("SUBJECT 25"))
            Dim subject26 As Double = Convert.ToDouble(row("SUBJECT 26"))

            ' 3rd Year 2nd Semester Subjects/Courses
            Dim subject35 As Double = Convert.ToDouble(row("SUBJECT 35"))
            Dim subject36 As Double = Convert.ToDouble(row("SUBJECT 36"))
            Dim subject37 As Double = Convert.ToDouble(row("SUBJECT 37"))
            Dim subject38 As Double = Convert.ToDouble(row("SUBJECT 38"))
            Dim subject39 As Double = Convert.ToDouble(row("SUBJECT 39"))
            Dim subject40 As Double = Convert.ToDouble(row("SUBJECT 40"))
            Dim subject41 As Double = Convert.ToDouble(row("SUBJECT 41"))
            Dim subject42 As Double = Convert.ToDouble(row("SUBJECT 42"))

            ' 4th Year 2nd Semester Subjects/Courses
            Dim subject51 As Double = Convert.ToDouble(row("SUBJECT 51"))
            Dim subject52 As Double = Convert.ToDouble(row("SUBJECT 52"))
            Dim subject53 As Double = Convert.ToDouble(row("SUBJECT 53"))
            Dim subject54 As Double = Convert.ToDouble(row("SUBJECT 54"))
            Dim subject55 As Double = Convert.ToDouble(row("SUBJECT 55"))
            Dim subject56 As Double = Convert.ToDouble(row("SUBJECT 56"))
            Dim subject57 As Double = Convert.ToDouble(row("SUBJECT 57"))
            Dim subject58 As Double = Convert.ToDouble(row("SUBJECT 58"))

            Dim grade As Double
            If year = "1st Year" Then
                grade = (subject7 + subject8 + subject9 + subject10 + subject11 + subject12) / 6
                row("1st Year 2nd Sem GWA") = grade

            ElseIf year = "2nd Year" Then
                grade = (subject20 + subject21 + subject22 + subject23 + subject24 + subject25 + subject26) / 7
                row("2nd Year 2nd Sem GWA") = grade

            ElseIf year = "3rd Year" Then
                grade = (subject35 + subject36 + subject37 + subject38 + subject39 + subject40 + subject41 + subject42) / 8
                row("3rd Year 2nd Sem GWA") = grade

            ElseIf year = "4th Year" Then
                grade = (subject51 + subject52 + subject53 + subject54 + subject55 + subject56 + subject57 + subject58) / 8
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
                updatequery = "UPDATE bscpe SET `1st Year 2nd Sem GWA` = @grade WHERE `Student ID` = @studentid"

            ElseIf year = "2nd Year" Then
                grade = Convert.ToDouble(row("2nd Year 2nd Sem GWA"))
                updatequery = "UPDATE bscpe SET `2nd Year 2nd Sem GWA` = @grade WHERE `Student ID` = @studentid"

            ElseIf year = "3rd Year" Then
                grade = Convert.ToDouble(row("3rd Year 2nd Sem GWA"))
                updatequery = "UPDATE bscpe SET `3rd Year 2nd Sem GWA` = @grade WHERE `Student ID` = @studentid"

            ElseIf year = "4th Year" Then
                grade = Convert.ToDouble(row("4th Year 2nd Sem GWA"))
                updatequery = "UPDATE bscpe SET `4th Year 2nd Sem GWA` = @grade WHERE `Student ID` = @studentid"

            End If

            Dim updatecommand As New MySqlCommand(updatequery, connection)

            updatecommand.Parameters.AddWithValue("@grade", Math.Round(grade, 2))
            updatecommand.Parameters.AddWithValue("@studentid", studentID)

            updatecommand.ExecuteNonQuery()

        Next
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