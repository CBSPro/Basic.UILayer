<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPT_PrtTBall
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPT_PrtTBall))
        Me.GpData = New System.Windows.Forms.GroupBox
        Me.lblProcess = New System.Windows.Forms.Label
        Me.ProgBar = New System.Windows.Forms.ProgressBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.GpLevel = New System.Windows.Forms.GroupBox
        Me.rdbThird = New System.Windows.Forms.RadioButton
        Me.rdbSecond = New System.Windows.Forms.RadioButton
        Me.rdbFirst = New System.Windows.Forms.RadioButton
        Me.btnProcess = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.GpData.SuspendLayout()
        Me.GpLevel.SuspendLayout()
        Me.SuspendLayout()
        '
        'GpData
        '
        Me.GpData.Controls.Add(Me.lblProcess)
        Me.GpData.Controls.Add(Me.ProgBar)
        Me.GpData.Controls.Add(Me.Label1)
        Me.GpData.Controls.Add(Me.dtpDate)
        Me.GpData.Controls.Add(Me.GpLevel)
        Me.GpData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpData.Location = New System.Drawing.Point(8, 0)
        Me.GpData.Name = "GpData"
        Me.GpData.Size = New System.Drawing.Size(360, 198)
        Me.GpData.TabIndex = 2
        Me.GpData.TabStop = False
        '
        'lblProcess
        '
        Me.lblProcess.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcess.Location = New System.Drawing.Point(10, 158)
        Me.lblProcess.Name = "lblProcess"
        Me.lblProcess.Size = New System.Drawing.Size(344, 13)
        Me.lblProcess.TabIndex = 11
        '
        'ProgBar
        '
        Me.ProgBar.Location = New System.Drawing.Point(6, 177)
        Me.ProgBar.Name = "ProgBar"
        Me.ProgBar.Size = New System.Drawing.Size(348, 15)
        Me.ProgBar.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(110, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "As On"
        '
        'dtpDate
        '
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(152, 127)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(90, 22)
        Me.dtpDate.TabIndex = 8
        Me.dtpDate.Value = New Date(2009, 2, 24, 0, 0, 0, 0)
        '
        'GpLevel
        '
        Me.GpLevel.Controls.Add(Me.rdbThird)
        Me.GpLevel.Controls.Add(Me.rdbSecond)
        Me.GpLevel.Controls.Add(Me.rdbFirst)
        Me.GpLevel.Location = New System.Drawing.Point(55, 15)
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
        'btnProcess
        '
        Me.btnProcess.Image = CType(resources.GetObject("btnProcess.Image"), System.Drawing.Image)
        Me.btnProcess.Location = New System.Drawing.Point(77, 198)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(108, 50)
        Me.btnProcess.TabIndex = 12
        Me.btnProcess.Text = "&Process"
        Me.btnProcess.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(201, 198)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(108, 50)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "&Close"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmRPT_PrtTBall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 254)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GpData)
        Me.Name = "frmRPT_PrtTBall"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trial Balance (All Branches)"
        Me.GpData.ResumeLayout(False)
        Me.GpData.PerformLayout()
        Me.GpLevel.ResumeLayout(False)
        Me.GpLevel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GpData As System.Windows.Forms.GroupBox
    Friend WithEvents GpLevel As System.Windows.Forms.GroupBox
    Friend WithEvents rdbThird As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSecond As System.Windows.Forms.RadioButton
    Friend WithEvents rdbFirst As System.Windows.Forms.RadioButton
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProgBar As System.Windows.Forms.ProgressBar
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblProcess As System.Windows.Forms.Label
End Class
