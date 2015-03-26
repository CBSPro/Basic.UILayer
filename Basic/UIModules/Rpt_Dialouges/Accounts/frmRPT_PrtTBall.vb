Imports System.Data
Imports System.Data.SqlClient
Imports Basic.DAL
Imports Basic.Constants.ProjConst
Imports Basic.DAL.Utils

Public Class frmRPT_PrtTBall
    Inherits System.Windows.Forms.Form

    Dim objTBall As New cTrialBal

    Dim PODS As New DataSet
    Dim DtAcc As New DataTable
    Dim DaAcc As SqlDataAdapter
    Dim StrFromDate As String
    Dim objRow As Data.DataRow
    Dim tableName As String = "TBall"
    Dim dtTBall As New DataTable
    Dim dtBranch As New DataTable
    Dim dtCode As DataTable
    Dim Tbal As Double
    Dim Tdesc As String
    Dim rowNum As Integer
    Dim rowNum1 As Integer
    Dim rowNum2 As Integer

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmRPT_PrtTBall_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        mTBalCross = False
    End Sub

    Private Sub frmRPT_PrtTBall_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.MdiParent = frmMdi
        rdbFirst.Checked = True
        rdbSecond.Checked = False
        rdbThird.Checked = False
        lblProcess.Text = ""
        ProgBar.Value = 0
        dtpDate.Text = SySDate
        objTBall.DelTBall()
    End Sub

    Private Sub btnProcess_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProcess.Click
        objTBall.DelTBall()
        CallReport(0)
        frmExportTB.ShowDialog()
    End Sub

    Private Sub CallReport(ByVal mPara As Integer)

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

        ''

        ''********* REPORT CALLING

        StrFromDate = "AS ON " & Format(dtpDate.ToString, "DD/MM/YYYY")
        Call MakeTB(dtpDate.Value)
    End Sub

    ''**************************************************************************
    '' ************ PROCESS PRINT STATEMENTS ***********************************
    ''**************************************************************************

    Private Sub MakeTB(ByVal TDate As Date)
        Dim mBr As Integer
        Dim mCodeLen As Integer
        ''**
        Dim TbrCode As String
        Dim BrField As String
        ''**
        Dim TCode As String
        ''*** PFTLOSS TABLE QUERY
        If rdbFirst.Checked = True Then
            objTBall.Level = "1"
        ElseIf rdbSecond.Checked = True Then
            objTBall.Level = "2"
        ElseIf rdbThird.Checked = True Then
            objTBall.Level = "3"
        End If

        dtCode = objTBall.LoadCodes()
        rowNum = dtCode.Rows.Count

        If rowNum > 0 Then
            rowNum = 0
            dtTBall = objTBall.GetTBal()
            Do While rowNum < dtCode.Rows.Count
                objTBall.Code = dtCode.Rows(rowNum).Item("Code").ToString
                objTBall.Description = Trim(dtCode.Rows(rowNum).Item("Description").ToString)
                objTBall.SaveValues()
                rowNum = rowNum + 1
            Loop
        End If

        dtTBall = objTBall.GetAllTBal()
        rowNum1 = dtTBall.Rows.Count

        ProgBar.Maximum = dtTBall.Rows.Count

        ' ''*****************
        ' ''*** MAIN LOOP
        ' ''*****************

        dtBranch = objTBall.LoadBranch()
        rowNum2 = dtBranch.Rows.Count
        'If rowNum2 > 0 Then
        mBr = 1
        '    rowNum2 = 0
        '    'Count Branchs 
        'Do While mBr <= dtBranch.Rows.Count
        ProgBar.Value = 0
        If rowNum1 > 0 Then
            rowNum1 = 0
            Do While rowNum1 < dtTBall.Rows.Count
                lblProcess.Text = dtTBall.Rows(rowNum1).Item("Description").ToString
                TCode = dtTBall.Rows(rowNum1).Item("Code").ToString
                mCodeLen = Len(TCode)
                Tdesc = dtTBall.Rows(rowNum1).Item("Description").ToString
                If rowNum > 0 Then
                    rowNum = 0

                    'Do While rowNum < dtBranch.Rows.Count
                    TbrCode = dtBranch.Rows(rowNum).Item("BRCODE").ToString
                    BrField = "BRANCH" & "00" & mBr
                    Tbal = 0
                    mSQL = GetBrSql(TbrCode, TDate, TCode, mCodeLen)
                    mSQL = GetFldValue(mSQL, "Balance")
                    If mSQL <> "" Then
                        Tbal = mSQL
                    End If
                    dtTBall.Rows(rowNum1).Item(BrField) = Tbal
                    objTBall.Code = TCode
                    objTBall.Description = Tdesc
                    objTBall.Branch001 = Tbal
                    objTBall.BranchName = BrField
                    'objTBall.TbrCode = Tbal
                    'Edit TBALL Values
                    objTBall.EditValues()
                    rowNum = rowNum + 1
                    'Loop
                End If
                rowNum1 = rowNum1 + 1
                ProgBar.Value = ProgBar.Value + 1
                'ProgBar.Value = ProgBar.Value + 1
            Loop
        End If
        'rowNum = rowNum + 1
        mBr += 1
        'Loop

        'End If

    End Sub
    ''*********************************************************************
    ''**************** END OF PROCESS PRINT STATEMENT *********************
    ''*********************************************************************

    Private Function GetBrSql(ByVal TtBrCode As String, ByVal TDate As Date, ByVal TCode As String, ByVal CodeLen As Integer) As String

        Dim mSQL As String = ""
        ''Dim PrStr As String
        Dim TmpStr As String


        TmpStr = Format(TDate, "dd-MMM-yyyy")

        If rdbThird.Checked = True Then
            mSQL = "SELECT SUM(DEBIT-CREDIT) Balance  " & _
                   "FROM Gledg WHERE VDATE <= '" & TmpStr & "' " & _
                   "AND GLEDG.BRCODE = '" & TtBrCode & "' " & _
                   "AND GLEDG.POSTED = 'Y' " & _
                   "AND GLEDG.CODE = '" & TCode & Fillit("", "0", aCodeL - CodeLen) & "' " & _
                   "GROUP BY GLEDG.CODE"
        ElseIf rdbSecond.Checked = True Then
            mSQL = "SELECT SUM(DEBIT-CREDIT) Balance  " & _
                   "FROM Gledg WHERE VDATE <= '" & TmpStr & "' " & _
                   "AND GLEDG.BRCODE = '" & TtBrCode & "' " & _
                   "AND GLEDG.POSTED = 'Y' " & _
                   "AND Left(GLEDG.CODE,4) = '" & Mid(TCode, 1, 4) & "' " & _
                   "GROUP BY LEFT(GLEDG.CODE,4)"
        ElseIf rdbFirst.Checked = True Then
            mSQL = "SELECT SUM(DEBIT-CREDIT) Balance  " & _
                   "FROM Gledg WHERE VDATE <= '" & TmpStr & "' " & _
                   "AND GLEDG.BRCODE = '" & TtBrCode & "' " & _
                   "AND GLEDG.POSTED = 'Y' " & _
                   "AND Left(GLEDG.CODE,2) = '" & Mid(TCode, 1, 2) & "' " & _
                   "GROUP BY LEFT(GLEDG.CODE,2)"
        End If
        If mSQL <> "" Then
            GetBrSql = mSQL
            Return mSQL
        Else
            Return ""
        End If
    End Function

    Private Sub dtpDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpDate.KeyDown
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

    Private Sub dtpDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtpDate.Validating
        If dtpDate.Value > SySDate Then
            'If SySDate >= dtpEndDate.Text Then
            MsgBox("Date Cannot Be Greater Than Current Date", vbInformation, SysCompany)
            e.Cancel = True
            dtpDate.Text = SySDate
        End If
    End Sub

    Private Sub dtpDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDate.ValueChanged

    End Sub
End Class