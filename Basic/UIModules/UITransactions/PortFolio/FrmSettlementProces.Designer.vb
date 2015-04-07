<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSettlementProces
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSettlementProces))
        Me.LblTypeValid = New System.Windows.Forms.Label()
        Me.GpData = New System.Windows.Forms.GroupBox()
        Me.cmbAllBrok = New System.Windows.Forms.CheckBox()
        Me.cmbAllSecu = New System.Windows.Forms.CheckBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.cmbBroker = New System.Windows.Forms.ComboBox()
        Me.cmbFund = New System.Windows.Forms.ComboBox()
        Me.cmbSecu = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LBLPosted = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnFetch = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpProcesDate = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.fpDetail = New AxFPSpreadADO.AxfpSpread()
        Me.GpData.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.fpDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTypeValid
        '
        Me.LblTypeValid.BackColor = System.Drawing.Color.PowderBlue
        Me.LblTypeValid.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTypeValid.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LblTypeValid.Location = New System.Drawing.Point(1, 0)
        Me.LblTypeValid.Name = "LblTypeValid"
        Me.LblTypeValid.Size = New System.Drawing.Size(901, 52)
        Me.LblTypeValid.TabIndex = 34
        Me.LblTypeValid.Text = "Settlement Proces"
        Me.LblTypeValid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GpData
        '
        Me.GpData.Controls.Add(Me.cmbAllBrok)
        Me.GpData.Controls.Add(Me.cmbAllSecu)
        Me.GpData.Controls.Add(Me.cmbStatus)
        Me.GpData.Controls.Add(Me.cmbBroker)
        Me.GpData.Controls.Add(Me.cmbFund)
        Me.GpData.Controls.Add(Me.cmbSecu)
        Me.GpData.Controls.Add(Me.Label3)
        Me.GpData.Controls.Add(Me.Label2)
        Me.GpData.Controls.Add(Me.LBLPosted)
        Me.GpData.Controls.Add(Me.Label1)
        Me.GpData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpData.Location = New System.Drawing.Point(51, 83)
        Me.GpData.Name = "GpData"
        Me.GpData.Size = New System.Drawing.Size(368, 146)
        Me.GpData.TabIndex = 42
        Me.GpData.TabStop = False
        '
        'cmbAllBrok
        '
        Me.cmbAllBrok.AutoSize = True
        Me.cmbAllBrok.Location = New System.Drawing.Point(281, 84)
        Me.cmbAllBrok.Name = "cmbAllBrok"
        Me.cmbAllBrok.Size = New System.Drawing.Size(45, 20)
        Me.cmbAllBrok.TabIndex = 54
        Me.cmbAllBrok.Text = "All"
        Me.cmbAllBrok.UseVisualStyleBackColor = True
        '
        'cmbAllSecu
        '
        Me.cmbAllSecu.AutoSize = True
        Me.cmbAllSecu.Location = New System.Drawing.Point(281, 52)
        Me.cmbAllSecu.Name = "cmbAllSecu"
        Me.cmbAllSecu.Size = New System.Drawing.Size(45, 20)
        Me.cmbAllSecu.TabIndex = 53
        Me.cmbAllSecu.Text = "All"
        Me.cmbAllSecu.UseVisualStyleBackColor = True
        '
        'cmbStatus
        '
        Me.cmbStatus.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(115, 114)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(160, 24)
        Me.cmbStatus.TabIndex = 5
        '
        'cmbBroker
        '
        Me.cmbBroker.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmbBroker.FormattingEnabled = True
        Me.cmbBroker.Location = New System.Drawing.Point(115, 82)
        Me.cmbBroker.Name = "cmbBroker"
        Me.cmbBroker.Size = New System.Drawing.Size(160, 24)
        Me.cmbBroker.TabIndex = 4
        '
        'cmbFund
        '
        Me.cmbFund.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmbFund.FormattingEnabled = True
        Me.cmbFund.Location = New System.Drawing.Point(115, 50)
        Me.cmbFund.Name = "cmbFund"
        Me.cmbFund.Size = New System.Drawing.Size(160, 24)
        Me.cmbFund.TabIndex = 3
        '
        'cmbSecu
        '
        Me.cmbSecu.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmbSecu.FormattingEnabled = True
        Me.cmbSecu.Location = New System.Drawing.Point(115, 21)
        Me.cmbSecu.Name = "cmbSecu"
        Me.cmbSecu.Size = New System.Drawing.Size(160, 24)
        Me.cmbSecu.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Transaction"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Fund"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LBLPosted
        '
        Me.LBLPosted.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPosted.ForeColor = System.Drawing.Color.Red
        Me.LBLPosted.Location = New System.Drawing.Point(575, 18)
        Me.LBLPosted.Name = "LBLPosted"
        Me.LBLPosted.Size = New System.Drawing.Size(137, 42)
        Me.LBLPosted.TabIndex = 13
        Me.LBLPosted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Security Type"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.btnFetch)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtpFromDate)
        Me.GroupBox1.Controls.Add(Me.dtpToDate)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(425, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(395, 147)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Date"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(67, 24)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(40, 17)
        Me.CheckBox1.TabIndex = 54
        Me.CheckBox1.Text = "All"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btnFetch
        '
        Me.btnFetch.Location = New System.Drawing.Point(286, 98)
        Me.btnFetch.Name = "btnFetch"
        Me.btnFetch.Size = New System.Drawing.Size(93, 42)
        Me.btnFetch.TabIndex = 8
        Me.btnFetch.Text = "Fetch"
        Me.btnFetch.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(131, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 13)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "To"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(119, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "From"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dtpFromDate
        '
        Me.dtpFromDate.CalendarMonthBackground = System.Drawing.SystemColors.ButtonHighlight
        Me.dtpFromDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFromDate.Location = New System.Drawing.Point(156, 52)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(111, 20)
        Me.dtpFromDate.TabIndex = 6
        '
        'dtpToDate
        '
        Me.dtpToDate.CalendarMonthBackground = System.Drawing.SystemColors.ButtonHighlight
        Me.dtpToDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpToDate.Location = New System.Drawing.Point(156, 84)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(111, 20)
        Me.dtpToDate.TabIndex = 7
        '
        'btnProcess
        '
        Me.btnProcess.Location = New System.Drawing.Point(674, 280)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(120, 38)
        Me.btnProcess.TabIndex = 9
        Me.btnProcess.Text = "Process"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(79, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Process Date"
        '
        'dtpProcesDate
        '
        Me.dtpProcesDate.CalendarMonthBackground = System.Drawing.SystemColors.ButtonHighlight
        Me.dtpProcesDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpProcesDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpProcesDate.Location = New System.Drawing.Point(167, 58)
        Me.dtpProcesDate.Name = "dtpProcesDate"
        Me.dtpProcesDate.Size = New System.Drawing.Size(101, 20)
        Me.dtpProcesDate.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.fpDetail)
        Me.GroupBox2.Controls.Add(Me.btnProcess)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 236)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(810, 327)
        Me.GroupBox2.TabIndex = 50
        Me.GroupBox2.TabStop = False
        '
        'fpDetail
        '
        Me.fpDetail.DataSource = Nothing
        Me.fpDetail.Location = New System.Drawing.Point(6, 14)
        Me.fpDetail.Name = "fpDetail"
        Me.fpDetail.OcxState = CType(resources.GetObject("fpDetail.OcxState"), System.Windows.Forms.AxHost.State)
        Me.fpDetail.Size = New System.Drawing.Size(790, 260)
        Me.fpDetail.TabIndex = 53
        '
        'FrmSettlementProces
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 575)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dtpProcesDate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GpData)
        Me.Controls.Add(Me.LblTypeValid)
        Me.Name = "FrmSettlementProces"
        Me.Text = "Settlement Proces"
        Me.GpData.ResumeLayout(False)
        Me.GpData.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.fpDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblTypeValid As System.Windows.Forms.Label
    Friend WithEvents GpData As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LBLPosted As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbSecu As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBroker As System.Windows.Forms.ComboBox
    Friend WithEvents cmbFund As System.Windows.Forms.ComboBox
    Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnFetch As System.Windows.Forms.Button
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents cmbAllSecu As System.Windows.Forms.CheckBox
    Friend WithEvents cmbAllBrok As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpProcesDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents fpDetail As AxFPSpreadADO.AxfpSpread
End Class
