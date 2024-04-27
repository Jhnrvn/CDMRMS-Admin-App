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
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.AssignedCourse_Btn = New System.Windows.Forms.Button()
        Me.ChangeGradeReq_Btn = New System.Windows.Forms.Button()
        Me.InstructorSubmittedGrade_Btn = New System.Windows.Forms.Button()
        Me.InstructorInfo_Panel = New System.Windows.Forms.Panel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LN_Label = New System.Windows.Forms.Label()
        Me.Birthday_Label = New System.Windows.Forms.Label()
        Me.Birthday_TB = New MetroFramework.Controls.MetroTextBox()
        Me.CN_Label = New System.Windows.Forms.Label()
        Me.Email_ = New System.Windows.Forms.Label()
        Me.Sex_Label = New System.Windows.Forms.Label()
        Me.Sex_TB = New MetroFramework.Controls.MetroTextBox()
        Me.InstructorID_Label = New System.Windows.Forms.Label()
        Me.LN_TB = New MetroFramework.Controls.MetroTextBox()
        Me.MN_Label = New System.Windows.Forms.Label()
        Me.FN_Label = New System.Windows.Forms.Label()
        Me.MN_TB = New MetroFramework.Controls.MetroTextBox()
        Me.FN_TB = New MetroFramework.Controls.MetroTextBox()
        Me.InstructorsID_TB = New MetroFramework.Controls.MetroTextBox()
        Me.CN_TB = New MetroFramework.Controls.MetroTextBox()
        Me.Email_TB = New MetroFramework.Controls.MetroTextBox()
        Me.InstructorInfo_Label = New System.Windows.Forms.Label()
        Me.CDMinstructors_Panel = New System.Windows.Forms.Panel()
        Me.Clear_Btn = New System.Windows.Forms.Button()
        Me.InstructorsDataTable = New System.Windows.Forms.DataGridView()
        Me.ViewInstructorInfo = New System.Windows.Forms.Button()
        Me.Institute = New System.Windows.Forms.Label()
        Me.InstructorSearchBar = New MetroFramework.Controls.MetroTextBox()
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
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ReqAndSubmit_Panel.Controls.Add(Me.AssignedCourse_Btn)
        Me.ReqAndSubmit_Panel.Controls.Add(Me.ChangeGradeReq_Btn)
        Me.ReqAndSubmit_Panel.Controls.Add(Me.InstructorSubmittedGrade_Btn)
        Me.ReqAndSubmit_Panel.Location = New System.Drawing.Point(4, 518)
        Me.ReqAndSubmit_Panel.Name = "ReqAndSubmit_Panel"
        Me.ReqAndSubmit_Panel.Size = New System.Drawing.Size(631, 255)
        Me.ReqAndSubmit_Panel.TabIndex = 2
        '
        'AssignedCourse_Btn
        '
        Me.AssignedCourse_Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.AssignedCourse_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AssignedCourse_Btn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.AssignedCourse_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.AssignedCourse_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.AssignedCourse_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AssignedCourse_Btn.Font = New System.Drawing.Font("Bernard MT Condensed", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AssignedCourse_Btn.ForeColor = System.Drawing.Color.White
        Me.AssignedCourse_Btn.Location = New System.Drawing.Point(419, 3)
        Me.AssignedCourse_Btn.Name = "AssignedCourse_Btn"
        Me.AssignedCourse_Btn.Size = New System.Drawing.Size(207, 247)
        Me.AssignedCourse_Btn.TabIndex = 57
        Me.AssignedCourse_Btn.Text = "Assinged Course and Section"
        Me.AssignedCourse_Btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.AssignedCourse_Btn.UseVisualStyleBackColor = False
        '
        'ChangeGradeReq_Btn
        '
        Me.ChangeGradeReq_Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ChangeGradeReq_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChangeGradeReq_Btn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ChangeGradeReq_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ChangeGradeReq_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ChangeGradeReq_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChangeGradeReq_Btn.Font = New System.Drawing.Font("Bernard MT Condensed", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangeGradeReq_Btn.ForeColor = System.Drawing.Color.White
        Me.ChangeGradeReq_Btn.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ChangeGradeReq_Btn.Location = New System.Drawing.Point(3, 3)
        Me.ChangeGradeReq_Btn.Name = "ChangeGradeReq_Btn"
        Me.ChangeGradeReq_Btn.Size = New System.Drawing.Size(207, 247)
        Me.ChangeGradeReq_Btn.TabIndex = 55
        Me.ChangeGradeReq_Btn.Text = "Changing Grade Request"
        Me.ChangeGradeReq_Btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ChangeGradeReq_Btn.UseVisualStyleBackColor = False
        '
        'InstructorSubmittedGrade_Btn
        '
        Me.InstructorSubmittedGrade_Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.InstructorSubmittedGrade_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.InstructorSubmittedGrade_Btn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.InstructorSubmittedGrade_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.InstructorSubmittedGrade_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.InstructorSubmittedGrade_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InstructorSubmittedGrade_Btn.Font = New System.Drawing.Font("Bernard MT Condensed", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstructorSubmittedGrade_Btn.ForeColor = System.Drawing.Color.White
        Me.InstructorSubmittedGrade_Btn.Location = New System.Drawing.Point(211, 3)
        Me.InstructorSubmittedGrade_Btn.Name = "InstructorSubmittedGrade_Btn"
        Me.InstructorSubmittedGrade_Btn.Size = New System.Drawing.Size(207, 247)
        Me.InstructorSubmittedGrade_Btn.TabIndex = 56
        Me.InstructorSubmittedGrade_Btn.Text = "Instructor Submitted Grade"
        Me.InstructorSubmittedGrade_Btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.InstructorSubmittedGrade_Btn.UseVisualStyleBackColor = False
        '
        'InstructorInfo_Panel
        '
        Me.InstructorInfo_Panel.BackColor = System.Drawing.Color.White
        Me.InstructorInfo_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InstructorInfo_Panel.Controls.Add(Me.DataGridView2)
        Me.InstructorInfo_Panel.Controls.Add(Me.Label2)
        Me.InstructorInfo_Panel.Controls.Add(Me.Label1)
        Me.InstructorInfo_Panel.Controls.Add(Me.DataGridView1)
        Me.InstructorInfo_Panel.Controls.Add(Me.LN_Label)
        Me.InstructorInfo_Panel.Controls.Add(Me.Birthday_Label)
        Me.InstructorInfo_Panel.Controls.Add(Me.Birthday_TB)
        Me.InstructorInfo_Panel.Controls.Add(Me.CN_Label)
        Me.InstructorInfo_Panel.Controls.Add(Me.Email_)
        Me.InstructorInfo_Panel.Controls.Add(Me.Sex_Label)
        Me.InstructorInfo_Panel.Controls.Add(Me.Sex_TB)
        Me.InstructorInfo_Panel.Controls.Add(Me.InstructorID_Label)
        Me.InstructorInfo_Panel.Controls.Add(Me.LN_TB)
        Me.InstructorInfo_Panel.Controls.Add(Me.MN_Label)
        Me.InstructorInfo_Panel.Controls.Add(Me.FN_Label)
        Me.InstructorInfo_Panel.Controls.Add(Me.MN_TB)
        Me.InstructorInfo_Panel.Controls.Add(Me.FN_TB)
        Me.InstructorInfo_Panel.Controls.Add(Me.InstructorsID_TB)
        Me.InstructorInfo_Panel.Controls.Add(Me.CN_TB)
        Me.InstructorInfo_Panel.Controls.Add(Me.Email_TB)
        Me.InstructorInfo_Panel.Controls.Add(Me.InstructorInfo_Label)
        Me.InstructorInfo_Panel.Location = New System.Drawing.Point(641, 5)
        Me.InstructorInfo_Panel.Name = "InstructorInfo_Panel"
        Me.InstructorInfo_Panel.Size = New System.Drawing.Size(685, 769)
        Me.InstructorInfo_Panel.TabIndex = 1
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(44, 599)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(596, 81)
        Me.DataGridView2.TabIndex = 71
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bernard MT Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 556)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(238, 40)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Assigned Sections"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bernard MT Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 409)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 40)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Assigned Course/s"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(44, 455)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(596, 81)
        Me.DataGridView1.TabIndex = 67
        '
        'LN_Label
        '
        Me.LN_Label.AutoSize = True
        Me.LN_Label.Cursor = System.Windows.Forms.Cursors.Default
        Me.LN_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LN_Label.Location = New System.Drawing.Point(441, 138)
        Me.LN_Label.Name = "LN_Label"
        Me.LN_Label.Size = New System.Drawing.Size(91, 20)
        Me.LN_Label.TabIndex = 53
        Me.LN_Label.Text = "Last Name"
        '
        'Birthday_Label
        '
        Me.Birthday_Label.AutoSize = True
        Me.Birthday_Label.Cursor = System.Windows.Forms.Cursors.Default
        Me.Birthday_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Birthday_Label.Location = New System.Drawing.Point(441, 214)
        Me.Birthday_Label.Name = "Birthday_Label"
        Me.Birthday_Label.Size = New System.Drawing.Size(71, 20)
        Me.Birthday_Label.TabIndex = 65
        Me.Birthday_Label.Text = "Birthday"
        '
        'Birthday_TB
        '
        Me.Birthday_TB.BackColor = System.Drawing.Color.Yellow
        '
        '
        '
        Me.Birthday_TB.CustomButton.Image = Nothing
        Me.Birthday_TB.CustomButton.Location = New System.Drawing.Point(157, 2)
        Me.Birthday_TB.CustomButton.Name = ""
        Me.Birthday_TB.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.Birthday_TB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Birthday_TB.CustomButton.TabIndex = 1
        Me.Birthday_TB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Birthday_TB.CustomButton.UseSelectable = True
        Me.Birthday_TB.CustomButton.Visible = False
        Me.Birthday_TB.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.Birthday_TB.Lines = New String(-1) {}
        Me.Birthday_TB.Location = New System.Drawing.Point(445, 233)
        Me.Birthday_TB.MaxLength = 8
        Me.Birthday_TB.Name = "Birthday_TB"
        Me.Birthday_TB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Birthday_TB.ReadOnly = True
        Me.Birthday_TB.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Birthday_TB.SelectedText = ""
        Me.Birthday_TB.SelectionLength = 0
        Me.Birthday_TB.SelectionStart = 0
        Me.Birthday_TB.ShortcutsEnabled = True
        Me.Birthday_TB.Size = New System.Drawing.Size(195, 40)
        Me.Birthday_TB.Style = MetroFramework.MetroColorStyle.Green
        Me.Birthday_TB.TabIndex = 64
        Me.Birthday_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Birthday_TB.UseCustomBackColor = True
        Me.Birthday_TB.UseSelectable = True
        Me.Birthday_TB.WaterMarkColor = System.Drawing.Color.Silver
        Me.Birthday_TB.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'CN_Label
        '
        Me.CN_Label.AutoSize = True
        Me.CN_Label.Cursor = System.Windows.Forms.Cursors.Default
        Me.CN_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CN_Label.Location = New System.Drawing.Point(241, 214)
        Me.CN_Label.Name = "CN_Label"
        Me.CN_Label.Size = New System.Drawing.Size(131, 20)
        Me.CN_Label.TabIndex = 63
        Me.CN_Label.Text = "Contact Number"
        '
        'Email_
        '
        Me.Email_.AutoSize = True
        Me.Email_.Cursor = System.Windows.Forms.Cursors.Default
        Me.Email_.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email_.Location = New System.Drawing.Point(40, 290)
        Me.Email_.Name = "Email_"
        Me.Email_.Size = New System.Drawing.Size(118, 20)
        Me.Email_.TabIndex = 61
        Me.Email_.Text = "Email Address"
        '
        'Sex_Label
        '
        Me.Sex_Label.AutoSize = True
        Me.Sex_Label.Cursor = System.Windows.Forms.Cursors.Default
        Me.Sex_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sex_Label.Location = New System.Drawing.Point(40, 214)
        Me.Sex_Label.Name = "Sex_Label"
        Me.Sex_Label.Size = New System.Drawing.Size(37, 20)
        Me.Sex_Label.TabIndex = 59
        Me.Sex_Label.Text = "Sex"
        '
        'Sex_TB
        '
        Me.Sex_TB.BackColor = System.Drawing.Color.Yellow
        '
        '
        '
        Me.Sex_TB.CustomButton.Image = Nothing
        Me.Sex_TB.CustomButton.Location = New System.Drawing.Point(157, 2)
        Me.Sex_TB.CustomButton.Name = ""
        Me.Sex_TB.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.Sex_TB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Sex_TB.CustomButton.TabIndex = 1
        Me.Sex_TB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Sex_TB.CustomButton.UseSelectable = True
        Me.Sex_TB.CustomButton.Visible = False
        Me.Sex_TB.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.Sex_TB.Lines = New String(-1) {}
        Me.Sex_TB.Location = New System.Drawing.Point(44, 233)
        Me.Sex_TB.MaxLength = 8
        Me.Sex_TB.Name = "Sex_TB"
        Me.Sex_TB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Sex_TB.ReadOnly = True
        Me.Sex_TB.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Sex_TB.SelectedText = ""
        Me.Sex_TB.SelectionLength = 0
        Me.Sex_TB.SelectionStart = 0
        Me.Sex_TB.ShortcutsEnabled = True
        Me.Sex_TB.Size = New System.Drawing.Size(195, 40)
        Me.Sex_TB.Style = MetroFramework.MetroColorStyle.Green
        Me.Sex_TB.TabIndex = 60
        Me.Sex_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Sex_TB.UseCustomBackColor = True
        Me.Sex_TB.UseSelectable = True
        Me.Sex_TB.WaterMarkColor = System.Drawing.Color.Silver
        Me.Sex_TB.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'InstructorID_Label
        '
        Me.InstructorID_Label.AutoSize = True
        Me.InstructorID_Label.Cursor = System.Windows.Forms.Cursors.Default
        Me.InstructorID_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstructorID_Label.Location = New System.Drawing.Point(40, 62)
        Me.InstructorID_Label.Name = "InstructorID_Label"
        Me.InstructorID_Label.Size = New System.Drawing.Size(102, 20)
        Me.InstructorID_Label.TabIndex = 58
        Me.InstructorID_Label.Text = "Instructor ID"
        '
        'LN_TB
        '
        Me.LN_TB.BackColor = System.Drawing.Color.Yellow
        '
        '
        '
        Me.LN_TB.CustomButton.Image = Nothing
        Me.LN_TB.CustomButton.Location = New System.Drawing.Point(157, 2)
        Me.LN_TB.CustomButton.Name = ""
        Me.LN_TB.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.LN_TB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.LN_TB.CustomButton.TabIndex = 1
        Me.LN_TB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.LN_TB.CustomButton.UseSelectable = True
        Me.LN_TB.CustomButton.Visible = False
        Me.LN_TB.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.LN_TB.Lines = New String(-1) {}
        Me.LN_TB.Location = New System.Drawing.Point(445, 157)
        Me.LN_TB.MaxLength = 8
        Me.LN_TB.Name = "LN_TB"
        Me.LN_TB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LN_TB.ReadOnly = True
        Me.LN_TB.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.LN_TB.SelectedText = ""
        Me.LN_TB.SelectionLength = 0
        Me.LN_TB.SelectionStart = 0
        Me.LN_TB.ShortcutsEnabled = True
        Me.LN_TB.Size = New System.Drawing.Size(195, 40)
        Me.LN_TB.Style = MetroFramework.MetroColorStyle.Green
        Me.LN_TB.TabIndex = 57
        Me.LN_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.LN_TB.UseCustomBackColor = True
        Me.LN_TB.UseSelectable = True
        Me.LN_TB.WaterMarkColor = System.Drawing.Color.Silver
        Me.LN_TB.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MN_Label
        '
        Me.MN_Label.AutoSize = True
        Me.MN_Label.Cursor = System.Windows.Forms.Cursors.Default
        Me.MN_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MN_Label.Location = New System.Drawing.Point(240, 138)
        Me.MN_Label.Name = "MN_Label"
        Me.MN_Label.Size = New System.Drawing.Size(107, 20)
        Me.MN_Label.TabIndex = 52
        Me.MN_Label.Text = "Middle Name"
        '
        'FN_Label
        '
        Me.FN_Label.AutoSize = True
        Me.FN_Label.Cursor = System.Windows.Forms.Cursors.Default
        Me.FN_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FN_Label.Location = New System.Drawing.Point(40, 138)
        Me.FN_Label.Name = "FN_Label"
        Me.FN_Label.Size = New System.Drawing.Size(92, 20)
        Me.FN_Label.TabIndex = 51
        Me.FN_Label.Text = "First Name"
        '
        'MN_TB
        '
        Me.MN_TB.BackColor = System.Drawing.Color.Yellow
        '
        '
        '
        Me.MN_TB.CustomButton.Image = Nothing
        Me.MN_TB.CustomButton.Location = New System.Drawing.Point(157, 2)
        Me.MN_TB.CustomButton.Name = ""
        Me.MN_TB.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.MN_TB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MN_TB.CustomButton.TabIndex = 1
        Me.MN_TB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MN_TB.CustomButton.UseSelectable = True
        Me.MN_TB.CustomButton.Visible = False
        Me.MN_TB.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.MN_TB.Lines = New String(-1) {}
        Me.MN_TB.Location = New System.Drawing.Point(244, 157)
        Me.MN_TB.MaxLength = 8
        Me.MN_TB.Name = "MN_TB"
        Me.MN_TB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MN_TB.ReadOnly = True
        Me.MN_TB.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MN_TB.SelectedText = ""
        Me.MN_TB.SelectionLength = 0
        Me.MN_TB.SelectionStart = 0
        Me.MN_TB.ShortcutsEnabled = True
        Me.MN_TB.Size = New System.Drawing.Size(195, 40)
        Me.MN_TB.Style = MetroFramework.MetroColorStyle.Green
        Me.MN_TB.TabIndex = 56
        Me.MN_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MN_TB.UseCustomBackColor = True
        Me.MN_TB.UseSelectable = True
        Me.MN_TB.WaterMarkColor = System.Drawing.Color.Silver
        Me.MN_TB.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'FN_TB
        '
        Me.FN_TB.BackColor = System.Drawing.Color.Yellow
        '
        '
        '
        Me.FN_TB.CustomButton.Image = Nothing
        Me.FN_TB.CustomButton.Location = New System.Drawing.Point(157, 2)
        Me.FN_TB.CustomButton.Name = ""
        Me.FN_TB.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.FN_TB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.FN_TB.CustomButton.TabIndex = 1
        Me.FN_TB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.FN_TB.CustomButton.UseSelectable = True
        Me.FN_TB.CustomButton.Visible = False
        Me.FN_TB.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.FN_TB.Lines = New String(-1) {}
        Me.FN_TB.Location = New System.Drawing.Point(44, 157)
        Me.FN_TB.MaxLength = 8
        Me.FN_TB.Name = "FN_TB"
        Me.FN_TB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FN_TB.ReadOnly = True
        Me.FN_TB.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.FN_TB.SelectedText = ""
        Me.FN_TB.SelectionLength = 0
        Me.FN_TB.SelectionStart = 0
        Me.FN_TB.ShortcutsEnabled = True
        Me.FN_TB.Size = New System.Drawing.Size(195, 40)
        Me.FN_TB.Style = MetroFramework.MetroColorStyle.Green
        Me.FN_TB.TabIndex = 55
        Me.FN_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.FN_TB.UseCustomBackColor = True
        Me.FN_TB.UseSelectable = True
        Me.FN_TB.WaterMarkColor = System.Drawing.Color.Silver
        Me.FN_TB.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'InstructorsID_TB
        '
        Me.InstructorsID_TB.BackColor = System.Drawing.Color.Yellow
        '
        '
        '
        Me.InstructorsID_TB.CustomButton.Image = Nothing
        Me.InstructorsID_TB.CustomButton.Location = New System.Drawing.Point(558, 2)
        Me.InstructorsID_TB.CustomButton.Name = ""
        Me.InstructorsID_TB.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.InstructorsID_TB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.InstructorsID_TB.CustomButton.TabIndex = 1
        Me.InstructorsID_TB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.InstructorsID_TB.CustomButton.UseSelectable = True
        Me.InstructorsID_TB.CustomButton.Visible = False
        Me.InstructorsID_TB.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.InstructorsID_TB.Lines = New String(-1) {}
        Me.InstructorsID_TB.Location = New System.Drawing.Point(44, 81)
        Me.InstructorsID_TB.MaxLength = 8
        Me.InstructorsID_TB.Name = "InstructorsID_TB"
        Me.InstructorsID_TB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.InstructorsID_TB.ReadOnly = True
        Me.InstructorsID_TB.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.InstructorsID_TB.SelectedText = ""
        Me.InstructorsID_TB.SelectionLength = 0
        Me.InstructorsID_TB.SelectionStart = 0
        Me.InstructorsID_TB.ShortcutsEnabled = True
        Me.InstructorsID_TB.Size = New System.Drawing.Size(596, 40)
        Me.InstructorsID_TB.Style = MetroFramework.MetroColorStyle.Green
        Me.InstructorsID_TB.TabIndex = 54
        Me.InstructorsID_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.InstructorsID_TB.UseCustomBackColor = True
        Me.InstructorsID_TB.UseSelectable = True
        Me.InstructorsID_TB.WaterMarkColor = System.Drawing.Color.Silver
        Me.InstructorsID_TB.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'CN_TB
        '
        Me.CN_TB.BackColor = System.Drawing.Color.Yellow
        '
        '
        '
        Me.CN_TB.CustomButton.Image = Nothing
        Me.CN_TB.CustomButton.Location = New System.Drawing.Point(156, 2)
        Me.CN_TB.CustomButton.Name = ""
        Me.CN_TB.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.CN_TB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.CN_TB.CustomButton.TabIndex = 1
        Me.CN_TB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.CN_TB.CustomButton.UseSelectable = True
        Me.CN_TB.CustomButton.Visible = False
        Me.CN_TB.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.CN_TB.Lines = New String(-1) {}
        Me.CN_TB.Location = New System.Drawing.Point(245, 233)
        Me.CN_TB.MaxLength = 8
        Me.CN_TB.Name = "CN_TB"
        Me.CN_TB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CN_TB.ReadOnly = True
        Me.CN_TB.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.CN_TB.SelectedText = ""
        Me.CN_TB.SelectionLength = 0
        Me.CN_TB.SelectionStart = 0
        Me.CN_TB.ShortcutsEnabled = True
        Me.CN_TB.Size = New System.Drawing.Size(194, 40)
        Me.CN_TB.Style = MetroFramework.MetroColorStyle.Green
        Me.CN_TB.TabIndex = 62
        Me.CN_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CN_TB.UseCustomBackColor = True
        Me.CN_TB.UseSelectable = True
        Me.CN_TB.WaterMarkColor = System.Drawing.Color.Silver
        Me.CN_TB.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Email_TB
        '
        Me.Email_TB.BackColor = System.Drawing.Color.Yellow
        '
        '
        '
        Me.Email_TB.CustomButton.Image = Nothing
        Me.Email_TB.CustomButton.Location = New System.Drawing.Point(558, 2)
        Me.Email_TB.CustomButton.Name = ""
        Me.Email_TB.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.Email_TB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Email_TB.CustomButton.TabIndex = 1
        Me.Email_TB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Email_TB.CustomButton.UseSelectable = True
        Me.Email_TB.CustomButton.Visible = False
        Me.Email_TB.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.Email_TB.Lines = New String(-1) {}
        Me.Email_TB.Location = New System.Drawing.Point(44, 309)
        Me.Email_TB.MaxLength = 8
        Me.Email_TB.Name = "Email_TB"
        Me.Email_TB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Email_TB.ReadOnly = True
        Me.Email_TB.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Email_TB.SelectedText = ""
        Me.Email_TB.SelectionLength = 0
        Me.Email_TB.SelectionStart = 0
        Me.Email_TB.ShortcutsEnabled = True
        Me.Email_TB.Size = New System.Drawing.Size(596, 40)
        Me.Email_TB.Style = MetroFramework.MetroColorStyle.Green
        Me.Email_TB.TabIndex = 66
        Me.Email_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Email_TB.UseCustomBackColor = True
        Me.Email_TB.UseSelectable = True
        Me.Email_TB.WaterMarkColor = System.Drawing.Color.Silver
        Me.Email_TB.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.CDMinstructors_Panel.Controls.Add(Me.Clear_Btn)
        Me.CDMinstructors_Panel.Controls.Add(Me.InstructorsDataTable)
        Me.CDMinstructors_Panel.Controls.Add(Me.ViewInstructorInfo)
        Me.CDMinstructors_Panel.Controls.Add(Me.Institute)
        Me.CDMinstructors_Panel.Controls.Add(Me.InstructorSearchBar)
        Me.CDMinstructors_Panel.Controls.Add(Me.CDMinstructors_Label)
        Me.CDMinstructors_Panel.Location = New System.Drawing.Point(4, 5)
        Me.CDMinstructors_Panel.Name = "CDMinstructors_Panel"
        Me.CDMinstructors_Panel.Size = New System.Drawing.Size(631, 509)
        Me.CDMinstructors_Panel.TabIndex = 0
        '
        'Clear_Btn
        '
        Me.Clear_Btn.BackColor = System.Drawing.Color.Yellow
        Me.Clear_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Clear_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Clear_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Clear_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Clear_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Clear_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear_Btn.ForeColor = System.Drawing.Color.Black
        Me.Clear_Btn.Location = New System.Drawing.Point(313, 409)
        Me.Clear_Btn.Name = "Clear_Btn"
        Me.Clear_Btn.Size = New System.Drawing.Size(90, 40)
        Me.Clear_Btn.TabIndex = 56
        Me.Clear_Btn.Text = "Clear"
        Me.Clear_Btn.UseVisualStyleBackColor = False
        '
        'InstructorsDataTable
        '
        Me.InstructorsDataTable.AllowUserToAddRows = False
        Me.InstructorsDataTable.AllowUserToDeleteRows = False
        Me.InstructorsDataTable.AllowUserToResizeColumns = False
        Me.InstructorsDataTable.AllowUserToResizeRows = False
        Me.InstructorsDataTable.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Bernard MT Condensed", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InstructorsDataTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle25
        Me.InstructorsDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle26.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.InstructorsDataTable.DefaultCellStyle = DataGridViewCellStyle26
        Me.InstructorsDataTable.GridColor = System.Drawing.Color.Black
        Me.InstructorsDataTable.Location = New System.Drawing.Point(45, 81)
        Me.InstructorsDataTable.Name = "InstructorsDataTable"
        Me.InstructorsDataTable.ReadOnly = True
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InstructorsDataTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle27
        Me.InstructorsDataTable.RowHeadersVisible = False
        Me.InstructorsDataTable.RowHeadersWidth = 51
        Me.InstructorsDataTable.RowTemplate.Height = 24
        Me.InstructorsDataTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.InstructorsDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.InstructorsDataTable.Size = New System.Drawing.Size(537, 268)
        Me.InstructorsDataTable.TabIndex = 2
        '
        'ViewInstructorInfo
        '
        Me.ViewInstructorInfo.BackColor = System.Drawing.Color.Yellow
        Me.ViewInstructorInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ViewInstructorInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.ViewInstructorInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.ViewInstructorInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.ViewInstructorInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewInstructorInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewInstructorInfo.ForeColor = System.Drawing.Color.Black
        Me.ViewInstructorInfo.Location = New System.Drawing.Point(409, 409)
        Me.ViewInstructorInfo.Name = "ViewInstructorInfo"
        Me.ViewInstructorInfo.Size = New System.Drawing.Size(90, 40)
        Me.ViewInstructorInfo.TabIndex = 54
        Me.ViewInstructorInfo.Text = "View"
        Me.ViewInstructorInfo.UseVisualStyleBackColor = False
        '
        'Institute
        '
        Me.Institute.AutoSize = True
        Me.Institute.Cursor = System.Windows.Forms.Cursors.Default
        Me.Institute.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Institute.Location = New System.Drawing.Point(42, 390)
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
        Me.InstructorSearchBar.Location = New System.Drawing.Point(46, 409)
        Me.InstructorSearchBar.MaxLength = 100
        Me.InstructorSearchBar.Name = "InstructorSearchBar"
        Me.InstructorSearchBar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.InstructorSearchBar.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.InstructorSearchBar.SelectedText = ""
        Me.InstructorSearchBar.SelectionLength = 0
        Me.InstructorSearchBar.SelectionStart = 0
        Me.InstructorSearchBar.ShortcutsEnabled = True
        Me.InstructorSearchBar.Size = New System.Drawing.Size(261, 40)
        Me.InstructorSearchBar.Style = MetroFramework.MetroColorStyle.Green
        Me.InstructorSearchBar.TabIndex = 37
        Me.InstructorSearchBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.InstructorSearchBar.UseSelectable = True
        Me.InstructorSearchBar.WaterMarkColor = System.Drawing.Color.Silver
        Me.InstructorSearchBar.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.Welcome_BG.Size = New System.Drawing.Size(1208, 742)
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
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Institute As Label
    Friend WithEvents ViewInstructorInfo As Button
    Friend WithEvents ChangeGradeReq_Btn As Button
    Friend WithEvents InstructorSubmittedGrade_Btn As Button
    Friend WithEvents Welcome_BG As PictureBox
    Friend WithEvents InstructorSearchBar As MetroFramework.Controls.MetroTextBox
    Friend WithEvents InstructorsDataTable As DataGridView
    Friend WithEvents Clear_Btn As Button
    Friend WithEvents AssignedCourse_Btn As Button
    Friend WithEvents LN_Label As Label
    Friend WithEvents Birthday_Label As Label
    Friend WithEvents Birthday_TB As MetroFramework.Controls.MetroTextBox
    Friend WithEvents CN_Label As Label
    Friend WithEvents Email_ As Label
    Friend WithEvents Sex_Label As Label
    Friend WithEvents Sex_TB As MetroFramework.Controls.MetroTextBox
    Friend WithEvents InstructorID_Label As Label
    Friend WithEvents LN_TB As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MN_Label As Label
    Friend WithEvents FN_Label As Label
    Friend WithEvents MN_TB As MetroFramework.Controls.MetroTextBox
    Friend WithEvents FN_TB As MetroFramework.Controls.MetroTextBox
    Friend WithEvents InstructorsID_TB As MetroFramework.Controls.MetroTextBox
    Friend WithEvents CN_TB As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Email_TB As MetroFramework.Controls.MetroTextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView2 As DataGridView
End Class
