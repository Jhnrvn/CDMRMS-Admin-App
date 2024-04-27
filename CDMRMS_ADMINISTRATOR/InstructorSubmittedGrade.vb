Public Class InstructorSubmittedGrade
    Private Sub Close_Btn_Click(sender As Object, e As EventArgs) Handles Close_Btn.Click
        Me.Close()
        Admin_Main.Enabled = True
    End Sub
End Class