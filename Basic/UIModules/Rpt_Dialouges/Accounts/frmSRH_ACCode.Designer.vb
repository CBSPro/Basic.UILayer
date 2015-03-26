<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSRH_ACCode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSRH_ACCode))
        Me.GpLevel = New System.Windows.Forms.GroupBox
        Me.rdbAll = New System.Windows.Forms.RadioButton
        Me.rdbThird = New System.Windows.Forms.RadioButton
        Me.rdbSecond = New System.Windows.Forms.RadioButton
        Me.rdbFirst = New System.Windows.Forms.RadioButton
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOk = New System.Windows.Forms.Button
        Me.GpLevel.SuspendLayout()
        Me.SuspendLayout()
        '
        'GpLevel
        '
        Me.GpLevel.Controls.Add(Me.rdbAll)
        Me.GpLevel.Controls.Add(Me.rdbThird)
        Me.GpLevel.Controls.Add(Me.rdbSecond)
        Me.GpLevel.Controls.Add(Me.rdbFirst)
        Me.GpLevel.Location = New System.Drawing.Point(6, 6)
        Me.GpLevel.Name = "GpLevel"
        Me.GpLevel.Size = New System.Drawing.Size(538, 48)
        Me.GpLevel.TabIndex = 8
        Me.GpLevel.TabStop = False
        '
        'rdbAll
        '
        Me.rdbAll.AutoSize = True
        Me.rdbAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbAll.Location = New System.Drawing.Point(43, 13)
        Me.rdbAll.Name = "rdbAll"
        Me.rdbAll.Size = New System.Drawing.Size(41, 20)
        Me.rdbAll.TabIndex = 0
        Me.rdbAll.TabStop = True
        Me.rdbAll.Text = "All"
        Me.rdbAll.UseVisualStyleBackColor = True
        '
        'rdbThird
        '
        Me.rdbThird.AutoSize = True
        Me.rdbThird.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbThird.Location = New System.Drawing.Point(408, 13)
        Me.rdbThird.Name = "rdbThird"
        Me.rdbThird.Size = New System.Drawing.Size(98, 20)
        Me.rdbThird.TabIndex = 3
        Me.rdbThird.TabStop = True
        Me.rdbThird.Text = "Level Three"
        Me.rdbThird.UseVisualStyleBackColor = True
        '
        'rdbSecond
        '
        Me.rdbSecond.AutoSize = True
        Me.rdbSecond.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbSecond.Location = New System.Drawing.Point(270, 13)
        Me.rdbSecond.Name = "rdbSecond"
        Me.rdbSecond.Size = New System.Drawing.Size(88, 20)
        Me.rdbSecond.TabIndex = 2
        Me.rdbSecond.TabStop = True
        Me.rdbSecond.Text = "Level Two"
        Me.rdbSecond.UseVisualStyleBackColor = True
        '
        'rdbFirst
        '
        Me.rdbFirst.AutoSize = True
        Me.rdbFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbFirst.Location = New System.Drawing.Point(133, 13)
        Me.rdbFirst.Name = "rdbFirst"
        Me.rdbFirst.Size = New System.Drawing.Size(87, 20)
        Me.rdbFirst.TabIndex = 1
        Me.rdbFirst.TabStop = True
        Me.rdbFirst.Text = "Level One"
        Me.rdbFirst.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(272, 72)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(108, 50)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnOk
        '
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.Location = New System.Drawing.Point(154, 72)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(108, 50)
        Me.btnOk.TabIndex = 4
        Me.btnOk.Text = "&Ok"
        Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'frmSRH_ACCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 131)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.GpLevel)
        Me.Name = "frmSRH_ACCode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Account Codes"
        Me.GpLevel.ResumeLayout(False)
        Me.GpLevel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GpLevel As System.Windows.Forms.GroupBox
    Friend WithEvents rdbThird As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSecond As System.Windows.Forms.RadioButton
    Friend WithEvents rdbFirst As System.Windows.Forms.RadioButton
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents rdbAll As System.Windows.Forms.RadioButton
End Class
