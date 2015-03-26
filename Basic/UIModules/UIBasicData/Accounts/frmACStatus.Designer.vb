<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmACStatus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmACStatus))
        Me.GpCriteria = New System.Windows.Forms.GroupBox
        Me.LBLOpBal = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker
        Me.lblBrName = New System.Windows.Forms.Label
        Me.lblRfCode = New System.Windows.Forms.Label
        Me.txtBrCode = New System.Windows.Forms.TextBox
        Me.mskCode = New System.Windows.Forms.MaskedTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.vspGrid = New AxFPSpreadADO.AxfpSpread
        Me.btnClose = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.LBLTotDr = New System.Windows.Forms.Label
        Me.LBLTotCr = New System.Windows.Forms.Label
        Me.LBLTotBal = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.GpCriteria.SuspendLayout()
        CType(Me.vspGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GpCriteria
        '
        Me.GpCriteria.Controls.Add(Me.LBLOpBal)
        Me.GpCriteria.Controls.Add(Me.Label5)
        Me.GpCriteria.Controls.Add(Me.dtpEndDate)
        Me.GpCriteria.Controls.Add(Me.Label4)
        Me.GpCriteria.Controls.Add(Me.dtpStartDate)
        Me.GpCriteria.Controls.Add(Me.lblBrName)
        Me.GpCriteria.Controls.Add(Me.lblRfCode)
        Me.GpCriteria.Controls.Add(Me.txtBrCode)
        Me.GpCriteria.Controls.Add(Me.mskCode)
        Me.GpCriteria.Controls.Add(Me.Label3)
        Me.GpCriteria.Controls.Add(Me.Label2)
        Me.GpCriteria.Controls.Add(Me.Label1)
        Me.GpCriteria.Location = New System.Drawing.Point(8, 60)
        Me.GpCriteria.Name = "GpCriteria"
        Me.GpCriteria.Size = New System.Drawing.Size(726, 94)
        Me.GpCriteria.TabIndex = 0
        Me.GpCriteria.TabStop = False
        '
        'LBLOpBal
        '
        Me.LBLOpBal.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LBLOpBal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLOpBal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLOpBal.Location = New System.Drawing.Point(614, 35)
        Me.LBLOpBal.Name = "LBLOpBal"
        Me.LBLOpBal.Size = New System.Drawing.Size(108, 21)
        Me.LBLOpBal.TabIndex = 19
        Me.LBLOpBal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(518, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 16)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Balance B/F"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEndDate.Location = New System.Drawing.Point(418, 61)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(91, 22)
        Me.dtpEndDate.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(343, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Ending Date"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartDate.Location = New System.Drawing.Point(131, 61)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(91, 22)
        Me.dtpStartDate.TabIndex = 2
        '
        'lblBrName
        '
        Me.lblBrName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblBrName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBrName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrName.Location = New System.Drawing.Point(181, 13)
        Me.lblBrName.Name = "lblBrName"
        Me.lblBrName.Size = New System.Drawing.Size(328, 22)
        Me.lblBrName.TabIndex = 15
        '
        'lblRfCode
        '
        Me.lblRfCode.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblRfCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRfCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRfCode.Location = New System.Drawing.Point(241, 37)
        Me.lblRfCode.Name = "lblRfCode"
        Me.lblRfCode.Size = New System.Drawing.Size(268, 22)
        Me.lblRfCode.TabIndex = 14
        '
        'txtBrCode
        '
        Me.txtBrCode.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtBrCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBrCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBrCode.Location = New System.Drawing.Point(131, 13)
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
        Me.mskCode.Location = New System.Drawing.Point(131, 37)
        Me.mskCode.Mask = "##"
        Me.mskCode.Name = "mskCode"
        Me.mskCode.Size = New System.Drawing.Size(104, 22)
        Me.mskCode.TabIndex = 1
        Me.mskCode.Tag = "Enter Account Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Starting Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Account Code"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-2, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Branch / Office Code"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'vspGrid
        '
        Me.vspGrid.DataSource = Nothing
        Me.vspGrid.Location = New System.Drawing.Point(8, 161)
        Me.vspGrid.Name = "vspGrid"
        Me.vspGrid.OcxState = CType(resources.GetObject("vspGrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.vspGrid.Size = New System.Drawing.Size(1008, 435)
        Me.vspGrid.TabIndex = 4
        '
        'btnClose
        '
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(824, 636)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(128, 46)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "&Close"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(234, 613)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(335, 16)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "*** Double-Click Any Cell For Voucher Detail ***"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(641, 613)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Total"
        '
        'LBLTotDr
        '
        Me.LBLTotDr.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LBLTotDr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLTotDr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTotDr.Location = New System.Drawing.Point(691, 608)
        Me.LBLTotDr.Name = "LBLTotDr"
        Me.LBLTotDr.Size = New System.Drawing.Size(86, 21)
        Me.LBLTotDr.TabIndex = 21
        Me.LBLTotDr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LBLTotCr
        '
        Me.LBLTotCr.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LBLTotCr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLTotCr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTotCr.Location = New System.Drawing.Point(778, 608)
        Me.LBLTotCr.Name = "LBLTotCr"
        Me.LBLTotCr.Size = New System.Drawing.Size(86, 21)
        Me.LBLTotCr.TabIndex = 22
        Me.LBLTotCr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LBLTotBal
        '
        Me.LBLTotBal.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LBLTotBal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLTotBal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTotBal.Location = New System.Drawing.Point(865, 608)
        Me.LBLTotBal.Name = "LBLTotBal"
        Me.LBLTotBal.Size = New System.Drawing.Size(86, 21)
        Me.LBLTotBal.TabIndex = 23
        Me.LBLTotBal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.PowderBlue
        Me.Label15.Font = New System.Drawing.Font("Nina", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label15.Location = New System.Drawing.Point(-2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(1029, 52)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "VoucherValidation"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmACStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 750)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.LBLTotBal)
        Me.Controls.Add(Me.LBLTotCr)
        Me.Controls.Add(Me.LBLTotDr)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.vspGrid)
        Me.Controls.Add(Me.GpCriteria)
        Me.Name = "frmACStatus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Code Status (On Screen)"
        Me.GpCriteria.ResumeLayout(False)
        Me.GpCriteria.PerformLayout()
        CType(Me.vspGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GpCriteria As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblBrName As System.Windows.Forms.Label
    Friend WithEvents lblRfCode As System.Windows.Forms.Label
    Friend WithEvents txtBrCode As System.Windows.Forms.TextBox
    Friend WithEvents mskCode As System.Windows.Forms.MaskedTextBox
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents vspGrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LBLOpBal As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LBLTotDr As System.Windows.Forms.Label
    Friend WithEvents LBLTotCr As System.Windows.Forms.Label
    Friend WithEvents LBLTotBal As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
