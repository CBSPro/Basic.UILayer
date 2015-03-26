<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPT_TrialBal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPT_TrialBal))
        Me.GpData = New System.Windows.Forms.GroupBox
        Me.GpCodes = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblEndName = New System.Windows.Forms.Label
        Me.mskEndCode = New System.Windows.Forms.MaskedTextBox
        Me.lblStartName = New System.Windows.Forms.Label
        Me.mskStartCode = New System.Windows.Forms.MaskedTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GpLevel = New System.Windows.Forms.GroupBox
        Me.rdbThird = New System.Windows.Forms.RadioButton
        Me.rdbSecond = New System.Windows.Forms.RadioButton
        Me.rdbFirst = New System.Windows.Forms.RadioButton
        Me.GpPeriod = New System.Windows.Forms.GroupBox
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker
        Me.lblBrName = New System.Windows.Forms.Label
        Me.txtRefBrCode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnPreview = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.GpData.SuspendLayout()
        Me.GpCodes.SuspendLayout()
        Me.GpLevel.SuspendLayout()
        Me.GpPeriod.SuspendLayout()
        Me.SuspendLayout()
        '
        'GpData
        '
        Me.GpData.Controls.Add(Me.GpCodes)
        Me.GpData.Controls.Add(Me.GpLevel)
        Me.GpData.Controls.Add(Me.GpPeriod)
        Me.GpData.Controls.Add(Me.lblBrName)
        Me.GpData.Controls.Add(Me.txtRefBrCode)
        Me.GpData.Controls.Add(Me.Label1)
        Me.GpData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpData.Location = New System.Drawing.Point(9, 48)
        Me.GpData.Name = "GpData"
        Me.GpData.Size = New System.Drawing.Size(499, 230)
        Me.GpData.TabIndex = 1
        Me.GpData.TabStop = False
        '
        'GpCodes
        '
        Me.GpCodes.Controls.Add(Me.Label4)
        Me.GpCodes.Controls.Add(Me.lblEndName)
        Me.GpCodes.Controls.Add(Me.mskEndCode)
        Me.GpCodes.Controls.Add(Me.lblStartName)
        Me.GpCodes.Controls.Add(Me.mskStartCode)
        Me.GpCodes.Controls.Add(Me.Label3)
        Me.GpCodes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpCodes.Location = New System.Drawing.Point(6, 149)
        Me.GpCodes.Name = "GpCodes"
        Me.GpCodes.Size = New System.Drawing.Size(486, 76)
        Me.GpCodes.TabIndex = 8
        Me.GpCodes.TabStop = False
        Me.GpCodes.Text = "Codes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Ending Code"
        '
        'lblEndName
        '
        Me.lblEndName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblEndName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEndName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndName.Location = New System.Drawing.Point(197, 41)
        Me.lblEndName.Name = "lblEndName"
        Me.lblEndName.Size = New System.Drawing.Size(279, 22)
        Me.lblEndName.TabIndex = 8
        '
        'mskEndCode
        '
        Me.mskEndCode.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.mskEndCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskEndCode.Location = New System.Drawing.Point(94, 41)
        Me.mskEndCode.Mask = "##"
        Me.mskEndCode.Name = "mskEndCode"
        Me.mskEndCode.Size = New System.Drawing.Size(97, 22)
        Me.mskEndCode.TabIndex = 3
        Me.mskEndCode.Tag = "Enter Account Code"
        '
        'lblStartName
        '
        Me.lblStartName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblStartName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStartName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartName.Location = New System.Drawing.Point(197, 16)
        Me.lblStartName.Name = "lblStartName"
        Me.lblStartName.Size = New System.Drawing.Size(279, 22)
        Me.lblStartName.TabIndex = 6
        '
        'mskStartCode
        '
        Me.mskStartCode.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.mskStartCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskStartCode.Location = New System.Drawing.Point(94, 16)
        Me.mskStartCode.Mask = "##"
        Me.mskStartCode.Name = "mskStartCode"
        Me.mskStartCode.Size = New System.Drawing.Size(97, 22)
        Me.mskStartCode.TabIndex = 2
        Me.mskStartCode.Tag = "Enter Account Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Starting Code"
        '
        'GpLevel
        '
        Me.GpLevel.Controls.Add(Me.rdbThird)
        Me.GpLevel.Controls.Add(Me.rdbSecond)
        Me.GpLevel.Controls.Add(Me.rdbFirst)
        Me.GpLevel.Location = New System.Drawing.Point(258, 48)
        Me.GpLevel.Name = "GpLevel"
        Me.GpLevel.Size = New System.Drawing.Size(235, 100)
        Me.GpLevel.TabIndex = 7
        Me.GpLevel.TabStop = False
        Me.GpLevel.Text = "Level"
        '
        'rdbThird
        '
        Me.rdbThird.AutoSize = True
        Me.rdbThird.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbThird.Location = New System.Drawing.Point(97, 69)
        Me.rdbThird.Name = "rdbThird"
        Me.rdbThird.Size = New System.Drawing.Size(57, 20)
        Me.rdbThird.TabIndex = 2
        Me.rdbThird.TabStop = True
        Me.rdbThird.Text = "Third"
        Me.rdbThird.UseVisualStyleBackColor = True
        '
        'rdbSecond
        '
        Me.rdbSecond.AutoSize = True
        Me.rdbSecond.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbSecond.Location = New System.Drawing.Point(97, 43)
        Me.rdbSecond.Name = "rdbSecond"
        Me.rdbSecond.Size = New System.Drawing.Size(73, 20)
        Me.rdbSecond.TabIndex = 1
        Me.rdbSecond.TabStop = True
        Me.rdbSecond.Text = "Second"
        Me.rdbSecond.UseVisualStyleBackColor = True
        '
        'rdbFirst
        '
        Me.rdbFirst.AutoSize = True
        Me.rdbFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbFirst.Location = New System.Drawing.Point(97, 17)
        Me.rdbFirst.Name = "rdbFirst"
        Me.rdbFirst.Size = New System.Drawing.Size(51, 20)
        Me.rdbFirst.TabIndex = 0
        Me.rdbFirst.TabStop = True
        Me.rdbFirst.Text = "First"
        Me.rdbFirst.UseVisualStyleBackColor = True
        '
        'GpPeriod
        '
        Me.GpPeriod.Controls.Add(Me.dtpEndDate)
        Me.GpPeriod.Controls.Add(Me.dtpStartDate)
        Me.GpPeriod.Location = New System.Drawing.Point(6, 48)
        Me.GpPeriod.Name = "GpPeriod"
        Me.GpPeriod.Size = New System.Drawing.Size(235, 100)
        Me.GpPeriod.TabIndex = 6
        Me.GpPeriod.TabStop = False
        Me.GpPeriod.Text = "Period"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEndDate.Location = New System.Drawing.Point(77, 54)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(90, 22)
        Me.dtpEndDate.TabIndex = 6
        Me.dtpEndDate.Value = New Date(2009, 2, 24, 0, 0, 0, 0)
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartDate.Location = New System.Drawing.Point(77, 26)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(90, 22)
        Me.dtpStartDate.TabIndex = 5
        Me.dtpStartDate.Value = New Date(2009, 2, 24, 0, 0, 0, 0)
        '
        'lblBrName
        '
        Me.lblBrName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblBrName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBrName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrName.Location = New System.Drawing.Point(142, 20)
        Me.lblBrName.Name = "lblBrName"
        Me.lblBrName.Size = New System.Drawing.Size(350, 22)
        Me.lblBrName.TabIndex = 5
        '
        'txtRefBrCode
        '
        Me.txtRefBrCode.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtRefBrCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefBrCode.Location = New System.Drawing.Point(94, 20)
        Me.txtRefBrCode.MaxLength = 3
        Me.txtRefBrCode.Name = "txtRefBrCode"
        Me.txtRefBrCode.Size = New System.Drawing.Size(46, 22)
        Me.txtRefBrCode.TabIndex = 1
        Me.txtRefBrCode.Tag = "Enter Description"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Branch Code"
        '
        'btnPreview
        '
        Me.btnPreview.Image = CType(resources.GetObject("btnPreview.Image"), System.Drawing.Image)
        Me.btnPreview.Location = New System.Drawing.Point(35, 283)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(136, 61)
        Me.btnPreview.TabIndex = 9
        Me.btnPreview.Text = "&Preview"
        Me.btnPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(349, 284)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(136, 61)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "&Close"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(195, 284)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(136, 61)
        Me.btnPrint.TabIndex = 10
        Me.btnPrint.Text = "Pr&int"
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.PowderBlue
        Me.Label15.Font = New System.Drawing.Font("Nina", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label15.Location = New System.Drawing.Point(1, -1)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(528, 52)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "VoucherValidation"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmRPT_TrialBal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 360)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.GpData)
        Me.Name = "frmRPT_TrialBal"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trial Balance"
        Me.GpData.ResumeLayout(False)
        Me.GpData.PerformLayout()
        Me.GpCodes.ResumeLayout(False)
        Me.GpCodes.PerformLayout()
        Me.GpLevel.ResumeLayout(False)
        Me.GpLevel.PerformLayout()
        Me.GpPeriod.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GpData As System.Windows.Forms.GroupBox
    Friend WithEvents GpPeriod As System.Windows.Forms.GroupBox
    Friend WithEvents lblBrName As System.Windows.Forms.Label
    Friend WithEvents txtRefBrCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GpLevel As System.Windows.Forms.GroupBox
    Friend WithEvents rdbThird As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSecond As System.Windows.Forms.RadioButton
    Friend WithEvents rdbFirst As System.Windows.Forms.RadioButton
    Friend WithEvents GpCodes As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblEndName As System.Windows.Forms.Label
    Friend WithEvents mskEndCode As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblStartName As System.Windows.Forms.Label
    Friend WithEvents mskStartCode As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
