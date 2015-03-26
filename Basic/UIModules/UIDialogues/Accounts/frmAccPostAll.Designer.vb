<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccPostAll
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccPostAll))
        Me.GpVouchers = New System.Windows.Forms.GroupBox
        Me.cboEndVoucher = New System.Windows.Forms.ComboBox
        Me.cboStVoucher = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ProgBar = New System.Windows.Forms.ProgressBar
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnPost = New System.Windows.Forms.Button
        Me.GpVouchers.SuspendLayout()
        Me.SuspendLayout()
        '
        'GpVouchers
        '
        Me.GpVouchers.Controls.Add(Me.cboEndVoucher)
        Me.GpVouchers.Controls.Add(Me.cboStVoucher)
        Me.GpVouchers.Controls.Add(Me.Label2)
        Me.GpVouchers.Controls.Add(Me.Label1)
        Me.GpVouchers.Location = New System.Drawing.Point(6, 1)
        Me.GpVouchers.Name = "GpVouchers"
        Me.GpVouchers.Size = New System.Drawing.Size(279, 73)
        Me.GpVouchers.TabIndex = 0
        Me.GpVouchers.TabStop = False
        '
        'cboEndVoucher
        '
        Me.cboEndVoucher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEndVoucher.FormattingEnabled = True
        Me.cboEndVoucher.Location = New System.Drawing.Point(118, 38)
        Me.cboEndVoucher.Name = "cboEndVoucher"
        Me.cboEndVoucher.Size = New System.Drawing.Size(142, 21)
        Me.cboEndVoucher.TabIndex = 1
        '
        'cboStVoucher
        '
        Me.cboStVoucher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStVoucher.FormattingEnabled = True
        Me.cboStVoucher.Location = New System.Drawing.Point(118, 15)
        Me.cboStVoucher.Name = "cboStVoucher"
        Me.cboStVoucher.Size = New System.Drawing.Size(142, 21)
        Me.cboStVoucher.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ending Voucher"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Starting Voucher"
        '
        'ProgBar
        '
        Me.ProgBar.Location = New System.Drawing.Point(4, 80)
        Me.ProgBar.Name = "ProgBar"
        Me.ProgBar.Size = New System.Drawing.Size(281, 15)
        Me.ProgBar.TabIndex = 11
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(144, 101)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(113, 44)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnPost
        '
        Me.btnPost.Image = CType(resources.GetObject("btnPost.Image"), System.Drawing.Image)
        Me.btnPost.Location = New System.Drawing.Point(25, 101)
        Me.btnPost.Name = "btnPost"
        Me.btnPost.Size = New System.Drawing.Size(113, 44)
        Me.btnPost.TabIndex = 2
        Me.btnPost.Text = "P&ost"
        Me.btnPost.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPost.UseVisualStyleBackColor = True
        '
        'frmAccPostAll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 151)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPost)
        Me.Controls.Add(Me.ProgBar)
        Me.Controls.Add(Me.GpVouchers)
        Me.Name = "frmAccPostAll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Posting Vouchers"
        Me.GpVouchers.ResumeLayout(False)
        Me.GpVouchers.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GpVouchers As System.Windows.Forms.GroupBox
    Friend WithEvents cboEndVoucher As System.Windows.Forms.ComboBox
    Friend WithEvents cboStVoucher As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProgBar As System.Windows.Forms.ProgressBar
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnPost As System.Windows.Forms.Button
End Class
