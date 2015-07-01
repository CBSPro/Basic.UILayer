Imports System.Data
Imports System.Data.SqlClient
'Imports Basic.Constants
Imports Basic.Reports
Imports Basic.DAL
Imports Basic.DAL.Utils

Public Class frmBranch
    Inherits System.Windows.Forms.Form

    Dim objBranch As New cBranch
    Dim objProper As New cProper

    Dim mAdd As Boolean
    Dim mEdit As Boolean
    Dim mDelete As Boolean
    Dim mPost As Boolean
    Dim mPrint As Boolean

    Dim PODS As New DataSet
    Dim objRow As Data.DataRow
    Dim ObjFind As Grid_Help
    Dim tableName As String = "Branch"
    Dim strFind As String
    Dim Flag As Boolean
    Dim AddMode As Boolean
    Dim EditMode As Boolean
    Dim mBrCode As String
    Dim mMenuStr As String
    Dim dtBranch As New DataTable
    Dim rowNum As Integer
    Dim dtRefBranch As New DataTable
    Dim rowNum1 As Integer
    Dim dtLookup As DataTable
    Dim vColumn As Integer
    Private sqlquery As String
    Private strPKValue As String

    Private Sub frmBranch_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Constants.ProjConst.mBranch = False
        '  mBranch = False
    End Sub


    Private Sub frmBranch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.MdiParent = frmMdi
        GpData.Enabled = False
        Flag = True
        Call SetEntryMode()
        btnSave.Enabled = False
        btnCancel.Enabled = False
        dtBranch = objBranch.LoadAllBranch()
        dtLookup = objBranch.LoadAllBranch()
        mMenuStr = "Select ROW_NUMBER() OVER (ORDER BY BrCode) AS Row,BrCode,BrName,Addr1,Addr2,Addr3 " & _
                " From Branch Order By BrCode "
        Call MenuGridLoad(mMenuStr)
        rowNum = dtBranch.Rows.Count - 1
        If rowNum >= 0 Then
            'rowNum = dtBranch.Rows.Count - 1
            Call LoadValue()
        End If
        btnExit.Focus()
        txtBrName.Focus()
        btnAdd.Enabled = True
        btnPost.Enabled = False
        btnView.Enabled = True
        btnStatus(False)
        Call SetFormSecurity(Me)
        Call SetButtonsSurity(Me)
        Call SetButtonPrinciple()
        Call SetButton()
        If mAdd = True Then
            btnAdd.Enabled = True
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        lblToolTip.Text = "Close Form"
        Me.Close()
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

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        AddMode = True
        EditMode = False
        txtBrCode.Enabled = False
        Flag = False
        Call SetEntryMode()
        btnSave.Enabled = True
        btnCancel.Enabled = True
        Call ClearAll()
        GpData.Enabled = True
        txtBrCode.Text = objBranch.GenBrCode
        lblCompany.Text = "Recorded On " & Format(Constants.ProjConst.SySDate, "dd-MMM-yyyy")
        lblToolTip.Text = "Add New Record"
        lblBy.Text = "Recorded By : " & Constants.ProjConst.SysUserID

        'lblBy.Text = "Recorded By : " & SysUserID
        dtpOpenDate.Focus()
        btnSave.Enabled = True
        btnCancel.Enabled = True
        EmptyControls(Me)
        txtBrName.Focus()
    End Sub

    Sub ClearAll()
        txtBrCode.Text = ""
        txtBrName.Text = ""
        txtAddr1.Text = ""
        txtAddr2.Text = ""
        txtAddr3.Text = ""
        txtPhone1.Text = ""
        txtPhone2.Text = ""
        txtFax.Text = ""
        txtEmail.Text = ""
        dtpOpenDate.Value = Constants.ProjConst.SySDate
        'dtpOpenDate.Value = S
    End Sub

    Sub LoadValue()
        If AddMode = True Or EditMode = True Then
            dtBranch = objBranch.LoadAllBranch()
            rowNum = dtBranch.Rows.Count - 1
        End If
        Try
            txtBrCode.Text = Trim$(dtBranch.Rows(rowNum).Item("BrCode") & "")    'objBranch.BrCode
            txtBrName.Text = Trim$(dtBranch.Rows(rowNum).Item("BrName") & "")    'objBranch.BrName
            txtAddr1.Text = Trim$(dtBranch.Rows(rowNum).Item("Addr1") & "")      'objBranch.Addr1
            txtAddr2.Text = Trim$(dtBranch.Rows(rowNum).Item("Addr2") & "")      'objBranch.Addr2
            txtAddr3.Text = Trim$(dtBranch.Rows(rowNum).Item("Addr3") & "")      'objBranch.Addr3
            txtPhone1.Text = Trim$(dtBranch.Rows(rowNum).Item("Phone1") & "")    'objBranch.Phone1
            txtPhone2.Text = Trim$(dtBranch.Rows(rowNum).Item("Phone2") & "")    'objBranch.Phone2
            txtFax.Text = Trim$(dtBranch.Rows(rowNum).Item("Fax") & "")          'objBranch.Fax
            txtEmail.Text = Trim$(dtBranch.Rows(rowNum).Item("Email") & "")      'objBranch.Email
            dtpOpenDate.Text = Trim$(dtBranch.Rows(rowNum).Item("Opdate") & "")  'objBranch.Opdate
            lblCompany.Text = "Recorded On : " & dtBranch.Rows(rowNum).Item("AddOn") & "" 'objBranch.AddOn
            lblBy.Text = "Recorded By : " & dtBranch.Rows(rowNum).Item("AddBy") & ""      'objBranch.AddBy
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        lblToolTip.Text = "Save Current Record"
        If CheckValidation() Then
            objBranch.getConnection()
            objBranch.BeginTransaction()
            SetData()
            If AddMode Then
                Try
                    objBranch.SaveBranch()
                    Call btnAdd_Click(Nothing, Nothing)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    objBranch.RollBack()
                End Try
            ElseIf EditMode Then
                EditMode = False
                Try
                    objBranch.EditBranch()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    objBranch.RollBack()
                End Try
                Flag = True
                Call SetEntryMode()
                GpData.Enabled = False
                btnSave.Enabled = False
                btnCancel.Enabled = False
            End If
            objBranch.CommitTransction()
        End If
        btnView.Enabled = False
        btnPost.Enabled = False
        dtBranch = objBranch.LoadAllBranch()
        Call MenuGridLoad(mMenuStr)
        rowNum = dtBranch.Rows.Count - 1
        Call SetButtonPrinciple()
        Call SetButton()
    End Sub

    Private Sub SetData()
        objBranch.BrCode = Me.txtBrCode.Text
        objBranch.BrName = Me.txtBrName.Text
        objBranch.Addr1 = Me.txtAddr1.Text
        objBranch.Addr2 = Me.txtAddr2.Text
        objBranch.Addr3 = Me.txtAddr3.Text
        objBranch.Phone1 = Me.txtPhone1.Text
        objBranch.Phone2 = Me.txtPhone2.Text
        objBranch.Fax = Me.txtFax.Text
        objBranch.Email = Me.txtEmail.Text
        objBranch.Opdate = Basic.DAL.Utils.GetDate(Me.dtpOpenDate.Text, "dd-MMM-yyyy")
        If AddMode Then
            objBranch.AddOn = Constants.ProjConst.SySDate
            objBranch.AddBy = Constants.ProjConst.SysUserID
        ElseIf EditMode Then
            objBranch.EditOn = Constants.ProjConst.SySDate
            objBranch.AddBy = Constants.ProjConst.SysUserID
        End If
    End Sub

    Private Function CheckValidation() As Boolean
        If txtBrName.Text = "" Then
            MsgBox("Please enter Branch Name.", MsgBoxStyle.Information, Constants.ProjConst.SysCompany)
            txtBrName.Focus()
            Return False
        ElseIf txtAddr1.Text = "" Then
            MsgBox("Please enter Address", MsgBoxStyle.Information, Constants.ProjConst.SysCompany)
            txtAddr1.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        lblToolTip.Text = "Edit Current Record"
        EditMode = True
        AddMode = False
        Flag = False
        Call SetEntryMode()
        GpData.Enabled = True
        txtBrCode.Enabled = False
        dtpOpenDate.Focus()
        btnSave.Enabled = True
        btnCancel.Enabled = True
    End Sub

    Private Sub btnBottom_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBottom.Click
        If rowNum > 0 Then
            rowNum = dtBranch.Rows.Count - 1
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

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If rowNum < dtBranch.Rows.Count - 1 Then
            rowNum = rowNum + 1
            btnNext.Enabled = True
            btnBottom.Enabled = True
            btnPrevious.Enabled = True
            btnTop.Enabled = True
            Call SetButtonPrinciple()
            Call SetButton()
        Else
            rowNum = dtBranch.Rows.Count - 1
            btnNext.Enabled = False
            btnBottom.Enabled = False
            btnPrevious.Enabled = True
            btnTop.Enabled = True
        End If
        LoadValue()
        lblToolTip.Text = "Move To Next Record"
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

    Private Sub btnTop_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTop.Click
        rowNum = 0
        btnTop.Enabled = False
        btnPrevious.Enabled = False
        btnNext.Enabled = True
        btnBottom.Enabled = True
      
        Call LoadValue()
        lblToolTip.Text = "Move To First Record"
        Call SetButtonPrinciple()
        Call SetButton()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Dim opt As MsgBoxResult

        AddMode = False
        EditMode = False
        lblToolTip.Text = "Cancel Last Action"
        Opt = MsgBox("Do you wish to Abort ?", MsgBoxStyle.YesNo)
        If Opt = MsgBoxResult.No Then
            txtBrCode.Focus()
            Exit Sub
        End If
        dtBranch = objBranch.LoadAllBranch()
        rowNum = dtBranch.Rows.Count - 1
        If rowNum >= 0 Then
            'rowNum = dtBranch.Rows.Count - 1
            Call LoadValue()
        End If
        Flag = True
        Call SetEntryMode()
        GpData.Enabled = False
        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnView.Enabled = False
        btnPost.Enabled = False
        'ClearAll()
        Call MenuGridLoad(mMenuStr)
        rowNum = dtBranch.Rows.Count - 1
        Call SetButtonPrinciple()
        Call SetButton()
        AddMode = False
        EditMode = False
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        If rowNum > 0 Then
            lblToolTip.Text = "Refresh Records"
            rowNum = dtBranch.Rows.Count - 1
            Call LoadValue()
            Call MenuGridLoad(mMenuStr)
            'rowNum = dtBranch.Rows.Count - 1
            Call SetButtonPrinciple()
            Call SetButton()
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        lblToolTip.Text = "Delete Current Record"
        Opt = MsgBox("Are You Sure To Delete Current Record", MsgBoxStyle.YesNo)
        If Opt = MsgBoxResult.Yes Then
            objBranch.BrCode = Trim(txtBrCode.Text)
            objBranch.DelBranch()
            Call ClearAll()
            If rowNum > 0 Then
                rowNum = rowNum - 1
                Call LoadValue()
            Else
                MsgBox("No Record Found", MsgBoxStyle.Information)
            End If
            Call MenuGridLoad(mMenuStr)
        End If

        Call SetButtonPrinciple()
        Call SetButton()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim frmList As New frmRPT_List
        lblToolTip.Text = "Print Record(s)"
        Constants.ProjConst.pPara = 1
        frmList.ShowDialog()
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click

        frmRPT_List.mReport = 0
        frmRPT_List.RepName = "Branches.Rpt"
        frmRPT_List.TableName = "Branch"
        frmRPT_List.SortFld1 = "BrCode"
        frmRPT_List.SortFld2 = "BrName"
        frmRPT_List.mCode = Trim(txtBrCode.Text)
        'SetUp.mOrder = 0
        mOrder = 0
        frmRPT_List.StrFilter = "1=1"
        lblToolTip.Text = "Preview Record(s)"
        frmRPT_List.rptPreview(sender, e)
    End Sub

    Sub LoadRefValues()

        dtRefBranch = objBranch.LoadBranch()
        rowNum1 = dtRefBranch.Rows.Count - 1
        If rowNum1 >= 0 Then
            rowNum1 = 0
            txtBrCode.Text = dtRefBranch.Rows(rowNum1).Item("BrCode") & "" 'objBranch.BrCode
            txtBrName.Text = dtRefBranch.Rows(rowNum1).Item("BrName") & "" 'objBranch.BrName
            txtAddr1.Text = dtRefBranch.Rows(rowNum1).Item("Addr1") & ""  'objBranch.Addr1
            txtAddr2.Text = dtRefBranch.Rows(rowNum1).Item("Addr2") & "" 'objBranch.Addr2
            txtAddr3.Text = dtRefBranch.Rows(rowNum1).Item("Addr3") & "" 'objBranch.Addr3
            txtPhone1.Text = dtRefBranch.Rows(rowNum1).Item("Phone1") & "" 'objBranch.Phone1
            txtPhone2.Text = dtRefBranch.Rows(rowNum1).Item("Phone2") & "" 'objBranch.Phone2
            txtFax.Text = dtRefBranch.Rows(rowNum1).Item("Fax") & "" 'objBranch.Fax
            txtEmail.Text = dtRefBranch.Rows(rowNum1).Item("Email") & "" 'objBranch.Email
            dtpOpenDate.Text = dtRefBranch.Rows(rowNum1).Item("Opdate") & "" 'objBranch.Opdate
            lblCompany.Text = "Recorded On : " & dtRefBranch.Rows(rowNum1).Item("AddOn") & "" 'objBranch.AddOn
            lblBy.Text = "Recorded By : " & dtRefBranch.Rows(rowNum1).Item("AddBy") & "" 'objBranch.AddBy
        End If
        lblToolTip.Text = "Close Form"

    End Sub

    Private Sub txtBrName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBrName.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtEmail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmail.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtFax_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFax.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtPhone1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPhone1.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtPhone2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPhone2.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub dtpOpenDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpOpenDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub btnCancel_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.GotFocus
        lblToolTip.Text = "Cancel Last Action"
    End Sub

    Private Sub btnAdd_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.GotFocus
        lblToolTip.Text = "Add New Record"
    End Sub

    Private Sub btnBottom_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBottom.GotFocus
        lblToolTip.Text = "Move To Last Record"
    End Sub

    Private Sub btnDelete_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.GotFocus
        lblToolTip.Text = "Delete Current Record"
    End Sub

    Private Sub btnEdit_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.GotFocus
        lblToolTip.Text = "Edit Current Record"
    End Sub

    Private Sub btnExit_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.GotFocus
        lblToolTip.Text = "Close Form"
    End Sub

    Private Sub btnFind_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFind.GotFocus
        lblToolTip.Text = "Find A Record"
    End Sub

    Private Sub btnNext_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNext.GotFocus
        lblToolTip.Text = "Move To Next Record"
    End Sub

    Private Sub btnPrevious_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrevious.GotFocus
        lblToolTip.Text = "Move To Previous Record"
    End Sub

    Private Sub btnPrint_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrint.GotFocus
        lblToolTip.Text = "Print Record(s)"
    End Sub

    Private Sub btnRefresh_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRefresh.GotFocus
        lblToolTip.Text = "Refresh Records"
    End Sub

    Private Sub btnSave_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.GotFocus
        lblToolTip.Text = "Save Current Record"
    End Sub

    Private Sub btnTop_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTop.GotFocus
        lblToolTip.Text = "Move To First Record"
    End Sub

    Private Sub txtAddr1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAddr1.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtAddr2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAddr2.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtAddr3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAddr3.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtBrName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBrName.LostFocus
        If Trim(txtBrName.Text) <> "" Then
            txtBrName.Text = objProper.Proper(txtBrName.Text)
        End If
    End Sub

    Private Sub txtAddr1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAddr1.LostFocus
        If Trim(txtAddr1.Text) <> "" Then
            txtAddr1.Text = objProper.Proper(txtAddr1.Text)
        End If
    End Sub

    Private Sub txtAddr2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAddr2.LostFocus
        If Trim(txtAddr2.Text) <> "" Then
            txtAddr2.Text = objProper.Proper(txtAddr2.Text)
        End If
    End Sub

    Private Sub txtAddr3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAddr3.LostFocus
        If Trim(txtAddr3.Text) <> "" Then
            txtAddr3.Text = objProper.Proper(txtAddr3.Text)
        End If
    End Sub

    Private Sub GpData_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GpData.Enter

    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click

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
        End Try
    End Sub

    Private Sub GVHelp_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GVHelp.CellClick
        vColumn = e.ColumnIndex
    End Sub

    Private Sub GVHelp_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GVHelp.CellContentClick

    End Sub

    Private Sub GVHelp_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GVHelp.CellEnter
        GVHelp.Cursor = Cursors.Default
    End Sub

    Private Sub GVHelp_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVHelp.DoubleClick
        If AddMode <> True And EditMode <> True Then
            If GVHelp.RowCount <> 0 Then
                Me.sqlquery = Me.GVHelp.Item(0, GVHelp.CurrentRow.Index).Value
                rowNum = sqlquery - 1
                'Call LoadMaster()
                objBranch.BrCode = Trim(txtBrCode.Text)
                dtBranch = objBranch.LoadAllBranch
                If rowNum >= 0 Then
                    Call LoadValue()
                End If
                If rowNum = 0 Then
                    btnTop.Enabled = False
                    btnPrevious.Enabled = False
                    btnNext.Enabled = True
                    btnBottom.Enabled = True
                ElseIf rowNum = dtBranch.Rows.Count - 1 Then
                    btnTop.Enabled = True
                    btnPrevious.Enabled = True
                    btnNext.Enabled = False
                    btnBottom.Enabled = False
                ElseIf rowNum <> 0 And rowNum < dtBranch.Rows.Count - 1 Then
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

    Private Sub frmBranch_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        mMenuStr = "Select ROW_NUMBER()OVER (ORDER BY BrCode) AS Row,BrCode,BrName,Addr1,Addr2,Addr3 " & _
                       " From Branch Order By BrCode "
        Call MenuGridLoad(mMenuStr)
    End Sub
End Class