Imports System.Data
Imports System.Data.SqlClient
Imports Basic.Constants.ProjConst
Imports Basic.DAL
Imports Basic.Reports
Imports Basic.DAL.Utils

Public Class FrmFinanInfo
    Dim objFinanInfo As New cFinanInfo
    Dim dtAccount As New DataTable

    'Dim objProper As New cProper

    Dim mAdd As Boolean
    Dim mEdit As Boolean
    Dim mDelete As Boolean
    Dim mPost As Boolean
    Dim mPrint As Boolean

    Dim PODS As New DataSet
    Dim objRow As Data.DataRow
    Dim ObjFind As Grid_Help
    Dim tableName As String = "FinType"
    Dim strFind As String
    Dim mOpen As String
    Dim Flag As Boolean
    Dim mMenuStr As String
    Dim AddMode As Boolean
    Dim EditMode As Boolean

    Dim rowNum As Integer
    Dim dtLookup As DataTable
    Dim vColumn As Integer
    Private sqlquery As String
    Private strPKValue As String

    Private Sub FrmFinanInfo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.MdiParent = frmMdi
        GpData.Enabled = False
        Flag = True
        Call SetAccParam()
        Call SetEntryMode()


        dtAccount = objFinanInfo.LoadAllCodes()
        dtLookup = objFinanInfo.LoadAllCodes()
        mMenuStr = "Select ROW_NUMBER()OVER (ORDER BY FinTypeCode) AS Row,FinTypeCode,TypeName,TypeDescription" & _
                    " from FinType"
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
                        If GVHelp.Columns(mcol).Name = "TypeDescription" Then
                            GVHelp.Columns(mcol).Width = 160
                        ElseIf GVHelp.Columns(mcol).Name <> "TypeName" And GVHelp.Columns(mcol).Name <> "TaxRate" And GVHelp.Columns(mcol).Name <> "Posted" Then
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

        txtDescrip.Text = ""
        txtName.Text = ""
        txtSearch.Text = ""
        txtsysCode.Text = ""

    End Sub



    Private Sub txtDescrip_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtDescrip.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtName_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtsysCode_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtsysCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub btnTop_Click(sender As Object, e As System.EventArgs) Handles btnTop.Click
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
    Private Sub FrmFinanInfo_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Constants.ProjConst.mFinanInfo = False

    End Sub
    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        lblToolTip.Text = "Close Form"
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        AddMode = True
        EditMode = False
        Flag = False
        ' mskCode.Enabled = True
        Call SetEntryMode()
        btnSave.Enabled = True
        btnCancel.Enabled = True
        EmptyControls(Me)
        Call ClearAll()
        GpData.Enabled = True
        ' GpACDef.Enabled = True
        Me.txtsysCode.Text = objFinanInfo.GenFinTypeCode()
        lblCompany.Text = "Recorded On " & Format(SySDate, "dd-MMM-yyyy")
        lblToolTip.Text = "Add New Record"
        lblBy.Text = "Recorded By : " & SysUserID
       
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        lblToolTip.Text = "Edit Current Record"
        EditMode = True
        AddMode = False
        Flag = False
        ' mskCode.Enabled = True
        Call SetEntryMode()
        GpData.Enabled = True

        ' mskCode.Enabled = False
        txtName.Focus()
        btnEdit.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Opt = MsgBox("Do you wish to Abort ?", MsgBoxStyle.YesNo)
        If Opt = MsgBoxResult.No Then
            txtName.Focus()
            Exit Sub

        Else
            Call SetEntryMode()
            Call ClearAll()
            Call SetEntryMode()
            GpData.Enabled = False
            btnSave.Enabled = False
            btnCancel.Enabled = False
            btnAdd.Enabled = True
            btnView.Enabled = True
            btnExit.Enabled = True
            Call SetButtonPrinciple()
            Call SetButton()
            AddMode = False
            EditMode = False
        End If
    End Sub

    Sub LoadValue()

        txtsysCode.Text = dtAccount.Rows(rowNum).Item("FinTypeCode")
        txtName.Text = dtAccount.Rows(rowNum).Item("TypeName") & "" 'objFinanInfo.Description
        txtDescrip.Text = dtAccount.Rows(rowNum).Item("TypeDescription") & "" 'objFinanInfo.Desc2


        lblCompany.Text = "Recorded On : " & dtAccount.Rows(rowNum).Item("AddOn") & "" 'objFinanInfo.AddOn
        lblBy.Text = "Recorded By : " & dtAccount.Rows(rowNum).Item("AddBy") & "" 'objFinanInfo.AddBy
        lblToolTip.Text = "Close Form"
    End Sub
    Private Function CheckValidation() As Boolean
        If txtName.Text = "" Then
            MsgBox("Please enter Name.", MsgBoxStyle.Information, SysCompany)
            txtName.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub SetData()
        objFinanInfo.FinTypeCode = Me.txtsysCode.Text
        objFinanInfo.TypeDescription = Me.txtDescrip.Text
        objFinanInfo.TypeName = Me.txtName.Text


      
       
        objFinanInfo.transfer = "F"
        If AddMode Then
            'objFinanInfo.AddOn = GetDate(SySDate, "yyyy-MM-dd")
            objFinanInfo.AddOn = "2015/06/30" 'SySDate
            objFinanInfo.AddBy = SysUserID
            'objBranch.AddBy = SysUserID
        ElseIf EditMode Then
            'objFinanInfo.EditOn = SySDate
            objFinanInfo.AddOn = "2015/06/30" 'SySDate
            objFinanInfo.EditBy = SysUserID
            'objBranch.AddBy = SysUserID
        End If
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        lblToolTip.Text = "Save Current Record"
        If CheckValidation() Then
            objFinanInfo.getConnection()
            objFinanInfo.BeginTransaction()
            SetData()
            If AddMode Then
                Try
                    objFinanInfo.SaveFinTypeCode()
                    Call btnAdd_Click(Nothing, Nothing)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    objFinanInfo.RollBack()
                End Try
            ElseIf EditMode Then
                Try
                    objFinanInfo.EditFinTypeCode()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    objFinanInfo.RollBack()
                End Try
                Flag = True
                Call SetEntryMode()
                GpData.Enabled = False

                btnSave.Enabled = False
                btnCancel.Enabled = False
                dtAccount = objFinanInfo.LoadAllCodes()
                rowNum = dtAccount.Rows.Count - 1
                Call LoadValue()
            End If
            objFinanInfo.CommitTransction()
        End If
        Call MenuGridLoad(mMenuStr)
        rowNum = dtAccount.Rows.Count - 1
        Call SetButtonPrinciple()
        Call SetButton()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        lblToolTip.Text = "Delete Current Record"
        Opt = MsgBox("Are You Sure To Delete Current Record", MsgBoxStyle.YesNo)
        If Opt = MsgBoxResult.Yes Then
            objFinanInfo.FinTypeCode = txtsysCode.Text
            objFinanInfo.DelFinTypeCode()
            Call ClearAll()
            If rowNum > 0 Then
                rowNum = rowNum - 1
                Call LoadValue()
            Else
                MsgBox("No Record Found", MsgBoxStyle.Information)
            End If
        End If
        dtAccount = objFinanInfo.LoadAllCodes()
        rowNum = dtAccount.Rows.Count - 1
        Call LoadValue()
        'rowNum = dtAccount.Rows.Count - 1
        Call MenuGridLoad(mMenuStr)
        rowNum = dtAccount.Rows.Count - 1
        Call SetButtonPrinciple()
        Call SetButtonPrinciple()
        Call SetButton()
    End Sub

    Private Sub GVHelp_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GVHelp.CellClick
        vColumn = e.ColumnIndex
    End Sub

    Private Sub GVHelp_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVHelp.DoubleClick
        If AddMode <> True And EditMode <> True Then
            If GVHelp.RowCount <> 0 Then
                Me.sqlquery = Me.GVHelp.Item(0, GVHelp.CurrentRow.Index).Value
                rowNum = sqlquery - 1
                dtAccount = objFinanInfo.LoadAllCodes()
                If rowNum >= 0 Then

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

    Private Sub GVHelp_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GVHelp.CellEnter
        GVHelp.Cursor = Cursors.Default
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        dtAccount = objFinanInfo.LoadAllCodes()
        Call MenuGridLoad(mMenuStr)
        rowNum = dtAccount.Rows.Count - 1
        Call LoadValue()
        lblToolTip.Text = "Refresh Records"
    End Sub
End Class