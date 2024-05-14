
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





    End Sub

    ' Close form
    Private Sub Close_Btn_Click(sender As Object, e As EventArgs) Handles Close_Btn.Click
        Me.Close()
        Admin_Main.Enabled = True
        Admin_Main.BringToFront()
    End Sub


End Class