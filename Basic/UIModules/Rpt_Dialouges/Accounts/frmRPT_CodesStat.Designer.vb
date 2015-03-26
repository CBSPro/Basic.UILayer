<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPT_CodesStat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPT_CodesStat))
        Me.GpRefAC = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblEndName = New System.Windows.Forms.Label
        Me.mskEndCode = New System.Windows.Forms.MaskedTextBox
        Me.lblStartName = New System.Windows.Forms.Label
        Me.lblBrName = New System.Windows.Forms.Label
        Me.txtRefBrCode = New System.Windows.Forms.TextBox
        Me.mskStartCode = New System.Windows.Forms.MaskedTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GpDates = New System.Windows.Forms.GroupBox
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker
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
        Me.GpRefAC.Controls.Add(Me.Label4)
        Me.GpRefAC.Controls.Add(Me.lblEndName)
        Me.GpRefAC.Controls.Add(Me.mskEndCode)
        Me.GpRefAC.Controls.Add(Me.lblStartName)
        Me.GpRefAC.Controls.Add(Me.lblBrName)
        Me.GpRefAC.Controls.Add(Me.txtRefBrCode)
        Me.GpRefAC.Controls.Add(Me.mskStartCode)
        Me.GpRefAC.Controls.Add(Me.Label2)
        Me.GpRefAC.Controls.Add(Me.Label1)
        Me.GpRefAC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpRefAC.Location = New System.Drawing.Point(6, 56)
        Me.GpRefAC.Name = "GpRefAC"
        Me.GpRefAC.Size = New System.Drawing.Size(524, 107)
        Me.GpRefAC.TabIndex = 0
        Me.GpRefAC.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 74)
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
        Me.lblEndName.Location = New System.Drawing.Point(198, 70)
        Me.lblEndName.Name = "lblEndName"
        Me.lblEndName.Size = New System.Drawing.Size(319, 22)
        Me.lblEndName.TabIndex = 8
        '
        'mskEndCode
        '
        Me.mskEndCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskEndCode.Location = New System.Drawing.Point(94, 70)
        Me.mskEndCode.Mask = "##"
        Me.mskEndCode.Name = "mskEndCode"
        Me.mskEndCode.Size = New System.Drawing.Size(101, 22)
        Me.mskEndCode.TabIndex = 3
        Me.mskEndCode.Tag = "Enter Account Code"
        '
        'lblStartName
        '
        Me.lblStartName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblStartName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStartName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartName.Location = New System.Drawing.Point(198, 45)
        Me.lblStartName.Name = "lblStartName"
        Me.lblStartName.Size = New System.Drawing.Size(319, 22)
        Me.lblStartName.TabIndex = 6
        '
        'lblBrName
        '
        Me.lblBrName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblBrName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBrName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrName.Location = New System.Drawing.Point(142, 20)
        Me.lblBrName.Name = "lblBrName"
        Me.lblBrName.Size = New System.Drawing.Size(375, 22)
        Me.lblBrName.TabIndex = 5
        '
        'txtRefBrCode
        '
        Me.txtRefBrCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefBrCode.Location = New System.Drawing.Point(94, 20)
        Me.txtRefBrCode.MaxLength = 3
        Me.txtRefBrCode.Name = "txtRefBrCode"
        Me.txtRefBrCode.Size = New System.Drawing.Size(46, 22)
        Me.txtRefBrCode.TabIndex = 1
        Me.txtRefBrCode.Tag = "Enter Description"
        '
        'mskStartCode
        '
        Me.mskStartCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskStartCode.Location = New System.Drawing.Point(94, 45)
        Me.mskStartCode.Mask = "##"
        Me.mskStartCode.Name = "mskStartCode"
        Me.mskStartCode.Size = New System.Drawing.Size(101, 22)
        Me.mskStartCode.TabIndex = 2
        Me.mskStartCode.Tag = "Enter Account Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Starting Code"
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
        'GpDates
        '
        Me.GpDates.Controls.Add(Me.dtpEndDate)
        Me.GpDates.Controls.Add(Me.dtpStartDate)
        Me.GpDates.Controls.Add(Me.Label5)
        Me.GpDates.Controls.Add(Me.Label3)
        Me.GpDates.Location = New System.Drawing.Point(6, 163)
        Me.GpDates.Name = "GpDates"
        Me.GpDates.Size = New System.Drawing.Size(524, 48)
        Me.GpDates.TabIndex = 3
        Me.GpDates.TabStop = False
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEndDate.Location = New System.Drawing.Point(351, 15)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(87, 20)
        Me.dtpEndDate.TabIndex = 5
        Me.dtpEndDate.Value = New Date(2009, 2, 24, 0, 0, 0, 0)
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartDate.Location = New System.Drawing.Point(94, 15)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(87, 20)
        Me.dtpStartDate.TabIndex = 4
        Me.dtpStartDate.Value = New Date(2009, 2, 24, 0, 0, 0, 0)
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
        Me.Label3.AutoSize = True
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
        Me.btnCancel.Location = New System.Drawing.Point(354, 217)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(136, 61)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "&Close"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(204, 217)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(136, 61)
        Me.btnPrint.TabIndex = 7
        Me.btnPrint.Text = "Pr&int"
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnPreview
        '
        Me.btnPreview.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPreview.FlatAppearance.BorderSize = 2
        Me.btnPreview.Image = CType(resources.GetObject("btnPreview.Image"), System.Drawing.Image)
        Me.btnPreview.Location = New System.Drawing.Point(55, 217)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(136, 61)
        Me.btnPreview.TabIndex = 6
        Me.btnPreview.Text = "&Preview"
        Me.btnPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.PowderBlue
        Me.Label15.Font = New System.Drawing.Font("Nina", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label15.Location = New System.Drawing.Point(-1, -2)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(538, 52)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "VoucherValidation"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmRPT_CodesStat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 287)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.GpDates)
        Me.Controls.Add(Me.GpRefAC)
        Me.MaximizeBox = False
        Me.Name = "frmRPT_CodesStat"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRPT_CodesStat"
        Me.GpRefAC.ResumeLayout(False)
        Me.GpRefAC.PerformLayout()
        Me.GpDates.ResumeLayout(False)
        Me.GpDates.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GpRefAC As System.Windows.Forms.GroupBox
    Friend WithEvents lblEndName As System.Windows.Forms.Label
    Friend WithEvents mskEndCode As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblStartName As System.Windows.Forms.Label
    Friend WithEvents lblBrName As System.Windows.Forms.Label
    Friend WithEvents txtRefBrCode As System.Windows.Forms.TextBox
    Friend WithEvents mskStartCode As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GpDates As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
