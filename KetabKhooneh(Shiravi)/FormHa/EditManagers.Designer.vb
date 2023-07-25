<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditManagers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ButtonExit = New System.Windows.Forms.Button
        Me.ButtonSabt = New System.Windows.Forms.Button
        Me.CheckBoxEdit = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtModirID = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.LabelModirNoAccess = New System.Windows.Forms.Label
        Me.CheckBoxModirNoAccess = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtModirPass = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtModirPass2 = New System.Windows.Forms.TextBox
        Me.txtModirUserName = New System.Windows.Forms.TextBox
        Me.lbl = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonExit)
        Me.GroupBox1.Controls.Add(Me.ButtonSabt)
        Me.GroupBox1.Controls.Add(Me.CheckBoxEdit)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtModirID)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(454, 141)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "مدیر"
        '
        'ButtonExit
        '
        Me.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonExit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ButtonExit.Location = New System.Drawing.Point(6, 108)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(49, 28)
        Me.ButtonExit.TabIndex = 23
        Me.ButtonExit.Text = "خروج"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'ButtonSabt
        '
        Me.ButtonSabt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSabt.Location = New System.Drawing.Point(61, 108)
        Me.ButtonSabt.Name = "ButtonSabt"
        Me.ButtonSabt.Size = New System.Drawing.Size(50, 28)
        Me.ButtonSabt.TabIndex = 22
        Me.ButtonSabt.Text = "ثبت"
        Me.ButtonSabt.UseVisualStyleBackColor = True
        '
        'CheckBoxEdit
        '
        Me.CheckBoxEdit.AutoSize = True
        Me.CheckBoxEdit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CheckBoxEdit.Location = New System.Drawing.Point(229, 23)
        Me.CheckBoxEdit.Name = "CheckBoxEdit"
        Me.CheckBoxEdit.Size = New System.Drawing.Size(66, 17)
        Me.CheckBoxEdit.TabIndex = 21
        Me.CheckBoxEdit.Text = "ویرایش"
        Me.CheckBoxEdit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(376, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "شناسه مدیر"
        '
        'txtModirID
        '
        Me.txtModirID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtModirID.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtModirID.Location = New System.Drawing.Point(301, 22)
        Me.txtModirID.MaxLength = 7
        Me.txtModirID.Name = "txtModirID"
        Me.txtModirID.Size = New System.Drawing.Size(69, 21)
        Me.txtModirID.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LabelModirNoAccess)
        Me.Panel1.Controls.Add(Me.CheckBoxModirNoAccess)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtModirPass)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtModirPass2)
        Me.Panel1.Controls.Add(Me.txtModirUserName)
        Me.Panel1.Controls.Add(Me.lbl)
        Me.Panel1.Location = New System.Drawing.Point(6, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(442, 53)
        Me.Panel1.TabIndex = 20
        '
        'LabelModirNoAccess
        '
        Me.LabelModirNoAccess.AutoSize = True
        Me.LabelModirNoAccess.Location = New System.Drawing.Point(238, 27)
        Me.LabelModirNoAccess.Name = "LabelModirNoAccess"
        Me.LabelModirNoAccess.Size = New System.Drawing.Size(16, 16)
        Me.LabelModirNoAccess.TabIndex = 19
        Me.LabelModirNoAccess.Text = "0"
        Me.LabelModirNoAccess.Visible = False
        '
        'CheckBoxModirNoAccess
        '
        Me.CheckBoxModirNoAccess.AutoSize = True
        Me.CheckBoxModirNoAccess.Checked = True
        Me.CheckBoxModirNoAccess.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxModirNoAccess.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CheckBoxModirNoAccess.Location = New System.Drawing.Point(284, 28)
        Me.CheckBoxModirNoAccess.Name = "CheckBoxModirNoAccess"
        Me.CheckBoxModirNoAccess.Size = New System.Drawing.Size(88, 17)
        Me.CheckBoxModirNoAccess.TabIndex = 18
        Me.CheckBoxModirNoAccess.Text = "داشته باشد"
        Me.CheckBoxModirNoAccess.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(378, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "دسترسی"
        '
        'txtModirPass
        '
        Me.txtModirPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtModirPass.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtModirPass.Location = New System.Drawing.Point(3, 0)
        Me.txtModirPass.MaxLength = 20
        Me.txtModirPass.Name = "txtModirPass"
        Me.txtModirPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.txtModirPass.Size = New System.Drawing.Size(120, 21)
        Me.txtModirPass.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.Location = New System.Drawing.Point(129, 2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "گذر واژه"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.Location = New System.Drawing.Point(129, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "تکرار گذر واژه"
        '
        'txtModirPass2
        '
        Me.txtModirPass2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtModirPass2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtModirPass2.Location = New System.Drawing.Point(3, 27)
        Me.txtModirPass2.MaxLength = 20
        Me.txtModirPass2.Name = "txtModirPass2"
        Me.txtModirPass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.txtModirPass2.Size = New System.Drawing.Size(120, 21)
        Me.txtModirPass2.TabIndex = 16
        '
        'txtModirUserName
        '
        Me.txtModirUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtModirUserName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtModirUserName.Location = New System.Drawing.Point(252, 0)
        Me.txtModirUserName.MaxLength = 20
        Me.txtModirUserName.Name = "txtModirUserName"
        Me.txtModirUserName.Size = New System.Drawing.Size(120, 21)
        Me.txtModirUserName.TabIndex = 5
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl.Location = New System.Drawing.Point(378, 2)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(61, 13)
        Me.lbl.TabIndex = 2
        Me.lbl.Text = "نام کاربری"
        '
        'EditManagers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(477, 166)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "EditManagers"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ویرایش مدیر"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonExit As System.Windows.Forms.Button
    Friend WithEvents ButtonSabt As System.Windows.Forms.Button
    Friend WithEvents CheckBoxEdit As System.Windows.Forms.CheckBox
    Friend WithEvents txtModirPass As System.Windows.Forms.TextBox
    Friend WithEvents txtModirPass2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtModirID As System.Windows.Forms.TextBox
    Friend WithEvents txtModirUserName As System.Windows.Forms.TextBox
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CheckBoxModirNoAccess As System.Windows.Forms.CheckBox
    Friend WithEvents LabelModirNoAccess As System.Windows.Forms.Label
End Class
