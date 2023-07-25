<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchBook
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GrdSearchBook = New System.Windows.Forms.DataGridView
        Me.KetabID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KetabOnvan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KetabNevisande = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KetabNasher = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KetabFee = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KetabDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KetabNumChap = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KetabMojood = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.GroupName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PanelKetab = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.PanelID = New System.Windows.Forms.Panel
        Me.TextBoxID = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.PanelKetabDetails = New System.Windows.Forms.Panel
        Me.CheckBoxJadidBoodan = New System.Windows.Forms.CheckBox
        Me.TextBoxOnvan = New System.Windows.Forms.TextBox
        Me.TextBoxNevisande = New System.Windows.Forms.TextBox
        Me.TextBoxNasher = New System.Windows.Forms.TextBox
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnBarHasb = New System.Windows.Forms.Button
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GrdSearchBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.PanelKetab.SuspendLayout()
        Me.PanelID.SuspendLayout()
        Me.PanelKetabDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(862, 84)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1047, 95)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1198, 68)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(103, 6)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "شناسه کتاب را وارد کنید"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(851, 446)
        Me.Panel1.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GrdSearchBook)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(20, 208)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(812, 225)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "نتایج جستجو"
        '
        'GrdSearchBook
        '
        Me.GrdSearchBook.AllowUserToAddRows = False
        Me.GrdSearchBook.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LavenderBlush
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.GrdSearchBook.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GrdSearchBook.BackgroundColor = System.Drawing.Color.Khaki
        Me.GrdSearchBook.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LavenderBlush
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrdSearchBook.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GrdSearchBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdSearchBook.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KetabID, Me.KetabOnvan, Me.KetabNevisande, Me.KetabNasher, Me.KetabFee, Me.KetabDate, Me.KetabNumChap, Me.KetabMojood, Me.GroupName})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LavenderBlush
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GrdSearchBook.DefaultCellStyle = DataGridViewCellStyle5
        Me.GrdSearchBook.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GrdSearchBook.Location = New System.Drawing.Point(3, 23)
        Me.GrdSearchBook.Name = "GrdSearchBook"
        Me.GrdSearchBook.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LavenderBlush
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrdSearchBook.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.GrdSearchBook.RowHeadersVisible = False
        Me.GrdSearchBook.Size = New System.Drawing.Size(806, 199)
        Me.GrdSearchBook.TabIndex = 0
        '
        'KetabID
        '
        Me.KetabID.DataPropertyName = "KetabID"
        Me.KetabID.HeaderText = "شناسه"
        Me.KetabID.Name = "KetabID"
        Me.KetabID.ReadOnly = True
        Me.KetabID.Width = 70
        '
        'KetabOnvan
        '
        Me.KetabOnvan.DataPropertyName = "KetabOnvan"
        Me.KetabOnvan.HeaderText = "عنوان کتاب"
        Me.KetabOnvan.Name = "KetabOnvan"
        Me.KetabOnvan.ReadOnly = True
        Me.KetabOnvan.Width = 250
        '
        'KetabNevisande
        '
        Me.KetabNevisande.DataPropertyName = "KetabNevisande"
        Me.KetabNevisande.HeaderText = "نام کامل نویسنده"
        Me.KetabNevisande.Name = "KetabNevisande"
        Me.KetabNevisande.ReadOnly = True
        Me.KetabNevisande.Width = 200
        '
        'KetabNasher
        '
        Me.KetabNasher.DataPropertyName = "KetabNasher"
        Me.KetabNasher.HeaderText = "ناشر"
        Me.KetabNasher.Name = "KetabNasher"
        Me.KetabNasher.ReadOnly = True
        Me.KetabNasher.Width = 130
        '
        'KetabFee
        '
        Me.KetabFee.DataPropertyName = "KetabFee"
        DataGridViewCellStyle3.Format = "00,000 تومان"
        Me.KetabFee.DefaultCellStyle = DataGridViewCellStyle3
        Me.KetabFee.HeaderText = "قیمت"
        Me.KetabFee.Name = "KetabFee"
        Me.KetabFee.ReadOnly = True
        Me.KetabFee.Width = 108
        '
        'KetabDate
        '
        Me.KetabDate.DataPropertyName = "KetabDate"
        Me.KetabDate.HeaderText = "تاریخ"
        Me.KetabDate.Name = "KetabDate"
        Me.KetabDate.ReadOnly = True
        Me.KetabDate.Width = 65
        '
        'KetabNumChap
        '
        Me.KetabNumChap.DataPropertyName = "KetabNumChap"
        DataGridViewCellStyle4.Format = "00 ام"
        Me.KetabNumChap.DefaultCellStyle = DataGridViewCellStyle4
        Me.KetabNumChap.HeaderText = "چاپ"
        Me.KetabNumChap.Name = "KetabNumChap"
        Me.KetabNumChap.ReadOnly = True
        Me.KetabNumChap.Width = 50
        '
        'KetabMojood
        '
        Me.KetabMojood.DataPropertyName = "KetabMojood"
        Me.KetabMojood.FalseValue = "ناموجود"
        Me.KetabMojood.HeaderText = "موجود بودن"
        Me.KetabMojood.IndeterminateValue = "ناموجود"
        Me.KetabMojood.Name = "KetabMojood"
        Me.KetabMojood.ReadOnly = True
        Me.KetabMojood.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.KetabMojood.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.KetabMojood.TrueValue = "موجود"
        '
        'GroupName
        '
        Me.GroupName.DataPropertyName = "GroupName"
        Me.GroupName.HeaderText = "گروه"
        Me.GroupName.Name = "GroupName"
        Me.GroupName.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PanelKetab)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(20, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(812, 179)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "اطلاعات زیر را وارد کنید"
        '
        'PanelKetab
        '
        Me.PanelKetab.Controls.Add(Me.Label8)
        Me.PanelKetab.Controls.Add(Me.Label9)
        Me.PanelKetab.Controls.Add(Me.PanelID)
        Me.PanelKetab.Controls.Add(Me.Label1)
        Me.PanelKetab.Controls.Add(Me.Label7)
        Me.PanelKetab.Controls.Add(Me.PanelKetabDetails)
        Me.PanelKetab.Controls.Add(Me.btnExit)
        Me.PanelKetab.Controls.Add(Me.btnBarHasb)
        Me.PanelKetab.Controls.Add(Me.BtnSearch)
        Me.PanelKetab.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelKetab.Location = New System.Drawing.Point(3, 25)
        Me.PanelKetab.Name = "PanelKetab"
        Me.PanelKetab.Size = New System.Drawing.Size(806, 151)
        Me.PanelKetab.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(627, 20)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "عنوان کتاب"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(627, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "کتاب موجود باشد"
        '
        'PanelID
        '
        Me.PanelID.Controls.Add(Me.TextBoxID)
        Me.PanelID.Controls.Add(Me.Label6)
        Me.PanelID.Location = New System.Drawing.Point(524, 115)
        Me.PanelID.Name = "PanelID"
        Me.PanelID.Size = New System.Drawing.Size(275, 31)
        Me.PanelID.TabIndex = 6
        Me.PanelID.Visible = False
        '
        'TextBoxID
        '
        Me.TextBoxID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxID.Location = New System.Drawing.Point(39, 4)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(54, 21)
        Me.TextBoxID.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(625, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "نام یا نام خانوادگی نویسنده"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(627, 67)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "نام انتشارات"
        '
        'PanelKetabDetails
        '
        Me.PanelKetabDetails.Controls.Add(Me.CheckBoxJadidBoodan)
        Me.PanelKetabDetails.Controls.Add(Me.TextBoxOnvan)
        Me.PanelKetabDetails.Controls.Add(Me.TextBoxNevisande)
        Me.PanelKetabDetails.Controls.Add(Me.TextBoxNasher)
        Me.PanelKetabDetails.Location = New System.Drawing.Point(425, 0)
        Me.PanelKetabDetails.Name = "PanelKetabDetails"
        Me.PanelKetabDetails.Size = New System.Drawing.Size(196, 110)
        Me.PanelKetabDetails.TabIndex = 3
        '
        'CheckBoxJadidBoodan
        '
        Me.CheckBoxJadidBoodan.AutoSize = True
        Me.CheckBoxJadidBoodan.Checked = True
        Me.CheckBoxJadidBoodan.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxJadidBoodan.Location = New System.Drawing.Point(149, 89)
        Me.CheckBoxJadidBoodan.Name = "CheckBoxJadidBoodan"
        Me.CheckBoxJadidBoodan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBoxJadidBoodan.Size = New System.Drawing.Size(46, 17)
        Me.CheckBoxJadidBoodan.TabIndex = 15
        Me.CheckBoxJadidBoodan.Text = "بلی"
        Me.CheckBoxJadidBoodan.UseVisualStyleBackColor = True
        '
        'TextBoxOnvan
        '
        Me.TextBoxOnvan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxOnvan.Location = New System.Drawing.Point(3, 18)
        Me.TextBoxOnvan.Name = "TextBoxOnvan"
        Me.TextBoxOnvan.Size = New System.Drawing.Size(189, 21)
        Me.TextBoxOnvan.TabIndex = 6
        '
        'TextBoxNevisande
        '
        Me.TextBoxNevisande.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxNevisande.Location = New System.Drawing.Point(3, 41)
        Me.TextBoxNevisande.Name = "TextBoxNevisande"
        Me.TextBoxNevisande.Size = New System.Drawing.Size(189, 21)
        Me.TextBoxNevisande.TabIndex = 14
        '
        'TextBoxNasher
        '
        Me.TextBoxNasher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxNasher.Location = New System.Drawing.Point(3, 65)
        Me.TextBoxNasher.Name = "TextBoxNasher"
        Me.TextBoxNasher.Size = New System.Drawing.Size(189, 21)
        Me.TextBoxNasher.TabIndex = 13
        '
        'btnExit
        '
        Me.btnExit.FlatAppearance.BorderSize = 2
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(7, 109)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(67, 30)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "خروج"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnBarHasb
        '
        Me.btnBarHasb.FlatAppearance.BorderSize = 2
        Me.btnBarHasb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBarHasb.Location = New System.Drawing.Point(74, 109)
        Me.btnBarHasb.Name = "btnBarHasb"
        Me.btnBarHasb.Size = New System.Drawing.Size(211, 30)
        Me.btnBarHasb.TabIndex = 8
        Me.btnBarHasb.Text = "جستجو بر حسب شناسه کتاب"
        Me.btnBarHasb.UseVisualStyleBackColor = True
        '
        'BtnSearch
        '
        Me.BtnSearch.FlatAppearance.BorderSize = 2
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Location = New System.Drawing.Point(284, 109)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(107, 30)
        Me.BtnSearch.TabIndex = 7
        Me.BtnSearch.Text = "جستجوی کتاب"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'SearchBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(851, 446)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "SearchBook"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "جستجو کتاب"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GrdSearchBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.PanelKetab.ResumeLayout(False)
        Me.PanelKetab.PerformLayout()
        Me.PanelID.ResumeLayout(False)
        Me.PanelID.PerformLayout()
        Me.PanelKetabDetails.ResumeLayout(False)
        Me.PanelKetabDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PanelID As System.Windows.Forms.Panel
    Friend WithEvents TextBoxID As System.Windows.Forms.TextBox
    Friend WithEvents PanelKetab As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnBarHasb As System.Windows.Forms.Button
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents TextBoxOnvan As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxJadidBoodan As System.Windows.Forms.CheckBox
    Friend WithEvents TextBoxNevisande As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNasher As System.Windows.Forms.TextBox
    Friend WithEvents PanelKetabDetails As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GrdSearchBook As System.Windows.Forms.DataGridView
    Friend WithEvents KetabID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KetabOnvan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KetabNevisande As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KetabNasher As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KetabFee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KetabDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KetabNumChap As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KetabMojood As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents GroupName As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
