
Imports System.Data
Imports System.Data.SqlClient
Imports Basic.DAL.Utils
Imports Basic.DAL
Imports Basic.Constants

Public Class frmRPT_CodesStat

    Dim ObjFind As Grid_Help
    Dim strFind As String
    Dim mReport As String
    Dim RepName As String
    Dim StrRepHdr1 As String
    Dim StrRepHdr2 As String
    Dim StrRepHdr3 As String
    Dim StrFilter As String

    Private Sub frmRPT_CodesStat_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Label15.Text = "A/C Code Status" Then
            Constants.ProjConst.mAcCStatus = False
        ElseIf Label15.Text = "Bank Book" Then
            Constants.ProjConst.mBBook = False
        ElseIf Label15.Text = "Cash Book" Then
            Constants.ProjConst.mCBook = False
        ElseIf Label15.Text = "Schedule For Subledger" Then
            Constants.ProjConst.mSubLedg = False
        End If

    End Sub
    Private Sub frmRPT_CodesStat_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.MdiParent = frmMdi
        Call SetParms()
        Call SetAccParam()
        dtpStartDate.Value = Constants.ProjConst.SySDate
        dtpEndDate.Value = Constants.ProjConst.SySDate
        mskStartCode.Mask = aMaskCode
        mskEndCode.Mask = aMaskCode

        If Constants.ProjConst.pPara = 12 Then
            Label15.Text = "A/C Code Status"
            Me.Text = "A/C Code Status"
            StrFilter = " AND (Substring(Code," & aP1P & "," & aP1L & ")<>'" & pBank & "' " & _
                        "AND Substring(Code," & aP1P & "," & aP1L & ")<>'" & pCash & "')"
            RepName = "GLAcStatus.Rpt"
        ElseIf Constants.ProjConst.pPara = 13 Then
            Label15.Text = "Bank Book"
            Me.Text = "Bank Book"
            StrFilter = " AND Substring(Code," & aP1P & "," & aP1L & ")='" & pBank & "'"
            RepName = "GLAcStatus.Rpt"
        ElseIf Constants.ProjConst.pPara = 14 Then
            Label15.Text = "Cash Book"
            Me.Text = "Cash Book"
            RepName = "GLAcStatus.Rpt"
            StrFilter = " AND Substring(Code," & aP1P & "," & aP1L & ")='" & pCash & "'"
        ElseIf Constants.ProjConst.pPara = 15 Then
            Label15.Text = "Schedule For Subledger"
            Me.Text = "Schedule For Subledger"
            StrFilter = ""
            RepName = "Sschedule.Rpt"
        End If
        Call ClearAll()
        If Constants.ProjConst.pPara = 15 Then
            'txtRefBrCode.Focus()
        End If
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
            'strFind = "SELECT Code,Description FROM Codes Order By Code"
            If Label15.Text = "A/C Code Status" Then
                strFind = "SELECT Code,Description FROM Codes " & _
                       "where Len(Code)= " & aCodeL & StrFilter
            ElseIf Label15.Text = "Bank Book" Then
                strFind = "Select Code,Description From Codes " & _
                       "Where Len(Code)= " & aCodeL & StrFilter
            ElseIf Label15.Text = "Cash Book" Then
                strFind = "Select Code,Description From Codes " & _
                       "Where Len(Code)= " & aCodeL & StrFilter
            ElseIf Label15.Text = "Schedule For Subledger" Then
                strFind = "Select Code,Description From Codes"
            End If
            ObjFind.sqlqueryFun = strFind
            ObjFind.ShowDialog()

            If ObjFind.PbOk = True Then
                Me.mskStartCode.Text = ObjFind.strPKfun & ""
                'Me.lblStartName.Text = ObjFind.sqlqueryFun & ""
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub mskEndCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mskEndCode.KeyDown
        ObjFind = New Grid_Help
        If e.KeyCode = Keys.F1 Then
            ObjFind.PMessage = "Codes"
            'strFind = "SELECT Code,Description FROM Codes Order By Code"
            If Label15.Text = "A/C Code Status" Then
                strFind = "SELECT Code,Description FROM Codes " & _
                       "where Len(Code)= " & aCodeL & StrFilter
            ElseIf Label15.Text = "Bank Book" Then
                strFind = "Select Code,Description From Codes " & _
                       "Where Len(Code)= " & aCodeL & StrFilter
            ElseIf Label15.Text = "Cash Book" Then
                strFind = "Select Code,Description From Codes " & _
                       "Where Len(Code)= " & aCodeL & StrFilter
            ElseIf Label15.Text = "Schedule For Subledger" Then
                strFind = "Select Code,Description From Codes"
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

    Private Sub mskStartCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mskStartCode.Validating
        If mskStartCode.Text <> aEmptyCode Then
            If Not (Len(aCode2Str(mskStartCode.Text)) = aP1L Or Len(aCode2Str(mskStartCode.Text)) = aP1L + aP2L + aP3L Or Len(aCode2Str(mskStartCode.Text)) = aCodeL) Then
                MsgBox("Invalid Code Length", vbInformation, Constants.ProjConst.SysCompany)
                mskStartCode.Text = aEmptyCode
                e.Cancel = True
                Exit Sub
            ElseIf Constants.ProjConst.pPara = 12 Then
                mSQL = "Select Code From Codes Where Code = '" & aCode2Str(mskStartCode.Text) & "' " & StrFilter
                mSQL = GetFldValue(mSQL, "Code")
                If mSQL <> "" Then
                    mSQL = "SELECT Description FROM Codes WHERE Code = '" & aCode2Str(mskStartCode.Text) & "'"
                    mSQL = GetFldValue(mSQL, "Description")
                    lblStartName.Text = mSQL
                    Exit Sub
                Else
                    MsgBox("Cash / Bank Code Is Not Allowed Here", vbInformation, Constants.ProjConst.SysCompany)
                    mskStartCode.Text = aEmptyCode
                    lblStartName.Text = ""
                    mskStartCode.Focus()
                    e.Cancel = True
                End If
            ElseIf Constants.ProjConst.pPara = 13 Then
                mSQL = "Select Code From Codes Where Code = '" & aCode2Str(mskStartCode.Text) & "' " & StrFilter
                mSQL = GetFldValue(mSQL, "Code")
                If mSQL <> "" Then
                    mSQL = "SELECT Description FROM Codes WHERE Code = '" & aCode2Str(mskStartCode.Text) & "'"
                    mSQL = GetFldValue(mSQL, "Description")
                    lblStartName.Text = mSQL
                    Exit Sub
                Else
                    MsgBox("Only Bank Code Is Allowed Here", vbInformation, Constants.ProjConst.SysCompany)
                    mskStartCode.Text = aEmptyCode
                    lblStartName.Text = ""
                    mskStartCode.Focus()
                    e.Cancel = True
                End If
            ElseIf Constants.ProjConst.pPara = 14 Then
                mSQL = "Select Code From Codes Where Code = '" & aCode2Str(mskStartCode.Text) & "' " & StrFilter
                mSQL = GetFldValue(mSQL, "Code")
                If mSQL <> "" Then
                    mSQL = "SELECT Description FROM Codes WHERE Code = '" & aCode2Str(mskStartCode.Text) & "'"
                    mSQL = GetFldValue(mSQL, "Description")
                    lblStartName.Text = mSQL
                Else
                    MsgBox("Only Cash Code Is Allowed Here", vbInformation, Constants.ProjConst.SysCompany)
                    mskStartCode.Text = aEmptyCode
                    lblStartName.Text = ""
                    mskStartCode.Focus()
                    e.Cancel = True
                End If
            ElseIf Constants.ProjConst.pPara = 15 Then
                mSQL = "Select Code From Codes Where Code = '" & aCode2Str(mskStartCode.Text) & "'"
                mSQL = GetFldValue(mSQL, "Code")
                If mSQL <> "" Then
                    mSQL = "SELECT Description FROM Codes WHERE Code = '" & aCode2Str(mskStartCode.Text) & "'"
                    mSQL = GetFldValue(mSQL, "Description")
                    lblStartName.Text = mSQL
                Else
                    MsgBox("Code Is Not Found", vbInformation, Constants.ProjConst.SysCompany)
                    mskStartCode.Text = aEmptyCode
                    lblStartName.Text = ""
                    mskStartCode.Focus()
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub mskEndCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mskEndCode.Validating
        If mskEndCode.Text <> aEmptyCode Then
            If Not (Len(aCode2Str(mskEndCode.Text)) = aP1L Or Len(aCode2Str(mskEndCode.Text)) = aP1L + aP2L + aP3L Or Len(aCode2Str(mskEndCode.Text)) = aCodeL) Then
                MsgBox("Invalid Code Length", vbInformation, Constants.ProjConst.SysCompany)
                mskEndCode.Text = aEmptyCode
                e.Cancel = True
                Exit Sub
            ElseIf Constants.ProjConst.pPara = 12 Then
                mSQL = "Select Code From Codes Where Code = '" & aCode2Str(mskEndCode.Text) & "' " & StrFilter
                mSQL = GetFldValue(mSQL, "Code")
                If mSQL <> "" Then
                    mSQL = "SELECT Description FROM Codes WHERE Code = '" & aCode2Str(mskEndCode.Text) & "'"
                    mSQL = GetFldValue(mSQL, "Description")
                    lblEndName.Text = mSQL
                Else
                    MsgBox("Cash / Bank Code Is Not Allowed Here", vbInformation, Constants.ProjConst.SysCompany)
                    mskEndCode.Text = aEmptyCode
                    lblEndName.Text = ""
                    mskEndCode.Focus()
                    e.Cancel = True
                End If
            ElseIf Constants.ProjConst.pPara = 13 Then
                mSQL = "Select Code From Codes Where Code = '" & aCode2Str(mskEndCode.Text) & "' " & StrFilter
                mSQL = GetFldValue(mSQL, "Code")
                If mSQL <> "" Then
                    mSQL = "SELECT Description FROM Codes WHERE Code = '" & aCode2Str(mskEndCode.Text) & "'"
                    mSQL = GetFldValue(mSQL, "Description")
                    lblEndName.Text = mSQL
                Else
                    MsgBox("Only Bank Code Is Allowed Here", vbInformation, Constants.ProjConst.SysCompany)
                    mskEndCode.Text = aEmptyCode
                    lblEndName.Text = ""
                    mskEndCode.Focus()
                    e.Cancel = True
                End If
            ElseIf Constants.ProjConst.pPara = 14 Then
                mSQL = "Select Code From Codes Where Code = '" & aCode2Str(mskEndCode.Text) & "' " & StrFilter
                mSQL = GetFldValue(mSQL, "Code")
                If mSQL <> "" Then
                    mSQL = "SELECT Description FROM Codes WHERE Code = '" & aCode2Str(mskEndCode.Text) & "'"
                    mSQL = GetFldValue(mSQL, "Description")
                    lblEndName.Text = mSQL
                Else
                    MsgBox("Only Cash Code Is Allowed Here", vbInformation, Constants.ProjConst.SysCompany)
                    mskEndCode.Text = aEmptyCode
                    lblEndName.Text = ""
                    mskEndCode.Focus()
                    e.Cancel = True
                End If
            ElseIf Constants.ProjConst.pPara = 15 Then
                mSQL = "Select Code From Codes Where Code = '" & aCode2Str(mskEndCode.Text) & "'"
                mSQL = GetFldValue(mSQL, "Code")
                If mSQL <> "" Then
                    mSQL = "SELECT Description FROM Codes WHERE Code = '" & aCode2Str(mskEndCode.Text) & "'"
                    mSQL = GetFldValue(mSQL, "Description")
                    lblEndName.Text = mSQL
                Else
                    MsgBox("Code Is Not Found", vbInformation, Constants.ProjConst.SysCompany)
                    mskEndCode.Text = aEmptyCode
                    lblEndName.Text = ""
                    mskEndCode.Focus()
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub btnPreview_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Call CallReport(0)
    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Call CallReport(1)
    End Sub

    Sub CallReport(ByVal mPara As Integer)
        'Dim CReports As New Crystal.CrystalReport

        If Trim(txtRefBrCode.Text) = "" Then
            MsgBox("Branch Code Can't be Empty", vbInformation, Constants.ProjConst.SysCompany)
            txtRefBrCode.Focus()
            Exit Sub
        ElseIf Trim(mskStartCode.Text) = aEmptyCode Then
            MsgBox("Starting Code Can't be Empty", vbInformation, Constants.ProjConst.SysCompany)
            mskStartCode.Focus()
            Exit Sub
        ElseIf Trim(mskEndCode.Text) = aEmptyCode Then
            MsgBox("Ending Code Can't be Empty", vbInformation, Constants.ProjConst.SysCompany)
            mskEndCode.Focus()
            Exit Sub
        End If

        ' ''***************
        ' ''Report Printing
        ' ''***************

        Dim path As String = Constants.ProjConst.RepPath & RepName

        Dim rptDoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptDoc.Load(path)

        'StrRepHdr1 = "From " & txtStart.Text & " To " & txtEnd.Text
        'StrRepHdr2 = ""
        'If Label15.Text = "A/C Code Status" Then
        '    strFind = "SELECT Code,Description FROM Codes " & _
        '           "where Len(Code)= " & aCodeL & StrFilter
        'ElseIf Label15.Text = "Bank Book" Then
        '    strFind = "Select Code,Description From Codes " & _
        '           "Where Len(Code)= " & aCodeL & StrFilter
        'ElseIf Label15.Text = "Cash Book" Then
        '    strFind = "Select Code,Description From Codes " & _
        '           "Where Len(Code)= " & aCodeL & StrFilter
        'ElseIf Label15.Text = "Schedule For Subledger" Then
        '    strFind = "Select Code,Description From Codes"
        'End If

        If (Label15.Text = "A/C Code Status" Or Label15.Text = "Schedule For Subledger") Then
            rptDoc.SetParameterValue(0, Trim(txtRefBrCode.Text))
            rptDoc.SetParameterValue(1, aCode2Str(mskStartCode.Text))
            rptDoc.SetParameterValue(2, aCode2Str(mskEndCode.Text))
            rptDoc.SetParameterValue(3, GetDate(dtpStartDate.Text, "dd-MMM-yyyy"))
            rptDoc.SetParameterValue(4, GetDate(dtpEndDate.Text, "dd-MMM-yyyy"))
            Constants.ProjConst.RepTitle = "Schedule For Subledger"
            strHeader1 = "From Code " + mskStartCode.Text + "  To  " + mskEndCode.Text
            strHeader2 = "From Date " + GetDate(dtpStartDate.Text, "dd-MMM-yyyy") + "  To  " + GetDate(dtpEndDate.Text, "dd-MMM-yyyy")

        ElseIf (Label15.Text = "Bank Book" Or Label15.Text = "Cash Book" Or Label15.Text = "Cash Book") Then
            rptDoc.SetParameterValue(0, Trim(txtRefBrCode.Text))
            rptDoc.SetParameterValue(1, aCode2Str(mskStartCode.Text))
            rptDoc.SetParameterValue(2, aCode2Str(mskEndCode.Text))
            rptDoc.SetParameterValue(3, GetDate(dtpStartDate.Text, "dd-MMM-yyyy"))
            rptDoc.SetParameterValue(4, GetDate(dtpEndDate.Text, "dd-MMM-yyyy"))
            If Constants.ProjConst.pPara = 12 Then
                Constants.ProjConst.RepTitle = "Acccount Code Status"
                strHeader1 = "From Code " + mskStartCode.Text + "  To  " + mskEndCode.Text
                strHeader2 = "From Date " + GetDate(dtpStartDate.Text, "dd-MMM-yyyy") + "  To  " + GetDate(dtpEndDate.Text, "dd-MMM-yyyy")
                'rptDoc.SetParameterValue("@RepHeader1", strHeader1)
            ElseIf Constants.ProjConst.pPara = 13 Then
                Constants.ProjConst.RepTitle = "Bank Book"
                strHeader1 = "From Code " + mskStartCode.Text + "  To  " + mskEndCode.Text
                strHeader2 = "From Date " + GetDate(dtpStartDate.Text, "dd-MMM-yyyy") + "  To  " + GetDate(dtpEndDate.Text, "dd-MMM-yyyy")
                'rptDoc.SetParameterValue("@RepHeader1", strHeader1)
            ElseIf Constants.ProjConst.pPara = 14 Then
                Constants.ProjConst.RepTitle = "Cash Book"
                strHeader1 = "From Code " + mskStartCode.Text + "  To  " + mskEndCode.Text
                strHeader2 = "From Date " + GetDate(dtpStartDate.Text, "dd-MMM-yyyy") + "  To  " + GetDate(dtpEndDate.Text, "dd-MMM-yyyy")
                'rptDoc.SetParameterValue("@RepHeader1", strHeader1)
            End If
        End If
        rptDoc.SetParameterValue("@ComDetail", Trim(lblBrName.Text))
        rptDoc.SetParameterValue("@Reptitle", Constants.ProjConst.RepTitle)
        rptDoc.SetParameterValue("@RepHeader1", strHeader1)
        rptDoc.SetParameterValue("@RepHeader2", strHeader2)
        frmReport.Show()
        frmReport.ShowTransReport(rptDoc, RepName) '"GLAcStatus.Rpt"
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Close()
    End Sub

    Sub ClearAll()
        txtRefBrCode.Text = ""
        lblBrName.Text = ""
        mskStartCode.Text = aEmptyCode
        lblStartName.Text = ""
        mskEndCode.Text = aEmptyCode
        lblEndName.Text = ""
    End Sub

    Private Sub dtpStartDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpStartDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub dtpEndDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpEndDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub mskStartCode_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles mskStartCode.MaskInputRejected

    End Sub

    Private Sub mskStartCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskStartCode.LostFocus
        mskEndCode.Text = mskStartCode.Text
    End Sub

    Private Sub dtpStartDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtpStartDate.Validating
        If dtpStartDate.Value > Constants.ProjConst.SySDate Then
            MsgBox("Start Date Cannot Be Greater Than Current Date", vbInformation, Constants.ProjConst.SysCompany)
            e.Cancel = True
            dtpStartDate.Text = Constants.ProjConst.SySDate
        End If
    End Sub

    Private Sub dtpStartDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpStartDate.ValueChanged

    End Sub

    Private Sub dtpEndDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtpEndDate.Validating
        If dtpStartDate.Value > Constants.ProjConst.SySDate Then
            MsgBox("End Date Cannot Be Greater Than Current Date", vbInformation, Constants.ProjConst.SysCompany)
            e.Cancel = True
            dtpStartDate.Text = Constants.ProjConst.SySDate
        End If
    End Sub

    Private Sub dtpEndDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpEndDate.ValueChanged

    End Sub

    Private Sub frmRPT_CodesStat_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        'Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub txtRefBrCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRefBrCode.TextChanged

    End Sub

    Private Sub mskEndCode_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles mskEndCode.MaskInputRejected

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class