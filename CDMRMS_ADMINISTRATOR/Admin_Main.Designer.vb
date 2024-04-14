<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin_Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_Main))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GreenSide_Panel = New System.Windows.Forms.Panel()
        Me.Dropdown_Panel = New System.Windows.Forms.Panel()
        Me.Student_Btn = New System.Windows.Forms.Button()
        Me.Instructor_Btn = New System.Windows.Forms.Button()
        Me.Dashboard_Btn = New System.Windows.Forms.Button()
        Me.Menu_Btn = New System.Windows.Forms.Button()
        Me.CMDRMS_PicBox = New System.Windows.Forms.PictureBox()
        Me.CDM_Logo = New System.Windows.Forms.PictureBox()
        Me.GreenUpper_Panel = New System.Windows.Forms.Panel()
        Me.Instructor_Panel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CourseReq_Panel = New System.Windows.Forms.Panel()
        Me.Send_Btn = New System.Windows.Forms.Button()
        Me.Choose_Btn = New System.Windows.Forms.Button()
        Me.CourseReq_Label = New System.Windows.Forms.Label()
        Me.Profile_Panel = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Institute = New System.Windows.Forms.Label()
        Me.InstructorSearchBar = New MetroFramework.Controls.MetroTextBox()
        Me.InstructorsDataTable = New System.Windows.Forms.DataGridView()
        Me.Profile_Label = New System.Windows.Forms.Label()
        Me.DropdownTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GreenSide_Panel.SuspendLayout()
        Me.Dropdown_Panel.SuspendLayout()
        CType(Me.CMDRMS_PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CDM_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Instructor_Panel.SuspendLayout()
        Me.CourseReq_Panel.SuspendLayout()
        Me.Profile_Panel.SuspendLayout()
        CType(Me.InstructorsDataTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GreenSide_Panel
        '
        Me.GreenSide_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.GreenSide_Panel.Controls.Add(Me.Dropdown_Panel)
        Me.GreenSide_Panel.Controls.Add(Me.CMDRMS_PicBox)
        Me.GreenSide_Panel.Controls.Add(Me.CDM_Logo)
        Me.GreenSide_Panel.Location = New System.Drawing.Point(-1, 31)
        Me.GreenSide_Panel.Name = "GreenSide_Panel"
        Me.GreenSide_Panel.Size = New System.Drawing.Size(220, 842)
        Me.GreenSide_Panel.TabIndex = 1
        '
        'Dropdown_Panel
        '
        Me.Dropdown_Panel.BackColor = System.Drawing.Color.White
        Me.Dropdown_Panel.Controls.Add(Me.Student_Btn)
        Me.Dropdown_Panel.Controls.Add(Me.Instructor_Btn)
        Me.Dropdown_Panel.Controls.Add(Me.Dashboard_Btn)
        Me.Dropdown_Panel.Controls.Add(Me.Menu_Btn)
        Me.Dropdown_Panel.Location = New System.Drawing.Point(2, 1)
        Me.Dropdown_Panel.MaximumSize = New System.Drawing.Size(216, 208)
        Me.Dropdown_Panel.MinimumSize = New System.Drawing.Size(216, 58)
        Me.Dropdown_Panel.Name = "Dropdown_Panel"
        Me.Dropdown_Panel.Size = New System.Drawing.Size(216, 208)
        Me.Dropdown_Panel.TabIndex = 1
        '
        'Student_Btn
        '
        Me.Student_Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Student_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Student_Btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.Student_Btn.FlatAppearance.BorderSize = 0
        Me.Student_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Student_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Student_Btn.Location = New System.Drawing.Point(0, 158)
        Me.Student_Btn.Name = "Student_Btn"
        Me.Student_Btn.Size = New System.Drawing.Size(216, 50)
        Me.Student_Btn.TabIndex = 4
        Me.Student_Btn.Text = "Student"
        Me.Student_Btn.UseVisualStyleBackColor = False
        '
        'Instructor_Btn
        '
        Me.Instructor_Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Instructor_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Instructor_Btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.Instructor_Btn.FlatAppearance.BorderSize = 0
        Me.Instructor_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Instructor_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Instructor_Btn.Location = New System.Drawing.Point(0, 108)
        Me.Instructor_Btn.Name = "Instructor_Btn"
        Me.Instructor_Btn.Size = New System.Drawing.Size(216, 50)
        Me.Instructor_Btn.TabIndex = 3
        Me.Instructor_Btn.Text = "Instructor"
        Me.Instructor_Btn.UseVisualStyleBackColor = False
        '
        'Dashboard_Btn
        '
        Me.Dashboard_Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Dashboard_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Dashboard_Btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.Dashboard_Btn.FlatAppearance.BorderSize = 0
        Me.Dashboard_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Dashboard_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dashboard_Btn.Location = New System.Drawing.Point(0, 58)
        Me.Dashboard_Btn.Name = "Dashboard_Btn"
        Me.Dashboard_Btn.Size = New System.Drawing.Size(216, 50)
        Me.Dashboard_Btn.TabIndex = 2
        Me.Dashboard_Btn.Text = "Dashboard"
        Me.Dashboard_Btn.UseVisualStyleBackColor = False
        '
        'Menu_Btn
        '
        Me.Menu_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Menu_Btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.Menu_Btn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Menu_Btn.FlatAppearance.BorderSize = 0
        Me.Menu_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Menu_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Menu_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Menu_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu_Btn.Location = New System.Drawing.Point(0, 0)
        Me.Menu_Btn.Name = "Menu_Btn"
        Me.Menu_Btn.Size = New System.Drawing.Size(216, 58)
        Me.Menu_Btn.TabIndex = 1
        Me.Menu_Btn.Text = "MENU"
        Me.Menu_Btn.UseVisualStyleBackColor = True
        '
        'CMDRMS_PicBox
        '
        Me.CMDRMS_PicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CMDRMS_PicBox.Image = CType(resources.GetObject("CMDRMS_PicBox.Image"), System.Drawing.Image)
        Me.CMDRMS_PicBox.Location = New System.Drawing.Point(23, 686)
        Me.CMDRMS_PicBox.Name = "CMDRMS_PicBox"
        Me.CMDRMS_PicBox.Size = New System.Drawing.Size(164, 125)
        Me.CMDRMS_PicBox.TabIndex = 52
        Me.CMDRMS_PicBox.TabStop = False
        '
        'CDM_Logo
        '
        Me.CDM_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CDM_Logo.Image = CType(resources.GetObject("CDM_Logo.Image"), System.Drawing.Image)
        Me.CDM_Logo.Location = New System.Drawing.Point(16, 198)
        Me.CDM_Logo.Name = "CDM_Logo"
        Me.CDM_Logo.Size = New System.Drawing.Size(175, 500)
        Me.CDM_Logo.TabIndex = 3
        Me.CDM_Logo.TabStop = False
        '
        'GreenUpper_Panel
        '
        Me.GreenUpper_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.GreenUpper_Panel.Location = New System.Drawing.Point(217, 31)
        Me.GreenUpper_Panel.Name = "GreenUpper_Panel"
        Me.GreenUpper_Panel.Size = New System.Drawing.Size(1334, 60)
        Me.GreenUpper_Panel.TabIndex = 3
        '
        'Instructor_Panel
        '
        Me.Instructor_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Instructor_Panel.Controls.Add(Me.Panel1)
        Me.Instructor_Panel.Controls.Add(Me.CourseReq_Panel)
        Me.Instructor_Panel.Controls.Add(Me.Profile_Panel)
        Me.Instructor_Panel.Location = New System.Drawing.Point(218, 91)
        Me.Instructor_Panel.Name = "Instructor_Panel"
        Me.Instructor_Panel.Size = New System.Drawing.Size(1334, 784)
        Me.Instructor_Panel.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(4, 518)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1322, 233)
        Me.Panel1.TabIndex = 2
        '
        'CourseReq_Panel
        '
        Me.CourseReq_Panel.BackColor = System.Drawing.Color.White
        Me.CourseReq_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CourseReq_Panel.Controls.Add(Me.Send_Btn)
        Me.CourseReq_Panel.Controls.Add(Me.Choose_Btn)
        Me.CourseReq_Panel.Controls.Add(Me.CourseReq_Label)
        Me.CourseReq_Panel.Location = New System.Drawing.Point(821, 5)
        Me.CourseReq_Panel.Name = "CourseReq_Panel"
        Me.CourseReq_Panel.Size = New System.Drawing.Size(505, 509)
        Me.CourseReq_Panel.TabIndex = 1
        '
        'Send_Btn
        '
        Me.Send_Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Send_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Send_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Send_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Send_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Send_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Send_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Send_Btn.ForeColor = System.Drawing.Color.Black
        Me.Send_Btn.Location = New System.Drawing.Point(295, 435)
        Me.Send_Btn.Name = "Send_Btn"
        Me.Send_Btn.Size = New System.Drawing.Size(90, 40)
        Me.Send_Btn.TabIndex = 53
        Me.Send_Btn.Text = "Send"
        Me.Send_Btn.UseVisualStyleBackColor = False
        '
        'Choose_Btn
        '
        Me.Choose_Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Choose_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Choose_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Choose_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Choose_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Choose_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Choose_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Choose_Btn.ForeColor = System.Drawing.Color.Black
        Me.Choose_Btn.Location = New System.Drawing.Point(199, 435)
        Me.Choose_Btn.Name = "Choose_Btn"
        Me.Choose_Btn.Size = New System.Drawing.Size(90, 40)
        Me.Choose_Btn.TabIndex = 52
        Me.Choose_Btn.Text = "Choose"
        Me.Choose_Btn.UseVisualStyleBackColor = False
        '
        'CourseReq_Label
        '
        Me.CourseReq_Label.AutoSize = True
        Me.CourseReq_Label.Font = New System.Drawing.Font("Bernard MT Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CourseReq_Label.Location = New System.Drawing.Point(13, 9)
        Me.CourseReq_Label.Name = "CourseReq_Label"
        Me.CourseReq_Label.Size = New System.Drawing.Size(312, 40)
        Me.CourseReq_Label.TabIndex = 1
        Me.CourseReq_Label.Text = "Course Handle Request"
        '
        'Profile_Panel
        '
        Me.Profile_Panel.BackColor = System.Drawing.SystemColors.Window
        Me.Profile_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Profile_Panel.Controls.Add(Me.Button1)
        Me.Profile_Panel.Controls.Add(Me.Institute)
        Me.Profile_Panel.Controls.Add(Me.InstructorSearchBar)
        Me.Profile_Panel.Controls.Add(Me.InstructorsDataTable)
        Me.Profile_Panel.Controls.Add(Me.Profile_Label)
        Me.Profile_Panel.Location = New System.Drawing.Point(4, 5)
        Me.Profile_Panel.Name = "Profile_Panel"
        Me.Profile_Panel.Size = New System.Drawing.Size(811, 509)
        Me.Profile_Panel.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(240, 330)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 40)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = "Choose"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Institute
        '
        Me.Institute.AutoSize = True
        Me.Institute.Cursor = System.Windows.Forms.Cursors.Default
        Me.Institute.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Institute.Location = New System.Drawing.Point(12, 311)
        Me.Institute.Name = "Institute"
        Me.Institute.Size = New System.Drawing.Size(138, 20)
        Me.Institute.TabIndex = 53
        Me.Institute.Text = "Search Instructor"
        '
        'InstructorSearchBar
        '
        '
        '
        '
        Me.InstructorSearchBar.CustomButton.Image = Nothing
        Me.InstructorSearchBar.CustomButton.Location = New System.Drawing.Point(180, 2)
        Me.InstructorSearchBar.CustomButton.Name = ""
        Me.InstructorSearchBar.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.InstructorSearchBar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.InstructorSearchBar.CustomButton.TabIndex = 1
        Me.InstructorSearchBar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.InstructorSearchBar.CustomButton.UseSelectable = True
        Me.InstructorSearchBar.CustomButton.Visible = False
        Me.InstructorSearchBar.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.InstructorSearchBar.Lines = New String(-1) {}
        Me.InstructorSearchBar.Location = New System.Drawing.Point(16, 330)
        Me.InstructorSearchBar.MaxLength = 100
        Me.InstructorSearchBar.Name = "InstructorSearchBar"
        Me.InstructorSearchBar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.InstructorSearchBar.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.InstructorSearchBar.SelectedText = ""
        Me.InstructorSearchBar.SelectionLength = 0
        Me.InstructorSearchBar.SelectionStart = 0
        Me.InstructorSearchBar.ShortcutsEnabled = True
        Me.InstructorSearchBar.Size = New System.Drawing.Size(218, 40)
        Me.InstructorSearchBar.Style = MetroFramework.MetroColorStyle.Green
        Me.InstructorSearchBar.TabIndex = 37
        Me.InstructorSearchBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.InstructorSearchBar.UseSelectable = True
        Me.InstructorSearchBar.WaterMarkColor = System.Drawing.Color.Silver
        Me.InstructorSearchBar.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'InstructorsDataTable
        '
        Me.InstructorsDataTable.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InstructorsDataTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.InstructorsDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InstructorsDataTable.Location = New System.Drawing.Point(16, 63)
        Me.InstructorsDataTable.Name = "InstructorsDataTable"
        Me.InstructorsDataTable.RowHeadersWidth = 51
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.InstructorsDataTable.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.InstructorsDataTable.RowTemplate.Height = 24
        Me.InstructorsDataTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.InstructorsDataTable.Size = New System.Drawing.Size(773, 233)
        Me.InstructorsDataTable.TabIndex = 1
        '
        'Profile_Label
        '
        Me.Profile_Label.AutoSize = True
        Me.Profile_Label.Font = New System.Drawing.Font("Bernard MT Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Profile_Label.Location = New System.Drawing.Point(9, 9)
        Me.Profile_Label.Name = "Profile_Label"
        Me.Profile_Label.Size = New System.Drawing.Size(214, 40)
        Me.Profile_Label.TabIndex = 0
        Me.Profile_Label.Text = "CDM Instructors"
        '
        'DropdownTimer
        '
        Me.DropdownTimer.Interval = 15
        '
        'Admin_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1550, 870)
        Me.Controls.Add(Me.Instructor_Panel)
        Me.Controls.Add(Me.GreenUpper_Panel)
        Me.Controls.Add(Me.GreenSide_Panel)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1550, 870)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1550, 870)
        Me.Name = "Admin_Main"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.None
        Me.Style = MetroFramework.MetroColorStyle.White
        Me.GreenSide_Panel.ResumeLayout(False)
        Me.Dropdown_Panel.ResumeLayout(False)
        CType(Me.CMDRMS_PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CDM_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Instructor_Panel.ResumeLayout(False)
        Me.CourseReq_Panel.ResumeLayout(False)
        Me.CourseReq_Panel.PerformLayout()
        Me.Profile_Panel.ResumeLayout(False)
        Me.Profile_Panel.PerformLayout()
        CType(Me.InstructorsDataTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GreenSide_Panel As Panel
    Friend WithEvents Dropdown_Panel As Panel
    Friend WithEvents Student_Btn As Button
    Friend WithEvents Instructor_Btn As Button
    Friend WithEvents Dashboard_Btn As Button
    Friend WithEvents Menu_Btn As Button
    Friend WithEvents CMDRMS_PicBox As PictureBox
    Friend WithEvents CDM_Logo As PictureBox
    Friend WithEvents GreenUpper_Panel As Panel
    Friend WithEvents Instructor_Panel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CourseReq_Panel As Panel
    Friend WithEvents Send_Btn As Button
    Friend WithEvents Choose_Btn As Button
    Friend WithEvents CourseReq_Label As Label
    Friend WithEvents Profile_Panel As Panel
    Friend WithEvents Profile_Label As Label
    Friend WithEvents DropdownTimer As Timer
    Friend WithEvents InstructorsDataTable As DataGridView
    Friend WithEvents InstructorSearchBar As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Institute As Label
    Friend WithEvents Button1 As Button
End Class
