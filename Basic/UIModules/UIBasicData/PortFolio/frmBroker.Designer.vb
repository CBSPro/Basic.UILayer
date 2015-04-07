<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBroker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBroker))
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
        Me.txtMnemo = New System.Windows.Forms.TextBox()
        Me.txtBrokerCode = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtNCSS = New System.Windows.Forms.TextBox()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtIAS = New System.Windows.Forms.TextBox()
        Me.txtCFS = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtAdress = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbDefine = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtsysCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.fpgrid1 = New AxFPSpreadADO.AxfpSpread()
        Me.cmb2 = New System.Windows.Forms.ComboBox()
        Me.cmb1 = New System.Windows.Forms.ComboBox()
        Me.radiobtn2 = New System.Windows.Forms.RadioButton()
        Me.radiobtn1 = New System.Windows.Forms.RadioButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.fpgrid2 = New AxFPSpreadADO.AxfpSpread()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.fpgrid3 = New AxFPSpreadADO.AxfpSpread()
        Me.lblBy = New System.Windows.Forms.Label()
        Me.lblToolTip = New System.Windows.Forms.Label()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.Search.SuspendLayout()
        CType(Me.GVHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GpBtns.SuspendLayout()
        Me.GpData.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.fpgrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.fpgrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.fpgrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTypeValid
        '
        Me.LblTypeValid.BackColor = System.Drawing.Color.PowderBlue
        Me.LblTypeValid.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTypeValid.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LblTypeValid.Location = New System.Drawing.Point(1, -1)
        Me.LblTypeValid.Name = "LblTypeValid"
        Me.LblTypeValid.Size = New System.Drawing.Size(1096, 52)
        Me.LblTypeValid.TabIndex = 35
        Me.LblTypeValid.Text = "Broker Information"
        Me.LblTypeValid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Search
        '
        Me.Search.Controls.Add(Me.GVHelp)
        Me.Search.Controls.Add(Me.txtSearch)
        Me.Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(8, 54)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(341, 546)
        Me.Search.TabIndex = 37
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
        Me.GpBtns.Location = New System.Drawing.Point(355, 54)
        Me.GpBtns.Name = "GpBtns"
        Me.GpBtns.Size = New System.Drawing.Size(722, 58)
        Me.GpBtns.TabIndex = 38
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
        Me.GpData.Controls.Add(Me.txtMnemo)
        Me.GpData.Controls.Add(Me.txtBrokerCode)
        Me.GpData.Controls.Add(Me.txtDescription)
        Me.GpData.Controls.Add(Me.txtNCSS)
        Me.GpData.Controls.Add(Me.txtFax)
        Me.GpData.Controls.Add(Me.txtEmail)
        Me.GpData.Controls.Add(Me.txtIAS)
        Me.GpData.Controls.Add(Me.txtCFS)
        Me.GpData.Controls.Add(Me.txtPhone)
        Me.GpData.Controls.Add(Me.txtAdress)
        Me.GpData.Controls.Add(Me.txtName)
        Me.GpData.Controls.Add(Me.Label16)
        Me.GpData.Controls.Add(Me.Label11)
        Me.GpData.Controls.Add(Me.CheckBox4)
        Me.GpData.Controls.Add(Me.CheckBox3)
        Me.GpData.Controls.Add(Me.CheckBox2)
        Me.GpData.Controls.Add(Me.CheckBox1)
        Me.GpData.Controls.Add(Me.Label9)
        Me.GpData.Controls.Add(Me.Label30)
        Me.GpData.Controls.Add(Me.Label10)
        Me.GpData.Controls.Add(Me.cmbDefine)
        Me.GpData.Controls.Add(Me.Label19)
        Me.GpData.Controls.Add(Me.Label12)
        Me.GpData.Controls.Add(Me.Label26)
        Me.GpData.Controls.Add(Me.Label2)
        Me.GpData.Controls.Add(Me.Label3)
        Me.GpData.Controls.Add(Me.Label5)
        Me.GpData.Controls.Add(Me.Label4)
        Me.GpData.Controls.Add(Me.txtsysCode)
        Me.GpData.Controls.Add(Me.Label1)
        Me.GpData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpData.Location = New System.Drawing.Point(363, 118)
        Me.GpData.Name = "GpData"
        Me.GpData.Size = New System.Drawing.Size(714, 251)
        Me.GpData.TabIndex = 39
        Me.GpData.TabStop = False
        '
        'txtMnemo
        '
        Me.txtMnemo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtMnemo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMnemo.Location = New System.Drawing.Point(513, 30)
        Me.txtMnemo.Name = "txtMnemo"
        Me.txtMnemo.Size = New System.Drawing.Size(178, 22)
        Me.txtMnemo.TabIndex = 2
        '
        'txtBrokerCode
        '
        Me.txtBrokerCode.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtBrokerCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBrokerCode.Location = New System.Drawing.Point(258, 31)
        Me.txtBrokerCode.Name = "txtBrokerCode"
        Me.txtBrokerCode.Size = New System.Drawing.Size(177, 22)
        Me.txtBrokerCode.TabIndex = 1
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescription.Location = New System.Drawing.Point(121, 215)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(570, 22)
        Me.txtDescription.TabIndex = 9
        '
        'txtNCSS
        '
        Me.txtNCSS.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtNCSS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNCSS.Location = New System.Drawing.Point(513, 183)
        Me.txtNCSS.Name = "txtNCSS"
        Me.txtNCSS.Size = New System.Drawing.Size(178, 22)
        Me.txtNCSS.TabIndex = 12
        '
        'txtFax
        '
        Me.txtFax.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtFax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFax.Location = New System.Drawing.Point(513, 148)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(178, 22)
        Me.txtFax.TabIndex = 11
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Location = New System.Drawing.Point(513, 113)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(178, 22)
        Me.txtEmail.TabIndex = 10
        '
        'txtIAS
        '
        Me.txtIAS.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtIAS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIAS.Location = New System.Drawing.Point(121, 161)
        Me.txtIAS.Name = "txtIAS"
        Me.txtIAS.Size = New System.Drawing.Size(95, 22)
        Me.txtIAS.TabIndex = 7
        '
        'txtCFS
        '
        Me.txtCFS.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtCFS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCFS.Location = New System.Drawing.Point(121, 135)
        Me.txtCFS.Name = "txtCFS"
        Me.txtCFS.Size = New System.Drawing.Size(95, 22)
        Me.txtCFS.TabIndex = 6
        '
        'txtPhone
        '
        Me.txtPhone.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.Location = New System.Drawing.Point(121, 109)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(95, 22)
        Me.txtPhone.TabIndex = 5
        '
        'txtAdress
        '
        Me.txtAdress.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtAdress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAdress.Location = New System.Drawing.Point(121, 83)
        Me.txtAdress.Name = "txtAdress"
        Me.txtAdress.Size = New System.Drawing.Size(570, 22)
        Me.txtAdress.TabIndex = 4
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(121, 57)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(570, 22)
        Me.txtName.TabIndex = 3
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(24, 143)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 13)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "CFS Limits (Rs)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(389, 188)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 13)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "NCSS Trading Code"
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(241, 193)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(121, 20)
        Me.CheckBox4.TabIndex = 38
        Me.CheckBox4.Text = "Is Associated"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(241, 166)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(125, 20)
        Me.CheckBox3.TabIndex = 37
        Me.CheckBox3.Text = "Active for TFC"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(241, 139)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(70, 20)
        Me.CheckBox2.TabIndex = 36
        Me.CheckBox2.Text = "Active"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(241, 112)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(131, 20)
        Me.CheckBox1.TabIndex = 35
        Me.CheckBox1.Text = "Primary Dealer"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 170)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 13)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "I.A.S Account No"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(72, 89)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(45, 13)
        Me.Label30.TabIndex = 30
        Me.Label30.Text = "Adress"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(472, 119)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Email"
        '
        'cmbDefine
        '
        Me.cmbDefine.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmbDefine.FormattingEnabled = True
        Me.cmbDefine.Location = New System.Drawing.Point(121, 187)
        Me.cmbDefine.Name = "cmbDefine"
        Me.cmbDefine.Size = New System.Drawing.Size(95, 24)
        Me.cmbDefine.TabIndex = 8
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(482, 153)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(27, 13)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "Fax"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(44, 197)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Defined For"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(78, 62)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(39, 13)
        Me.Label26.TabIndex = 21
        Me.Label26.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(175, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Broker Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(62, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Phone #"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Description"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(443, 35)
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
        Me.txtsysCode.Location = New System.Drawing.Point(121, 31)
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
        Me.Label1.Location = New System.Drawing.Point(37, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "System Code"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(360, 375)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(725, 202)
        Me.TabControl1.TabIndex = 40
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.fpgrid1)
        Me.TabPage3.Controls.Add(Me.cmb2)
        Me.TabPage3.Controls.Add(Me.cmb1)
        Me.TabPage3.Controls.Add(Me.radiobtn2)
        Me.TabPage3.Controls.Add(Me.radiobtn1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(717, 176)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Standard Brokerage Rate"
        '
        'fpgrid1
        '
        Me.fpgrid1.DataSource = Nothing
        Me.fpgrid1.Location = New System.Drawing.Point(6, 43)
        Me.fpgrid1.Name = "fpgrid1"
        Me.fpgrid1.OcxState = CType(resources.GetObject("fpgrid1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.fpgrid1.Size = New System.Drawing.Size(705, 115)
        Me.fpgrid1.TabIndex = 31
        '
        'cmb2
        '
        Me.cmb2.FormattingEnabled = True
        Me.cmb2.Location = New System.Drawing.Point(432, 13)
        Me.cmb2.Name = "cmb2"
        Me.cmb2.Size = New System.Drawing.Size(100, 21)
        Me.cmb2.TabIndex = 30
        '
        'cmb1
        '
        Me.cmb1.FormattingEnabled = True
        Me.cmb1.Location = New System.Drawing.Point(274, 13)
        Me.cmb1.Name = "cmb1"
        Me.cmb1.Size = New System.Drawing.Size(100, 21)
        Me.cmb1.TabIndex = 29
        '
        'radiobtn2
        '
        Me.radiobtn2.AutoSize = True
        Me.radiobtn2.Location = New System.Drawing.Point(135, 17)
        Me.radiobtn2.Name = "radiobtn2"
        Me.radiobtn2.Size = New System.Drawing.Size(90, 17)
        Me.radiobtn2.TabIndex = 1
        Me.radiobtn2.TabStop = True
        Me.radiobtn2.Text = "RadioButton2"
        Me.radiobtn2.UseVisualStyleBackColor = True
        '
        'radiobtn1
        '
        Me.radiobtn1.AutoSize = True
        Me.radiobtn1.Location = New System.Drawing.Point(29, 17)
        Me.radiobtn1.Name = "radiobtn1"
        Me.radiobtn1.Size = New System.Drawing.Size(90, 17)
        Me.radiobtn1.TabIndex = 0
        Me.radiobtn1.TabStop = True
        Me.radiobtn1.Text = "RadioButton1"
        Me.radiobtn1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.fpgrid2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(717, 176)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Agreed Brokerage Rate"
        '
        'fpgrid2
        '
        Me.fpgrid2.DataSource = Nothing
        Me.fpgrid2.Location = New System.Drawing.Point(20, 24)
        Me.fpgrid2.Name = "fpgrid2"
        Me.fpgrid2.OcxState = CType(resources.GetObject("fpgrid2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.fpgrid2.Size = New System.Drawing.Size(679, 133)
        Me.fpgrid2.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.fpgrid3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(717, 176)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "PortFolio Limits"
        '
        'fpgrid3
        '
        Me.fpgrid3.DataSource = Nothing
        Me.fpgrid3.Location = New System.Drawing.Point(6, 21)
        Me.fpgrid3.Name = "fpgrid3"
        Me.fpgrid3.OcxState = CType(resources.GetObject("fpgrid3.OcxState"), System.Windows.Forms.AxHost.State)
        Me.fpgrid3.Size = New System.Drawing.Size(693, 134)
        Me.fpgrid3.TabIndex = 0
        '
        'lblBy
        '
        Me.lblBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBy.Location = New System.Drawing.Point(913, 580)
        Me.lblBy.Name = "lblBy"
        Me.lblBy.Size = New System.Drawing.Size(170, 23)
        Me.lblBy.TabIndex = 43
        '
        'lblToolTip
        '
        Me.lblToolTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblToolTip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToolTip.Location = New System.Drawing.Point(536, 580)
        Me.lblToolTip.Name = "lblToolTip"
        Me.lblToolTip.Size = New System.Drawing.Size(372, 23)
        Me.lblToolTip.TabIndex = 42
        '
        'lblCompany
        '
        Me.lblCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.Location = New System.Drawing.Point(360, 581)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(170, 23)
        Me.lblCompany.TabIndex = 41
        '
        'frmBroker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1097, 608)
        Me.Controls.Add(Me.lblBy)
        Me.Controls.Add(Me.lblToolTip)
        Me.Controls.Add(Me.lblCompany)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GpData)
        Me.Controls.Add(Me.GpBtns)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.LblTypeValid)
        Me.Name = "frmBroker"
        Me.Text = "Broker Information"
        Me.Search.ResumeLayout(False)
        Me.Search.PerformLayout()
        CType(Me.GVHelp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GpBtns.ResumeLayout(False)
        Me.GpData.ResumeLayout(False)
        Me.GpData.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.fpgrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.fpgrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.fpgrid3, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbDefine As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtsysCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmb2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmb1 As System.Windows.Forms.ComboBox
    Friend WithEvents radiobtn2 As System.Windows.Forms.RadioButton
    Friend WithEvents radiobtn1 As System.Windows.Forms.RadioButton
    Friend WithEvents fpgrid1 As AxFPSpreadADO.AxfpSpread
    Friend WithEvents fpgrid2 As AxFPSpreadADO.AxfpSpread
    Friend WithEvents fpgrid3 As AxFPSpreadADO.AxfpSpread
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtNCSS As System.Windows.Forms.TextBox
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtIAS As System.Windows.Forms.TextBox
    Friend WithEvents txtCFS As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtAdress As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtMnemo As System.Windows.Forms.TextBox
    Friend WithEvents txtBrokerCode As System.Windows.Forms.TextBox
    Friend WithEvents lblBy As System.Windows.Forms.Label
    Friend WithEvents lblToolTip As System.Windows.Forms.Label
    Friend WithEvents lblCompany As System.Windows.Forms.Label
End Class
