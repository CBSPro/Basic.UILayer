Imports System.Data
Imports System.Data.SqlClient
Imports Basic.DAL
Imports Basic.DAL.Utils
Imports Basic.Constants

Public Class frmRecPay
    Inherits System.Windows.Forms.Form

    Dim objRecPay As New cRecPay
    Dim objProper As New cProper
    Dim PODS As New DataSet
    Dim DtAcc As New DataTable
    Dim dtMaster As New DataTable
    Dim dtDetail As New DataTable
    Dim dtLookup As New DataTable
    Dim dtMasterMenu As New DataTable

    Dim DaAcc As SqlDataAdapter
    Dim objRow As Data.DataRow
    Dim ObjFind As Grid_Help
    Dim tableName As String = "GLHead"
    Dim mOpen As String
    Dim mSeqNo As Integer
    Dim mTotRecs As String
    Dim strFind As String
    Dim SDate As String
    Dim EDate As String
    Dim mPosted As String
    Dim mTmpCode As String
    Dim mtemp As String
    Dim mBPstr As String
    Dim mBRstr As String
    Dim mCPstr As String
    Dim mCRstr As String
    Private strPKValue As String
    Private sqlquery As String
    Public LookSql As String
    Dim rowNum As Integer
    Dim rowNum1 As Integer
    Dim Flag As Boolean
    Dim AddMode As Boolean
    Dim EditMode As Boolean
    Dim KeyReturn As Boolean
    Dim ColBack As Boolean
    Dim SelRow As Boolean
    Dim Inc As Integer
    Dim mindexMenu As Integer
    Public fCategory As Integer
    Dim mFocus As Boolean
    Dim mAdd As Boolean
    Dim mEdit As Boolean
    Dim mDelete As Boolean
    Dim mPost As Boolean
    Dim mPrint As Boolean
    Dim IsSorted As Boolean
    Dim lastsearchrow As Long
    Dim lastsearchlen As Long
    Dim lastcol As Long
    Dim LastSearchTxt As Object
    Dim TmpVar As Object
    
    Private HelpDs As DataSet
    Dim vColumn As Integer = 1
    Private bOK As Boolean = False
    Private Message, mStr As String
    Private strSql As String

    Private Sub frmRecPay_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        GVHelp.Cursor = Cursors.No
        Me.MdiParent = frmMdi
        Me.Top = 0
        Me.Left = 0
        Me.WindowState = FormWindowState.Maximized

        GpTaxDed.Visible = False
        EmptyControls(Me)
        If pParaJV = 5 Then
            mType = "BR"
            Me.Text = "Bank Receipt Voucher"
            MenuName = "miBRVoucher"
            Constants.ProjConst.mfrmBR = False
            LblTypeValid.Text = "Bank Receipt Voucher"
        ElseIf pParaJV = 6 Then
            mType = "BP"
            Me.Text = "Bank Payment Voucher"
            LblTypeValid.Text = "Bank Payment Voucher"
            MenuName = "miBPVoucher"
            Constants.ProjConst.mfrmBP = False
        ElseIf pParaJV = 8 Then
            mType = "CP"
            Me.Text = "Cash Payment Voucher"
            LblTypeValid.Text = "Cash Payment Voucher"
            MenuName = "miCPVoucher"
            Constants.ProjConst.mfrmCP = False
        ElseIf pParaJV = 7 Then
            mType = "CR"
            Me.Text = "Cash Receipt Voucher"
            LblTypeValid.Text = "Cash Receipt Voucher"
            MenuName = "miCRVoucher"
            Constants.ProjConst.mfrmCR = False
        End If
        pParaJV = 0
        objRecPay.Type = mType
        If (mType = "BP" Or mType = "CP") Then
            mskDedCode.Mask = aMaskCode
            lblDedCodeDec.Text = ""
            lblDedAmount.Text = ""
            lblNetPayable.Text = ""
            mskTaxRate.Mask = aMaskTDed
        End If
        ''
        If Mid(mType, 1, 1) = "B" Then
            lblRefCode.Text = "Bank Code"
            vspGrid.Col = 5
            vspGrid.ColHidden = False
        Else
            lblRefCode.Text = "Cash Code"
            vspGrid.Col = 4
            vspGrid.ColHidden = True
        End If
        Call SetEntryMode()
        Call EmptyControls(Me)
        Call setFeild(False)
        Flag = True
        Call SetAccParam()
        Call SetEntryMode()
        mskCode.Mask = aMaskCode
        mskCode.Text = ""
        mskCode.SelectedText = 0
        btnSave.Enabled = False
        btnCancel.Enabled = False
        objRecPay.BrCode = Constants.ProjConst.Branch
        objRecPay.Type = mType
        objRecPay.VDate = Constants.ProjConst.SySDate
        objRecPay.Level = "0"
        btnEdit.Enabled = False
        vspGrid.BlockMode = True
        vspGrid.Enabled = True
        'vspGrid.Enabled = False
        'btnCode.Enabled = False
        Call ClearAll()
        btnStatus(False)
        Call SetFormSecurity(Me)
        Call SetButtonsSurity(Me)
        Call SetButtonPrinciple()
        Call SetButton()
    End Sub

    Sub LoadMaster()
        Try
            txtBrCode.Text = dtMaster.Rows(rowNum).Item("BrCode")
            mSQL = "Select BrName From Branch Where BrCode = '" & Trim(txtBrCode.Text) & "'"
            lblBrName.Text = GetFldValue(mSQL, "BrName")
            dtpVDate.Text = dtMaster.Rows(rowNum).Item("VDate")
            lblVNo.Text = dtMaster.Rows(rowNum).Item("VNo")
            mskCode.Text = aStr2Code(dtMaster.Rows(rowNum).Item("RFCode"))
            mSQL = "Select Description From Codes Where Code = " & _
                   "'" & aCode2Str(mskCode.Text) & "'"
            lblRfCode.Text = GetFldValue(mSQL, "Description")
            txtPurpose.Text = dtMaster.Rows(rowNum).Item("RefRemarks")
            mPosted = GetFldValue("Select Posted From GLHead Where " & _
                        "Type = '" & mType & "' And Vno = '" & lblVNo.Text & "'" & _
                        "And BrCode = '" & Trim(txtBrCode.Text) & "'", "Posted")
            Call SetButtonsSeuctiry1(Me, mPosted)
            If mPosted = "Y" Then
                LBLPosted.Text = "Posted"
            Else
                LBLPosted.Text = "Un-Posted"
            End If
            If mPosted = "Y" Then
                LBLPosted.Text = "Posted"
                btnEdit.Enabled = False
                btnDelete.Enabled = False
                btnPost.Enabled = False
            Else
                LBLPosted.Text = "Un-Posted"
                btnEdit.Enabled = True
                btnDelete.Enabled = True
                btnPost.Enabled = True
            End If
            lblCompany.Text = "Recorded On : " & dtMaster.Rows(rowNum).Item("AddOn")
            lblBy.Text = "Recorded By : " & dtMaster.Rows(rowNum).Item("AddBy")
            lblToolTip.Text = "Close Form"
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Sub LoadDetail()
        Dim mi As Integer
        Dim TotSum As Double
        Dim Fld As String
        TotSum = 0

        Try
            ''
            If LblTypeValid.Text = "Bank Payment Voucher" Then
                mType = "BP"
            ElseIf LblTypeValid.Text = "Bank Receipt Voucher" Then
                mType = "BR"
            ElseIf LblTypeValid.Text = "Cash Receipt Voucher" Then
                mType = "CR"
            ElseIf LblTypeValid.Text = "Cash Payment Voucher" Then
                mType = "CP"
            End If
            If mType = "CR" Or mType = "BR" Then
                Fld = "CREDIT"
            Else
                Fld = "DEBIT"
            End If
            ''
            rowNum1 = 0
            If dtDetail.Rows.Count > 0 Then
                vspGrid.MaxRows = 1
                vspGrid.SetText(1, 1, "")
                vspGrid.SetText(2, 1, "")
                vspGrid.SetText(3, 1, "")
                vspGrid.SetText(4, 1, "")
                vspGrid.SetText(5, 1, "")

                For mi = 1 To dtDetail.Rows.Count
                    Dim mStr As String
                    If mi > vspGrid.MaxRows Then
                        vspGrid.MaxRows = vspGrid.MaxRows + 1
                    End If
                    mStr = dtDetail.Rows(rowNum1).Item("Code").ToString()
                    vspGrid.SetText(1, mi, aStr2Code(mStr))
                    mStr = dtDetail.Rows(rowNum1).Item("Description").ToString()
                    vspGrid.SetText(2, mi, mStr)
                    mStr = dtDetail.Rows(rowNum1).Item("Remarks").ToString()
                    vspGrid.SetText(3, mi, mStr)
                    mStr = dtDetail.Rows(rowNum1).Item("ChequeNo").ToString()
                    vspGrid.SetText(4, mi, mStr)
                    If Not IsDBNull(dtDetail.Rows(rowNum1).Item(Fld)) Then
                        mStr = dtDetail.Rows(rowNum1).Item(Fld).ToString
                        vspGrid.SetText(5, mi, Format(Val(mStr), "##,###,###,###.00"))
                        TotSum = TotSum + dtDetail.Rows(rowNum1).Item(Fld)
                    End If
                    If mi < dtDetail.Rows.Count Then
                        vspGrid.MaxRows = vspGrid.MaxRows + 1
                        rowNum1 = rowNum1 + 1
                    End If
                Next
                lblTotAmt.Text = Format(TotSum, "##,###,###,###.00")
            Else
                vspGrid.MaxRows = 1
                vspGrid.SetText(1, 1, "")
                vspGrid.SetText(2, 1, "")
                vspGrid.SetText(3, 1, "")
                vspGrid.SetText(4, 1, "")
                vspGrid.SetText(5, 1, "")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Sub SetEntryMode()
        btnAdd.Enabled = Flag
        btnEdit.Enabled = Flag
        btnView.Enabled = Flag
        btnDelete.Enabled = Flag
        btnPost.Enabled = Flag
        btnPrint.Enabled = Flag
        btnSave.Enabled = Flag
        btnCancel.Enabled = Flag
        btnFind.Enabled = Flag
        btnRefresh.Enabled = Flag
        btnTop.Enabled = Flag
        btnPrevious.Enabled = Flag
        btnNext.Enabled = Flag
        btnBottom.Enabled = Flag
        btnExit.Enabled = Flag
    End Sub

    Sub ClearAll()
        txtBrCode.Text = ""
        lblBrName.Text = ""
        dtpVDate.Value = Constants.ProjConst.SySDate
        lblVNo.Text = ""
        mskCode.Mask = aMaskCode
        mskCode.Text = ""
        lblRfCode.Text = ""
        txtPurpose.Text = ""
        LBLPosted.Text = ""
        lblTotAmt.Text = ""
        Call ClearGrid()
    End Sub

    Private Function CheckValidation() As Boolean
        Try
            If txtBrCode.Text = "" Then
                MsgBox("Please Enter Branch Code.", MsgBoxStyle.Information, Constants.ProjConst.SysCompany)
                txtBrCode.Focus()
                Return False
            ElseIf dtpVDate.Text = "" Then
                MsgBox("Please Enter Voucher Date", MsgBoxStyle.Information, Constants.ProjConst.SysCompany)
                dtpVDate.Focus()
                Return False

            ElseIf mskCode.Text = aEmpMaskCode Then
                MsgBox("Please Enter Account Code", MsgBoxStyle.Information, Constants.ProjConst.SysCompany)
                mskCode.Focus()
                Return False
            ElseIf Not ValidLine() Then
                'MsgBox("Please Enter Account Code in Grid", MsgBoxStyle.Information, SysCompany)
                Return False

            ElseIf Not CheckTotal() Then
                Return False

            ElseIf (lblTotAmt.Text = 0 Or lblTotAmt.Text = mEmpty) Then
                MsgBox("Voucher With No Detail Lines Can't be Saved", MsgBoxStyle.Information, Constants.ProjConst.SysCompany)
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

        Return True
    End Function

    Private Function ValidLine() As Boolean
        Dim mi As Integer
        Dim Tmp As Object
        Dim mStrCode As String
        Dim mCode As String
        Dim mAmt As Double

        For mi = 1 To vspGrid.MaxRows
            Erase Tmp
            vspGrid.GetText(1, mi, Tmp)
            mCode = Tmp
            mStrCode = mCode
            If mStrCode <> "" Then
                mStrCode = aCode2Str(mStrCode)
                Erase Tmp
                vspGrid.GetText(5, mi, Tmp)
                mAmt = Tmp
                If mAmt <= 0 Then
                    MsgBox("You must Enter Amount With Acount Code => " & mStrCode, vbInformation, Constants.ProjConst.SysCompany)
                    ValidLine = False
                    Exit Function
                End If
            End If
        Next mi
        ValidLine = True
    End Function

    Private Function CheckTotal() As Boolean
        Dim i As Integer
        Dim Tmp As Object
        Dim TotalAmt As Double
        TotalAmt = 0
        For i = 1 To vspGrid.MaxRows
            Erase Tmp
            'Tmp = ""
            vspGrid.GetText(5, i, Tmp) 'vspGrid.GetText(1, rowIndex, mTemp)
            TotalAmt = TotalAmt + Val(Tmp)
        Next i
        lblTotAmt.Text = Format(TotalAmt, "###,###,###,###.00")
        If TotalAmt = 0 Then
            CheckTotal = False
            MsgBox("Voucher With No Detail Lines Can't be Saved", vbInformation, Constants.ProjConst.SysCompany)
        Else
            CheckTotal = True
        End If
    End Function

    Private Sub SetDataMaster()

        objRecPay.BrCode = Trim(txtBrCode.Text)
        If LblTypeValid.Text = "Bank Payment Voucher" Then
            objRecPay.Type = "BP"
        ElseIf LblTypeValid.Text = "Bank Receipt Voucher" Then
            objRecPay.Type = "BR"
        ElseIf LblTypeValid.Text = "Cash Receipt Voucher" Then
            objRecPay.Type = "CR"
        ElseIf LblTypeValid.Text = "Cash Payment Voucher" Then
            objRecPay.Type = "CP"
        End If
        If AddMode = True Then
            objRecPay.VNo = GetJVno(txtBrCode.Text, mType, dtpVDate.Value)
        ElseIf EditMode = True Then
            objRecPay.VNo = lblVNo.Text
        End If
        objRecPay.VDate = Format(dtpVDate.Value, "dd-MMM-yyyy")
        objRecPay.RfCode = aCode2Str(mskCode.Text)
        objRecPay.RefRemarks = Trim(txtPurpose.Text)

        lblVNo.Text = objRecPay.VNo
        If AddMode Then
            objRecPay.AddOn = Constants.ProjConst.SySDate
            objRecPay.AddBy = Constants.ProjConst.SysUserID
        ElseIf EditMode Then
            objRecPay.EditOn = Constants.ProjConst.SySDate
            objRecPay.EditBy = Constants.ProjConst.SysUserID
        End If
    End Sub

    Private Sub SetDataDbCr(ByVal rowIndex As Integer)
        'Dim mi As Integer
        Dim mStrCode As String
        Dim mTemp As Object
        Dim mChequeNo As String
        Dim mRemarks As String
        Dim mAmount As Double

        mSeqNo = 1
        If LblTypeValid.Text = "Bank Payment Voucher" Then
            mType = "BP"
        ElseIf LblTypeValid.Text = "Bank Receipt Voucher" Then
            mType = "BR"
        ElseIf LblTypeValid.Text = "Cash Payment Voucher" Then
            mType = "CP"
        ElseIf LblTypeValid.Text = "Cash Receipt Voucher" Then
            mType = "CR"
        End If
        For rowIndex = 1 To vspGrid.MaxRows

            If Mid(mType, 2, 1) = "R" Then          '1st CR
                Erase mTemp
                vspGrid.GetText(1, rowIndex, mTemp)
                If mTemp <> "" Then
                    mStrCode = ""
                    mChequeNo = ""
                    mRemarks = ""
                    mAmount = 0
                    objRecPay.BrCode = Trim(txtBrCode.Text)
                    objRecPay.Type = mType
                    objRecPay.VNo = lblVNo.Text
                    objRecPay.SeqNo = Format(mSeqNo, "00000")
                    objRecPay.RfCode = aCode2Str(mskCode.Text)
                    objRecPay.Code = aCode2Str(mTemp)
                    Erase mTemp
                    vspGrid.GetText(3, rowIndex, mTemp)
                    objRecPay.Remarks = mTemp & " "
                    Erase mTemp
                    vspGrid.GetText(4, rowIndex, mTemp)
                    objRecPay.Chequeno = mTemp
                    Erase mTemp
                    vspGrid.GetText(5, rowIndex, mTemp)
                    mAmount = Format(Val(mTemp), "##,###,###,###.##")
                    If Mid(mType, 2, 1) = "R" Then
                        objRecPay.Debit = 0
                        objRecPay.Credit = mAmount
                    ElseIf Mid(mType, 2, 1) = "P" Then
                        objRecPay.Debit = mAmount
                        objRecPay.Credit = 0
                    End If
                    mSeqNo = mSeqNo + 1
                    objRecPay.SaveDetail()
                End If
            End If

            If Mid(mType, 2, 1) = "P" Then          '1st BP
                Erase mTemp
                vspGrid.GetText(1, rowIndex, mTemp)
                If mTemp <> "" Then
                    mStrCode = ""
                    mChequeNo = ""
                    mRemarks = ""
                    mAmount = 0
                    objRecPay.BrCode = Trim(txtBrCode.Text)
                    objRecPay.Type = mType
                    objRecPay.VNo = lblVNo.Text
                    objRecPay.SeqNo = Format(mSeqNo, "00000")
                    objRecPay.RfCode = aCode2Str(mskCode.Text)
                    objRecPay.Code = aCode2Str(mTemp)
                    Erase mTemp
                    vspGrid.GetText(3, rowIndex, mTemp)
                    objRecPay.Remarks = mTemp & " "
                    Erase mTemp
                    vspGrid.GetText(4, rowIndex, mTemp)
                    mChequeNo = mTemp
                    objRecPay.Chequeno = mChequeNo
                    Erase mTemp
                    vspGrid.GetText(5, rowIndex, mTemp)
                    mAmount = Format(Val(mTemp), "##,###,###,###.##")
                    If Mid(mType, 2, 1) = "R" Then
                        objRecPay.Debit = 0
                        objRecPay.Credit = mAmount
                    ElseIf Mid(mType, 2, 1) = "P" Then
                        objRecPay.Debit = mAmount
                        objRecPay.Credit = 0
                    End If
                    mSeqNo = mSeqNo + 1
                    objRecPay.SaveDetail()
                End If
            End If
        Next
        For rowIndex = 1 To vspGrid.MaxRows
            If Mid(mType, 2, 1) = "P" Then      '2nd BP
                Erase mTemp
                vspGrid.GetText(1, rowIndex, mTemp)
                If mTemp <> "" Then
                    mStrCode = ""
                    mChequeNo = ""
                    mRemarks = ""
                    mAmount = 0
                    objRecPay.BrCode = Trim(txtBrCode.Text)
                    objRecPay.Type = mType
                    objRecPay.VNo = lblVNo.Text
                    objRecPay.SeqNo = Format(mSeqNo, "00000")
                    objRecPay.RfCode = aCode2Str(mTemp)
                    objRecPay.Code = aCode2Str(mskCode.Text)
                    Erase mTemp
                    vspGrid.GetText(3, rowIndex, mTemp)
                    objRecPay.Remarks = mTemp & " "
                    Erase mTemp
                    vspGrid.GetText(4, rowIndex, mTemp)
                    mChequeNo = mTemp
                    objRecPay.Chequeno = mChequeNo
                    Erase mTemp
                    vspGrid.GetText(5, rowIndex, mTemp)
                    mAmount = Format(Val(mTemp), "##,###,###,###.##")
                    If Mid(mType, 2, 1) = "R" Then
                        objRecPay.Debit = mAmount
                        objRecPay.Credit = 0
                    ElseIf Mid(mType, 2, 1) = "P" Then
                        objRecPay.Debit = 0
                        objRecPay.Credit = mAmount
                    End If
                    mSeqNo = mSeqNo + 1
                    objRecPay.SaveDetail()
                End If
            End If
            If Mid(mType, 2, 1) = "R" Then      '2nd CR
                Erase mTemp
                vspGrid.GetText(1, rowIndex, mTemp)
                If mTemp <> "" Then
                    mStrCode = ""
                    mChequeNo = ""
                    mRemarks = ""
                    mAmount = 0
                    objRecPay.BrCode = Trim(txtBrCode.Text)
                    objRecPay.Type = mType
                    objRecPay.VNo = lblVNo.Text
                    objRecPay.SeqNo = Format(mSeqNo, "00000")
                    objRecPay.RfCode = aCode2Str(mTemp)
                    objRecPay.Code = aCode2Str(mskCode.Text)
                    Erase mTemp
                    vspGrid.GetText(3, rowIndex, mTemp)
                    objRecPay.Remarks = mTemp & " "
                    Erase mTemp
                    vspGrid.GetText(4, rowIndex, mTemp)
                    mChequeNo = mTemp
                    objRecPay.Chequeno = mChequeNo
                    Erase mTemp
                    vspGrid.GetText(5, rowIndex, mTemp)
                    mAmount = Format(Val(mTemp), "##,###,###,###.##")
                    If Mid(mType, 2, 1) = "R" Then
                        objRecPay.Debit = mAmount
                        objRecPay.Credit = 0
                    ElseIf Mid(mType, 2, 1) = "P" Then
                        objRecPay.Debit = 0
                        objRecPay.Credit = mAmount
                    End If
                    mSeqNo = mSeqNo + 1
                    objRecPay.SaveDetail()
                End If
            End If
        Next
    End Sub

    Private Sub SetDataReverse(ByVal rowIndex As Integer)
        Dim mStrCode As String
        Dim mTemp As Object
        Dim mChequeNo As String
        Dim mRemarks As String
        Dim mAmount As Double

        Erase mTemp
        vspGrid.GetText(1, rowIndex, mTemp)
        If mTemp <> "" Then
            mStrCode = ""
            mChequeNo = ""
            mRemarks = ""
            mAmount = 0
            objRecPay.BrCode = Trim(txtBrCode.Text)
            objRecPay.Type = mType
            objRecPay.VNo = lblVNo.Text
            objRecPay.SeqNo = Format(mSeqNo, "00000")
            objRecPay.Code = aCode2Str(mTemp)
            aCode2Str(vspGrid.GetText(1, rowIndex, mStrCode))
            objRecPay.RfCode = mStrCode
            Erase mTemp
            vspGrid.GetText(3, rowIndex, mTemp)
            mRemarks = mTemp
            objRecPay.Remarks = mRemarks
            Erase mTemp
            vspGrid.GetText(4, rowIndex, mTemp)
            mChequeNo = mTemp
            objRecPay.Chequeno = mChequeNo
            Erase mTemp
            vspGrid.GetText(5, rowIndex, mTemp)
            mAmount = Format(Val(mTemp), "##,###,###,###.##")
            If Mid(mType, 2, 1) = "R" Then
                objRecPay.Debit = 0
                objRecPay.Credit = mAmount
            ElseIf Mid(mType, 2, 1) = "P" Then
                objRecPay.Debit = mAmount
                objRecPay.Credit = 0
            End If
            mSeqNo = mSeqNo + 1
        End If
        'Next
    End Sub

    Private Sub dtpVDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpVDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub dtpVDate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpVDate.LostFocus
        If AddMode Then
            lblVNo.Text = GetJVno(txtBrCode.Text, mType, dtpVDate.Value)
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        AddMode = True
        EditMode = False
        Flag = False
        Call SetEntryMode()
        Call ClearAll()
        Call SetEntryMode()
        GpData.Enabled = True
        lblCompany.Text = "Recorded On " & GetDate(Constants.ProjConst.SySDate, "dd-MM-yyyy")
        lblToolTip.Text = "Add New Record"
        lblBy.Text = "Recorded By : " & Constants.ProjConst.SysUserID
        txtBrCode.Enabled = True
        txtBrCode.Focus()
        btnSave.Enabled = True
        btnCancel.Enabled = True
        vspGrid.BlockMode = False
        vspGrid.Enabled = True
        btnCode.Enabled = True
        setFeild(True)
        EmptyControls(Me)

    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim mi As Integer
        Dim mTmpNo As String
        mTmpNo = Trim(lblVNo.Text)
        Try
            lblToolTip.Text = "Save Current Record"
            If CheckValidation() Then
                objRecPay.getConnection()
                objRecPay.BeginTransaction()
                If AddMode Then
                    Try
                        SetDataMaster()         'Set Master Object Variables
                        objRecPay.SaveMaster()  'Save Master Object Variables
                        SetDataDbCr(mi)         ' Save(Detail)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        objRecPay.RollBack()
                        Exit Sub
                    End Try
                ElseIf EditMode Then
                    Try
                        EditSet()
                        SetDataMaster()         'Set Master Object Variables
                        objRecPay.EditMaster()
                        SetDataDbCr(mi)         ' Save(Detail)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        objRecPay.RollBack()
                        Exit Sub
                    End Try
                End If
                objRecPay.CommitTransction()
                If Trim(lblVNo.Text) <> Trim(mTmpNo) Then
                    MsgBox("Your Transaction Is Saved With Voucher " & mType & " " & lblVNo.Text, vbInformation, Constants.ProjConst.SysCompany)
                End If
                If AddMode Then
                    Call btnAdd_Click(Nothing, Nothing)

                    If LblTypeValid.Text = "Bank Payment Voucher" Then
                        mStr = mBPstr
                    ElseIf LblTypeValid.Text = "Bank Receipt Voucher" Then
                        mStr = mBRstr
                    ElseIf LblTypeValid.Text = "Cash Receipt Voucher" Then
                        mStr = mCPstr
                    ElseIf LblTypeValid.Text = "Cash Payment Voucher" Then
                        mStr = mCRstr
                    End If
                    If mStr <> "" Then
                        Call MenuGridLoad(mStr)
                        rowNum = dtMaster.Rows.Count - 1
                    End If
                ElseIf EditMode Then
                    Flag = True
                    Call SetEntryMode()
                    Call EmptyControls(Me)
                    Call setFeild(False)
                    GpTaxDed.Enabled = False
                    btnSave.Enabled = False
                    btnCancel.Enabled = False
                    vspGrid.Enabled = False
                    btnCode.Enabled = False
                    Call btnRefresh_Click(sender, e)
                    EditMode = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try



        'EmptyControls(Me)
        'btnRefresh_Click(sender, e)
        'Call SetButton()

    End Sub

    Private Sub btnTop_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTop.Click
        lblTotAmt.Text = " "
        rowNum = 0
        btnTop.Enabled = False
        btnPrevious.Enabled = False
        btnNext.Enabled = True
        btnBottom.Enabled = True
        Call LoadMaster()
        Call LoadDetail()
        objRecPay.BrCode = Trim(txtBrCode.Text)
        'objRecPay.Type = mType
        objRecPay.VNo = lblVNo.Text
        If LblTypeValid.Text = "Bank Payment Voucher" Then
            objRecPay.Type = "BP"
        ElseIf LblTypeValid.Text = "Bank Receipt Voucher" Then
            objRecPay.Type = "BR"
        ElseIf LblTypeValid.Text = "Cash Receipt Voucher" Then
            objRecPay.Type = "CR"
        ElseIf LblTypeValid.Text = "Cash Payment Voucher" Then
            objRecPay.Type = "CP"
        End If
        dtDetail = objRecPay.LoadAllDetail()
        Call ClearGrid()
        Call LoadDetail()
        lblToolTip.Text = "Move To First Record"
        Call SetButtonPrinciple()
        Call SetButton()
    End Sub

    Private Sub btnBottom_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBottom.Click
        lblTotAmt.Text = " "
        rowNum = dtMaster.Rows.Count - 1
        If rowNum > 0 Then
            lblToolTip.Text = "Move To Last Record"
            lblToolTip.Text = "Move To Last Record"
            btnTop.Enabled = True
            btnPrevious.Enabled = True
            btnNext.Enabled = False
            btnBottom.Enabled = False
            Call LoadMaster()
            Call LoadDetail()
            objRecPay.BrCode = Trim(txtBrCode.Text)
            objRecPay.VNo = lblVNo.Text
            If LblTypeValid.Text = "Bank Payment Voucher" Then
                objRecPay.Type = "BP"
            ElseIf LblTypeValid.Text = "Bank Receipt Voucher" Then
                objRecPay.Type = "BR"
            ElseIf LblTypeValid.Text = "Cash Receipt Voucher" Then
                objRecPay.Type = "CR"
            ElseIf LblTypeValid.Text = "Cash Payment Voucher" Then
                objRecPay.Type = "CP"
            End If
            dtDetail = objRecPay.LoadAllDetail()
            Call ClearGrid()
            Call LoadDetail()
            Call SetButtonPrinciple()
            Call SetButton()
        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNext.Click
        lblTotAmt.Text = " "
        If rowNum < dtMaster.Rows.Count - 1 Then
            rowNum = rowNum + 1
            btnNext.Enabled = True
            btnBottom.Enabled = True
            btnPrevious.Enabled = True
            btnTop.Enabled = True
        Else
            rowNum = dtMaster.Rows.Count - 1
            btnNext.Enabled = False
            btnBottom.Enabled = False
            btnTop.Enabled = True
            btnPrevious.Enabled = True
        End If
        Call LoadMaster()
        Call LoadDetail()
        objRecPay.BrCode = Trim(txtBrCode.Text)
        objRecPay.VNo = lblVNo.Text
        If LblTypeValid.Text = "Bank Payment Voucher" Then
            objRecPay.Type = "BP"
        ElseIf LblTypeValid.Text = "Bank Receipt Voucher" Then
            objRecPay.Type = "BR"
        ElseIf LblTypeValid.Text = "Cash Receipt Voucher" Then
            objRecPay.Type = "CR"
        ElseIf LblTypeValid.Text = "Cash Payment Voucher" Then
            objRecPay.Type = "CP"
        End If
        dtDetail = objRecPay.LoadAllDetail()
        Call ClearGrid()
        Call LoadDetail()
        lblToolTip.Text = "Move To Next Record"
        Call SetButtonPrinciple()
        Call SetButton()
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        EmptyControls(Me)
        lblTotAmt.Text = " "
        If rowNum > 0 Then
            rowNum = rowNum - 1
            btnNext.Enabled = True
            btnBottom.Enabled = True
            btnPrevious.Enabled = True
            btnTop.Enabled = True
        Else
            rowNum = 0
            btnTop.Enabled = False
            btnPrevious.Enabled = False
            btnNext.Enabled = True
            btnBottom.Enabled = True
        End If
        Call LoadMaster()
        Call LoadDetail()
        objRecPay.BrCode = Trim(txtBrCode.Text)
        objRecPay.VNo = lblVNo.Text
        If LblTypeValid.Text = "Bank Payment Voucher" Then
            objRecPay.Type = "BP"
        ElseIf LblTypeValid.Text = "Bank Receipt Voucher" Then
            objRecPay.Type = "BR"
        ElseIf LblTypeValid.Text = "Cash Receipt Voucher" Then
            objRecPay.Type = "CR"
        ElseIf LblTypeValid.Text = "Cash Payment Voucher" Then
            objRecPay.Type = "CP"
        End If
        dtDetail = objRecPay.LoadAllDetail()
        Call ClearGrid()
        Call LoadDetail()
        lblToolTip.Text = "Move To Previous Record"
        Call SetButtonPrinciple()
        Call SetButton()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        lblToolTip.Text = "Refresh Records"
        dtMaster = objRecPay.LoadAllMaster()
        If rowNum >= 0 Then
            Call LoadMaster()
            Call LoadDetail()
            objRecPay.BrCode = Trim(txtBrCode.Text)
            objRecPay.Type = mType
            objRecPay.VNo = lblVNo.Text
            dtDetail = objRecPay.LoadAllDetail()
            Call LoadDetail()
            btnExit.Focus()
            If LblTypeValid.Text = "Bank Payment Voucher" Then
                mStr = mBPstr
            ElseIf LblTypeValid.Text = "Bank Receipt Voucher" Then
                mStr = mBRstr
            ElseIf LblTypeValid.Text = "Cash Receipt Voucher" Then
                mStr = mCPstr
            ElseIf LblTypeValid.Text = "Cash Payment Voucher" Then
                mStr = mCRstr
            End If
            If mStr <> "" Then
                Call MenuGridLoad(mStr)
                rowNum = dtMaster.Rows.Count - 1
            End If
        Else
            MsgBox("No Record Found", MsgBoxStyle.Information)
            Call ClearAll()
        End If

    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If LblTypeValid.Text = "Bank Payment Voucher" Then
            Constants.ProjConst.mfrmBP = False
        ElseIf LblTypeValid.Text = "Bank Receipt Voucher" Then
            Constants.ProjConst.mfrmBR = False
        ElseIf LblTypeValid.Text = "Cash Payment Voucher" Then
            Constants.ProjConst.mfrmCP = False
        ElseIf LblTypeValid.Text = "Cash Receipt Voucher" Then
            Constants.ProjConst.mfrmCR = False
        End If
        lblToolTip.Text = "Close Form"
        Constants.ProjConst.Branch = ""
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Constants.ProjConst.mcboBranch = Trim(txtBrCode.Text + " : " + lblBrName.Text)
        Dim frmList As New frmRPT_List
        If LblTypeValid.Text = "Bank Payment Voucher" Then
            objRecPay.Type = "BP"
            frmRPT_PTrans.mReport = 6
        ElseIf LblTypeValid.Text = "Bank Receipt Voucher" Then
            objRecPay.Type = "BR"
            frmRPT_PTrans.mReport = 5
        ElseIf LblTypeValid.Text = "Cash Receipt Voucher" Then
            objRecPay.Type = "CR"
            frmRPT_PTrans.mReport = 7
        ElseIf LblTypeValid.Text = "Cash Payment Voucher" Then
            objRecPay.Type = "CP"
            frmRPT_PTrans.mReport = 8
        End If
        frmRPT_PTrans.cboBranch.Text = txtBrCode.Text
        frmRPT_PTrans.txtStartVNo.Text = lblVNo.Text
        frmRPT_PTrans.txtEndVNo.Text = lblVNo.Text
        lblToolTip.Text = "Print Record(s)"
        frmRPT_PTrans.ShowDialog()
        'Call SetButton()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        lblToolTip.Text = "Edit Current Record"
        EditMode = True
        AddMode = False
        Flag = False
        Call SetEntryMode()
        Me.GpData.Enabled = True
        dtpVDate.Focus()
        btnEdit.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
        vspGrid.BlockMode = False
        vspGrid.Enabled = True
        btnCode.Enabled = True
        setFeild(True)
        txtBrCode.Enabled = False
        'Call SetButton()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        lblToolTip.Text = "Cancel Last Action"
        Opt = MsgBox("Do you wish to Abort ?", MsgBoxStyle.YesNo)
        If Opt = MsgBoxResult.No Then
            txtBrCode.Focus()
            Exit Sub
        End If
        If AddMode Then
            dtMaster = objRecPay.LoadMasterVoucher()
            rowNum = dtMaster.Rows.Count - 1
            If rowNum >= 0 Then
                Flag = True
                Call SetEntryMode()
                btnStatus(False)
                Call SetFormSecurity(Me)
                Call SetButtonsSurity(Me)
                Call SetButtonPrinciple()
                Call SetButton()
                Call LoadMaster()
                objRecPay.BrCode = Trim(txtBrCode.Text)
                objRecPay.Type = mType
                objRecPay.VNo = lblVNo.Text
                dtDetail = objRecPay.LoadAllDetail()
                Call LoadDetail()
            Else
                txtBrCode.Text = ""
                lblBrName.Text = ""
                lblVNo.Text = ""
                mskCode.Text = aEmptyCode
                lblRfCode.Text = ""
                txtPurpose.Text = ""
                Call ClearAll()
                txtBrCode.Focus()
                Flag = True
                Call SetEntryMode()
                btnAdd.Enabled = True
                btnView.Enabled = True
                btnStatus(False)
                Call SetFormSecurity(Me)
                Call SetButtonsSurity(Me)
                Call SetButtonPrinciple()
                Call SetButton()
            End If
        Else
            Flag = True
            Call SetEntryMode()
            Call LoadMaster()
            dtMasterMenu = objRecPay.LoadAllMaster()
            Call LoadDetail()
            Call SetButton()
        End If
        If LblTypeValid.Text = "Bank Payment Voucher" Then
            mStr = mBPstr
        ElseIf LblTypeValid.Text = "Bank Receipt Voucher" Then
            mStr = mBRstr
        ElseIf LblTypeValid.Text = "Cash Receipt Voucher" Then
            mStr = mCPstr
        ElseIf LblTypeValid.Text = "Cash Payment Voucher" Then
            mStr = mCRstr
        End If
        Call MenuGridLoad(mStr)
        rowNum = dtMaster.Rows.Count - 1
        'Flag = True
        setFeild(False)
        'Call SetEntryMode()
        vspGrid.BlockMode = True
        vspGrid.Enabled = False
        btnCode.Enabled = False
        GpTaxDed.Enabled = False
        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnEdit.Enabled = False
        btnCode.Enabled = False
        txtBrCode.Enabled = False
        btnStatus(False)
        Call SetFormSecurity(Me)
        Call SetButtonsSurity(Me)
        Call SetButtonPrinciple()
        Call SetButton()
        EmptyControls(Me)
        AddMode = False
        EditMode = False
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        lblToolTip.Text = "Delete Current Record"
        Opt = MsgBox("Are You Sure To Delete Current Record", MsgBoxStyle.YesNo)
        If Opt = MsgBoxResult.Yes Then
            objRecPay.DelRecPay()
            dtMaster = objRecPay.LoadAllMaster()
            dtMasterMenu = objRecPay.LoadAllMaster()
            rowNum = dtMaster.Rows.Count - 1
            If rowNum >= 0 Then
                Call LoadMaster()
                Call LoadDetail()
                objRecPay.BrCode = Trim(txtBrCode.Text)
                objRecPay.Type = mType
                objRecPay.VNo = lblVNo.Text
                dtDetail = objRecPay.LoadAllDetail()
                Call LoadDetail()
                btnExit.Focus()
                If LblTypeValid.Text = "Bank Payment Voucher" Then
                    mStr = mBPstr
                ElseIf LblTypeValid.Text = "Bank Receipt Voucher" Then
                    mStr = mBRstr
                ElseIf LblTypeValid.Text = "Cash Receipt Voucher" Then
                    mStr = mCPstr
                ElseIf LblTypeValid.Text = "Cash Payment Voucher" Then
                    mStr = mCRstr
                End If
                Call MenuGridLoad(mStr)
                rowNum = dtMaster.Rows.Count - 1
            Else
                MsgBox("No Record Found", MsgBoxStyle.Information)
                Call ClearAll()
            End If
        End If
    End Sub

    Private Sub btnFind_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFind.Click
        If txtBrCode.Text <> "" Then
            mOrder = 0
            If rowNum >= 0 Then
                If LblTypeValid.Text = "Bank Payment Voucher" Then
                    mType = "BP"
                    frmRPT_PTrans.mReport = 6
                ElseIf LblTypeValid.Text = "Bank Receipt Voucher" Then
                    mType = "BR"
                    frmRPT_PTrans.mReport = 5
                ElseIf LblTypeValid.Text = "Cash Receipt Voucher" Then
                    mType = "CR"
                    frmRPT_PTrans.mReport = 7
                ElseIf LblTypeValid.Text = "Cash Payment Voucher" Then
                    mType = "CP"
                    frmRPT_PTrans.mReport = 8
                End If
                frmRPT_PTrans.chkValidation.Checked = False
                frmRPT_PTrans.mBranch = txtBrCode.Text
                frmRPT_PTrans.BranchName = Trim(lblBrName.Text)
                frmRPT_PTrans.mVno = lblVNo.Text
                lblToolTip.Text = "Preview Record(s)"
                frmRPT_PTrans.rptPreview(sender, e)
            End If
        End If
    End Sub

    Private Sub mskCode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskCode.GotFocus
        mskCode.SelectionStart = 0
    End Sub

    Private Sub mskCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mskCode.KeyDown
        ObjFind = New Grid_Help
        If e.KeyCode = Keys.F1 Then
            ObjFind.PMessage = "Codes"
            If Mid(mType, 1, 1) = "B" Then
                strFind = "SELECT Code,Description FROM Codes  " & _
                       "WHERE Left(CODE,2)= '" & pBank & "' Order By Code"
            ElseIf Mid(mType, 1, 1) = "C" Then
                strFind = "SELECT Code,Description FROM Codes  " & _
                       "WHERE Left(CODE,2)= '" & pCash & "' Order By Code"
            End If
            ObjFind.sqlqueryFun = strFind
            ObjFind.ShowDialog()

            If ObjFind.PbOk = True Then
                If (Mid(ObjFind.strPKfun, 1, 2) = "00" Or Mid(ObjFind.strPKfun, 3, 2) = "00" Or Mid(ObjFind.strPKfun, 5, 4) = "0000") Then
                    MsgBox("Invalid Code", vbInformation, Constants.ProjConst.SysCompany)
                    mskCode.Mask = aMaskCode
                    mskCode.Text = ""
                    mskCode.SelectionStart = 0
                    lblRfCode.Text = ""
                    mskCode.Focus()
                    Exit Sub
                End If
                mskCode.Text = aStr2Code(ObjFind.strPKfun) & ""
                lblRfCode.Text = ObjFind.sqlqueryFun & ""
            End If
        End If
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub mskCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mskCode.Validating

        If mskCode.Text <> "  -  -" Then

            If Not ChkCode(aCode2Str(mskCode.Text)) Then
                mskCode.Text = aEmptyCode
                mskCode.SelectedText = 0
                lblRfCode.Text = ""
                e.Cancel = True
                Exit Sub
            Else
              If (Mid((mskCode.Text), aP1P, aP1L) = "00" Or Mid(mskCode.Text, aP2P, aP2L) = "00" Or Mid(mskCode.Text, aP3P, aP3L) = "0000") Then
                    MsgBox("Invalid Code", vbInformation, Constants.ProjConst.SysCompany)
                    mskCode.Mask = aMaskCode
                    mskCode.Text = ""
                    mskCode.SelectionStart = 0
                    lblRfCode.Text = ""
                    e.Cancel = True
                    mskCode.Focus()
                    Exit Sub
                End If
                If Mid(mType, 1, 1) = "B" Then
                    mSQL = "SELECT Code FROM Codes  " & _
                           "WHERE Left(CODE,2)= '" & pBank & "' And Code = '" & aCode2Str(mskCode.Text) & "' Order By Code"
                ElseIf Mid(mType, 1, 1) = "C" Then
                    mSQL = "SELECT Code FROM Codes  " & _
                           "WHERE Left(CODE,2)= '" & pCash & "' And Code = '" & aCode2Str(mskCode.Text) & "' Order By Code"
                End If
                mSQL = GetFldValue(mSQL, "Code")
                If mSQL <> "" Then
                    mSQL = "Select Description From Codes Where Code = '" & aCode2Str(mskCode.Text) & "'"
                    mSQL = GetFldValue(mSQL, "Description")
                    lblRfCode.Text = mSQL
                    Call ShowAcBalance(aCode2Str(mskCode.Text), txtBrCode.Text)
                Else
                    MsgBox("Invalid Code", vbInformation, Constants.ProjConst.SysCompany)
                    mskCode.Text = aMaskCode
                    lblRfCode.Text = ""
                    e.Cancel = True
                    mskCode.Focus()
                    Exit Sub
                End If

            End If
        End If
    End Sub

    Private Sub ShowAcBalance(ByVal mCode As String, ByVal mBrCode As String)
        Dim TBalance As Double

        TBalance = Val(GetFldValue("SELECT SUM(DEBIT-CREDIT) BALANCE FROM GLEDG WHERE BRCODE ='" & mBrCode & "' AND CODE= '" & mCode & "' AND POSTED='Y'", "BALANCE"))
        'TBalance = Val(GetFldValue("SELECT SUM(DEBIT-CREDIT) BALANCE FROM GLEDG WHERE BRCODE ='" & mBrCode & "' AND CODE= '" & mCode & "'", "BALANCE"))
        btnCode.Text = aStr2Code(mCode)
        If TBalance > 0 Then
            LBLBalance.Text = Format(TBalance, NumFmt)
        Else
            LBLBalance.Text = "(" & Format(0 - TBalance, NumFmt) & ")"
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
        If txtBrCode.Text <> "" Then
            mSQL = "SELECT BrName FROM Branch WHERE BrCode = '" & Trim(txtBrCode.Text) & "'"
            mSQL = GetFldValue(mSQL, "BrName")
            lblBrName.Text = mSQL
            If mSQL = "" Then
                MsgBox("No Record Found", vbInformation, Constants.ProjConst.SysCompany)
                txtBrCode.Text = ""
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub btnCode_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCode.Click
        Dim mStDate As Date
        Dim mEnDate As Date
        If Not btnCode.Text = " " Then
            If Not txtBrCode.Text = "" Then
                mSQL = "Select Top 1 VDate From GLedg Where BrCode = '" & Trim(txtBrCode.Text) & "' " & _
                       "And Code = '" & aCode2Str(btnCode.Text) & "'"
                mSQL = GetFldValue(mSQL, "VDate")
                mStDate = CDate(mSQL)
                If mSQL <> "" Then
                    frmACStatus.mRefStDate = Format(mStDate, "dd-MMM-yyyy")
                    mSQL = "Select Top 1 VDate From GLedg Where BrCode = '" & Trim(txtBrCode.Text) & "' " & _
                           "And Code = '" & aCode2Str(btnCode.Text) & "' Order By VDate Desc"
                    mSQL = GetFldValue(mSQL, "VDate")
                    mEnDate = CDate(mSQL)
                    frmACStatus.mRefEndDate = mEnDate
                    frmACStatus.mRefBrCode = Trim(txtBrCode.Text)
                    frmACStatus.mRefAcCode = aCode2Str(btnCode.Text)
                    ' ''frmACStatus.mComDetail = ""
                    ' ''frmACStatus.mRepTitle = ""
                    ' ''frmACStatus.mRepHeader1 = ""
                    frmACStatus.Show()
                End If
            Else
                MsgBox("Please Enter Branch code", MsgBoxStyle.DefaultButton1, Constants.ProjConst.SysCompany)
                txtBrCode.Focus()
            End If
        End If
    End Sub

    Private Sub GetSum(ByVal LBLAmount As Label)
        Dim i As Integer
        Dim Tmp As Object
        Dim TotalAmt As Double
        TotalAmt = 0
        ''
        For i = 1 To vspGrid.MaxRows
            'Tmp = 0
            Erase Tmp
            vspGrid.GetText(5, i, Tmp)
            TotalAmt = TotalAmt + Val(Tmp)
        Next i
        lblTotAmt.Text = Format(TotalAmt, "###,###,###,###.00")
    End Sub

    Private Sub vspGrid_Change(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_ChangeEvent) Handles vspGrid.Change
        Dim mTmpStr As Object
        Dim mTmpCode As String
        Dim mAmount As Double
        Dim mPrvRemarks As String
        If AddMode Or EditMode Then

            Select Case vspGrid.ActiveCol
                Case 1
                    Erase mTmpStr
                    vspGrid.GetText(1, vspGrid.ActiveRow, mTmpStr)
                    If mTmpStr <> "" Then
                        mTmpCode = aCode2Str(mTmpStr)
                        If mTmpCode = aCode2Str(mskCode.Text) Then
                            MsgBox("Bank / Cash Code Cannot Be Repeated", vbInformation, Constants.ProjConst.SysCompany)
                            vspGrid.SetText(1, vspGrid.ActiveRow, aEmptyCode)
                            Call SetCol(vspGrid.ActiveRow, 1)
                            ColBack = True
                            Exit Sub
                        End If
                        If Not ChkCode(mTmpCode) Then
                            vspGrid.SetText(1, vspGrid.ActiveRow, aEmptyCode)
                            Call SetCol(vspGrid.ActiveRow, 1)
                            ColBack = True
                            Exit Sub
                        Else
                            If (Mid(mTmpCode, aP1P, aP1L) = "00" Or Mid(mTmpCode, aP2P, aP2L) = "00" Or Mid(mTmpCode, aP3P + 1, aP3L) = "00" Or Mid(mTmpCode, aP4P + 2, aP4L) = "00000") Then
                                MsgBox("Invalid Code", vbInformation, Constants.ProjConst.SysCompany)
                                vspGrid.SetText(1, vspGrid.ActiveRow, aEmptyCode)
                                Call SetCol(vspGrid.ActiveRow, 1)
                                ColBack = True
                                Exit Sub
                            End If
                            mSQL = "SELECT Description FROM Codes WHERE Code = '" & mTmpCode & "'"
                            mTmpStr = GetFldValue(mSQL, "Description")
                            vspGrid.SetText(2, vspGrid.ActiveRow, mTmpStr)
                            Call SetCol(vspGrid.ActiveRow, 2)
                        End If
                        ''** COPY OF PREVIOUS REMARKS
                        If vspGrid.ActiveRow >= 2 Then
                            vspGrid.GetText(3, vspGrid.ActiveRow - 1, mTmpStr)
                            mPrvRemarks = mTmpStr
                            vspGrid.SetText(3, vspGrid.ActiveRow, mTmpStr)
                        End If
                    End If
                    If vspGrid.ActiveCol = 1 Then
                        vspGrid.GetText(1, vspGrid.ActiveRow, mTmpStr)
                        mTmpCode = aCode2Str(mTmpStr)
                        Call ShowAcBalance(mTmpCode, txtBrCode.Text)
                    End If
                    ''
                Case 4  'Cheque No
                    ''
                    ''
                Case 5  'Amount
                    Erase mTmpStr
                    vspGrid.GetText(1, vspGrid.ActiveRow, mTmpStr)
                    If Trim(mTmpStr) = "" Then
                        MsgBox("You Can't give Value Without giving Code", vbInformation, Constants.ProjConst.SysCompany)
                        vspGrid.SetText(5, vspGrid.ActiveRow, "")
                        Call SetCol(vspGrid.ActiveRow, 5)
                        ColBack = True
                        Exit Sub
                    End If
                    Erase mTmpStr
                    vspGrid.GetText(5, vspGrid.ActiveRow, mTmpStr)
                    mAmount = Val(mTmpStr)
                    Call GetSum(lblTotAmt)
            End Select
        End If
    End Sub

    Private Sub SetCol(ByVal mRow As Integer, ByVal mCol As Integer)

        vspGrid.Row = mRow
        vspGrid.Col = mCol

    End Sub

    Private Sub ClearGrid()
        Call vspGrid.ClearRange(1, 1, vspGrid.MaxCols, vspGrid.MaxRows, True)
        vspGrid.MaxRows = 1
    End Sub

    Private Sub ClearGVhelp()
        GVHelp.DataSource = Nothing
    End Sub

    Private Sub vspGrid_ClickEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_ClickEvent) Handles vspGrid.ClickEvent
        Dim mTmpStr As Object

        If AddMode Or EditMode Then
            If e.col = 0 Then
                SelRow = True
            Else
                SelRow = False
            End If
        End If
        If vspGrid.ActiveCol = 1 Then
            Erase mTmpStr
            vspGrid.GetText(1, vspGrid.ActiveRow, mTmpStr)
            mTmpCode = aCode2Str(mTmpStr)
            Call ShowAcBalance(mTmpCode, txtBrCode.Text)
        End If
    End Sub

    Private Sub vspGrid_DblClick(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_DblClickEvent) Handles vspGrid.DblClick
        If e.col = 1 Then
            frmAccounts.ShowDialog()
        End If
    End Sub

    Private Sub vspGrid_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles vspGrid.KeyDownEvent
        Dim mTmpStr As Object
        ObjFind = New Grid_Help

        If e.keyCode = Keys.Down And vspGrid.ActiveRow = vspGrid.MaxRows Then
            vspGrid.MaxRows = vspGrid.MaxRows + 1
            'Look Up for Account Pfcodes

        ElseIf vspGrid.ActiveCol = 1 And e.keyCode = Keys.F1 Then
            strFind = "SELECT Code,Description FROM Codes WHERE " & _
                   "LEN(RTRIM(CODE)) = '" & aCodeL & "' And " & _
                   "Code <> '" & aCode2Str(mskCode.Text) & "'"
            ObjFind.PMessage = "GLHead"
            ObjFind.sqlqueryFun = strFind
            ObjFind.ShowDialog()

            If ObjFind.PbOk = True Then
                mTmpCode = ObjFind.strPKfun & ""
                If (Mid(mTmpCode, aP1P, aP1L) = "00" Or Mid(mTmpCode, aP2P, aP2L) = "00" Or Mid(mTmpCode, aP3P, aP3L) = "0000") Then
                    MsgBox("Control Code not allowed here", vbInformation, Constants.ProjConst.SysCompany)
                    vspGrid.SetText(1, vspGrid.ActiveRow, aEmptyCode)
                    vspGrid.SetText(2, vspGrid.ActiveRow, aEmptyCode)
                    Call SetCol(vspGrid.ActiveRow, 1)
                    ColBack = True
                    Exit Sub
                End If
                mTmpCode = aStr2Code(ObjFind.strPKfun)
                vspGrid.SetText(1, vspGrid.ActiveRow, mTmpCode)
                vspGrid.SetText(2, vspGrid.ActiveRow, ObjFind.sqlqueryFun)
                If vspGrid.ActiveCol = 1 Then
                    Erase mTmpStr
                    vspGrid.GetText(1, vspGrid.ActiveRow, mTmpStr)
                    mTmpCode = aCode2Str(mTmpStr)
                    Call ShowAcBalance(mTmpCode, txtBrCode.Text)
                End If
            End If

        ElseIf e.keyCode = Keys.Delete Then
            If SelRow Or e.shift = 2 Then
                vspGrid.Row = vspGrid.ActiveRow
                vspGrid.Action = 5
                Call GetSum(lblTotAmt)
                If vspGrid.MaxRows > 1 Then
                    vspGrid.MaxRows = vspGrid.MaxRows - 1
                End If
            End If

        ElseIf vspGrid.ActiveCol = 5 And e.keyCode = Keys.Enter Then
            'SendKeys.Send("{Tab}")
            If vspGrid.ActiveRow = vspGrid.MaxRows Then
                vspGrid.MaxRows = vspGrid.MaxRows + 1
                'vspGrid.Col = 3
                Call SetCol(vspGrid.MaxRows, 1)
            End If
        ElseIf e.keyCode = Keys.Insert Then
            If SelRow Then
                ' Addition in Max Rows
                vspGrid.MaxRows = vspGrid.MaxRows + 1
                vspGrid.Row = vspGrid.ActiveRow
                vspGrid.Action = 7
                Call SetCol(vspGrid.ActiveRow, 1)
            End If
        ElseIf e.keyCode = Keys.Return And vspGrid.ActiveCol = 5 Then
            If vspGrid.ActiveRow = vspGrid.MaxRows Then
                vspGrid.MaxRows = vspGrid.MaxRows + 1
                vspGrid.Col = 1


            End If
        ElseIf e.keyCode = Keys.Delete Then
            vspGrid.Row = vspGrid.ActiveRow
            vspGrid.Action = 5
            Call GetSum(lblTotAmt)
            If vspGrid.MaxRows > 1 Then
                vspGrid.MaxRows = vspGrid.MaxRows - 1
            End If
        ElseIf e.keyCode = Keys.Return Then
            KeyReturn = True
        Else
            KeyReturn = False
        End If
        If e.keyCode = Keys.Up And vspGrid.ActiveCol = 5 Then
            mFocus = True
        End If
        End Sub

    Private Sub vspGrid_LeaveCell(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_LeaveCellEvent) Handles vspGrid.LeaveCell
        Dim mTmp As Object
        Dim mStr As String

        If AddMode Or EditMode Then
            If e.row <> -1 And e.col <> -1 Then
                ''
                If e.col = 1 Then
                    lblToolTip.Text = "Enter Account Code"
                    vspGrid.SetText(3, vspGrid.ActiveRow, txtPurpose.Text)
                ElseIf e.col = 2 Then
                    lblToolTip.Text = ""
                ElseIf e.col = 3 Then
                    lblToolTip.Text = "Enter Remarks"
                ElseIf e.col = 4 Then
                    lblToolTip.Text = "Enter Cheque No"
                ElseIf e.col = 5 Then
                    lblToolTip.Text = "Enter Amount"
                Else
                    lblToolTip.Text = ""
                End If
                If e.col = 1 Then
                    Erase mTmp
                    vspGrid.GetText(1, vspGrid.ActiveRow, mTmp)
                    mStr = mTmp
                    If KeyReturn And (mStr = "" Or mStr = aEmptyCode) And Not ColBack Then
                        SendKeys.Send("{Tab}")
                        ColBack = True
                        e.cancel = True
                        Exit Sub
                    End If
                End If
                ''
                If ColBack Then
                    e.cancel = True
                    ColBack = False
                End If
                ' ''If vspGrid.ActiveCol = 3 Then
                ' ''    Erase mTmp
                ' ''    vspGrid.GetText(3, vspGrid.ActiveRow, mTmp)
                ' ''    mStr = mTmp
                ' ''    mStr = objProper.Proper(mStr)
                ' ''    vspGrid.SetText(3, vspGrid.ActiveRow, mStr)
                ' ''End If
                ''
            End If
        End If
    End Sub

    Private Sub btnView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnView.Click
        frmSRH_Vouchers.ShowDialog()
        If frmSRH_Vouchers.SetFilter = True Then
            If LblTypeValid.Text = "Bank Payment Voucher" Then
                objRecPay.Type = "BP"
            ElseIf LblTypeValid.Text = "Bank Receipt Voucher" Then
                objRecPay.Type = "BR"
            ElseIf LblTypeValid.Text = "Cash Receipt Voucher" Then
                objRecPay.Type = "CR"
            ElseIf LblTypeValid.Text = "Cash Payment Voucher" Then
                objRecPay.Type = "CP"
            End If
            SDate = Constants.ProjConst.SDate
            EDate = Constants.ProjConst.EDate
            objRecPay.StDate = GetDate(SDate, "dd-MMM-yyyy")
            objRecPay.EndDate = GetDate(EDate, "dd-MMM-yyyy")
            objRecPay.BrCode = Constants.ProjConst.Branch
            If Constants.ProjConst.FltAll Then
                objRecPay.Level = "0"
                dtMaster = objRecPay.LoadAllMaster
                dtMasterMenu = objRecPay.LoadAllMaster()
                mStr = "Select ROW_NUMBER() " & _
                        "OVER (ORDER BY BrCode,vno) AS Row,Vno,CONVERT(varchar(13),Vdate,106) As Date,RefRemarks From GLHead " & _
                        "Where BrCode = '" + Constants.ProjConst.Branch + "' And Type = '" + objRecPay.Type + "'" & _
                        " And VDate Between '" + objRecPay.StDate + "' And '" + objRecPay.EndDate + "'" & _
                        "Order By Brcode,VNo"
            ElseIf Constants.ProjConst.Fltpost Then
                objRecPay.Level = "1"
                objRecPay.StDate = CStr(GetDate(SDate, "dd-MMM-yyyy"))
                objRecPay.EndDate = CStr(GetDate(EDate, "dd-MMM-yyyy"))
                dtMaster = objRecPay.LoadSelectRecPay()
                dtMasterMenu = objRecPay.LoadSelectRecPay()
                mStr = "Select ROW_NUMBER() " & _
                         "OVER (ORDER BY BrCode,vno) AS Row,Vno,CONVERT(varchar(13),Vdate,106) As Date,RefRemarks From GLHead " & _
                         "Where Posted= 'Y' and BrCode = '" + Constants.ProjConst.Branch + "' And Type = '" + objRecPay.Type + "'" & _
                         " And VDate Between '" + objRecPay.StDate + "' And '" + objRecPay.EndDate + "'" & _
                         "Order By Brcode,VNo"
            ElseIf Constants.ProjConst.FltUnpost Then
                objRecPay.Level = "2"
                objRecPay.StDate = CStr(GetDate(SDate, "dd-MMM-yyyy"))
                objRecPay.EndDate = CStr(GetDate(EDate, "dd-MMM-yyyy"))
                dtMaster = objRecPay.LoadSelectRecPay()
                dtMasterMenu = objRecPay.LoadSelectRecPay()
                mStr = "Select ROW_NUMBER() " & _
                        "OVER (ORDER BY BrCode,vno) AS Row,Vno,CONVERT(varchar(13),Vdate,106) As Date,RefRemarks From GLHead " & _
                        "Where Posted= 'N' and BrCode = '" + Constants.ProjConst.Branch + "' And Type = '" + objRecPay.Type + "'" & _
                        " And VDate Between '" + objRecPay.StDate + "' And '" + objRecPay.EndDate + "'" & _
                        "Order By Brcode,VNo"
            End If
        End If
        If LblTypeValid.Text = "Bank Payment Voucher" Then
            mBPstr = mStr
        ElseIf LblTypeValid.Text = "Bank Receipt Voucher" Then
            mBRstr = mStr
        ElseIf LblTypeValid.Text = "Cash Receipt Voucher" Then
            mCPstr = mStr
        ElseIf LblTypeValid.Text = "Cash Payment Voucher" Then
            mCRstr = mStr
        End If
        Call MenuGridLoad(mStr)
        rowNum = dtMaster.Rows.Count - 1

        If rowNum >= 0 Then
            Call SetFormSecurity(Me)
            Call SetButtonsSurity(Me)
            Call SetButtonPrinciple()
            Call SetButton()
            btnEdit.Enabled = True
            vspGrid.BlockMode = True

            Call LoadMaster()
            objRecPay.BrCode = Trim(txtBrCode.Text)
            If LblTypeValid.Text = "Bank Payment Voucher" Then
                objRecPay.Type = "BP"
            ElseIf LblTypeValid.Text = "Bank Receipt Voucher" Then
                objRecPay.Type = "BR"
            ElseIf LblTypeValid.Text = "Cash Receipt Voucher" Then
                objRecPay.Type = "CR"
            ElseIf LblTypeValid.Text = "Cash Payment Voucher" Then
                objRecPay.Type = "CP"
            End If
            objRecPay.VNo = lblVNo.Text
            dtDetail = objRecPay.LoadAllDetail()
            Call LoadDetail()
            btnExit.Focus()

        Else

            Call ClearGVhelp()
            Call ClearAll()
            btnStatus(False)
            btnEdit.Enabled = False
            btnAdd.Enabled = True
            btnView.Enabled = True
            rowNum = -1
        End If
        
    End Sub

    Private Sub btnPost_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPost.Click

        frmAccPostAll.cboStVoucher.Items.Clear()
        frmAccPostAll.cboEndVoucher.Items.Clear()
        frmAccPostAll.mVType = mType
        frmAccPostAll.mBrCode = Trim(txtBrCode.Text)
        mVno = lblVNo.Text
        frmAccPostAll.ShowDialog()
        dtMaster = objRecPay.LoadAllMaster()
        dtMasterMenu = objRecPay.LoadAllMaster()
        If LblTypeValid.Text = "Bank Payment Voucher" Then
            mStr = mBPstr
        ElseIf LblTypeValid.Text = "Bank Receipt Voucher" Then
            mStr = mBRstr
        ElseIf LblTypeValid.Text = "Cash Receipt Voucher" Then
            mStr = mCPstr
        ElseIf LblTypeValid.Text = "Cash Payment Voucher" Then
            mStr = mCRstr
        End If
        Call MenuGridLoad(mStr)
        rowNum = dtMaster.Rows.Count - 1
        Call LoadMaster()
        dtDetail = objRecPay.LoadAllDetail()
        Call LoadDetail()
        Call SetButtonPrinciple()
        Call SetButton()
    End Sub

    Private Sub txtPurpose_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPurpose.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtPurpose_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPurpose.LostFocus
        If Trim(txtPurpose.Text) <> "" Then
            txtPurpose.Text = objProper.Proper(txtPurpose.Text)
        End If
    End Sub

    Private Sub setFeild(ByVal status As Boolean)
        txtBrCode.Enabled = status
        dtpVDate.Enabled = status
        mskCode.Enabled = status
        txtPurpose.Enabled = status
    End Sub

    Private Sub btnStatus(ByVal status As Boolean)
        btnAdd.Enabled = status
        btnEdit.Enabled = status
        btnDelete.Enabled = status
        btnPost.Enabled = status
        btnPrint.Enabled = status
    End Sub

    Private Sub gridStatus(ByVal status As Boolean)

        If status = True Then
            vspGrid.BlockMode = False
            vspGrid.Enabled = True
            btnCode.Enabled = True
        Else
            vspGrid.BlockMode = True
            vspGrid.Enabled = False
            btnCode.Enabled = False
        End If

    End Sub

    Private Sub txtPurpose_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPurpose.Leave
        txtPurpose.Text = UCase(txtPurpose.Text)
    End Sub

    Private Sub mskDedCode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskDedCode.GotFocus
        If vspGrid.MaxRows > 1 Then
            btnSave.Focus()
            MsgBox("One Row Allowed in Case of Tax Deduction", vbInformation, Constants.ProjConst.SysCompany)

            'vspGrid_LostFocus(sender, e)
            txtDedRemarks.Enabled = False
            mskTaxRate.Enabled = False
        Else

            txtDedRemarks.Enabled = True
            mskTaxRate.Enabled = True
        End If
        mskDedCode.SelectionStart = 0
        mskDedCode.SelectionLength = Len(mskDedCode.Text)
        lblToolTip.Text = "Press F1 for LookUp"
    End Sub

    Private Sub mskDedCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mskDedCode.KeyDown
        mskDedCode.Mask = aMaskCode
        ObjFind = New Grid_Help
        If e.KeyCode = Keys.F1 Then
            strFind = "SELECT Code,Description FROM Codes WHERE " & _
                   "LEN(RTRIM(CODE)) = '" & aCodeL & "' And " & _
                   "Code <> '" & aCode2Str(mskCode.Text) & "'"
            ObjFind.sqlqueryFun = strFind
            ObjFind.ShowDialog()

            If ObjFind.PbOk = True Then
                If (Mid(ObjFind.strPKfun, 1, 2) = "00" Or Mid(ObjFind.strPKfun, 3, 2) = "00" Or Mid(ObjFind.strPKfun, 5, 4) = "0000") Then
                    MsgBox("Invalid Code", vbInformation, Constants.ProjConst.SysCompany)
                    mskDedCode.Mask = aMaskCode
                    mskDedCode.Text = ""
                    mskDedCode.SelectionStart = 0
                    mskDedCode.Focus()
                    lblRfCode.Text = ""
                    Exit Sub
                End If
                mskDedCode.Text = aStr2Code(ObjFind.strPKfun) & ""
                lblDedCodeDec.Text = ObjFind.sqlqueryFun & ""
            End If
        End If
    End Sub

    Private Sub txtTaxRate_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        mskTaxRate.SelectionStart = 0
        'mskTaxRate.SelectionLength = Len(mskTaxRate.Text)
        lblToolTip.Text = "Enter Rate"
    End Sub

    Private Sub mskTaxRate_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskTaxRate.GotFocus
        lblToolTip.Text = "Enter Rate"
        mskTaxRate.SelectionStart = 0

    End Sub

    Private Sub mskTaxRate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskTaxRate.LostFocus
        Dim dedAmount As Double
        Dim netPayable As Double
        Try
            If mskDedCode.Text <> aEmptyCode Then
                dedAmount = (mskTaxRate.Text / 100) * (lblTotAmt.Text)
                lblDedAmount.Text = Format(dedAmount, "###,###,###,###.00")
                netPayable = (lblTotAmt.Text - dedAmount)
                lblNetPayable.Text = Format(netPayable, "###,###,###,###.00")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmRecPay_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If LblTypeValid.Text = "Bank Payment Voucher" Then
            Constants.ProjConst.mfrmBP = False
        ElseIf LblTypeValid.Text = "Bank Receipt Voucher" Then
            Constants.ProjConst.mfrmBR = False
        ElseIf LblTypeValid.Text = "Cash Payment Voucher" Then
            Constants.ProjConst.mfrmCP = False
        ElseIf LblTypeValid.Text = "Cash Receipt Voucher" Then
            Constants.ProjConst.mfrmCR = False
        End If
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub EditSet()

        mSQL = "DELETE FROM GLedg WHERE BrCode = '" & Trim(txtBrCode.Text) & "' And VNo = '" & _
                lblVNo.Text & "' AND TYPE ='" & mType & "'"
        ExecQuery(mSQL)
    End Sub

    Private Sub SetButton()
        btnAdd.Enabled = mAdd
        btnEdit.Enabled = mEdit
        btnDelete.Enabled = mDelete
        btnPrint.Enabled = mPrint
        btnPost.Enabled = mPost
    End Sub

    Private Sub SetButtonPrinciple()
        mAdd = mbtnAdd
        mEdit = mbtnEdit
        mDelete = mbtnDelete
        mPrint = mbtnPrint
        mPost = mbtnPost
    End Sub

    Public Sub NoRecord(ByVal frm As Form)
        Call SetButtonPrinciple()
        Call SetButton()
        Call btnStatus(False)
        btnView.Enabled = True
        btnExit.Enabled = True
        Call EmptyControls(frm)
    End Sub

    Public Sub BtnStatus(ByVal status As String)
        btnEdit.Enabled = status
        btnDelete.Enabled = status
        btnPost.Enabled = status
        btnPrint.Enabled = status
        btnSave.Enabled = status
        btnExit.Enabled = status
        btnCancel.Enabled = status
        btnFind.Enabled = status
        btnRefresh.Enabled = status
        btnTop.Enabled = status
        btnPrevious.Enabled = status
        btnNext.Enabled = status
        btnBottom.Enabled = status
    End Sub

    Private Sub GVHelp_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GVHelp.DoubleClick
        If AddMode <> True And EditMode <> True Then
            If GVHelp.RowCount <> 0 Then
                Me.sqlquery = Me.GVHelp.Item(0, GVHelp.CurrentRow.Index).Value
                rowNum = sqlquery - 1
                If rowNum >= 0 Then
                    Call LoadMaster()
                    objRecPay.BrCode = Trim(txtBrCode.Text)
                    objRecPay.Type = mType
                    objRecPay.VNo = lblVNo.Text
                    dtDetail = objRecPay.LoadAllDetail()
                    Call LoadDetail()
                End If
                If rowNum = 0 Then
                    btnTop.Enabled = False
                    btnPrevious.Enabled = False
                    btnNext.Enabled = True
                    btnBottom.Enabled = True
                ElseIf rowNum = dtMaster.Rows.Count - 1 Then
                    btnTop.Enabled = True
                    btnPrevious.Enabled = True
                    btnNext.Enabled = False
                    btnBottom.Enabled = False
                ElseIf rowNum <> 0 And rowNum < dtMaster.Rows.Count - 1 Then
                    btnTop.Enabled = True
                    btnPrevious.Enabled = True
                    btnNext.Enabled = True
                    btnBottom.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub GVHelp_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GVHelp.CellClick
        vColumn = e.ColumnIndex
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter And Me.GVHelp.Rows.Count > 0 Then
            If mOrder = 0 Then
                Me.strPKValue = Me.GVHelp.Item(0, GVHelp.CurrentRow.Index).Value
                Me.sqlquery = Me.GVHelp.Item(1, GVHelp.CurrentRow.Index).Value
            ElseIf mOrder = 1 Then
                Me.strPKValue = Me.GVHelp.Item(1, GVHelp.CurrentRow.Index).Value
                Me.sqlquery = Me.GVHelp.Item(0, GVHelp.CurrentRow.Index).Value
            End If
        ElseIf e.KeyCode = Keys.Enter And Me.GVHelp.Rows.Count <= 0 Then
            Me.txtSearch.Text = String.Empty

            Me.strPKValue = 0
        End If
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtSearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearch.KeyPress
        If (Char.IsNumber(e.KeyChar)) <> True And (Char.IsLetter(e.KeyChar)) <> True And (Char.IsWhiteSpace(e.KeyChar) <> True) And (Char.IsSymbol(e.KeyChar)) <> True And (Char.IsControl(e.KeyChar)) <> True And (Char.IsPunctuation(e.KeyChar)) <> True Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = "" Then
            'vColumn = 0
            dtLookup.DefaultView.RowFilter = Nothing
        Else
            With dtLookup
                If .Columns(vColumn).DataType.ToString = "System.Int32" Or .Columns(vColumn).DataType.ToString = "System.Double" Then
                    .DefaultView.RowFilter = .Columns(vColumn).Caption & " = " & Val(txtSearch.Text)
                ElseIf .Columns(vColumn).DataType.ToString = "System.String" Or .Columns(vColumn).DataType.ToString = "System.char" Then
                    .DefaultView.RowFilter = .Columns(vColumn).Caption & " like '" & txtSearch.Text & "%'"
                End If
            End With
        End If
    End Sub

    Private Sub MenuGridLoad(ByVal mQuery As String)
        Dim mcol As Integer
        Dim mcolName As String
        Try
            If mQuery <> "" And mQuery <> Nothing Then
                dtLookup = Lookup(mQuery).Tables(0)
                Me.GVHelp.DataSource = dtLookup.DefaultView

                Dim header_style As New DataGridViewCellStyle
                header_style.BackColor = Color.Yellow
                GVHelp.Columns(2).HeaderCell.Style = header_style
                GVHelp.Columns(0).Visible = 0
                If GVHelp.Columns.Count > 0 Then
                    For mcol = 1 To GVHelp.Columns.Count - 1
                        mcolName = GVHelp.Columns(mcol).Name
                        If GVHelp.Columns(mcol).Name = "RefRemarks" Then
                            GVHelp.Columns(mcol).Width = 160
                        ElseIf GVHelp.Columns(mcol).Name <> "BrCode" And GVHelp.Columns(mcol).Name <> "Type" And GVHelp.Columns(mcol).Name <> "TaxRate" And GVHelp.Columns(mcol).Name <> "Posted" Then
                            GVHelp.Columns(mcol).Width = 80

                        Else
                            GVHelp.Columns(mcol).Width = 40
                        End If
                    Next
                End If
                GVHelp.Columns(0).Visible = 0
                If GVHelp.Rows.Count > 0 Then
                    For mRow = 0 To GVHelp.Rows.Count - 1
                        If mRow Mod 2 = 0 Then
                            GVHelp.Rows(mRow).DefaultCellStyle.BackColor = Color.White
                        Else
                            GVHelp.Rows(mRow).DefaultCellStyle.BackColor = Color.PowderBlue
                        End If
                    Next
                End If
                GVHelp.Columns(0).Visible = 0
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmRecPay_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If LblTypeValid.Text = "Bank Payment Voucher" Then
            mStr = mBPstr
        ElseIf LblTypeValid.Text = "Bank Receipt Voucher" Then
            mStr = mBRstr
        ElseIf LblTypeValid.Text = "Cash Receipt Voucher" Then
            mStr = mCPstr
        ElseIf LblTypeValid.Text = "Cash Payment Voucher" Then
            mStr = mCRstr
        End If
        Call MenuGridLoad(mStr)
    End Sub

End Class
