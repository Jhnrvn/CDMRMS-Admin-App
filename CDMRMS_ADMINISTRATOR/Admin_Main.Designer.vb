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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_Main))
        Me.GreenSide_Panel = New System.Windows.Forms.Panel()
        Me.Dropdown_Panel = New System.Windows.Forms.Panel()
        Me.Student_Btn = New System.Windows.Forms.Button()
        Me.Instructor_Btn = New System.Windows.Forms.Button()
        Me.Dashboard_Btn = New System.Windows.Forms.Button()
        Me.Menu_Btn = New System.Windows.Forms.Button()
        Me.CMDRMS_PicBox = New System.Windows.Forms.PictureBox()
        Me.CDM_Logo = New System.Windows.Forms.PictureBox()
        Me.GreenUpper_Panel = New System.Windows.Forms.Panel()
        Me.MyProfile_Panel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CourseReq_Panel = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Institute = New System.Windows.Forms.Label()
        Me.Course_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Sem_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Year_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Program_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Institute_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Send_Btn = New System.Windows.Forms.Button()
        Me.Choose_Btn = New System.Windows.Forms.Button()
        Me.CourseReq_Label = New System.Windows.Forms.Label()
        Me.Profile_Panel = New System.Windows.Forms.Panel()
        Me.Save_Btn = New System.Windows.Forms.Button()
        Me.Profile_Label = New System.Windows.Forms.Label()
        Me.GreenSide_Panel.SuspendLayout()
        Me.Dropdown_Panel.SuspendLayout()
        CType(Me.CMDRMS_PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CDM_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MyProfile_Panel.SuspendLayout()
        Me.CourseReq_Panel.SuspendLayout()
        Me.Profile_Panel.SuspendLayout()
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
        'MyProfile_Panel
        '
        Me.MyProfile_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.MyProfile_Panel.Controls.Add(Me.Panel1)
        Me.MyProfile_Panel.Controls.Add(Me.CourseReq_Panel)
        Me.MyProfile_Panel.Controls.Add(Me.Profile_Panel)
        Me.MyProfile_Panel.Location = New System.Drawing.Point(218, 91)
        Me.MyProfile_Panel.Name = "MyProfile_Panel"
        Me.MyProfile_Panel.Size = New System.Drawing.Size(1334, 784)
        Me.MyProfile_Panel.TabIndex = 4
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
        Me.CourseReq_Panel.Controls.Add(Me.Label4)
        Me.CourseReq_Panel.Controls.Add(Me.Label3)
        Me.CourseReq_Panel.Controls.Add(Me.Label2)
        Me.CourseReq_Panel.Controls.Add(Me.Label1)
        Me.CourseReq_Panel.Controls.Add(Me.Institute)
        Me.CourseReq_Panel.Controls.Add(Me.Course_Tbox)
        Me.CourseReq_Panel.Controls.Add(Me.Sem_Tbox)
        Me.CourseReq_Panel.Controls.Add(Me.Year_Tbox)
        Me.CourseReq_Panel.Controls.Add(Me.Program_Tbox)
        Me.CourseReq_Panel.Controls.Add(Me.Institute_Tbox)
        Me.CourseReq_Panel.Controls.Add(Me.Send_Btn)
        Me.CourseReq_Panel.Controls.Add(Me.Choose_Btn)
        Me.CourseReq_Panel.Controls.Add(Me.CourseReq_Label)
        Me.CourseReq_Panel.Location = New System.Drawing.Point(912, 5)
        Me.CourseReq_Panel.Name = "CourseReq_Panel"
        Me.CourseReq_Panel.Size = New System.Drawing.Size(414, 509)
        Me.CourseReq_Panel.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 355)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 20)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Course"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 282)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Semester"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Year Level"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 20)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "College Program"
        '
        'Institute
        '
        Me.Institute.AutoSize = True
        Me.Institute.Cursor = System.Windows.Forms.Cursors.Default
        Me.Institute.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Institute.Location = New System.Drawing.Point(20, 64)
        Me.Institute.Name = "Institute"
        Me.Institute.Size = New System.Drawing.Size(68, 20)
        Me.Institute.TabIndex = 52
        Me.Institute.Text = "Institute"
        '
        'Course_Tbox
        '
        '
        '
        '
        Me.Course_Tbox.CustomButton.Image = Nothing
        Me.Course_Tbox.CustomButton.Location = New System.Drawing.Point(323, 2)
        Me.Course_Tbox.CustomButton.Name = ""
        Me.Course_Tbox.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.Course_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Course_Tbox.CustomButton.TabIndex = 1
        Me.Course_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Course_Tbox.CustomButton.UseSelectable = True
        Me.Course_Tbox.CustomButton.Visible = False
        Me.Course_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.Course_Tbox.Lines = New String(-1) {}
        Me.Course_Tbox.Location = New System.Drawing.Point(24, 374)
        Me.Course_Tbox.MaxLength = 50
        Me.Course_Tbox.Name = "Course_Tbox"
        Me.Course_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Course_Tbox.ReadOnly = True
        Me.Course_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Course_Tbox.SelectedText = ""
        Me.Course_Tbox.SelectionLength = 0
        Me.Course_Tbox.SelectionStart = 0
        Me.Course_Tbox.ShortcutsEnabled = True
        Me.Course_Tbox.Size = New System.Drawing.Size(361, 40)
        Me.Course_Tbox.Style = MetroFramework.MetroColorStyle.Green
        Me.Course_Tbox.TabIndex = 57
        Me.Course_Tbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Course_Tbox.UseSelectable = True
        Me.Course_Tbox.WaterMarkColor = System.Drawing.Color.Silver
        Me.Course_Tbox.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Sem_Tbox
        '
        '
        '
        '
        Me.Sem_Tbox.CustomButton.Image = Nothing
        Me.Sem_Tbox.CustomButton.Location = New System.Drawing.Point(323, 2)
        Me.Sem_Tbox.CustomButton.Name = ""
        Me.Sem_Tbox.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.Sem_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Sem_Tbox.CustomButton.TabIndex = 1
        Me.Sem_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Sem_Tbox.CustomButton.UseSelectable = True
        Me.Sem_Tbox.CustomButton.Visible = False
        Me.Sem_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.Sem_Tbox.Lines = New String(-1) {}
        Me.Sem_Tbox.Location = New System.Drawing.Point(24, 301)
        Me.Sem_Tbox.MaxLength = 50
        Me.Sem_Tbox.Name = "Sem_Tbox"
        Me.Sem_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Sem_Tbox.ReadOnly = True
        Me.Sem_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Sem_Tbox.SelectedText = ""
        Me.Sem_Tbox.SelectionLength = 0
        Me.Sem_Tbox.SelectionStart = 0
        Me.Sem_Tbox.ShortcutsEnabled = True
        Me.Sem_Tbox.Size = New System.Drawing.Size(361, 40)
        Me.Sem_Tbox.Style = MetroFramework.MetroColorStyle.Green
        Me.Sem_Tbox.TabIndex = 56
        Me.Sem_Tbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Sem_Tbox.UseSelectable = True
        Me.Sem_Tbox.WaterMarkColor = System.Drawing.Color.Silver
        Me.Sem_Tbox.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Year_Tbox
        '
        '
        '
        '
        Me.Year_Tbox.CustomButton.Image = Nothing
        Me.Year_Tbox.CustomButton.Location = New System.Drawing.Point(323, 2)
        Me.Year_Tbox.CustomButton.Name = ""
        Me.Year_Tbox.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.Year_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Year_Tbox.CustomButton.TabIndex = 1
        Me.Year_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Year_Tbox.CustomButton.UseSelectable = True
        Me.Year_Tbox.CustomButton.Visible = False
        Me.Year_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.Year_Tbox.Lines = New String(-1) {}
        Me.Year_Tbox.Location = New System.Drawing.Point(24, 228)
        Me.Year_Tbox.MaxLength = 50
        Me.Year_Tbox.Name = "Year_Tbox"
        Me.Year_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Year_Tbox.ReadOnly = True
        Me.Year_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Year_Tbox.SelectedText = ""
        Me.Year_Tbox.SelectionLength = 0
        Me.Year_Tbox.SelectionStart = 0
        Me.Year_Tbox.ShortcutsEnabled = True
        Me.Year_Tbox.Size = New System.Drawing.Size(361, 40)
        Me.Year_Tbox.Style = MetroFramework.MetroColorStyle.Green
        Me.Year_Tbox.TabIndex = 55
        Me.Year_Tbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Year_Tbox.UseSelectable = True
        Me.Year_Tbox.WaterMarkColor = System.Drawing.Color.Silver
        Me.Year_Tbox.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Program_Tbox
        '
        '
        '
        '
        Me.Program_Tbox.CustomButton.Image = Nothing
        Me.Program_Tbox.CustomButton.Location = New System.Drawing.Point(323, 2)
        Me.Program_Tbox.CustomButton.Name = ""
        Me.Program_Tbox.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.Program_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Program_Tbox.CustomButton.TabIndex = 1
        Me.Program_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Program_Tbox.CustomButton.UseSelectable = True
        Me.Program_Tbox.CustomButton.Visible = False
        Me.Program_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.Program_Tbox.Lines = New String(-1) {}
        Me.Program_Tbox.Location = New System.Drawing.Point(24, 155)
        Me.Program_Tbox.MaxLength = 50
        Me.Program_Tbox.Name = "Program_Tbox"
        Me.Program_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Program_Tbox.ReadOnly = True
        Me.Program_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Program_Tbox.SelectedText = ""
        Me.Program_Tbox.SelectionLength = 0
        Me.Program_Tbox.SelectionStart = 0
        Me.Program_Tbox.ShortcutsEnabled = True
        Me.Program_Tbox.Size = New System.Drawing.Size(361, 40)
        Me.Program_Tbox.Style = MetroFramework.MetroColorStyle.Green
        Me.Program_Tbox.TabIndex = 54
        Me.Program_Tbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Program_Tbox.UseSelectable = True
        Me.Program_Tbox.WaterMarkColor = System.Drawing.Color.Silver
        Me.Program_Tbox.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Institute_Tbox
        '
        '
        '
        '
        Me.Institute_Tbox.CustomButton.Image = Nothing
        Me.Institute_Tbox.CustomButton.Location = New System.Drawing.Point(323, 2)
        Me.Institute_Tbox.CustomButton.Name = ""
        Me.Institute_Tbox.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.Institute_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Institute_Tbox.CustomButton.TabIndex = 1
        Me.Institute_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Institute_Tbox.CustomButton.UseSelectable = True
        Me.Institute_Tbox.CustomButton.Visible = False
        Me.Institute_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.Institute_Tbox.Lines = New String(-1) {}
        Me.Institute_Tbox.Location = New System.Drawing.Point(24, 83)
        Me.Institute_Tbox.MaxLength = 50
        Me.Institute_Tbox.Name = "Institute_Tbox"
        Me.Institute_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Institute_Tbox.ReadOnly = True
        Me.Institute_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Institute_Tbox.SelectedText = ""
        Me.Institute_Tbox.SelectionLength = 0
        Me.Institute_Tbox.SelectionStart = 0
        Me.Institute_Tbox.ShortcutsEnabled = True
        Me.Institute_Tbox.Size = New System.Drawing.Size(361, 40)
        Me.Institute_Tbox.Style = MetroFramework.MetroColorStyle.Green
        Me.Institute_Tbox.TabIndex = 52
        Me.Institute_Tbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Institute_Tbox.UseSelectable = True
        Me.Institute_Tbox.WaterMarkColor = System.Drawing.Color.Silver
        Me.Institute_Tbox.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.Profile_Panel.Controls.Add(Me.Save_Btn)
        Me.Profile_Panel.Controls.Add(Me.Profile_Label)
        Me.Profile_Panel.Location = New System.Drawing.Point(4, 5)
        Me.Profile_Panel.Name = "Profile_Panel"
        Me.Profile_Panel.Size = New System.Drawing.Size(902, 509)
        Me.Profile_Panel.TabIndex = 0
        '
        'Save_Btn
        '
        Me.Save_Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Save_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Save_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Save_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Save_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Save_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Save_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save_Btn.ForeColor = System.Drawing.Color.Black
        Me.Save_Btn.Location = New System.Drawing.Point(725, 435)
        Me.Save_Btn.Name = "Save_Btn"
        Me.Save_Btn.Size = New System.Drawing.Size(147, 40)
        Me.Save_Btn.TabIndex = 51
        Me.Save_Btn.Text = "Save Changes"
        Me.Save_Btn.UseVisualStyleBackColor = False
        '
        'Profile_Label
        '
        Me.Profile_Label.AutoSize = True
        Me.Profile_Label.Font = New System.Drawing.Font("Bernard MT Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Profile_Label.Location = New System.Drawing.Point(9, 9)
        Me.Profile_Label.Name = "Profile_Label"
        Me.Profile_Label.Size = New System.Drawing.Size(102, 40)
        Me.Profile_Label.TabIndex = 0
        Me.Profile_Label.Text = "Profile"
        '
        'Admin_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1550, 870)
        Me.Controls.Add(Me.MyProfile_Panel)
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
        Me.MyProfile_Panel.ResumeLayout(False)
        Me.CourseReq_Panel.ResumeLayout(False)
        Me.CourseReq_Panel.PerformLayout()
        Me.Profile_Panel.ResumeLayout(False)
        Me.Profile_Panel.PerformLayout()
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
    Friend WithEvents MyProfile_Panel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CourseReq_Panel As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Institute As Label
    Friend WithEvents Course_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Sem_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Year_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Program_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Institute_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Send_Btn As Button
    Friend WithEvents Choose_Btn As Button
    Friend WithEvents CourseReq_Label As Label
    Friend WithEvents Profile_Panel As Panel
    Friend WithEvents Save_Btn As Button
    Friend WithEvents Profile_Label As Label
End Class
