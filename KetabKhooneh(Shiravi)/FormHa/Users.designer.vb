<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Users
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
        Me.txtUsID = New System.Windows.Forms.TextBox
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbl = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.UsID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UsName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UsFamily = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UsFatherName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UsNumber = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UsBirthDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UsStartDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UsRevivalDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtUsID)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lbl)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(563, 298)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "کاربران"
        '
        'txtUsID
        '
        Me.txtUsID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsID.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtUsID.Location = New System.Drawing.Point(407, 50)
        Me.txtUsID.Name = "txtUsID"
        Me.txtUsID.Size = New System.Drawing.Size(69, 21)
        Me.txtUsID.TabIndex = 5
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(265, 23)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(211, 21)
        Me.txtSearch.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(482, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "شناسه کاربر"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl.Location = New System.Drawing.Point(482, 26)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(46, 13)
        Me.lbl.TabIndex = 1
        Me.lbl.Text = "جستجو"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UsID, Me.UsName, Me.UsFamily, Me.UsFatherName, Me.UsNumber, Me.UsBirthDate, Me.UsStartDate, Me.UsRevivalDate})
        Me.DataGridView1.Location = New System.Drawing.Point(4, 77)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(555, 214)
        Me.DataGridView1.TabIndex = 0
        '
        'UsID
        '
        Me.UsID.DataPropertyName = "UsID"
        Me.UsID.HeaderText = "شناسه"
        Me.UsID.Name = "UsID"
        Me.UsID.ReadOnly = True
        Me.UsID.Width = 70
        '
        'UsName
        '
        Me.UsName.DataPropertyName = "UsName"
        Me.UsName.HeaderText = "نام"
        Me.UsName.Name = "UsName"
        Me.UsName.ReadOnly = True
        '
        'UsFamily
        '
        Me.UsFamily.DataPropertyName = "UsFamily"
        Me.UsFamily.HeaderText = "نام خانوادگی"
        Me.UsFamily.Name = "UsFamily"
        Me.UsFamily.ReadOnly = True
        Me.UsFamily.Width = 150
        '
        'UsFatherName
        '
        Me.UsFatherName.DataPropertyName = "UsFatherName"
        Me.UsFatherName.HeaderText = "نام پدر"
        Me.UsFatherName.Name = "UsFatherName"
        Me.UsFatherName.ReadOnly = True
        '
        'UsNumber
        '
        Me.UsNumber.DataPropertyName = "UsNumber"
        Me.UsNumber.HeaderText = "شماره ملی"
        Me.UsNumber.Name = "UsNumber"
        Me.UsNumber.ReadOnly = True
        '
        'UsBirthDate
        '
        Me.UsBirthDate.DataPropertyName = "UsBirthDate"
        Me.UsBirthDate.HeaderText = "تاریخ تولد"
        Me.UsBirthDate.Name = "UsBirthDate"
        Me.UsBirthDate.ReadOnly = True
        '
        'UsStartDate
        '
        Me.UsStartDate.DataPropertyName = "UsStartDate"
        Me.UsStartDate.HeaderText = "تاریخ ثبت نام"
        Me.UsStartDate.Name = "UsStartDate"
        Me.UsStartDate.ReadOnly = True
        '
        'UsRevivalDate
        '
        Me.UsRevivalDate.DataPropertyName = "UsRevivalDate"
        Me.UsRevivalDate.HeaderText = "تاریخ تمدید"
        Me.UsRevivalDate.Name = "UsRevivalDate"
        Me.UsRevivalDate.ReadOnly = True
        '
        'Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(589, 324)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Users"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "کاربران"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents txtUsID As System.Windows.Forms.TextBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents UsID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsFamily As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsFatherName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsBirthDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsStartDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsRevivalDate As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
