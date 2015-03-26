
Imports System.Data
Imports System.Data.SqlClient
Imports Basic.DAL
Imports Basic.DAL.Utils
Imports Basic.Constants.ProjConst

Public Class frmJV
    Inherits System.Windows.Forms.Form

    Dim objConnection As Object
    Dim objJV As New cJV
    Dim objProper As New cProper

    Dim PODS As New DataSet
    Dim DtAcc As New DataTable
    Dim DaAcc As SqlDataAdapter
    Dim objRow As Data.DataRow
    Dim ObjFind As Grid_Help
    Dim tableName As String = "GLHead"
    Dim mOpen As String
    Dim mSeqNo As Integer
    Dim mTotRecs As String
    Dim strFind As String
    Dim mMenuStr As String
    Dim mTmpCode As String
    Dim Flag As Boolean
    Dim AddMode As Boolean
    Dim EditMode As Boolean
    Dim dtMasterMenu As New DataTable
    Dim dtMaster As New DataTable
    Dim dtDetail As New DataTable
    Dim dtLookup As New DataTable
    Dim rowNum As Integer
    Dim rowNum1 As Integer
    Dim KeyReturn As Boolean
    Dim ColBack As Boolean
    Dim SelRow As Boolean
    Dim mPosted As String
    Dim mindexMenu As Integer
    Dim mAdd As Boolean
    Dim mEdit As Boolean
    Dim mDelete As Boolean
    Dim mPost As Boolean
    Dim mPrint As Boolean
    Dim mQuery As String
    Dim mstr1 As String
    Dim mstr2 As String
    Dim mstr3 As String
    Private strPKValue As String
    Private sqlquery As String
    Private HelpDs As DataSet
    Dim vColumn As Integer = 1
    Private bOK As Boolean = False
    Private Message As String
    Private strSql As String

    Private Sub frmJV_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'vspGridMenu.Col = 4
        'vspGridMenu.ColHidden = True
        'vspGridMenu.MaxCols = 3

        Me.MdiParent = frmMdi
        Me.Top = 0
        Me.Left = 0
        Me.WindowState = FormWindowState.Maximized

        LblTypeValid.Text = "Journal Voucher"
        mQuery = "select G.Vno,CONVERT(varchar(13),G.Vdate,106) As Date,G.Refremarks,G.Rfcode,C.Description " & _
                "from Glhead G inner join Codes c on G.Rfcode = c.Code"
        Me.WindowState = FormWindowState.Maximized
        mType = "JV"
        GpData.Enabled = False
        Flag = True
        Call SetAccParam()
        Call SetEntryMode()
        vspGrid.BlockMode = True
        ' ''vspGrid.Enabled = False
        ' ''btnCode.Enabled = False
        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnEdit.Enabled = False
        Call ClearAll()
        btnStatus(False)
        Call SetFormSecurity(Me)
        Call SetButtonsSurity(Me)
        Call SetButtonPrinciple()
        btnAdd.Enabled = True
        btnView.Enabled = True
        btnStatus(False)
        Call ClearAll()
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
            txtPurpose.Text = dtMaster.Rows(rowNum).Item("RefRemarks")
            mPosted = GetFldValue("Select Posted From GLHead Where " & _
                        "Type = '" & mType & "' And Vno = '" & lblVNo.Text & "'" & _
                        "And BrCode = '" & Trim(txtBrCode.Text) & "'", "Posted")
            Call SetButtonsSeuctiry1(Me, mPosted)
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
        Dim mtotDr As Double
        Dim mtotCr As Double
        Dim TotSum As Double

        mtotDr = 0
        mtotCr = 0
        TotSum = 0
        Try
            rowNum1 = 0
            If dtDetail.Rows.Count > 0 Then
                vspGrid.MaxRows = 1
                vspGrid.SetText(1, 1, "")
                vspGrid.SetText(2, 1, "")
                vspGrid.SetText(3, 1, "")
                vspGrid.SetText(4, 1, "")
                vspGrid.SetText(5, 1, "")

                LBLTotDr.Text = 0
                LBLTotCr.Text = 0

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
                    If Not IsDBNull(dtDetail.Rows(rowNum1).Item("Debit")) Then
                        mStr = dtDetail.Rows(rowNum1).Item("Debit").ToString
                        vspGrid.SetText(4, mi, Format(Val(mStr), "##,###,###,###.00"))
                        mtotDr = mtotDr + dtDetail.Rows(rowNum1).Item("Debit")
                    End If
                    If Not IsDBNull(dtDetail.Rows(rowNum1).Item("Credit")) Then
                        mStr = dtDetail.Rows(rowNum1).Item("Credit").ToString
                        vspGrid.SetText(5, mi, Format(Val(mStr), "##,###,###,###.00"))
                        mtotCr = mtotCr + dtDetail.Rows(rowNum1).Item("Credit")
                    End If
                    If mi < dtDetail.Rows.Count Then
                        vspGrid.MaxRows = vspGrid.MaxRows + 1
                        rowNum1 = rowNum1 + 1
                    End If
                Next
                LBLTotDr.Text = Format(mtotDr, "##,###,###,###.00")
                LBLTotCr.Text = Format(mtotCr, "##,###,###,###.00")
            Else
                vspGrid.MaxRows = 1
                vspGrid.SetText(1, 1, "")
                vspGrid.SetText(2, 1, "")
                vspGrid.SetText(3, 1, "")
                vspGrid.SetText(4, 1, "")
                vspGrid.SetText(5, 1, "")
            End If
            If 0 = dtDetail.Rows.Count Then
                ClearAll()
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
        dtpVDate.Value = SySDate
        lblVNo.Text = ""
        txtPurpose.Text = ""
        LBLPosted.Text = ""
        Call ClearGrid()
    End Sub

    Sub ClearGrid()
        Call vspGrid.ClearRange(1, 1, vspGrid.MaxCols, vspGrid.MaxRows, True)
        vspGrid.MaxRows = 1
    End Sub

    Sub ClearGVhelpGrid()
        GVHelp.DataSource = Nothing
    End Sub

    Private Function CheckValidation() As Boolean
        If txtBrCode.Text = "" Then
            MsgBox("Please Enter Branch Code.", MsgBoxStyle.Information, SysCompany)
            txtBrCode.Focus()
            Return False
        End If
        If LBLTotDr.Text <> LBLTotCr.Text Then
            MsgBox("Total Debit & Credit must be same", MsgBoxStyle.Information, SysCompany)
            Return False
        End If
        If (LBLTotDr.Text = 0 Or LBLTotDr.Text = mEmpty Or LBLTotCr.Text = 0 Or LBLTotCr.Text = mEmpty) Then
            MsgBox("Voucher With No Detail Lines Can't be Saved", MsgBoxStyle.Information, SysCompany)
            Return False
        End If
        Return True
    End Function

    Private Sub SetDataMaster()
        mType = "JV"
        objJV.BrCode = Trim(txtBrCode.Text)
        objJV.Type = mType
        If AddMode = True Then
            objJV.VNo = GetJVno(txtBrCode.Text, mType, dtpVDate.Value)
        ElseIf EditMode = True Then
            objJV.VNo = lblVNo.Text
        End If
        lblVNo.Text = objJV.VNo
        objJV.VDate = Format(dtpVDate.Value, "dd-MMM-yyyy")
        objJV.RefRemarks = Trim(txtPurpose.Text)

        If AddMode Then
            objJV.AddOn = Format(dtpVDate.Value, "dd-MMM-yyyy")
            objJV.AddBy = SysUserID
        ElseIf EditMode Then
            objJV.EditOn = Format(dtpVDate.Value, "dd-MMM-yyyy")
            objJV.EditBy = SysUserID
        End If
    End Sub

    Private Sub SetData(ByVal rowIndex As Integer)
        Dim mTemp As Object
        Dim mAmount As Double
        mType = "JV"
        For rowIndex = 1 To vspGrid.MaxRows
            Erase mTemp
            vspGrid.GetText(1, rowIndex, mTemp)
            If mTemp <> "" Then
                objJV.BrCode = Trim(txtBrCode.Text)
                objJV.Type = mType
                objJV.VNo = lblVNo.Text
                objJV.SeqNo = Format(rowIndex, "00000")
                objJV.VDate = Format(dtpVDate.Value, "dd-MMM-yyyy")
                objJV.Code = aCode2Str(mTemp)
                Erase mTemp
                vspGrid.GetText(3, rowIndex, mTemp)
                objJV.Remarks = mTemp
                Erase mTemp
                vspGrid.GetText(4, rowIndex, mTemp)
                mAmount = Val(mTemp)
                If mAmount > 0 Then
                    objJV.Debit = Format(mAmount, "##,###,###,###.##")
                Else
                    objJV.Debit = "0.00"
                End If
                Erase mTemp
                vspGrid.GetText(5, rowIndex, mTemp)
                mAmount = Val(mTemp)
                If mAmount > 0 Then
                    objJV.Credit = Format(mAmount, "##,###,###,###.##")
                Else
                    objJV.Credit = "0.00"
                End If
                objJV.SaveDetail()
            End If
        Next
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

        btnCode.Enabled = True
        btnSave.Enabled = True
        btnCancel.Enabled = True
        vspGrid.BlockMode = False
        vspGrid.Enabled = True
        btnCode.Enabled = False
        Call ClearAll()
        GpData.Enabled = True
        lblCompany.Text = "Recorded On " & GetDate(SySDate, "dd-MM-yyyy")
        lblToolTip.Text = "Add New Record"
        lblBy.Text = "Recorded By : " & SysUserID
        txtBrCode.Enabled = True
        txtBrCode.Focus()
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim mi As Integer
        Dim mTmpNo As String
        lblToolTip.Text = "Save Current Record"
        mTmpNo = lblVNo.Text

        If CheckValidation() Then
            objJV.getConnection()
            objJV.BeginTransaction()
            If AddMode Then
                Try
                    SetDataMaster()         'Set Master Object Variables
                    objJV.SaveMaster()  'Save Master Object Variables
                    SetData(mi)         ' Save(Detail)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    objJV.RollBack()
                    Exit Sub
                End Try
            ElseIf EditMode Then
                Try
                    SetDataMaster()         'Set Master Object Variables
                    EditSet()
                    objJV.EditMaster()
                    SetData(mi)             ' Save(Detail)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    objJV.RollBack()
                    Exit Sub
                End Try
            End If
            objJV.CommitTransction()
            If Trim(lblVNo.Text) <> Trim(mTmpNo) Then
                MsgBox("Your Transaction Is Saved With Voucher " & mType & " " & lblVNo.Text, vbInformation, SysCompany)
            End If
            If AddMode Then
                Call btnAdd_Click(Nothing, Nothing)
                If mMenuStr <> "" Then
                    Call MenuGridLoad(mMenuStr)
                    rowNum = dtMaster.Rows.Count - 1
                End If
            ElseIf EditMode Then
                Flag = True
                Call SetEntryMode()
                GpData.Enabled = False
                btnSave.Enabled = False
                btnCancel.Enabled = False
                vspGrid.Enabled = False
                btnCode.Enabled = False
                Call btnRefresh_Click(sender, e)
                EditMode = False
            End If

        End If
    End Sub

    Private Sub btnTop_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTop.Click
        rowNum = 0
        btnTop.Enabled = False
        btnPrevious.Enabled = False
        btnNext.Enabled = True
        btnBottom.Enabled = True
        Call LoadMaster()
        objJV.BrCode = Trim(txtBrCode.Text)
        objJV.Type = mType
        objJV.VNo = lblVNo.Text
        dtDetail = objJV.LoadAllDetail()
        Call ClearGrid()
        Call LoadDetail()
        lblToolTip.Text = "Move To First Record"
        Call SetButtonPrinciple()
        Call SetButton()
    End Sub

    Private Sub btnBottom_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBottom.Click
        rowNum = dtMaster.Rows.Count - 1
        lblToolTip.Text = "Move To Last Record"
        lblToolTip.Text = "Move To Last Record"
        btnTop.Enabled = True
        btnPrevious.Enabled = True
        btnNext.Enabled = False
        btnBottom.Enabled = False
        Call LoadMaster()
        objJV.BrCode = Trim(txtBrCode.Text)
        objJV.Type = mType
        objJV.VNo = lblVNo.Text
        dtDetail = objJV.LoadAllDetail()
        Call ClearGrid()
        Call LoadDetail()
        Call SetButtonPrinciple()
        Call SetButton()
    End Sub

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNext.Click
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
        objJV.BrCode = Trim(txtBrCode.Text)
        objJV.Type = mType
        objJV.VNo = lblVNo.Text
        dtDetail = objJV.LoadAllDetail()
        Call ClearGrid()
        Call LoadDetail()
        lblToolTip.Text = "Move To Next Record"
        Call SetButtonPrinciple()
        Call SetButton()
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
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
        objJV.BrCode = Trim(txtBrCode.Text)
        objJV.Type = mType
        objJV.VNo = lblVNo.Text
        dtDetail = objJV.LoadAllDetail()
        Call ClearGrid()
        Call LoadDetail()
        lblToolTip.Text = "Move To Previous Record"
        Call SetButtonPrinciple()
        Call SetButton()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        lblToolTip.Text = "Refresh Records"
        dtMaster = objJV.LoadAllMaster()
        Call MenuGridLoad(mMenuStr)
        rowNum = dtMaster.Rows.Count - 1
        If rowNum >= 0 Then
            Call LoadMaster()
            objJV.BrCode = Trim(txtBrCode.Text)
            objJV.Type = mType
            objJV.VNo = lblVNo.Text
            dtDetail = objJV.LoadAllDetail()
            Call LoadDetail()
            btnExit.Focus()
            Call MenuGridLoad(mMenuStr)
            rowNum = dtMaster.Rows.Count - 1
        Else
            MsgBox("No Record Found", MsgBoxStyle.Information)
            Call ClearAll()
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        lblToolTip.Text = "Close Form"
        Branch = ""
        Me.Close()
        mfrmJV = False
    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim frmList As New frmRPT_List
        mcboBranch = Trim(txtBrCode.Text + " : " + lblBrName.Text)
        lblToolTip.Text = "Print Record(s)"
        frmRPT_PTrans.mReport = 20
        frmRPT_PTrans.cboBranch.Text = txtBrCode.Text
        frmRPT_PTrans.txtStartVNo.Text = lblVNo.Text
        frmRPT_PTrans.txtEndVNo.Text = lblVNo.Text
        lblToolTip.Text = "Print Record(s)"
        frmRPT_PTrans.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        lblToolTip.Text = "Edit Current Record"
        EditMode = True
        AddMode = False
        Flag = False
        vspGrid.BlockMode = False
        vspGrid.Enabled = True
        btnCode.Enabled = True
        Call SetEntryMode()
        GpData.Enabled = True
        txtBrCode.Enabled = False
        dtpVDate.Focus()
        btnEdit.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        lblToolTip.Text = "Cancel Last Action"
        Opt = MsgBox("Do you wish to Abort ?", MsgBoxStyle.YesNo)

        If Opt = MsgBoxResult.No Then
            txtBrCode.Focus()
            Exit Sub
        End If

        If AddMode Then
            dtMaster = objJV.LoadMasterVoucher()
            dtMasterMenu = objJV.LoadAllMaster()
            SetCol(1, 1, 2)
            Flag = True
            Call SetEntryMode()
            btnStatus(False)
            Call SetFormSecurity(Me)
            Call SetButtonsSurity(Me)
            Call SetButtonPrinciple()
            Call SetButton()
            rowNum = dtMaster.Rows.Count - 1
            Call LoadMaster()
            objJV.BrCode = Trim(txtBrCode.Text)
            objJV.Type = mType
            objJV.VNo = lblVNo.Text
            dtDetail = objJV.LoadAllDetail()
            Call LoadDetail()
        Else
            Flag = True
            Call SetEntryMode()
            btnStatus(False)
            Call SetFormSecurity(Me)
            Call SetButtonsSurity(Me)
            Call SetButtonPrinciple()
            Call SetButton()
            Call LoadMaster()
            dtMasterMenu = objJV.LoadAllMaster()
            SetCol(1, 1, 2)
            Call LoadDetail()
        End If

        GpData.Enabled = False
        btnSave.Enabled = False
        btnCancel.Enabled = False
        'EmptyControls(Me)
        AddMode = False
        EditMode = False
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        lblToolTip.Text = "Delete Current Record"
        Opt = MsgBox("Are You Sure To Delete Current Record", MsgBoxStyle.YesNo)

        If Opt = MsgBoxResult.Yes Then
            objJV.DelRecPay()
            dtMaster = objJV.LoadAllMaster()
            Call MenuGridLoad(mMenuStr)
            rowNum = dtMaster.Rows.Count - 1
            If rowNum >= 0 Then
                Call LoadMaster()
                SetCol(1, 1, 2)
                'Call LoadMasterMenu()
                'vspGridMenu.Col = 4
                'vspGridMenu.ColHidden = True
                objJV.BrCode = Trim(txtBrCode.Text)
                objJV.Type = mType
                objJV.VNo = lblVNo.Text
                dtDetail = objJV.LoadAllDetail()
                Call LoadDetail()
                btnExit.Focus()
            Else
                MsgBox("No Record Found", MsgBoxStyle.Information)
                Call ClearAll()
            End If
        End If
    End Sub

    Private Sub btnFind_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFind.Click
        If txtBrCode.Text <> "" Then
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
                ElseIf LblTypeValid.Text = "Journal Voucher" Then
                    mType = "JV"
                    frmRPT_PTrans.mReport = 20
                End If
                frmRPT_PTrans.chkValidation.Checked = False
                frmRPT_PTrans.mBranch = txtBrCode.Text
                frmRPT_PTrans.BranchName = Trim(lblBrName.Text)
                frmRPT_PTrans.mVno = lblVNo.Text
                frmRPT_PTrans.mVno = lblVNo.Text
                lblToolTip.Text = "Preview Record(s)"
                frmRPT_PTrans.rptPreview(sender, e)
            End If
        End If
    End Sub

    Private Sub vspGrid_Change(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_ChangeEvent) Handles vspGrid.Change
        If AddMode Or EditMode Then
            Dim mTmpStr As Object
            Dim mTmpCode As String
            Dim mDebit As Double
            Dim mCredit As Double
            Dim mPrvRemarks As String

            Select Case vspGrid.ActiveCol
                Case 1
                    Erase mTmpStr
                    vspGrid.GetText(1, vspGrid.ActiveRow, mTmpStr)
                    If mTmpStr <> "" Then
                        mTmpCode = aCode2Str(mTmpStr)
                        If Not ChkCode(mTmpCode) Then
                            vspGrid.SetText(1, vspGrid.ActiveRow, aEmptyCode)
                            Call SetCol(vspGrid.ActiveRow, 1)
                            ColBack = True
                            Exit Sub
                        Else
                            If (Mid(mTmpCode, 1, 2) = "00" Or Mid(mTmpCode, 3, 2) = "00" Or Mid(mTmpCode, 5, 4) = "0000") Then
                                MsgBox("Invalid Code", vbInformation, SysCompany)
                                vspGrid.SetText(1, vspGrid.ActiveRow, aEmptyCode)
                                Call SetCol(vspGrid.ActiveRow, 1)
                                ColBack = True
                                Exit Sub
                            End If
                            mSQL = "SELECT Description FROM Codes WHERE Code ='" & mTmpCode & "'"
                            mTmpStr = GetFldValue(mSQL, "Description")
                            vspGrid.SetText(2, vspGrid.ActiveRow, mTmpStr)
                            Call SetCol(vspGrid.ActiveRow, 2)
                        End If
                        ''** COPY OF PREVIOUS REMARKS
                        If vspGrid.ActiveRow >= 2 Then
                            Erase mTmpStr
                            vspGrid.GetText(3, vspGrid.ActiveRow - 1, mTmpStr)
                            mPrvRemarks = mTmpStr
                            vspGrid.SetText(3, vspGrid.ActiveRow, mTmpStr)
                        End If
                    End If
                    If vspGrid.ActiveCol = 1 Then
                        Erase mTmpStr
                        vspGrid.GetText(1, vspGrid.ActiveRow, mTmpStr)
                        mTmpCode = aCode2Str(mTmpStr)
                        Call ShowAcBalance(mTmpCode, txtBrCode.Text)
                    End If
                    ''
                Case 4  'Debit
                    Erase mTmpStr
                    vspGrid.GetText(1, vspGrid.ActiveRow, mTmpStr)
                    If Trim(mTmpStr) = "" Then
                        MsgBox("You Can't give Value Without giving Code", vbInformation, SysCompany)
                        vspGrid.SetText(4, vspGrid.ActiveRow, "")
                        Call SetCol(vspGrid.ActiveRow, 4)
                        ColBack = True
                        Exit Sub
                    End If
                    Erase mTmpStr
                    vspGrid.GetText(4, vspGrid.ActiveRow, mTmpStr)
                    mDebit = Val(mTmpStr)
                    Erase mTmpStr
                    vspGrid.GetText(5, vspGrid.ActiveRow, mTmpStr)
                    mCredit = Val(mTmpStr)
                    If mDebit > 0 And mCredit > 0 Then
                        MsgBox("Both Debit and Credit Can not be Greater then Zero", vbInformation, SysCompany)
                        vspGrid.SetText(4, vspGrid.ActiveRow, "")
                        Call SetCol(vspGrid.ActiveRow, 4)
                        ColBack = True
                        Exit Sub
                    End If
                    Call GetSum(LBLTotDr, LBLTotCr)
                    Erase mTmpStr
                    vspGrid.GetText(4, vspGrid.ActiveRow, mTmpStr)
                    mDebit = mTmpStr
                    Erase mTmpStr
                    vspGrid.GetText(5, vspGrid.ActiveRow, mTmpStr)
                    mCredit = mTmpStr
                Case 5  'Credit
                    Erase mTmpStr
                    vspGrid.GetText(1, vspGrid.ActiveRow, mTmpStr)
                    If Trim(mTmpStr) = "" Then
                        MsgBox("You Can't give Value Without giving Code", vbInformation, SysCompany)
                        vspGrid.SetText(5, vspGrid.ActiveRow, "")
                        Call SetCol(vspGrid.ActiveRow, 5)
                        ColBack = True
                        Exit Sub
                    End If
                    Erase mTmpStr
                    vspGrid.GetText(4, vspGrid.ActiveRow, mTmpStr)
                    mDebit = Val(mTmpStr)
                    Erase mTmpStr
                    vspGrid.GetText(5, vspGrid.ActiveRow, mTmpStr)
                    mCredit = Val(mTmpStr)
                    If mDebit > 0 And mCredit > 0 Then
                        MsgBox("Both Debit and Credit Can not be greater then Zero", vbInformation, SysCompany)
                        vspGrid.SetText(5, vspGrid.ActiveRow, "")
                        Call SetCol(vspGrid.ActiveRow, 5)
                        ColBack = True
                        Exit Sub
                    End If
                    Call GetSum(LBLTotDr, LBLTotCr)
            End Select
        End If
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
        If AddMode Or EditMode Then

            Dim mTmpStr As Object
            Dim mTmpCode As String
            Dim mPrvRemarks As String
            ObjFind = New Grid_Help

            If e.keyCode = Keys.Down And vspGrid.ActiveRow = vspGrid.MaxRows Then
                vspGrid.MaxRows = vspGrid.MaxRows + 1
                'Look Up for Account Pfcodes
            ElseIf vspGrid.ActiveCol = 1 And e.keyCode = Keys.F1 Then
                strFind = "SELECT Code,Description FROM Codes WHERE " & _
                            "LEN(RTRIM(CODE)) = " & aCodeL
                ObjFind.PMessage = "GLHead"
                ObjFind.sqlqueryFun = strFind
                ObjFind.ShowDialog()

                If ObjFind.PbOk = True Then
                    mTmpCode = ObjFind.strPKfun & ""
                    If (Mid(mTmpCode, aP1P, aP1L) = "00" Or Mid(mTmpCode, aP2P, aP2L) = "00" Or Mid(mTmpCode, aP3P + 1, aP3L) = "00" Or Mid(mTmpCode, aP4P + 2, aP4L) = "00000") Then
                        MsgBox("Control Code not allowed here", vbInformation, SysCompany)
                        vspGrid.SetText(1, vspGrid.ActiveRow, aEmptyCode)
                        Call SetCol(vspGrid.ActiveRow, 1)
                        ColBack = True
                        Exit Sub
                    End If
                    mTmpCode = aStr2Code(ObjFind.strPKfun)
                    vspGrid.SetText(1, vspGrid.ActiveRow, mTmpCode)
                    vspGrid.SetText(2, vspGrid.ActiveRow, ObjFind.sqlqueryFun)
                    mTmpCode = aCode2Str(mTmpCode)
                    Call ShowAcBalance(mTmpCode, txtBrCode.Text)

                    ''** COPY OF PREVIOUS REMARKS
                    If vspGrid.ActiveRow >= 2 Then
                        Erase mTmpStr
                        vspGrid.GetText(3, vspGrid.ActiveRow - 1, mTmpStr)
                        mPrvRemarks = mTmpStr
                        vspGrid.SetText(3, vspGrid.ActiveRow, mTmpStr)
                    End If
                End If
            ElseIf e.keyCode = Keys.Delete Then
                If SelRow Then
                    vspGrid.Row = vspGrid.ActiveRow
                    vspGrid.Action = 5
                    Call GetSum(LBLTotDr, LBLTotCr)
                    If vspGrid.MaxRows > 1 Then
                        vspGrid.MaxRows = vspGrid.MaxRows - 1
                    End If
                End If
            ElseIf vspGrid.ActiveCol = 5 And e.keyCode = Keys.Enter Then
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
                End If
            ElseIf e.keyCode = Keys.Return And vspGrid.ActiveCol = 5 Then
                If vspGrid.ActiveRow = vspGrid.MaxRows Then
                    vspGrid.MaxRows = vspGrid.MaxRows + 1
                    vspGrid.Col = 1
                End If
            ElseIf e.keyCode = Keys.Delete Then
                vspGrid.Row = vspGrid.ActiveRow
                vspGrid.Action = 5
                Call GetSum(LBLTotDr, LBLTotCr)
                If vspGrid.MaxRows > 1 Then
                    vspGrid.MaxRows = vspGrid.MaxRows - 1
                End If
            End If
            '** TO Check Enter Key In Leave Cell
            If e.keyCode = Keys.Return Then
                KeyReturn = True
            Else
                KeyReturn = False
            End If

            ''**
        End If
        ' ''If vspGrid.ActiveCol = 3 And e.keyCode = Keys.F1 Then
        ' ''    strFind = "SELECT LandID,LandName FROM Land WHERE Active=1 "
        ' ''    ObjFind.PMessage = "LandID"
        ' ''    ObjFind.sqlqueryFun = strFind
        ' ''    ObjFind.ShowDialog()

        ' ''    If ObjFind.PbOk = True Then
        ' ''        Dim mTmpCode As String
        ' ''        mTmpCode = ObjFind.strPKfun & ""
        ' ''        mTmpCode = aStr2LndCode(ObjFind.strPKfun)
        ' ''        vspGrid.SetText(3, vspGrid.ActiveRow, mTmpCode)
        ' ''    End If
        ' ''End If
    End Sub

    Private Sub btnCode_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCode.Click
        Dim mStDate As Date
        Dim mEnDate As Date

        mSQL = "Select Top 1 VDate From GLedg Where BrCode = '" & Trim(txtBrCode.Text) & "' " & _
               "And Code = '" & aCode2Str(btnCode.Text) & "'"
        mSQL = GetFldValue(mSQL, "VDate")
        mStDate = CDate(mSQL)

        If mSQL <> "" Then
            frmACStatus.mRefStDate = Format(mStDate, "dd-MM-yyyy")
            mSQL = "Select Top 1 VDate From GLedg Where BrCode = '" & Trim(txtBrCode.Text) & "' " & _
                   "And Code = '" & aCode2Str(btnCode.Text) & "' Order By VDate Desc"
            mSQL = GetFldValue(mSQL, "VDate")
            mEnDate = CDate(mSQL)
            frmACStatus.mRefEndDate = Format(mEnDate, "dd-MM-yyyy")
            frmACStatus.mRefBrCode = Trim(txtBrCode.Text)
            frmACStatus.mRefAcCode = aCode2Str(btnCode.Text)
            frmACStatus.Show()
        End If
    End Sub

    Private Sub txtBrCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBrCode.KeyDown
        ObjFind = New Grid_Help

        If e.KeyCode = Keys.F1 Then
            ObjFind.PMessage = "Branch"
            strFind = "SELECT BrCode,BrName FROM Branch " & _
                      "Where BrCode <> '000' Order By BrCode"
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
                MsgBox("No Record Found", vbInformation, SysCompany)
                txtBrCode.Text = ""
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub SetCol(ByVal mRow As Integer, ByVal mCol As Integer)

        vspGrid.Row = mRow
        vspGrid.Col = mCol

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

    Private Sub GetSum(ByVal LblDr As Label, ByVal LblCr As Label)
        Dim i As Integer
        Dim Tmp As Object
        Dim TotalDr As Double
        Dim TotalCr As Double
        TotalDr = 0
        TotalCr = 0
        For i = 1 To vspGrid.MaxRows
            Erase Tmp
            vspGrid.GetText(4, i, Tmp)
            TotalDr = TotalDr + Val(Tmp)
            Erase Tmp
            vspGrid.GetText(5, i, Tmp)
            TotalCr = TotalCr + Val(Tmp)
        Next i
        LblDr.Text = Format(TotalDr, "###,###,###,###.00")
        LblCr.Text = Format(TotalCr, "###,###,###,###.00")

    End Sub

    Private Sub vspGrid_LeaveCell(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_LeaveCellEvent) Handles vspGrid.LeaveCell
        If AddMode Or EditMode Then
            If e.row <> -1 And e.col <> -1 Then
                If e.col = 1 Then
                    lblToolTip.Text = "Enter Code"
                    vspGrid.SetText(4, vspGrid.ActiveRow, txtPurpose.Text)
                ElseIf e.col = 2 Then
                    lblToolTip.Text = ""
                ElseIf e.col = 3 Then
                    lblToolTip.Text = "Enter Remarks"
                ElseIf e.col = 4 Then
                    lblToolTip.Text = "Enter Debit Amount"
                ElseIf e.col = 5 Then
                    lblToolTip.Text = "Enter Credit Amount"
                Else
                    lblToolTip.Text = ""
                End If
            End If
            'If AddMode Or EditMode Then
            '    If e.col = 1 Then
            '        Erase mTmp
            '        vspGrid.GetText(1, vspGrid.ActiveRow, mTmp)
            '        mStr = mTmp
            '        If Keys.Return And (mStr = "" Or mStr = aEmptyCode) And Not ColBack Then
            '            'SendKeys.Send("{TAB}")
            '            If vspGrid.MaxRows > 1 Then
            '                vspGrid.MaxRows = vspGrid.MaxRows - 1
            '            End If
            '            btnSave.Focus()
            '            ColBack = True
            '            e.cancel = True
            '            Exit Sub
            '        End If
            '    End If
            '    If vspGrid.ActiveCol = 3 Then
            '        Erase mTmp
            '        vspGrid.GetText(3, vspGrid.ActiveRow, mTmp)
            '        mStr = mTmp
            '        mStr = objProper.Proper(mStr)
            '        vspGrid.SetText(3, vspGrid.ActiveRow, mStr)
            '    End If
            ''
            If ColBack Then
                e.cancel = True
                ColBack = False
            End If
        End If
    End Sub

    Private Sub btnView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnView.Click
        frmSRH_Vouchers.ShowDialog()
        mType = "JV"
        If frmSRH_Vouchers.SetFilter = True Then
            If FltAll Then
                SDate = Constants.ProjConst.SDate
                EDate = Constants.ProjConst.EDate
                objJV.StDate = GetDate(SDate, "dd-MMM-yyyy")
                objJV.EndDate = GetDate(EDate, "dd-MMM-yyyy")
                objJV.BrCode = Branch
                objJV.Type = mType
                objJV.Level = "0"
                dtMaster = objJV.LoadAllMaster
                dtMasterMenu = objJV.LoadAllMaster
                mMenuStr = "Select ROW_NUMBER() " & _
                         "OVER (ORDER BY BrCode,vno) AS Row,Vno,BrCode,RefRemarks,CONVERT(varchar(13),Vdate,106) As Date From GLHead " & _
                         "Where BrCode = '" + Branch + "' And Type = '" + mType + "'" & _
                         " And VDate Between '" + objJV.StDate + "' And '" + objJV.EndDate + "'" & _
                         "Order By Brcode,VNo"
            ElseIf Fltpost Then
                objJV.Level = "1"
                objJV.StDate = CStr(GetDate(SDate, "dd-MMM-yyyy"))
                objJV.EndDate = CStr(GetDate(EDate, "dd-MMM-yyyy"))
                dtMaster = objJV.LoadSelectJV()
                dtMasterMenu = objJV.LoadAllMaster
                mMenuStr = "Select ROW_NUMBER() " & _
                         "OVER (ORDER BY BrCode,vno) AS Row,Vno,RefRemarks,CONVERT(varchar(13),Vdate,106) As Date From GLHead " & _
                         "Where Posted= 'Y' and BrCode = '" + Branch + "' And Type = '" + mType + "'" & _
                          " And VDate Between '" + objJV.StDate + "' And '" + objJV.EndDate + "'" & _
                         "Order By Brcode,VNo"
            ElseIf FltUnpost Then
                objJV.Level = "2"
                objJV.StDate = CStr(GetDate(SDate, "dd-MMM-yyyy"))
                objJV.EndDate = CStr(GetDate(EDate, "dd-MMM-yyyy"))
                dtMaster = objJV.LoadSelectJV()
                dtMasterMenu = objJV.LoadAllMaster
                mMenuStr = "Select ROW_NUMBER() " & _
                         "OVER (ORDER BY BrCode,vno) AS Row,Vno,RefRemarks,CONVERT(varchar(13),Vdate,106) As Date From GLHead " & _
                         "Where Posted= 'N' and BrCode = '" + Branch + "' And Type = '" + mType + "'" & _
                          " And VDate Between '" + objJV.StDate + "' And '" + objJV.EndDate + "'" & _
                         "Order By Brcode,VNo"
            End If
        End If
        Call MenuGridLoad(mMenuStr)
        rowNum = dtMaster.Rows.Count - 1
        If rowNum >= 0 Then
            Call SetFormSecurity(Me)
            Call SetButtonsSurity(Me)
            Call SetButtonPrinciple()
            Call SetButton()

            Call LoadMaster()
            objJV.BrCode = Trim(txtBrCode.Text)
            objJV.Type = mType
            objJV.VNo = lblVNo.Text
            dtDetail = objJV.LoadAllDetail()
            'rowNum = dtDetail.Rows.Count - 1
            Call LoadDetail()
            btnExit.Focus()
        Else
            ClearGVhelpGrid()
            Call ClearAll()
            btnStatus(False)
            btnEdit.Enabled = False
            btnAdd.Enabled = True
            btnView.Enabled = True
            rowNum = -1
        End If
    End Sub

    Private Sub btnPost_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPost.Click
        frmAccPostAll.mVType = mType
        frmAccPostAll.mBrCode = Trim(txtBrCode.Text)
        mVno = lblVNo.Text
        frmAccPostAll.ShowDialog()
        dtMaster = objJV.LoadAllMaster()
        Call MenuGridLoad(mMenuStr)
        rowNum = dtMaster.Rows.Count - 1
        rowNum = dtMaster.Rows.Count - 1
        dtDetail = objJV.LoadAllDetail()
        Call LoadDetail()
        dtMaster = objJV.LoadAllMaster()
        rowNum = dtMaster.Rows.Count - 1
        Call LoadMaster()
        dtDetail = objJV.LoadAllDetail()
        Call LoadDetail()
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
        vspGrid.Focus()
    End Sub

    Private Sub frmJV_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        mfrmJV = False
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub EditSet()

        mSQL = "DELETE FROM GLedg WHERE BrCode = '" & Trim(txtBrCode.Text) & "' And VNo = '" & _
                lblVNo.Text & "' AND TYPE ='" & mType & "'"
        ExecQuery(mSQL)
    End Sub

    Sub LoadMasterMenu()
        ''Dim mStr As String
        ''Dim inc As Integer = 0
        ''Try
        ''    For mindexMenu = 1 To dtMasterMenu.Rows.Count '- 1

        ''        If mindexMenu > vspGridMenu.MaxRows Then
        ''            vspGridMenu.MaxRows = vspGridMenu.MaxRows + 1
        ''        End If
        ''        mStr = dtMasterMenu.Rows(inc).Item("VNo")
        ''        vspGridMenu.SetText(1, mindexMenu, mStr)
        ''        mStr = dtMasterMenu.Rows(inc).Item("VDate")
        ''        vspGridMenu.SetText(2, mindexMenu, mStr)
        ''        mStr = dtMasterMenu.Rows(inc).Item("RefRemarks")
        ''        vspGridMenu.SetText(3, mindexMenu, mStr)
        ''        vspGridMenu.SetText(4, mindexMenu, inc)
        ''        inc = inc + 1
        ''    Next
        ''Catch ex As Exception
        ''    'MsgBox(ex.Message, MsgBoxStyle.Information)
        ''End Try
    End Sub

    Private Sub SetCol(ByVal mRow As Integer, ByVal mCol As Integer, ByVal GridType As Integer)
        If GridType = 1 Then
            vspGrid.Row = mRow
            vspGrid.Col = mCol
        Else
            'vspGridMenu.Row = mRow
            'vspGridMenu.Col = mCol
            'vspGridMenu.MaxRows = 1
            'vspGridMenu.MaxCols = 4
        End If
    End Sub

    Private Sub MenuGridLoad(ByVal mQuery As String)
        Dim mcol As Integer
        Dim mcolName As String
        Try
            If mQuery <> "" Or mQuery Is Nothing Then
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
            'MsgBox("Record Does Not Exist", MsgBoxStyle.Information, SysCompany)
            Me.txtSearch.Text = String.Empty

            Me.strPKValue = 0
        End If
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtSearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearch.KeyPress
        Dim mChe As Boolean
        mChe = Char.IsNumber(e.KeyChar)
        mChe = Char.IsLetter(e.KeyChar)
        mChe = Char.IsSymbol(e.KeyChar)
        mChe = Char.IsWhiteSpace(e.KeyChar)
        mChe = Char.IsControl(e.KeyChar)
        mChe = Char.IsLetterOrDigit(e.KeyChar)
        mChe = Char.IsSurrogate(e.KeyChar)
        mChe = Char.IsSeparator(e.KeyChar)
        mChe = Char.IsPunctuation(e.KeyChar)

        If (Char.IsNumber(e.KeyChar)) <> True And (Char.IsLetter(e.KeyChar)) <> True And (Char.IsWhiteSpace(e.KeyChar) <> True) And (Char.IsSymbol(e.KeyChar)) <> True And (Char.IsControl(e.KeyChar)) <> True And (Char.IsPunctuation(e.KeyChar)) <> True Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = "" Then
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

    Private Sub GVHelp_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GVHelp.CellClick
        vColumn = e.ColumnIndex
    End Sub

    Private Sub GVHelp_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVHelp.DoubleClick
        If AddMode <> True And EditMode <> True Then
            If GVHelp.RowCount <> 0 Then
                Me.sqlquery = Me.GVHelp.Item(0, GVHelp.CurrentRow.Index).Value
                rowNum = sqlquery - 1
                If rowNum >= 0 Then
                    Call LoadMaster()
                    objJV.BrCode = Trim(txtBrCode.Text)
                    objJV.Type = mType
                    objJV.VNo = lblVNo.Text
                    dtDetail = objJV.LoadAllDetail()
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

    Private Sub btnStatus(ByVal status As Boolean)
        btnAdd.Enabled = status
        btnEdit.Enabled = status
        btnDelete.Enabled = status
        btnPost.Enabled = status
        btnPrint.Enabled = status
    End Sub

    Private Sub SetButtonPrinciple()
        mAdd = mbtnAdd
        mEdit = mbtnEdit
        mDelete = mbtnDelete
        mPrint = mbtnPrint
        mPost = mbtnPost
    End Sub

    Private Sub SetButton()
        btnAdd.Enabled = mAdd
        btnEdit.Enabled = mEdit
        btnDelete.Enabled = mDelete
        btnPrint.Enabled = mPrint
        btnPost.Enabled = mPost
    End Sub

    Private Sub GVHelp_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GVHelp.CellContentClick

    End Sub
End Class

