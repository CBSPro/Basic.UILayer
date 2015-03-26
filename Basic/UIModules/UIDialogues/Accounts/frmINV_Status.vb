Imports System.Data
Imports System.Data.SqlClient
Imports Basic.DAL
Imports Basic.DAL.Utils
Imports Basic.Constants.ProjConst



Public Class frmINV_Status
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
            mAcCStatus = False
        ElseIf Label15.Text = "Bank Book" Then
            mBBook = False
        ElseIf Label15.Text = "Cash Book" Then
            mCBook = False
        ElseIf Label15.Text = "Schedule For Subledger" Then
            mSubLedg = False
        End If

    End Sub
    Private Sub frmRPT_CodesStat_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.MdiParent = frmMdi
        Call SetParms()
        Call SetAccParam()
        dtpSdate.Value = SySDate
        dtpEdate.Value = SySDate
        'mskStartCode.Mask = aMaskCode
        'mskEndCode.Mask = aMaskCode
        If pPara = 12 Or pPara = 25 Then
            If pPara = 12 Then
                Me.Text = "Stock Transaction List - Quantitative"
                Label15.Text = "Stock Transaction List - Quantitative"
                RepTitle = "Stock Transaction List - Quantitative"
                RepName = "StkStore.Rpt"
            Else
                Me.Text = "Rate Comparison Report"
                Label15.Text = "Rate Comparison Report"
                RepTitle = "Rate Comparison Report"
                RepName = "RateComp.Rpt"
            End If
        ElseIf pPara = 13 Then
            Me.Text = "Stock Transaction Summary - Quantitative"
            Label15.Text = "Stock Transaction Summary - Quantitative"
            RepTitle = "Stock Transaction Summary - Quantitative"
            RepName = "StkStoreSum.Rpt"
        ElseIf pPara = 14 Then
            Me.Text = "Stock Position Item Wise - Quantitative"
            Label15.Text = "Stock Position Item Wise - Quantitative"
            RepTitle = "Stock Position Item Wise - Quantitative"
            RepName = "StkStoreBal.Rpt"
            dtpEdate.Visible = False
            Label5.Visible = False
            Label3.Text = "          As on"
            Label3.TextAlign = ContentAlignment.BottomRight
        ElseIf pPara = 15 Then
            Me.Text = "Stock Position Category Wise - Quantitative"
            Label15.Text = "Stock Position Category Wise - Quantitative"
            RepTitle = "Stock Position Category Wise - Quantitative"
            RepName = "CstkStorebal.Rpt"
            Label1.Visible = False
            Label6.Visible = False
            'txtRefBrCode.Visible = False
            mskStoreCode.Visible = False
            'lblBrName.Visible = False
            mskStoreCodeName.Visible = False
            dtpEdate.Visible = False
            Label5.Visible = False
            Label3.Text = "          As on"
            Label3.TextAlign = ContentAlignment.TopLeft
        ElseIf pPara = 16 Then
            Me.Text = "Detailed Stock Movement"
            Label15.Text = "Detailed Stock Movement"
            RepTitle = "Detailed Stock Movement"
            RepName = "StkMove.Rpt"
        ElseIf pPara = 17 Then
            Me.Text = "Stock Movement Summary (All)"
            Label15.Text = "Stock Movement Summary (All)"
            RepTitle = "Stock Movement Summary (All)"
            RepName = "StkSum.Rpt"
        ElseIf pPara = 18 Then
            Me.Text = "Stock Movement Summary - Moving Items"
            Label15.Text = "Stock Movement Summary - Moving Items"
            RepTitle = "Stock Movement Summary - Moving Items"
            RepName = "StkSumMoving.Rpt"
        ElseIf pPara = 19 Then
            Me.Text = "Stock Movement (Non Moving Items Only)"
            Label15.Text = "Stock Movement (Non Moving Items Only)"
            RepTitle = "Stock Movement (Non Moving Items Only)"
            RepName = "StkSumNonMoving.Rpt"
        ElseIf pPara = 20 Then
            Me.Text = "Stock Position - Items Wise"
            Label15.Text = "Stock Position - Items Wise"
            RepTitle = "Stock Position - Items Wise"
            RepName = "Stkbal.Rpt"
            dtpEdate.Visible = False
            Label5.Visible = False
            Label1.Text = "From Category"
            Label4.Text = "To Category"
            Label3.Text = "          As on"
        ElseIf pPara = 21 Then
            Me.Text = "Stock Position - Item Category Wise"
            Label15.Text = "Stock Position - Item Category Wise"
            RepTitle = "Stock Position - Item Category Wise"
            RepName = "Cstkbal.Rpt"
            'Label1.Visible = False
            Label6.Visible = False
            'txtRefBrCode.Visible = False
            mskStoreCode.Visible = False
            'lblBrName.Visible = False
            mskStoreCodeName.Visible = False
            dtpEdate.Visible = False
            Label5.Visible = False
            Label2.Text = "From Category"
            Label4.Text = "To Category"
            Label3.Text = "          As on"
        ElseIf pPara = 22 Or pPara = 23 Or pPara = 24 Then
            If pPara = 22 Then
                Me.Text = "Stock Below Reorder Level"
                Label15.Text = "Stock Below Reorder Level"
                RepTitle = "Stock Below Reorder Level"
                RepName = "StkReordBelow.Rpt"
            ElseIf pPara = 23 Then
                Me.Text = "Stock Above Reorder Level"
                Label15.Text = "Stock Above Reorder Level"
                RepTitle = "Stock Above Reorder Level"
                RepName = "StkReordAbove.Rpt"
            ElseIf pPara = 24 Then
                Me.Text = "Expired Items Report"
                Label15.Text = "Expired Items Report"
                RepTitle = "Expired Items Report"
                RepName = "Expired.Rpt"
            End If
            Label1.Visible = False
            'txtRefBrCode.Visible = False
            'lblBrName.Visible = False
            dtpEdate.Visible = False
            Label5.Visible = False
            Label2.Text = "From Item"
            Label4.Text = "To Item"
            Label3.Text = "          As on"
        End If

        Call ClearAll()
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
                MsgBox("No Record Found", vbInformation, SysCompany)
                txtRefBrCode.Text = ""
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub mskStartCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        ObjFind = New Grid_Help
        If e.KeyCode = Keys.F1 Then
            ObjFind.PMessage = "Codes"
            strFind = "SELECT ItemCode,Description FROM Items Order By Cast(ItemCode as Numeric(20))"
            ObjFind.sqlqueryFun = strFind
            ObjFind.ShowDialog()

            If ObjFind.PbOk = True Then
                'Me.mskStartCode.Text = ObjFind.strPKfun & ""
                'Me.lblStartName.Text = ObjFind.sqlqueryFun & ""
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub mskEndCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
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
                'Me.mskEndCode.Text = ObjFind.strPKfun & ""
                Me.txtECodeName.Text = ObjFind.sqlqueryFun & ""
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub mskStartCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        'If mskStartCode.Text <> aEmptyCode Then
        '    If Not (Len(aCode2Str(mskStartCode.Text)) = aP1L Or Len(aCode2Str(mskStartCode.Text)) = aP1L + aP2L + aP3L Or Len(aCode2Str(mskStartCode.Text)) = aCodeL) Then
        '        MsgBox("Invalid Code Length", vbInformation, SysCompany)
        '        mskStartCode.Text = aEmptyCode
        '        e.Cancel = True
        '        Exit Sub
        '    ElseIf pPara = 12 Then
        '        mSQL = "Select Code From Codes Where Code = '" & aCode2Str(mskStartCode.Text) & "' " & StrFilter
        '        mSQL = GetFldValue(mSQL, "Code")
        '        If mSQL <> "" Then
        '            mSQL = "SELECT Description FROM Codes WHERE Code = '" & aCode2Str(mskStartCode.Text) & "'"
        '            mSQL = GetFldValue(mSQL, "Description")
        '            txtSCodeName.Text = mSQL
        '            Exit Sub
        '        Else
        '            MsgBox("Cash / Bank Code Is Not Allowed Here", vbInformation, SysCompany)
        '            mskStartCode.Text = aEmptyCode
        '            txtSCodeName.Text = ""
        '            mskStartCode.Focus()
        '            e.Cancel = True
        '        End If
        '    ElseIf pPara = 13 Then
        '        mSQL = "Select Code From Codes Where Code = '" & aCode2Str(mskStartCode.Text) & "' " & StrFilter
        '        mSQL = GetFldValue(mSQL, "Code")
        '        If mSQL <> "" Then
        '            mSQL = "SELECT Description FROM Codes WHERE Code = '" & aCode2Str(mskStartCode.Text) & "'"
        '            mSQL = GetFldValue(mSQL, "Description")
        '            txtSCodeName.Text = mSQL
        '            Exit Sub
        '        Else
        '            MsgBox("Only Bank Code Is Allowed Here", vbInformation, SysCompany)
        '            mskStartCode.Text = aEmptyCode
        '            txtSCodeName.Text = ""
        '            mskStartCode.Focus()
        '            e.Cancel = True
        '        End If
        '    ElseIf pPara = 14 Then
        '        mSQL = "Select Code From Codes Where Code = '" & aCode2Str(mskStartCode.Text) & "' " & StrFilter
        '        mSQL = GetFldValue(mSQL, "Code")
        '        If mSQL <> "" Then
        '            mSQL = "SELECT Description FROM Codes WHERE Code = '" & aCode2Str(mskStartCode.Text) & "'"
        '            mSQL = GetFldValue(mSQL, "Description")
        '            txtSCodeName.Text = mSQL
        '        Else
        '            MsgBox("Only Cash Code Is Allowed Here", vbInformation, SysCompany)
        '            mskStartCode.Text = aEmptyCode
        '            txtSCodeName.Text = ""
        '            mskStartCode.Focus()
        '            e.Cancel = True
        '        End If
        '    ElseIf pPara = 15 Then
        '        mSQL = "Select Code From Codes Where Code = '" & aCode2Str(mskStartCode.Text) & "'"
        '        mSQL = GetFldValue(mSQL, "Code")
        '        If mSQL <> "" Then
        '            mSQL = "SELECT Description FROM Codes WHERE Code = '" & aCode2Str(mskStartCode.Text) & "'"
        '            mSQL = GetFldValue(mSQL, "Description")
        '            txtSCodeName.Text = mSQL
        '        Else
        '            MsgBox("Code Is Not Found", vbInformation, SysCompany)
        '            mskStartCode.Text = aEmptyCode
        '            txtSCodeName.Text = ""
        '            mskStartCode.Focus()
        '            e.Cancel = True
        '        End If
        '    End If
        'End If
    End Sub

    Private Sub mskEndCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        'If mskEndCode.Text <> aEmptyCode Then
        '    If Not (Len(aCode2Str(mskEndCode.Text)) = aP1L Or Len(aCode2Str(mskEndCode.Text)) = aP1L + aP2L + aP3L Or Len(aCode2Str(mskEndCode.Text)) = aCodeL) Then
        '        MsgBox("Invalid Code Length", vbInformation, SysCompany)
        '        mskEndCode.Text = aEmptyCode
        '        e.Cancel = True
        '        Exit Sub
        '    ElseIf pPara = 12 Then
        '        mSQL = "Select Code From Codes Where Code = '" & aCode2Str(mskEndCode.Text) & "' " & StrFilter
        '        mSQL = GetFldValue(mSQL, "Code")
        '        If mSQL <> "" Then
        '            mSQL = "SELECT Description FROM Codes WHERE Code = '" & aCode2Str(mskEndCode.Text) & "'"
        '            mSQL = GetFldValue(mSQL, "Description")
        '            txtECodeName.Text = mSQL
        '        Else
        '            MsgBox("Cash / Bank Code Is Not Allowed Here", vbInformation, SysCompany)
        '            mskEndCode.Text = aEmptyCode
        '            txtECodeName.Text = ""
        '            mskEndCode.Focus()
        '            e.Cancel = True
        '        End If
        '    ElseIf pPara = 13 Then
        '        mSQL = "Select Code From Codes Where Code = '" & aCode2Str(mskEndCode.Text) & "' " & StrFilter
        '        mSQL = GetFldValue(mSQL, "Code")
        '        If mSQL <> "" Then
        '            mSQL = "SELECT Description FROM Codes WHERE Code = '" & aCode2Str(mskEndCode.Text) & "'"
        '            mSQL = GetFldValue(mSQL, "Description")
        '            txtECodeName.Text = mSQL
        '        Else
        '            MsgBox("Only Bank Code Is Allowed Here", vbInformation, SysCompany)
        '            mskEndCode.Text = aEmptyCode
        '            txtECodeName.Text = ""
        '            mskEndCode.Focus()
        '            e.Cancel = True
        '        End If
        '    ElseIf pPara = 14 Then
        '        mSQL = "Select Code From Codes Where Code = '" & aCode2Str(mskEndCode.Text) & "' " & StrFilter
        '        mSQL = GetFldValue(mSQL, "Code")
        '        If mSQL <> "" Then
        '            mSQL = "SELECT Description FROM Codes WHERE Code = '" & aCode2Str(mskEndCode.Text) & "'"
        '            mSQL = GetFldValue(mSQL, "Description")
        '            txtECodeName.Text = mSQL
        '        Else
        '            MsgBox("Only Cash Code Is Allowed Here", vbInformation, SysCompany)
        '            mskEndCode.Text = aEmptyCode
        '            txtECodeName.Text = ""
        '            mskEndCode.Focus()
        '            e.Cancel = True
        '        End If
        '    ElseIf pPara = 15 Then
        '        mSQL = "Select Code From Codes Where Code = '" & aCode2Str(mskEndCode.Text) & "'"
        '        mSQL = GetFldValue(mSQL, "Code")
        '        If mSQL <> "" Then
        '            mSQL = "SELECT Description FROM Codes WHERE Code = '" & aCode2Str(mskEndCode.Text) & "'"
        '            mSQL = GetFldValue(mSQL, "Description")
        '            txtECodeName.Text = mSQL
        '        Else
        '            MsgBox("Code Is Not Found", vbInformation, SysCompany)
        '            mskEndCode.Text = aEmptyCode
        '            txtECodeName.Text = ""
        '            mskEndCode.Focus()
        '            e.Cancel = True
        '        End If
        '    End If
        'End If
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
            If (Label15.Text <> "Stock Position Category Wise - Quantitative" And Label15.Text <> "Stock Position - Item Category Wise" And Label15.Text <> "Stock Below Reorder Level" And Label15.Text <> "Stock Above Reorder Level") Then
                MsgBox("Branch Code Can't be Empty", vbInformation, SysCompany)
                txtRefBrCode.Focus()
                Exit Sub
            End If
        ElseIf Trim(txtSCode.Text) = "" Then
            MsgBox("Starting Code Can't be Empty", vbInformation, SysCompany)
            txtSCode.Focus()
            Exit Sub
        ElseIf Trim(txtECode.Text) = "" Then
            MsgBox("Ending Code Can't be Empty", vbInformation, SysCompany)
            txtECode.Focus()
            Exit Sub
        ElseIf Trim(mskStoreCode.Text) = aEmptyCode Then
            MsgBox("Store Code Can't be Empty", vbInformation, SysCompany)
            mskStoreCode.Focus()
            Exit Sub
        End If

        ' ''***************
        ' ''Report Printing
        ' ''***************

        Dim path As String = RepPath & RepName

        Dim rptDoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptDoc.Load(path)

        strHeader1 = "From " & txtSCode.Text & " To " & txtECode.Text
        strHeader2 = Trim(mskStoreCodeName.Text)
        If (Label15.Text = "Stock Transaction List - Quantitative" Or Label15.Text = "Stock Transaction Summary - Quantitative" Or Label15.Text = "Detailed Stock Movement" Or Label15.Text = "Stock Movement Summary (All)" Or Label15.Text = "Stock Movement Summary - Moving Items") Then
            String.Format(dtpSdate.Text, "dd-MMM-yyyy")
            If Label15.Text = "Detailed Stock Movement" Or Label15.Text = "Stock Movement Summary (All)" Or Label15.Text = "Stock Movement Summary - Moving Items" Then
                strHeader2 = "For the Period from " & String.Format(dtpSdate.Text, "dd-MMM-yyyy") & " To " & String.Format(dtpEdate.Text, "dd-MMM-yyyy")
                rptDoc.SetParameterValue("@RepHeader2", strHeader2)
            End If
            rptDoc.SetParameterValue(0, Trim(txtSCode.Text))
            rptDoc.SetParameterValue(1, Trim(txtECode.Text))
            rptDoc.SetParameterValue(2, String.Format(dtpSdate.Text, "dd-MMM-yyyy"))
            rptDoc.SetParameterValue(3, String.Format(dtpEdate.Text, "dd-MMM-yyyy"))
            rptDoc.SetParameterValue(4, Trim(mskStoreCode.Text))
            rptDoc.SetParameterValue(5, Trim(txtRefBrCode.Text))
        ElseIf (Label15.Text = "Stock Movement (Non Moving Items Only)") Then
            rptDoc.SetParameterValue(0, Trim(txtSCode.Text))
            rptDoc.SetParameterValue(1, Trim(txtECode.Text))
            rptDoc.SetParameterValue(2, String.Format(dtpSdate.Text, "dd-MMM-yyyy"))
            rptDoc.SetParameterValue(3, String.Format(dtpEdate.Text, "dd-MMM-yyyy"))
            rptDoc.SetParameterValue(4, Trim(mskStoreCode.Text))
            rptDoc.SetParameterValue(5, Trim(txtRefBrCode.Text))
            strHeader2 = "For the Period from " & String.Format(dtpSdate.Text, "dd-MMM-yyyy") & " To " & String.Format(dtpEdate.Text, "dd-MMM-yyyy")
            rptDoc.SetParameterValue("@RepHeader2", strHeader2)
        ElseIf (Label15.Text = "Stock Position Item Wise - Quantitative" Or Label15.Text = "Stock Position - Items Wise" Or Label15.Text = "Stock Below Reorder Level" Or Label15.Text = "Stock Above Reorder Level" Or Label15.Text = "Expired Items Report") Then
            rptDoc.SetParameterValue(0, Trim(txtSCode.Text))
            rptDoc.SetParameterValue(1, Trim(txtECode.Text))
            rptDoc.SetParameterValue(2, String.Format(dtpSdate.Text, "dd-MMM-yyyy"))
            rptDoc.SetParameterValue(3, Trim(mskStoreCode.Text))
            rptDoc.SetParameterValue(4, Trim(txtRefBrCode.Text))
            rptDoc.SetParameterValue("@RepHeader2", strHeader2)
        ElseIf (Label15.Text = "Stock Position Category Wise - Quantitative" Or Label15.Text = "Stock Position - Item Category Wise") Then
            rptDoc.SetParameterValue(0, Trim(txtSCode.Text))
            rptDoc.SetParameterValue(1, Trim(txtECode.Text))
            rptDoc.SetParameterValue(2, String.Format(dtpSdate.Text, "dd-MMM-yyyy"))
            rptDoc.SetParameterValue(3, Trim(txtRefBrCode.Text))
            rptDoc.SetParameterValue("@RepHeader2", strHeader2)
        ElseIf (Label15.Text = "Rate Comparison Report") Then
            rptDoc.SetParameterValue(0, Trim(txtSCode.Text))
            rptDoc.SetParameterValue(1, Trim(txtECode.Text))
            rptDoc.SetParameterValue(2, String.Format(dtpSdate.Text, "dd-MMM-yyyy"))
            rptDoc.SetParameterValue(3, String.Format(dtpEdate.Text, "dd-MMM-yyyy"))
            rptDoc.SetParameterValue(4, Trim(mskStoreCode.Text))
            rptDoc.SetParameterValue(5, Trim(txtRefBrCode.Text))
            rptDoc.SetParameterValue("@RepHeader2", strHeader2)
        End If
        rptDoc.SetParameterValue("@ComDetail", SysCompany)
        rptDoc.SetParameterValue("@Reptitle", RepTitle)
        rptDoc.SetParameterValue("@RepHeader1", strHeader1)

        frmReport.Show()
        frmReport.ShowTransReport(rptDoc, RepName) '"GLAcStatus.Rpt"
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Sub ClearAll()
        txtRefBrCode.Text = ""
        lblBrName.Text = ""
        'mskStartCode.Text = aEmptyCode
        txtSCodeName.Text = ""
        'mskEndCode.Text = aEmptyCode
        txtECodeName.Text = ""
    End Sub

    Private Sub dtpStartDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpSdate.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub dtpEndDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpEdate.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub mskStartCode_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)

    End Sub

    Private Sub mskStartCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'mskEndCode.Text = mskStartCode.Text
    End Sub

    Private Sub dtpStartDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtpSdate.Validating
        If dtpSdate.Value > SySDate Then
            MsgBox("Start Date Cannot Be Greater Than Current Date", vbInformation, SysCompany)
            e.Cancel = True
            dtpSdate.Text = SySDate
        End If
    End Sub

    Private Sub dtpStartDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpSdate.ValueChanged

    End Sub

    Private Sub dtpEndDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtpEdate.Validating
        If dtpSdate.Value > SySDate Then
            MsgBox("End Date Cannot Be Greater Than Current Date", vbInformation, SysCompany)
            e.Cancel = True
            dtpSdate.Text = SySDate
        End If
    End Sub

    Private Sub dtpEndDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpEdate.ValueChanged

    End Sub

    Private Sub frmRPT_CodesStat_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        'Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub txtRefBrCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRefBrCode.TextChanged

    End Sub

    Private Sub mskEndCode_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtSCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSCode.KeyDown
        ObjFind = New Grid_Help
        If e.KeyCode = Keys.F1 Then
            ObjFind.PMessage = "Items"
            If Label15.Text <> "Stock Position - Item Category Wise" Or Label15.Text <> "Stock Position - Item Category Wise" Then
                strFind = "SELECT ItemCode,Description FROM Items"
            Else
                strFind = "SELECT CompCode,Name FROM Companies "
            End If
            ObjFind.sqlqueryFun = strFind
            ObjFind.ShowDialog()

            If ObjFind.PbOk = True Then
                Me.txtSCode.Text = ObjFind.strPKfun & ""
                Me.txtSCodeName.Text = ObjFind.sqlqueryFun & ""
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtSCode_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtSCode.MouseWheel

    End Sub

    Private Sub txtSCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSCode.TextChanged

    End Sub

    Private Sub txtECode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtECode.KeyDown
        ObjFind = New Grid_Help
        If e.KeyCode = Keys.F1 Then
            ObjFind.PMessage = "Items"
            If Label15.Text <> "Stock Position - Item Category Wise" Or Label15.Text <> "Stock Position - Item Category Wise" Then
                strFind = "SELECT ItemCode,Description FROM Items"
            Else
                strFind = "SELECT CompCode,Name FROM Companies "
            End If
            ObjFind.sqlqueryFun = strFind
            ObjFind.ShowDialog()

            If ObjFind.PbOk = True Then
                Me.txtECode.Text = ObjFind.strPKfun & ""
                Me.txtECodeName.Text = ObjFind.sqlqueryFun & ""
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtECode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtECode.TextChanged

    End Sub

    Private Sub txtSCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSCode.Validated
        If txtSCode.Text <> "" Then

            If Label15.Text = "Stock Position - Item Category Wise" Then
                mSQL = "SELECT Name FROM Companies WHERE CompCode = '" & txtSCode.Text & "'"
                mSQL = GetFldValue(mSQL, "Name")

                If mSQL <> "" Then
                    txtSCodeName.Text = mSQL
                Else
                    MsgBox("Invalid Item Code", vbInformation)
                End If
            Else

                mSQL = "SELECT Description FROM ITEMS WHERE ITEMNO = '" & txtSCode.Text & "'"
                mSQL = GetFldValue(mSQL, "Description")

                If mSQL <> "" Then
                    txtSCodeName.Text = mSQL
                Else
                    MsgBox("Invalid Item Code", vbInformation)
                End If
            End If
        End If
    End Sub

    Private Sub txtECode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtECode.Validated
        If txtECode.Text <> "" Then
            If Label15.Text = "Stock Position - Item Category Wise" Then
                mSQL = "SELECT Name FROM Companies WHERE CompCode = '" & txtECode.Text & "'"
                mSQL = GetFldValue(mSQL, "Name")

                If mSQL <> "" Then
                    txtECodeName.Text = mSQL
                Else
                    MsgBox("Invalid Item Code", vbInformation)
                End If
            Else
                mSQL = "SELECT Description FROM ITEMS WHERE ITEMNO = '" & txtECode.Text & "'"
                mSQL = GetFldValue(mSQL, "Description")

                If mSQL <> "" Then
                    txtECodeName.Text = mSQL
                Else
                    MsgBox("Invalid Item Code", vbInformation)
                End If
            End If
        End If
    End Sub

    Private Sub mskStoreCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mskStoreCode.KeyDown

        ObjFind = New Grid_Help
        If e.KeyCode = Keys.F1 Then
            ObjFind.PMessage = "Stores"
            strFind = "SELECT StoreCode,Name FROM Stores "
            ObjFind.sqlqueryFun = strFind
            ObjFind.ShowDialog()

            If ObjFind.PbOk = True Then
                Me.mskStoreCode.Text = ObjFind.strPKfun & ""
                Me.mskStoreCodeName.Text = ObjFind.sqlqueryFun & ""
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub mskStoreCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskStoreCode.Validated
        If mskStoreCode.Text <> "" Then
            mSQL = "SELECT Name FROM STORES WHERE STORECODE = '" & mskStoreCode.Text & "'"
            mSQL = GetFldValue(mSQL, "Name")

            If mSQL <> "" Then
                mskStoreCodeName.Text = mSQL
                'mskStoreCode.Text = mskStoreCode.Text
                'mskStoreCode.Text = mSQL
            Else
                MsgBox("Invalid Store Code", vbInformation)
                'Cancel = True
            End If
        Else
            mskStoreCodeName.Text = ""
        End If
    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        ObjFind = New Grid_Help
        If e.KeyCode = Keys.F1 Then
            ObjFind.PMessage = "Suppliers"
            strFind = "SELECT SupplCode,Name FROM Suppliers "
            ObjFind.sqlqueryFun = strFind
            ObjFind.ShowDialog()

            If ObjFind.PbOk = True Then
                Me.txtSCode.Text = ObjFind.strPKfun & ""
                Me.txtSCodeName.Text = ObjFind.sqlqueryFun & ""
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        ObjFind = New Grid_Help
        If e.KeyCode = Keys.F1 Then
            ObjFind.PMessage = "Suppliers"
            strFind = "SELECT SupplCode,Name FROM Suppliers "
            ObjFind.sqlqueryFun = strFind
            ObjFind.ShowDialog()

            If ObjFind.PbOk = True Then
                Me.txtSCode.Text = ObjFind.strPKfun & ""
                Me.txtSCodeName.Text = ObjFind.sqlqueryFun & ""
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class