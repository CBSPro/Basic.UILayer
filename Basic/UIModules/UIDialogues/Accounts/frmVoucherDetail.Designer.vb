<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVoucherDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVoucherDetail))
        Me.GpData = New System.Windows.Forms.GroupBox
        Me.lblBrCode = New System.Windows.Forms.Label
        Me.lblType = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblVNo = New System.Windows.Forms.Label
        Me.dtpVDate = New System.Windows.Forms.DateTimePicker
        Me.txtPurpose = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.vspGrid = New AxFPSpreadADO.AxfpSpread
        Me.LBLTotCr = New System.Windows.Forms.Label
        Me.LBLTotDr = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.LblTypeValid = New System.Windows.Forms.Label
        Me.GpData.SuspendLayout()
        CType(Me.vspGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GpData
        '
        Me.GpData.Controls.Add(Me.lblBrCode)
        Me.GpData.Controls.Add(Me.lblType)
        Me.GpData.Controls.Add(Me.Label5)
        Me.GpData.Controls.Add(Me.lblVNo)
        Me.GpData.Controls.Add(Me.dtpVDate)
        Me.GpData.Controls.Add(Me.txtPurpose)
        Me.GpData.Controls.Add(Me.Label2)
        Me.GpData.Controls.Add(Me.Label1)
        Me.GpData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpData.Location = New System.Drawing.Point(7, 55)
        Me.GpData.Name = "GpData"
        Me.GpData.Size = New System.Drawing.Size(729, 72)
        Me.GpData.TabIndex = 19
        Me.GpData.TabStop = False
        '
        'lblBrCode
        '
        Me.lblBrCode.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblBrCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBrCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrCode.Location = New System.Drawing.Point(170, 15)
        Me.lblBrCode.Name = "lblBrCode"
        Me.lblBrCode.Size = New System.Drawing.Size(41, 22)
        Me.lblBrCode.TabIndex = 11
        '
        'lblType
        '
        Me.lblType.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(137, 15)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(31, 22)
        Me.lblType.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(81, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Purpose"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVNo
        '
        Me.lblVNo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblVNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVNo.Location = New System.Drawing.Point(213, 15)
        Me.lblVNo.Name = "lblVNo"
        Me.lblVNo.Size = New System.Drawing.Size(95, 22)
        Me.lblVNo.TabIndex = 8
        '
        'dtpVDate
        '
        Me.dtpVDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpVDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVDate.Location = New System.Drawing.Point(537, 15)
        Me.dtpVDate.Name = "dtpVDate"
        Me.dtpVDate.Size = New System.Drawing.Size(91, 22)
        Me.dtpVDate.TabIndex = 1
        '
        'txtPurpose
        '
        Me.txtPurpose.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtPurpose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPurpose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurpose.Location = New System.Drawing.Point(137, 40)
        Me.txtPurpose.MaxLength = 80
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.Size = New System.Drawing.Size(491, 22)
        Me.txtPurpose.TabIndex = 3
        Me.txtPurpose.Tag = "Enter Purpose"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(450, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Voucher Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Voucher No."
        '
        'vspGrid
        '
        Me.vspGrid.DataSource = Nothing
        Me.vspGrid.Location = New System.Drawing.Point(9, 132)
        Me.vspGrid.Name = "vspGrid"
        Me.vspGrid.OcxState = CType(resources.GetObject("vspGrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.vspGrid.Size = New System.Drawing.Size(727, 248)
        Me.vspGrid.TabIndex = 20
        '
        'LBLTotCr
        '
        Me.LBLTotCr.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LBLTotCr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLTotCr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTotCr.Location = New System.Drawing.Point(483, 386)
        Me.LBLTotCr.Name = "LBLTotCr"
        Me.LBLTotCr.Size = New System.Drawing.Size(86, 21)
        Me.LBLTotCr.TabIndex = 26
        Me.LBLTotCr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LBLTotDr
        '
        Me.LBLTotDr.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LBLTotDr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLTotDr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTotDr.Location = New System.Drawing.Point(396, 386)
        Me.LBLTotDr.Name = "LBLTotDr"
        Me.LBLTotDr.Size = New System.Drawing.Size(86, 21)
        Me.LBLTotDr.TabIndex = 25
        Me.LBLTotDr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(350, 389)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 16)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Total"
        '
        'btnClose
        '
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(616, 385)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(113, 46)
        Me.btnClose.TabIndex = 23
        Me.btnClose.Text = "&Close"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'LblTypeValid
        '
        Me.LblTypeValid.BackColor = System.Drawing.Color.PowderBlue
        Me.LblTypeValid.Font = New System.Drawing.Font("Nina", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTypeValid.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LblTypeValid.Location = New System.Drawing.Point(0, 0)
        Me.LblTypeValid.Name = "LblTypeValid"
        Me.LblTypeValid.Size = New System.Drawing.Size(749, 52)
        Me.LblTypeValid.TabIndex = 46
        Me.LblTypeValid.Text = "Voucher Detail"
        Me.LblTypeValid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmVoucherDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 437)
        Me.Controls.Add(Me.LblTypeValid)
        Me.Controls.Add(Me.LBLTotCr)
        Me.Controls.Add(Me.LBLTotDr)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.vspGrid)
        Me.Controls.Add(Me.GpData)
        Me.Name = "frmVoucherDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Voucher Detail"
        Me.GpData.ResumeLayout(False)
        Me.GpData.PerformLayout()
        CType(Me.vspGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GpData As System.Windows.Forms.GroupBox
    Friend WithEvents lblBrCode As System.Windows.Forms.Label
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblVNo As System.Windows.Forms.Label
    Friend WithEvents dtpVDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPurpose As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents vspGrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents LBLTotCr As System.Windows.Forms.Label
    Friend WithEvents LBLTotDr As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents LblTypeValid As System.Windows.Forms.Label
End Class
