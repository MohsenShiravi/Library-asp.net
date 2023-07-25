<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrustDetails
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PanelDate = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.ComboBox6 = New System.Windows.Forms.ComboBox
        Me.ComboBox5 = New System.Windows.Forms.ComboBox
        Me.ComboBox4 = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.PanelMoshtari = New System.Windows.Forms.Panel
        Me.txtUsID = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.PanelFactorID = New System.Windows.Forms.Panel
        Me.txtFromTrID = New System.Windows.Forms.TextBox
        Me.txtToTrID = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.RadioButtonUsID = New System.Windows.Forms.RadioButton
        Me.RadioButtonDate = New System.Windows.Forms.RadioButton
        Me.RadioButtonTrID = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.grdGozaresh = New System.Windows.Forms.DataGridView
        Me.FactorID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UsID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UsFamily = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KetabID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KetabOnvan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TrDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TrReturnDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UsNumber = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        Me.PanelDate.SuspendLayout()
        Me.PanelMoshtari.SuspendLayout()
        Me.PanelFactorID.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grdGozaresh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PanelDate)
        Me.GroupBox1.Controls.Add(Me.PanelMoshtari)
        Me.GroupBox1.Controls.Add(Me.PanelFactorID)
        Me.GroupBox1.Controls.Add(Me.RadioButtonUsID)
        Me.GroupBox1.Controls.Add(Me.RadioButtonDate)
        Me.GroupBox1.Controls.Add(Me.RadioButtonTrID)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(594, 254)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "اطلاعات زیر را وارد کنید :"
        '
        'PanelDate
        '
        Me.PanelDate.Controls.Add(Me.Label7)
        Me.PanelDate.Controls.Add(Me.Label5)
        Me.PanelDate.Controls.Add(Me.ComboBox6)
        Me.PanelDate.Controls.Add(Me.ComboBox5)
        Me.PanelDate.Controls.Add(Me.ComboBox4)
        Me.PanelDate.Controls.Add(Me.Label9)
        Me.PanelDate.Controls.Add(Me.Label8)
        Me.PanelDate.Controls.Add(Me.ComboBox3)
        Me.PanelDate.Controls.Add(Me.ComboBox2)
        Me.PanelDate.Controls.Add(Me.ComboBox1)
        Me.PanelDate.Controls.Add(Me.Label4)
        Me.PanelDate.Controls.Add(Me.Label3)
        Me.PanelDate.Location = New System.Drawing.Point(331, 132)
        Me.PanelDate.Name = "PanelDate"
        Me.PanelDate.Size = New System.Drawing.Size(251, 58)
        Me.PanelDate.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.Location = New System.Drawing.Point(64, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "/"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(131, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "/"
        '
        'ComboBox6
        '
        Me.ComboBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Items.AddRange(New Object() {"88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99"})
        Me.ComboBox6.Location = New System.Drawing.Point(3, 31)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(55, 22)
        Me.ComboBox6.TabIndex = 12
        '
        'ComboBox5
        '
        Me.ComboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.ComboBox5.Location = New System.Drawing.Point(85, 31)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(40, 22)
        Me.ComboBox5.TabIndex = 11
        '
        'ComboBox4
        '
        Me.ComboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.ComboBox4.Location = New System.Drawing.Point(152, 31)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(40, 22)
        Me.ComboBox4.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.Location = New System.Drawing.Point(131, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "/"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.Location = New System.Drawing.Point(64, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "/"
        '
        'ComboBox3
        '
        Me.ComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99"})
        Me.ComboBox3.Location = New System.Drawing.Point(3, 3)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(55, 22)
        Me.ComboBox3.TabIndex = 4
        '
        'ComboBox2
        '
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.ComboBox2.Location = New System.Drawing.Point(85, 3)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(40, 22)
        Me.ComboBox2.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.ComboBox1.Location = New System.Drawing.Point(152, 3)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(40, 22)
        Me.ComboBox1.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(198, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "تا تاریخ :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(198, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "از تاریخ :"
        '
        'PanelMoshtari
        '
        Me.PanelMoshtari.Controls.Add(Me.txtUsID)
        Me.PanelMoshtari.Controls.Add(Me.Label6)
        Me.PanelMoshtari.Location = New System.Drawing.Point(395, 219)
        Me.PanelMoshtari.Name = "PanelMoshtari"
        Me.PanelMoshtari.Size = New System.Drawing.Size(187, 28)
        Me.PanelMoshtari.TabIndex = 11
        '
        'txtUsID
        '
        Me.txtUsID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsID.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsID.Location = New System.Drawing.Point(3, 3)
        Me.txtUsID.Name = "txtUsID"
        Me.txtUsID.Size = New System.Drawing.Size(94, 22)
        Me.txtUsID.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(103, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "شناسه کاربر :"
        '
        'PanelFactorID
        '
        Me.PanelFactorID.Controls.Add(Me.txtFromTrID)
        Me.PanelFactorID.Controls.Add(Me.txtToTrID)
        Me.PanelFactorID.Controls.Add(Me.Label2)
        Me.PanelFactorID.Controls.Add(Me.Label1)
        Me.PanelFactorID.Location = New System.Drawing.Point(393, 51)
        Me.PanelFactorID.Name = "PanelFactorID"
        Me.PanelFactorID.Size = New System.Drawing.Size(189, 52)
        Me.PanelFactorID.TabIndex = 10
        '
        'txtFromTrID
        '
        Me.txtFromTrID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFromTrID.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFromTrID.Location = New System.Drawing.Point(18, 3)
        Me.txtFromTrID.Name = "txtFromTrID"
        Me.txtFromTrID.Size = New System.Drawing.Size(81, 22)
        Me.txtFromTrID.TabIndex = 8
        '
        'txtToTrID
        '
        Me.txtToTrID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtToTrID.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtToTrID.Location = New System.Drawing.Point(18, 27)
        Me.txtToTrID.Name = "txtToTrID"
        Me.txtToTrID.Size = New System.Drawing.Size(81, 22)
        Me.txtToTrID.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(105, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "تا شماره ثبت :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(105, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "از شماره ثبت :"
        '
        'RadioButtonUsID
        '
        Me.RadioButtonUsID.AutoSize = True
        Me.RadioButtonUsID.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonUsID.Location = New System.Drawing.Point(470, 196)
        Me.RadioButtonUsID.Name = "RadioButtonUsID"
        Me.RadioButtonUsID.Size = New System.Drawing.Size(112, 17)
        Me.RadioButtonUsID.TabIndex = 9
        Me.RadioButtonUsID.Text = "براساس شناسه"
        Me.RadioButtonUsID.UseVisualStyleBackColor = True
        '
        'RadioButtonDate
        '
        Me.RadioButtonDate.AutoSize = True
        Me.RadioButtonDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonDate.Location = New System.Drawing.Point(465, 109)
        Me.RadioButtonDate.Name = "RadioButtonDate"
        Me.RadioButtonDate.Size = New System.Drawing.Size(117, 17)
        Me.RadioButtonDate.TabIndex = 8
        Me.RadioButtonDate.Text = "براساس تاریــــــخ"
        Me.RadioButtonDate.UseVisualStyleBackColor = True
        '
        'RadioButtonTrID
        '
        Me.RadioButtonTrID.AutoSize = True
        Me.RadioButtonTrID.Checked = True
        Me.RadioButtonTrID.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonTrID.Location = New System.Drawing.Point(475, 28)
        Me.RadioButtonTrID.Name = "RadioButtonTrID"
        Me.RadioButtonTrID.Size = New System.Drawing.Size(107, 17)
        Me.RadioButtonTrID.TabIndex = 7
        Me.RadioButtonTrID.TabStop = True
        Me.RadioButtonTrID.Text = "براساس شماره" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RadioButtonTrID.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.grdGozaresh)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 260)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(594, 212)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "نتایج :"
        '
        'grdGozaresh
        '
        Me.grdGozaresh.AllowUserToAddRows = False
        Me.grdGozaresh.AllowUserToDeleteRows = False
        Me.grdGozaresh.BackgroundColor = System.Drawing.Color.White
        Me.grdGozaresh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdGozaresh.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FactorID, Me.UsID, Me.UsFamily, Me.KetabID, Me.KetabOnvan, Me.TrDate, Me.TrReturnDate, Me.UsNumber})
        Me.grdGozaresh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdGozaresh.Location = New System.Drawing.Point(3, 17)
        Me.grdGozaresh.Name = "grdGozaresh"
        Me.grdGozaresh.ReadOnly = True
        Me.grdGozaresh.RowHeadersVisible = False
        Me.grdGozaresh.Size = New System.Drawing.Size(588, 192)
        Me.grdGozaresh.TabIndex = 0
        '
        'FactorID
        '
        Me.FactorID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.FactorID.DataPropertyName = "TrID"
        Me.FactorID.HeaderText = "شناسه"
        Me.FactorID.Name = "FactorID"
        Me.FactorID.ReadOnly = True
        '
        'UsID
        '
        Me.UsID.DataPropertyName = "UsID"
        Me.UsID.HeaderText = "شناسه کاربر"
        Me.UsID.Name = "UsID"
        Me.UsID.ReadOnly = True
        '
        'UsFamily
        '
        Me.UsFamily.DataPropertyName = "UsFamily"
        Me.UsFamily.HeaderText = "نام خانوادگی"
        Me.UsFamily.Name = "UsFamily"
        Me.UsFamily.ReadOnly = True
        '
        'KetabID
        '
        Me.KetabID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.KetabID.DataPropertyName = "KetabID"
        Me.KetabID.HeaderText = "شناسه کتاب"
        Me.KetabID.MinimumWidth = 100
        Me.KetabID.Name = "KetabID"
        Me.KetabID.ReadOnly = True
        '
        'KetabOnvan
        '
        Me.KetabOnvan.DataPropertyName = "KetabOnvan"
        Me.KetabOnvan.HeaderText = "عنوان کتاب"
        Me.KetabOnvan.Name = "KetabOnvan"
        Me.KetabOnvan.ReadOnly = True
        '
        'TrDate
        '
        Me.TrDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.TrDate.DataPropertyName = "TrDate"
        DataGridViewCellStyle3.Format = "0000/00/00 - 00:00:00"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.TrDate.DefaultCellStyle = DataGridViewCellStyle3
        Me.TrDate.HeaderText = "تاریخ تحویل"
        Me.TrDate.Name = "TrDate"
        Me.TrDate.ReadOnly = True
        '
        'TrReturnDate
        '
        Me.TrReturnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.TrReturnDate.DataPropertyName = "TrReturnDate"
        DataGridViewCellStyle4.Format = "0000/00/00 - 00:00:00"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.TrReturnDate.DefaultCellStyle = DataGridViewCellStyle4
        Me.TrReturnDate.HeaderText = "تاریخ برگرداندن"
        Me.TrReturnDate.Name = "TrReturnDate"
        Me.TrReturnDate.ReadOnly = True
        Me.TrReturnDate.Width = 150
        '
        'UsNumber
        '
        Me.UsNumber.DataPropertyName = "UsNumber"
        Me.UsNumber.HeaderText = "شماره تلفن"
        Me.UsNumber.Name = "UsNumber"
        Me.UsNumber.ReadOnly = True
        '
        'TrustDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(594, 472)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "TrustDetails"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "گزارش"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelDate.ResumeLayout(False)
        Me.PanelDate.PerformLayout()
        Me.PanelMoshtari.ResumeLayout(False)
        Me.PanelMoshtari.PerformLayout()
        Me.PanelFactorID.ResumeLayout(False)
        Me.PanelFactorID.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.grdGozaresh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PanelDate As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox6 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PanelMoshtari As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PanelFactorID As System.Windows.Forms.Panel
    Friend WithEvents txtFromTrID As System.Windows.Forms.TextBox
    Friend WithEvents txtToTrID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadioButtonUsID As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonDate As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonTrID As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents grdGozaresh As System.Windows.Forms.DataGridView
    Friend WithEvents txtUsID As System.Windows.Forms.TextBox
    Friend WithEvents FactorID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsFamily As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KetabID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KetabOnvan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrReturnDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsNumber As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
