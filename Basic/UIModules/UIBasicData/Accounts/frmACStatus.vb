
Imports System.Data
Imports System.Data.SqlClient
Imports Basic.Constants.ProjConst
Imports Basic.DAL
Imports Basic.DAL.Utils

Public Class frmACStatus

    Dim objACStatus As New cACStatus

    Dim ObjFind As Grid_Help
    Dim strFind As String
    Public mRefBrCode As String
    Public mRefAcCode As String
    Public mRefStDate As Date
    Public mRefEndDate As Date
    Dim dtACStatus As New DataTable
    Dim rowNum As Integer

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
        txtBrCode.Text = ""
        lblBrName.Text = ""
        mskCode.Text = ""
        lblRfCode.Text = ""
        LBLOpBal.Text = ""
        LBLTotBal.Text = ""
        LBLTotCr.Text = ""
        LBLTotDr.Text = ""
        mRefAcCode = ""
        mRefBrCode = ""
        mRefStDate = SySDate
        mRefEndDate = SySDate
        'mRefStDate = SySDate
        'mRefEndDate = SySDate
        Me.Close()
    End Sub

    Private Sub frmACStatus_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Label15.Text = "A/C Code Status (On-Screen)" Then
            mCStatus = False
        ElseIf Label15.Text = "Bank Book (On-Screen)" Then
            mBBookScr = False
        ElseIf Label15.Text = "Cash Book (On-Screen)" Then
            mCBookScr = False
        End If
    End Sub

    Private Sub frmACStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmMdi
        Me.Top = 0
        Me.Left = 0
        Me.WindowState = FormWindowState.Maximized
        Call vspGrid.ClearRange(1, 1, vspGrid.MaxCols, vspGrid.MaxRows, True)
        Call SetAccParam()
        mskCode.Mask = aMaskCode
        dtpStartDate.Value = SySDate
        dtpEndDate.Value = SySDate

        If pPara = 9 Then
            Me.Text = "A/C Code Status (On-Screen)"
            Label15.Text = "A/C Code Status (On-Screen)"
            Exit Sub
        ElseIf pPara = 10 Then
            Me.Text = "Bank Book (On-Screen)"
            Label15.Text = "Bank Book (On-Screen)"
            Exit Sub
        ElseIf pPara = 11 Then
            Me.Text = "Cash Book (On-Screen)"
            Label15.Text = "Cash Book (On-Screen)"
            Exit Sub
        End If
        If (mRefBrCode <> "" And mRefAcCode <> "") Then
            txtBrCode.Text = mRefBrCode
            mSQL = "Select BrName From Branch Where BrCode = '" & Trim(txtBrCode.Text) & "'"
            lblBrName.Text = GetFldValue(mSQL, "BrName")
            mskCode.Text = aStr2Code(mRefAcCode)
            mSQL = "Select Description From Codes Where Code = '" & aCode2Str(mskCode.Text) & "'"
            lblRfCode.Text = GetFldValue(mSQL, "Description")
            'dtpStartDate.Value = Format(mRefStDate, "dd-MMM-yyyy")
            'dtpEndDate.Value = Format(mRefEndDate, "dd-MMM-yyyy")
            'dtpStartDate.Value = CDate(SySDate)
            'dtpEndDate.Value = CDate(SySDate)
            dtpStartDate.Value = CDate(mRefStDate)
            dtpEndDate.Value = CDate(mRefEndDate)
            GpCriteria.Enabled = False
            Call dtpEndDate_LostFocus(Nothing, Nothing)
        End If
    End Sub

    Sub ClearGrid()
        Call vspGrid.ClearRange(1, 1, vspGrid.MaxCols, vspGrid.MaxRows, True)
        vspGrid.MaxRows = 1
    End Sub

    Private Sub dtpEndDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpEndDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub dtpEndDate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpEndDate.LostFocus
        ClearGrid()
        objACStatus.BrCode = Trim(txtBrCode.Text)
        objACStatus.Code = aCode2Str(mskCode.Text)
        objACStatus.StDate = GetDate(dtpStartDate.Value, "dd-MMM-yyyy")
        objACStatus.EnDate = GetDate(dtpEndDate.Value, "dd-MMM-yyyy")
        dtACStatus = objACStatus.FillGrid()
        rowNum = dtACStatus.Rows.Count - 1
        If rowNum >= 0 Then
            Call DispACCode()
        Else
            MsgBox("No Record Found", MsgBoxStyle.Information)
        End If
    End Sub
    Sub DispACCode()
        Dim mi As Integer
        Dim mtotDr As Double
        Dim mtotCr As Double
        Dim mTotBal As Double

        Try
            If dtACStatus.Rows(0).Item("OpBal") > 0 Then
                LBLOpBal.Text = Format(dtACStatus.Rows(0).Item("OpBal"), NumFmt)
            Else
                LBLOpBal.Text = "(" & Format(0 - dtACStatus.Rows(0).Item("OpBal"), NumFmt) & ")"
            End If

            mtotDr = 0
            mtotCr = 0
            mTotBal = dtACStatus.Rows(0).Item("OpBal")
            'mTotBal = objACStatus.OpBal
            If dtACStatus.Rows.Count > 0 Then
                vspGrid.MaxRows = 1
                vspGrid.SetText(1, 1, "")
                vspGrid.SetText(2, 1, "")
                vspGrid.SetText(3, 1, "")
                vspGrid.SetText(4, 1, "")
                vspGrid.SetText(5, 1, "")
                vspGrid.SetText(6, 1, "")
                vspGrid.SetText(7, 1, "")
                vspGrid.SetText(8, 1, "")
                vspGrid.SetText(9, 1, "")
                vspGrid.SetText(10, 1, "")
                vspGrid.SetText(11, 1, "")

                For mi = 1 To dtACStatus.Rows.Count
                    Dim mStr As String
                    If mi > vspGrid.MaxRows Then
                        vspGrid.MaxRows = vspGrid.MaxRows + 1
                    End If

                    If dtACStatus.Rows(mi - 1).Item("BrCode").ToString() = "" Then



                    Else





                        mStr = dtACStatus.Rows(mi - 1).Item("BrCode").ToString()
                        vspGrid.SetText(1, mi, mStr)
                        mStr = dtACStatus.Rows(mi - 1).Item("BrName").ToString()
                        vspGrid.SetText(2, mi, mStr)
                        mStr = dtACStatus.Rows(mi - 1).Item("Type").ToString()
                        vspGrid.SetText(3, mi, mStr)
                        mStr = dtACStatus.Rows(mi - 1).Item("VNo").ToString()
                        vspGrid.SetText(4, mi, mStr)
                        'If dtACStatus.Rows(mi - 1).Item("VDate")  System.DBNull.Value Then
                        If IsDBNull(dtACStatus.Rows(mi - 1).Item("VDate")) Then
                            ' mStr = dtACStatus.Rows(mi - 1).Item("VDate").ToString()
                            mStr = "" 'GetDate(dtACStatus.Rows(mi - 1).Item("VDate"), "dd-MMM-yyyy")
                            vspGrid.SetText(5, mi, mStr)
                        Else
                            mStr = dtACStatus.Rows(mi - 1).Item("VDate").ToString()
                            mStr = GetDate(dtACStatus.Rows(mi - 1).Item("VDate"), "dd-MMM-yyyy")
                            vspGrid.SetText(5, mi, mStr)
                        End If


                        mStr = dtACStatus.Rows(mi - 1).Item("Remarks").ToString()
                        vspGrid.SetText(6, mi, mStr)
                        mStr = dtACStatus.Rows(mi - 1).Item("RfCode").ToString()
                        vspGrid.SetText(7, mi, aStr2Code(mStr))
                        If Not IsDBNull(dtACStatus.Rows(mi - 1).Item("Debit")) Then
                            mStr = dtACStatus.Rows(mi - 1).Item("Debit").ToString
                            vspGrid.SetText(8, mi, Format(Val(mStr), "##,###,###,###.00"))
                            mtotDr = mtotDr + Val(mStr)
                        End If
                        If Not IsDBNull(dtACStatus.Rows(mi - 1).Item("Credit")) Then
                            mStr = dtACStatus.Rows(mi - 1).Item("Credit").ToString
                            vspGrid.SetText(9, mi, Format(Val(mStr), "##,###,###,###.00"))
                            mtotCr = mtotCr + Val(mStr)
                        End If
                        mTotBal = mTotBal + dtACStatus.Rows(mi - 1).Item("Debit") - dtACStatus.Rows(mi - 1).Item("Credit")
                        mStr = mTotBal
                        vspGrid.SetText(10, mi, mStr)
                        mStr = dtACStatus.Rows(mi - 1).Item("Posted").ToString()
                        vspGrid.SetText(11, mi, mStr)
                        If mi < dtACStatus.Rows.Count Then
                            vspGrid.MaxRows = vspGrid.MaxRows + 1
                        End If


                    End If


                Next
            End If
            LBLTotDr.Text = Format(mtotDr, "##,###,###,###.00")
            LBLTotCr.Text = Format(mtotCr, "##,###,###,###.00")
            If mTotBal > 0 Then
                LBLTotBal.Text = Format(mTotBal, "##,###,###,###.00")
            Else
                LBLTotBal.Text = "(" & Format(0 - mTotBal, "##,###,###,###.00") & ")"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    'Sub DispACCode()
    '    Dim mi As Integer
    '    Dim mtotDr As Double
    '    Dim mtotCr As Double
    '    Dim mTotBal As Double

    '    Try
    '        If dtACStatus.Rows(0).Item("OpBal") > 0 Then
    '            LBLOpBal.Text = Format(dtACStatus.Rows(0).Item("OpBal"), NumFmt)
    '        Else
    '            LBLOpBal.Text = "(" & Format(0 - dtACStatus.Rows(0).Item("OpBal"), NumFmt) & ")"
    '        End If

    '        mtotDr = 0
    '        mtotCr = 0
    '        mTotBal = dtACStatus.Rows(0).Item("OpBal")
    '        'mTotBal = objACStatus.OpBal
    '        If dtACStatus.Rows.Count > 0 Then
    '            vspGrid.MaxRows = 1
    '            vspGrid.SetText(1, 1, "")
    '            vspGrid.SetText(2, 1, "")
    '            vspGrid.SetText(3, 1, "")
    '            vspGrid.SetText(4, 1, "")
    '            vspGrid.SetText(5, 1, "")
    '            vspGrid.SetText(6, 1, "")
    '            vspGrid.SetText(7, 1, "")
    '            vspGrid.SetText(8, 1, "")
    '            vspGrid.SetText(9, 1, "")
    '            vspGrid.SetText(10, 1, "")
    '            vspGrid.SetText(11, 1, "")

    '            For mi = 1 To dtACStatus.Rows.Count
    '                Dim mStr As String
    '                If mi > vspGrid.MaxRows Then
    '                    vspGrid.MaxRows = vspGrid.MaxRows + 1
    '                End If
    '                mStr = dtACStatus.Rows(mi - 1).Item("BrCode").ToString()
    '                vspGrid.SetText(1, mi, mStr)
    '                mStr = dtACStatus.Rows(mi - 1).Item("BrName").ToString()
    '                vspGrid.SetText(2, mi, mStr)
    '                mStr = dtACStatus.Rows(mi - 1).Item("Type").ToString()
    '                vspGrid.SetText(3, mi, mStr)
    '                mStr = dtACStatus.Rows(mi - 1).Item("VNo").ToString()
    '                vspGrid.SetText(4, mi, mStr)
    '                If dtACStatus.Rows(mi - 1).Item("VDate").ToString() <> vbNull Then
    '                    mStr = dtACStatus.Rows(mi - 1).Item("VDate").ToString()
    '                    mStr = GetDate(dtACStatus.Rows(mi - 1).Item("VDate"), "dd-MMM-yyyy")
    '                    vspGrid.SetText(5, mi, mStr)

    '                End If
    '                mStr = dtACStatus.Rows(mi - 1).Item("Remarks").ToString()
    '                vspGrid.SetText(6, mi, mStr)
    '                mStr = dtACStatus.Rows(mi - 1).Item("RfCode").ToString()
    '                vspGrid.SetText(7, mi, aStr2Code(mStr))
    '                If Not IsDBNull(dtACStatus.Rows(mi - 1).Item("Debit")) Then
    '                    mStr = dtACStatus.Rows(mi - 1).Item("Debit").ToString
    '                    vspGrid.SetText(8, mi, Format(Val(mStr), "##,###,###,###.00"))
    '                    mtotDr = mtotDr + Val(mStr)
    '                End If
    '                If Not IsDBNull(dtACStatus.Rows(mi - 1).Item("Credit")) Then
    '                    mStr = dtACStatus.Rows(mi - 1).Item("Credit").ToString
    '                    vspGrid.SetText(9, mi, Format(Val(mStr), "##,###,###,###.00"))
    '                    mtotCr = mtotCr + Val(mStr)
    '                End If
    '                mTotBal = mTotBal + dtACStatus.Rows(mi - 1).Item("Debit") - dtACStatus.Rows(mi - 1).Item("Credit")
    '                mStr = mTotBal
    '                vspGrid.SetText(10, mi, mStr)
    '                mStr = dtACStatus.Rows(mi - 1).Item("Posted").ToString()
    '                vspGrid.SetText(11, mi, mStr)
    '                If mi < dtACStatus.Rows.Count Then
    '                    vspGrid.MaxRows = vspGrid.MaxRows + 1
    '                End If
    '            Next
    '        End If
    '        LBLTotDr.Text = Format(mtotDr, "##,###,###,###.00")
    '        LBLTotCr.Text = Format(mtotCr, "##,###,###,###.00")
    '        If mTotBal > 0 Then
    '            LBLTotBal.Text = Format(mTotBal, "##,###,###,###.00")
    '        Else
    '            LBLTotBal.Text = "(" & Format(0 - mTotBal, "##,###,###,###.00") & ")"
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Information)
    '    End Try
    'End Sub

    Private Sub vspGrid_ClickEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_ClickEvent) Handles vspGrid.ClickEvent
        Dim mTmp1 As Object
        Dim mTmp2 As Object
        Dim mTmp3 As Object

        If e.row = vspGrid.ActiveRow Then
            Erase mTmp1
            vspGrid.GetText(1, vspGrid.ActiveRow, mTmp1)    'BrCode
            frmVoucherDetail.mBrCode = mTmp1
            Erase mTmp2
            vspGrid.GetText(3, vspGrid.ActiveRow, mTmp2)    'Type
            frmVoucherDetail.mType = mTmp2
            Erase mTmp3
            vspGrid.GetText(4, vspGrid.ActiveRow, mTmp3)
            frmVoucherDetail.mVNo = mTmp3                   'Code
            'frmVoucherDetail.ShowDialog()
            frmVoucherDetail.Show()
        End If
    End Sub

    Private Sub mskCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mskCode.KeyDown
        ObjFind = New Grid_Help
        If e.KeyCode = Keys.F1 Then
            If pPara = 9 Then
                strFind = "SELECT Code,Description FROM Codes " & _
                       "Where (Left(CODE,2) <> '" & pBank & "' And " & _
                       "Left(Code,2) <> '" & pCash & "') Order By Code"
            ElseIf pPara = 10 Then
                strFind = "SELECT Code,Description FROM Codes " & _
                       "Where Left(CODE,2) = '" & pBank & "' Order By Code"
            ElseIf pPara = 11 Then
                strFind = "SELECT Code,Description FROM Codes " & _
                       "Where Left(CODE,2) = '" & pCash & "' Order By Code"
            End If
            ObjFind.PMessage = "Codes"
            ObjFind.sqlqueryFun = strFind
            ObjFind.ShowDialog()

            If ObjFind.PbOk = True Then
                mskCode.Text = ObjFind.strPKfun & ""
                lblRfCode.Text = ObjFind.sqlqueryFun & ""
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub mskCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mskCode.Validating
        If mskCode.Text <> "  -  -  -" Then
            If mskCode.Text <> "" Then
                If Not ChkCode(aCode2Str(mskCode.Text)) Then
                    mskCode.Text = aEmptyCode
                    lblRfCode.Text = ""
                    e.Cancel = True
                    Exit Sub
                Else
                    StrCode = aCode2Str(mskCode.Text)
                    If (Mid(StrCode, 1, 2) = "00" Or Mid(StrCode, 3, 2) = "00" Or Mid(StrCode, 5, 4) = "0000") Then
                        MsgBox("Control Code Is Not Allowed Here", vbInformation, SysCompany)
                        mskCode.Text = aEmptyCode
                        lblRfCode.Text = ""
                        e.Cancel = True
                        mskCode.Focus()
                        Exit Sub
                    Else
                        If pPara = 9 Then
                            If (Mid(StrCode, 1, 2) <> pBank And Mid(StrCode, 1, 2) <> pCash) Then
                                mSQL = "SELECT Description FROM Codes WHERE CODE = '" & _
                                        aCode2Str(mskCode.Text) & "'"
                                mSQL = GetFldValue(mSQL, "Description")
                                lblRfCode.Text = mSQL
                                Exit Sub
                            Else
                                MsgBox("Bank/Cash Code Is Not Allowed Here", vbInformation, SysCompany)
                                mskCode.Text = aEmptyCode
                                lblRfCode.Text = ""
                                e.Cancel = True
                                mskCode.Focus()
                                Exit Sub
                            End If
                        ElseIf pPara = 10 Then
                            If Mid(StrCode, 1, 2) = pBank Then
                                mSQL = "SELECT Description FROM Codes WHERE CODE = '" & _
                                        aCode2Str(mskCode.Text) & "'"
                                mSQL = GetFldValue(mSQL, "Description")
                                lblRfCode.Text = mSQL
                                Exit Sub
                            Else
                                MsgBox("Only Bank Code Is Allowed Here", vbInformation, SysCompany)
                                mskCode.Text = aEmptyCode
                                lblRfCode.Text = ""
                                e.Cancel = True
                                mskCode.Focus()
                                Exit Sub
                            End If
                        ElseIf pPara = 11 Then
                            If Mid(StrCode, 1, 2) = pCash Then
                                mSQL = "SELECT Description FROM Codes WHERE CODE = '" & _
                                        aCode2Str(mskCode.Text) & "'"
                                mSQL = GetFldValue(mSQL, "Description")
                                lblRfCode.Text = mSQL
                                Exit Sub
                            Else
                                MsgBox("Only Cash Code Is Allowed Here", vbInformation, SysCompany)
                                mskCode.Text = aEmptyCode
                                lblRfCode.Text = ""
                                e.Cancel = True
                                mskCode.Focus()
                                Exit Sub
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

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
            txtBrCode.Text = Format(Val(txtBrCode.Text), "000")
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

    Private Sub dtpStartDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpStartDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub mskCode_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles mskCode.MaskInputRejected

    End Sub

    Private Sub vspGrid_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles vspGrid.Advance

    End Sub
End Class