<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditBooks
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
        Me.txtKetabID = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtKetabNevisande = New System.Windows.Forms.TextBox
        Me.ComboBoxGroupID = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtKetabNasher = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.lbl = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtKetabNumChap = New System.Windows.Forms.NumericUpDown
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtKetabDate = New System.Windows.Forms.TextBox
        Me.txtKetabFee = New System.Windows.Forms.TextBox
        Me.CheckBoxketabMojood = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtKetabOnvan = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.txtKetabNumChap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonExit)
        Me.GroupBox1.Controls.Add(Me.ButtonSabt)
        Me.GroupBox1.Controls.Add(Me.CheckBoxEdit)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtKetabID)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(470, 309)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "کتاب"
        '
        'ButtonExit
        '
        Me.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonExit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ButtonExit.Location = New System.Drawing.Point(12, 273)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(49, 28)
        Me.ButtonExit.TabIndex = 23
        Me.ButtonExit.Text = "خروج"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'ButtonSabt
        '
        Me.ButtonSabt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSabt.Location = New System.Drawing.Point(67, 273)
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
        Me.CheckBoxEdit.Location = New System.Drawing.Point(230, 23)
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
        Me.Label1.Location = New System.Drawing.Point(377, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "شناسه کتاب"
        '
        'txtKetabID
        '
        Me.txtKetabID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKetabID.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtKetabID.Location = New System.Drawing.Point(302, 22)
        Me.txtKetabID.MaxLength = 7
        Me.txtKetabID.Name = "txtKetabID"
        Me.txtKetabID.Size = New System.Drawing.Size(69, 21)
        Me.txtKetabID.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtKetabNevisande)
        Me.Panel1.Controls.Add(Me.ComboBoxGroupID)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtKetabNasher)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lbl)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtKetabNumChap)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtKetabDate)
        Me.Panel1.Controls.Add(Me.txtKetabFee)
        Me.Panel1.Controls.Add(Me.CheckBoxketabMojood)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtKetabOnvan)
        Me.Panel1.Location = New System.Drawing.Point(12, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(447, 218)
        Me.Panel1.TabIndex = 20
        '
        'txtKetabNevisande
        '
        Me.txtKetabNevisande.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKetabNevisande.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtKetabNevisande.Location = New System.Drawing.Point(140, 161)
        Me.txtKetabNevisande.MaxLength = 100
        Me.txtKetabNevisande.Name = "txtKetabNevisande"
        Me.txtKetabNevisande.Size = New System.Drawing.Size(219, 21)
        Me.txtKetabNevisande.TabIndex = 28
        '
        'ComboBoxGroupID
        '
        Me.ComboBoxGroupID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxGroupID.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ComboBoxGroupID.FormattingEnabled = True
        Me.ComboBoxGroupID.Location = New System.Drawing.Point(218, 134)
        Me.ComboBoxGroupID.Name = "ComboBoxGroupID"
        Me.ComboBoxGroupID.Size = New System.Drawing.Size(141, 21)
        Me.ComboBoxGroupID.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.Location = New System.Drawing.Point(365, 190)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "ناشر" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtKetabNasher
        '
        Me.txtKetabNasher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKetabNasher.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtKetabNasher.Location = New System.Drawing.Point(140, 188)
        Me.txtKetabNasher.MaxLength = 100
        Me.txtKetabNasher.Name = "txtKetabNasher"
        Me.txtKetabNasher.Size = New System.Drawing.Size(219, 21)
        Me.txtKetabNasher.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.Location = New System.Drawing.Point(365, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "قیمت کتاب"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl.Location = New System.Drawing.Point(365, 5)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(64, 13)
        Me.lbl.TabIndex = 2
        Me.lbl.Text = "عنوان کتاب"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.Location = New System.Drawing.Point(365, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "تاریخ چاپ"
        '
        'txtKetabNumChap
        '
        Me.txtKetabNumChap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKetabNumChap.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtKetabNumChap.Location = New System.Drawing.Point(290, 107)
        Me.txtKetabNumChap.Name = "txtKetabNumChap"
        Me.txtKetabNumChap.Size = New System.Drawing.Size(69, 21)
        Me.txtKetabNumChap.TabIndex = 23
        Me.txtKetabNumChap.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(365, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "موجودیت کتاب"
        '
        'txtKetabDate
        '
        Me.txtKetabDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKetabDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtKetabDate.Location = New System.Drawing.Point(290, 57)
        Me.txtKetabDate.MaxLength = 4
        Me.txtKetabDate.Name = "txtKetabDate"
        Me.txtKetabDate.Size = New System.Drawing.Size(69, 21)
        Me.txtKetabDate.TabIndex = 16
        '
        'txtKetabFee
        '
        Me.txtKetabFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKetabFee.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtKetabFee.Location = New System.Drawing.Point(290, 30)
        Me.txtKetabFee.MaxLength = 10
        Me.txtKetabFee.Name = "txtKetabFee"
        Me.txtKetabFee.Size = New System.Drawing.Size(69, 21)
        Me.txtKetabFee.TabIndex = 17
        '
        'CheckBoxketabMojood
        '
        Me.CheckBoxketabMojood.AutoSize = True
        Me.CheckBoxketabMojood.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CheckBoxketabMojood.Location = New System.Drawing.Point(300, 84)
        Me.CheckBoxketabMojood.Name = "CheckBoxketabMojood"
        Me.CheckBoxketabMojood.Size = New System.Drawing.Size(59, 17)
        Me.CheckBoxketabMojood.TabIndex = 22
        Me.CheckBoxketabMojood.Text = "موجود"
        Me.CheckBoxketabMojood.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(365, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "شماره چاپ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(365, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "گروه"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(365, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "نویسندگان"
        '
        'txtKetabOnvan
        '
        Me.txtKetabOnvan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKetabOnvan.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtKetabOnvan.Location = New System.Drawing.Point(3, 3)
        Me.txtKetabOnvan.MaxLength = 100
        Me.txtKetabOnvan.Name = "txtKetabOnvan"
        Me.txtKetabOnvan.Size = New System.Drawing.Size(356, 21)
        Me.txtKetabOnvan.TabIndex = 5
        '
        'EditBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(470, 316)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "EditBooks"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ثبت کتاب"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txtKetabNumChap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonExit As System.Windows.Forms.Button
    Friend WithEvents ButtonSabt As System.Windows.Forms.Button
    Friend WithEvents CheckBoxEdit As System.Windows.Forms.CheckBox
    Friend WithEvents txtKetabFee As System.Windows.Forms.TextBox
    Friend WithEvents txtKetabDate As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtKetabID As System.Windows.Forms.TextBox
    Friend WithEvents txtKetabOnvan As System.Windows.Forms.TextBox
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CheckBoxketabMojood As System.Windows.Forms.CheckBox
    Friend WithEvents txtKetabNumChap As System.Windows.Forms.NumericUpDown
    Friend WithEvents ComboBoxGroupID As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtKetabNasher As System.Windows.Forms.TextBox
    Friend WithEvents txtKetabNevisande As System.Windows.Forms.TextBox
End Class
