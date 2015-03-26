<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecPay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecPay))
        Me.GpData = New System.Windows.Forms.GroupBox
        Me.LBLPosted = New System.Windows.Forms.Label
        Me.lblBrName = New System.Windows.Forms.Label
        Me.lblRfCode = New System.Windows.Forms.Label
        Me.lblVNo = New System.Windows.Forms.Label
        Me.dtpVDate = New System.Windows.Forms.DateTimePicker
        Me.txtPurpose = New System.Windows.Forms.TextBox
        Me.txtBrCode = New System.Windows.Forms.TextBox
        Me.mskCode = New System.Windows.Forms.MaskedTextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblRefCode = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.LBLBalance = New System.Windows.Forms.Label
        Me.btnCode = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblTotAmt = New System.Windows.Forms.Label
        Me.GpTaxDed = New System.Windows.Forms.GroupBox
        Me.mskTaxRate = New System.Windows.Forms.MaskedTextBox
        Me.lblNetPayable = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.lblDedAmount = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtDedRemarks = New System.Windows.Forms.TextBox
        Me.lblDedCodeDec = New System.Windows.Forms.Label
        Me.mskDedCode = New System.Windows.Forms.MaskedTextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.LblTypeValid = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GVHelp = New System.Windows.Forms.DataGridView
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.vspGrid = New AxFPSpreadADO.AxfpSpread
        Me.GpData.SuspendLayout()
        Me.GpBtns.SuspendLayout()
        Me.GpTaxDed.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GVHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vspGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GpData
        '
        Me.GpData.Controls.Add(Me.LBLPosted)
        Me.GpData.Controls.Add(Me.lblBrName)
        Me.GpData.Controls.Add(Me.lblRfCode)
        Me.GpData.Controls.Add(Me.lblVNo)
        Me.GpData.Controls.Add(Me.dtpVDate)
        Me.GpData.Controls.Add(Me.txtPurpose)
        Me.GpData.Controls.Add(Me.txtBrCode)
        Me.GpData.Controls.Add(Me.mskCode)
        Me.GpData.Controls.Add(Me.Label5)
        Me.GpData.Controls.Add(Me.lblRefCode)
        Me.GpData.Controls.Add(Me.Label2)
        Me.GpData.Controls.Add(Me.Label1)
        Me.GpData.Controls.Add(Me.Label4)
        Me.GpData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpData.Location = New System.Drawing.Point(387, 114)
        Me.GpData.Name = "GpData"
        Me.GpData.Size = New System.Drawing.Size(791, 121)
        Me.GpData.TabIndex = 3
        Me.GpData.TabStop = False
        '
        'LBLPosted
        '
        Me.LBLPosted.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPosted.ForeColor = System.Drawing.Color.Red
        Me.LBLPosted.Location = New System.Drawing.Point(566, 15)
        Me.LBLPosted.Name = "LBLPosted"
        Me.LBLPosted.Size = New System.Drawing.Size(157, 42)
        Me.LBLPosted.TabIndex = 14
        Me.LBLPosted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBrName
        '
        Me.lblBrName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblBrName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBrName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrName.Location = New System.Drawing.Point(188, 15)
        Me.lblBrName.Name = "lblBrName"
        Me.lblBrName.Size = New System.Drawing.Size(328, 22)
        Me.lblBrName.TabIndex = 11
        Me.lblBrName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRfCode
        '
        Me.lblRfCode.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblRfCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRfCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRfCode.Location = New System.Drawing.Point(233, 61)
        Me.lblRfCode.Name = "lblRfCode"
        Me.lblRfCode.Size = New System.Drawing.Size(283, 22)
        Me.lblRfCode.TabIndex = 10
        Me.lblRfCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVNo
        '
        Me.lblVNo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblVNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVNo.Location = New System.Drawing.Point(421, 38)
        Me.lblVNo.Name = "lblVNo"
        Me.lblVNo.Size = New System.Drawing.Size(95, 22)
        Me.lblVNo.TabIndex = 8
        Me.lblVNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpVDate
        '
        Me.dtpVDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpVDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVDate.Location = New System.Drawing.Point(138, 38)
        Me.dtpVDate.Name = "dtpVDate"
        Me.dtpVDate.Size = New System.Drawing.Size(91, 22)
        Me.dtpVDate.TabIndex = 1
        '
        'txtPurpose
        '
        Me.txtPurpose.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtPurpose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPurpose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurpose.Location = New System.Drawing.Point(138, 84)
        Me.txtPurpose.MaxLength = 80
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.Size = New System.Drawing.Size(378, 22)
        Me.txtPurpose.TabIndex = 3
        Me.txtPurpose.Tag = "Enter Purpose"
        '
        'txtBrCode
        '
        Me.txtBrCode.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtBrCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBrCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBrCode.Location = New System.Drawing.Point(138, 15)
        Me.txtBrCode.MaxLength = 3
        Me.txtBrCode.Name = "txtBrCode"
        Me.txtBrCode.Size = New System.Drawing.Size(46, 22)
        Me.txtBrCode.TabIndex = 0
        Me.txtBrCode.Tag = "Enter Description"
        '
        'mskCode
        '
        Me.mskCode.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.mskCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskCode.Location = New System.Drawing.Point(138, 61)
        Me.mskCode.Mask = "##"
        Me.mskCode.Name = "mskCode"
        Me.mskCode.Size = New System.Drawing.Size(91, 22)
        Me.mskCode.TabIndex = 2
        Me.mskCode.Tag = "Enter Account Code"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(79, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Purpose"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblRefCode
        '
        Me.lblRefCode.AutoSize = True
        Me.lblRefCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRefCode.Location = New System.Drawing.Point(68, 64)
        Me.lblRefCode.Name = "lblRefCode"
        Me.lblRefCode.Size = New System.Drawing.Size(62, 13)
        Me.lblRefCode.TabIndex = 6
        Me.lblRefCode.Text = "A/C Code"
        Me.lblRefCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Voucher Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Branch / Office Code"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(337, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Voucher No."
        '
        'lblBy
        '
        Me.lblBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBy.Location = New System.Drawing.Point(962, 637)
        Me.lblBy.Name = "lblBy"
        Me.lblBy.Size = New System.Drawing.Size(170, 23)
        Me.lblBy.TabIndex = 16
        '
        'lblToolTip
        '
        Me.lblToolTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblToolTip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToolTip.Location = New System.Drawing.Point(565, 637)
        Me.lblToolTip.Name = "lblToolTip"
        Me.lblToolTip.Size = New System.Drawing.Size(393, 23)
        Me.lblToolTip.TabIndex = 15
        '
        'lblCompany
        '
        Me.lblCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.Location = New System.Drawing.Point(391, 637)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(170, 23)
        Me.lblCompany.TabIndex = 14
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
        Me.GpBtns.Location = New System.Drawing.Point(387, 55)
        Me.GpBtns.Name = "GpBtns"
        Me.GpBtns.Size = New System.Drawing.Size(791, 58)
        Me.GpBtns.TabIndex = 17
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
        Me.btnCancel.TabIndex = 8
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
        Me.btnSave.TabIndex = 8
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
        Me.btnView.Location = New System.Drawing.Point(375, 11)
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(396, 552)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Current Balance >>"
        '
        'LBLBalance
        '
        Me.LBLBalance.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LBLBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLBalance.Location = New System.Drawing.Point(518, 548)
        Me.LBLBalance.Name = "LBLBalance"
        Me.LBLBalance.Size = New System.Drawing.Size(99, 21)
        Me.LBLBalance.TabIndex = 19
        Me.LBLBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCode
        '
        Me.btnCode.Location = New System.Drawing.Point(623, 548)
        Me.btnCode.Name = "btnCode"
        Me.btnCode.Size = New System.Drawing.Size(122, 23)
        Me.btnCode.TabIndex = 20
        Me.btnCode.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(751, 552)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "<< Click For Details"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1041, 552)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Total"
        '
        'lblTotAmt
        '
        Me.lblTotAmt.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTotAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotAmt.Location = New System.Drawing.Point(1078, 548)
        Me.lblTotAmt.Name = "lblTotAmt"
        Me.lblTotAmt.Size = New System.Drawing.Size(99, 21)
        Me.lblTotAmt.TabIndex = 23
        Me.lblTotAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GpTaxDed
        '
        Me.GpTaxDed.Controls.Add(Me.mskTaxRate)
        Me.GpTaxDed.Controls.Add(Me.lblNetPayable)
        Me.GpTaxDed.Controls.Add(Me.Label15)
        Me.GpTaxDed.Controls.Add(Me.lblDedAmount)
        Me.GpTaxDed.Controls.Add(Me.Label13)
        Me.GpTaxDed.Controls.Add(Me.Label12)
        Me.GpTaxDed.Controls.Add(Me.Label11)
        Me.GpTaxDed.Controls.Add(Me.txtDedRemarks)
        Me.GpTaxDed.Controls.Add(Me.lblDedCodeDec)
        Me.GpTaxDed.Controls.Add(Me.mskDedCode)
        Me.GpTaxDed.Controls.Add(Me.Label9)
        Me.GpTaxDed.Controls.Add(Me.Label8)
        Me.GpTaxDed.Location = New System.Drawing.Point(6, 750)
        Me.GpTaxDed.Name = "GpTaxDed"
        Me.GpTaxDed.Size = New System.Drawing.Size(755, 84)
        Me.GpTaxDed.TabIndex = 24
        Me.GpTaxDed.TabStop = False
        '
        'mskTaxRate
        '
        Me.mskTaxRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskTaxRate.Location = New System.Drawing.Point(359, 50)
        Me.mskTaxRate.Mask = "##"
        Me.mskTaxRate.Name = "mskTaxRate"
        Me.mskTaxRate.Size = New System.Drawing.Size(35, 22)
        Me.mskTaxRate.TabIndex = 7
        Me.mskTaxRate.Tag = "Enter Account Code"
        '
        'lblNetPayable
        '
        Me.lblNetPayable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNetPayable.Location = New System.Drawing.Point(627, 51)
        Me.lblNetPayable.Name = "lblNetPayable"
        Me.lblNetPayable.Size = New System.Drawing.Size(99, 20)
        Me.lblNetPayable.TabIndex = 12
        Me.lblNetPayable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(559, 54)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 13)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Net Payable"
        '
        'lblDedAmount
        '
        Me.lblDedAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDedAmount.Location = New System.Drawing.Point(456, 51)
        Me.lblDedAmount.Name = "lblDedAmount"
        Me.lblDedAmount.Size = New System.Drawing.Size(103, 20)
        Me.lblDedAmount.TabIndex = 10
        Me.lblDedAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(411, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Amount"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(394, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(15, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "%"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(329, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Rate"
        '
        'txtDedRemarks
        '
        Me.txtDedRemarks.Location = New System.Drawing.Point(80, 51)
        Me.txtDedRemarks.Name = "txtDedRemarks"
        Me.txtDedRemarks.Size = New System.Drawing.Size(241, 20)
        Me.txtDedRemarks.TabIndex = 6
        '
        'lblDedCodeDec
        '
        Me.lblDedCodeDec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDedCodeDec.Location = New System.Drawing.Point(166, 15)
        Me.lblDedCodeDec.Name = "lblDedCodeDec"
        Me.lblDedCodeDec.Size = New System.Drawing.Size(155, 22)
        Me.lblDedCodeDec.TabIndex = 4
        Me.lblDedCodeDec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mskDedCode
        '
        Me.mskDedCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskDedCode.Location = New System.Drawing.Point(80, 15)
        Me.mskDedCode.Mask = "##"
        Me.mskDedCode.Name = "mskDedCode"
        Me.mskDedCode.Size = New System.Drawing.Size(80, 22)
        Me.mskDedCode.TabIndex = 5
        Me.mskDedCode.Tag = "Enter Account Code"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Remarks"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Account Code"
        '
        'LblTypeValid
        '
        Me.LblTypeValid.BackColor = System.Drawing.Color.PowderBlue
        Me.LblTypeValid.Font = New System.Drawing.Font("Nina", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTypeValid.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LblTypeValid.Location = New System.Drawing.Point(-4, -2)
        Me.LblTypeValid.Name = "LblTypeValid"
        Me.LblTypeValid.Size = New System.Drawing.Size(1182, 52)
        Me.LblTypeValid.TabIndex = 25
        Me.LblTypeValid.Text = "VoucherValidation"
        Me.LblTypeValid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GVHelp)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(371, 605)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'GVHelp
        '
        Me.GVHelp.AllowUserToAddRows = False
        Me.GVHelp.AllowUserToDeleteRows = False
        Me.GVHelp.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.GVHelp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GVHelp.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.GVHelp.Location = New System.Drawing.Point(8, 43)
        Me.GVHelp.Name = "GVHelp"
        Me.GVHelp.ReadOnly = True
        Me.GVHelp.RowHeadersWidth = 20
        Me.GVHelp.Size = New System.Drawing.Size(354, 561)
        Me.GVHelp.StandardTab = True
        Me.GVHelp.TabIndex = 42
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(9, 17)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(353, 20)
        Me.txtSearch.TabIndex = 41
        '
        'vspGrid
        '
        Me.vspGrid.DataSource = Nothing
        Me.vspGrid.Location = New System.Drawing.Point(387, 245)
        Me.vspGrid.Name = "vspGrid"
        Me.vspGrid.OcxState = CType(resources.GetObject("vspGrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.vspGrid.Size = New System.Drawing.Size(791, 298)
        Me.vspGrid.TabIndex = 4
        '
        'frmRecPay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1186, 693)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblTypeValid)
        Me.Controls.Add(Me.GpTaxDed)
        Me.Controls.Add(Me.lblTotAmt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnCode)
        Me.Controls.Add(Me.LBLBalance)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GpBtns)
        Me.Controls.Add(Me.lblBy)
        Me.Controls.Add(Me.lblToolTip)
        Me.Controls.Add(Me.lblCompany)
        Me.Controls.Add(Me.vspGrid)
        Me.Controls.Add(Me.GpData)
        Me.Name = "frmRecPay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.GpData.ResumeLayout(False)
        Me.GpData.PerformLayout()
        Me.GpBtns.ResumeLayout(False)
        Me.GpTaxDed.ResumeLayout(False)
        Me.GpTaxDed.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GVHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vspGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GpData As System.Windows.Forms.GroupBox
    Friend WithEvents txtPurpose As System.Windows.Forms.TextBox
    Friend WithEvents txtBrCode As System.Windows.Forms.TextBox
    Friend WithEvents mskCode As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblRefCode As System.Windows.Forms.Label
    Friend WithEvents dtpVDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblVNo As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblRfCode As System.Windows.Forms.Label
    Friend WithEvents lblBy As System.Windows.Forms.Label
    Friend WithEvents lblToolTip As System.Windows.Forms.Label
    Friend WithEvents lblCompany As System.Windows.Forms.Label
    Friend WithEvents lblBrName As System.Windows.Forms.Label
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LBLBalance As System.Windows.Forms.Label
    Friend WithEvents btnCode As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblTotAmt As System.Windows.Forms.Label
    Friend WithEvents LBLPosted As System.Windows.Forms.Label
    Friend WithEvents GpTaxDed As System.Windows.Forms.GroupBox
    Friend WithEvents txtDedRemarks As System.Windows.Forms.TextBox
    Friend WithEvents lblDedCodeDec As System.Windows.Forms.Label
    Friend WithEvents mskDedCode As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblNetPayable As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblDedAmount As System.Windows.Forms.Label
    Friend WithEvents mskTaxRate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LblTypeValid As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GVHelp As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents vspGrid As AxFPSpreadADO.AxfpSpread
End Class
