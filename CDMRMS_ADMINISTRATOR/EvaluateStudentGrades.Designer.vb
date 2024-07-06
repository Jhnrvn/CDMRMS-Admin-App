<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EvaluateStudentGrades
    Inherits MetroFramework.Forms.MetroForm


    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EvaluateStudentGrades))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Close_Btn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CDMinstructors_Label = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Evaluate_Btn = New System.Windows.Forms.Button()
        Me.InstructorInfo_Label = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.InstructorInstruction_1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SemesterSelector = New MetroFramework.Controls.MetroComboBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Close_Btn)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(-2, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(855, 607)
        Me.Panel1.TabIndex = 1
        '
        'Close_Btn
        '
        Me.Close_Btn.BackColor = System.Drawing.Color.Red
        Me.Close_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Close_Btn.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Close_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Close_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Close_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Close_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Close_Btn.ForeColor = System.Drawing.Color.White
        Me.Close_Btn.Location = New System.Drawing.Point(802, 3)
        Me.Close_Btn.Name = "Close_Btn"
        Me.Close_Btn.Size = New System.Drawing.Size(50, 35)
        Me.Close_Btn.TabIndex = 57
        Me.Close_Btn.Text = "X"
        Me.Close_Btn.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(3, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(849, 565)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.CDMinstructors_Label)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Evaluate_Btn)
        Me.Panel3.Controls.Add(Me.InstructorInfo_Label)
        Me.Panel3.Controls.Add(Me.Panel9)
        Me.Panel3.Controls.Add(Me.SemesterSelector)
        Me.Panel3.Location = New System.Drawing.Point(5, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(840, 555)
        Me.Panel3.TabIndex = 70
        '
        'CDMinstructors_Label
        '
        Me.CDMinstructors_Label.AutoSize = True
        Me.CDMinstructors_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold)
        Me.CDMinstructors_Label.Location = New System.Drawing.Point(211, 21)
        Me.CDMinstructors_Label.Name = "CDMinstructors_Label"
        Me.CDMinstructors_Label.Size = New System.Drawing.Size(393, 38)
        Me.CDMinstructors_Label.TabIndex = 78
        Me.CDMinstructors_Label.Text = "EVALUATE STUDENTS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CDMRMS_ADMINISTRATOR.My.Resources.Resources.CDM_Emblem
        Me.PictureBox1.Location = New System.Drawing.Point(552, 208)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(238, 224)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 77
        Me.PictureBox1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(46, 82)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(462, 87)
        Me.Panel4.TabIndex = 76
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(17, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(386, 60)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "     Please select the appropriate grade Semester " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "from the dropdown menu to eva" &
    "luate the student's " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "performance."
        '
        'Evaluate_Btn
        '
        Me.Evaluate_Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Evaluate_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Evaluate_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Evaluate_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Evaluate_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Evaluate_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Evaluate_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Evaluate_Btn.ForeColor = System.Drawing.Color.Black
        Me.Evaluate_Btn.Location = New System.Drawing.Point(683, 467)
        Me.Evaluate_Btn.Name = "Evaluate_Btn"
        Me.Evaluate_Btn.Size = New System.Drawing.Size(107, 42)
        Me.Evaluate_Btn.TabIndex = 69
        Me.Evaluate_Btn.Text = "Evaluate"
        Me.Evaluate_Btn.UseVisualStyleBackColor = False
        '
        'InstructorInfo_Label
        '
        Me.InstructorInfo_Label.AutoSize = True
        Me.InstructorInfo_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.InstructorInfo_Label.Location = New System.Drawing.Point(548, 104)
        Me.InstructorInfo_Label.Name = "InstructorInfo_Label"
        Me.InstructorInfo_Label.Size = New System.Drawing.Size(86, 22)
        Me.InstructorInfo_Label.TabIndex = 73
        Me.InstructorInfo_Label.Text = "Semester"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Panel9.Controls.Add(Me.InstructorInstruction_1)
        Me.Panel9.Controls.Add(Me.Label1)
        Me.Panel9.Location = New System.Drawing.Point(46, 208)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(462, 301)
        Me.Panel9.TabIndex = 72
        '
        'InstructorInstruction_1
        '
        Me.InstructorInstruction_1.AutoSize = True
        Me.InstructorInstruction_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstructorInstruction_1.ForeColor = System.Drawing.Color.Black
        Me.InstructorInstruction_1.Location = New System.Drawing.Point(17, 78)
        Me.InstructorInstruction_1.Name = "InstructorInstruction_1"
        Me.InstructorInstruction_1.Size = New System.Drawing.Size(355, 180)
        Me.InstructorInstruction_1.TabIndex = 75
        Me.InstructorInstruction_1.Text = resources.GetString("InstructorInstruction_1.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(14, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 38)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Qualifications:"
        '
        'SemesterSelector
        '
        Me.SemesterSelector.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.SemesterSelector.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SemesterSelector.FontSize = MetroFramework.MetroComboBoxSize.Tall
        Me.SemesterSelector.FontWeight = MetroFramework.MetroComboBoxWeight.Bold
        Me.SemesterSelector.ForeColor = System.Drawing.Color.Black
        Me.SemesterSelector.FormattingEnabled = True
        Me.SemesterSelector.ItemHeight = 29
        Me.SemesterSelector.Items.AddRange(New Object() {"1st Semester", "2nd Semester"})
        Me.SemesterSelector.Location = New System.Drawing.Point(552, 125)
        Me.SemesterSelector.Name = "SemesterSelector"
        Me.SemesterSelector.Size = New System.Drawing.Size(236, 35)
        Me.SemesterSelector.TabIndex = 67
        Me.SemesterSelector.UseCustomForeColor = True
        Me.SemesterSelector.UseSelectable = True
        '
        'EvaluateStudentGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 600)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EvaluateStudentGrades"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Style = MetroFramework.MetroColorStyle.White
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Close_Btn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Evaluate_Btn As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents SemesterSelector As MetroFramework.Controls.MetroComboBox
    Friend WithEvents InstructorInfo_Label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents InstructorInstruction_1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CDMinstructors_Label As Label
End Class
