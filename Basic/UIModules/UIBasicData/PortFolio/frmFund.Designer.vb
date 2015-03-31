<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFund
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFund))
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
        Me.txtAccNo = New System.Windows.Forms.TextBox()
        Me.txtBnkAdress = New System.Windows.Forms.TextBox()
        Me.txtSaleLoad = New System.Windows.Forms.TextBox()
        Me.txtMnemonic = New System.Windows.Forms.TextBox()
        Me.txtdescription = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbFundType = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbCompany = New System.Windows.Forms.ComboBox()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtsysCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCostCenter = New System.Windows.Forms.TextBox()
        Me.txtSiteCode = New System.Windows.Forms.TextBox()
        Me.txtdbName = New System.Windows.Forms.TextBox()
        Me.txtCompcode = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtdesciptionGL = New System.Windows.Forms.TextBox()
        Me.txtMnemoGL = New System.Windows.Forms.TextBox()
        Me.txtNameGL = New System.Windows.Forms.TextBox()
        Me.dtGL = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtsysCodeGL = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkBrokerageTFC = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.chkFED = New System.Windows.Forms.CheckBox()
        Me.chkBrokerage = New System.Windows.Forms.CheckBox()
        Me.chkCVT = New System.Windows.Forms.CheckBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtAccruedIntrestTFC = New System.Windows.Forms.CheckBox()
        Me.txtAmortizationTFC = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.chkAcruedIntPIB = New System.Windows.Forms.CheckBox()
        Me.chkAmortizationPIB = New System.Windows.Forms.CheckBox()
        Me.chkBrokeragePIB = New System.Windows.Forms.CheckBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.chkBrokerageTBill = New System.Windows.Forms.CheckBox()
        Me.Search.SuspendLayout()
        CType(Me.GVHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GpBtns.SuspendLayout()
        Me.GpData.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.chkBrokerageTFC.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblTypeValid
        '
        Me.LblTypeValid.BackColor = System.Drawing.Color.PowderBlue
        Me.LblTypeValid.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTypeValid.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LblTypeValid.Location = New System.Drawing.Point(-1, 0)
        Me.LblTypeValid.Name = "LblTypeValid"
        Me.LblTypeValid.Size = New System.Drawing.Size(1096, 52)
        Me.LblTypeValid.TabIndex = 34
        Me.LblTypeValid.Text = "Fund Information"
        Me.LblTypeValid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Search
        '
        Me.Search.Controls.Add(Me.GVHelp)
        Me.Search.Controls.Add(Me.txtSearch)
        Me.Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(6, 55)
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
        Me.GpBtns.Location = New System.Drawing.Point(355, 56)
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
        Me.GpData.Controls.Add(Me.txtAccNo)
        Me.GpData.Controls.Add(Me.txtBnkAdress)
        Me.GpData.Controls.Add(Me.txtSaleLoad)
        Me.GpData.Controls.Add(Me.txtMnemonic)
        Me.GpData.Controls.Add(Me.txtdescription)
        Me.GpData.Controls.Add(Me.txtName)
        Me.GpData.Controls.Add(Me.Label30)
        Me.GpData.Controls.Add(Me.Label10)
        Me.GpData.Controls.Add(Me.cmbFundType)
        Me.GpData.Controls.Add(Me.Label19)
        Me.GpData.Controls.Add(Me.dtpStartDate)
        Me.GpData.Controls.Add(Me.Label12)
        Me.GpData.Controls.Add(Me.Label26)
        Me.GpData.Controls.Add(Me.Label25)
        Me.GpData.Controls.Add(Me.Label2)
        Me.GpData.Controls.Add(Me.cmbCompany)
        Me.GpData.Controls.Add(Me.cmbType)
        Me.GpData.Controls.Add(Me.Label3)
        Me.GpData.Controls.Add(Me.Label5)
        Me.GpData.Controls.Add(Me.Label4)
        Me.GpData.Controls.Add(Me.txtsysCode)
        Me.GpData.Controls.Add(Me.Label1)
        Me.GpData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpData.Location = New System.Drawing.Point(358, 122)
        Me.GpData.Name = "GpData"
        Me.GpData.Size = New System.Drawing.Size(722, 165)
        Me.GpData.TabIndex = 38
        Me.GpData.TabStop = False
        Me.GpData.Text = "Fund Information"
        '
        'txtAccNo
        '
        Me.txtAccNo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtAccNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAccNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccNo.Location = New System.Drawing.Point(98, 137)
        Me.txtAccNo.MaxLength = 3
        Me.txtAccNo.Name = "txtAccNo"
        Me.txtAccNo.Size = New System.Drawing.Size(89, 22)
        Me.txtAccNo.TabIndex = 56
        Me.txtAccNo.Tag = "Enter Description"
        '
        'txtBnkAdress
        '
        Me.txtBnkAdress.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtBnkAdress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBnkAdress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBnkAdress.Location = New System.Drawing.Point(275, 135)
        Me.txtBnkAdress.MaxLength = 3
        Me.txtBnkAdress.Name = "txtBnkAdress"
        Me.txtBnkAdress.Size = New System.Drawing.Size(436, 22)
        Me.txtBnkAdress.TabIndex = 55
        Me.txtBnkAdress.Tag = "Enter Description"
        '
        'txtSaleLoad
        '
        Me.txtSaleLoad.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtSaleLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaleLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaleLoad.Location = New System.Drawing.Point(275, 109)
        Me.txtSaleLoad.MaxLength = 3
        Me.txtSaleLoad.Name = "txtSaleLoad"
        Me.txtSaleLoad.Size = New System.Drawing.Size(131, 22)
        Me.txtSaleLoad.TabIndex = 54
        Me.txtSaleLoad.Tag = "Enter Description"
        '
        'txtMnemonic
        '
        Me.txtMnemonic.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtMnemonic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMnemonic.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMnemonic.Location = New System.Drawing.Point(483, 56)
        Me.txtMnemonic.MaxLength = 3
        Me.txtMnemonic.Name = "txtMnemonic"
        Me.txtMnemonic.Size = New System.Drawing.Size(228, 22)
        Me.txtMnemonic.TabIndex = 53
        Me.txtMnemonic.Tag = "Enter Description"
        '
        'txtdescription
        '
        Me.txtdescription.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtdescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescription.Location = New System.Drawing.Point(97, 81)
        Me.txtdescription.MaxLength = 3
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(309, 22)
        Me.txtdescription.TabIndex = 52
        Me.txtdescription.Tag = "Enter Description"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(97, 56)
        Me.txtName.MaxLength = 3
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(309, 22)
        Me.txtName.TabIndex = 51
        Me.txtName.Tag = "Enter Description"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(21, 86)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(71, 13)
        Me.Label30.TabIndex = 30
        Me.Label30.Text = "Description"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(412, 110)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Fund Type"
        '
        'cmbFundType
        '
        Me.cmbFundType.FormattingEnabled = True
        Me.cmbFundType.Location = New System.Drawing.Point(482, 106)
        Me.cmbFundType.Name = "cmbFundType"
        Me.cmbFundType.Size = New System.Drawing.Size(229, 24)
        Me.cmbFundType.TabIndex = 28
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(209, 115)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 13)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "Sale Load"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartDate.Location = New System.Drawing.Point(97, 109)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(95, 22)
        Me.dtpStartDate.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(58, 112)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Date"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(53, 63)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(39, 13)
        Me.Label26.TabIndex = 21
        Me.Label26.Text = "Name"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(421, 30)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(58, 13)
        Me.Label25.TabIndex = 20
        Me.Label25.Text = "Company"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(152, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Type"
        '
        'cmbCompany
        '
        Me.cmbCompany.FormattingEnabled = True
        Me.cmbCompany.Location = New System.Drawing.Point(482, 27)
        Me.cmbCompany.Name = "cmbCompany"
        Me.cmbCompany.Size = New System.Drawing.Size(230, 24)
        Me.cmbCompany.TabIndex = 18
        '
        'cmbType
        '
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Location = New System.Drawing.Point(193, 28)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(213, 24)
        Me.cmbType.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Account #"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(195, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Bank Adress"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(415, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Mnemonic"
        '
        'txtsysCode
        '
        Me.txtsysCode.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtsysCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsysCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsysCode.Location = New System.Drawing.Point(97, 31)
        Me.txtsysCode.MaxLength = 3
        Me.txtsysCode.Name = "txtsysCode"
        Me.txtsysCode.Size = New System.Drawing.Size(46, 22)
        Me.txtsysCode.TabIndex = 0
        Me.txtsysCode.Tag = "Enter Description"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " System Code"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCostCenter)
        Me.GroupBox1.Controls.Add(Me.txtSiteCode)
        Me.GroupBox1.Controls.Add(Me.txtdbName)
        Me.GroupBox1.Controls.Add(Me.txtCompcode)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(358, 299)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(722, 64)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GL Configuration Params"
        '
        'txtCostCenter
        '
        Me.txtCostCenter.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtCostCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCostCenter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostCenter.Location = New System.Drawing.Point(579, 32)
        Me.txtCostCenter.MaxLength = 3
        Me.txtCostCenter.Name = "txtCostCenter"
        Me.txtCostCenter.Size = New System.Drawing.Size(132, 22)
        Me.txtCostCenter.TabIndex = 55
        Me.txtCostCenter.Tag = "Enter Description"
        '
        'txtSiteCode
        '
        Me.txtSiteCode.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtSiteCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSiteCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSiteCode.Location = New System.Drawing.Point(402, 33)
        Me.txtSiteCode.MaxLength = 3
        Me.txtSiteCode.Name = "txtSiteCode"
        Me.txtSiteCode.Size = New System.Drawing.Size(94, 22)
        Me.txtSiteCode.TabIndex = 54
        Me.txtSiteCode.Tag = "Enter Description"
        '
        'txtdbName
        '
        Me.txtdbName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtdbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdbName.Location = New System.Drawing.Point(209, 32)
        Me.txtdbName.MaxLength = 3
        Me.txtdbName.Name = "txtdbName"
        Me.txtdbName.Size = New System.Drawing.Size(116, 22)
        Me.txtdbName.TabIndex = 53
        Me.txtdbName.Tag = "Enter Description"
        '
        'txtCompcode
        '
        Me.txtCompcode.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtCompcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCompcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompcode.Location = New System.Drawing.Point(97, 30)
        Me.txtCompcode.MaxLength = 3
        Me.txtCompcode.Name = "txtCompcode"
        Me.txtCompcode.Size = New System.Drawing.Size(45, 22)
        Me.txtCompcode.TabIndex = 52
        Me.txtCompcode.Tag = "Enter Description"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(502, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Cost Center"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(147, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "DB Name"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(329, 39)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 13)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Site Code"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(21, 37)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Comp-Code"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtdesciptionGL)
        Me.GroupBox2.Controls.Add(Me.txtMnemoGL)
        Me.GroupBox2.Controls.Add(Me.txtNameGL)
        Me.GroupBox2.Controls.Add(Me.dtGL)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.txtsysCodeGL)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(358, 360)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(722, 109)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        '
        'txtdesciptionGL
        '
        Me.txtdesciptionGL.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtdesciptionGL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdesciptionGL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesciptionGL.Location = New System.Drawing.Point(397, 69)
        Me.txtdesciptionGL.MaxLength = 3
        Me.txtdesciptionGL.Name = "txtdesciptionGL"
        Me.txtdesciptionGL.Size = New System.Drawing.Size(309, 22)
        Me.txtdesciptionGL.TabIndex = 54
        Me.txtdesciptionGL.Tag = "Enter Description"
        '
        'txtMnemoGL
        '
        Me.txtMnemoGL.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtMnemoGL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMnemoGL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMnemoGL.Location = New System.Drawing.Point(397, 41)
        Me.txtMnemoGL.MaxLength = 3
        Me.txtMnemoGL.Name = "txtMnemoGL"
        Me.txtMnemoGL.Size = New System.Drawing.Size(309, 22)
        Me.txtMnemoGL.TabIndex = 53
        Me.txtMnemoGL.Tag = "Enter Description"
        '
        'txtNameGL
        '
        Me.txtNameGL.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtNameGL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNameGL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameGL.Location = New System.Drawing.Point(97, 46)
        Me.txtNameGL.MaxLength = 3
        Me.txtNameGL.Name = "txtNameGL"
        Me.txtNameGL.Size = New System.Drawing.Size(228, 22)
        Me.txtNameGL.TabIndex = 52
        Me.txtNameGL.Tag = "Enter Description"
        '
        'dtGL
        '
        Me.dtGL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtGL.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtGL.Location = New System.Drawing.Point(97, 74)
        Me.dtGL.Name = "dtGL"
        Me.dtGL.Size = New System.Drawing.Size(91, 22)
        Me.dtGL.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(58, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Date"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(320, 74)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(71, 13)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "Description"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(53, 51)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(39, 13)
        Me.Label18.TabIndex = 14
        Me.Label18.Text = "Name"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(327, 50)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(64, 13)
        Me.Label23.TabIndex = 7
        Me.Label23.Text = "Mnemonic"
        '
        'txtsysCodeGL
        '
        Me.txtsysCodeGL.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtsysCodeGL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsysCodeGL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsysCodeGL.Location = New System.Drawing.Point(97, 21)
        Me.txtsysCodeGL.MaxLength = 3
        Me.txtsysCodeGL.Name = "txtsysCodeGL"
        Me.txtsysCodeGL.Size = New System.Drawing.Size(46, 22)
        Me.txtsysCodeGL.TabIndex = 0
        Me.txtsysCodeGL.Tag = "Enter Description"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(12, 25)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(80, 13)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "System Code"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkBrokerageTFC)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(358, 475)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(722, 116)
        Me.GroupBox3.TabIndex = 41
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cost Params"
        '
        'chkBrokerageTFC
        '
        Me.chkBrokerageTFC.Controls.Add(Me.TabPage1)
        Me.chkBrokerageTFC.Controls.Add(Me.TabPage2)
        Me.chkBrokerageTFC.Controls.Add(Me.TabPage3)
        Me.chkBrokerageTFC.Controls.Add(Me.TabPage4)
        Me.chkBrokerageTFC.Controls.Add(Me.TabPage5)
        Me.chkBrokerageTFC.Location = New System.Drawing.Point(14, 24)
        Me.chkBrokerageTFC.Name = "chkBrokerageTFC"
        Me.chkBrokerageTFC.SelectedIndex = 0
        Me.chkBrokerageTFC.Size = New System.Drawing.Size(702, 78)
        Me.chkBrokerageTFC.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(694, 49)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Share"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.chkFED)
        Me.TabPage2.Controls.Add(Me.chkBrokerage)
        Me.TabPage2.Controls.Add(Me.chkCVT)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(694, 49)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Furure"
        '
        'chkFED
        '
        Me.chkFED.AutoSize = True
        Me.chkFED.Location = New System.Drawing.Point(359, 18)
        Me.chkFED.Name = "chkFED"
        Me.chkFED.Size = New System.Drawing.Size(57, 20)
        Me.chkFED.TabIndex = 2
        Me.chkFED.Text = "FED"
        Me.chkFED.UseVisualStyleBackColor = True
        '
        'chkBrokerage
        '
        Me.chkBrokerage.AutoSize = True
        Me.chkBrokerage.Location = New System.Drawing.Point(242, 18)
        Me.chkBrokerage.Name = "chkBrokerage"
        Me.chkBrokerage.Size = New System.Drawing.Size(86, 20)
        Me.chkBrokerage.TabIndex = 1
        Me.chkBrokerage.Text = "Brokage"
        Me.chkBrokerage.UseVisualStyleBackColor = True
        '
        'chkCVT
        '
        Me.chkCVT.AutoSize = True
        Me.chkCVT.Location = New System.Drawing.Point(158, 18)
        Me.chkCVT.Name = "chkCVT"
        Me.chkCVT.Size = New System.Drawing.Size(57, 20)
        Me.chkCVT.TabIndex = 0
        Me.chkCVT.Text = "CVT"
        Me.chkCVT.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.txtAccruedIntrestTFC)
        Me.TabPage3.Controls.Add(Me.txtAmortizationTFC)
        Me.TabPage3.Controls.Add(Me.CheckBox6)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(694, 49)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TFC"
        '
        'txtAccruedIntrestTFC
        '
        Me.txtAccruedIntrestTFC.AutoSize = True
        Me.txtAccruedIntrestTFC.Location = New System.Drawing.Point(139, 15)
        Me.txtAccruedIntrestTFC.Name = "txtAccruedIntrestTFC"
        Me.txtAccruedIntrestTFC.Size = New System.Drawing.Size(278, 20)
        Me.txtAccruedIntrestTFC.TabIndex = 5
        Me.txtAccruedIntrestTFC.Text = "Accrued Interest impact Amortization"
        Me.txtAccruedIntrestTFC.UseVisualStyleBackColor = True
        '
        'txtAmortizationTFC
        '
        Me.txtAmortizationTFC.AutoSize = True
        Me.txtAmortizationTFC.Location = New System.Drawing.Point(463, 15)
        Me.txtAmortizationTFC.Name = "txtAmortizationTFC"
        Me.txtAmortizationTFC.Size = New System.Drawing.Size(112, 20)
        Me.txtAmortizationTFC.TabIndex = 4
        Me.txtAmortizationTFC.Text = "Amortization"
        Me.txtAmortizationTFC.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(6, 15)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(104, 20)
        Me.CheckBox6.TabIndex = 3
        Me.CheckBox6.Text = "Brokerage "
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage4.Controls.Add(Me.chkAcruedIntPIB)
        Me.TabPage4.Controls.Add(Me.chkAmortizationPIB)
        Me.TabPage4.Controls.Add(Me.chkBrokeragePIB)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(694, 49)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "PIB"
        '
        'chkAcruedIntPIB
        '
        Me.chkAcruedIntPIB.AutoSize = True
        Me.chkAcruedIntPIB.Location = New System.Drawing.Point(171, 16)
        Me.chkAcruedIntPIB.Name = "chkAcruedIntPIB"
        Me.chkAcruedIntPIB.Size = New System.Drawing.Size(278, 20)
        Me.chkAcruedIntPIB.TabIndex = 8
        Me.chkAcruedIntPIB.Text = "Accrued Interest impact Amortization"
        Me.chkAcruedIntPIB.UseVisualStyleBackColor = True
        '
        'chkAmortizationPIB
        '
        Me.chkAmortizationPIB.AutoSize = True
        Me.chkAmortizationPIB.Location = New System.Drawing.Point(495, 16)
        Me.chkAmortizationPIB.Name = "chkAmortizationPIB"
        Me.chkAmortizationPIB.Size = New System.Drawing.Size(112, 20)
        Me.chkAmortizationPIB.TabIndex = 7
        Me.chkAmortizationPIB.Text = "Amortization"
        Me.chkAmortizationPIB.UseVisualStyleBackColor = True
        '
        'chkBrokeragePIB
        '
        Me.chkBrokeragePIB.AutoSize = True
        Me.chkBrokeragePIB.Location = New System.Drawing.Point(38, 16)
        Me.chkBrokeragePIB.Name = "chkBrokeragePIB"
        Me.chkBrokeragePIB.Size = New System.Drawing.Size(104, 20)
        Me.chkBrokeragePIB.TabIndex = 6
        Me.chkBrokeragePIB.Text = "Brokerage "
        Me.chkBrokeragePIB.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage5.Controls.Add(Me.chkBrokerageTBill)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(694, 49)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "TBill"
        '
        'chkBrokerageTBill
        '
        Me.chkBrokerageTBill.AutoSize = True
        Me.chkBrokerageTBill.Location = New System.Drawing.Point(164, 16)
        Me.chkBrokerageTBill.Name = "chkBrokerageTBill"
        Me.chkBrokerageTBill.Size = New System.Drawing.Size(104, 20)
        Me.chkBrokerageTBill.TabIndex = 6
        Me.chkBrokerageTBill.Text = "Brokerage "
        Me.chkBrokerageTBill.UseVisualStyleBackColor = True
        '
        'frmFund
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1091, 605)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GpData)
        Me.Controls.Add(Me.GpBtns)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.LblTypeValid)
        Me.Name = "frmFund"
        Me.Text = "Fund Information"
        Me.Search.ResumeLayout(False)
        Me.Search.PerformLayout()
        CType(Me.GVHelp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GpBtns.ResumeLayout(False)
        Me.GpData.ResumeLayout(False)
        Me.GpData.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.chkBrokerageTFC.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtsysCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtsysCodeGL As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbCompany As System.Windows.Forms.ComboBox
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbFundType As System.Windows.Forms.ComboBox
    Friend WithEvents dtGL As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkBrokerageTFC As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents chkFED As System.Windows.Forms.CheckBox
    Friend WithEvents chkBrokerage As System.Windows.Forms.CheckBox
    Friend WithEvents chkCVT As System.Windows.Forms.CheckBox
    Friend WithEvents txtAccruedIntrestTFC As System.Windows.Forms.CheckBox
    Friend WithEvents txtAmortizationTFC As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents chkAcruedIntPIB As System.Windows.Forms.CheckBox
    Friend WithEvents chkAmortizationPIB As System.Windows.Forms.CheckBox
    Friend WithEvents chkBrokeragePIB As System.Windows.Forms.CheckBox
    Friend WithEvents chkBrokerageTBill As System.Windows.Forms.CheckBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtAccNo As System.Windows.Forms.TextBox
    Friend WithEvents txtBnkAdress As System.Windows.Forms.TextBox
    Friend WithEvents txtSaleLoad As System.Windows.Forms.TextBox
    Friend WithEvents txtMnemonic As System.Windows.Forms.TextBox
    Friend WithEvents txtdescription As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtCostCenter As System.Windows.Forms.TextBox
    Friend WithEvents txtSiteCode As System.Windows.Forms.TextBox
    Friend WithEvents txtdbName As System.Windows.Forms.TextBox
    Friend WithEvents txtCompcode As System.Windows.Forms.TextBox
    Friend WithEvents txtdesciptionGL As System.Windows.Forms.TextBox
    Friend WithEvents txtMnemoGL As System.Windows.Forms.TextBox
    Friend WithEvents txtNameGL As System.Windows.Forms.TextBox
End Class
