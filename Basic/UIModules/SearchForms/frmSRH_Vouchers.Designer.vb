<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSRH_Vouchers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSRH_Vouchers))
        Me.GpCriteria = New System.Windows.Forms.GroupBox
        Me.rdbUnposted = New System.Windows.Forms.RadioButton
        Me.rdbPosted = New System.Windows.Forms.RadioButton
        Me.rdbAll = New System.Windows.Forms.RadioButton
        Me.GpDates = New System.Windows.Forms.GroupBox
        Me.lblBrName = New System.Windows.Forms.Label
        Me.txtRefBrCode = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOk = New System.Windows.Forms.Button
        Me.GpCriteria.SuspendLayout()
        Me.GpDates.SuspendLayout()
        Me.SuspendLayout()
        '
        'GpCriteria
        '
        Me.GpCriteria.Controls.Add(Me.rdbUnposted)
        Me.GpCriteria.Controls.Add(Me.rdbPosted)
        Me.GpCriteria.Controls.Add(Me.rdbAll)
        Me.GpCriteria.Location = New System.Drawing.Point(6, 1)
        Me.GpCriteria.Name = "GpCriteria"
        Me.GpCriteria.Size = New System.Drawing.Size(443, 53)
        Me.GpCriteria.TabIndex = 0
        Me.GpCriteria.TabStop = False
        '
        'rdbUnposted
        '
        Me.rdbUnposted.AutoSize = True
        Me.rdbUnposted.Location = New System.Drawing.Point(276, 19)
        Me.rdbUnposted.Name = "rdbUnposted"
        Me.rdbUnposted.Size = New System.Drawing.Size(119, 17)
        Me.rdbUnposted.TabIndex = 2
        Me.rdbUnposted.TabStop = True
        Me.rdbUnposted.Text = "Unposted Vouchers"
        Me.rdbUnposted.UseVisualStyleBackColor = True
        '
        'rdbPosted
        '
        Me.rdbPosted.AutoSize = True
        Me.rdbPosted.Location = New System.Drawing.Point(114, 19)
        Me.rdbPosted.Name = "rdbPosted"
        Me.rdbPosted.Size = New System.Drawing.Size(106, 17)
        Me.rdbPosted.TabIndex = 1
        Me.rdbPosted.TabStop = True
        Me.rdbPosted.Text = "Posted Vouchers"
        Me.rdbPosted.UseVisualStyleBackColor = True
        '
        'rdbAll
        '
        Me.rdbAll.AutoSize = True
        Me.rdbAll.Location = New System.Drawing.Point(16, 19)
        Me.rdbAll.Name = "rdbAll"
        Me.rdbAll.Size = New System.Drawing.Size(36, 17)
        Me.rdbAll.TabIndex = 0
        Me.rdbAll.TabStop = True
        Me.rdbAll.Text = "All"
        Me.rdbAll.UseVisualStyleBackColor = True
        '
        'GpDates
        '
        Me.GpDates.Controls.Add(Me.lblBrName)
        Me.GpDates.Controls.Add(Me.txtRefBrCode)
        Me.GpDates.Controls.Add(Me.Label3)
        Me.GpDates.Controls.Add(Me.dtpEndDate)
        Me.GpDates.Controls.Add(Me.dtpStartDate)
        Me.GpDates.Controls.Add(Me.Label2)
        Me.GpDates.Controls.Add(Me.Label1)
        Me.GpDates.Location = New System.Drawing.Point(6, 60)
        Me.GpDates.Name = "GpDates"
        Me.GpDates.Size = New System.Drawing.Size(443, 86)
        Me.GpDates.TabIndex = 1
        Me.GpDates.TabStop = False
        '
        'lblBrName
        '
        Me.lblBrName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBrName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrName.Location = New System.Drawing.Point(138, 23)
        Me.lblBrName.Name = "lblBrName"
        Me.lblBrName.Size = New System.Drawing.Size(299, 22)
        Me.lblBrName.TabIndex = 8
        '
        'txtRefBrCode
        '
        Me.txtRefBrCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefBrCode.Location = New System.Drawing.Point(90, 23)
        Me.txtRefBrCode.MaxLength = 3
        Me.txtRefBrCode.Name = "txtRefBrCode"
        Me.txtRefBrCode.Size = New System.Drawing.Size(46, 22)
        Me.txtRefBrCode.TabIndex = 3
        Me.txtRefBrCode.Tag = "Enter Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Branch Code"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEndDate.Location = New System.Drawing.Point(278, 48)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(90, 22)
        Me.dtpEndDate.TabIndex = 5
        Me.dtpEndDate.Value = New Date(2009, 2, 24, 0, 0, 0, 0)
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartDate.Location = New System.Drawing.Point(90, 48)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(90, 22)
        Me.dtpStartDate.TabIndex = 4
        Me.dtpStartDate.Value = New Date(2009, 2, 24, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(207, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ending Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Starting Date"
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(248, 152)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(108, 50)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnOk
        '
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.Location = New System.Drawing.Point(130, 152)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(108, 50)
        Me.btnOk.TabIndex = 6
        Me.btnOk.Text = "&Ok"
        Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'frmSRH_Vouchers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 213)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.GpDates)
        Me.Controls.Add(Me.GpCriteria)
        Me.Name = "frmSRH_Vouchers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSRH_Vouchers"
        Me.GpCriteria.ResumeLayout(False)
        Me.GpCriteria.PerformLayout()
        Me.GpDates.ResumeLayout(False)
        Me.GpDates.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GpCriteria As System.Windows.Forms.GroupBox
    Friend WithEvents rdbAll As System.Windows.Forms.RadioButton
    Friend WithEvents rdbUnposted As System.Windows.Forms.RadioButton
    Friend WithEvents rdbPosted As System.Windows.Forms.RadioButton
    Friend WithEvents GpDates As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents lblBrName As System.Windows.Forms.Label
    Friend WithEvents txtRefBrCode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
