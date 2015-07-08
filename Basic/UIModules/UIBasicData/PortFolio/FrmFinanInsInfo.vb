Imports System.Data
Imports System.Data.SqlClient
Imports Basic.Constants.ProjConst
Imports Basic.DAL
Imports Basic.Reports
Imports Basic.DAL.Utils

Public Class FrmFinanInsInfo

    Dim objFinanInfo As New cFinanInsInfo
    Dim dtMaster As New DataTable

    'Dim objProper As New cProper

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
        txtSysName.Text = ""
        txtDesc.Text = ""
        cmbInstType.Text = ""
        txtrate.Text = ""
        cmbCom.Text = ""


        txtAddr.Text = ""

        txtBankAccNo.Text = ""
        txtBic.Text = ""
        txtBranchName.Text = ""
        'BoundData()
    End Sub


    Private Sub txtDesc_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDesc.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub



    Private Sub CBCounter_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CBCounter.KeyDown, cbCounPart.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub cbDepositry_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbDepositry.KeyDown, cbDepBnk.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub CBSettlement_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CBSettlement.KeyDown, cbSetBnk.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub cmbComp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCom.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub cmbInstituteType_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbInstType.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub rbBank_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rbBank.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub rbSGL_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rbChk.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtAddr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAddr.KeyDown, txtBrAddr.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtBankAc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBnkAcc.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtBic_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBic.KeyDown, txtBrBIC.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtBranchName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBranchName.KeyDown, txtBrName.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtContPer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtContPer.KeyDown, txtBrContPer.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtDesc2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDesc2.KeyDown, txtBrDes.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtEmail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmail.KeyDown, txtBrEmail.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtFax_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFax.KeyDown, txtBrFax.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtIpsAccNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIpsAccNo.KeyDown, txtBrIPS.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSysName.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtPH_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPH.KeyDown, txtBrPh.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtrate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtrate.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtsysCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSysCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtSysCode2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSysCode2.KeyDown, txtBranCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub


    Private Sub btnTop_Click(sender As Object, e As System.EventArgs) Handles btnTop.Click
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


    Private Sub btnBottom_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBottom.Click
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
        'LoadValue()
        lblToolTip.Text = "Move To Previous Record"
    End Sub

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNext.Click

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


    Private Sub FrmFinanInsInfo_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Constants.ProjConst.mFinanInsInfo = False
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        lblToolTip.Text = "Close Form"
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        AddMode = True
        EditMode = False
        Flag = False

        Call SetEntryMode()
        btnSave.Enabled = True
        btnCancel.Enabled = True
        EmptyControls(Me)
        Call ClearAll()
        GPMain.Enabled = True
        GPBRanch.Enabled = True
        Me.txtSysCode.Text = objFinanInfo.GenFinInstTypeCode()
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
        GPMain.Enabled = True
        GPBRanch.Enabled = True
        ' mskCode.Enabled = False
        txtSysName.Focus()
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
    Sub LoadMaster()
        Try

            Dim PrintOp As String
            '==================Master data===============================================
            txtSysCode.Text = dtMaster.Rows(rowNum).Item("InstCode")
            txtSysName.Text = dtMaster.Rows(rowNum).Item("InstName") & "" 'objFinanInfo.Description
            txtDesc.Text = dtMaster.Rows(rowNum).Item("Descrip") & "" 'objFinanInfo.Desc2
            cmbInstType.Text = dtMaster.Rows(rowNum).Item("FinTypeCode")
            txtrate.Text = dtMaster.Rows(rowNum).Item("Rating")
            cmbCom.Text = dtMaster.Rows(rowNum).Item("CompCode")
            PrintOp = dtMaster.Rows(rowNum).Item("PrintOp")
            txtBankAccNo.Text = dtMaster.Rows(rowNum).Item("BnkAccNo")
            If PrintOp = "B" Then
                rbBank.Checked = True
            ElseIf PrintOp = "C" Then
                rbChk.Checked = True
            End If
            ' rbBank
            '======================detail data=====================================
            'txtBranCode.Text=

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
    Sub LoadValue()
       
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        lblToolTip.Text = "Cancel Last Action"
        Opt = MsgBox("Do you wish to Abort ?", MsgBoxStyle.YesNo)

        If Opt = MsgBoxResult.No Then
            txtSysName.Focus()
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
            ' objFinanInfo.Type = mType
            'objFinanInfo.VNo = lblVNo.Text
            'dtDetail = objFinanInfo.LoadAllDetail()
            'Call LoadDetail()
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

        GPMain.Enabled = False
        btnSave.Enabled = False
        btnCancel.Enabled = False
        'EmptyControls(Me)
        AddMode = False
        EditMode = False
    End Sub
    Private Sub BoundData()
        '=========BOUND DATA OF NAME===================
        Dim Dts, dts2 As New DataSet
        Me.cmbInstType.Text = ""
        'select FinTypeCode,TypeName from FinType

        Dim strSql As String = "SELECT TypeName+'  |  '+FinTypeCode as name,FinTypeCode from FinType order by TypeName"
        If sqlCon.State = ConnectionState.Closed Then
            sqlCon.Open()
        End If
        Dim da As New SqlDataAdapter(strSql, sqlCon)


        da.Fill(Dts, "FinType")

        cmbInstType.DisplayMember = "name"
        cmbInstType.ValueMember = "FinTypeCode"
        cmbInstType.DataSource = Dts.Tables("FinType")

        If sqlCon.State = ConnectionState.Open Then
            sqlCon.Close()
        End If
    

        '==================================



    End Sub
    Private Sub FrmFinanInsInfo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.MdiParent = frmMdi
        Me.Top = 0
        Me.Left = 0
        Me.WindowState = FormWindowState.Maximized

        LblTypeValid.Text = "Financial Institute Information"

        mQuery = "select fi.instcode,fi.InstName,fb.InsBranCode,fb.InsBrName from FinInstitute fi " & _
                "left outer join FinInstBranch fb on  fi.InstCode=fb.InstCode"
        Call MenuGridLoad(mQuery)
        If rowNum >= 0 Then
            Call LoadMaster()
        End If
        GPMain.Enabled = False
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

    Private Sub GVHelp_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GVHelp.CellClick
        vColumn = e.ColumnIndex
    End Sub

    Private Sub GVHelp_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVHelp.DoubleClick
        If AddMode <> True And EditMode <> True Then
            If GVHelp.RowCount <> 0 Then
                Me.sqlquery = Me.GVHelp.Item(0, GVHelp.CurrentRow.Index).Value
                rowNum = sqlquery - 1
                If rowNum >= 0 Then
                    Call LoadMaster()
                    'objFinanInfo.BrCode = Trim(txtBrCode.Text)
                    'objFinanInfo.Type = mType
                    'objFinanInfo.VNo = lblVNo.Text
                    'dtDetail = objFinanInfo.LoadAllDetail()
                    'Call LoadDetail()
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
    Private Sub SetDataMaster()

        objFinanInfo.InstCode = Trim(txtSysCode.Text)
        objFinanInfo.InstName = Me.txtSysName.Text
       
        objFinanInfo.FinTypeCode = cmbInstType.Text
        objFinanInfo.Rating = txtrate.Text
        objFinanInfo.CompCode = cmbCom.Text
        If Me.rbBank.Checked = True Then
            objFinanInfo.PrintOp = "B"

        ElseIf Me.rbChk.Checked = True Then
            objFinanInfo.PrintOp = "C"

        
        End If

        objFinanInfo.BnkAccNo = txtBankAccNo.Text
        objFinanInfo.Descrip = txtDesc.Text


        If AddMode Then
            objFinanInfo.AddOn = "2015/07/07" 'Format(SySDate, "dd-MMM-yyyy")
            objFinanInfo.AddBy = SysUserID
        ElseIf EditMode Then
            objFinanInfo.EditOn = Format(SySDate, "dd-MMM-yyyy")
            objFinanInfo.EditBy = SysUserID
        End If
    End Sub
    Private Sub EditSet()

        mSQL = "DELETE FROM FinInstBranch WHERE instcode = '" & Trim(txtSysCode.Text) & "' And InsBranCode = '" & _
                txtBranCode.Text & "' "
        ExecQuery(mSQL)
    End Sub
    Private Function CheckValidation() As Boolean
        If txtSysName.Text = "" Then
            MsgBox("Please Enter Name.", MsgBoxStyle.Information, SysCompany)
            txtSysName.Focus()
            Return False
        End If
        'If LBLTotDr.Text <> LBLTotCr.Text Then
        '    MsgBox("Total Debit & Credit must be same", MsgBoxStyle.Information, SysCompany)
        '    Return False
        'End If
        'If (LBLTotDr.Text = 0 Or LBLTotDr.Text = mEmpty Or LBLTotCr.Text = 0 Or LBLTotCr.Text = mEmpty) Then
        '    MsgBox("Voucher With No Detail Lines Can't be Saved", MsgBoxStyle.Information, SysCompany)
        '    Return False
        'End If
        Return True
    End Function
    Private Sub SetDetail()

        objFinanInfo.InsBranCode = Me.txtBranCode.Text
        objFinanInfo.InsBrName = Me.txtBranchName.Text
        objFinanInfo.InsBrAddres=Me.txtBrAddr.Text
        objFinanInfo.ContPer = Me.txtBrContPer.Text
        objFinanInfo.InsBrBnkAccNo = Me.txtBrBnkAc.Text
        objFinanInfo.Ph = Me.txtBrPh.Text
        objFinanInfo.Email = Me.txtBrEmail.Text
        objFinanInfo.Fax = Me.txtBrFax.Text
        objFinanInfo.Description = Me.txtBrDes.Text
        objFinanInfo.BISPNo = Me.txtBrIPS.Text
        objFinanInfo.BICCode = Me.txtBrBIC.Text
        If Me.cbDepBnk.Checked = True Then
            objFinanInfo.DepBnk = "T"
        End If
        If cbSetBnk.Checked = True Then
            objFinanInfo.SetBnk = "T"
        End If

        If Me.cbCounPart.Checked = True Then
            objFinanInfo.CounPart = "T"
        End If
        If Me.CBPrimDeal.Checked = True Then
            objFinanInfo.PrimDeal = "T"
        End If

        objFinanInfo.InstCode = Me.txtSysCode.Text
        If AddMode Then
            objFinanInfo.AddOn = "2015/07/07" 'Format(SySDate, "dd-MMM-yyyy")
            objFinanInfo.AddBy = SysUserID
        ElseIf EditMode Then
            objFinanInfo.EditOn = Format(SySDate, "dd-MMM-yyyy")
            objFinanInfo.EditBy = SysUserID
        End If




    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
       
        lblToolTip.Text = "Save Current Record"


        If CheckValidation() Then
            objFinanInfo.getConnection()
            objFinanInfo.BeginTransaction()
            If AddMode Then
                Try
                    SetDataMaster()         'Set Master Object Variables
                    objFinanInfo.SaveMaster()  'Save Master Object Variables
                    'SetDetail()
                    'objFinanInfo.SaveDetail()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    objFinanInfo.RollBack()
                    Exit Sub
                End Try
            ElseIf EditMode Then
                Try

                    'EditSet()
                    'objFinanInfo.EditMaster()
                    'SetData(mi)             ' Save(Detail)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    objFinanInfo.RollBack()
                    Exit Sub
                End Try
            End If
            objFinanInfo.CommitTransction()
            'If Trim(lblVNo.Text) <> Trim(mTmpNo) Then
            '    MsgBox("Your Transaction Is Saved With Voucher " & mType & " " & lblVNo.Text, vbInformation, SysCompany)
            'End If
            If AddMode Then
                Call btnAdd_Click(Nothing, Nothing)
                If mMenuStr <> "" Then
                    Call MenuGridLoad(mMenuStr)
                    rowNum = dtMaster.Rows.Count - 1
                End If
            ElseIf EditMode Then
                Flag = True
                Call SetEntryMode()
                GPMain.Enabled = False
                GPBRanch.Enabled = False
                btnSave.Enabled = False
                btnCancel.Enabled = False
                EditMode = False
            End If

        End If
    End Sub

    Private Sub btnAddBranch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddBranch.Click

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        lblToolTip.Text = "Refresh Records"
        dtMaster = objFinanInfo.LoadAllMaster()
        Call MenuGridLoad(mMenuStr)
        rowNum = dtMaster.Rows.Count - 1
        If rowNum >= 0 Then
            Call LoadMaster()
            objFinanInfo.FinTypeCode = Trim(txtSysCode.Text)
            'objFinanInfo.Type = mType
            'objFinanInfo.VNo = lblVNo.Text
            'dtDetail = objFinanInfo.LoadAllDetail()
            ' Call LoadDetail()
            LoadMaster()
            btnExit.Focus()
            Call MenuGridLoad(mMenuStr)
            rowNum = dtMaster.Rows.Count - 1
        Else
            MsgBox("No Record Found", MsgBoxStyle.Information)
            Call ClearAll()
        End If
    End Sub
End Class