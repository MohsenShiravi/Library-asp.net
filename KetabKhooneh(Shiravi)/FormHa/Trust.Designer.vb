<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Trust
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LabelKetab = New System.Windows.Forms.Label
        Me.txtKetabID = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.btnInsertKetab = New System.Windows.Forms.Button
        Me.txtKetabDetails = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtTrID = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtUsDetails = New System.Windows.Forms.TextBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.btnFactor = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtUsID = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.dgdFactorDetails = New System.Windows.Forms.DataGridView
        Me.TrID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KetabID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KetabOnvan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TrDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgdFactorDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelKetab)
        Me.GroupBox1.Controls.Add(Me.txtKetabID)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.btnInsertKetab)
        Me.GroupBox1.Controls.Add(Me.txtKetabDetails)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 155)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(500, 127)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ثبت کتاب"
        '
        'LabelKetab
        '
        Me.LabelKetab.AutoSize = True
        Me.LabelKetab.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LabelKetab.Location = New System.Drawing.Point(46, 26)
        Me.LabelKetab.Name = "LabelKetab"
        Me.LabelKetab.Size = New System.Drawing.Size(14, 13)
        Me.LabelKetab.TabIndex = 15
        Me.LabelKetab.Text = "0"
        Me.LabelKetab.Visible = False
        '
        'txtKetabID
        '
        Me.txtKetabID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKetabID.Location = New System.Drawing.Point(253, 20)
        Me.txtKetabID.Name = "txtKetabID"
        Me.txtKetabID.Size = New System.Drawing.Size(154, 21)
        Me.txtKetabID.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.Location = New System.Drawing.Point(413, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "توضیحات"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button3.Location = New System.Drawing.Point(104, 18)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "پاک کردن"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnInsertKetab
        '
        Me.btnInsertKetab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsertKetab.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnInsertKetab.Location = New System.Drawing.Point(182, 18)
        Me.btnInsertKetab.Name = "btnInsertKetab"
        Me.btnInsertKetab.Size = New System.Drawing.Size(65, 22)
        Me.btnInsertKetab.TabIndex = 11
        Me.btnInsertKetab.Text = "ثبت کتاب"
        Me.btnInsertKetab.UseVisualStyleBackColor = True
        '
        'txtKetabDetails
        '
        Me.txtKetabDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKetabDetails.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtKetabDetails.Location = New System.Drawing.Point(44, 46)
        Me.txtKetabDetails.Multiline = True
        Me.txtKetabDetails.Name = "txtKetabDetails"
        Me.txtKetabDetails.ReadOnly = True
        Me.txtKetabDetails.Size = New System.Drawing.Size(363, 72)
        Me.txtKetabDetails.TabIndex = 9
        Me.txtKetabDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(413, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "شناسه کتاب"
        '
        'txtTrID
        '
        Me.txtTrID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTrID.Location = New System.Drawing.Point(323, 22)
        Me.txtTrID.Name = "txtTrID"
        Me.txtTrID.Size = New System.Drawing.Size(84, 21)
        Me.txtTrID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(413, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "شماره ثبت"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtUsDetails)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.btnFactor)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtUsID)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtTrID)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(500, 155)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ثبت"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(413, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "توضیحات کاربر"
        '
        'txtUsDetails
        '
        Me.txtUsDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsDetails.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtUsDetails.Location = New System.Drawing.Point(41, 81)
        Me.txtUsDetails.Multiline = True
        Me.txtUsDetails.Name = "txtUsDetails"
        Me.txtUsDetails.ReadOnly = True
        Me.txtUsDetails.Size = New System.Drawing.Size(366, 68)
        Me.txtUsDetails.TabIndex = 10
        Me.txtUsDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button4.Location = New System.Drawing.Point(104, 23)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(105, 23)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "برگشت کتاب"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnFactor
        '
        Me.btnFactor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFactor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnFactor.Location = New System.Drawing.Point(215, 23)
        Me.btnFactor.Name = "btnFactor"
        Me.btnFactor.Size = New System.Drawing.Size(102, 23)
        Me.btnFactor.TabIndex = 5
        Me.btnFactor.Text = "ثبت شماره جدید"
        Me.btnFactor.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(413, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "شناسه کاربر"
        '
        'txtUsID
        '
        Me.txtUsID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsID.Location = New System.Drawing.Point(323, 51)
        Me.txtUsID.Name = "txtUsID"
        Me.txtUsID.Size = New System.Drawing.Size(84, 21)
        Me.txtUsID.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Panel1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(0, 282)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(500, 150)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "کتاب امانت داده شده"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgdFactorDetails)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Panel1.Location = New System.Drawing.Point(3, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(494, 130)
        Me.Panel1.TabIndex = 5
        '
        'dgdFactorDetails
        '
        Me.dgdFactorDetails.AllowUserToAddRows = False
        Me.dgdFactorDetails.AllowUserToDeleteRows = False
        Me.dgdFactorDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdFactorDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TrID, Me.KetabID, Me.KetabOnvan, Me.TrDate})
        Me.dgdFactorDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgdFactorDetails.Location = New System.Drawing.Point(0, 0)
        Me.dgdFactorDetails.Name = "dgdFactorDetails"
        Me.dgdFactorDetails.ReadOnly = True
        Me.dgdFactorDetails.RowHeadersVisible = False
        Me.dgdFactorDetails.Size = New System.Drawing.Size(494, 130)
        Me.dgdFactorDetails.TabIndex = 11
        '
        'TrID
        '
        Me.TrID.DataPropertyName = "TrID"
        Me.TrID.FillWeight = 70.0!
        Me.TrID.Frozen = True
        Me.TrID.HeaderText = "شماره ثبت"
        Me.TrID.Name = "TrID"
        Me.TrID.ReadOnly = True
        Me.TrID.Width = 70
        '
        'KetabID
        '
        Me.KetabID.DataPropertyName = "KetabID"
        Me.KetabID.FillWeight = 70.0!
        Me.KetabID.Frozen = True
        Me.KetabID.HeaderText = "شناسه ک"
        Me.KetabID.Name = "KetabID"
        Me.KetabID.ReadOnly = True
        Me.KetabID.Width = 70
        '
        'KetabOnvan
        '
        Me.KetabOnvan.DataPropertyName = "KetabOnvan"
        Me.KetabOnvan.Frozen = True
        Me.KetabOnvan.HeaderText = "عنوان کتاب"
        Me.KetabOnvan.MinimumWidth = 200
        Me.KetabOnvan.Name = "KetabOnvan"
        Me.KetabOnvan.ReadOnly = True
        Me.KetabOnvan.Width = 240
        '
        'TrDate
        '
        Me.TrDate.DataPropertyName = "TrDate"
        DataGridViewCellStyle1.Format = "0000/00/00 - 00:00:00"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.TrDate.DefaultCellStyle = DataGridViewCellStyle1
        Me.TrDate.Frozen = True
        Me.TrDate.HeaderText = "تاریخ تحویل کتاب"
        Me.TrDate.Name = "TrDate"
        Me.TrDate.ReadOnly = True
        Me.TrDate.Width = 120
        '
        'Trust
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(500, 432)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Trust"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "امانت"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgdFactorDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTrID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUsID As System.Windows.Forms.TextBox
    Friend WithEvents btnFactor As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnInsertKetab As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgdFactorDetails As System.Windows.Forms.DataGridView
    Friend WithEvents txtKetabDetails As System.Windows.Forms.TextBox
    Friend WithEvents txtKetabID As System.Windows.Forms.TextBox
    Friend WithEvents txtUsDetails As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LabelKetab As System.Windows.Forms.Label
    Friend WithEvents TrID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KetabID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KetabOnvan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrDate As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
