<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExportTB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExportTB))
        Me.fpSpread1 = New AxFPSpreadADO.AxfpSpread
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnExport = New System.Windows.Forms.Button
        CType(Me.fpSpread1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fpSpread1
        '
        Me.fpSpread1.DataSource = Nothing
        Me.fpSpread1.Location = New System.Drawing.Point(3, 1)
        Me.fpSpread1.Name = "fpSpread1"
        Me.fpSpread1.OcxState = CType(resources.GetObject("fpSpread1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.fpSpread1.Size = New System.Drawing.Size(785, 406)
        Me.fpSpread1.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(699, 415)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(89, 46)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Image)
        Me.btnExport.Location = New System.Drawing.Point(607, 415)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(89, 46)
        Me.btnExport.TabIndex = 1
        Me.btnExport.Text = "&Exp Range"
        Me.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'frmExportTB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 466)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.fpSpread1)
        Me.Name = "frmExportTB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export Report"
        CType(Me.fpSpread1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents fpSpread1 As AxFPSpreadADO.AxfpSpread
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
End Class
