<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AssignedCourse_Section
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BG_Panel1 = New System.Windows.Forms.Panel()
        Me.Close_Btn = New System.Windows.Forms.Button()
        Me.AssignedCourse_Label = New System.Windows.Forms.Label()
        Me.BG_Panel2 = New System.Windows.Forms.Panel()
        Me.Edit_Btn = New System.Windows.Forms.Button()
        Me.Delete_Btn = New System.Windows.Forms.Button()
        Me.Institute = New System.Windows.Forms.Label()
        Me.InstructorSearchBar = New MetroFramework.Controls.MetroTextBox()
        Me.AssignedCourseTable = New System.Windows.Forms.DataGridView()
        Me.Save_Btn = New System.Windows.Forms.Button()
        Me.BG_Panel1.SuspendLayout()
        Me.BG_Panel2.SuspendLayout()
        CType(Me.AssignedCourseTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BG_Panel1
        '
        Me.BG_Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BG_Panel1.Controls.Add(Me.Close_Btn)
        Me.BG_Panel1.Controls.Add(Me.AssignedCourse_Label)
        Me.BG_Panel1.Controls.Add(Me.BG_Panel2)
        Me.BG_Panel1.Location = New System.Drawing.Point(-1, -2)
        Me.BG_Panel1.Name = "BG_Panel1"
        Me.BG_Panel1.Size = New System.Drawing.Size(855, 607)
        Me.BG_Panel1.TabIndex = 1
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
        Me.Close_Btn.Location = New System.Drawing.Point(797, 20)
        Me.Close_Btn.Name = "Close_Btn"
        Me.Close_Btn.Size = New System.Drawing.Size(42, 40)
        Me.Close_Btn.TabIndex = 57
        Me.Close_Btn.Text = "X"
        Me.Close_Btn.UseVisualStyleBackColor = False
        '
        'AssignedCourse_Label
        '
        Me.AssignedCourse_Label.AutoSize = True
        Me.AssignedCourse_Label.Font = New System.Drawing.Font("Bernard MT Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AssignedCourse_Label.ForeColor = System.Drawing.Color.White
        Me.AssignedCourse_Label.Location = New System.Drawing.Point(17, 20)
        Me.AssignedCourse_Label.Name = "AssignedCourse_Label"
        Me.AssignedCourse_Label.Size = New System.Drawing.Size(406, 40)
        Me.AssignedCourse_Label.TabIndex = 1
        Me.AssignedCourse_Label.Text = "Assigned Course/s and Section"
        '
        'BG_Panel2
        '
        Me.BG_Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BG_Panel2.Controls.Add(Me.Edit_Btn)
        Me.BG_Panel2.Controls.Add(Me.Delete_Btn)
        Me.BG_Panel2.Controls.Add(Me.Institute)
        Me.BG_Panel2.Controls.Add(Me.InstructorSearchBar)
        Me.BG_Panel2.Controls.Add(Me.AssignedCourseTable)
        Me.BG_Panel2.Controls.Add(Me.Save_Btn)
        Me.BG_Panel2.Location = New System.Drawing.Point(16, 63)
        Me.BG_Panel2.Name = "BG_Panel2"
        Me.BG_Panel2.Size = New System.Drawing.Size(823, 516)
        Me.BG_Panel2.TabIndex = 2
        '
        'Edit_Btn
        '
        Me.Edit_Btn.BackColor = System.Drawing.Color.Yellow
        Me.Edit_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Edit_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Edit_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Edit_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Edit_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Edit_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edit_Btn.ForeColor = System.Drawing.Color.Black
        Me.Edit_Btn.Location = New System.Drawing.Point(582, 421)
        Me.Edit_Btn.Name = "Edit_Btn"
        Me.Edit_Btn.Size = New System.Drawing.Size(107, 40)
        Me.Edit_Btn.TabIndex = 75
        Me.Edit_Btn.Text = "Edit"
        Me.Edit_Btn.UseVisualStyleBackColor = False
        '
        'Delete_Btn
        '
        Me.Delete_Btn.BackColor = System.Drawing.Color.Red
        Me.Delete_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Delete_Btn.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Delete_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Delete_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Delete_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Delete_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete_Btn.ForeColor = System.Drawing.Color.White
        Me.Delete_Btn.Location = New System.Drawing.Point(469, 421)
        Me.Delete_Btn.Name = "Delete_Btn"
        Me.Delete_Btn.Size = New System.Drawing.Size(107, 40)
        Me.Delete_Btn.TabIndex = 74
        Me.Delete_Btn.Text = "Delete"
        Me.Delete_Btn.UseVisualStyleBackColor = False
        '
        'Institute
        '
        Me.Institute.AutoSize = True
        Me.Institute.Cursor = System.Windows.Forms.Cursors.Default
        Me.Institute.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Institute.Location = New System.Drawing.Point(17, 402)
        Me.Institute.Name = "Institute"
        Me.Institute.Size = New System.Drawing.Size(138, 20)
        Me.Institute.TabIndex = 73
        Me.Institute.Text = "Search Instructor"
        '
        'InstructorSearchBar
        '
        '
        '
        '
        Me.InstructorSearchBar.CustomButton.Image = Nothing
        Me.InstructorSearchBar.CustomButton.Location = New System.Drawing.Point(223, 2)
        Me.InstructorSearchBar.CustomButton.Name = ""
        Me.InstructorSearchBar.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.InstructorSearchBar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.InstructorSearchBar.CustomButton.TabIndex = 1
        Me.InstructorSearchBar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.InstructorSearchBar.CustomButton.UseSelectable = True
        Me.InstructorSearchBar.CustomButton.Visible = False
        Me.InstructorSearchBar.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.InstructorSearchBar.Lines = New String(-1) {}
        Me.InstructorSearchBar.Location = New System.Drawing.Point(21, 421)
        Me.InstructorSearchBar.MaxLength = 100
        Me.InstructorSearchBar.Name = "InstructorSearchBar"
        Me.InstructorSearchBar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.InstructorSearchBar.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.InstructorSearchBar.SelectedText = ""
        Me.InstructorSearchBar.SelectionLength = 0
        Me.InstructorSearchBar.SelectionStart = 0
        Me.InstructorSearchBar.ShortcutsEnabled = True
        Me.InstructorSearchBar.Size = New System.Drawing.Size(261, 40)
        Me.InstructorSearchBar.Style = MetroFramework.MetroColorStyle.Yellow
        Me.InstructorSearchBar.TabIndex = 72
        Me.InstructorSearchBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.InstructorSearchBar.UseSelectable = True
        Me.InstructorSearchBar.WaterMarkColor = System.Drawing.Color.Silver
        Me.InstructorSearchBar.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'AssignedCourseTable
        '
        Me.AssignedCourseTable.AllowUserToResizeColumns = False
        Me.AssignedCourseTable.AllowUserToResizeRows = False
        Me.AssignedCourseTable.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Bernard MT Condensed", 14.2!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AssignedCourseTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.AssignedCourseTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AssignedCourseTable.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AssignedCourseTable.DefaultCellStyle = DataGridViewCellStyle5
        Me.AssignedCourseTable.GridColor = System.Drawing.Color.Black
        Me.AssignedCourseTable.Location = New System.Drawing.Point(21, 16)
        Me.AssignedCourseTable.Name = "AssignedCourseTable"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AssignedCourseTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.AssignedCourseTable.RowHeadersVisible = False
        Me.AssignedCourseTable.RowHeadersWidth = 51
        Me.AssignedCourseTable.RowTemplate.Height = 24
        Me.AssignedCourseTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AssignedCourseTable.Size = New System.Drawing.Size(781, 352)
        Me.AssignedCourseTable.TabIndex = 59
        '
        'Save_Btn
        '
        Me.Save_Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Save_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Save_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Save_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Save_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Save_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Save_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save_Btn.ForeColor = System.Drawing.Color.Black
        Me.Save_Btn.Location = New System.Drawing.Point(695, 421)
        Me.Save_Btn.Name = "Save_Btn"
        Me.Save_Btn.Size = New System.Drawing.Size(107, 40)
        Me.Save_Btn.TabIndex = 55
        Me.Save_Btn.Text = "Save"
        Me.Save_Btn.UseVisualStyleBackColor = False
        '
        'AssignedCourse_Section
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 600)
        Me.Controls.Add(Me.BG_Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AssignedCourse_Section"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.None
        Me.Style = MetroFramework.MetroColorStyle.White
        Me.BG_Panel1.ResumeLayout(False)
        Me.BG_Panel1.PerformLayout()
        Me.BG_Panel2.ResumeLayout(False)
        Me.BG_Panel2.PerformLayout()
        CType(Me.AssignedCourseTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BG_Panel1 As Panel
    Friend WithEvents Close_Btn As Button
    Friend WithEvents AssignedCourse_Label As Label
    Friend WithEvents BG_Panel2 As Panel
    Friend WithEvents Save_Btn As Button
    Friend WithEvents AssignedCourseTable As DataGridView
    Friend WithEvents Delete_Btn As Button
    Friend WithEvents Institute As Label
    Friend WithEvents InstructorSearchBar As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Edit_Btn As Button
End Class
