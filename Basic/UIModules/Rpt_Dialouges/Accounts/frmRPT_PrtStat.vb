Imports System.Data
Imports System.Data.SqlClient
Imports Basic.DAL
Imports Basic.DAL.Utils
Imports Basic.Constants.ProjConst

Public Class frmRPT_PrtStat
    Inherits System.Windows.Forms.Form

    Dim objIncStat As New cIncStat
    Dim objTBall As New cTrialBal

    Public SetFilter As Boolean
    Dim ObjFind As Grid_Help
    Dim strFind As String
    Dim SelFormula As String
    Dim STRFROMTO As String
    Dim StrFromDate As String
    Dim RepName As String
    Dim dtBranch As New DataTable
    Dim rowNum As Integer
    Dim mi As Double
    Dim Tbal As Double
    Dim OPERATORS As String

    Private Sub txtStPageNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStPageNo.KeyDown
        ObjFind = New Grid_Help
        If e.KeyCode = Keys.F1 Then
            ObjFind.PMessage = "Branch"
            strFind = "SELECT MAX(PAGENO) AS PAGENO,MAX(HDR) AS HEADING FROM " & _
                      "PFTLOSS GROUP BY PAGENO"
            ObjFind.sqlqueryFun = strFind
            ObjFind.ShowDialog()

            If ObjFind.PbOk = True Then
                Me.txtStPageNo.Text = ObjFind.strPKfun & ""
                Me.LBLStPageNo.Text = ObjFind.sqlqueryFun & ""
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtEndPageNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEndPageNo.KeyDown
        ObjFind = New Grid_Help
        If e.KeyCode = Keys.F1 Then
            ObjFind.PMessage = "Branch"
            strFind = "SELECT MAX(PAGENO) AS PAGENO,MAX(HDR) AS HEADING FROM " & _
                      "PFTLOSS GROUP BY PAGENO"
            ObjFind.sqlqueryFun = strFind
            ObjFind.ShowDialog()

            If ObjFind.PbOk = True Then
                Me.txtEndPageNo.Text = ObjFind.strPKfun & ""
                Me.lblEndPageNo.Text = ObjFind.sqlqueryFun & ""
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtStPageNo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtStPageNo.Validating
        If Trim(txtStPageNo.Text) <> "" Then
            txtStPageNo.Text = Format(Val(Trim(txtStPageNo.Text)), "00")
            mSQL = "SELECT HDR FROM PFTLOSS WHERE PAGENO = '" & Trim(txtStPageNo.Text) & "'"
            mSQL = GetFldValue(mSQL, "HDR")
            LBLStPageNo.Text = mSQL
            If mSQL = "" Then
                MsgBox("No Record Found", vbInformation, SysCompany)
                txtStPageNo.Text = ""
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub txtEndPageNo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEndPageNo.Validating
        If Trim(txtEndPageNo.Text) <> "" Then
            txtEndPageNo.Text = Format(Val(Trim(txtEndPageNo.Text)), "00")
            mSQL = "SELECT HDR FROM PFTLOSS WHERE PAGENO = '" & Trim(txtEndPageNo.Text) & "'"
            mSQL = GetFldValue(mSQL, "HDR")
            lblEndPageNo.Text = mSQL
            If mSQL = "" Then
                MsgBox("No Record Found", vbInformation, SysCompany)
                txtEndPageNo.Text = ""
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub btnPreview_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Call CallReport(0)
        'temp comments''''frmExportRep.ShowDialog()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Call CallReport(1)
    End Sub

    Private Sub CallReport(ByVal mPara As Integer)
        'Dim mBrField As String
        Dim Branch001 As String
        Dim Branch002 As String
        Dim Branch003 As String
        Dim Branch004 As String
        Dim Branch005 As String
        Dim Branch006 As String
        Dim Branch007 As String
        Dim Branch008 As String
        Dim Branch009 As String
        Dim Branch010 As String
        Dim Branch011 As String
        Dim Branch012 As String
        Dim Branch013 As String
        Dim Branch014 As String
        Dim Branch015 As String
        Dim Branch016 As String
        Dim Branch017 As String
        Dim Branch018 As String
        Dim Branch019 As String
        Dim Branch020 As String
        Dim Branch021 As String
        Dim Branch022 As String
        Dim Branch023 As String
        Dim Branch024 As String
        Dim Branch025 As String
        Dim Branch026 As String
        Dim Branch027 As String
        Dim Branch028 As String
        Dim Branch029 As String
        Dim Branch030 As String
        Dim Branch031 As String
        Dim Branch032 As String
        Dim Branch033 As String
        Dim Branch034 As String
        Dim Branch035 As String
        Dim Branch036 As String
        Dim Branch037 As String
        Dim Branch038 As String
        Dim Branch039 As String
        Dim Branch040 As String
        Dim Branch041 As String
        Dim Branch042 As String
        Dim Branch043 As String
        Dim Branch044 As String
        'Dim Branch045 As String
        'Dim Branch046 As String
        'Dim Branch047 As String
        'Dim Branch048 As String
        'Dim Branch049 As String
        'Dim Branch050 As String

        dtBranch = objTBall.LoadBranch()
        rowNum = dtBranch.Rows.Count

        If rowNum > 0 Then
            rowNum = 0
            Do While rowNum < dtBranch.Rows.Count
                Select Case dtBranch.Rows(rowNum).Item("BRCODE").ToString
                    Case "001"
                        Branch001 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "002"
                        Branch002 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "003"
                        Branch003 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "004"
                        Branch004 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "005"
                        Branch005 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "006"
                        Branch006 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "007"
                        Branch007 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "008"
                        Branch008 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "009"
                        Branch009 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "010"
                        Branch010 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "011"
                        Branch011 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "012"
                        Branch012 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "013"
                        Branch013 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "014"
                        Branch014 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "015"
                        Branch015 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "016"
                        Branch016 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "017"
                        Branch017 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "018"
                        Branch018 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "019"
                        Branch019 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "020"
                        Branch020 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "021"
                        Branch021 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "022"
                        Branch022 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "023"
                        Branch023 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "024"
                        Branch024 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "025"
                        Branch025 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "026"
                        Branch026 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "027"
                        Branch027 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "028"
                        Branch028 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "029"
                        Branch029 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "030"
                        Branch030 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "031"
                        Branch031 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "032"
                        Branch032 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "033"
                        Branch033 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "034"
                        Branch034 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "035"
                        Branch035 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "036"
                        Branch036 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "037"
                        Branch037 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "038"
                        Branch038 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "039"
                        Branch039 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "040"
                        Branch040 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "041"
                        Branch041 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "042"
                        Branch042 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "043"
                        Branch043 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                    Case "044"
                        Branch044 = Trim(dtBranch.Rows(rowNum).Item("BRNAME").ToString)
                End Select
                rowNum = rowNum + 1
            Loop
        End If

        ''********* REPORT CALLING

        StrFromDate = "AS ON " & Format(dtpDate.Value, "DD/MM/YYYY")

        SelFormula = "{PFTLOSS.PAGENO} >= '" & Trim(txtStPageNo.Text) & "' " & _
                " AND {PFTLOSS.PAGENO} <= '" & Trim(txtEndPageNo.Text) & "'"

        If chkPrtNotes.Checked = True Then
            Me.Cursor = Cursors.WaitCursor
            objIncStat.DelDetail()
            Call Calc_PrtStat(txtStPageNo.Text, txtEndPageNo.Text, dtpDate.Value, True)
            Me.Cursor = Cursors.Default
            'RepName = "IncStatAll.Rpt"

            'Dim path As String = RepPath & RepName

            'Dim rptDoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            'rptDoc.Load(path)

            'frmReport.Show()
            'frmReport.ShowTransReport(rptDoc, "AccSys")
            'RepName = "Notes.Rpt"

            'Dim path1 As String = RepPath & RepName

            'Dim rptDoc1 As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            'rptDoc1.Load(path1)

            'frmReport.Show()
            'frmReport.ShowTransReport(rptDoc1, "AccSys")
        End If

        ''** INCOME STATEMENT

        Me.Cursor = Cursors.WaitCursor
        objIncStat.DelDetail()
        Call Calc_PrtStat(txtStPageNo.Text, txtEndPageNo.Text, dtpDate.Value, False)
        Me.Cursor = Cursors.Default
        ''RepName = "IncStatAll.Rpt"

        ''Dim path2 As String = RepPath & RepName

        ''Dim rptDoc2 As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        ''rptDoc2.Load(path2)

        ''frmReport.Show()
        ''frmReport.ShowTransReport(rptDoc2, "AccSys")
    End Sub
    ''**************************************************************************
    '' ************ PROCESS PRINT STATEMENTS ***********************************
    ''**************************************************************************

    Private Sub Calc_PrtStat(ByVal StrPgNo As String, ByVal EndPgNo As String, ByVal TDate As Date, ByVal PrtNotes As Boolean)

        Dim objIncStat As New cIncStat

        Dim dtPftLoss As New DataTable
        Dim dtDetail As New DataTable
        Dim dtCodesBal As New DataTable
        Dim dtTemp As New DataTable
        Dim rowNum As Integer
        Dim rowNum1 As Integer
        Dim rowNum2 As Integer
        Dim rowNum3 As Integer
        Dim rowTemp As Integer

        Dim mTStr
        Dim DtCode As String
        Dim DtDesc As String
        Dim mCodeLen As Integer

        'Dim TLimit As Integer
        'Dim II As Integer
        ''**
        Dim TbrCode As String
        Dim TmpBrCode As String
        'Dim BrIndex As Integer
        Dim BrField As String
        ''**
        Dim TPageNo As String
        Dim PrDate As Date
        '    Dim TExRate As Double
        Dim TLineNo As String
        Dim TValue As String
        Dim Tdesc As String
        Dim TNoteRef As String
        Dim TCode As String
        ''**
        Dim TpNo As String
        Dim TLNo As String
        Dim TLNo1 As String
        Dim TLNo2 As String
        ''**
        Dim FAmt As Double
        Dim TLBal As Double
        Dim TLbal1 As Double
        Dim TLbal2 As Double
        Dim TCdBal As Double
        Dim DtCdBal As Double
        ''** TO DELETE ALL PREVIUOS ENTRIES IN DETAIL
        objIncStat.DelDetail()
        ''** ''** END OF DELETE PROCESS IN DETAIL
        dtDetail = objIncStat.SelDetail()
        rowNum2 = dtDetail.Rows.Count
        If rowNum2 >= 0 Then
            rowNum2 = 0
        End If
        ''*** GET PREVIOUS DATE
        PrDate = PMonth(TDate)
        ''*** PFTLOSS TABLE QUERY
        dtPftLoss = objIncStat.SelPftLoss()
        rowNum1 = dtPftLoss.Rows.Count - 1
        ProgBar.Maximum = dtPftLoss.Rows.Count
        ''*****************
        ''*** MAIN LOOP
        ''*****************
        mSQL = "SELECT * FROM BRANCH WHERE BRCODE<>'000' ORDER BY BRCODE"
        dtBranch = GetDataTable(mSQL)
        rowNum = dtBranch.Rows.Count
        If rowNum >= 0 Then
            rowNum = 0
            Do While rowNum < dtBranch.Rows.Count
                TbrCode = dtBranch.Rows(rowNum).Item("BRCODE").ToString
                BrField = "BRANCH" & TbrCode & ""
                ProgBar.Value = 0
                lblProcess.Text = dtBranch.Rows(rowNum).Item("BRNAME").ToString
                If rowNum1 >= 0 Then
                    rowNum1 = 0
                    Do While rowNum1 < dtPftLoss.Rows.Count
                        TPageNo = dtPftLoss.Rows(rowNum1).Item("PAGENO").ToString
                        Do While dtPftLoss.Rows(rowNum1).Item("PageNo") = TPageNo
                            Tbal = 0
                            TLineNo = dtPftLoss.Rows(rowNum1).Item("mLINENO").ToString
                            TValue = dtPftLoss.Rows(rowNum1).Item("mValue").ToString
                            Tdesc = dtPftLoss.Rows(rowNum1).Item("Description").ToString
                            TNoteRef = dtPftLoss.Rows(rowNum1).Item("NOTEREF").ToString
                            TRepType = dtPftLoss.Rows(rowNum1).Item("RepType").ToString
                            mi = 1
                            TCode = ""
                            TpNo = TPageNo              '' PAGE NUMBER
                            TLNo = ""                   '' LINE NUMBER
                            FAmt = 0                    '' FIXED VALUE TO BE ADDED IN THE AMOUNT
                            TmpBrCode = ""
                            ''**
                            TLBal = 0
                            TLbal1 = 0
                            TLbal2 = 0
                            ''**
                            Do
                                '' LOOP OF mI
                                Do While mi < Len(TValue)
                                    If Mid(TValue, mi, 1) = Space(1) Then
                                        mi = mi + 1
                                        Exit Do
                                    End If
                                    '' START IF OF  mI CHAR
                                    If Mid(TValue, mi, 1) = "C" Then
                                        mi = mi + 1
                                        TCode = ""
                                        RepType = "C"
                                        Do While Mid(TValue, mi, 1) <> "" And Mid(TValue, mi, 1) <> " "
                                            TCode = TCode + Mid(TValue, mi, 1)
                                            mi = mi + 1
                                        Loop
                                    ElseIf Mid(TValue, mi, 1) = "A" Then
                                        mi = mi + 1
                                        TCode = ""
                                        RepType = "A"
                                        Do While Mid(TValue, mi, 1) <> "" And Mid(TValue, mi, 1) <> " "
                                            TCode = TCode + Mid(TValue, mi, 1)
                                            mi = mi + 1
                                        Loop
                                    ElseIf Mid(TValue, mi, 1) = "O" Then
                                        mi = mi + 1
                                        TCode = ""
                                        RepType = "O"
                                        Do While Mid(TValue, mi, 1) <> "" And Mid(TValue, mi, 1) <> " "
                                            TCode = TCode + Mid(TValue, mi, 1)
                                            mi = mi + 1
                                        Loop
                                    ElseIf Mid(TValue, mi, 1) = "D" Then
                                        mi = mi + 1
                                        TCode = ""
                                        RepType = "D"
                                        Do While Mid(TValue, mi, 1) <> "" And Mid(TValue, mi, 1) <> " "
                                            TCode = TCode + Mid(TValue, mi, 1)
                                            mi = mi + 1
                                        Loop
                                    ElseIf Mid(TValue, mi, 1) = "R" Then
                                        mi = mi + 1
                                        TCode = ""
                                        RepType = "R"
                                        Do While Mid(TValue, mi, 1) <> "" And Mid(TValue, mi, 1) <> " "
                                            TCode = TCode + Mid(TValue, mi, 1)
                                            mi = mi + 1
                                        Loop
                                    ElseIf Mid(TValue, mi, 1) = "+" Or Mid(TValue, mi, 1) = "-" Or Mid(TValue, mi, 1) = "/" Or Mid(TValue, mi, 1) = "*" Or Mid(TValue, mi, 1) = "/" Or Mid(TValue, mi, 1) = "^" Then
                                        OPERATORS = Mid(TValue, mi, 1)
                                        mi = mi + 1
                                        Exit Do
                                    ElseIf Mid(TValue, mi, 3) = "LOW" Then
                                        mi = mi + 4
                                        TLNo1 = Mid(TValue, mi, 2)
                                        mi = mi + 3
                                        TLNo2 = Mid(TValue, mi, 2)
                                        mi = mi + 3
                                        If Len(Trim(TNoteRef)) <> 0 Then
                                            objIncStat.PageNo = TPageNo
                                            objIncStat.mLineNo = TLineNo
                                            objIncStat.NoteRef = TNoteRef
                                            objIncStat.Description = Tdesc
                                        End If
                                        mSQL = "SELECT * FROM PFTLOSS WHERE PAGENO = '" & _
                                                TPageNo & "' AND mLineNo = '" & TLNo1 & "'"
                                        dtTemp = GetDataTable(mSQL)
                                        rowTemp = dtTemp.Rows.Count
                                        If rowTemp >= 0 Then
                                            rowTemp = 0
                                            TLbal1 = dtTemp.Rows(rowTemp).Item(BrField).ToString
                                        End If
                                        mSQL = "SELECT * FROM PFTLOSS WHERE PAGENO = '" & _
                                                TPageNo & "' AND mLineNo = '" & TLNo2 & "'"
                                        dtTemp = GetDataTable(mSQL)
                                        rowTemp = dtTemp.Rows.Count
                                        If rowTemp >= 0 Then
                                            rowTemp = 0
                                            TLbal2 = dtTemp.Rows(rowTemp).Item(BrField).ToString
                                        End If
                                        If TLbal2 < TLbal1 Then
                                            TLBal = TLbal2
                                        Else
                                            TLBal = TLbal1
                                        End If
                                        If Len(Trim(TNoteRef)) <> 0 Then
                                            objIncStat.BrField = TLBal
                                        End If
                                    ElseIf Mid(TValue, mi, 4) = "HIGH" Then
                                        mi = mi + 5
                                        TLNo1 = Mid(TValue, mi, 2)
                                        mi = mi + 3
                                        TLNo2 = Mid(TValue, mi, 2)
                                        mi = mi + 3
                                        mSQL = "SELECT * FROM PFTLOSS WHERE PAGENO = '" & _
                                                TPageNo & "' AND mLineNo = '" & TLNo1 & "'"
                                        dtTemp = GetDataTable(mSQL)
                                        rowTemp = dtTemp.Rows.Count
                                        If rowTemp >= 0 Then
                                            rowTemp = 0
                                            TLbal1 = dtTemp.Rows(rowTemp).Item(BrField).ToString
                                        End If
                                        mSQL = "SELECT * FROM PFTLOSS WHERE PAGENO = '" & _
                                                TPageNo & "' AND mLineNo = '" & TLNo2 & "'"
                                        dtTemp = GetDataTable(mSQL)
                                        rowTemp = dtTemp.Rows.Count
                                        If rowTemp >= 0 Then
                                            rowTemp = 0
                                            TLbal2 = dtTemp.Rows(rowTemp).Item(BrField).ToString
                                        End If
                                        If TLbal2 > TLbal1 Then
                                            TLBal = TLbal2
                                        Else
                                            TLBal = TLbal1
                                        End If
                                        If Len(Trim(TNoteRef)) <> 0 Then
                                            objIncStat.BrField = TLBal
                                        End If
                                    ElseIf Mid(TValue, mi, 1) = "L" Then  ''** ADDITION OF LINE IN DETAIL
                                        mi = mi + 1
                                        TLNo = ""
                                        Do While Mid(TValue, mi, 1) <> "" And Mid(TValue, mi, 1) <> " "
                                            TLNo = TLNo + Mid(TValue, mi, 1)
                                            mi = mi + 1
                                        Loop
                                        If Len(Trim(TNoteRef)) <> 0 Then
                                            objIncStat.PageNo = TPageNo
                                            objIncStat.mLineNo = TLineNo
                                            objIncStat.NoteRef = TNoteRef
                                            objIncStat.Description = Tdesc
                                        End If
                                        If Trim(TpNo) <> "" And Trim(TLNo) <> "" Then
                                            mSQL = "SELECT * FROM PFTLOSS WHERE PAGENO = '" & _
                                                    TpNo & "' AND mLineNo = '" & TLNo & "'"
                                        ElseIf Trim(TLNo) <> "" And Trim(TpNo) = "" Then
                                            mSQL = "SELECT * FROM PFTLOSS WHERE PAGENO = '" & _
                                                    TPageNo & "' AND mLineNo = '" & TLNo & "'"
                                        End If
                                        dtTemp = GetDataTable(mSQL)
                                        rowTemp = dtTemp.Rows.Count
                                        If rowTemp >= 0 Then
                                            rowTemp = 0
                                            TLBal = dtTemp.Rows(rowTemp).Item(BrField).ToString
                                        End If
                                        If Len(Trim(TNoteRef)) <> 0 Then
                                            objIncStat.BrField = TLBal
                                        End If
                                        TpNo = TPageNo
                                    ElseIf Mid(TValue, mi, 1) = "P" Then
                                        mi = mi + 1
                                        TpNo = ""
                                        Do While Mid(TValue, mi, 1) <> "" And Mid(TValue, mi, 1) <> " "
                                            TpNo = TpNo + Mid(TValue, mi, 1)
                                            mi = mi + 1
                                        Loop
                                        Exit Do
                                    ElseIf Mid(TValue, mi, 1) = "F" Then
                                        mi = mi + 1
                                        mTStr = ""
                                        Do While Mid(TValue, mi, 1) <> "" And Mid(TValue, mi, 1) <> " "
                                            mTStr = mTStr + Mid(TValue, mi, 1)
                                            mi = mi + 1
                                        Loop
                                        FAmt = Val(mTStr)
                                    ElseIf Mid(TValue, mi, 1) = "B" Then
                                        mi = mi + 1
                                        TmpBrCode = Mid(TValue, mi, 2)
                                        mi = mi + 2
                                        mTStr = ""
                                        Do While Mid(TValue, mi, 1) <> "" And Mid(TValue, mi, 1) <> " "
                                            mTStr = mTStr + Mid(TValue, mi, 1)
                                            mi = mi + 1
                                        Loop
                                        FAmt = Val(mTStr)
                                    Else
                                        mi = mi + 1
                                    End If
                                    '' END IF OF mI CHAR
                                    ''** START OF IF STATEMENT
                                    If Len(Trim(TCode)) <> 0 Then
                                        TCdBal = 0
                                        mCodeLen = Len(Trim(TCode))
                                        TCode = Trim(TCode)
                                        If PrtNotes Then
                                            If TRepType = "C" Then
                                                If RepType = "C" Then
                                                    mSQL = GetBrSqlCF(TbrCode, PrDate, TDate, TCode, mCodeLen, True)
                                                ElseIf RepType = "A" Then
                                                    mSQL = GetBrSqlAF(TbrCode, PrDate, TDate, TCode, mCodeLen, True)
                                                ElseIf RepType = "O" Then
                                                    mSQL = GetBrSqlOF(TbrCode, PrDate, TDate, TCode, mCodeLen, True)
                                                ElseIf RepType = "D" Then
                                                    mSQL = GetBrSqlDF(TbrCode, PrDate, TDate, TCode, mCodeLen, True)
                                                ElseIf RepType = "R" Then
                                                    mSQL = GetBrSqlRF(TbrCode, PrDate, TDate, TCode, mCodeLen, True)
                                                End If
                                            Else
                                                If RepType = "C" Then
                                                    mSQL = GetBrSqlC(TbrCode, PrDate, TDate, TCode, mCodeLen, True)
                                                ElseIf RepType = "A" Then
                                                    mSQL = GetBrSqlA(TbrCode, PrDate, TDate, TCode, mCodeLen, True)
                                                ElseIf RepType = "O" Then
                                                    mSQL = GetBrSqlO(TbrCode, PrDate, TDate, TCode, mCodeLen, True)
                                                ElseIf RepType = "D" Then
                                                    mSQL = GetBrSqlD(TbrCode, PrDate, TDate, TCode, mCodeLen, True)
                                                ElseIf RepType = "R" Then
                                                    mSQL = GetBrSqlR(TbrCode, PrDate, TDate, TCode, mCodeLen, True)
                                                End If
                                            End If
                                        Else
                                            If TRepType = "C" Then
                                                If RepType = "C" Then
                                                    mSQL = GetBrSqlCF(TbrCode, PrDate, TDate, TCode, mCodeLen, False)
                                                ElseIf RepType = "A" Then
                                                    mSQL = GetBrSqlAF(TbrCode, PrDate, TDate, TCode, mCodeLen, False)
                                                ElseIf RepType = "O" Then
                                                    mSQL = GetBrSqlOF(TbrCode, PrDate, TDate, TCode, mCodeLen, False)
                                                ElseIf RepType = "D" Then
                                                    mSQL = GetBrSqlDF(TbrCode, PrDate, TDate, TCode, mCodeLen, False)
                                                ElseIf RepType = "R" Then
                                                    mSQL = GetBrSqlRF(TbrCode, PrDate, TDate, TCode, mCodeLen, False)
                                                End If
                                            Else
                                                If RepType = "C" Then
                                                    mSQL = GetBrSqlC(TbrCode, PrDate, TDate, TCode, mCodeLen, False)
                                                ElseIf RepType = "A" Then
                                                    mSQL = GetBrSqlA(TbrCode, PrDate, TDate, TCode, mCodeLen, False)
                                                ElseIf RepType = "O" Then
                                                    mSQL = GetBrSqlO(TbrCode, PrDate, TDate, TCode, mCodeLen, False)
                                                ElseIf RepType = "D" Then
                                                    mSQL = GetBrSqlD(TbrCode, PrDate, TDate, TCode, mCodeLen, False)
                                                ElseIf RepType = "R" Then
                                                    mSQL = GetBrSqlR(TbrCode, PrDate, TDate, TCode, mCodeLen, False)
                                                End If
                                            End If
                                        End If
                                        dtCodesBal = GetDataTable(mSQL)
                                        rowNum3 = dtCodesBal.Rows.Count
                                        If rowNum3 >= 0 Then
                                            rowNum3 = 0
                                            Do While rowNum3 < dtCodesBal.Rows.Count
                                                DtCode = dtCodesBal.Rows(rowNum3).Item("Code").ToString
                                                DtCdBal = 0
                                                If Not IsDBNull(dtCodesBal.Rows(rowNum3).Item("Balance")) Then
                                                    DtCdBal = dtCodesBal.Rows(rowNum3).Item("Balance")
                                                End If
                                                DtDesc = dtCodesBal.Rows(rowNum3).Item("Description")
                                                objIncStat.PageNo = TPageNo
                                                objIncStat.mLineNo = TLineNo
                                                objIncStat.NoteRef = TNoteRef
                                                objIncStat.Description = Tdesc
                                                objIncStat.Code = DtCode
                                                objIncStat.CDesc = DtDesc
                                                If OPERATORS = "-" Then
                                                    objIncStat.BrField = 0 - DtCdBal
                                                Else
                                                    objIncStat.BrField = DtCdBal
                                                End If
                                                objIncStat.AddDetail()
                                                TCdBal = TCdBal + DtCdBal
                                                rowNum3 = rowNum3 + 1
                                            Loop
                                        End If
                                        Call SumBal(TCdBal)
                                        TCode = ""
                                    ElseIf FAmt <> 0 Then
                                        If Len(Trim(TmpBrCode)) = 0 Then
                                            Call SumBal(FAmt)
                                        ElseIf Len(Trim(TmpBrCode)) <> 0 And TmpBrCode = TbrCode Then
                                            Call SumBal(FAmt)
                                        End If
                                        TmpBrCode = ""
                                        FAmt = 0
                                    ElseIf TLBal <> 0 Then
                                        Call SumBal(TLBal)
                                        TLBal = 0
                                    End If
                                    '                        ''** END OF IF STATEMENT
                                Loop
                                ''** END OF LOOP mI
                            Loop Until Not (mi < Len(TValue))
                            ''** ENTRIES IN PFTLOSS
                            objIncStat.PageNo = TPageNo
                            objIncStat.mLineNo = TLineNo
                            objIncStat.BrField = Tbal
                            objIncStat.AppendPftLoss()
                            rowNum1 = rowNum1 + 1
                            ProgBar.Value = ProgBar.Value + 1
                        Loop
                    Loop
                End If
                rowNum = rowNum + 1
            Loop
        End If
        ''** END OF BRANCHES LOOP
        ''**************************
        If PrtNotes Then
            lblProcess.Text = "Preparing Notes The Accounts"
            Me.Refresh()
        End If
        ''**************************
    End Sub
    ''*********************************************************************
    ''**************** END OF PROCESS PRINT STATEMENT *********************
    ''*********************************************************************


    ''**************** PROCEDURES USED IN INCOME STATEMENT *****************
    Private Sub SumBal(ByVal mValue As Double)
        Select Case OPERATORS
            Case "+"
                Tbal = Tbal + mValue
            Case "-"
                Tbal = Tbal - mValue
            Case "*"
                If mValue <> 0 Then
                    Tbal = Tbal * mValue
                End If
            Case "/"
                If mValue <> 0 Then
                    Tbal = Tbal / mValue
                End If
            Case "^"
                If mValue <> 0 Then
                    Tbal = Tbal ^ mValue
                End If
        End Select
    End Sub

    Private Function GetBrSql(ByVal TtBrCode As String, ByVal PrDate As Date, ByVal TDate As Date, ByVal TCode As String, ByVal CodeLen As Integer, ByVal PrtNotes As Boolean) As String
        Dim mSQL As String
        Dim PrStr As String
        Dim TmpStr As String

        PrStr = GetCmpDate(PrDate)
        TmpStr = Format(TDate, "dd-MMM-yyyy")
        If PrtNotes Then

            mSQL = "SELECT MAX(Codes.DESCRIPTION) AS Description, SUBSTRING(Gledg.CODE,1," & CodeLen & ") AS Code, " & _
                   "SUM(DEBIT-CREDIT) Balance " & _
             "From Gledg, Codes, " & _
                   "(SELECT DISTINCT SUBSTRING(CODE,1," & CodeLen & ") SUBCODE FROM Gledg " & _
                   " WHERE SUBSTRING(CODE,1," & CodeLen & ")='" & TCode & "') G " & _
             "WHERE VDATE <= '" & TmpStr & "' " & _
                   "AND GLEDG.BRCODE = '" & TtBrCode & "' " & _
                   "AND GLEDG.POSTED = 'Y' " & _
                   "AND SUBSTRING(Gledg.CODE,1," & CodeLen & " ) = G.SUBCODE " & _
                   "AND Codes.CODE = G.SUBCODE+'" & Fillit("", "0", aCodeL - CodeLen) & "'" & _
             " GROUP BY SUBSTRING(Gledg.CODE,1," & CodeLen & ") "

        Else

            mSQL = "SELECT MAX(Codes.DESCRIPTION) AS Description,SUBSTRING(Gledg.CODE,1," & CodeLen & ") AS Code, " & _
                   "SUM(DEBIT-CREDIT) Balance  " & _
               "FROM Gledg, Codes " & _
               "WHERE VDATE <= '" & TmpStr & "' " & _
                   "AND GLEDG.BRCODE = '" & TtBrCode & "' " & _
                   "AND GLEDG.POSTED = 'Y' " & _
                   "AND SUBSTRING(Gledg.CODE,1," & CodeLen & ") = '" & TCode & "' " & _
                   "AND Codes.CODE = '" & TCode & Fillit("", "0", aCodeL - CodeLen) & "' " & _
               "GROUP BY SUBSTRING(Gledg.CODE,1," & CodeLen & ")"

        End If
        GetBrSql = mSQL

    End Function

    Private Function GetBrSqlCF(ByVal TtBrCode As String, ByVal PrDate As Date, ByVal TDate As Date, ByVal TCode As String, ByVal CodeLen As Integer, ByVal PrtNotes As Boolean) As String
        Dim mSQL As String
        Dim PrStr As String
        Dim TmpStr As String

        PrStr = GetCmpDate(PrDate)
        TmpStr = Format(TDate, "dd-MMM-yyyy")
        If PrtNotes Then

            mSQL = "SELECT MAX(Codes.DESCRIPTION) AS Description, SUBSTRING(Gledg.CODE,1," & CodeLen & ") AS Code, " & _
                   "SUM(DEBIT-CREDIT) Balance " & _
             "From Gledg, Codes, " & _
                   "(SELECT DISTINCT SUBSTRING(CODE,1," & CodeLen & ") SUBCODE FROM Gledg " & _
                   " WHERE SUBSTRING(CODE,1," & CodeLen & ")='" & TCode & "') G " & _
             "WHERE Type In (Select CFType From CFTypes) And VDATE <= '" & Format(TmpStr, "dd-MMM-yyyy") & "' " & _
                   "AND GLEDG.BRCODE = '" & TtBrCode & "' " & _
                   "AND GLEDG.POSTED = 'Y' " & _
                   "AND SUBSTRING(Gledg.CODE,1," & CodeLen & " ) = G.SUBCODE " & _
                   "AND Codes.CODE = G.SUBCODE+'" & Fillit("", "0", aCodeL - CodeLen) & "'" & _
             " GROUP BY SUBSTRING(Gledg.CODE,1," & CodeLen & ") "

        Else

            mSQL = "SELECT MAX(Codes.DESCRIPTION) AS Description,SUBSTRING(Gledg.CODE,1," & CodeLen & ") AS Code, " & _
                   "SUM(DEBIT-CREDIT) Balance  " & _
               "FROM Gledg, Codes " & _
               "WHERE Type In (Select CFType From CFTypes) And VDATE <= '" & Format(TmpStr, "dd-MMM-yyyy") & "' " & _
                   "AND GLEDG.BRCODE = '" & TtBrCode & "' " & _
                   "AND GLEDG.POSTED = 'Y' " & _
                   "AND SUBSTRING(Gledg.CODE,1," & CodeLen & ") = '" & TCode & "' " & _
                   "AND Codes.CODE = '" & TCode & Fillit("", "0", aCodeL - CodeLen) & "' " & _
               "GROUP BY SUBSTRING(Gledg.CODE,1," & CodeLen & ")"

        End If
        GetBrSqlCF = mSQL

    End Function

    Private Function GetBrSqlAF(ByVal TtBrCode As String, ByVal PrDate As Date, ByVal TDate As Date, ByVal TCode As String, ByVal CodeLen As Integer, ByVal PrtNotes As Boolean) As String
        Dim mSQL As String
        Dim PrStr As String
        Dim TmpStr As String

        PrStr = GetCmpDate(PrDate)
        TmpStr = Format(TDate, "dd-MMM-yyyy")
        If PrtNotes Then

            mSQL = "SELECT MAX(Codes.DESCRIPTION) AS Description, SUBSTRING(Gledg.CODE,1," & CodeLen & ") AS Code, " & _
                   "SUM(DEBIT-CREDIT) Balance " & _
             "From Gledg, Codes, " & _
                   "(SELECT DISTINCT SUBSTRING(CODE,1," & CodeLen & ") SUBCODE FROM Gledg " & _
                   " WHERE SUBSTRING(CODE,1," & CodeLen & ")='" & TCode & "') G " & _
             "WHERE Type In (Select CFType From CFTypes) And VDATE Between " & _
                   "'" & Format(SDate, "dd-MMM-yyyy") & "' And '" & Format(TmpStr, "dd-MMM-yyyy") & "' " & _
                   "AND GLEDG.BRCODE = '" & TtBrCode & "' " & _
                   "AND GLEDG.POSTED = 'Y' " & _
                   "AND SUBSTRING(Gledg.CODE,1," & CodeLen & " ) = G.SUBCODE " & _
                   "AND Codes.CODE = G.SUBCODE+'" & Fillit("", "0", aCodeL - CodeLen) & "'" & _
             " GROUP BY SUBSTRING(Gledg.CODE,1," & CodeLen & ") "

        Else

            mSQL = "SELECT MAX(Codes.DESCRIPTION) AS Description,SUBSTRING(Gledg.CODE,1," & CodeLen & ") AS Code, " & _
                   "SUM(DEBIT-CREDIT) Balance  " & _
               "FROM Gledg, Codes " & _
               "WHERE Type In (Select CFType From CFTypes) And VDATE Between " & _
                   "'" & Format(SDate, "dd-MMM-yyyy") & "' And '" & Format(TmpStr, "dd-MMM-yyyy") & "' " & _
                   "AND GLEDG.BRCODE = '" & TtBrCode & "' " & _
                   "AND GLEDG.POSTED = 'Y' " & _
                   "AND SUBSTRING(Gledg.CODE,1," & CodeLen & ") = '" & TCode & "' " & _
                   "AND Codes.CODE = '" & TCode & Fillit("", "0", aCodeL - CodeLen) & "' " & _
               "GROUP BY SUBSTRING(Gledg.CODE,1," & CodeLen & ")"

        End If
        GetBrSqlAF = mSQL

    End Function

    Private Function GetBrSqlOF(ByVal TtBrCode As String, ByVal PrDate As Date, ByVal TDate As Date, ByVal TCode As String, ByVal CodeLen As Integer, ByVal PrtNotes As Boolean) As String
        Dim mSQL As String
        Dim PrStr As String
        Dim TmpStr As String

        PrStr = GetCmpDate(PrDate)
        TmpStr = Format(TDate, "dd-MMM-yyyy")
        If PrtNotes Then

            mSQL = "SELECT MAX(Codes.DESCRIPTION) AS Description, SUBSTRING(Gledg.CODE,1," & CodeLen & ") AS Code, " & _
                   "SUM(DEBIT-CREDIT) Balance " & _
             "From Gledg, Codes, " & _
                   "(SELECT DISTINCT SUBSTRING(CODE,1," & CodeLen & ") SUBCODE FROM Gledg " & _
                   " WHERE SUBSTRING(CODE,1," & CodeLen & ")='" & TCode & "') G " & _
             "WHERE Type In (Select CFType From CFTypes) And VDATE < '" & Format(SDate, "dd-MMM-yyyy") & "' " & _
                   "AND GLEDG.BRCODE = '" & TtBrCode & "' " & _
                   "AND GLEDG.POSTED = 'Y' " & _
                   "AND SUBSTRING(Gledg.CODE,1," & CodeLen & " ) = G.SUBCODE " & _
                   "AND Codes.CODE = G.SUBCODE+'" & Fillit("", "0", aCodeL - CodeLen) & "'" & _
             " GROUP BY SUBSTRING(Gledg.CODE,1," & CodeLen & ") "

        Else

            mSQL = "SELECT MAX(Codes.DESCRIPTION) AS Description,SUBSTRING(Gledg.CODE,1," & CodeLen & ") AS Code, " & _
                   "SUM(DEBIT-CREDIT) Balance  " & _
               "FROM Gledg, Codes " & _
               "WHERE Type In (Select CFType From CFTypes) And VDATE < '" & Format(SDate, "dd-MMM-yyyy") & "' " & _
                   "AND GLEDG.BRCODE = '" & TtBrCode & "' " & _
                   "AND GLEDG.POSTED = 'Y' " & _
                   "AND SUBSTRING(Gledg.CODE,1," & CodeLen & ") = '" & TCode & "' " & _
                   "AND Codes.CODE = '" & TCode & Fillit("", "0", aCodeL - CodeLen) & "' " & _
               "GROUP BY SUBSTRING(Gledg.CODE,1," & CodeLen & ")"

        End If
        GetBrSqlOF = mSQL

    End Function

    Private Function GetBrSqlDF(ByVal TtBrCode As String, ByVal PrDate As Date, ByVal TDate As Date, ByVal TCode As String, ByVal CodeLen As Integer, ByVal PrtNotes As Boolean) As String
        Dim mSQL As String
        Dim PrStr As String
        Dim TmpStr As String

        PrStr = GetCmpDate(PrDate)
        TmpStr = Format(TDate, "dd-MMM-yyyy")
        If PrtNotes Then

            mSQL = "SELECT MAX(Codes.DESCRIPTION) AS Description, SUBSTRING(Gledg.CODE,1," & CodeLen & ") AS Code, " & _
                   "SUM(DEBIT) Balance " & _
             "From Gledg, Codes, " & _
                   "(SELECT DISTINCT SUBSTRING(CODE,1," & CodeLen & ") SUBCODE FROM Gledg " & _
                   " WHERE SUBSTRING(CODE,1," & CodeLen & ")='" & TCode & "') G " & _
             "WHERE Type In (Select CFType From CFTypes) And VDATE Between " & _
                   "'" & Format(SDate, "dd-MMM-yyyy") & "' And '" & Format(TmpStr, "dd-MMM-yyyy") & "' " & _
                   "AND GLEDG.BRCODE = '" & TtBrCode & "' " & _
                   "AND GLEDG.POSTED = 'Y' " & _
                   "AND SUBSTRING(Gledg.CODE,1," & CodeLen & " ) = G.SUBCODE " & _
                   "AND Codes.CODE = G.SUBCODE+'" & Fillit("", "0", aCodeL - CodeLen) & "'" & _
             " GROUP BY SUBSTRING(Gledg.CODE,1," & CodeLen & ") "

        Else

            mSQL = "SELECT MAX(Codes.DESCRIPTION) AS Description,SUBSTRING(Gledg.CODE,1," & CodeLen & ") AS Code, " & _
                   "SUM(DEBIT) Balance  " & _
               "FROM Gledg, Codes " & _
               "WHERE Type In (Select CFType From CFTypes) And VDATE Between " & _
                   "'" & Format(SDate, "dd-MMM-yyyy") & "' And '" & Format(TmpStr, "dd-MMM-yyyy") & "' " & _
                   "AND GLEDG.BRCODE = '" & TtBrCode & "' " & _
                   "AND GLEDG.POSTED = 'Y' " & _
                   "AND SUBSTRING(Gledg.CODE,1," & CodeLen & ") = '" & TCode & "' " & _
                   "AND Codes.CODE = '" & TCode & Fillit("", "0", aCodeL - CodeLen) & "' " & _
               "GROUP BY SUBSTRING(Gledg.CODE,1," & CodeLen & ")"

        End If
        GetBrSqlDF = mSQL

    End Function

    Private Function GetBrSqlRF(ByVal TtBrCode As String, ByVal PrDate As Date, ByVal TDate As Date, ByVal TCode As String, ByVal CodeLen As Integer, ByVal PrtNotes As Boolean) As String
        Dim mSQL As String
        Dim PrStr As String
        Dim TmpStr As String

        PrStr = GetCmpDate(PrDate)
        TmpStr = Format(TDate, "dd-MMM-yyyy")
        If PrtNotes Then

            mSQL = "SELECT MAX(Codes.DESCRIPTION) AS Description, SUBSTRING(Gledg.CODE,1," & CodeLen & ") AS Code, " & _
                   "SUM(CREDIT) Balance " & _
             "From Gledg, Codes, " & _
                   "(SELECT DISTINCT SUBSTRING(CODE,1," & CodeLen & ") SUBCODE FROM Gledg " & _
                   " WHERE SUBSTRING(CODE,1," & CodeLen & ")='" & TCode & "') G " & _
             "WHERE Type In (Select CFType From CFTypes) And VDATE Between " & _
                   "'" & Format(SDate, "dd-MMM-yyyy") & "' And '" & Format(TmpStr, "dd-MMM-yyyy") & "' " & _
                   "AND GLEDG.BRCODE = '" & TtBrCode & "' " & _
                   "AND GLEDG.POSTED = 'Y' " & _
                   "AND SUBSTRING(Gledg.CODE,1," & CodeLen & " ) = G.SUBCODE " & _
                   "AND Codes.CODE = G.SUBCODE+'" & Fillit("", "0", aCodeL - CodeLen) & "'" & _
             " GROUP BY SUBSTRING(Gledg.CODE,1," & CodeLen & ") "

        Else

            mSQL = "SELECT MAX(Codes.DESCRIPTION) AS Description,SUBSTRING(Gledg.CODE,1," & CodeLen & ") AS Code, " & _
                   "SUM(CREDIT) Balance  " & _
               "FROM Gledg, Codes " & _
               "WHERE Type In (Select CFType From CFTypes) And VDATE Between " & _
                   "'" & Format(SDate, "dd-MMM-yyyy") & "' And '" & Format(TmpStr, "dd-MMM-yyyy") & "' " & _
                   "AND GLEDG.BRCODE = '" & TtBrCode & "' " & _
                   "AND GLEDG.POSTED = 'Y' " & _
                   "AND SUBSTRING(Gledg.CODE,1," & CodeLen & ") = '" & TCode & "' " & _
                   "AND Codes.CODE = '" & TCode & Fillit("", "0", aCodeL - CodeLen) & "' " & _
               "GROUP BY SUBSTRING(Gledg.CODE,1," & CodeLen & ")"

        End If
        GetBrSqlRF = mSQL

    End Function

    Private Function GetBrSqlC(ByVal TtBrCode As String, ByVal PrDate As Date, ByVal TDate As Date, ByVal TCode As String, ByVal CodeLen As Integer, ByVal PrtNotes As Boolean) As String
        Dim mSQL As String
        Dim PrStr As String
        Dim TmpStr As String

        PrStr = GetCmpDate(PrDate)
        TmpStr = Format(TDate, "dd-MMM-yyyy")
        If PrtNotes Then

            mSQL = "SELECT MAX(Codes.DESCRIPTION) AS Description, SUBSTRING(Gledg.CODE,1," & CodeLen & ") AS Code, " & _
                   "SUM(DEBIT-CREDIT) Balance " & _
             "From Gledg, Codes, " & _
                   "(SELECT DISTINCT SUBSTRING(CODE,1," & CodeLen & ") SUBCODE FROM Gledg " & _
                   " WHERE SUBSTRING(CODE,1," & CodeLen & ")='" & TCode & "') G " & _
             "WHERE VDATE <= '" & Format(TmpStr, "dd-MMM-yyyy") & "' " & _
                   "AND GLEDG.BRCODE = '" & TtBrCode & "' " & _
                   "AND GLEDG.POSTED = 'Y' " & _
                   "AND SUBSTRING(Gledg.CODE,1," & CodeLen & " ) = G.SUBCODE " & _
                   "AND Codes.CODE = G.SUBCODE+'" & Fillit("", "0", aCodeL - CodeLen) & "'" & _
             " GROUP BY SUBSTRING(Gledg.CODE,1," & CodeLen & ") "

        Else

            mSQL = "SELECT MAX(Codes.DESCRIPTION) AS Description,SUBSTRING(Gledg.CODE,1," & CodeLen & ") AS Code, " & _
                   "SUM(DEBIT-CREDIT) Balance  " & _
               "FROM Gledg, Codes " & _
               "WHERE VDATE <= '" & Format(TmpStr, "dd-MMM-yyyy") & "' " & _
                   "AND GLEDG.BRCODE = '" & TtBrCode & "' " & _
                   "AND GLEDG.POSTED = 'Y' " & _
                   "AND SUBSTRING(Gledg.CODE,1," & CodeLen & ") = '" & TCode & "' " & _
                   "AND Codes.CODE = '" & TCode & Fillit("", "0", aCodeL - CodeLen) & "' " & _
               "GROUP BY SUBSTRING(Gledg.CODE,1," & CodeLen & ")"

        End If
        GetBrSqlC = mSQL

    End Function

    Private Function GetBrSqlA(ByVal TtBrCode As String, ByVal PrDate As Date, ByVal TDate As Date, ByVal TCode As String, ByVal CodeLen As Integer, ByVal PrtNotes As Boolean) As String
        Dim mSQL As String
        Dim PrStr As String
        Dim TmpStr As String

        PrStr = GetCmpDate(PrDate)
        TmpStr = Format(TDate, "dd-MMM-yyyy")
        If PrtNotes Then

            mSQL = "SELECT MAX(Codes.DESCRIPTION) AS Description, SUBSTRING(Gledg.CODE,1," & CodeLen & ") AS Code, " & _
                   "SUM(DEBIT-CREDIT) Balance " & _
             "From Gledg, Codes, " & _
                   "(SELECT DISTINCT SUBSTRING(CODE,1," & CodeLen & ") SUBCODE FROM Gledg " & _
                   " WHERE SUBSTRING(CODE,1," & CodeLen & ")='" & TCode & "') G " & _
             "WHERE VDATE Between '" & Format(SDate, "dd-MMM-yyyy") & "' And " & _
                   "'" & Format(TmpStr, "dd-MMM-yyyy") & "' " & _
                   "AND GLEDG.BRCODE = '" & TtBrCode & "' " & _
                   "AND GLEDG.POSTED = 'Y' " & _
                   "AND SUBSTRING(Gledg.CODE,1," & CodeLen & " ) = G.SUBCODE " & _
                   "AND Codes.CODE = G.SUBCODE+'" & Fillit("", "0", aCodeL - CodeLen) & "'" & _
             " GROUP BY SUBSTRING(Gledg.CODE,1," & CodeLen & ") "

        Else

            mSQL = "SELECT MAX(Codes.DESCRIPTION) AS Description,SUBSTRING(Gledg.CODE,1," & CodeLen & ") AS Code, " & _
                   "SUM(DEBIT-CREDIT) Balance  " & _
               "FROM Gledg, Codes " & _
               "WHERE VDATE Between '" & Format(SDate, "dd-MMM-yyyy") & "' And " & _
                   "'" & Format(TmpStr, "dd-MMM-yyyy") & "' " & _
                   "AND GLEDG.BRCODE = '" & TtBrCode & "' " & _
                   "AND GLEDG.POSTED = 'Y' " & _
                   "AND SUBSTRING(Gledg.CODE,1," & CodeLen & ") = '" & TCode & "' " & _
                   "AND Codes.CODE = '" & TCode & Fillit("", "0", aCodeL - CodeLen) & "' " & _
               "GROUP BY SUBSTRING(Gledg.CODE,1," & CodeLen & ")"

        End If
        GetBrSqlA = mSQL

    End Function

    Private Function GetBrSqlO(ByVal TtBrCode As String, ByVal PrDate As Date, ByVal TDate As Date, ByVal TCode As String, ByVal CodeLen As Integer, ByVal PrtNotes As Boolean) As String
        Dim mSQL As String
        Dim PrStr As String
        Dim TmpStr As String

        PrStr = GetCmpDate(PrDate)
        TmpStr = Format(TDate, "dd-MMM-yyyy")
        If PrtNotes Then

            mSQL = "SELECT MAX(Codes.DESCRIPTION) AS Description, SUBSTRING(Gledg.CODE,1," & CodeLen & ") AS Code, " & _
                   "SUM(DEBIT-CREDIT) Balance " & _
             "From Gledg, Codes, " & _
                   "(SELECT DISTINCT SUBSTRING(CODE,1," & CodeLen & ") SUBCODE FROM Gledg " & _
                   " WHERE SUBSTRING(CODE,1," & CodeLen & ")='" & TCode & "') G " & _
             "WHERE VDATE < '" & Format(SDate, "dd-MMM-yyyy") & "' " & _
                   "AND GLEDG.BRCODE = '" & TtBrCode & "' " & _
                   "AND GLEDG.POSTED = 'Y' " & _
                   "AND SUBSTRING(Gledg.CODE,1," & CodeLen & " ) = G.SUBCODE " & _
                   "AND Codes.CODE = G.SUBCODE+'" & Fillit("", "0", aCodeL - CodeLen) & "'" & _
             " GROUP BY SUBSTRING(Gledg.CODE,1," & CodeLen & ") "

        Else

            mSQL = "SELECT MAX(Codes.DESCRIPTION) AS Description,SUBSTRING(Gledg.CODE,1," & CodeLen & ") AS Code, " & _
                   "SUM(DEBIT-CREDIT) Balance  " & _
               "FROM Gledg, Codes " & _
               "WHERE VDATE < '" & Format(SDate, "dd-MMM-yyyy") & "' " & _
                   "AND GLEDG.BRCODE = '" & TtBrCode & "' " & _
                   "AND GLEDG.POSTED = 'Y' " & _
                   "AND SUBSTRING(Gledg.CODE,1," & CodeLen & ") = '" & TCode & "' " & _
                   "AND Codes.CODE = '" & TCode & Fillit("", "0", aCodeL - CodeLen) & "' " & _
               "GROUP BY SUBSTRING(Gledg.CODE,1," & CodeLen & ")"

        End If
        GetBrSqlO = mSQL

    End Function

    Private Function GetBrSqlD(ByVal TtBrCode As String, ByVal PrDate As Date, ByVal TDate As Date, ByVal TCode As String, ByVal CodeLen As Integer, ByVal PrtNotes As Boolean) As String
        Dim mSQL As String
        Dim PrStr As String
        Dim TmpStr As String

        PrStr = GetCmpDate(PrDate)
        TmpStr = Format(TDate, "dd-MMM-yyyy")
        If PrtNotes Then

            mSQL = "SELECT MAX(Codes.DESCRIPTION) AS Description, SUBSTRING(Gledg.CODE,1," & CodeLen & ") AS Code, " & _
                   "SUM(DEBIT) Balance " & _
             "From Gledg, Codes, " & _
                   "(SELECT DISTINCT SUBSTRING(CODE,1," & CodeLen & ") SUBCODE FROM Gledg " & _
                   " WHERE SUBSTRING(CODE,1," & CodeLen & ")='" & TCode & "') G " & _
             "WHERE VDATE Between '" & Format(SDate, "dd-MMM-yyyy") & "' And " & _
                   "'" & Format(TmpStr, "dd-MMM-yyyy") & "' " & _
                   "AND GLEDG.BRCODE = '" & TtBrCode & "' " & _
                   "AND GLEDG.POSTED = 'Y' " & _
                   "AND SUBSTRING(Gledg.CODE,1," & CodeLen & " ) = G.SUBCODE " & _
                   "AND Codes.CODE = G.SUBCODE+'" & Fillit("", "0", aCodeL - CodeLen) & "'" & _
             " GROUP BY SUBSTRING(Gledg.CODE,1," & CodeLen & ") "

        Else

            mSQL = "SELECT MAX(Codes.DESCRIPTION) AS Description,SUBSTRING(Gledg.CODE,1," & CodeLen & ") AS Code, " & _
                   "SUM(DEBIT) Balance  " & _
               "FROM Gledg, Codes " & _
               "WHERE VDATE Between '" & Format(SDate, "dd-MMM-yyyy") & "' And " & _
                   "'" & Format(TmpStr, "dd-MMM-yyyy") & "' " & _
                   "AND GLEDG.BRCODE = '" & TtBrCode & "' " & _
                   "AND GLEDG.POSTED = 'Y' " & _
                   "AND SUBSTRING(Gledg.CODE,1," & CodeLen & ") = '" & TCode & "' " & _
                   "AND Codes.CODE = '" & TCode & Fillit("", "0", aCodeL - CodeLen) & "' " & _
               "GROUP BY SUBSTRING(Gledg.CODE,1," & CodeLen & ")"

        End If
        GetBrSqlD = mSQL

    End Function

    Private Function GetBrSqlR(ByVal TtBrCode As String, ByVal PrDate As Date, ByVal TDate As Date, ByVal TCode As String, ByVal CodeLen As Integer, ByVal PrtNotes As Boolean) As String
        Dim mSQL As String
        Dim PrStr As String
        Dim TmpStr As String

        PrStr = GetCmpDate(PrDate)
        TmpStr = Format(TDate, "dd-MMM-yyyy")
        If PrtNotes Then

            mSQL = "SELECT MAX(Codes.DESCRIPTION) AS Description, SUBSTRING(Gledg.CODE,1," & CodeLen & ") AS Code, " & _
                   "SUM(CREDIT) Balance " & _
             "From Gledg, Codes, " & _
                   "(SELECT DISTINCT SUBSTRING(CODE,1," & CodeLen & ") SUBCODE FROM Gledg " & _
                   " WHERE SUBSTRING(CODE,1," & CodeLen & ")='" & TCode & "') G " & _
             "WHERE VDATE Between '" & Format(SDate, "dd-MMM-yyyy") & "' And " & _
                   "'" & Format(TmpStr, "dd-MMM-yyyy") & "' " & _
                   "AND GLEDG.BRCODE = '" & TtBrCode & "' " & _
                   "AND GLEDG.POSTED = 'Y' " & _
                   "AND SUBSTRING(Gledg.CODE,1," & CodeLen & " ) = G.SUBCODE " & _
                   "AND Codes.CODE = G.SUBCODE+'" & Fillit("", "0", aCodeL - CodeLen) & "'" & _
             " GROUP BY SUBSTRING(Gledg.CODE,1," & CodeLen & ") "

        Else

            mSQL = "SELECT MAX(Codes.DESCRIPTION) AS Description,SUBSTRING(Gledg.CODE,1," & CodeLen & ") AS Code, " & _
                   "SUM(CREDIT) Balance  " & _
               "FROM Gledg, Codes " & _
               "WHERE VDATE Between '" & Format(SDate, "dd-MMM-yyyy") & "' And " & _
                   "'" & Format(TmpStr, "dd-MMM-yyyy") & "' " & _
                   "AND GLEDG.BRCODE = '" & TtBrCode & "' " & _
                   "AND GLEDG.POSTED = 'Y' " & _
                   "AND SUBSTRING(Gledg.CODE,1," & CodeLen & ") = '" & TCode & "' " & _
                   "AND Codes.CODE = '" & TCode & Fillit("", "0", aCodeL - CodeLen) & "' " & _
               "GROUP BY SUBSTRING(Gledg.CODE,1," & CodeLen & ")"

        End If
        GetBrSqlR = mSQL

    End Function

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub chkPrtNotes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkPrtNotes.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub dtpDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub dtpEndDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpEndDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub frmRPT_PrtStat_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        mPDefRefCross = False
    End Sub

    Private Sub frmRPT_PrtStat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmMdi
        dtpDate.Value = SySDate
        dtpEndDate.Value = SySDate
    End Sub

    Private Sub dtpDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDate.ValueChanged
        If dtpDate.Value > SySDate Then
            MsgBox("Start Date Cannot Be Greater Than Current Date", vbInformation, SysCompany)
            dtpDate.Text = SySDate
        End If
    End Sub

    Private Sub dtpEndDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtpEndDate.Validating
        If dtpDate.Value > SySDate Then
            MsgBox("End Date Cannot Be Greater Than Current Date", vbInformation, SysCompany)
            e.Cancel = True
            dtpDate.Text = SySDate
        End If

    End Sub

    Private Sub dtpEndDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpEndDate.ValueChanged

    End Sub
End Class