Imports System.Data
Imports System.Data.SqlClient
Imports Basic.Constants.ProjConst
Imports Basic.DAL
Imports Basic.Reports
Imports Basic.DAL.Utils



Public Class frmAccounts
    Inherits System.Windows.Forms.Form

    Dim objAccount As New cAccounts
    Dim objProper As New cProper

    Dim mAdd As Boolean
    Dim mEdit As Boolean
    Dim mDelete As Boolean
    Dim mPost As Boolean
    Dim mPrint As Boolean

    Dim PODS As New DataSet
    Dim objRow As Data.DataRow
    Dim ObjFind As Grid_Help
    Dim tableName As String = "Codes"
    Dim strFind As String
    Dim mOpen As String
    Dim Flag As Boolean
    Dim mMenuStr As String
    Dim AddMode As Boolean
    Dim EditMode As Boolean
    Dim dtAccount As New DataTable
    Dim rowNum As Integer
    Dim dtLookup As DataTable
    Dim vColumn As Integer
    Private sqlquery As String
    Private strPKValue As String

    Private Sub frmAccounts_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Constants.ProjConst.mAccMaintanance = False
    End Sub

    Private Sub frmAccounts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.MdiParent = frmMdi
        GpACDef.Enabled = False
        Flag = True
        Call SetAccParam()
        Call SetEntryMode()
        GpStatus.Enabled = False
        mskCode.Mask = aMaskCode
        dtAccount = objAccount.LoadAllCodes()
        dtLookup = objAccount.LoadAllCodes()
        mMenuStr = "Select ROW_NUMBER()OVER (ORDER BY Code) AS Row,Code,Description,AccType,Status," & _
                    "CONVERT(varchar(13),OpenDate,106) As OpenDate from Codes"
        Call MenuGridLoad(mMenuStr)
        rowNum = dtAccount.Rows.Count - 1
        If rowNum >= 0 Then
            Call LoadValue()
        End If
        btnPost.Enabled = False
        btnView.Enabled = True
        btnAdd.Enabled = True
        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnStatus(False)
        Call SetFormSecurity(Me)
        Call SetButtonsSurity(Me)
        Call SetButtonPrinciple()
        Call SetButton()
        If mAdd = True Then
            btnAdd.Enabled = True
        End If
    End Sub

    Sub LoadValue()

        mskCode.Text = aStr2Code(dtAccount.Rows(rowNum).Item("Code")) 'objAccount.Code
        txtDesc1.Text = dtAccount.Rows(rowNum).Item("Description") & "" 'objAccount.Description
        txtDesc2.Text = dtAccount.Rows(rowNum).Item("Desc2") & "" 'objAccount.Desc2
        txtDesc3.Text = dtAccount.Rows(rowNum).Item("Desc3") & "" 'objAccount.Desc3
        If dtAccount.Rows(rowNum).Item("Status") = "A" Then
            rdbActive.Checked = True
        ElseIf dtAccount.Rows(rowNum).Item("Status") = "C" Then
            rdbClosed.Checked = True
        End If
        dtpOpenDate.Text = dtAccount.Rows(rowNum).Item("OpenDate") & "" 'objAccount.OpenDate
        dtpCloseDate.Text = dtAccount.Rows(rowNum).Item("CloseDate") & "" 'objAccount.CloseDate


        If Not IsDBNull(dtAccount.Rows(rowNum).Item("AccType")) Then
            If dtAccount.Rows(rowNum).Item("AccType") = "A" Then
                rdbAsset.Checked = True
            ElseIf dtAccount.Rows(rowNum).Item("AccType") = "E" Then
                rdbExpense.Checked = True
            ElseIf dtAccount.Rows(rowNum).Item("AccType") = "I" Then
                rdbIncome.Checked = True
            ElseIf dtAccount.Rows(rowNum).Item("AccType") = "L" Then
                rdbLiability.Checked = True
            End If
        Else
            rdbAsset.Checked = False
            rdbExpense.Checked = False
            rdbIncome.Checked = False
            rdbLiability.Checked = False
        End If
        lblCompany.Text = "Recorded On : " & dtAccount.Rows(rowNum).Item("AddOn") & "" 'objAccount.AddOn
        lblBy.Text = "Recorded By : " & dtAccount.Rows(rowNum).Item("AddBy") & "" 'objAccount.AddBy
        lblToolTip.Text = "Close Form"
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
        'mskCode.Text = aEmptyCode
        mskCode.Text = ""
        mskCode.Mask = aMaskCode
        txtDesc1.Text = ""
        txtDesc2.Text = ""
        txtDesc3.Text = ""
        rdbAsset.Checked = False
        rdbExpense.Checked = False
        rdbIncome.Checked = False
        rdbLiability.Checked = False
        rdbActive.Checked = False
        rdbClosed.Checked = False
        dtpOpenDate.Value = Format(Now.Date, "dd-MMM-yyyy")
        dtpCloseDate.Value = Format(Now.Date, "dd-MMM-yyyy")
    End Sub

    Sub LoadRefValues()

        objAccount.Code = aCode2Str(mskCode.Text)
        objAccount.LoadCode()

        txtDesc1.Text = objAccount.Description
        txtDesc2.Text = objAccount.Desc2
        txtDesc3.Text = objAccount.Desc3
        If objAccount.Status = "A" Then
            rdbActive.Checked = True
        ElseIf objAccount.Status = "C" Then
            rdbClosed.Checked = True
        End If
        dtpOpenDate.Text = objAccount.OpenDate
        dtpCloseDate.Text = objAccount.CloseDate
        If objAccount.AccType = "A" Then
            rdbAsset.Checked = True
        ElseIf objAccount.AccType = "E" Then
            rdbExpense.Checked = True
        ElseIf objAccount.AccType = "I" Then
            rdbIncome.Checked = True
        ElseIf objAccount.AccType = "L" Then
            rdbLiability.Checked = True
        Else
            rdbAsset.Checked = False
            rdbExpense.Checked = False
            rdbIncome.Checked = False
            rdbLiability.Checked = False
        End If
        lblCompany.Text = "Recorded On : " & objAccount.AddOn
        lblBy.Text = "Recorded By : " & objAccount.AddBy
        lblToolTip.Text = "Close Form"
    End Sub

    Private Sub mskCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mskCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub rdbActive_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rdbActive.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
            dtpOpenDate.Focus()
        End If
    End Sub

    Private Sub rdbAsset_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rdbAsset.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
            rdbActive.Focus()
        End If
    End Sub

    Private Sub rdbClosed_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rdbClosed.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
            dtpOpenDate.Focus()
        End If
    End Sub

    Private Sub rdbExpense_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rdbExpense.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
            rdbActive.Focus()
        End If
    End Sub

    Private Sub rdbIncome_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rdbIncome.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
            rdbActive.Focus()
        End If
    End Sub

    Private Sub rdbLiability_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rdbLiability.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
            rdbActive.Focus()
        End If
    End Sub

    Private Sub txtDesc1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDesc1.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtDesc2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDesc2.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtDesc3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDesc3.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
            rdbAsset.Focus()
        End If
    End Sub

    Private Sub dtpCloseDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpCloseDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub dtpOpenDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpOpenDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub mskCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mskCode.Validating

    End Sub

    Private Sub btnTop_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTop.Click
        If rowNum > 0 Then
            btnTop.Enabled = False
            btnPrevious.Enabled = False
            btnNext.Enabled = True
            btnBottom.Enabled = True
            Call LoadValue()
            lblToolTip.Text = "Move To First Record"
            Call SetButtonPrinciple()
            Call SetButton()
        End If
    End Sub

    Private Sub btnBottom_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBottom.Click
        If rowNum > 0 Then
            rowNum = dtAccount.Rows.Count - 1
            btnBottom.Enabled = False
            btnNext.Enabled = False
            btnTop.Enabled = True
            btnPrevious.Enabled = True
            Call LoadValue()
            lblToolTip.Text = "Move To Last Record"

            Call SetButtonPrinciple()
            Call SetButton()
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        lblToolTip.Text = "Close Form"
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        lblToolTip.Text = "Delete Current Record"
        Opt = MsgBox("Are You Sure To Delete Current Record", MsgBoxStyle.YesNo)
        If Opt = MsgBoxResult.Yes Then
            objAccount.Code = aCode2Str(mskCode.Text)
            objAccount.DelCode()
            Call ClearAll()
            If rowNum > 0 Then
                rowNum = rowNum - 1
                Call LoadValue()
            Else
                MsgBox("No Record Found", MsgBoxStyle.Information)
            End If
        End If
        dtAccount = objAccount.LoadAllCodes()
        rowNum = dtAccount.Rows.Count - 1
        Call LoadValue()
        'rowNum = dtAccount.Rows.Count - 1
        Call MenuGridLoad(mMenuStr)
        rowNum = dtAccount.Rows.Count - 1
        Call SetButtonPrinciple()
        Call SetButtonPrinciple()
        Call SetButton()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        lblToolTip.Text = "Edit Current Record"
        EditMode = True
        AddMode = False
        Flag = False
        mskCode.Enabled = True
        Call SetEntryMode()
        GpStatus.Enabled = True
        GpACDef.Enabled = True
        mskCode.Enabled = False
        txtDesc1.Focus()
        btnEdit.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        dtAccount = objAccount.LoadAllCodes()
        rowNum = dtAccount.Rows.Count - 1
        AddMode = False
        EditMode = False
        mskCode.Enabled = False
        lblToolTip.Text = "Cancel Last Action"
        Opt = MsgBox("Do you wish to Abort ?", MsgBoxStyle.YesNo)
        If Opt = MsgBoxResult.No Then
            mskCode.Focus()
            Exit Sub
        End If
        Call LoadValue()
        Flag = True
        Call SetEntryMode()
        GpACDef.Enabled = False
        btnSave.Enabled = False
        btnCancel.Enabled = False
        GpStatus.Enabled = False
        'rowNum = dtAccount.Rows.Count - 1
        Call MenuGridLoad(mMenuStr)
        rowNum = dtAccount.Rows.Count - 1
        Call SetButtonPrinciple()
        Call SetButtonPrinciple()
        Call SetButton()
        AddMode = False
        EditMode = False
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        lblToolTip.Text = "Save Current Record"
        If CheckValidation() Then
            objAccount.getConnection()
            objAccount.BeginTransaction()
            SetData()
            If AddMode Then
                Try
                    objAccount.SaveACCode()
                    Call btnAdd_Click(Nothing, Nothing)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    objAccount.RollBack()
                End Try
            ElseIf EditMode Then
                Try
                    objAccount.EditACCode()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    objAccount.RollBack()
                End Try
                Flag = True
                Call SetEntryMode()
                GpStatus.Enabled = False
                GpACDef.Enabled = False
                btnSave.Enabled = False
                btnCancel.Enabled = False
                dtAccount = objAccount.LoadAllCodes()
                rowNum = dtAccount.Rows.Count - 1
                Call LoadValue()
            End If
            objAccount.CommitTransction()
        End If
        Call MenuGridLoad(mMenuStr)
        rowNum = dtAccount.Rows.Count - 1
        Call SetButtonPrinciple()
        Call SetButton()
    End Sub

    Private Sub SetData()
        objAccount.Code = aCode2Str(Me.mskCode.Text)
        objAccount.Description = Me.txtDesc1.Text
        objAccount.Desc2 = Me.txtDesc2.Text
        objAccount.Desc3 = Me.txtDesc3.Text

        If rdbActive.Checked = True Then
            objAccount.Status = "A"
        ElseIf rdbClosed.Checked = True Then
            objAccount.Status = "C"
        End If
        objAccount.OpenDate = dtpOpenDate.Value.ToString("yyyy-MM-dd")
        objAccount.CloseDate = dtpCloseDate.Value.ToString("yyyy-MM-dd")
        If rdbAsset.Checked = True Then
            objAccount.AccType = "A"
        ElseIf rdbExpense.Checked = True Then
            objAccount.AccType = "E"
        ElseIf rdbIncome.Checked = True Then
            objAccount.AccType = "I"
        ElseIf rdbLiability.Checked = True Then
            objAccount.AccType = "L"
        End If
        objAccount.Transmit = "F"
        If AddMode Then
            'objAccount.AddOn = GetDate(SySDate, "yyyy-MM-dd")
            objAccount.AddOn = SySDate
            objAccount.AddBy = SysUserID
            'objBranch.AddBy = SysUserID
        ElseIf EditMode Then
            'objAccount.EditOn = SySDate
            objAccount.AddOn = SySDate
            objAccount.EditBy = SysUserID
            'objBranch.AddBy = SysUserID
        End If
    End Sub

    Private Function CheckValidation() As Boolean
        If mskCode.Text = aEmptyCode Then
            MsgBox("Please enter Account Code.", MsgBoxStyle.Information, SysCompany)
            mskCode.Focus()
            Return False
        ElseIf txtDesc1.Text = "" Then
            MsgBox("Please enter Description", MsgBoxStyle.Information, SysCompany)
            txtDesc1.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        AddMode = True
        EditMode = False
        Flag = False
        mskCode.Enabled = True
        Call SetEntryMode()
        btnSave.Enabled = True
        btnCancel.Enabled = True
        EmptyControls(Me)
        Call ClearAll()
        GpStatus.Enabled = True
        GpACDef.Enabled = True
        lblCompany.Text = "Recorded On " & Format(SySDate, "dd-MMM-yyyy")
        lblToolTip.Text = "Add New Record"
        lblBy.Text = "Recorded By : " & SysUserID
        mskCode.SelectionStart = 0
        mskCode.Focus()
    End Sub

    Private Sub btnFind_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Dim mTCode As String
        dtAccount = objAccount.LoadAllCodes
        mTCode = dtAccount.Rows(0).Item("Code")
        frmRPT_List.mCode = mTCode
        mTCode = dtAccount.Rows(dtAccount.Rows.Count - 1).Item("Code")
        frmRPT_List.mECode = mTCode
        frmRPT_List.mReport = 1
        'SetUp.mOrder = 0
        mOrder = 0
        frmRPT_List.RepName = "GLCodeLevel3.rpt"
        frmRPT_List.TableName = "Codes"
        frmRPT_List.Fld1 = "Code"
        frmRPT_List.Fld2 = "Description"
        frmRPT_List.SortFld1 = "Code"
        frmRPT_List.SortFld2 = "Description"
        lblToolTip.Text = "Preview Record(s)"
        frmRPT_List.rptPreview(sender, e)
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        dtAccount = objAccount.LoadAllCodes()
        Call MenuGridLoad(mMenuStr)
        rowNum = dtAccount.Rows.Count - 1
        Call LoadValue()
        lblToolTip.Text = "Refresh Records"
    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim frmList As New frmRPT_List
        If rowNum > 0 Then
            lblToolTip.Text = "Print Record(s)"
            'pPara = 2
            pPara = 28
            Call SetButtonPrinciple()
            Call SetButton()
            frmList.ShowDialog()
        End If
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        If rowNum > 0 Then
            rowNum = rowNum - 1
            btnNext.Enabled = True
            btnBottom.Enabled = True
            btnPrevious.Enabled = True
            btnTop.Enabled = True
            Call SetButtonPrinciple()
            Call SetButton()
        Else
            rowNum = 0
            btnTop.Enabled = False
            btnPrevious.Enabled = False
            btnNext.Enabled = True
            btnBottom.Enabled = True
        End If
        LoadValue()
        lblToolTip.Text = "Move To Previous Record"
    End Sub

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If rowNum < dtAccount.Rows.Count - 1 Then
            rowNum = rowNum + 1
            btnNext.Enabled = True
            btnBottom.Enabled = True
            btnPrevious.Enabled = True
            btnTop.Enabled = True
            Call SetButtonPrinciple()
            Call SetButton()
        Else
            rowNum = dtAccount.Rows.Count - 1
            btnNext.Enabled = False
            btnBottom.Enabled = False
            btnPrevious.Enabled = True
            btnTop.Enabled = True
        End If
        LoadValue()
        lblToolTip.Text = "Move To Next Record"
    End Sub

    Private Sub btnView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnView.Click
        frmSRH_ACCode.ShowDialog()
        If frmSRH_ACCode.SetFilter = True Then
            If FltAll Then
                objAccount.Level = "0"
            ElseIf FltFirst Then
                objAccount.Level = "1"
            ElseIf FltSecond Then
                objAccount.Level = "2"
            ElseIf FltThird Then
                objAccount.Level = "3"
            End If
        End If
        dtAccount = objAccount.LoadSelectCodes()
        rowNum = dtAccount.Rows.Count - 1
        Call LoadValue()
        btnExit.Focus()
        Call SetButtonPrinciple()
        Call SetButton()
    End Sub

    Private Sub txtDesc1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDesc1.LostFocus
        If Trim(txtDesc1.Text) <> "" Then
            txtDesc1.Text = objProper.Proper(txtDesc1.Text)
        End If
    End Sub

    Private Sub txtDesc2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDesc2.LostFocus
        If Trim(txtDesc2.Text) <> "" Then
            txtDesc2.Text = objProper.Proper(txtDesc2.Text)
        End If
    End Sub

    Private Sub txtDesc3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDesc3.LostFocus
        If Trim(txtDesc3.Text) <> "" Then
            txtDesc3.Text = objProper.Proper(txtDesc3.Text)
        End If
    End Sub

    Private Sub mskCode_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles mskCode.MaskInputRejected

    End Sub

    Private Sub mskCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskCode.Validated
        If Not (AddMode Or EditMode) Then Exit Sub
        If Not mskCode.Text = aEmpMaskCode Then
            If Not (Len(aCode2Str(mskCode.Text)) = aP1L Or Len(aCode2Str(mskCode.Text)) = aP1L + aP2L + aP3L Or Len(aCode2Str(mskCode.Text)) = aCodeL) Then
                MsgBox("Invalid Code Length", vbInformation, SysCompany)
                mskCode.Text = aEmptyCode
                mskCode.Focus()
                'e.Cancel = True
                Exit Sub
            End If
            If Not mskCode.Text = aEmpMaskCode Then
                If Not aCtrlExist(aCode2Str(mskCode.Text)) Then
                    MsgBox("Control Code Of This Code Does Not Exists", vbInformation, SysCompany)
                    mskCode.Mask = aMaskCode
                    mskCode.Focus()
                    mskCode.Text = ""
                    'e.Cancel = True
                End If
            End If
            mSQL = "SELECT Code FROM Codes WHERE Code = '" & aCode2Str(mskCode.Text) & "'"
            If Found(mSQL) Then
                MsgBox("Code Allready Exists", vbCritical, SysCompany)
                mskCode.Text = aEmptyCode
                mskCode.Focus()
                'e.Cancel = True
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

    Private Sub btnPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPost.Click
        Call SetButtonPrinciple()
        Call SetButton()
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
                dtAccount = objAccount.LoadAllCodes()
                If rowNum > 0 Then
                    Call LoadValue()
                End If
                If rowNum = 0 Then
                    btnTop.Enabled = False
                    btnPrevious.Enabled = False
                    btnNext.Enabled = True
                    btnBottom.Enabled = True
                ElseIf rowNum = dtAccount.Rows.Count - 1 Then
                    btnTop.Enabled = True
                    btnPrevious.Enabled = True
                    btnNext.Enabled = False
                    btnBottom.Enabled = False
                ElseIf rowNum <> 0 And rowNum < dtAccount.Rows.Count - 1 Then
                    btnTop.Enabled = True
                    btnPrevious.Enabled = True
                    btnNext.Enabled = True
                    btnBottom.Enabled = True
                End If
            End If
        End If
    End Sub
    Private Sub MenuGridLoad(ByVal mQuery As String)
        Dim mcol As Integer
        Dim mcolName As String
        Dim header_style As New DataGridViewCellStyle

        Try
            If mQuery <> "" And mQuery <> Nothing Then
                dtLookup = Lookup(mQuery).Tables(0)
                Me.GVHelp.DataSource = dtLookup.DefaultView
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

    Private Sub frmAccounts_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        mMenuStr = "Select ROW_NUMBER()OVER (ORDER BY Code) AS Row,Code,Description,AccType,Status,CONVERT(varchar(13),OpenDate,106) As OpenDate from Codes"
        Call MenuGridLoad(mMenuStr)
    End Sub
End Class