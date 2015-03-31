<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExpoAndMargn
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
        Me.LblTypeValid = New System.Windows.Forms.Label()
        Me.Search = New System.Windows.Forms.GroupBox()
        Me.GVHelp = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.GpData = New System.Windows.Forms.GroupBox()
        Me.dtpValid = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbInstitute = New System.Windows.Forms.ComboBox()
        Me.cmbInstituteType = New System.Windows.Forms.ComboBox()
        Me.rbMargin = New System.Windows.Forms.RadioButton()
        Me.rbBorrow = New System.Windows.Forms.RadioButton()
        Me.rbLending = New System.Windows.Forms.RadioButton()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.txtAmnt = New System.Windows.Forms.TextBox()
        Me.cmbFund = New System.Windows.Forms.ComboBox()
        Me.cmbMode = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtsysCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Search.SuspendLayout()
        CType(Me.GVHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GpData.SuspendLayout()
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
        Me.LblTypeValid.Text = "Set Exposure And Margin Information"
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
        'GpData
        '
        Me.GpData.Controls.Add(Me.dtpValid)
        Me.GpData.Controls.Add(Me.Label4)
        Me.GpData.Controls.Add(Me.Label2)
        Me.GpData.Controls.Add(Me.cmbInstitute)
        Me.GpData.Controls.Add(Me.cmbInstituteType)
        Me.GpData.Controls.Add(Me.rbMargin)
        Me.GpData.Controls.Add(Me.rbBorrow)
        Me.GpData.Controls.Add(Me.rbLending)
        Me.GpData.Controls.Add(Me.txtDesc)
        Me.GpData.Controls.Add(Me.txtAmnt)
        Me.GpData.Controls.Add(Me.cmbFund)
        Me.GpData.Controls.Add(Me.cmbMode)
        Me.GpData.Controls.Add(Me.Label9)
        Me.GpData.Controls.Add(Me.Label30)
        Me.GpData.Controls.Add(Me.Label10)
        Me.GpData.Controls.Add(Me.Label26)
        Me.GpData.Controls.Add(Me.Label3)
        Me.GpData.Controls.Add(Me.Label5)
        Me.GpData.Controls.Add(Me.txtsysCode)
        Me.GpData.Controls.Add(Me.Label1)
        Me.GpData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpData.Location = New System.Drawing.Point(355, 63)
        Me.GpData.Name = "GpData"
        Me.GpData.Size = New System.Drawing.Size(722, 331)
        Me.GpData.TabIndex = 43
        Me.GpData.TabStop = False
        '
        'dtpValid
        '
        Me.dtpValid.CustomFormat = "dd/MM/yyyy"
        Me.dtpValid.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpValid.Location = New System.Drawing.Point(122, 211)
        Me.dtpValid.Name = "dtpValid"
        Me.dtpValid.Size = New System.Drawing.Size(146, 22)
        Me.dtpValid.TabIndex = 57
        Me.dtpValid.Value = New Date(2015, 3, 30, 15, 11, 43, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Validity Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Institute"
        '
        'cmbInstitute
        '
        Me.cmbInstitute.FormattingEnabled = True
        Me.cmbInstitute.Location = New System.Drawing.Point(122, 178)
        Me.cmbInstitute.Name = "cmbInstitute"
        Me.cmbInstitute.Size = New System.Drawing.Size(146, 24)
        Me.cmbInstitute.TabIndex = 54
        '
        'cmbInstituteType
        '
        Me.cmbInstituteType.FormattingEnabled = True
        Me.cmbInstituteType.Location = New System.Drawing.Point(122, 148)
        Me.cmbInstituteType.Name = "cmbInstituteType"
        Me.cmbInstituteType.Size = New System.Drawing.Size(146, 24)
        Me.cmbInstituteType.TabIndex = 53
        '
        'rbMargin
        '
        Me.rbMargin.AutoSize = True
        Me.rbMargin.Location = New System.Drawing.Point(448, 61)
        Me.rbMargin.Name = "rbMargin"
        Me.rbMargin.Size = New System.Drawing.Size(73, 20)
        Me.rbMargin.TabIndex = 52
        Me.rbMargin.TabStop = True
        Me.rbMargin.Text = "Margin"
        Me.rbMargin.UseVisualStyleBackColor = True
        '
        'rbBorrow
        '
        Me.rbBorrow.AutoSize = True
        Me.rbBorrow.Location = New System.Drawing.Point(278, 61)
        Me.rbBorrow.Name = "rbBorrow"
        Me.rbBorrow.Size = New System.Drawing.Size(164, 20)
        Me.rbBorrow.TabIndex = 51
        Me.rbBorrow.TabStop = True
        Me.rbBorrow.Text = "Borrowing Exposure"
        Me.rbBorrow.UseVisualStyleBackColor = True
        '
        'rbLending
        '
        Me.rbLending.AutoSize = True
        Me.rbLending.Location = New System.Drawing.Point(122, 61)
        Me.rbLending.Name = "rbLending"
        Me.rbLending.Size = New System.Drawing.Size(150, 20)
        Me.rbLending.TabIndex = 50
        Me.rbLending.TabStop = True
        Me.rbLending.Text = "Lending Exposure"
        Me.rbLending.UseVisualStyleBackColor = True
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(122, 283)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDesc.Size = New System.Drawing.Size(146, 42)
        Me.txtDesc.TabIndex = 49
        '
        'txtAmnt
        '
        Me.txtAmnt.Location = New System.Drawing.Point(122, 252)
        Me.txtAmnt.Name = "txtAmnt"
        Me.txtAmnt.Size = New System.Drawing.Size(146, 22)
        Me.txtAmnt.TabIndex = 48
        '
        'cmbFund
        '
        Me.cmbFund.FormattingEnabled = True
        Me.cmbFund.Location = New System.Drawing.Point(122, 116)
        Me.cmbFund.Name = "cmbFund"
        Me.cmbFund.Size = New System.Drawing.Size(146, 24)
        Me.cmbFund.TabIndex = 46
        '
        'cmbMode
        '
        Me.cmbMode.FormattingEnabled = True
        Me.cmbMode.Location = New System.Drawing.Point(122, 86)
        Me.cmbMode.Name = "cmbMode"
        Me.cmbMode.Size = New System.Drawing.Size(146, 24)
        Me.cmbMode.TabIndex = 45
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(39, 261)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Exp. Amount"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(79, 97)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(38, 13)
        Me.Label30.TabIndex = 30
        Me.Label30.Text = "Mode"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(81, 127)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Fund"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(42, 65)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(75, 13)
        Me.Label26.TabIndex = 21
        Me.Label26.Text = "Trans. Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Institute Type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Description"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtsysCode
        '
        Me.txtsysCode.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtsysCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsysCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsysCode.Location = New System.Drawing.Point(122, 31)
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
        Me.Label1.Location = New System.Drawing.Point(33, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " System Code"
        '
        'FrmExpoAndMargn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1083, 607)
        Me.Controls.Add(Me.GpData)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.LblTypeValid)
        Me.Name = "FrmExpoAndMargn"
        Me.Text = "Set Exposure And Margin Information"
        Me.Search.ResumeLayout(False)
        Me.Search.PerformLayout()
        CType(Me.GVHelp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GpData.ResumeLayout(False)
        Me.GpData.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblTypeValid As System.Windows.Forms.Label
    Friend WithEvents Search As System.Windows.Forms.GroupBox
    Friend WithEvents GVHelp As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents GpData As System.Windows.Forms.GroupBox
    Friend WithEvents rbBorrow As System.Windows.Forms.RadioButton
    Friend WithEvents rbLending As System.Windows.Forms.RadioButton
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtAmnt As System.Windows.Forms.TextBox
    Friend WithEvents cmbFund As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMode As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtsysCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbMargin As System.Windows.Forms.RadioButton
    Friend WithEvents cmbInstituteType As System.Windows.Forms.ComboBox
    Friend WithEvents cmbInstitute As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpValid As System.Windows.Forms.DateTimePicker
End Class
