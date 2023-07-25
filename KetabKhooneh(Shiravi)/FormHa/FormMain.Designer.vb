<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.فایلToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.خروجToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ثبتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ثبتکتابToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ثبتکاربرانToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ثبتمدیرانToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.جستجوToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.جستجوکتابToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.جستجوکاربرانToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.گزارشاتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.گزارشفروشToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.دربارهToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.دربارهبرنامهنویسToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.lblWelcome1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.LblDate = New System.Windows.Forms.ToolStripLabel
        Me.lblDay = New System.Windows.Forms.ToolStripLabel
        Me.lblTime = New System.Windows.Forms.ToolStripLabel
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.فایلToolStripMenuItem, Me.ثبتToolStripMenuItem, Me.جستجوToolStripMenuItem, Me.گزارشاتToolStripMenuItem, Me.دربارهToolStripMenuItem})
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'فایلToolStripMenuItem
        '
        Me.فایلToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.خروجToolStripMenuItem})
        Me.فایلToolStripMenuItem.Name = "فایلToolStripMenuItem"
        resources.ApplyResources(Me.فایلToolStripMenuItem, "فایلToolStripMenuItem")
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        resources.ApplyResources(Me.ToolStripMenuItem1, "ToolStripMenuItem1")
        '
        'خروجToolStripMenuItem
        '
        Me.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem"
        resources.ApplyResources(Me.خروجToolStripMenuItem, "خروجToolStripMenuItem")
        '
        'ثبتToolStripMenuItem
        '
        Me.ثبتToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ثبتکتابToolStripMenuItem, Me.ثبتکاربرانToolStripMenuItem, Me.ثبتمدیرانToolStripMenuItem})
        Me.ثبتToolStripMenuItem.Name = "ثبتToolStripMenuItem"
        resources.ApplyResources(Me.ثبتToolStripMenuItem, "ثبتToolStripMenuItem")
        '
        'ثبتکتابToolStripMenuItem
        '
        Me.ثبتکتابToolStripMenuItem.Name = "ثبتکتابToolStripMenuItem"
        resources.ApplyResources(Me.ثبتکتابToolStripMenuItem, "ثبتکتابToolStripMenuItem")
        '
        'ثبتکاربرانToolStripMenuItem
        '
        Me.ثبتکاربرانToolStripMenuItem.Name = "ثبتکاربرانToolStripMenuItem"
        resources.ApplyResources(Me.ثبتکاربرانToolStripMenuItem, "ثبتکاربرانToolStripMenuItem")
        '
        'ثبتمدیرانToolStripMenuItem
        '
        Me.ثبتمدیرانToolStripMenuItem.Name = "ثبتمدیرانToolStripMenuItem"
        resources.ApplyResources(Me.ثبتمدیرانToolStripMenuItem, "ثبتمدیرانToolStripMenuItem")
        '
        'جستجوToolStripMenuItem
        '
        Me.جستجوToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.جستجوکتابToolStripMenuItem, Me.جستجوکاربرانToolStripMenuItem})
        Me.جستجوToolStripMenuItem.Name = "جستجوToolStripMenuItem"
        resources.ApplyResources(Me.جستجوToolStripMenuItem, "جستجوToolStripMenuItem")
        '
        'جستجوکتابToolStripMenuItem
        '
        Me.جستجوکتابToolStripMenuItem.Name = "جستجوکتابToolStripMenuItem"
        resources.ApplyResources(Me.جستجوکتابToolStripMenuItem, "جستجوکتابToolStripMenuItem")
        '
        'جستجوکاربرانToolStripMenuItem
        '
        Me.جستجوکاربرانToolStripMenuItem.Name = "جستجوکاربرانToolStripMenuItem"
        resources.ApplyResources(Me.جستجوکاربرانToolStripMenuItem, "جستجوکاربرانToolStripMenuItem")
        '
        'گزارشاتToolStripMenuItem
        '
        Me.گزارشاتToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.گزارشفروشToolStripMenuItem})
        Me.گزارشاتToolStripMenuItem.Name = "گزارشاتToolStripMenuItem"
        resources.ApplyResources(Me.گزارشاتToolStripMenuItem, "گزارشاتToolStripMenuItem")
        '
        'گزارشفروشToolStripMenuItem
        '
        Me.گزارشفروشToolStripMenuItem.Name = "گزارشفروشToolStripMenuItem"
        resources.ApplyResources(Me.گزارشفروشToolStripMenuItem, "گزارشفروشToolStripMenuItem")
        '
        'دربارهToolStripMenuItem
        '
        Me.دربارهToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.دربارهبرنامهنویسToolStripMenuItem})
        Me.دربارهToolStripMenuItem.Name = "دربارهToolStripMenuItem"
        resources.ApplyResources(Me.دربارهToolStripMenuItem, "دربارهToolStripMenuItem")
        '
        'دربارهبرنامهنویسToolStripMenuItem
        '
        Me.دربارهبرنامهنویسToolStripMenuItem.Name = "دربارهبرنامهنویسToolStripMenuItem"
        resources.ApplyResources(Me.دربارهبرنامهنویسToolStripMenuItem, "دربارهبرنامهنویسToolStripMenuItem")
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ToolStrip3
        '
        Me.ToolStrip3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        resources.ApplyResources(Me.ToolStrip3, "ToolStrip3")
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator9, Me.ToolStripButton4, Me.ToolStripSeparator6, Me.ToolStripButton1, Me.ToolStripButton7})
        Me.ToolStrip3.Name = "ToolStrip3"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        resources.ApplyResources(Me.ToolStripSeparator9, "ToolStripSeparator9")
        '
        'ToolStripButton4
        '
        resources.ApplyResources(Me.ToolStripButton4, "ToolStripButton4")
        Me.ToolStripButton4.Name = "ToolStripButton4"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        resources.ApplyResources(Me.ToolStripSeparator6, "ToolStripSeparator6")
        '
        'ToolStripButton1
        '
        resources.ApplyResources(Me.ToolStripButton1, "ToolStripButton1")
        Me.ToolStripButton1.Name = "ToolStripButton1"
        '
        'ToolStripButton7
        '
        resources.ApplyResources(Me.ToolStripButton7, "ToolStripButton7")
        Me.ToolStripButton7.Name = "ToolStripButton7"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        resources.ApplyResources(Me.ToolStripLabel1, "ToolStripLabel1")
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        resources.ApplyResources(Me.ToolStripButton5, "ToolStripButton5")
        Me.ToolStripButton5.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.PaleGoldenrod
        resources.ApplyResources(Me.ToolStrip1, "ToolStrip1")
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripButton5, Me.ToolStripSeparator1, Me.lblWelcome1, Me.ToolStripSeparator2, Me.LblDate, Me.lblDay, Me.lblTime})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip1.Name = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'lblWelcome1
        '
        resources.ApplyResources(Me.lblWelcome1, "lblWelcome1")
        Me.lblWelcome1.Name = "lblWelcome1"
        Me.lblWelcome1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
        '
        'LblDate
        '
        resources.ApplyResources(Me.LblDate, "LblDate")
        Me.LblDate.Name = "LblDate"
        '
        'lblDay
        '
        resources.ApplyResources(Me.lblDay, "lblDay")
        Me.lblDay.Name = "lblDay"
        '
        'lblTime
        '
        resources.ApplyResources(Me.lblTime, "lblTime")
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        '
        'FormMain
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ToolStrip3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.Navy
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormMain"
        Me.ShowIcon = False
        Me.TransparencyKey = System.Drawing.Color.White
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents فایلToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents خروجToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ثبتToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents دربارهToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ثبتکتابToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents جستجوToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents جستجوکتابToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents دربارهبرنامهنویسToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents گزارشاتToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents گزارشفروشToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblWelcome As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ثبتکاربرانToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ثبتمدیرانToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents جستجوکاربرانToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblDay As System.Windows.Forms.ToolStripLabel
    Friend WithEvents LblDate As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblTime As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblWelcome1 As System.Windows.Forms.ToolStripLabel

End Class
