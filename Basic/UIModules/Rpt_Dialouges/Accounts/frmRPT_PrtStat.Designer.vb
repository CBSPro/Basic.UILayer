<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPT_PrtStat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPT_PrtStat))
        Me.btnPreview = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.GpDates = New System.Windows.Forms.GroupBox
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblProcess = New System.Windows.Forms.Label
        Me.ProgBar = New System.Windows.Forms.ProgressBar
        Me.chkPrtNotes = New System.Windows.Forms.CheckBox
        Me.lblEndPageNo = New System.Windows.Forms.Label
        Me.txtEndPageNo = New System.Windows.Forms.TextBox
        Me.LBLStPageNo = New System.Windows.Forms.Label
        Me.txtStPageNo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.GpDates.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPreview
        '
        Me.btnPreview.Image = CType(resources.GetObject("btnPreview.Image"), System.Drawing.Image)
        Me.btnPreview.Location = New System.Drawing.Point(89, 154)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(108, 50)
        Me.btnPreview.TabIndex = 6
        Me.btnPreview.Text = "&Preview"
        Me.btnPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(317, 154)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(108, 50)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "&Close"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(203, 154)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(108, 50)
        Me.btnPrint.TabIndex = 7
        Me.btnPrint.Text = "Pr&int"
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'GpDates
        '
        Me.GpDates.Controls.Add(Me.dtpEndDate)
        Me.GpDates.Controls.Add(Me.Label3)
        Me.GpDates.Controls.Add(Me.lblProcess)
        Me.GpDates.Controls.Add(Me.ProgBar)
        Me.GpDates.Controls.Add(Me.chkPrtNotes)
        Me.GpDates.Controls.Add(Me.lblEndPageNo)
        Me.GpDates.Controls.Add(Me.txtEndPageNo)
        Me.GpDates.Controls.Add(Me.LBLStPageNo)
        Me.GpDates.Controls.Add(Me.txtStPageNo)
        Me.GpDates.Controls.Add(Me.Label4)
        Me.GpDates.Controls.Add(Me.Label1)
        Me.GpDates.Controls.Add(Me.dtpDate)
        Me.GpDates.Controls.Add(Me.Label2)
        Me.GpDates.Location = New System.Drawing.Point(6, -2)
        Me.GpDates.Name = "GpDates"
        Me.GpDates.Size = New System.Drawing.Size(502, 153)
        Me.GpDates.TabIndex = 18
        Me.GpDates.TabStop = False
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEndDate.Location = New System.Drawing.Point(368, 65)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(90, 22)
        Me.dtpEndDate.TabIndex = 4
        Me.dtpEndDate.Value = New Date(2009, 2, 24, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(305, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "End Date"
        '
        'lblProcess
        '
        Me.lblProcess.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcess.Location = New System.Drawing.Point(10, 113)
        Me.lblProcess.Name = "lblProcess"
        Me.lblProcess.Size = New System.Drawing.Size(486, 13)
        Me.lblProcess.TabIndex = 16
        '
        'ProgBar
        '
        Me.ProgBar.Location = New System.Drawing.Point(6, 132)
        Me.ProgBar.Name = "ProgBar"
        Me.ProgBar.Size = New System.Drawing.Size(490, 15)
        Me.ProgBar.TabIndex = 15
        '
        'chkPrtNotes
        '
        Me.chkPrtNotes.AutoSize = True
        Me.chkPrtNotes.Location = New System.Drawing.Point(111, 92)
        Me.chkPrtNotes.Name = "chkPrtNotes"
        Me.chkPrtNotes.Size = New System.Drawing.Size(164, 17)
        Me.chkPrtNotes.TabIndex = 5
        Me.chkPrtNotes.Text = "Print Notes To The Accounts"
        Me.chkPrtNotes.UseVisualStyleBackColor = True
        '
        'lblEndPageNo
        '
        Me.lblEndPageNo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblEndPageNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEndPageNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndPageNo.Location = New System.Drawing.Point(159, 40)
        Me.lblEndPageNo.Name = "lblEndPageNo"
        Me.lblEndPageNo.Size = New System.Drawing.Size(299, 22)
        Me.lblEndPageNo.TabIndex = 14
        '
        'txtEndPageNo
        '
        Me.txtEndPageNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndPageNo.Location = New System.Drawing.Point(111, 40)
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
        Me.LBLStPageNo.Location = New System.Drawing.Point(159, 14)
        Me.LBLStPageNo.Name = "LBLStPageNo"
        Me.LBLStPageNo.Size = New System.Drawing.Size(299, 22)
        Me.LBLStPageNo.TabIndex = 12
        '
        'txtStPageNo
        '
        Me.txtStPageNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStPageNo.Location = New System.Drawing.Point(111, 14)
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
        Me.Label4.Location = New System.Drawing.Point(18, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Ending Page No."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Starting Page No."
        '
        'dtpDate
        '
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(111, 65)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(90, 22)
        Me.dtpDate.TabIndex = 3
        Me.dtpDate.Value = New Date(2009, 2, 24, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Start Date"
        '
        'frmRPT_PrtStat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 211)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.GpDates)
        Me.Name = "frmRPT_PrtStat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Defined Reports Printing"
        Me.GpDates.ResumeLayout(False)
        Me.GpDates.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents GpDates As System.Windows.Forms.GroupBox
    Friend WithEvents chkPrtNotes As System.Windows.Forms.CheckBox
    Friend WithEvents lblEndPageNo As System.Windows.Forms.Label
    Friend WithEvents txtEndPageNo As System.Windows.Forms.TextBox
    Friend WithEvents LBLStPageNo As System.Windows.Forms.Label
    Friend WithEvents txtStPageNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblProcess As System.Windows.Forms.Label
    Friend WithEvents ProgBar As System.Windows.Forms.ProgressBar
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
