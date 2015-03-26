<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccounts
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccounts))
        Me.GpACDef = New System.Windows.Forms.GroupBox
        Me.GpACType = New System.Windows.Forms.GroupBox
        Me.rdbLiability = New System.Windows.Forms.RadioButton
        Me.rdbExpense = New System.Windows.Forms.RadioButton
        Me.rdbIncome = New System.Windows.Forms.RadioButton
        Me.rdbAsset = New System.Windows.Forms.RadioButton
        Me.txtDesc3 = New System.Windows.Forms.TextBox
        Me.txtDesc2 = New System.Windows.Forms.TextBox
        Me.txtDesc1 = New System.Windows.Forms.TextBox
        Me.mskCode = New System.Windows.Forms.MaskedTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GpStatus = New System.Windows.Forms.GroupBox
        Me.dtpCloseDate = New System.Windows.Forms.DateTimePicker
        Me.dtpOpenDate = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.rdbClosed = New System.Windows.Forms.RadioButton
        Me.rdbActive = New System.Windows.Forms.RadioButton
        Me.lblBy = New System.Windows.Forms.Label
        Me.lblToolTip = New System.Windows.Forms.Label
        Me.lblCompany = New System.Windows.Forms.Label
        Me.GpBtns = New System.Windows.Forms.GroupBox
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnBottom = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.btnPrevious = New System.Windows.Forms.Button
        Me.btnTop = New System.Windows.Forms.Button
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.btnFind = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.btnPost = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnView = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.GVHelp = New System.Windows.Forms.DataGridView
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.LblTypeValid = New System.Windows.Forms.Label
        Me.GpACDef.SuspendLayout()
        Me.GpACType.SuspendLayout()
        Me.GpStatus.SuspendLayout()
        Me.GpBtns.SuspendLayout()
        CType(Me.GVHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GpACDef
        '
        Me.GpACDef.Controls.Add(Me.GpACType)
        Me.GpACDef.Controls.Add(Me.txtDesc3)
        Me.GpACDef.Controls.Add(Me.txtDesc2)
        Me.GpACDef.Controls.Add(Me.txtDesc1)
        Me.GpACDef.Controls.Add(Me.mskCode)
        Me.GpACDef.Controls.Add(Me.Label2)
        Me.GpACDef.Controls.Add(Me.Label1)
        Me.GpACDef.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpACDef.Location = New System.Drawing.Point(351, 120)
        Me.GpACDef.Name = "GpACDef"
        Me.GpACDef.Size = New System.Drawing.Size(767, 121)
        Me.GpACDef.TabIndex = 2
        Me.GpACDef.TabStop = False
        Me.GpACDef.Text = "A/C Definition"
        '
        'GpACType
        '
        Me.GpACType.Controls.Add(Me.rdbLiability)
        Me.GpACType.Controls.Add(Me.rdbExpense)
        Me.GpACType.Controls.Add(Me.rdbIncome)
        Me.GpACType.Controls.Add(Me.rdbAsset)
        Me.GpACType.Location = New System.Drawing.Point(512, 12)
        Me.GpACType.Name = "GpACType"
        Me.GpACType.Size = New System.Drawing.Size(200, 98)
        Me.GpACType.TabIndex = 4
        Me.GpACType.TabStop = False
        Me.GpACType.Text = "Account Type"
        '
        'rdbLiability
        '
        Me.rdbLiability.AutoSize = True
        Me.rdbLiability.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbLiability.Location = New System.Drawing.Point(96, 71)
        Me.rdbLiability.Name = "rdbLiability"
        Me.rdbLiability.Size = New System.Drawing.Size(68, 17)
        Me.rdbLiability.TabIndex = 7
        Me.rdbLiability.TabStop = True
        Me.rdbLiability.Text = "Liability"
        Me.rdbLiability.UseVisualStyleBackColor = True
        '
        'rdbExpense
        '
        Me.rdbExpense.AutoSize = True
        Me.rdbExpense.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbExpense.Location = New System.Drawing.Point(96, 52)
        Me.rdbExpense.Name = "rdbExpense"
        Me.rdbExpense.Size = New System.Drawing.Size(73, 17)
        Me.rdbExpense.TabIndex = 6
        Me.rdbExpense.TabStop = True
        Me.rdbExpense.Text = "Expense"
        Me.rdbExpense.UseVisualStyleBackColor = True
        '
        'rdbIncome
        '
        Me.rdbIncome.AutoSize = True
        Me.rdbIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbIncome.Location = New System.Drawing.Point(96, 33)
        Me.rdbIncome.Name = "rdbIncome"
        Me.rdbIncome.Size = New System.Drawing.Size(66, 17)
        Me.rdbIncome.TabIndex = 5
        Me.rdbIncome.TabStop = True
        Me.rdbIncome.Text = "Income"
        Me.rdbIncome.UseVisualStyleBackColor = True
        '
        'rdbAsset
        '
        Me.rdbAsset.AutoSize = True
        Me.rdbAsset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbAsset.Location = New System.Drawing.Point(96, 14)
        Me.rdbAsset.Name = "rdbAsset"
        Me.rdbAsset.Size = New System.Drawing.Size(62, 17)
        Me.rdbAsset.TabIndex = 4
        Me.rdbAsset.TabStop = True
        Me.rdbAsset.Text = "Assets"
        Me.rdbAsset.UseVisualStyleBackColor = True
        '
        'txtDesc3
        '
        Me.txtDesc3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtDesc3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesc3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc3.Location = New System.Drawing.Point(182, 89)
        Me.txtDesc3.Name = "txtDesc3"
        Me.txtDesc3.Size = New System.Drawing.Size(283, 22)
        Me.txtDesc3.TabIndex = 3
        Me.txtDesc3.Tag = "Enter Description"
        '
        'txtDesc2
        '
        Me.txtDesc2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtDesc2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesc2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc2.Location = New System.Drawing.Point(182, 66)
        Me.txtDesc2.Name = "txtDesc2"
        Me.txtDesc2.Size = New System.Drawing.Size(283, 22)
        Me.txtDesc2.TabIndex = 2
        Me.txtDesc2.Tag = "Enter Description"
        '
        'txtDesc1
        '
        Me.txtDesc1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtDesc1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesc1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc1.Location = New System.Drawing.Point(182, 43)
        Me.txtDesc1.Name = "txtDesc1"
        Me.txtDesc1.Size = New System.Drawing.Size(283, 22)
        Me.txtDesc1.TabIndex = 1
        Me.txtDesc1.Tag = "Enter Description"
        '
        'mskCode
        '
        Me.mskCode.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.mskCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskCode.Location = New System.Drawing.Point(182, 20)
        Me.mskCode.Mask = "##"
        Me.mskCode.Name = "mskCode"
        Me.mskCode.Size = New System.Drawing.Size(97, 22)
        Me.mskCode.TabIndex = 0
        Me.mskCode.Tag = "Enter Account Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(108, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Description"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(93, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Account Code"
        '
        'GpStatus
        '
        Me.GpStatus.Controls.Add(Me.dtpCloseDate)
        Me.GpStatus.Controls.Add(Me.dtpOpenDate)
        Me.GpStatus.Controls.Add(Me.Label4)
        Me.GpStatus.Controls.Add(Me.Label3)
        Me.GpStatus.Controls.Add(Me.rdbClosed)
        Me.GpStatus.Controls.Add(Me.rdbActive)
        Me.GpStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpStatus.Location = New System.Drawing.Point(351, 245)
        Me.GpStatus.Name = "GpStatus"
        Me.GpStatus.Size = New System.Drawing.Size(767, 80)
        Me.GpStatus.TabIndex = 9
        Me.GpStatus.TabStop = False
        Me.GpStatus.Text = "Status"
        '
        'dtpCloseDate
        '
        Me.dtpCloseDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCloseDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCloseDate.Location = New System.Drawing.Point(436, 44)
        Me.dtpCloseDate.Name = "dtpCloseDate"
        Me.dtpCloseDate.ShowCheckBox = True
        Me.dtpCloseDate.Size = New System.Drawing.Size(114, 22)
        Me.dtpCloseDate.TabIndex = 11
        '
        'dtpOpenDate
        '
        Me.dtpOpenDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpOpenDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpOpenDate.Location = New System.Drawing.Point(436, 20)
        Me.dtpOpenDate.Name = "dtpOpenDate"
        Me.dtpOpenDate.ShowCheckBox = True
        Me.dtpOpenDate.Size = New System.Drawing.Size(114, 22)
        Me.dtpOpenDate.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(318, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Account Close Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(319, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Account Open Date"
        '
        'rdbClosed
        '
        Me.rdbClosed.AutoSize = True
        Me.rdbClosed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbClosed.Location = New System.Drawing.Point(96, 44)
        Me.rdbClosed.Name = "rdbClosed"
        Me.rdbClosed.Size = New System.Drawing.Size(63, 17)
        Me.rdbClosed.TabIndex = 9
        Me.rdbClosed.TabStop = True
        Me.rdbClosed.Text = "Closed"
        Me.rdbClosed.UseVisualStyleBackColor = True
        '
        'rdbActive
        '
        Me.rdbActive.AutoSize = True
        Me.rdbActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbActive.Location = New System.Drawing.Point(96, 21)
        Me.rdbActive.Name = "rdbActive"
        Me.rdbActive.Size = New System.Drawing.Size(61, 17)
        Me.rdbActive.TabIndex = 8
        Me.rdbActive.TabStop = True
        Me.rdbActive.Text = "Active"
        Me.rdbActive.UseVisualStyleBackColor = True
        '
        'lblBy
        '
        Me.lblBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBy.Location = New System.Drawing.Point(838, 654)
        Me.lblBy.Name = "lblBy"
        Me.lblBy.Size = New System.Drawing.Size(170, 23)
        Me.lblBy.TabIndex = 13
        '
        'lblToolTip
        '
        Me.lblToolTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblToolTip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToolTip.Location = New System.Drawing.Point(461, 654)
        Me.lblToolTip.Name = "lblToolTip"
        Me.lblToolTip.Size = New System.Drawing.Size(372, 23)
        Me.lblToolTip.TabIndex = 12
        '
        'lblCompany
        '
        Me.lblCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.Location = New System.Drawing.Point(285, 655)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(170, 23)
        Me.lblCompany.TabIndex = 11
        '
        'GpBtns
        '
        Me.GpBtns.Controls.Add(Me.btnExit)
        Me.GpBtns.Controls.Add(Me.btnBottom)
        Me.GpBtns.Controls.Add(Me.btnNext)
        Me.GpBtns.Controls.Add(Me.btnPrevious)
        Me.GpBtns.Controls.Add(Me.btnTop)
        Me.GpBtns.Controls.Add(Me.btnRefresh)
        Me.GpBtns.Controls.Add(Me.btnFind)
        Me.GpBtns.Controls.Add(Me.btnCancel)
        Me.GpBtns.Controls.Add(Me.btnSave)
        Me.GpBtns.Controls.Add(Me.btnPrint)
        Me.GpBtns.Controls.Add(Me.btnPost)
        Me.GpBtns.Controls.Add(Me.btnDelete)
        Me.GpBtns.Controls.Add(Me.btnView)
        Me.GpBtns.Controls.Add(Me.btnEdit)
        Me.GpBtns.Controls.Add(Me.btnAdd)
        Me.GpBtns.Location = New System.Drawing.Point(350, 54)
        Me.GpBtns.Name = "GpBtns"
        Me.GpBtns.Size = New System.Drawing.Size(768, 58)
        Me.GpBtns.TabIndex = 14
        Me.GpBtns.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(657, 11)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(46, 39)
        Me.btnExit.TabIndex = 22
        Me.btnExit.Text = "E&xit"
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnBottom
        '
        Me.btnBottom.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBottom.Image = CType(resources.GetObject("btnBottom.Image"), System.Drawing.Image)
        Me.btnBottom.Location = New System.Drawing.Point(605, 11)
        Me.btnBottom.Name = "btnBottom"
        Me.btnBottom.Size = New System.Drawing.Size(48, 39)
        Me.btnBottom.TabIndex = 34
        Me.btnBottom.Text = "&Bottom"
        Me.btnBottom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnBottom.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Image = CType(resources.GetObject("btnNext.Image"), System.Drawing.Image)
        Me.btnNext.Location = New System.Drawing.Point(560, 11)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(46, 39)
        Me.btnNext.TabIndex = 33
        Me.btnNext.Text = "&Next"
        Me.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Image = CType(resources.GetObject("btnPrevious.Image"), System.Drawing.Image)
        Me.btnPrevious.Location = New System.Drawing.Point(515, 11)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(46, 39)
        Me.btnPrevious.TabIndex = 33
        Me.btnPrevious.Text = "&Prev."
        Me.btnPrevious.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnTop
        '
        Me.btnTop.Image = CType(resources.GetObject("btnTop.Image"), System.Drawing.Image)
        Me.btnTop.Location = New System.Drawing.Point(470, 11)
        Me.btnTop.Name = "btnTop"
        Me.btnTop.Size = New System.Drawing.Size(46, 39)
        Me.btnTop.TabIndex = 31
        Me.btnTop.Text = "&Top"
        Me.btnTop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnTop.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.Location = New System.Drawing.Point(420, 11)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(46, 39)
        Me.btnRefresh.TabIndex = 30
        Me.btnRefresh.Text = "&Ref."
        Me.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnFind
        '
        Me.btnFind.Image = CType(resources.GetObject("btnFind.Image"), System.Drawing.Image)
        Me.btnFind.Location = New System.Drawing.Point(228, 11)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(46, 39)
        Me.btnFind.TabIndex = 29
        Me.btnFind.Text = "&View"
        Me.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(323, 11)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(48, 39)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(278, 11)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(46, 39)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(183, 11)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(46, 39)
        Me.btnPrint.TabIndex = 28
        Me.btnPrint.Text = "Pr&int"
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnPost
        '
        Me.btnPost.Image = CType(resources.GetObject("btnPost.Image"), System.Drawing.Image)
        Me.btnPost.Location = New System.Drawing.Point(138, 11)
        Me.btnPost.Name = "btnPost"
        Me.btnPost.Size = New System.Drawing.Size(46, 39)
        Me.btnPost.TabIndex = 27
        Me.btnPost.Text = "P&ost"
        Me.btnPost.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPost.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(93, 11)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(46, 39)
        Me.btnDelete.TabIndex = 26
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Image = CType(resources.GetObject("btnView.Image"), System.Drawing.Image)
        Me.btnView.Location = New System.Drawing.Point(376, 11)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(46, 39)
        Me.btnView.TabIndex = 25
        Me.btnView.Text = "&Filter"
        Me.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(48, 11)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(46, 39)
        Me.btnEdit.TabIndex = 24
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(3, 11)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(46, 39)
        Me.btnAdd.TabIndex = 23
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(17, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Search"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GVHelp
        '
        Me.GVHelp.AllowUserToAddRows = False
        Me.GVHelp.AllowUserToDeleteRows = False
        Me.GVHelp.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.GVHelp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GVHelp.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.GVHelp.Location = New System.Drawing.Point(16, 112)
        Me.GVHelp.Name = "GVHelp"
        Me.GVHelp.ReadOnly = True
        Me.GVHelp.RowHeadersWidth = 20
        Me.GVHelp.Size = New System.Drawing.Size(314, 565)
        Me.GVHelp.StandardTab = True
        Me.GVHelp.TabIndex = 45
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(17, 81)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(313, 20)
        Me.txtSearch.TabIndex = 44
        '
        'LblTypeValid
        '
        Me.LblTypeValid.BackColor = System.Drawing.Color.PowderBlue
        Me.LblTypeValid.Font = New System.Drawing.Font("Nina", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTypeValid.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LblTypeValid.Location = New System.Drawing.Point(-1, 0)
        Me.LblTypeValid.Name = "LblTypeValid"
        Me.LblTypeValid.Size = New System.Drawing.Size(1136, 52)
        Me.LblTypeValid.TabIndex = 47
        Me.LblTypeValid.Text = "Account Code"
        Me.LblTypeValid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 693)
        Me.Controls.Add(Me.LblTypeValid)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GVHelp)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.GpBtns)
        Me.Controls.Add(Me.lblBy)
        Me.Controls.Add(Me.lblToolTip)
        Me.Controls.Add(Me.lblCompany)
        Me.Controls.Add(Me.GpStatus)
        Me.Controls.Add(Me.GpACDef)
        Me.Name = "frmAccounts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Codes"
        Me.GpACDef.ResumeLayout(False)
        Me.GpACDef.PerformLayout()
        Me.GpACType.ResumeLayout(False)
        Me.GpACType.PerformLayout()
        Me.GpStatus.ResumeLayout(False)
        Me.GpStatus.PerformLayout()
        Me.GpBtns.ResumeLayout(False)
        CType(Me.GVHelp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GpACDef As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mskCode As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GpACType As System.Windows.Forms.GroupBox
    Friend WithEvents txtDesc3 As System.Windows.Forms.TextBox
    Friend WithEvents txtDesc2 As System.Windows.Forms.TextBox
    Friend WithEvents txtDesc1 As System.Windows.Forms.TextBox
    Friend WithEvents rdbLiability As System.Windows.Forms.RadioButton
    Friend WithEvents rdbExpense As System.Windows.Forms.RadioButton
    Friend WithEvents rdbIncome As System.Windows.Forms.RadioButton
    Friend WithEvents rdbAsset As System.Windows.Forms.RadioButton
    Friend WithEvents GpStatus As System.Windows.Forms.GroupBox
    Friend WithEvents dtpOpenDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rdbClosed As System.Windows.Forms.RadioButton
    Friend WithEvents rdbActive As System.Windows.Forms.RadioButton
    Friend WithEvents dtpCloseDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblBy As System.Windows.Forms.Label
    Friend WithEvents lblToolTip As System.Windows.Forms.Label
    Friend WithEvents lblCompany As System.Windows.Forms.Label
    Friend WithEvents GpBtns As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnBottom As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnTop As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnPost As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GVHelp As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents LblTypeValid As System.Windows.Forms.Label
End Class
