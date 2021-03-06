﻿Imports System.Data
Imports System.Data.SqlClient
Imports Basic.Constants.ProjConst
Imports Basic.DAL
Imports Basic.Reports
Imports Basic.DAL.Utils

Public Class frmFinInsBranch

    Dim objFinanInfo As New cFinanInsInfo
    Dim dtMaster As New DataTable

    'Dim objProper As New cProper
    Public Shared FinInsSysCode As String
    Dim mAdd As Boolean
    Dim mEdit As Boolean
    Dim mDelete As Boolean
    Dim mPost As Boolean
    Dim mPrint As Boolean
    Dim mQuery As String
    Dim PODS As New DataSet
    Dim objRow As Data.DataRow
    Dim ObjFind As Grid_Help
    Dim tableName As String = "FinInstitute"
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
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        AddMode = True
        EditMode = False
        Flag = False

        Call SetEntryMode()
        btnSave.Enabled = True
        btnCancel.Enabled = True
        EmptyControls(Me)
        Call ClearAll()

        GPBRanch.Enabled = True
        sqlquery = "select isnull(MAX(InsBranCode),0) from FinInstBranch where InstCode='" & Me.txtSysCode.Text & "'"

        Me.txtBranCode.Text = objFinanInfo.GenFinInstTypeCode()
        lblCompany.Text = "Recorded On " & Format(SySDate, "dd-MMM-yyyy")
        lblToolTip.Text = "Add New Record"
        lblBy.Text = "Recorded By : " & SysUserID
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
        txtSysCode.Text = ""
        txtBrAddr.Text = ""
        txtBranCode.Text = ""
        txtBrBIC.Text = ""
        txtBrBnkAc.Text = ""
        txtBrContPer.Text = ""
        txtBrDes.Text = ""
        txtBrEmail.Text = ""
        txtBrFax.Text = ""
        txtBrIPS.Text = ""
        txtBrName.Text = ""
        txtBrPh.Text = ""
        cbCounPart.Checked = False
        CBPrimDeal.Checked = False
        cbSetBnk.Checked = False
        cbDepBnk.Checked = False

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        lblToolTip.Text = "Edit Current Record"
        EditMode = True
        AddMode = False
        Flag = False
        ' mskCode.Enabled = True
        Call SetEntryMode()

        GPBRanch.Enabled = True
        ' mskCode.Enabled = False
        txtBrName.Focus()
        btnEdit.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        lblToolTip.Text = "Delete Current Record"
        Opt = MsgBox("Are You Sure To Delete Current Record", MsgBoxStyle.YesNo)

        If Opt = MsgBoxResult.Yes Then
            objFinanInfo.DelFinInstTypeCode()
            dtMaster = objFinanInfo.LoadAllMaster()
            Call MenuGridLoad(mMenuStr)
            rowNum = dtMaster.Rows.Count - 1
            If rowNum >= 0 Then
                Call LoadMaster()

                objFinanInfo.InstCode = Trim(txtSysCode.Text)
                'objFinanInfo.FinTypeCode = mType

                ' dtDetail = objFinanInfo.LoadAllDetail()
                ' Call LoadDetail()
                btnExit.Focus()
            Else
                MsgBox("No Record Found", MsgBoxStyle.Information)
                Call ClearAll()
            End If
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

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        lblToolTip.Text = "Cancel Last Action"
        Opt = MsgBox("Do you wish to Abort ?", MsgBoxStyle.YesNo)

        If Opt = MsgBoxResult.No Then
            txtBrName.Focus()
            Exit Sub
        End If

        If AddMode Then
            'dtMaster = objFinanInfo.LoadMasterVoucher()
            Call SetEntryMode()
            btnStatus(False)
            Call SetFormSecurity(Me)
            Call SetButtonsSurity(Me)
            Call SetButtonPrinciple()
            Call SetButton()
            rowNum = dtMaster.Rows.Count - 1
            Call LoadMaster()
            objFinanInfo.InstCode = Trim(txtSysCode.Text)
           
        Else
            Flag = True
            Call SetEntryMode()
            btnStatus(False)
            Call SetFormSecurity(Me)
            Call SetButtonsSurity(Me)
            Call SetButtonPrinciple()
            Call SetButton()
            Call LoadMaster()
            'dtMasterMenu = objFinanInfo.LoadAllMaster()

            'Call LoadDetail()
        End If

        GPBRanch.Enabled = False
        btnSave.Enabled = False
        btnCancel.Enabled = False
        'EmptyControls(Me)
        AddMode = False
        EditMode = False
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
    Private Sub btnStatus(ByVal status As Boolean)
        btnAdd.Enabled = status
        btnEdit.Enabled = status
        btnDelete.Enabled = status
        btnPost.Enabled = status
        btnPrint.Enabled = status
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        lblToolTip.Text = "Refresh Records"
        dtMaster = objFinanInfo.LoadAllDetail(Me.txtSysCode.Text)
        Call MenuGridLoad(mMenuStr)
        rowNum = dtMaster.Rows.Count - 1
        If rowNum >= 0 Then
            Call LoadMaster()
           
            btnExit.Focus()
            Call MenuGridLoad(mMenuStr)
            rowNum = dtMaster.Rows.Count - 1
        Else
            MsgBox("No Record Found", MsgBoxStyle.Information)
            Call ClearAll()
        End If
    End Sub

    Private Sub btnTop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTop.Click
        If rowNum > 0 Then
            btnTop.Enabled = False
            btnPrevious.Enabled = False
            btnNext.Enabled = True
            btnBottom.Enabled = True
            'Call LoadValue()
            lblToolTip.Text = "Move To First Record"
            Call SetButtonPrinciple()
            Call SetButton()
        End If
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
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
        'LoadValue()
        lblToolTip.Text = "Move To Previous Record"
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click

        rowNum = rowNum + 1
        btnNext.Enabled = True
        btnBottom.Enabled = True
        btnPrevious.Enabled = True
        btnTop.Enabled = True
        Call SetButtonPrinciple()
        Call SetButton()
        ' Else

        btnNext.Enabled = False
        btnBottom.Enabled = False
        btnPrevious.Enabled = True
        btnTop.Enabled = True
        ' End If
        'LoadValue()
        lblToolTip.Text = "Move To Next Record"
    End Sub

    Private Sub btnBottom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBottom.Click
        If rowNum > 0 Then

            btnBottom.Enabled = False
            btnNext.Enabled = False
            btnTop.Enabled = True
            btnPrevious.Enabled = True
            'Call LoadValue()
            lblToolTip.Text = "Move To Last Record"

            Call SetButtonPrinciple()
            Call SetButton()
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        lblToolTip.Text = "Close Form"
        Me.Close()
    End Sub

    Private Sub frmFinInsBranch_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Constants.ProjConst.mFinanInsBranch = False
    End Sub
    Sub LoadMaster()
        Try

            Dim PrintOp As String
            txtSysCode.Text = dtMaster.Rows(rowNum).Item("InstCode")
            txtBrAddr.Text = ""
            txtBranCode.Text = dtMaster.Rows(rowNum).Item("InsBranCode")
            txtBrBIC.Text = dtMaster.Rows(rowNum).Item("BICCode")
            txtBrBnkAc.Text = dtMaster.Rows(rowNum).Item("InsBrBnkAccNo")
            txtBrContPer.Text = dtMaster.Rows(rowNum).Item("ContPer")
            txtBrDes.Text = dtMaster.Rows(rowNum).Item("Description")
            txtBrEmail.Text = dtMaster.Rows(rowNum).Item("Email")
            txtBrFax.Text = dtMaster.Rows(rowNum).Item("Fax")
            txtBrIPS.Text = dtMaster.Rows(rowNum).Item("BISPNo")
            txtBrName.Text = dtMaster.Rows(rowNum).Item("InsBrName")
            txtBrPh.Text = dtMaster.Rows(rowNum).Item("Ph")

            If dtMaster.Rows(rowNum).Item("SetBnk") = "T" Then
                cbSetBnk.Checked = True
            Else
                cbSetBnk.Checked = False
            End If

            If dtMaster.Rows(rowNum).Item("DepBnk") = "T" Then
                cbDepBnk.Checked = True
            Else
                cbDepBnk.Checked = False
            End If

            If dtMaster.Rows(rowNum).Item("CounPart") = "T" Then
                cbCounPart.Checked = True
            Else
                cbCounPart.Checked = False
            End If


            If dtMaster.Rows(rowNum).Item("PrimDeal") = "T" Then
                CBPrimDeal.Checked = True
            Else
                CBPrimDeal.Checked = False
            End If
        
            '=================================================================
            lblCompany.Text = "Recorded On : " & dtMaster.Rows(rowNum).Item("AddOn") & "" 'objFinanInfo.AddOn
            lblBy.Text = "Recorded By : " & dtMaster.Rows(rowNum).Item("AddBy") & "" 'objFinanInfo.AddBy
            lblToolTip.Text = "Close Form"
            lblCompany.Text = "Recorded On : " & dtMaster.Rows(rowNum).Item("AddOn")
            lblBy.Text = "Recorded By : " & dtMaster.Rows(rowNum).Item("AddBy")
            lblToolTip.Text = "Close Form"
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub frmFinInsBranch_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Me.MdiParent = frmMdi
        'Me.Top = 0
        'Me.Left = 0
        Me.WindowState = FormWindowState.Maximized

        LblTypeValid.Text = "Financial Institute Branch"
        Me.txtSysCode.Text = FinInsSysCode
        objFinanInfo.LoadAllDetail(Me.txtSysCode.Text)
        Call MenuGridLoad(mQuery)
        If rowNum >= 0 Then
            Call LoadMaster()
        End If

        GPBRanch.Enabled = False
        Flag = True
        Call SetAccParam()
        Call SetEntryMode()
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
        ' BoundData()
    End Sub
End Class