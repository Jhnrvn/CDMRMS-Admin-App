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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.ReqAndSubmit_Panel = New System.Windows.Forms.Panel()
        Me.InstructorSubmittedGrade_Btn = New System.Windows.Forms.Button()
        Me.ChangeGradeReq_Btn = New System.Windows.Forms.Button()
        Me.InstructorInfo_Panel = New System.Windows.Forms.Panel()
        Me.InstructorInfo_Label = New System.Windows.Forms.Label()
        Me.CDMinstructors_Panel = New System.Windows.Forms.Panel()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.SelectInstructor_Btn = New System.Windows.Forms.Button()
        Me.Institute = New System.Windows.Forms.Label()
        Me.InstructorSearchBar = New MetroFramework.Controls.MetroTextBox()
        Me.InstructorsDataTable = New System.Windows.Forms.DataGridView()
        Me.CDMinstructors_Label = New System.Windows.Forms.Label()
        Me.DropdownTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Welcome_BG = New System.Windows.Forms.PictureBox()
        Me.GreenSide_Panel.SuspendLayout()
        Me.Dropdown_Panel.SuspendLayout()
        CType(Me.CMDRMS_PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CDM_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Instructor_Panel.SuspendLayout()
        Me.ReqAndSubmit_Panel.SuspendLayout()
        Me.InstructorInfo_Panel.SuspendLayout()
        Me.CDMinstructors_Panel.SuspendLayout()
        CType(Me.InstructorsDataTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Welcome_BG, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Instructor_Panel.Controls.Add(Me.ReqAndSubmit_Panel)
        Me.Instructor_Panel.Controls.Add(Me.InstructorInfo_Panel)
        Me.Instructor_Panel.Controls.Add(Me.CDMinstructors_Panel)
        Me.Instructor_Panel.Location = New System.Drawing.Point(218, 91)
        Me.Instructor_Panel.Name = "Instructor_Panel"
        Me.Instructor_Panel.Size = New System.Drawing.Size(1334, 784)
        Me.Instructor_Panel.TabIndex = 4
        '
        'ReqAndSubmit_Panel
        '
        Me.ReqAndSubmit_Panel.BackColor = System.Drawing.Color.White
        Me.ReqAndSubmit_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReqAndSubmit_Panel.Controls.Add(Me.InstructorSubmittedGrade_Btn)
        Me.ReqAndSubmit_Panel.Controls.Add(Me.ChangeGradeReq_Btn)
        Me.ReqAndSubmit_Panel.Location = New System.Drawing.Point(4, 518)
        Me.ReqAndSubmit_Panel.Name = "ReqAndSubmit_Panel"
        Me.ReqAndSubmit_Panel.Size = New System.Drawing.Size(641, 255)
        Me.ReqAndSubmit_Panel.TabIndex = 2
        '
        'InstructorSubmittedGrade_Btn
        '
        Me.InstructorSubmittedGrade_Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.InstructorSubmittedGrade_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.InstructorSubmittedGrade_Btn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.InstructorSubmittedGrade_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.InstructorSubmittedGrade_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.InstructorSubmittedGrade_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InstructorSubmittedGrade_Btn.Font = New System.Drawing.Font("Bernard MT Condensed", 31.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstructorSubmittedGrade_Btn.ForeColor = System.Drawing.Color.White
        Me.InstructorSubmittedGrade_Btn.Location = New System.Drawing.Point(321, 3)
        Me.InstructorSubmittedGrade_Btn.Name = "InstructorSubmittedGrade_Btn"
        Me.InstructorSubmittedGrade_Btn.Size = New System.Drawing.Size(312, 247)
        Me.InstructorSubmittedGrade_Btn.TabIndex = 56
        Me.InstructorSubmittedGrade_Btn.Text = "Instructor Submitted Grade"
        Me.InstructorSubmittedGrade_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.InstructorSubmittedGrade_Btn.UseVisualStyleBackColor = False
        '
        'ChangeGradeReq_Btn
        '
        Me.ChangeGradeReq_Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ChangeGradeReq_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChangeGradeReq_Btn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ChangeGradeReq_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ChangeGradeReq_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ChangeGradeReq_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChangeGradeReq_Btn.Font = New System.Drawing.Font("Bernard MT Condensed", 31.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangeGradeReq_Btn.ForeColor = System.Drawing.Color.White
        Me.ChangeGradeReq_Btn.Location = New System.Drawing.Point(5, 3)
        Me.ChangeGradeReq_Btn.Name = "ChangeGradeReq_Btn"
        Me.ChangeGradeReq_Btn.Size = New System.Drawing.Size(312, 247)
        Me.ChangeGradeReq_Btn.TabIndex = 55
        Me.ChangeGradeReq_Btn.Text = "Changing Grade Request"
        Me.ChangeGradeReq_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ChangeGradeReq_Btn.UseVisualStyleBackColor = False
        '
        'InstructorInfo_Panel
        '
        Me.InstructorInfo_Panel.BackColor = System.Drawing.Color.White
        Me.InstructorInfo_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InstructorInfo_Panel.Controls.Add(Me.InstructorInfo_Label)
        Me.InstructorInfo_Panel.Location = New System.Drawing.Point(651, 5)
        Me.InstructorInfo_Panel.Name = "InstructorInfo_Panel"
        Me.InstructorInfo_Panel.Size = New System.Drawing.Size(675, 768)
        Me.InstructorInfo_Panel.TabIndex = 1
        '
        'InstructorInfo_Label
        '
        Me.InstructorInfo_Label.AutoSize = True
        Me.InstructorInfo_Label.Font = New System.Drawing.Font("Bernard MT Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstructorInfo_Label.Location = New System.Drawing.Point(13, 9)
        Me.InstructorInfo_Label.Name = "InstructorInfo_Label"
        Me.InstructorInfo_Label.Size = New System.Drawing.Size(365, 40)
        Me.InstructorInfo_Label.TabIndex = 1
        Me.InstructorInfo_Label.Text = "CDM Instructor Information"
        '
        'CDMinstructors_Panel
        '
        Me.CDMinstructors_Panel.BackColor = System.Drawing.SystemColors.Window
        Me.CDMinstructors_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CDMinstructors_Panel.Controls.Add(Me.MetroTextBox1)
        Me.CDMinstructors_Panel.Controls.Add(Me.SelectInstructor_Btn)
        Me.CDMinstructors_Panel.Controls.Add(Me.Institute)
        Me.CDMinstructors_Panel.Controls.Add(Me.InstructorSearchBar)
        Me.CDMinstructors_Panel.Controls.Add(Me.InstructorsDataTable)
        Me.CDMinstructors_Panel.Controls.Add(Me.CDMinstructors_Label)
        Me.CDMinstructors_Panel.Location = New System.Drawing.Point(4, 5)
        Me.CDMinstructors_Panel.Name = "CDMinstructors_Panel"
        Me.CDMinstructors_Panel.Size = New System.Drawing.Size(641, 509)
        Me.CDMinstructors_Panel.TabIndex = 0
        '
        'MetroTextBox1
        '
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = Nothing
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(167, 2)
        Me.MetroTextBox1.CustomButton.Name = ""
        Me.MetroTextBox1.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.MetroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox1.CustomButton.TabIndex = 1
        Me.MetroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox1.CustomButton.UseSelectable = True
        Me.MetroTextBox1.CustomButton.Visible = False
        Me.MetroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.MetroTextBox1.Lines = New String(-1) {}
        Me.MetroTextBox1.Location = New System.Drawing.Point(321, 367)
        Me.MetroTextBox1.MaxLength = 100
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.ShortcutsEnabled = True
        Me.MetroTextBox1.Size = New System.Drawing.Size(205, 40)
        Me.MetroTextBox1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroTextBox1.TabIndex = 55
        Me.MetroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.Silver
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'SelectInstructor_Btn
        '
        Me.SelectInstructor_Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.SelectInstructor_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SelectInstructor_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.SelectInstructor_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.SelectInstructor_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.SelectInstructor_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SelectInstructor_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectInstructor_Btn.ForeColor = System.Drawing.Color.Black
        Me.SelectInstructor_Btn.Location = New System.Drawing.Point(531, 367)
        Me.SelectInstructor_Btn.Name = "SelectInstructor_Btn"
        Me.SelectInstructor_Btn.Size = New System.Drawing.Size(90, 40)
        Me.SelectInstructor_Btn.TabIndex = 54
        Me.SelectInstructor_Btn.Text = "Select"
        Me.SelectInstructor_Btn.UseVisualStyleBackColor = False
        '
        'Institute
        '
        Me.Institute.AutoSize = True
        Me.Institute.Cursor = System.Windows.Forms.Cursors.Default
        Me.Institute.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Institute.Location = New System.Drawing.Point(12, 348)
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
        Me.InstructorSearchBar.CustomButton.Location = New System.Drawing.Point(167, 2)
        Me.InstructorSearchBar.CustomButton.Name = ""
        Me.InstructorSearchBar.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.InstructorSearchBar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.InstructorSearchBar.CustomButton.TabIndex = 1
        Me.InstructorSearchBar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.InstructorSearchBar.CustomButton.UseSelectable = True
        Me.InstructorSearchBar.CustomButton.Visible = False
        Me.InstructorSearchBar.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.InstructorSearchBar.Lines = New String(-1) {}
        Me.InstructorSearchBar.Location = New System.Drawing.Point(16, 367)
        Me.InstructorSearchBar.MaxLength = 100
        Me.InstructorSearchBar.Name = "InstructorSearchBar"
        Me.InstructorSearchBar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.InstructorSearchBar.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.InstructorSearchBar.SelectedText = ""
        Me.InstructorSearchBar.SelectionLength = 0
        Me.InstructorSearchBar.SelectionStart = 0
        Me.InstructorSearchBar.ShortcutsEnabled = True
        Me.InstructorSearchBar.Size = New System.Drawing.Size(205, 40)
        Me.InstructorSearchBar.Style = MetroFramework.MetroColorStyle.Green
        Me.InstructorSearchBar.TabIndex = 37
        Me.InstructorSearchBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.InstructorSearchBar.UseSelectable = True
        Me.InstructorSearchBar.WaterMarkColor = System.Drawing.Color.Silver
        Me.InstructorSearchBar.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'InstructorsDataTable
        '
        Me.InstructorsDataTable.AllowUserToAddRows = False
        Me.InstructorsDataTable.AllowUserToDeleteRows = False
        Me.InstructorsDataTable.AllowUserToResizeColumns = False
        Me.InstructorsDataTable.AllowUserToResizeRows = False
        Me.InstructorsDataTable.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InstructorsDataTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.InstructorsDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InstructorsDataTable.GridColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.InstructorsDataTable.Location = New System.Drawing.Point(16, 63)
        Me.InstructorsDataTable.Name = "InstructorsDataTable"
        Me.InstructorsDataTable.ReadOnly = True
        Me.InstructorsDataTable.RowHeadersWidth = 51
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        Me.InstructorsDataTable.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.InstructorsDataTable.RowTemplate.Height = 24
        Me.InstructorsDataTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.InstructorsDataTable.Size = New System.Drawing.Size(605, 271)
        Me.InstructorsDataTable.TabIndex = 1
        '
        'CDMinstructors_Label
        '
        Me.CDMinstructors_Label.AutoSize = True
        Me.CDMinstructors_Label.Font = New System.Drawing.Font("Bernard MT Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CDMinstructors_Label.Location = New System.Drawing.Point(9, 9)
        Me.CDMinstructors_Label.Name = "CDMinstructors_Label"
        Me.CDMinstructors_Label.Size = New System.Drawing.Size(214, 40)
        Me.CDMinstructors_Label.TabIndex = 0
        Me.CDMinstructors_Label.Text = "CDM Instructors"
        '
        'DropdownTimer
        '
        Me.DropdownTimer.Interval = 15
        '
        'Welcome_BG
        '
        Me.Welcome_BG.Image = CType(resources.GetObject("Welcome_BG.Image"), System.Drawing.Image)
        Me.Welcome_BG.Location = New System.Drawing.Point(272, 118)
        Me.Welcome_BG.Name = "Welcome_BG"
        Me.Welcome_BG.Size = New System.Drawing.Size(1208, 599)
        Me.Welcome_BG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Welcome_BG.TabIndex = 5
        Me.Welcome_BG.TabStop = False
        '
        'Admin_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1550, 870)
        Me.Controls.Add(Me.Instructor_Panel)
        Me.Controls.Add(Me.GreenUpper_Panel)
        Me.Controls.Add(Me.GreenSide_Panel)
        Me.Controls.Add(Me.Welcome_BG)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1550, 870)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1550, 870)
        Me.Name = "Admin_Main"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.None
        Me.Style = MetroFramework.MetroColorStyle.White
        Me.GreenSide_Panel.ResumeLayout(False)
        Me.Dropdown_Panel.ResumeLayout(False)
        CType(Me.CMDRMS_PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CDM_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Instructor_Panel.ResumeLayout(False)
        Me.ReqAndSubmit_Panel.ResumeLayout(False)
        Me.InstructorInfo_Panel.ResumeLayout(False)
        Me.InstructorInfo_Panel.PerformLayout()
        Me.CDMinstructors_Panel.ResumeLayout(False)
        Me.CDMinstructors_Panel.PerformLayout()
        CType(Me.InstructorsDataTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Welcome_BG, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ReqAndSubmit_Panel As Panel
    Friend WithEvents InstructorInfo_Panel As Panel
    Friend WithEvents InstructorInfo_Label As Label
    Friend WithEvents CDMinstructors_Panel As Panel
    Friend WithEvents CDMinstructors_Label As Label
    Friend WithEvents DropdownTimer As Timer
    Friend WithEvents InstructorsDataTable As DataGridView
    Friend WithEvents Institute As Label
    Friend WithEvents SelectInstructor_Btn As Button
    Friend WithEvents ChangeGradeReq_Btn As Button
    Friend WithEvents InstructorSubmittedGrade_Btn As Button
    Friend WithEvents Welcome_BG As PictureBox
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents InstructorSearchBar As MetroFramework.Controls.MetroTextBox
End Class
