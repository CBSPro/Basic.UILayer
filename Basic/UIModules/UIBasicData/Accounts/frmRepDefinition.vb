Imports System.Data
Imports System.Data.SqlClient
Imports Basic.Constants.ProjConst
Imports Basic.DAL
Imports Basic.DAL.Utils
'Imports Basic.Reports

Public Class frmRepDefinition
    Inherits System.Windows.Forms.Form

    Dim objRefDef As New cRepDefinition
    Dim objProper As New cProper

    Dim mAdd As Boolean
    Dim mEdit As Boolean
    Dim mDelete As Boolean
    Dim mPost As Boolean
    Dim mPrint As Boolean

    Dim PODS As New DataSet
    Dim DtDet As New DataTable
    Dim DaDet As SqlDataAdapter
    Dim objRow As Data.DataRow
    Dim ObjFind As Grid_Help
    Dim tableName As String = "Pftloss"
    Dim strFind As String
    Dim mMenuStr As String
    Dim Flag As Boolean
    Dim AddMode As Boolean
    Dim EditMode As Boolean
    Dim KeyReturn As Boolean
    Dim ColBack As Boolean
    Dim SelRow As Boolean
    Dim dtMaster As New DataTable
    Dim dtDetail As New DataTable
    Dim rowNum As Integer
    Dim rowNum1 As Integer
    Dim dtLookup As DataTable
    Dim vColumn As Integer
    Private sqlquery As String
    Private strPKValue As String
    Private mtempStr As String

    Private Sub frmRepDefinition_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        mDefReport = False
    End Sub

    Private Sub frmRepDefinition_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MenuName = "miDefRep"
        Me.MdiParent = frmMdi
        GpData.Enabled = False
        Me.WindowState = FormWindowState.Maximized
        Flag = True
        Call SetEntryMode()
        btnSave.Enabled = False
        btnCancel.Enabled = False
        dtMaster = objRefDef.LoadAllMaster()
        dtLookup = objRefDef.LoadAllMaster()
        mMenuStr = "Select ROW_NUMBER()OVER (ORDER BY PageNo) AS Row,Max(PageNo) PageNo,Max(HDR) HDR,Max(AddOn) AddOn," & _
                   "Max(AddBy) AddBy From Pftloss Group By PageNo"
        Call MenuGridLoad(mMenuStr)
        rowNum = dtMaster.Rows.Count - 1
        If (dtMaster Is Nothing Or dtMaster.Rows.Count < 1) Then
            MsgBox("No Record Found", MsgBoxStyle.OkCancel, SysCompany)
            Exit Sub
        Else
            rowNum = dtMaster.Rows.Count - 1
            Call LoadMaster()
        End If
        objRefDef.Pageno = Trim(txtRepNo.Text)
        dtDetail = objRefDef.LoadAllDetail()
        rowNum1 = dtDetail.Rows.Count - 1
        Call LoadDetail()
        vspGrid.Enabled = False
        'dtMaster = objRefDef.LoadAllDetail()
        btnExit.Focus()
        btnStatus(False)
        Call SetFormSecurity(Me)
        Call SetButtonsSurity(Me)
        Call SetButtonPrinciple()
        Call SetButton()
    End Sub

    Sub LoadMaster()
        txtRepNo.Text = dtMaster.Rows(rowNum).Item("Pageno") 'objRefDef.Pageno
        txtHeading.Text = dtMaster.Rows(rowNum).Item("Hdr") 'objRefDef.Hdr
        lblCompany.Text = "Recorded On : " & GetDate(dtMaster.Rows(rowNum).Item("AddOn"), "dd-MMM-yyyy") 'objRefDef.AddOn
        lblBy.Text = "Recorded By : " & dtMaster.Rows(rowNum).Item("AddBy") 'objRefDef.AddBy
        lblToolTip.Text = "Close Form"
    End Sub

    Sub LoadDetail()
        Dim mi As Integer

        rowNum1 = 0
        For mi = 1 To dtDetail.Rows.Count
            If mi < dtDetail.Rows.Count Then
                vspGrid.MaxRows = vspGrid.MaxRows + 1
                rowNum1 = rowNum1 + 1
            End If
            mStr = dtDetail.Rows(rowNum1).Item("mLineNo").ToString()
            vspGrid.SetText(1, mi, mStr)
            mStr = dtDetail.Rows(rowNum1).Item("NoteRef").ToString()
            vspGrid.SetText(2, mi, mStr)
            mStr = dtDetail.Rows(rowNum1).Item("Description").ToString()
            vspGrid.SetText(3, mi, mStr)
            mStr = dtDetail.Rows(rowNum1).Item("mValue").ToString()
            vspGrid.SetText(4, mi, mStr)
        Next
    End Sub

    Sub ClearGrid()
        Call vspGrid.ClearRange(1, 1, vspGrid.MaxCols, vspGrid.MaxRows, True)
        vspGrid.MaxRows = 1
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
        txtRepNo.Text = ""
        txtHeading.Text = ""
        Call ClearGrid()
    End Sub

    Sub LoadRefValues()

        objRefDef.LoadRepDef()

        txtRepNo.Text = objRefDef.Pageno
        txtHeading.Text = objRefDef.Hdr
        lblCompany.Text = "Recorded On : " & objRefDef.AddOn
        lblBy.Text = "Recorded By : " & objRefDef.AddBy
        lblToolTip.Text = "Close Form"
    End Sub

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        AddMode = True
        EditMode = False
        Flag = False
        Call SetEntryMode()
        btnSave.Enabled = True
        btnCancel.Enabled = True
        Call ClearAll()
        GpData.Enabled = True
        'txtRepNo.Text = objRefDef.GetPageNo
        mSQL = "Select PageNo  from PftLoss"
        mSQL = GetFldValue(mSQL, "PageNo")
        If (mSQL = "") Then
            txtRepNo.Text = ""
        Else
            txtRepNo.Text = objRefDef.GenPageNo
        End If
        vspGrid.Enabled = True
        vspGrid.BlockMode = False
        lblCompany.Text = "Recorded On " & SySDate
        lblToolTip.Text = "Add New Record"
        lblBy.Text = "Recorded By : " & SysUserID
        'lblBy.Text = "Recorded By : " & SysUserID
        txtRepNo.Focus()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        lblToolTip.Text = "Cancel Last Action"
        Opt = MsgBox("Do you wish to Abort ?", MsgBoxStyle.YesNo)
        If Opt = MsgBoxResult.No Then
            txtRepNo.Focus()
            Exit Sub
        End If
        dtMaster = objRefDef.LoadAllMaster()
        If Not (dtMaster Is Nothing Or dtMaster.Rows.Count < 1) Then
            rowNum = dtMaster.Rows.Count - 1
            Call LoadMaster()
        End If
        objRefDef.Pageno = Trim(txtRepNo.Text)
        dtDetail = objRefDef.LoadAllDetail()
        rowNum1 = dtDetail.Rows.Count - 1
        Call LoadDetail()
        'Call LoadMaster()
        'Call LoadDetail()
        Flag = True
        Call SetEntryMode()
        GpData.Enabled = False
        btnSave.Enabled = False
        btnCancel.Enabled = False
        vspGrid.Enabled = False
        vspGrid.BlockMode = True
        Call MenuGridLoad(mMenuStr)
        rowNum = dtMaster.Rows.Count - 1
        AddMode = False
        EditMode = False
        btnStatus(False)
        Call SetFormSecurity(Me)
        Call SetButtonsSurity(Me)
        Call SetButtonPrinciple()
        Call SetButton()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        lblToolTip.Text = "Refresh Records"
        ClearGrid()
        If rowNum >= 0 Then
            Call LoadMaster()
            Call LoadDetail()
            btnStatus(False)
            Call SetFormSecurity(Me)
            Call SetButtonsSurity(Me)
            Call SetButtonPrinciple()
            Call SetButton()
            Call MenuGridLoad(mMenuStr)
            rowNum = dtMaster.Rows.Count - 1
            Call LoadMaster()
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim frmList As New frmRPT_List

        lblToolTip.Text = "Print Record(s)"
        pPara = 4
        frmList.ShowDialog()
        btnStatus(False)
        Call SetFormSecurity(Me)
        Call SetButtonsSurity(Me)
        Call SetButtonPrinciple()
        Call SetButton()
    End Sub

    Private Sub btnFind_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFind.Click
        'Me.Text = "Report Definition"
        Dim rep As New frmRPT_List
        rep.mCode = txtRepNo.Text
        rep.RepName = "RepDefinition.Rpt"
        rep.mReport = 3
        rep.rptPreview(sender, e)

        'lblToolTip.Text = "Find A Record"
        'ObjFind = New Grid_Help
        'mOrder = 0
        'strFind = "SELECT MAX(PAGENO) AS PAGENO,MAX(HDR) AS HDR FROM " & _
        '             "PFTLOSS GROUP BY PAGENO"
        'ObjFind.PMessage = "Pftloss"
        'ObjFind.sqlqueryFun = strFind
        'ObjFind.ShowDialog()

        'If ObjFind.PbOk = True Then
        '    'objRefDef.Pageno = ObjFind.strPKfun
        '    'objRefDef.Pageno = Trim(txtRepNo.Text)
        '    Call ClearAll()
        '    objRefDef.Pageno = ObjFind.strPKfun & ""
        '    Call LoadRefValues()
        '    'txtRepNo.Text = ObjFind.strPKfun & ""
        '    'Call LoadDetail()
        '    objRefDef.Pageno = ObjFind.strPKfun & ""
        '    dtDetail = objRefDef.LoadAllDetail()
        '    rowNum1 = dtDetail.Rows.Count - 1
        '    Call LoadDetail()
        'End If
        'btnStatus(False)
        'Call SetFormSecurity(Me)
        'Call SetButtonsSurity(Me)
        'Call SetButtonPrinciple()
        'Call SetButton()
    End Sub

    Private Sub btnTop_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTop.Click
        rowNum = 0
        btnTop.Enabled = False
        btnPrevious.Enabled = False
        btnNext.Enabled = True
        btnBottom.Enabled = True
        Call LoadMaster()
        objRefDef.Pageno = Trim(txtRepNo.Text)
        dtDetail = objRefDef.LoadAllDetail()
        Call ClearGrid()
        Call LoadDetail()
        lblToolTip.Text = "Move To First Record"
        btnStatus(False)
        Call SetFormSecurity(Me)
        Call SetButtonsSurity(Me)
        Call SetButtonPrinciple()
        Call SetButton()
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        lblToolTip.Text = "Close Form"
        Me.Close()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        lblToolTip.Text = "Edit Current Record"
        EditMode = True
        AddMode = False
        Flag = False
        Call SetEntryMode()
        vspGrid.Enabled = True
        vspGrid.BlockMode = False
        GpData.Enabled = True
        txtRepNo.Enabled = False
        txtHeading.Focus()
        btnEdit.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        lblToolTip.Text = "Delete Current Record"
        Opt = MsgBox("Are You Sure To Delete Current Record", MsgBoxStyle.YesNo)
        If Opt = MsgBoxResult.Yes Then
            objRefDef.DelRepDef()
            Call ClearAll()
            dtMaster = objRefDef.LoadAllMaster()
            If (dtMaster Is Nothing Or dtMaster.Rows.Count < 1) Then
                MsgBox("No Record Found", MsgBoxStyle.OkCancel, SysCompany)
                Exit Sub
            Else
                rowNum = dtMaster.Rows.Count - 1
                Call LoadMaster()
            End If
            objRefDef.Pageno = Trim(txtRepNo.Text)
            dtDetail = objRefDef.LoadAllDetail()
            rowNum1 = dtDetail.Rows.Count - 1
            Call LoadDetail()
        End If
        btnStatus(False)
        Call SetFormSecurity(Me)
        Call SetButtonsSurity(Me)
        Call SetButtonPrinciple()
        Call SetButton()
    End Sub

    Private Sub btnBottom_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBottom.Click
        rowNum = dtMaster.Rows.Count - 1
        btnTop.Enabled = True
        btnPrevious.Enabled = True
        btnNext.Enabled = False
        btnBottom.Enabled = False
        lblToolTip.Text = "Move To Last Record"
        lblToolTip.Text = "Move To Last Record"
        Call LoadMaster()
        objRefDef.Pageno = Trim(txtRepNo.Text)
        dtDetail = objRefDef.LoadAllDetail()
        Call ClearGrid()
        Call LoadDetail()
        btnStatus(False)
        Call SetFormSecurity(Me)
        Call SetButtonsSurity(Me)
        Call SetButtonPrinciple()
        Call SetButton()
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        lblToolTip.Text = "Save Current Record"
        If CheckValidation() Then
            objRefDef.getConnection()
            objRefDef.BeginTransaction()
            If AddMode Then
                Try
                    SetData()
                    'objRefDef.SaveValues()
                    Call btnAdd_Click(Nothing, Nothing)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    objRefDef.RollBack()
                End Try
            ElseIf EditMode Then
                Try
                    objRefDef.DelRepDef()
                    'objRefDef.EditRepDef()
                    SetData()
                    Flag = True
                    Call SetEntryMode()
                    GpData.Enabled = False
                    btnSave.Enabled = False
                    btnCancel.Enabled = False
                    dtMaster = objRefDef.LoadAllMaster()
                    If (dtMaster Is Nothing Or dtMaster.Rows.Count < 1) Then
                        MsgBox("No Record Found", MsgBoxStyle.OkCancel, SysCompany)
                        Exit Sub
                    Else
                        rowNum = dtMaster.Rows.Count - 1
                        Call LoadMaster()
                    End If
                    objRefDef.Pageno = Trim(txtRepNo.Text)
                    dtDetail = objRefDef.LoadAllDetail()
                    rowNum1 = dtDetail.Rows.Count - 1
                Catch ex As Exception
                    MsgBox(ex.Message)
                    objRefDef.RollBack()
                End Try
                Call LoadDetail()
            End If
            objRefDef.CommitTransction()
        End If
        'vspGrid.Enabled = False
        'vspGrid.BlockMode = True
        btnStatus(False)
        Call MenuGridLoad(mMenuStr)
        rowNum = dtMaster.Rows.Count - 1
        Call SetFormSecurity(Me)
        Call SetButtonsSurity(Me)
        Call SetButtonPrinciple()
        Call SetButton()
    End Sub

    Private Sub SetData()
        Dim mi As Integer
        Dim mTemp As Object

        For mi = 1 To vspGrid.MaxRows
            objRefDef.Pageno = Me.txtRepNo.Text
            objRefDef.Hdr = Me.txtHeading.Text
            Erase mTemp
            vspGrid.GetText(1, mi, mTemp)
            objRefDef.mLineno = mTemp
            Erase mTemp
            vspGrid.GetText(2, mi, mTemp)
            objRefDef.Noteref = mTemp
            Erase mTemp
            vspGrid.GetText(3, mi, mTemp)
            objRefDef.Description = mTemp
            Erase mTemp
            vspGrid.GetText(4, mi, mTemp)
            objRefDef.mValue = mTemp
            objRefDef.AddOn = SySDate
            objRefDef.AddBy = SysUserID
            objRefDef.SaveValues()
            'If AddMode Then
            'objRefDef.AddOn = Format(SySDate, "dd-MMM-yyyy")
            'objBranch.AddBy = SysUserID
            'ElseIf EditMode Then
            'objRefDef.EditOn = SySDate
            ''objRefDef.EditOn = Format(SySDate, "dd-MMM-yyyy")
            'objRefDef.EditBy = "0001"
            ''objBranch.AddBy = SysUserID
            ''objRefDef.EditRepDef()
            'objRefDef.SaveValues()
            'End If
        Next
    End Sub

    Private Function CheckValidation() As Boolean
        If txtRepNo.Text = "" Then
            MsgBox("Please Enter Page No.", MsgBoxStyle.Information, SysCompany)
            txtRepNo.Focus()
            Return False
        ElseIf txtHeading.Text = "" Then
            MsgBox("Please Enter Heading", MsgBoxStyle.Information, SysCompany)
            txtHeading.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub vspGrid_Change(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_ChangeEvent) Handles vspGrid.Change
        Dim mTmpStr As Object
        Dim mTmpCode As String

        If AddMode Or EditMode Then
            Select Case vspGrid.ActiveCol
                Case 1
                    Erase mTmpStr
                    vspGrid.GetText(1, vspGrid.ActiveRow, mTmpStr)
                    mTmpCode = mTmpStr
                    mTmpCode = Format(Val(mTmpCode), "00")
                    vspGrid.SetText(1, vspGrid.ActiveRow, mTmpCode)
                    If mTmpCode <> "" Then
                        If mTmpCode = "" Then
                            SendKeys.Send("{Tab}")
                            ColBack = True
                            Exit Sub
                        End If
                        If SearchLine(mTmpCode, vspGrid.ActiveRow) Then
                            MsgBox("This Line No Allready Defined", vbInformation, SysCompany)
                            vspGrid.SetText(1, vspGrid.ActiveRow, "")
                            KeyReturn = False
                            vspGrid.Col = 1
                            ColBack = True
                            Exit Sub
                        End If
                    End If
            End Select
        End If
    End Sub

    Private Sub vspGrid_ClickEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_ClickEvent) Handles vspGrid.ClickEvent
    End Sub

    Private Sub vspGrid_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles vspGrid.KeyDownEvent
        If e.keyCode = Keys.Down And vspGrid.ActiveRow = vspGrid.MaxRows Then
            vspGrid.MaxRows = vspGrid.MaxRows + 1
        ElseIf e.keyCode = Keys.Delete Then
            vspGrid.Row = vspGrid.ActiveRow
            vspGrid.Action = 5
            If vspGrid.MaxRows > 1 Then
                vspGrid.MaxRows = vspGrid.MaxRows - 1
            End If
        ElseIf e.keyCode = Keys.Insert Then
            vspGrid.MaxRows = vspGrid.MaxRows + 1
            vspGrid.Row = vspGrid.ActiveRow
            vspGrid.Action = 7
        ElseIf e.keyCode = Keys.Return And vspGrid.ActiveCol = 4 Then
            If vspGrid.ActiveRow = vspGrid.MaxRows Then
                vspGrid.MaxRows = vspGrid.MaxRows + 1
                vspGrid.Col = 1
            End If
        End If
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
        End If
        Call LoadMaster()
        objRefDef.Pageno = Trim(txtRepNo.Text)
        dtDetail = objRefDef.LoadAllDetail()
        Call ClearGrid()
        Call LoadDetail()
        lblToolTip.Text = "Move To Next Record"
        btnStatus(False)
        Call SetFormSecurity(Me)
        Call SetButtonsSurity(Me)
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
        End If
        Call LoadMaster()
        objRefDef.Pageno = Trim(txtRepNo.Text)
        dtDetail = objRefDef.LoadAllDetail()
        Call ClearGrid()
        Call LoadDetail()
        lblToolTip.Text = "Move To Previous Record"
        btnStatus(False)
        Call SetFormSecurity(Me)
        Call SetButtonsSurity(Me)
        Call SetButtonPrinciple()
        Call SetButton()
    End Sub

    Private Sub txtRepNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRepNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtHeading_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtHeading.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtRepNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRepNo.LostFocus
        If Trim(txtRepNo.Text) <> "" Then
            txtRepNo.Text = Format(Val(Trim(txtRepNo.Text)), "00")
        End If
    End Sub

    Private Sub txtHeading_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHeading.LostFocus
        If Trim(txtHeading.Text) <> "" Then
            txtHeading.Text = objProper.Proper(txtHeading.Text)
        End If
        vspGrid.Focus()
    End Sub

    Private Function SearchLine(ByVal mCode As String, ByVal CurRow As Integer) As Boolean
        Dim mi As Integer
        Dim mTmpCode As String
        Dim mTmpVal

        For mi = 1 To vspGrid.MaxRows
            Erase mTmpVal
            vspGrid.GetText(1, mi, mTmpVal)
            mTmpCode = mTmpVal
            If mTmpVal <> "" Then
                If mTmpCode = mCode And mi <> CurRow Then
                    SearchLine = True
                    Exit Function
                End If
            End If
        Next mi
    End Function

    Private Sub vspGrid_LeaveCell(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_LeaveCellEvent) Handles vspGrid.LeaveCell
        Dim mTmpStr As Object
        Dim mTemp As String

        If AddMode Or EditMode Then
            Dim mTmp As Object
            Erase mTmp
            vspGrid.GetText(1, vspGrid.ActiveRow, mTmp)
            If KeyReturn And mTmp = "" Then
                SendKeys.Send("{Tab}")
                ColBack = True
            End If
            If ColBack Then
                ColBack = False
            End If
        End If
        If vspGrid.ActiveCol = 3 Then
            Erase mTmpStr
            vspGrid.GetText(3, vspGrid.ActiveRow, mTmpStr)
            mTemp = mTmpStr
            mTemp = objProper.Proper(mTemp)
            vspGrid.SetText(3, vspGrid.ActiveRow, mTemp)
        End If
    End Sub

    Private Sub GpData_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GpData.Enter

    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click

    End Sub

    Private Sub btnPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPost.Click

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

    Private Sub txtHeading_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHeading.TextChanged

    End Sub

    Private Sub GVHelp_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GVHelp.CellClick
        vColumn = e.ColumnIndex
    End Sub

    Private Sub GVHelp_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GVHelp.CellContentClick

    End Sub

    Private Sub GVHelp_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVHelp.DoubleClick
        If AddMode <> True And EditMode <> True Then
            If GVHelp.RowCount <> 0 Then
                Me.sqlquery = Me.GVHelp.Item(0, GVHelp.CurrentRow.Index).Value
                rowNum = sqlquery - 1
                dtMaster = objRefDef.LoadAllMaster()
                dtLookup = objRefDef.LoadAllMaster()
                If rowNum >= 0 Then
                    Call LoadMaster()
                    objRefDef.Pageno = Trim(txtRepNo.Text)
                    dtDetail = objRefDef.LoadAllDetail()
                    Call ClearGrid()
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
        If (Char.IsNumber(e.KeyChar)) <> True And (Char.IsLetter(e.KeyChar)) <> True And (Char.IsWhiteSpace(e.KeyChar) <> True) And (Char.IsSymbol(e.KeyChar)) <> True And (Char.IsControl(e.KeyChar)) <> True And (Char.IsPunctuation(e.KeyChar)) <> True Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = "" Then
            vColumn = 0
            dtLookup.DefaultView.RowFilter = Nothing
            'lblNoOfRecords.Text = Me.GVHelp.RowCount & " Records Found"
        Else
            With dtLookup
                If .Columns(vColumn).DataType.ToString = "System.Int32" Or .Columns(vColumn).DataType.ToString = "System.Double" Then
                    .DefaultView.RowFilter = .Columns(vColumn).Caption & " = " & Val(txtSearch.Text)
                ElseIf .Columns(vColumn).DataType.ToString = "System.String" Or .Columns(vColumn).DataType.ToString = "System.char" Then
                    .DefaultView.RowFilter = .Columns(vColumn).Caption & " like '" & txtSearch.Text & "%'"
                End If
                'lblNoOfRecords.Text = Me.GVHelp.RowCount & " Records Found"
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

    Private Sub frmRepDefinition_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        mMenuStr = "Select ROW_NUMBER()OVER (ORDER BY PageNo) AS Row,Max(PageNo) PageNo,Max(HDR) HDR,Max(AddOn) AddOn," & _
                          "Max(AddBy) AddBy From Pftloss Group By PageNo"
        Call MenuGridLoad(mMenuStr)
        btnRefresh_Click(sender, e)
    End Sub
End Class