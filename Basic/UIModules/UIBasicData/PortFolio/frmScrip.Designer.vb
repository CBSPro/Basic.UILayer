<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScrip
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScrip))
        Me.LblTypeValid = New System.Windows.Forms.Label()
        Me.Search = New System.Windows.Forms.GroupBox()
        Me.GVHelp = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.GpBtns = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnBottom = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnTop = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnPost = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GpData = New System.Windows.Forms.GroupBox()
        Me.txtSecurityCode = New System.Windows.Forms.TextBox()
        Me.txtCompCode = New System.Windows.Forms.TextBox()
        Me.txtAuthorizeCapital = New System.Windows.Forms.TextBox()
        Me.txtPaidUpCapital = New System.Windows.Forms.TextBox()
        Me.txtFaceValue = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtSymbol = New System.Windows.Forms.TextBox()
        Me.chkDelisted = New System.Windows.Forms.CheckBox()
        Me.chkTransactionReport = New System.Windows.Forms.CheckBox()
        Me.chkListedinstock = New System.Windows.Forms.CheckBox()
        Me.chkFutureTrade = New System.Windows.Forms.CheckBox()
        Me.chkCDCelig = New System.Windows.Forms.CheckBox()
        Me.chkGrpOfcomp = New System.Windows.Forms.CheckBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpDelistedDate = New System.Windows.Forms.DateTimePicker()
        Me.cmbGroupofCompany = New System.Windows.Forms.ComboBox()
        Me.CmbSector = New System.Windows.Forms.ComboBox()
        Me.cmbSystemCode = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LBLPosted = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtsysCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Search.SuspendLayout()
        CType(Me.GVHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GpBtns.SuspendLayout()
        Me.GpData.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblTypeValid
        '
        Me.LblTypeValid.BackColor = System.Drawing.Color.PowderBlue
        Me.LblTypeValid.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTypeValid.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LblTypeValid.Location = New System.Drawing.Point(1, 0)
        Me.LblTypeValid.Name = "LblTypeValid"
        Me.LblTypeValid.Size = New System.Drawing.Size(1096, 52)
        Me.LblTypeValid.TabIndex = 34
        Me.LblTypeValid.Text = "Scrip"
        Me.LblTypeValid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Search
        '
        Me.Search.Controls.Add(Me.GVHelp)
        Me.Search.Controls.Add(Me.txtSearch)
        Me.Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(9, 54)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(341, 546)
        Me.Search.TabIndex = 36
        Me.Search.TabStop = False
        Me.Search.Text = "Search"
        '
        'GVHelp
        '
        Me.GVHelp.AllowUserToAddRows = False
        Me.GVHelp.AllowUserToDeleteRows = False
        Me.GVHelp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GVHelp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GVHelp.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.GVHelp.Location = New System.Drawing.Point(6, 45)
        Me.GVHelp.Name = "GVHelp"
        Me.GVHelp.ReadOnly = True
        Me.GVHelp.RowHeadersWidth = 20
        Me.GVHelp.Size = New System.Drawing.Size(328, 491)
        Me.GVHelp.StandardTab = True
        Me.GVHelp.TabIndex = 43
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(7, 19)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(327, 20)
        Me.txtSearch.TabIndex = 41
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
        Me.GpBtns.Location = New System.Drawing.Point(356, 54)
        Me.GpBtns.Name = "GpBtns"
        Me.GpBtns.Size = New System.Drawing.Size(722, 58)
        Me.GpBtns.TabIndex = 37
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
        Me.btnCancel.TabIndex = 5
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
        'GpData
        '
        Me.GpData.Controls.Add(Me.txtSecurityCode)
        Me.GpData.Controls.Add(Me.txtCompCode)
        Me.GpData.Controls.Add(Me.txtAuthorizeCapital)
        Me.GpData.Controls.Add(Me.txtPaidUpCapital)
        Me.GpData.Controls.Add(Me.txtFaceValue)
        Me.GpData.Controls.Add(Me.txtDescription)
        Me.GpData.Controls.Add(Me.txtName)
        Me.GpData.Controls.Add(Me.txtSymbol)
        Me.GpData.Controls.Add(Me.chkDelisted)
        Me.GpData.Controls.Add(Me.chkTransactionReport)
        Me.GpData.Controls.Add(Me.chkListedinstock)
        Me.GpData.Controls.Add(Me.chkFutureTrade)
        Me.GpData.Controls.Add(Me.chkCDCelig)
        Me.GpData.Controls.Add(Me.chkGrpOfcomp)
        Me.GpData.Controls.Add(Me.Label18)
        Me.GpData.Controls.Add(Me.Label17)
        Me.GpData.Controls.Add(Me.Label16)
        Me.GpData.Controls.Add(Me.Label15)
        Me.GpData.Controls.Add(Me.Label14)
        Me.GpData.Controls.Add(Me.Label13)
        Me.GpData.Controls.Add(Me.Label12)
        Me.GpData.Controls.Add(Me.Label11)
        Me.GpData.Controls.Add(Me.dtpDelistedDate)
        Me.GpData.Controls.Add(Me.cmbGroupofCompany)
        Me.GpData.Controls.Add(Me.CmbSector)
        Me.GpData.Controls.Add(Me.cmbSystemCode)
        Me.GpData.Controls.Add(Me.Label3)
        Me.GpData.Controls.Add(Me.Label2)
        Me.GpData.Controls.Add(Me.LBLPosted)
        Me.GpData.Controls.Add(Me.Label4)
        Me.GpData.Controls.Add(Me.txtsysCode)
        Me.GpData.Controls.Add(Me.Label1)
        Me.GpData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpData.Location = New System.Drawing.Point(359, 118)
        Me.GpData.Name = "GpData"
        Me.GpData.Size = New System.Drawing.Size(722, 482)
        Me.GpData.TabIndex = 38
        Me.GpData.TabStop = False
        '
        'txtSecurityCode
        '
        Me.txtSecurityCode.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtSecurityCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSecurityCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecurityCode.Location = New System.Drawing.Point(152, 309)
        Me.txtSecurityCode.MaxLength = 3
        Me.txtSecurityCode.Name = "txtSecurityCode"
        Me.txtSecurityCode.Size = New System.Drawing.Size(95, 22)
        Me.txtSecurityCode.TabIndex = 59
        Me.txtSecurityCode.Tag = "Enter Description"
        '
        'txtCompCode
        '
        Me.txtCompCode.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtCompCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCompCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompCode.Location = New System.Drawing.Point(152, 282)
        Me.txtCompCode.MaxLength = 3
        Me.txtCompCode.Name = "txtCompCode"
        Me.txtCompCode.Size = New System.Drawing.Size(95, 22)
        Me.txtCompCode.TabIndex = 58
        Me.txtCompCode.Tag = "Enter Description"
        '
        'txtAuthorizeCapital
        '
        Me.txtAuthorizeCapital.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtAuthorizeCapital.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAuthorizeCapital.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthorizeCapital.Location = New System.Drawing.Point(152, 226)
        Me.txtAuthorizeCapital.MaxLength = 3
        Me.txtAuthorizeCapital.Name = "txtAuthorizeCapital"
        Me.txtAuthorizeCapital.Size = New System.Drawing.Size(95, 22)
        Me.txtAuthorizeCapital.TabIndex = 57
        Me.txtAuthorizeCapital.Tag = "Enter Description"
        '
        'txtPaidUpCapital
        '
        Me.txtPaidUpCapital.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtPaidUpCapital.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPaidUpCapital.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaidUpCapital.Location = New System.Drawing.Point(152, 190)
        Me.txtPaidUpCapital.MaxLength = 3
        Me.txtPaidUpCapital.Name = "txtPaidUpCapital"
        Me.txtPaidUpCapital.Size = New System.Drawing.Size(95, 22)
        Me.txtPaidUpCapital.TabIndex = 56
        Me.txtPaidUpCapital.Tag = "Enter Description"
        '
        'txtFaceValue
        '
        Me.txtFaceValue.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtFaceValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFaceValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFaceValue.Location = New System.Drawing.Point(152, 158)
        Me.txtFaceValue.MaxLength = 3
        Me.txtFaceValue.Name = "txtFaceValue"
        Me.txtFaceValue.Size = New System.Drawing.Size(95, 22)
        Me.txtFaceValue.TabIndex = 55
        Me.txtFaceValue.Tag = "Enter Description"
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(152, 368)
        Me.txtDescription.MaxLength = 3
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(538, 22)
        Me.txtDescription.TabIndex = 54
        Me.txtDescription.Tag = "Enter Description"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(152, 102)
        Me.txtName.MaxLength = 3
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(309, 22)
        Me.txtName.TabIndex = 53
        Me.txtName.Tag = "Enter Description"
        '
        'txtSymbol
        '
        Me.txtSymbol.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtSymbol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSymbol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSymbol.Location = New System.Drawing.Point(152, 72)
        Me.txtSymbol.MaxLength = 3
        Me.txtSymbol.Name = "txtSymbol"
        Me.txtSymbol.Size = New System.Drawing.Size(309, 22)
        Me.txtSymbol.TabIndex = 52
        Me.txtSymbol.Tag = "Enter Description"
        '
        'chkDelisted
        '
        Me.chkDelisted.AutoSize = True
        Me.chkDelisted.Location = New System.Drawing.Point(527, 335)
        Me.chkDelisted.Name = "chkDelisted"
        Me.chkDelisted.Size = New System.Drawing.Size(85, 20)
        Me.chkDelisted.TabIndex = 41
        Me.chkDelisted.Text = "Delisted"
        Me.chkDelisted.UseVisualStyleBackColor = True
        '
        'chkTransactionReport
        '
        Me.chkTransactionReport.AutoSize = True
        Me.chkTransactionReport.Location = New System.Drawing.Point(527, 287)
        Me.chkTransactionReport.Name = "chkTransactionReport"
        Me.chkTransactionReport.Size = New System.Drawing.Size(181, 20)
        Me.chkTransactionReport.TabIndex = 40
        Me.chkTransactionReport.Text = "Transaction Reporting"
        Me.chkTransactionReport.UseVisualStyleBackColor = True
        '
        'chkListedinstock
        '
        Me.chkListedinstock.AutoSize = True
        Me.chkListedinstock.Location = New System.Drawing.Point(527, 256)
        Me.chkListedinstock.Name = "chkListedinstock"
        Me.chkListedinstock.Size = New System.Drawing.Size(197, 20)
        Me.chkListedinstock.TabIndex = 39
        Me.chkListedinstock.Text = "Listed in stock exchange"
        Me.chkListedinstock.UseVisualStyleBackColor = True
        '
        'chkFutureTrade
        '
        Me.chkFutureTrade.AutoSize = True
        Me.chkFutureTrade.Location = New System.Drawing.Point(527, 224)
        Me.chkFutureTrade.Name = "chkFutureTrade"
        Me.chkFutureTrade.Size = New System.Drawing.Size(116, 20)
        Me.chkFutureTrade.TabIndex = 38
        Me.chkFutureTrade.Text = "Future Trade"
        Me.chkFutureTrade.UseVisualStyleBackColor = True
        '
        'chkCDCelig
        '
        Me.chkCDCelig.AutoSize = True
        Me.chkCDCelig.Location = New System.Drawing.Point(527, 193)
        Me.chkCDCelig.Name = "chkCDCelig"
        Me.chkCDCelig.Size = New System.Drawing.Size(115, 20)
        Me.chkCDCelig.TabIndex = 37
        Me.chkCDCelig.Text = "CDC Eligible"
        Me.chkCDCelig.UseVisualStyleBackColor = True
        '
        'chkGrpOfcomp
        '
        Me.chkGrpOfcomp.AutoSize = True
        Me.chkGrpOfcomp.Location = New System.Drawing.Point(527, 161)
        Me.chkGrpOfcomp.Name = "chkGrpOfcomp"
        Me.chkGrpOfcomp.Size = New System.Drawing.Size(155, 20)
        Me.chkGrpOfcomp.TabIndex = 36
        Me.chkGrpOfcomp.Text = "Group of Company"
        Me.chkGrpOfcomp.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(75, 372)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 13)
        Me.Label18.TabIndex = 35
        Me.Label18.Text = "Description"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(62, 344)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(84, 13)
        Me.Label17.TabIndex = 34
        Me.Label17.Text = "Delisted Date"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(60, 318)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 13)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "Security Code"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(55, 289)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 13)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Comapny Code"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(35, 257)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(111, 13)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Group of Company"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(75, 161)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Face Value"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(51, 194)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Paid Up Capital"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(36, 226)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Authorized Capital"
        '
        'dtpDelistedDate
        '
        Me.dtpDelistedDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDelistedDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDelistedDate.Location = New System.Drawing.Point(152, 340)
        Me.dtpDelistedDate.Name = "dtpDelistedDate"
        Me.dtpDelistedDate.Size = New System.Drawing.Size(95, 22)
        Me.dtpDelistedDate.TabIndex = 26
        '
        'cmbGroupofCompany
        '
        Me.cmbGroupofCompany.FormattingEnabled = True
        Me.cmbGroupofCompany.Location = New System.Drawing.Point(152, 252)
        Me.cmbGroupofCompany.Name = "cmbGroupofCompany"
        Me.cmbGroupofCompany.Size = New System.Drawing.Size(230, 24)
        Me.cmbGroupofCompany.TabIndex = 23
        '
        'CmbSector
        '
        Me.CmbSector.FormattingEnabled = True
        Me.CmbSector.Location = New System.Drawing.Point(152, 128)
        Me.CmbSector.Name = "CmbSector"
        Me.CmbSector.Size = New System.Drawing.Size(230, 24)
        Me.CmbSector.TabIndex = 20
        '
        'cmbSystemCode
        '
        Me.cmbSystemCode.FormattingEnabled = True
        Me.cmbSystemCode.Location = New System.Drawing.Point(152, 39)
        Me.cmbSystemCode.Name = "cmbSystemCode"
        Me.cmbSystemCode.Size = New System.Drawing.Size(213, 24)
        Me.cmbSystemCode.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(102, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Sector"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(99, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Symbol"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LBLPosted
        '
        Me.LBLPosted.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPosted.ForeColor = System.Drawing.Color.Red
        Me.LBLPosted.Location = New System.Drawing.Point(575, 39)
        Me.LBLPosted.Name = "LBLPosted"
        Me.LBLPosted.Size = New System.Drawing.Size(137, 42)
        Me.LBLPosted.TabIndex = 13
        Me.LBLPosted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(107, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Name"
        '
        'txtsysCode
        '
        Me.txtsysCode.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtsysCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsysCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsysCode.Location = New System.Drawing.Point(152, 39)
        Me.txtsysCode.MaxLength = 3
        Me.txtsysCode.Name = "txtsysCode"
        Me.txtsysCode.Size = New System.Drawing.Size(80, 22)
        Me.txtsysCode.TabIndex = 0
        Me.txtsysCode.Tag = "Enter Description"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "System Code"
        '
        'frmScrip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1097, 606)
        Me.Controls.Add(Me.GpData)
        Me.Controls.Add(Me.GpBtns)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.LblTypeValid)
        Me.Name = "frmScrip"
        Me.Text = "Scrip"
        Me.Search.ResumeLayout(False)
        Me.Search.PerformLayout()
        CType(Me.GVHelp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GpBtns.ResumeLayout(False)
        Me.GpData.ResumeLayout(False)
        Me.GpData.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblTypeValid As System.Windows.Forms.Label
    Friend WithEvents Search As System.Windows.Forms.GroupBox
    Friend WithEvents GVHelp As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
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
    Friend WithEvents GpData As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LBLPosted As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtsysCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbGroupofCompany As System.Windows.Forms.ComboBox
    Friend WithEvents CmbSector As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSystemCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpDelistedDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkDelisted As System.Windows.Forms.CheckBox
    Friend WithEvents chkTransactionReport As System.Windows.Forms.CheckBox
    Friend WithEvents chkListedinstock As System.Windows.Forms.CheckBox
    Friend WithEvents chkFutureTrade As System.Windows.Forms.CheckBox
    Friend WithEvents chkCDCelig As System.Windows.Forms.CheckBox
    Friend WithEvents chkGrpOfcomp As System.Windows.Forms.CheckBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtSymbol As System.Windows.Forms.TextBox
    Friend WithEvents txtSecurityCode As System.Windows.Forms.TextBox
    Friend WithEvents txtCompCode As System.Windows.Forms.TextBox
    Friend WithEvents txtAuthorizeCapital As System.Windows.Forms.TextBox
    Friend WithEvents txtPaidUpCapital As System.Windows.Forms.TextBox
    Friend WithEvents txtFaceValue As System.Windows.Forms.TextBox
End Class
