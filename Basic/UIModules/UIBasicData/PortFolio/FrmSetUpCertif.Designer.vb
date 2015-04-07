<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSetUpCertif
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSetUpCertif))
        Me.LblTypeValid = New System.Windows.Forms.Label()
        Me.Search = New System.Windows.Forms.GroupBox()
        Me.GVHelp = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.GpData = New System.Windows.Forms.GroupBox()
        Me.cbIssuCertific = New System.Windows.Forms.CheckBox()
        Me.cmbInstuType = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbBranch = New System.Windows.Forms.ComboBox()
        Me.cmbInstitute = New System.Windows.Forms.ComboBox()
        Me.cmbInstituteType = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtsysCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpIssue = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCertificateNo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpMaturityDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNoOfDays = New System.Windows.Forms.TextBox()
        Me.txtAmnt = New System.Windows.Forms.TextBox()
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
        Me.lblBy = New System.Windows.Forms.Label()
        Me.lblToolTip = New System.Windows.Forms.Label()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.Search.SuspendLayout()
        CType(Me.GVHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GpData.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GpBtns.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblTypeValid
        '
        Me.LblTypeValid.BackColor = System.Drawing.Color.PowderBlue
        Me.LblTypeValid.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTypeValid.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LblTypeValid.Location = New System.Drawing.Point(1, -1)
        Me.LblTypeValid.Name = "LblTypeValid"
        Me.LblTypeValid.Size = New System.Drawing.Size(1076, 52)
        Me.LblTypeValid.TabIndex = 36
        Me.LblTypeValid.Text = "Setup Certificate Information"
        Me.LblTypeValid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Search
        '
        Me.Search.Controls.Add(Me.GVHelp)
        Me.Search.Controls.Add(Me.txtSearch)
        Me.Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(8, 54)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(341, 517)
        Me.Search.TabIndex = 38
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
        Me.GVHelp.Size = New System.Drawing.Size(328, 461)
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
        'GpData
        '
        Me.GpData.Controls.Add(Me.cbIssuCertific)
        Me.GpData.Controls.Add(Me.cmbInstuType)
        Me.GpData.Controls.Add(Me.Label2)
        Me.GpData.Controls.Add(Me.cmbBranch)
        Me.GpData.Controls.Add(Me.cmbInstitute)
        Me.GpData.Controls.Add(Me.cmbInstituteType)
        Me.GpData.Controls.Add(Me.Label10)
        Me.GpData.Controls.Add(Me.Label26)
        Me.GpData.Controls.Add(Me.Label3)
        Me.GpData.Controls.Add(Me.txtsysCode)
        Me.GpData.Controls.Add(Me.Label1)
        Me.GpData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpData.Location = New System.Drawing.Point(355, 108)
        Me.GpData.Name = "GpData"
        Me.GpData.Size = New System.Drawing.Size(722, 206)
        Me.GpData.TabIndex = 43
        Me.GpData.TabStop = False
        '
        'cbIssuCertific
        '
        Me.cbIssuCertific.AutoSize = True
        Me.cbIssuCertific.Location = New System.Drawing.Point(111, 172)
        Me.cbIssuCertific.Name = "cbIssuCertific"
        Me.cbIssuCertific.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbIssuCertific.Size = New System.Drawing.Size(163, 20)
        Me.cbIssuCertific.TabIndex = 59
        Me.cbIssuCertific.Text = "Issuance Certificate"
        Me.cbIssuCertific.UseVisualStyleBackColor = True
        '
        'cmbInstuType
        '
        Me.cmbInstuType.FormattingEnabled = True
        Me.cmbInstuType.Location = New System.Drawing.Point(279, 55)
        Me.cmbInstuType.Name = "cmbInstuType"
        Me.cmbInstuType.Size = New System.Drawing.Size(146, 24)
        Me.cmbInstuType.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(221, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Institute"
        '
        'cmbBranch
        '
        Me.cmbBranch.FormattingEnabled = True
        Me.cmbBranch.Location = New System.Drawing.Point(279, 142)
        Me.cmbBranch.Name = "cmbBranch"
        Me.cmbBranch.Size = New System.Drawing.Size(146, 24)
        Me.cmbBranch.TabIndex = 4
        '
        'cmbInstitute
        '
        Me.cmbInstitute.FormattingEnabled = True
        Me.cmbInstitute.Location = New System.Drawing.Point(279, 113)
        Me.cmbInstitute.Name = "cmbInstitute"
        Me.cmbInstitute.Size = New System.Drawing.Size(146, 24)
        Me.cmbInstitute.TabIndex = 3
        '
        'cmbInstituteType
        '
        Me.cmbInstituteType.FormattingEnabled = True
        Me.cmbInstituteType.Location = New System.Drawing.Point(279, 84)
        Me.cmbInstituteType.Name = "cmbInstituteType"
        Me.cmbInstituteType.Size = New System.Drawing.Size(146, 24)
        Me.cmbInstituteType.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(191, 144)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 13)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Branch Name"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(176, 60)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(98, 13)
        Me.Label26.TabIndex = 21
        Me.Label26.Text = "Instrument Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(179, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Institution Type"
        '
        'txtsysCode
        '
        Me.txtsysCode.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtsysCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsysCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsysCode.Location = New System.Drawing.Point(279, 28)
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
        Me.Label1.Location = New System.Drawing.Point(190, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " System Code"
        '
        'dtpIssue
        '
        Me.dtpIssue.CustomFormat = "dd/MM/yyyy"
        Me.dtpIssue.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpIssue.Location = New System.Drawing.Point(279, 81)
        Me.dtpIssue.Name = "dtpIssue"
        Me.dtpIssue.Size = New System.Drawing.Size(146, 20)
        Me.dtpIssue.TabIndex = 7
        Me.dtpIssue.Value = New Date(2015, 3, 30, 15, 11, 43, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(206, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Issue Date"
        '
        'txtCertificateNo
        '
        Me.txtCertificateNo.Location = New System.Drawing.Point(279, 27)
        Me.txtCertificateNo.Name = "txtCertificateNo"
        Me.txtCertificateNo.Size = New System.Drawing.Size(146, 20)
        Me.txtCertificateNo.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(225, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Amount"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(189, 30)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(85, 13)
        Me.Label30.TabIndex = 30
        Me.Label30.Text = "Certificate No"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(198, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "No. Of Days"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpMaturityDate)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtNoOfDays)
        Me.GroupBox1.Controls.Add(Me.txtAmnt)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.dtpIssue)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtCertificateNo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(355, 320)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(722, 210)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Certificate Details"
        '
        'dtpMaturityDate
        '
        Me.dtpMaturityDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpMaturityDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMaturityDate.Location = New System.Drawing.Point(279, 135)
        Me.dtpMaturityDate.Name = "dtpMaturityDate"
        Me.dtpMaturityDate.Size = New System.Drawing.Size(146, 20)
        Me.dtpMaturityDate.TabIndex = 9
        Me.dtpMaturityDate.Value = New Date(2015, 3, 30, 15, 11, 43, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(191, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Maturity Date"
        '
        'txtNoOfDays
        '
        Me.txtNoOfDays.Location = New System.Drawing.Point(279, 108)
        Me.txtNoOfDays.Name = "txtNoOfDays"
        Me.txtNoOfDays.Size = New System.Drawing.Size(146, 20)
        Me.txtNoOfDays.TabIndex = 8
        '
        'txtAmnt
        '
        Me.txtAmnt.Location = New System.Drawing.Point(279, 54)
        Me.txtAmnt.Name = "txtAmnt"
        Me.txtAmnt.Size = New System.Drawing.Size(146, 20)
        Me.txtAmnt.TabIndex = 6
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
        Me.GpBtns.Location = New System.Drawing.Point(355, 54)
        Me.GpBtns.Name = "GpBtns"
        Me.GpBtns.Size = New System.Drawing.Size(722, 58)
        Me.GpBtns.TabIndex = 45
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
        'lblBy
        '
        Me.lblBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBy.Location = New System.Drawing.Point(904, 536)
        Me.lblBy.Name = "lblBy"
        Me.lblBy.Size = New System.Drawing.Size(170, 23)
        Me.lblBy.TabIndex = 48
        '
        'lblToolTip
        '
        Me.lblToolTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblToolTip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToolTip.Location = New System.Drawing.Point(527, 536)
        Me.lblToolTip.Name = "lblToolTip"
        Me.lblToolTip.Size = New System.Drawing.Size(372, 23)
        Me.lblToolTip.TabIndex = 47
        '
        'lblCompany
        '
        Me.lblCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.Location = New System.Drawing.Point(351, 537)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(170, 23)
        Me.lblCompany.TabIndex = 46
        '
        'FrmSetUpCertif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1083, 585)
        Me.Controls.Add(Me.lblBy)
        Me.Controls.Add(Me.lblToolTip)
        Me.Controls.Add(Me.lblCompany)
        Me.Controls.Add(Me.GpBtns)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GpData)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.LblTypeValid)
        Me.Name = "FrmSetUpCertif"
        Me.Text = "Setup Certificate Information"
        Me.Search.ResumeLayout(False)
        Me.Search.PerformLayout()
        CType(Me.GVHelp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GpData.ResumeLayout(False)
        Me.GpData.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GpBtns.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblTypeValid As System.Windows.Forms.Label
    Friend WithEvents Search As System.Windows.Forms.GroupBox
    Friend WithEvents GVHelp As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents GpData As System.Windows.Forms.GroupBox
    Friend WithEvents txtCertificateNo As System.Windows.Forms.TextBox
    Friend WithEvents cmbInstitute As System.Windows.Forms.ComboBox
    Friend WithEvents cmbInstituteType As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtsysCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbBranch As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpIssue As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbInstuType As System.Windows.Forms.ComboBox
    Friend WithEvents cbIssuCertific As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAmnt As System.Windows.Forms.TextBox
    Friend WithEvents txtNoOfDays As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpMaturityDate As System.Windows.Forms.DateTimePicker
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
    Friend WithEvents lblBy As System.Windows.Forms.Label
    Friend WithEvents lblToolTip As System.Windows.Forms.Label
    Friend WithEvents lblCompany As System.Windows.Forms.Label
End Class
