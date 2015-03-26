Imports System.Data
Imports System.Data.SqlClient
Imports Basic.DAL
Imports Basic.DAL.Utils
Imports Basic.Constants

Public Class frmRPT_TrialBal

    Dim ObjFind As Grid_Help
    Dim strFind As String
    Dim mReport As String
    Dim RepName As String
    Dim StrRepHdr1 As String
    Dim StrRepHdr2 As String
    Dim StrRepHdr3 As String
    Dim StrFilter As String

    Private Sub frmRPT_TrialBal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Label15.Text = "Activity Trial" Then
            Constants.ProjConst.mTBal = False
        ElseIf Label15.Text = "Trial Balance" Then
            Constants.ProjConst.mATrial = False
        End If

    End Sub

    Private Sub frmRPT_TrialBal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.MdiParent = frmMdi
        Call SetParms()
        Call SetAccParam()
        dtpStartDate.Value = Constants.ProjConst.SySDate
        dtpEndDate.Value = Constants.ProjConst.SySDate
        mskStartCode.Mask = aMaskCode
        mskEndCode.Mask = aMaskCode

        If Constants.ProjConst.pPara = 16 Then
            Label15.Text = "Trial Balance"
            Me.Text = "Trial Balance"
            GpCodes.Visible = False
            GpData.Height = 160
            btnPreview.Top = 220
            btnPrint.Top = 220
            btnCancel.Top = 220
            Me.Height = 320
        ElseIf Constants.ProjConst.pPara = 17 Then
            Me.Text = "Activity Trial"
            Label15.Text = "Activity Trial"
            GpCodes.Visible = True
            GpData.Height = 230
            btnPreview.Top = 300
            btnPrint.Top = 300
            btnCancel.Top = 300
            Me.Height = 400
        End If
        rdbFirst.Checked = True
    End Sub

    Private Sub txtRefBrCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRefBrCode.KeyDown
        ObjFind = New Grid_Help
        If e.KeyCode = Keys.F1 Then
            ObjFind.PMessage = "Branch"
            strFind = "SELECT BrCode,BrName FROM Branch Order By BrCode"
            ObjFind.sqlqueryFun = strFind
            ObjFind.ShowDialog()

            If ObjFind.PbOk = True Then
                Me.txtRefBrCode.Text = ObjFind.strPKfun & ""
                Me.lblBrName.Text = ObjFind.sqlqueryFun & ""
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtRefBrCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtRefBrCode.Validating
        If Trim(txtRefBrCode.Text) <> "" Then
            mSQL = "SELECT BrName FROM Branch WHERE BrCode = '" & Trim(txtRefBrCode.Text) & "'"
            mSQL = GetFldValue(mSQL, "BrName")
            lblBrName.Text = mSQL
            If mSQL = "" Then
                MsgBox("No Record Found", vbInformation, Constants.ProjConst.SysCompany)
                txtRefBrCode.Text = ""
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub mskStartCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mskStartCode.KeyDown
        ObjFind = New Grid_Help
        If e.KeyCode = Keys.F1 Then
            ObjFind.PMessage = "Codes"
            If rdbFirst.Checked = True Then
                strFind = "Select Code,Description From Codes " & _
                       "Where Right(Code,6) = '000000'"
            ElseIf rdbSecond.Checked = True Then
                strFind = "Select Code,Description From Codes " & _
                       "Where Right(Code,6) <> '000000' And " & _
                       "Right(Code,4) = '0000'"
            ElseIf rdbThird.Checked = True Then
                strFind = "Select Code,Description From Codes " & _
                       "Where (Right(Code,6) <> '000000' And " & _
                       "Right(Code,4) <> '0000')"
            End If
            ObjFind.sqlqueryFun = strFind
            ObjFind.ShowDialog()

            If ObjFind.PbOk = True Then
                Me.mskStartCode.Text = ObjFind.strPKfun & ""
                Me.lblStartName.Text = ObjFind.sqlqueryFun & ""
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub mskStartCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mskStartCode.Validating
        If mskStartCode.Text <> aEmpMaskCode Then
            If rdbFirst.Checked = True Then
                If Mid(aCode2Str(mskStartCode.Text), 3, 6) <> "000000" Then
                    MsgBox("Invalid Code For The Selected Level", vbInformation, Constants.ProjConst.SysCompany)
                    mskStartCode.Text = aEmptyCode
                    e.Cancel = True
                    mskStartCode.Text = " "
                    mskStartCode.Focus()
                    Exit Sub
                End If
            ElseIf rdbSecond.Checked = True Then
                If Mid(aCode2Str(mskStartCode.Text), 3, 6) = "000000" Or Mid(aCode2Str(mskStartCode.Text), 5, 4) <> "0000" Then
                    MsgBox("Invalid Code For The Selected Level", vbInformation, Constants.ProjConst.SysCompany)
                    mskStartCode.Text = aEmptyCode
                    e.Cancel = True
                    mskStartCode.Focus()
                    Exit Sub
                End If
            ElseIf rdbThird.Checked = True Then
                If Mid(aCode2Str(mskStartCode.Text), 3, 6) = "000000" Or Mid(aCode2Str(mskStartCode.Text), 5, 4) = "0000" Then
                    MsgBox("Invalid Code For The Selected Level", vbInformation, Constants.ProjConst.SysCompany)
                    mskStartCode.Text = aEmptyCode
                    e.Cancel = True
                    mskStartCode.Focus()
                    Exit Sub
                End If
            End If
            If Not ChkCode(aCode2Str(mskStartCode.Text)) Then
                e.Cancel = True
                Call mskStartCode_KeyDown(Nothing, Nothing)
            Else
                mSQL = "Select Description From Codes " & _
                       "Where Code = '" & aCode2Str(mskStartCode.Text) & "'"
                mSQL = GetFldValue(mSQL, "Description")
                lblStartName.Text = mSQL
                mskEndCode.Text = mskStartCode.Text
                lblEndName.Text = mSQL
            End If
        End If
    End Sub

    Private Sub mskEndCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mskEndCode.KeyDown
        ObjFind = New Grid_Help
        If e.KeyCode = Keys.F1 Then
            ObjFind.PMessage = "Codes"
            If rdbFirst.Checked = True Then
                strFind = "Select Code,Description From Codes " & _
                       "Where Right(Code,6) = '000000'"
            ElseIf rdbSecond.Checked = True Then
                strFind = "Select Code,Description From Codes " & _
                       "Where Right(Code,6) <> '000000' And " & _
                       "Right(Code,4) = '0000'"
            ElseIf rdbThird.Checked = True Then
                strFind = "Select Code,Description From Codes " & _
                       "Where (Right(Code,6) <> '000000' And " & _
                       "Right(Code,4) <> '0000')"
            End If
            ObjFind.sqlqueryFun = strFind
            ObjFind.ShowDialog()

            If ObjFind.PbOk = True Then
                Me.mskEndCode.Text = ObjFind.strPKfun & ""
                Me.lblEndName.Text = ObjFind.sqlqueryFun & ""
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub mskEndCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mskEndCode.Validating
        If mskEndCode.Text <> aEmpMaskCode Then
            If rdbFirst.Checked = True Then
                If Mid(aCode2Str(mskEndCode.Text), 3, 6) <> "000000" Then
                    MsgBox("Invalid Code For The Selected Level", vbInformation, Constants.ProjConst.SysCompany)
                    mskEndCode.Text = aEmptyCode
                    e.Cancel = True
                    mskEndCode.Focus()
                    Exit Sub
                End If
            ElseIf rdbSecond.Checked = True Then
                If Mid(aCode2Str(mskEndCode.Text), 3, 6) = "000000" Or Mid(aCode2Str(mskEndCode.Text), 5, 4) <> "0000" Then
                    MsgBox("Invalid Code For The Selected Level", vbInformation, Constants.ProjConst.SysCompany)
                    mskEndCode.Text = aEmptyCode
                    e.Cancel = True
                    mskEndCode.Focus()
                    Exit Sub
                End If
            ElseIf rdbThird.Checked = True Then
                If Mid(aCode2Str(mskEndCode.Text), 3, 6) = "000000" Or Mid(aCode2Str(mskEndCode.Text), 5, 4) = "0000" Then
                    MsgBox("Invalid Code For The Selected Level", vbInformation, Constants.ProjConst.SysCompany)
                    mskEndCode.Text = aEmptyCode
                    e.Cancel = True
                    mskEndCode.Focus()
                    Exit Sub
                End If
            End If
            If Not ChkCode(aCode2Str(mskEndCode.Text)) Then
                e.Cancel = True
                Call mskEndCode_KeyDown(Nothing, Nothing)
            Else
                mSQL = "Select Description From Codes " & _
                       "Where Code = '" & aCode2Str(mskEndCode.Text) & "'"
                mSQL = GetFldValue(mSQL, "Description")
                lblEndName.Text = mSQL
            End If
        End If
    End Sub

    Private Sub btnPreview_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Call CallReport(0)
    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Call CallReport(0)
    End Sub

    Sub CallReport(ByVal mPara As Integer)
        'Dim CReports As New Crystal.CrystalReport

        Dim Level As Integer
        If rdbFirst.Checked = True Then
            Level = 1
            If Constants.ProjConst.pPara = 16 Then
                RepName = "Trialb.Rpt"
            ElseIf Constants.ProjConst.pPara = 17 Then
                RepName = "ActivityRep.Rpt"
            End If
        ElseIf rdbSecond.Checked = True Then
            Level = 2
            If Constants.ProjConst.pPara = 16 Then
                RepName = "Trialb.Rpt"
            ElseIf Constants.ProjConst.pPara = 17 Then
                RepName = "ActivityRep.Rpt"
            End If
        ElseIf rdbThird.Checked = True Then
            Level = 3
            If Constants.ProjConst.pPara = 16 Then
                RepName = "Trialb.Rpt"
            ElseIf Constants.ProjConst.pPara = 17 Then
                RepName = "ActivityRep.Rpt"
            End If
        End If

        ' ''***************
        ' ''Report Printing
        ' ''***************

        Dim path As String = Constants.ProjConst.RepPath & RepName

        Dim rptDoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptDoc.Load(path)

        'StrRepHdr1 = "From " & txtStart.Text & " To " & txtEnd.Text
        'StrRepHdr2 = ""

        If Constants.ProjConst.pPara = 16 Then
            rptDoc.SetParameterValue(0, Trim(txtRefBrCode.Text))
            rptDoc.SetParameterValue(1, GetDate(dtpStartDate.Text, "dd-MMM-yyyy"))
            rptDoc.SetParameterValue(2, GetDate(dtpEndDate.Text, "dd-MMM-yyyy"))
            rptDoc.SetParameterValue(3, Val(Level))
        ElseIf Constants.ProjConst.pPara = 17 Then
            rptDoc.SetParameterValue(0, Trim(txtRefBrCode.Text))
            rptDoc.SetParameterValue(1, GetDate(dtpStartDate.Text, "dd-MMM-yyyy"))
            rptDoc.SetParameterValue(2, GetDate(dtpEndDate.Text, "dd-MMM-yyyy"))
            rptDoc.SetParameterValue(3, Val(Level))
            rptDoc.SetParameterValue(4, aCode2Str(mskStartCode.Text))
            rptDoc.SetParameterValue(5, aCode2Str(mskEndCode.Text))
        End If

        If Constants.ProjConst.pPara = 16 Then
            RepName = "Trial Balance Sheet"
            'strHeader1 = "Code from " + mskStartCode.Text + "  To  " + mskEndCode.Text
            strHeader2 = "From Date " + GetDate(dtpEndDate.Text, "dd-MMM-yyyy") + "  To  " + GetDate(dtpEndDate.Text, "dd-MMM-yyyy")
        ElseIf Constants.ProjConst.pPara = 17 Then
            RepName = "Activity Reports"
            'strHeader1 = "Code from " + mskStartCode.Text + "  To  " + mskEndCode.Text
            strHeader2 = "From Date " + GetDate(dtpEndDate.Text, "dd-MMM-yyyy") + "  To  " + GetDate(dtpEndDate.Text, "dd-MMM-yyyy")
        End If

        strHeader1 = "Level 0" + CStr(Level)
        rptDoc.SetParameterValue("@ComDetail", Trim(lblBrName.Text))
        rptDoc.SetParameterValue("@RepTitle", RepName)
        rptDoc.SetParameterValue("@RepHeader1", strHeader1)
        rptDoc.SetParameterValue("@RepHeader2", strHeader2)

        frmReport.Show()
        frmReport.ShowTransReport(rptDoc, Constants.ProjConst.SysCompany)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub dtpEndDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpEndDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub dtpStartDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpStartDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub rdbFirst_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rdbFirst.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub rdbSecond_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rdbSecond.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub rdbThird_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rdbThird.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub mskStartCode_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles mskStartCode.MaskInputRejected

    End Sub

    Private Sub mskEndCode_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles mskEndCode.MaskInputRejected

    End Sub

    Private Sub dtpStartDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtpStartDate.Validating
        If dtpStartDate.Value > Constants.ProjConst.SySDate Then
            MsgBox("Starting Date Cannot Be Greater Than Current Date", vbInformation, Constants.ProjConst.SysCompany)
            e.Cancel = True
            dtpStartDate.Text = Constants.ProjConst.SySDate
        End If
    End Sub

    Private Sub dtpStartDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpStartDate.ValueChanged

    End Sub

    Private Sub dtpEndDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtpEndDate.Validating
        If dtpEndDate.Value > Constants.ProjConst.SySDate Then
            MsgBox("Ending Date Cannot Be Greater Than Current Date", vbInformation, Constants.ProjConst.SysCompany)
            e.Cancel = True
            dtpEndDate.Text = Constants.ProjConst.SySDate
        End If
    End Sub

    Private Sub dtpEndDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpEndDate.ValueChanged

    End Sub

    Private Sub frmRPT_TrialBal_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        'Me.WindowState = FormWindowState.Normal
    End Sub

End Class