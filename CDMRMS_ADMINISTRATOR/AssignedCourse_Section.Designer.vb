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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BG_Panel1 = New System.Windows.Forms.Panel()
        Me.Close_Btn = New System.Windows.Forms.Button()
        Me.AssignedCourse_Label = New System.Windows.Forms.Label()
        Me.BG_Panel2 = New System.Windows.Forms.Panel()
        Me.AssignedCourseTable = New System.Windows.Forms.DataGridView()
        Me.Edit_Btn = New System.Windows.Forms.Button()
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
        Me.BG_Panel1.Size = New System.Drawing.Size(803, 459)
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
        Me.Close_Btn.Location = New System.Drawing.Point(743, 17)
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
        Me.BG_Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.BG_Panel2.Controls.Add(Me.AssignedCourseTable)
        Me.BG_Panel2.Controls.Add(Me.Edit_Btn)
        Me.BG_Panel2.Controls.Add(Me.Save_Btn)
        Me.BG_Panel2.Location = New System.Drawing.Point(14, 63)
        Me.BG_Panel2.Name = "BG_Panel2"
        Me.BG_Panel2.Size = New System.Drawing.Size(771, 373)
        Me.BG_Panel2.TabIndex = 2
        '
        'AssignedCourseTable
        '
        Me.AssignedCourseTable.AllowUserToResizeColumns = False
        Me.AssignedCourseTable.AllowUserToResizeRows = False
        Me.AssignedCourseTable.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Bernard MT Condensed", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AssignedCourseTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.AssignedCourseTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AssignedCourseTable.DefaultCellStyle = DataGridViewCellStyle2
        Me.AssignedCourseTable.GridColor = System.Drawing.Color.Black
        Me.AssignedCourseTable.Location = New System.Drawing.Point(23, 16)
        Me.AssignedCourseTable.Name = "AssignedCourseTable"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AssignedCourseTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.AssignedCourseTable.RowHeadersVisible = False
        Me.AssignedCourseTable.RowHeadersWidth = 51
        Me.AssignedCourseTable.RowTemplate.Height = 24
        Me.AssignedCourseTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AssignedCourseTable.Size = New System.Drawing.Size(727, 268)
        Me.AssignedCourseTable.TabIndex = 59
        '
        'Edit_Btn
        '
        Me.Edit_Btn.BackColor = System.Drawing.Color.Red
        Me.Edit_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Edit_Btn.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Edit_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Edit_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Edit_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Edit_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edit_Btn.ForeColor = System.Drawing.Color.White
        Me.Edit_Btn.Location = New System.Drawing.Point(530, 312)
        Me.Edit_Btn.Name = "Edit_Btn"
        Me.Edit_Btn.Size = New System.Drawing.Size(107, 40)
        Me.Edit_Btn.TabIndex = 58
        Me.Edit_Btn.Text = "Edit"
        Me.Edit_Btn.UseVisualStyleBackColor = False
        '
        'Save_Btn
        '
        Me.Save_Btn.BackColor = System.Drawing.Color.Yellow
        Me.Save_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Save_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Save_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Save_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Save_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Save_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save_Btn.ForeColor = System.Drawing.Color.Black
        Me.Save_Btn.Location = New System.Drawing.Point(643, 312)
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
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
        CType(Me.AssignedCourseTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BG_Panel1 As Panel
    Friend WithEvents Close_Btn As Button
    Friend WithEvents AssignedCourse_Label As Label
    Friend WithEvents BG_Panel2 As Panel
    Friend WithEvents Edit_Btn As Button
    Friend WithEvents Save_Btn As Button
    Friend WithEvents AssignedCourseTable As DataGridView
End Class
