<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmINV_Status
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmINV_Status))
        Me.GpRefAC = New System.Windows.Forms.GroupBox
        Me.txtECode = New System.Windows.Forms.TextBox
        Me.txtSCode = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.mskStoreCodeName = New System.Windows.Forms.Label
        Me.mskStoreCode = New System.Windows.Forms.MaskedTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtECodeName = New System.Windows.Forms.Label
        Me.txtSCodeName = New System.Windows.Forms.Label
        Me.lblBrName = New System.Windows.Forms.Label
        Me.txtRefBrCode = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GpDates = New System.Windows.Forms.GroupBox
        Me.dtpEdate = New System.Windows.Forms.DateTimePicker
        Me.dtpSdate = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.btnPreview = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.GpRefAC.SuspendLayout()
        Me.GpDates.SuspendLayout()
        Me.SuspendLayout()
        '
        'GpRefAC
        '
        Me.GpRefAC.Controls.Add(Me.txtECode)
        Me.GpRefAC.Controls.Add(Me.txtSCode)
        Me.GpRefAC.Controls.Add(Me.Label6)
        Me.GpRefAC.Controls.Add(Me.mskStoreCodeName)
        Me.GpRefAC.Controls.Add(Me.mskStoreCode)
        Me.GpRefAC.Controls.Add(Me.Label4)
        Me.GpRefAC.Controls.Add(Me.txtECodeName)
        Me.GpRefAC.Controls.Add(Me.txtSCodeName)
        Me.GpRefAC.Controls.Add(Me.lblBrName)
        Me.GpRefAC.Controls.Add(Me.txtRefBrCode)
        Me.GpRefAC.Controls.Add(Me.Label2)
        Me.GpRefAC.Controls.Add(Me.Label1)
        Me.GpRefAC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpRefAC.Location = New System.Drawing.Point(5, 53)
        Me.GpRefAC.Name = "GpRefAC"
        Me.GpRefAC.Size = New System.Drawing.Size(524, 137)
        Me.GpRefAC.TabIndex = 0
        Me.GpRefAC.TabStop = False
        '
        'txtECode
        '
        Me.txtECode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtECode.Location = New System.Drawing.Point(94, 48)
        Me.txtECode.MaxLength = 3
        Me.txtECode.Name = "txtECode"
        Me.txtECode.Size = New System.Drawing.Size(64, 22)
        Me.txtECode.TabIndex = 2
        Me.txtECode.Tag = "Enter Item"
        '
        'txtSCode
        '
        Me.txtSCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSCode.Location = New System.Drawing.Point(94, 19)
        Me.txtSCode.MaxLength = 3
        Me.txtSCode.Name = "txtSCode"
        Me.txtSCode.Size = New System.Drawing.Size(64, 22)
        Me.txtSCode.TabIndex = 1
        Me.txtSCode.Tag = "Enter Item"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Store Code"
        '
        'mskStoreCodeName
        '
        Me.mskStoreCodeName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.mskStoreCodeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskStoreCodeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskStoreCodeName.Location = New System.Drawing.Point(131, 105)
        Me.mskStoreCodeName.Name = "mskStoreCodeName"
        Me.mskStoreCodeName.Size = New System.Drawing.Size(386, 22)
        Me.mskStoreCodeName.TabIndex = 11
        '
        'mskStoreCode
        '
        Me.mskStoreCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskStoreCode.Location = New System.Drawing.Point(94, 105)
        Me.mskStoreCode.Mask = "##"
        Me.mskStoreCode.Name = "mskStoreCode"
        Me.mskStoreCode.Size = New System.Drawing.Size(31, 22)
        Me.mskStoreCode.TabIndex = 4
        Me.mskStoreCode.Tag = "Enter Store Code"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "To Item"
        '
        'txtECodeName
        '
        Me.txtECodeName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtECodeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtECodeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtECodeName.Location = New System.Drawing.Point(164, 48)
        Me.txtECodeName.Name = "txtECodeName"
        Me.txtECodeName.Size = New System.Drawing.Size(353, 22)
        Me.txtECodeName.TabIndex = 8
        '
        'txtSCodeName
        '
        Me.txtSCodeName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtSCodeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSCodeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSCodeName.Location = New System.Drawing.Point(164, 19)
        Me.txtSCodeName.Name = "txtSCodeName"
        Me.txtSCodeName.Size = New System.Drawing.Size(353, 22)
        Me.txtSCodeName.TabIndex = 6
        '
        'lblBrName
        '
        Me.lblBrName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblBrName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBrName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrName.Location = New System.Drawing.Point(131, 76)
        Me.lblBrName.Name = "lblBrName"
        Me.lblBrName.Size = New System.Drawing.Size(386, 22)
        Me.lblBrName.TabIndex = 5
        '
        'txtRefBrCode
        '
        Me.txtRefBrCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefBrCode.Location = New System.Drawing.Point(94, 76)
        Me.txtRefBrCode.MaxLength = 3
        Me.txtRefBrCode.Name = "txtRefBrCode"
        Me.txtRefBrCode.Size = New System.Drawing.Size(31, 22)
        Me.txtRefBrCode.TabIndex = 3
        Me.txtRefBrCode.Tag = "Enter Branch Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "From Item"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Branch Code"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'GpDates
        '
        Me.GpDates.Controls.Add(Me.dtpEdate)
        Me.GpDates.Controls.Add(Me.dtpSdate)
        Me.GpDates.Controls.Add(Me.Label5)
        Me.GpDates.Controls.Add(Me.Label3)
        Me.GpDates.Location = New System.Drawing.Point(5, 192)
        Me.GpDates.Name = "GpDates"
        Me.GpDates.Size = New System.Drawing.Size(524, 48)
        Me.GpDates.TabIndex = 3
        Me.GpDates.TabStop = False
        '
        'dtpEdate
        '
        Me.dtpEdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEdate.Location = New System.Drawing.Point(351, 15)
        Me.dtpEdate.Name = "dtpEdate"
        Me.dtpEdate.Size = New System.Drawing.Size(87, 20)
        Me.dtpEdate.TabIndex = 6
        Me.dtpEdate.Value = New Date(2009, 2, 24, 0, 0, 0, 0)
        '
        'dtpSdate
        '
        Me.dtpSdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSdate.Location = New System.Drawing.Point(94, 15)
        Me.dtpSdate.Name = "dtpSdate"
        Me.dtpSdate.Size = New System.Drawing.Size(87, 20)
        Me.dtpSdate.TabIndex = 5
        Me.dtpSdate.Value = New Date(2009, 2, 24, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(279, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Ending Date"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Starting Date"
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(353, 244)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(136, 61)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "&Close"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(203, 244)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(136, 61)
        Me.btnPrint.TabIndex = 8
        Me.btnPrint.Text = "Pr&int"
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnPreview
        '
        Me.btnPreview.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPreview.FlatAppearance.BorderSize = 2
        Me.btnPreview.Image = CType(resources.GetObject("btnPreview.Image"), System.Drawing.Image)
        Me.btnPreview.Location = New System.Drawing.Point(54, 244)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(136, 61)
        Me.btnPreview.TabIndex = 7
        Me.btnPreview.Text = "&Preview"
        Me.btnPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.PowderBlue
        Me.Label15.Font = New System.Drawing.Font("Nina", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label15.Location = New System.Drawing.Point(-1, -2)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(538, 52)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "VoucherValidation"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmINV_Status
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 312)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.GpDates)
        Me.Controls.Add(Me.GpRefAC)
        Me.MaximizeBox = False
        Me.Name = "frmINV_Status"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GpRefAC.ResumeLayout(False)
        Me.GpRefAC.PerformLayout()
        Me.GpDates.ResumeLayout(False)
        Me.GpDates.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GpRefAC As System.Windows.Forms.GroupBox
    Friend WithEvents txtECodeName As System.Windows.Forms.Label
    Friend WithEvents txtSCodeName As System.Windows.Forms.Label
    Friend WithEvents lblBrName As System.Windows.Forms.Label
    Friend WithEvents txtRefBrCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GpDates As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpEdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpSdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents mskStoreCodeName As System.Windows.Forms.Label
    Friend WithEvents mskStoreCode As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtECode As System.Windows.Forms.TextBox
    Friend WithEvents txtSCode As System.Windows.Forms.TextBox
End Class
