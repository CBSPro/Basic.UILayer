<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPT_List
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPT_List))
        Me.GpCriteria = New System.Windows.Forms.GroupBox
        Me.rdAlphabet = New System.Windows.Forms.RadioButton
        Me.rdCode = New System.Windows.Forms.RadioButton
        Me.GpLevel = New System.Windows.Forms.GroupBox
        Me.cboLevel = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GpBranch = New System.Windows.Forms.GroupBox
        Me.lblBrName = New System.Windows.Forms.Label
        Me.txtBrCode = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GpRange = New System.Windows.Forms.GroupBox
        Me.txtEnd = New System.Windows.Forms.TextBox
        Me.txtStart = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblEnd = New System.Windows.Forms.Label
        Me.lblStart = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnPreview = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.GpCriteria.SuspendLayout()
        Me.GpLevel.SuspendLayout()
        Me.GpBranch.SuspendLayout()
        Me.GpRange.SuspendLayout()
        Me.SuspendLayout()
        '
        'GpCriteria
        '
        Me.GpCriteria.Controls.Add(Me.rdAlphabet)
        Me.GpCriteria.Controls.Add(Me.rdCode)
        Me.GpCriteria.Location = New System.Drawing.Point(9, 0)
        Me.GpCriteria.Name = "GpCriteria"
        Me.GpCriteria.Size = New System.Drawing.Size(430, 50)
        Me.GpCriteria.TabIndex = 0
        Me.GpCriteria.TabStop = False
        '
        'rdAlphabet
        '
        Me.rdAlphabet.AutoSize = True
        Me.rdAlphabet.Location = New System.Drawing.Point(181, 19)
        Me.rdAlphabet.Name = "rdAlphabet"
        Me.rdAlphabet.Size = New System.Drawing.Size(104, 17)
        Me.rdAlphabet.TabIndex = 1
        Me.rdAlphabet.TabStop = True
        Me.rdAlphabet.Text = "Alphabatic Order"
        Me.rdAlphabet.UseVisualStyleBackColor = True
        '
        'rdCode
        '
        Me.rdCode.AutoSize = True
        Me.rdCode.Location = New System.Drawing.Point(50, 19)
        Me.rdCode.Name = "rdCode"
        Me.rdCode.Size = New System.Drawing.Size(79, 17)
        Me.rdCode.TabIndex = 0
        Me.rdCode.TabStop = True
        Me.rdCode.Text = "Code Order"
        Me.rdCode.UseVisualStyleBackColor = True
        '
        'GpLevel
        '
        Me.GpLevel.Controls.Add(Me.cboLevel)
        Me.GpLevel.Controls.Add(Me.Label1)
        Me.GpLevel.Location = New System.Drawing.Point(9, 49)
        Me.GpLevel.Name = "GpLevel"
        Me.GpLevel.Size = New System.Drawing.Size(430, 43)
        Me.GpLevel.TabIndex = 1
        Me.GpLevel.TabStop = False
        '
        'cboLevel
        '
        Me.cboLevel.FormattingEnabled = True
        Me.cboLevel.Location = New System.Drawing.Point(63, 13)
        Me.cboLevel.Name = "cboLevel"
        Me.cboLevel.Size = New System.Drawing.Size(199, 21)
        Me.cboLevel.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Level"
        '
        'GpBranch
        '
        Me.GpBranch.Controls.Add(Me.lblBrName)
        Me.GpBranch.Controls.Add(Me.txtBrCode)
        Me.GpBranch.Controls.Add(Me.Label2)
        Me.GpBranch.Location = New System.Drawing.Point(10, 91)
        Me.GpBranch.Name = "GpBranch"
        Me.GpBranch.Size = New System.Drawing.Size(429, 43)
        Me.GpBranch.TabIndex = 2
        Me.GpBranch.TabStop = False
        '
        'lblBrName
        '
        Me.lblBrName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblBrName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBrName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrName.Location = New System.Drawing.Point(110, 13)
        Me.lblBrName.Name = "lblBrName"
        Me.lblBrName.Size = New System.Drawing.Size(309, 22)
        Me.lblBrName.TabIndex = 7
        '
        'txtBrCode
        '
        Me.txtBrCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBrCode.Location = New System.Drawing.Point(62, 13)
        Me.txtBrCode.MaxLength = 3
        Me.txtBrCode.Name = "txtBrCode"
        Me.txtBrCode.Size = New System.Drawing.Size(46, 22)
        Me.txtBrCode.TabIndex = 6
        Me.txtBrCode.Tag = "Enter Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Branch"
        '
        'GpRange
        '
        Me.GpRange.Controls.Add(Me.txtEnd)
        Me.GpRange.Controls.Add(Me.txtStart)
        Me.GpRange.Controls.Add(Me.Label4)
        Me.GpRange.Controls.Add(Me.lblEnd)
        Me.GpRange.Controls.Add(Me.lblStart)
        Me.GpRange.Controls.Add(Me.Label3)
        Me.GpRange.Location = New System.Drawing.Point(9, 133)
        Me.GpRange.Name = "GpRange"
        Me.GpRange.Size = New System.Drawing.Size(430, 113)
        Me.GpRange.TabIndex = 3
        Me.GpRange.TabStop = False
        '
        'txtEnd
        '
        Me.txtEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnd.Location = New System.Drawing.Point(90, 58)
        Me.txtEnd.MaxLength = 3
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.Size = New System.Drawing.Size(98, 22)
        Me.txtEnd.TabIndex = 17
        Me.txtEnd.Tag = "Enter Description"
        '
        'txtStart
        '
        Me.txtStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStart.Location = New System.Drawing.Point(90, 9)
        Me.txtStart.MaxLength = 3
        Me.txtStart.Name = "txtStart"
        Me.txtStart.Size = New System.Drawing.Size(98, 22)
        Me.txtStart.TabIndex = 16
        Me.txtStart.Tag = "Enter Description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Ending Code"
        '
        'lblEnd
        '
        Me.lblEnd.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnd.Location = New System.Drawing.Point(90, 82)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(330, 22)
        Me.lblEnd.TabIndex = 14
        '
        'lblStart
        '
        Me.lblStart.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.Location = New System.Drawing.Point(90, 34)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(330, 22)
        Me.lblStart.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Starting Code"
        '
        'btnPreview
        '
        Me.btnPreview.Image = CType(resources.GetObject("btnPreview.Image"), System.Drawing.Image)
        Me.btnPreview.Location = New System.Drawing.Point(11, 259)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(136, 61)
        Me.btnPreview.TabIndex = 12
        Me.btnPreview.Text = "&Preview"
        Me.btnPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(304, 259)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(136, 61)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "&Close"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(158, 259)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(136, 61)
        Me.btnPrint.TabIndex = 13
        Me.btnPrint.Text = "Pr&int"
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'frmRPT_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 333)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.GpRange)
        Me.Controls.Add(Me.GpBranch)
        Me.Controls.Add(Me.GpLevel)
        Me.Controls.Add(Me.GpCriteria)
        Me.Name = "frmRPT_List"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRPT_List"
        Me.GpCriteria.ResumeLayout(False)
        Me.GpCriteria.PerformLayout()
        Me.GpLevel.ResumeLayout(False)
        Me.GpLevel.PerformLayout()
        Me.GpBranch.ResumeLayout(False)
        Me.GpBranch.PerformLayout()
        Me.GpRange.ResumeLayout(False)
        Me.GpRange.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GpCriteria As System.Windows.Forms.GroupBox
    Friend WithEvents rdAlphabet As System.Windows.Forms.RadioButton
    Friend WithEvents rdCode As System.Windows.Forms.RadioButton
    Friend WithEvents GpLevel As System.Windows.Forms.GroupBox
    Friend WithEvents cboLevel As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GpBranch As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblBrName As System.Windows.Forms.Label
    Friend WithEvents txtBrCode As System.Windows.Forms.TextBox
    Friend WithEvents GpRange As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblEnd As System.Windows.Forms.Label
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents txtStart As System.Windows.Forms.TextBox
    Friend WithEvents txtEnd As System.Windows.Forms.TextBox
End Class
