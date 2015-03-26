Imports System.Data
Imports System.Data.SqlClient
Imports Basic.DAL
Imports Basic.DAL.Utils
Imports Basic.Constants.ProjConst


Public Class frmRPT_Aging
    'Inherits System.Windows.Forms.Form

    Dim objAging As New cAging

    Dim ObjFind As Grid_Help
    Dim strFind As String
    Dim mReport As String
    Dim RepName As String
    Dim StrRepHdr1 As String
    Dim StrRepHdr2 As String
    Dim StrRepHdr3 As String
    Dim StrFilter As String
    Dim Tdays(7) As Integer
    Dim Amt(7) As Double
    Dim TBalance As Double
    Dim Days As Integer
    Dim TSign As Integer
    Dim TotAmt As Double
    Dim PaidAmt As Double
    Dim TCode As String
    Dim dtAging As New DataTable
    Dim dtCode As New DataTable
    Dim dtBalance As New DataTable
    Dim rowNum As Integer
    Dim rowNum1 As Integer

    Private Sub txtBrCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBrCode.KeyDown
        ObjFind = New Grid_Help
        If e.KeyCode = Keys.F1 Then
            ObjFind.PMessage = "Branch"
            strFind = "SELECT BrCode,BrName FROM Branch Order By BrCode"
            ObjFind.sqlqueryFun = strFind
            ObjFind.ShowDialog()

            If ObjFind.PbOk = True Then
                Me.txtBrCode.Text = ObjFind.strPKfun & ""
                Me.lblBrName.Text = ObjFind.sqlqueryFun & ""
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtBrCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtBrCode.Validating
        If Trim(txtBrCode.Text) <> "" Then
            txtBrCode.Text = Format(Val(Trim(txtBrCode.Text)), "000")
            mSQL = "SELECT BrName FROM Branch WHERE BrCode = '" & Trim(txtBrCode.Text) & "'"
            mSQL = GetFldValue(mSQL, "BrName")
            lblBrName.Text = mSQL
            If mSQL = "" Then
                MsgBox("No Record Found", vbInformation, SysCompany)
                txtBrCode.Text = ""
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub mskStartCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mskStartCode.KeyDown
        ObjFind = New Grid_Help
        If e.KeyCode = Keys.F1 Then
            ObjFind.PMessage = "Codes"
            'strFind = "SELECT Code,Description FROM Codes Order By Code"
            strFind = "SELECT Code,Description FROM Codes " & _
                       "where Len(Code)= " & aCodeL & StrFilter
            ObjFind.sqlqueryFun = strFind
            ObjFind.ShowDialog()

            If ObjFind.PbOk = True Then
                Me.mskStartCode.Text = aStr2Code(ObjFind.strPKfun) & ""
                Me.lblStartName.Text = ObjFind.sqlqueryFun & ""
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
            strFind = "SELECT Code,Description FROM Codes " & _
                       "where Len(Code)= " & aCodeL & StrFilter
            ObjFind.sqlqueryFun = strFind
            ObjFind.ShowDialog()

            If ObjFind.PbOk = True Then
                Me.mskEndCode.Text = aStr2Code(ObjFind.strPKfun) & ""
                Me.lblEndName.Text = ObjFind.sqlqueryFun & ""
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub mskStartCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mskStartCode.Validating
        If mskStartCode.Text <> aEmptyCode Then
            If Not (Len(aCode2Str(mskStartCode.Text)) = aP1L Or Len(aCode2Str(mskStartCode.Text)) = aP1L + aP2L + aP3L Or Len(aCode2Str(mskStartCode.Text)) = aCodeL) Then
                MsgBox("Invalid Code Length", vbInformation, SysCompany)
                mskStartCode.Text = aEmptyCode
                e.Cancel = True
                Exit Sub
            Else
                mSQL = "Select Code From Codes Where Code = '" & aCode2Str(mskStartCode.Text) & "' " & StrFilter
                mSQL = GetFldValue(mSQL, "Code")
                If mSQL <> "" Then
                    mSQL = "SELECT Description FROM Codes WHERE Code = '" & aCode2Str(mskStartCode.Text) & "'"
                    mSQL = GetFldValue(mSQL, "Description")
                    lblStartName.Text = mSQL
                    mskEndCode.Text = mskStartCode.Text
                    lblEndName.Text = lblStartName.Text
                    Exit Sub
                Else
                    MsgBox("Invalid Code Is Not Allowed Here", vbInformation, SysCompany)
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
                MsgBox("Invalid Code Length", vbInformation, SysCompany)
                mskEndCode.Text = aEmptyCode
                e.Cancel = True
                Exit Sub
            Else
                mSQL = "Select Code From Codes Where Code = '" & aCode2Str(mskEndCode.Text) & "' " & StrFilter
                mSQL = GetFldValue(mSQL, "Code")
                If mSQL <> "" Then
                    mSQL = "SELECT Description FROM Codes WHERE Code = '" & aCode2Str(mskEndCode.Text) & "'"
                    mSQL = GetFldValue(mSQL, "Description")
                    lblEndName.Text = mSQL
                    Exit Sub
                Else
                    MsgBox("Invalid Code Is Not Allowed Here", vbInformation, SysCompany)
                    mskEndCode.Text = aEmptyCode
                    lblEndName.Text = ""
                    mskEndCode.Focus()
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub frmRPT_Aging_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        mAAnalysis = False
    End Sub

    Private Sub frmRPT_Aging_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.MdiParent = frmMdi
        Call SetParms()
        Call SetAccParam()
        Call ClearAll()
        mskStartCode.Mask = aMaskCode
        mskEndCode.Mask = aMaskCode
        txtBrCode.Focus()
        Tdays(1) = 60
        Tdays(2) = 90
        Tdays(3) = 180
        Tdays(4) = 365
        Tdays(5) = 730
        Tdays(6) = 1095
        Tdays(7) = 1095
    End Sub

    Private Sub txtFirst_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFirst.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtFirst_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFirst.LostFocus
        Label7.Text = CStr(Val(Trim(txtFirst.Text)) + 1)
    End Sub

    Private Sub txtSecond_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSecond.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtSecond_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSecond.LostFocus
        If Val(Trim(txtSecond.Text)) < Val(Label7.Text) Then
            MsgBox("Upper Value can't be less than Lower Value", vbInformation, SysCompany)
            txtSecond.Text = Val(Label7.Text)
            txtSecond.Focus()
            Exit Sub
        Else
            Label10.Text = ""
            Label10.Text = CStr(Val(Trim(txtSecond.Text)) + 1)
        End If
    End Sub

    Private Sub txtThird_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtThird.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtThird_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtThird.LostFocus
        If Val(Trim(txtThird.Text)) < Val(Label10.Text) Then
            MsgBox("Upper Value can't be less than Lower Value", vbInformation, SysCompany)
            txtThird.Text = Val(Label10.Text)
            txtThird.Focus()
            Exit Sub
        Else
            Label12.Text = ""
            Label12.Text = CStr(Val(Trim(txtThird.Text)) + 1)
        End If
    End Sub

    Private Sub txtFour_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFour.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtFour_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFour.LostFocus
        If Val(Trim(txtFour.Text)) < Val(Label12.Text) Then
            MsgBox("Upper Value can't be less than Lower Value", vbInformation, SysCompany)
            txtFour.Text = Val(Label12.Text)
            txtFour.Focus()
            Exit Sub
        Else
            Label14.Text = ""
            Label14.Text = CStr(Val(Trim(txtFour.Text)) + 1)
        End If
    End Sub

    Private Sub txtFive_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFive.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtFive_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFive.LostFocus
        If Val(Trim(txtFive.Text)) < Val(Label14.Text) Then
            MsgBox("Upper Value can't be less than Lower Value", vbInformation, SysCompany)
            txtFive.Text = Val(Label14.Text)
            txtFive.Focus()
            Exit Sub
        Else
            Label16.Text = ""
            Label16.Text = CStr(Val(Trim(txtFive.Text)) + 1)
        End If
    End Sub

    Private Sub txtSix_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSix.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtSix_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSix.LostFocus
        If Val(Trim(txtSix.Text)) < Val(Label16.Text) Then
            MsgBox("Upper Value can't be less than Lower Value", vbInformation, SysCompany)
            txtSix.Text = Val(Label16.Text)
            txtSix.Focus()
            Exit Sub
        Else
            txtSeven.Text = Trim(txtSix.Text)
        End If
    End Sub

    Private Sub btnPreview_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Dim i As Integer
        'Dim count As Integer

        objAging.DelAging()
        objAging.SCode = aCode2Str(mskStartCode.Text)
        objAging.ECode = aCode2Str(mskEndCode.Text)
        dtCode = objAging.GetCode
        rowNum = dtCode.Rows.Count - 1
        Tdays(1) = Val(txtFirst.Text)
        Tdays(2) = Val(txtSecond.Text)
        Tdays(3) = Val(txtThird.Text)
        Tdays(4) = Val(txtFour.Text)
        Tdays(5) = Val(txtFive.Text)
        Tdays(6) = Val(txtSix.Text)
        Tdays(7) = Val(txtSeven.Text)
        If rowNum >= 0 Then
            rowNum = 0
            Do While rowNum < dtCode.Rows.Count
                TCode = dtCode.Rows(rowNum).Item("Code")
                TotAmt = 0
                TBalance = 0
                For i = 1 To 7
                    Amt(i) = 0
                Next
                objAging.BrCode = Trim(txtBrCode.Text)
                objAging.Code = TCode
                objAging.VDate = GetDate(dtpVDate.Text, "dd-MMM-yyyy")
                dtBalance = objAging.GetBalance
                rowNum1 = dtBalance.Rows.Count - 1
                If rowNum1 >= 0 Then
                    rowNum1 = 0
                    Do While rowNum1 < dtBalance.Rows.Count
                        TBalance = TBalance + (dtBalance.Rows(rowNum1).Item("Debit") - dtBalance.Rows(rowNum1).Item("Credit")) * TSign
                        Days = DateDiff("d", dtBalance.Rows(rowNum1).Item("VDate"), dtpVDate.Text)
                        i = 1
                        Do While Days > Tdays(i) And i < 7
                            i = i + 1
                        Loop
                        If TSign < 0 Then
                            Amt(i) = Amt(i) + dtBalance.Rows(rowNum1).Item("Credit")
                            TotAmt = TotAmt + dtBalance.Rows(rowNum1).Item("Credit")
                        Else
                            Amt(i) = Amt(i) + dtBalance.Rows(rowNum1).Item("Debit")
                            TotAmt = TotAmt + dtBalance.Rows(rowNum1).Item("Debit")
                        End If
                        rowNum1 = rowNum1 + 1
                    Loop
                    PaidAmt = TotAmt - TBalance
                    i = 7
                    Do While PaidAmt <> 0 And i <> 0
                        If Amt(i) < PaidAmt Then
                            PaidAmt = PaidAmt - Amt(i)
                            Amt(i) = 0
                        Else
                            Amt(i) = Amt(i) - PaidAmt
                            PaidAmt = 0
                        End If
                        i = i - 1
                    Loop
                    Call SaveValues()
                End If
                rowNum = rowNum + 1
            Loop
        End If
        Call CallReport(0)
    End Sub

    Private Sub rdbCredit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbCredit.Click
        If rdbCredit.Checked = True Then
            rdbDebit.Checked = False
            TSign = -1
        End If
    End Sub

    Private Sub rdbDebit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbDebit.Click
        If rdbDebit.Checked = True Then
            rdbCredit.Checked = False
            TSign = 1
        End If
    End Sub

    Sub SaveValues()
        If CheckValidation() Then
            SetData()
            objAging.SaveAging()
        End If
    End Sub

    Private Sub SetData()
        objAging.Code = TCode
        objAging.AgDate = GetDate(Me.dtpVDate.Text, "dd-MMM-yyyy")
        objAging.TotAmt = TBalance
        objAging.FstInt = "0 - " & Trim(Me.txtFirst.Text)
        objAging.FstAmt = Amt(1)
        objAging.SndInt = Val(Label7.Text) & " - " & Val(Me.txtSecond.Text)
        objAging.SndAmt = Amt(2)
        objAging.TrdInt = Val(Label10.Text) & " - " & Val(Me.txtThird.Text)
        objAging.TrdAmt = Amt(3)
        objAging.FurInt = Val(Label12.Text) & " - " & Val(Me.txtFour.Text)
        objAging.FurAmt = Amt(4)
        objAging.FveInt = Val(Label14.Text) & " - " & Val(Me.txtFive.Text)
        objAging.FveAmt = Amt(5)
        objAging.SixInt = Val(Label16.Text) & " - " & Val(Me.txtSix.Text)
        objAging.SixAmt = Amt(6)
        objAging.SvnInt = "0ver " & Trim(Me.txtSeven.Text)
        objAging.SvnAmt = Amt(7)
    End Sub

    Private Function CheckValidation() As Boolean
        If Trim(txtBrCode.Text) = "" Then
            MsgBox("Please Enter Branch Code.", MsgBoxStyle.Information, SysCompany)
            txtBrCode.Focus()
            Return False
        ElseIf mskStartCode.Text = aEmptyCode Then
            MsgBox("Please Enter Starting Account Code.", MsgBoxStyle.Information, SysCompany)
            mskStartCode.Focus()
            Return False
        ElseIf mskEndCode.Text = aEmptyCode Then
            MsgBox("Please Enter Ending Account Code", MsgBoxStyle.Information, SysCompany)
            mskEndCode.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub CallReport(ByVal mPara As Integer)

        If Trim(mskStartCode.Text) = "" Then
            MsgBox("Starting Code Can't be Empty", vbInformation, SysCompany)
            Exit Sub
        ElseIf Trim(mskEndCode.Text) = "" Then
            MsgBox("Ending Code Can't be Empty", vbInformation, SysCompany)
            Exit Sub
        ElseIf Trim(mskStartCode.Text) > Trim(mskEndCode.Text) Then
            MsgBox("Starting Code Can't be Greater Then Ending Code ", vbInformation, SysCompany)
            Exit Sub
        End If
        'StrRepHdr1 = "For A/C Code " & aStr2Code(mskStartCode.Text) & " To " & aStr2Code(mskEndCode.Text)
        'StrRepHdr2 = "As On " & Format(dtpVDate.Value, "dd-MMM-yyyy") & ""

        RepName = "Aging.rpt"

        ' ''***************
        ' ''Report Printing
        ' ''***************

        Dim path As String = RepPath & RepName

        Dim rptDoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptDoc.Load(path)

        RepName = "Aging Reports"
        strHeader1 = "From Code " + mskStartCode.Text + "  To  " + mskEndCode.Text
        strHeader2 = "Analysis Date " + GetDate(dtpVDate.Text, "dd-MMM-yyyy")

        rptDoc.SetParameterValue("@ComDetail", Trim(lblBrName.Text))
        rptDoc.SetParameterValue("@RepTitle", RepName)
        rptDoc.SetParameterValue("@RepHeader1", strHeader1)
        rptDoc.SetParameterValue("@RepHeader2", strHeader2)

        frmReport.Show()
        frmReport.ShowTransReport(rptDoc, "AccSys")
    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Call CallReport(1)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub dtpVDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpVDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub rdbCredit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rdbCredit.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub rdbDebit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rdbDebit.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtSeven_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSeven.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Sub ClearAll()
        txtBrCode.Text = ""
        lblBrName.Text = ""
        mskStartCode.Text = aEmptyCode
        lblStartName.Text = ""
        mskEndCode.Text = aEmptyCode
        lblEndName.Text = ""
    End Sub

    Private Sub txtFirst_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFirst.TextChanged

    End Sub

    Private Sub dtpVDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtpVDate.Validating
        If dtpVDate.Value > SySDate Then
            MsgBox("Date Cannot Be Greater Than Current Date", vbInformation, SysCompany)
            e.Cancel = True
            dtpVDate.Text = SySDate
        End If
    End Sub

    Private Sub dtpVDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpVDate.ValueChanged

    End Sub

    Private Sub mskStartCode_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles mskStartCode.MaskInputRejected

    End Sub
End Class
