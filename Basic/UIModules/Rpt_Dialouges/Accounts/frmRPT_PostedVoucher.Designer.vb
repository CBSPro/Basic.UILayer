<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPT_PostedVoucher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPT_PostedVoucher))
        Me.GpSearch = New System.Windows.Forms.GroupBox
        Me.txtEndVNo = New System.Windows.Forms.TextBox
        Me.txtStartVNo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboType = New System.Windows.Forms.ComboBox
        Me.cboBranch = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnPreview = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.GpSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'GpSearch
        '
        Me.GpSearch.Controls.Add(Me.txtEndVNo)
        Me.GpSearch.Controls.Add(Me.txtStartVNo)
        Me.GpSearch.Controls.Add(Me.Label4)
        Me.GpSearch.Controls.Add(Me.Label3)
        Me.GpSearch.Controls.Add(Me.cboType)
        Me.GpSearch.Controls.Add(Me.cboBranch)
        Me.GpSearch.Controls.Add(Me.Label2)
        Me.GpSearch.Controls.Add(Me.Label1)
        Me.GpSearch.Location = New System.Drawing.Point(9, 0)
        Me.GpSearch.Name = "GpSearch"
        Me.GpSearch.Size = New System.Drawing.Size(345, 117)
        Me.GpSearch.TabIndex = 0
        Me.GpSearch.TabStop = False
        '
        'txtEndVNo
        '
        Me.txtEndVNo.Location = New System.Drawing.Point(134, 85)
        Me.txtEndVNo.MaxLength = 10
        Me.txtEndVNo.Name = "txtEndVNo"
        Me.txtEndVNo.Size = New System.Drawing.Size(100, 20)
        Me.txtEndVNo.TabIndex = 9
        '
        'txtStartVNo
        '
        Me.txtStartVNo.Location = New System.Drawing.Point(134, 62)
        Me.txtStartVNo.MaxLength = 10
        Me.txtStartVNo.Name = "txtStartVNo"
        Me.txtStartVNo.Size = New System.Drawing.Size(100, 20)
        Me.txtStartVNo.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = " Ending Voucher No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Starting Voucher No."
        '
        'cboType
        '
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.FormattingEnabled = True
        Me.cboType.Location = New System.Drawing.Point(69, 37)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(254, 21)
        Me.cboType.TabIndex = 4
        '
        'cboBranch
        '
        Me.cboBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBranch.FormattingEnabled = True
        Me.cboBranch.Location = New System.Drawing.Point(69, 13)
        Me.cboBranch.Name = "cboBranch"
        Me.cboBranch.Size = New System.Drawing.Size(254, 21)
        Me.cboBranch.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Type"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Branch"
        '
        'btnPreview
        '
        Me.btnPreview.Image = CType(resources.GetObject("btnPreview.Image"), System.Drawing.Image)
        Me.btnPreview.Location = New System.Drawing.Point(21, 121)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(108, 50)
        Me.btnPreview.TabIndex = 15
        Me.btnPreview.Text = "&Preview"
        Me.btnPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(249, 121)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(108, 50)
        Me.btnClose.TabIndex = 17
        Me.btnClose.Text = "&Close"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(135, 121)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(108, 50)
        Me.btnPrint.TabIndex = 16
        Me.btnPrint.Text = "Pr&int"
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'frmRPT_PostedVoucher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 192)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.GpSearch)
        Me.Name = "frmRPT_PostedVoucher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Posted Vouchers"
        Me.GpSearch.ResumeLayout(False)
        Me.GpSearch.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GpSearch As System.Windows.Forms.GroupBox
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
    Friend WithEvents cboBranch As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEndVNo As System.Windows.Forms.TextBox
    Friend WithEvents txtStartVNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
End Class
