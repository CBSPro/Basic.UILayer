<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPT_IncStat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPT_IncStat))
        Me.GpDates = New System.Windows.Forms.GroupBox
        Me.chkPrtNotes = New System.Windows.Forms.CheckBox
        Me.lblEndPageNo = New System.Windows.Forms.Label
        Me.txtEndPageNo = New System.Windows.Forms.TextBox
        Me.LBLStPageNo = New System.Windows.Forms.Label
        Me.txtStPageNo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblBrName = New System.Windows.Forms.Label
        Me.txtRefBrCode = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnPreview = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.GpDates.SuspendLayout()
        Me.SuspendLayout()
        '
        'GpDates
        '
        Me.GpDates.Controls.Add(Me.chkPrtNotes)
        Me.GpDates.Controls.Add(Me.lblEndPageNo)
        Me.GpDates.Controls.Add(Me.txtEndPageNo)
        Me.GpDates.Controls.Add(Me.LBLStPageNo)
        Me.GpDates.Controls.Add(Me.txtStPageNo)
        Me.GpDates.Controls.Add(Me.Label4)
        Me.GpDates.Controls.Add(Me.Label1)
        Me.GpDates.Controls.Add(Me.lblBrName)
        Me.GpDates.Controls.Add(Me.txtRefBrCode)
        Me.GpDates.Controls.Add(Me.Label3)
        Me.GpDates.Controls.Add(Me.dtpDate)
        Me.GpDates.Controls.Add(Me.Label2)
        Me.GpDates.Location = New System.Drawing.Point(5, 0)
        Me.GpDates.Name = "GpDates"
        Me.GpDates.Size = New System.Drawing.Size(502, 153)
        Me.GpDates.TabIndex = 2
        Me.GpDates.TabStop = False
        '
        'chkPrtNotes
        '
        Me.chkPrtNotes.AutoSize = True
        Me.chkPrtNotes.Location = New System.Drawing.Point(111, 123)
        Me.chkPrtNotes.Name = "chkPrtNotes"
        Me.chkPrtNotes.Size = New System.Drawing.Size(164, 17)
        Me.chkPrtNotes.TabIndex = 4
        Me.chkPrtNotes.Text = "Print Notes To The Accounts"
        Me.chkPrtNotes.UseVisualStyleBackColor = True
        '
        'lblEndPageNo
        '
        Me.lblEndPageNo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblEndPageNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEndPageNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndPageNo.Location = New System.Drawing.Point(159, 71)
        Me.lblEndPageNo.Name = "lblEndPageNo"
        Me.lblEndPageNo.Size = New System.Drawing.Size(299, 22)
        Me.lblEndPageNo.TabIndex = 14
        '
        'txtEndPageNo
        '
        Me.txtEndPageNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndPageNo.Location = New System.Drawing.Point(111, 71)
        Me.txtEndPageNo.MaxLength = 2
        Me.txtEndPageNo.Name = "txtEndPageNo"
        Me.txtEndPageNo.Size = New System.Drawing.Size(46, 22)
        Me.txtEndPageNo.TabIndex = 2
        Me.txtEndPageNo.Tag = "Enter Description"
        '
        'LBLStPageNo
        '
        Me.LBLStPageNo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LBLStPageNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLStPageNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLStPageNo.Location = New System.Drawing.Point(159, 45)
        Me.LBLStPageNo.Name = "LBLStPageNo"
        Me.LBLStPageNo.Size = New System.Drawing.Size(299, 22)
        Me.LBLStPageNo.TabIndex = 12
        '
        'txtStPageNo
        '
        Me.txtStPageNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStPageNo.Location = New System.Drawing.Point(111, 45)
        Me.txtStPageNo.MaxLength = 2
        Me.txtStPageNo.Name = "txtStPageNo"
        Me.txtStPageNo.Size = New System.Drawing.Size(46, 22)
        Me.txtStPageNo.TabIndex = 1
        Me.txtStPageNo.Tag = "Enter Description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Ending Page No."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Starting Page No."
        '
        'lblBrName
        '
        Me.lblBrName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblBrName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBrName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrName.Location = New System.Drawing.Point(159, 19)
        Me.lblBrName.Name = "lblBrName"
        Me.lblBrName.Size = New System.Drawing.Size(299, 22)
        Me.lblBrName.TabIndex = 8
        '
        'txtRefBrCode
        '
        Me.txtRefBrCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefBrCode.Location = New System.Drawing.Point(111, 19)
        Me.txtRefBrCode.MaxLength = 3
        Me.txtRefBrCode.Name = "txtRefBrCode"
        Me.txtRefBrCode.Size = New System.Drawing.Size(46, 22)
        Me.txtRefBrCode.TabIndex = 0
        Me.txtRefBrCode.Tag = "Enter Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Branch Code"
        '
        'dtpDate
        '
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(111, 96)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(90, 22)
        Me.dtpDate.TabIndex = 3
        Me.dtpDate.Value = New Date(2009, 2, 24, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date"
        '
        'btnPreview
        '
        Me.btnPreview.Image = CType(resources.GetObject("btnPreview.Image"), System.Drawing.Image)
        Me.btnPreview.Location = New System.Drawing.Point(49, 159)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(136, 61)
        Me.btnPreview.TabIndex = 15
        Me.btnPreview.Text = "&Preview"
        Me.btnPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(345, 159)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(136, 61)
        Me.btnClose.TabIndex = 17
        Me.btnClose.Text = "&Close"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(197, 159)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(136, 61)
        Me.btnPrint.TabIndex = 16
        Me.btnPrint.Text = "Pr&int"
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'frmRPT_IncStat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 232)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.GpDates)
        Me.Name = "frmRPT_IncStat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRPT_IncStat"
        Me.GpDates.ResumeLayout(False)
        Me.GpDates.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GpDates As System.Windows.Forms.GroupBox
    Friend WithEvents lblBrName As System.Windows.Forms.Label
    Friend WithEvents txtRefBrCode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblEndPageNo As System.Windows.Forms.Label
    Friend WithEvents txtEndPageNo As System.Windows.Forms.TextBox
    Friend WithEvents LBLStPageNo As System.Windows.Forms.Label
    Friend WithEvents txtStPageNo As System.Windows.Forms.TextBox
    Friend WithEvents chkPrtNotes As System.Windows.Forms.CheckBox
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
End Class
