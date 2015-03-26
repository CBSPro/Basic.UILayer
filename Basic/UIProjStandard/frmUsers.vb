
Imports System.Data.SqlClient
Imports System.Data
Imports Basic.DAL
Imports Basic.Constants
Imports Basic.DAL.Utils

Public Class frmUsers
    Inherits System.Windows.Forms.Form

    Dim objUsers As New cUsers

    Dim PODS As New DataSet
    Dim DtDet As New DataTable
    Dim DaDet As SqlDataAdapter
    Dim objRow As Data.DataRow
    Dim ObjFind As Grid_Help
    Dim strFind As String
    Dim Flag As Boolean
    Dim AddMode As Boolean
    Dim EditMode As Boolean
    Dim KeyReturn As Boolean
    Dim ColBack As Boolean
    Dim SelRow As Boolean
    Dim dtMenu As New DataTable
    Dim dtSecurity As New DataTable
    Dim dtMaster As New DataTable
    Dim dtDetail As New DataTable
    Dim rowMenu As Integer
    Dim rowNum As Integer
    Dim rowNum1 As Integer

    Private Sub frmUsers_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Constants.ProjConst.mUMaintenence = False
    End Sub

    Private Sub frmUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmMdi
        Me.Top = 0
        Me.Left = 0
        Me.WindowState = FormWindowState.Maximized
        vspGrid.SetOddEvenRowColor(&HFFF4FE, &H80000008, &H80000005, &H80000008)
        GpData.Enabled = False
        Flag = True
        Call SetEntryMode()
        btnSave.Enabled = False
        btnCancel.Enabled = False
        dtMaster = objUsers.LoadUsers()
        rowNum = dtMaster.Rows.Count - 1
        Call LoadMaster()
        Call LoadDetail()
        btnExit.Focus()
        vspGrid.BlockMode = True
        vspGrid.Enabled = False
    End Sub

    Sub LoadMaster()
        txtUserID.Text = dtMaster.Rows(rowNum).Item("UserID") 'objRefDef.Pageno
        txtUserName.Text = dtMaster.Rows(rowNum).Item("UserName") 'objRefDef.Hdr
        If (dtMaster.Rows.Count > 0) Then
            lblCompany.Text = "Recorded On : " & GetDate(dtMaster.Rows(rowNum).Item("AddOn").ToString(), "dd-MMM-yyyy") + " " 'objRefDef.AddOn
            lblBy.Text = "Recorded By : " & dtMaster.Rows(rowNum).Item("AddBy").ToString() 'objRefDef.AddBy
        Else
            lblCompany.Text = ""
            lblBy.Text = ""
        End If
        lblToolTip.Text = "Close Form"
    End Sub

    Sub LoadDetail()
        Dim mi As Integer
        Dim TmpVal As String
        Dim TmpStr As Object

        Call FillDetail()
        vspGrid.Row = 1

        For mi = 1 To vspGrid.MaxRows
            Erase TmpStr
            vspGrid.GetText(1, mi, TmpStr)

            mSQL = "SELECT MenuName FROM Menu WHERE MenuCaption = '" & _
                        Trim(TmpStr) & "'"
            TmpVal = GetFldValue(mSQL, "MenuName")

            objUsers.UserID = Trim(txtUserID.Text)
            objUsers.MenuName = Trim(TmpVal) & ""

            dtSecurity = objUsers.LoadfrmSecurity()
            rowMenu = dtSecurity.Rows.Count - 1

            If dtSecurity.Rows.Count > 0 Then
                If (dtSecurity.Rows(0).Item("ShowMenu") = "True" Or dtSecurity.Rows(0).Item("ShowMenu") = "1") Then
                    TmpVal = "Checked"
                Else
                    TmpVal = ""
                End If
                vspGrid.SetText(2, mi, TmpVal)
                If dtSecurity.Rows(0).Item("CanAdd") = "True" Then
                    TmpVal = "Checked"
                Else
                    TmpVal = ""
                End If
                vspGrid.SetText(3, mi, TmpVal)
                If dtSecurity.Rows(0).Item("CanEdit") = "True" Then
                    TmpVal = "Checked"
                Else
                    TmpVal = ""
                End If
                vspGrid.SetText(4, mi, TmpVal)
                If dtSecurity.Rows(0).Item("CanDelete") = "True" Then
                    TmpVal = "Checked"
                Else
                    TmpVal = ""
                End If
                vspGrid.SetText(5, mi, TmpVal)
                If dtSecurity.Rows(0).Item("CanPost") = "True" Then
                    TmpVal = "Checked"
                Else
                    TmpVal = ""
                End If
                vspGrid.SetText(6, mi, TmpVal)
                If dtSecurity.Rows(0).Item("CanPrint") = "True" Then
                    TmpVal = "Checked"
                Else
                    TmpVal = ""
                End If
                vspGrid.SetText(7, mi, TmpVal)
                If dtSecurity.Rows(0).Item("CanPreview") = "True" Then
                    TmpVal = "Checked"
                Else
                    TmpVal = ""
                End If
                vspGrid.SetText(8, mi, TmpVal)
            End If
        Next mi
        'Call LockGrid(False)
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
        txtUserID.Text = ""
        txtUserName.Text = ""
        Call ClearGrid()
    End Sub

    Sub ClearGrid()
        Call vspGrid.ClearRange(2, 1, vspGrid.MaxCols, vspGrid.MaxRows, True)
    End Sub

    Private Sub FillDetail()
        Dim mi As Integer
        Dim TmpVal
        Dim TmpStr
        If Trim(txtUserID.Text) <> "" Then
            dtMenu = objUsers.LoadMenu()
            'rowMenu = dtMenu.Rows.Count - 1

            vspGrid.MaxRows = 1
            TmpVal = ""

            vspGrid.SetText(2, 1, TmpVal)
            vspGrid.SetText(3, 1, TmpVal)
            vspGrid.SetText(4, 1, TmpVal)
            vspGrid.SetText(5, 1, TmpVal)
            vspGrid.SetText(6, 1, TmpVal)
            vspGrid.SetText(7, 1, TmpVal)
            vspGrid.SetText(8, 1, TmpVal)

            If dtMenu.Rows.Count > 0 Then
                rowMenu = 0
                For mi = 1 To dtMenu.Rows.Count
                    If mi > vspGrid.MaxRows Then
                        vspGrid.MaxRows = vspGrid.MaxRows + 1
                    End If

                    TmpVal = dtMenu.Rows(rowMenu).Item("MenuName") & ""
                    TmpStr = dtMenu.Rows(rowMenu).Item("MenuCaption") & ""

                    If Mid(TmpVal, 1, 3) = "smi" Then
                        vspGrid.SetText(1, mi, Space(10) & TmpStr)
                    ElseIf Mid(TmpVal, 1, 2) = "mi" Then
                        vspGrid.SetText(1, mi, Space(5) & TmpStr)
                    Else
                        vspGrid.SetText(1, mi, TmpStr)
                    End If
                    ''
                    TmpVal = ""
                    vspGrid.SetText(2, mi, TmpVal)
                    vspGrid.SetText(3, mi, TmpVal)
                    vspGrid.SetText(4, mi, TmpVal)
                    vspGrid.SetText(5, mi, TmpVal)
                    vspGrid.SetText(6, mi, TmpVal)
                    vspGrid.SetText(7, mi, TmpVal)
                    vspGrid.SetText(8, mi, TmpVal)
                    If mi <= dtMenu.Rows.Count Then
                        vspGrid.MaxRows = vspGrid.MaxRows + 1
                        rowMenu = rowMenu + 1
                    End If
                    If mi = dtMenu.Rows.Count Then
                        vspGrid.MaxRows = vspGrid.MaxRows - 1
                    End If
                Next
            End If
        End If
        'Call LockGrid(False)
    End Sub

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If Not SpUser Then
            MsgBox("You are Not Allowed to Define Users", vbInformation, Constants.ProjConst.SysCompany)
            Exit Sub
        End If
        AddMode = True
        EditMode = False
        Flag = False
        Call SetEntryMode()
        btnSave.Enabled = True
        btnCancel.Enabled = True
        Call ClearAll()
        GpData.Enabled = True
        Call GetNewUserID()
        lblCompany.Text = "Recorded On " & Constants.ProjConst.SySDate
        lblToolTip.Text = "Add New Record"
        lblBy.Text = "Recorded By : " & "0001"
        'lblBy.Text = "Recorded By : " & SysUserID
        txtUserID.Enabled = False
        txtUserName.Enabled = True
        txtUserName.Focus()
        vspGrid.BlockMode = False
        vspGrid.Enabled = True
    End Sub

    Private Sub GetNewUserID()
        mSQL = "SELECT MAX(USERID) UserID FROM USERS"
        mSQL = GetFldValue(mSQL, "UserID")
        If mSQL <> "" Then
            txtUserID.Text = Format(Val(mSQL) + 1, "0000")
        Else
            txtUserID.Text = "0002"
        End If
    End Sub

    Private Sub CheckAll()
        Dim mi As Integer
        Dim mStr

        If txtUserId.Text <> "" Then
            mStr = "Checked"
            For mi = 1 To vspGrid.MaxRows
                vspGrid.SetText(2, mi, mStr)
                vspGrid.SetText(3, mi, mStr)
                vspGrid.SetText(4, mi, mStr)
                vspGrid.SetText(5, mi, mStr)
                vspGrid.SetText(6, mi, mStr)
                vspGrid.SetText(7, mi, mStr)
                vspGrid.SetText(8, mi, mStr)
            Next mi
        End If
        'Call LockGrid(False)
    End Sub

    Private Sub UnCheckAll()
        Dim mi As Integer
        Dim mStr
        If txtUserID.Text <> "" Then
            mStr = ""
            For mi = 1 To vspGrid.MaxRows
                vspGrid.SetText(2, mi, mStr)
                vspGrid.SetText(3, mi, mStr)
                vspGrid.SetText(4, mi, mStr)
                vspGrid.SetText(5, mi, mStr)
                vspGrid.SetText(6, mi, mStr)
                vspGrid.SetText(7, mi, mStr)
                vspGrid.SetText(8, mi, mStr)
            Next mi
        End If
        'Call LockGrid(False)
    End Sub

    Private Sub btnCheck_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        Call CheckAll()
    End Sub

    Private Sub btnUnCheck_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUnCheck.Click
        Call UnCheckAll()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        lblToolTip.Text = "Edit Current Record"
        'If Not Trim(txtUserName.Text) = BuiltInUser Then
        '    MsgBox("You Can't Edit BuiltIn User", vbInformation, SysCompany)
        '    Exit Sub
        'End If
        If Not SpUser Then
            MsgBox("You are Not Allowed to Edit Users", vbInformation, Constants.ProjConst.SysCompany)
            Exit Sub
        End If
        EditMode = True
        AddMode = False
        Flag = False
        Call SetEntryMode()
        GpData.Enabled = True
        txtUserID.Enabled = False
        txtUserName.Enabled = False
        txtUserName.Focus()
        btnEdit.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
        vspGrid.BlockMode = False
        vspGrid.Enabled = True
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim mi As Integer

        lblToolTip.Text = "Save Current Record"
        If CheckValidation() Then
            objUsers.getConnection()
            objUsers.BeginTransaction()
            SetDataMaster()
            If AddMode Then
                Try
                    If SpUser = True Then
                        SpUsers = 1
                    Else
                        SpUsers = 0
                    End If
                    objUsers.SaveMaster()
                    For mi = 1 To vspGrid.MaxRows
                        SetData(mi)
                        objUsers.SaveDetail()
                    Next
                Catch ex As Exception
                    MsgBox(ex.Message)
                    objUsers.RollBack()
                End Try
                'objUsers.SaveDBUser()
                Call btnAdd_Click(Nothing, Nothing)
                'objUsers.RollBack()
            ElseIf EditMode Then
                Try
                    objUsers.EditMaster()
                    objUsers.DelUser()
                    SetDataMaster()
                    objUsers.SaveMaster()
                    For mi = 1 To vspGrid.MaxRows
                        SetData(mi)
                        objUsers.SaveDetail()
                    Next
                    Flag = True
                    Call SetEntryMode()
                    GpData.Enabled = False
                    btnSave.Enabled = False
                    btnCancel.Enabled = False
                    vspGrid.BlockMode = True
                    vspGrid.Enabled = False
                Catch ex As Exception
                    MsgBox(ex.Message)
                    objUsers.RollBack()
                End Try
            End If
        End If
        objUsers.CommitTransction()
    End Sub

    Private Function CheckValidation() As Boolean
        If txtUserID.Text = "" Then
            MsgBox("Please Enter User ID", MsgBoxStyle.Information, Constants.ProjConst.SysCompany)
            txtUserID.Focus()
            Return False
        ElseIf txtUserName.Text = "" Then
            MsgBox("Please Enter User Name", MsgBoxStyle.Information, Constants.ProjConst.SysCompany)
            txtUserName.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub SetDataMaster()
        objUsers.UserID = Trim(txtUserID.Text)
        objUsers.UserName = Trim(txtUserName.Text)
        If AddMode Then
            objUsers.AddOn = Constants.ProjConst.SySDate
            objUsers.AddBy = "0001"
            'objBranch.AddBy = SysUserID
        ElseIf EditMode Then
            objUsers.EditOn = Constants.ProjConst.SySDate
            objUsers.EditBy = "0001"
            'objBranch.AddBy = SysUserID
        End If
    End Sub

    Private Sub SetData(ByVal rowIndex As Integer)
        Dim mTemp As Object
        Dim mMenuCaption As Object

        Erase mMenuCaption
        vspGrid.GetText(1, rowIndex, mMenuCaption)
        If mMenuCaption <> "" Then
            objUsers.UserID = Trim(txtUserID.Text)
            mSQL = "SELECT * FROM Menu WHERE MenuCaption = '" & _
                        Trim(mMenuCaption) & "'"
            objUsers.MenuName = GetFldValue(mSQL, "MenuName")
            objUsers.SeqNo = GetNewSeq()
            'objUsers.SeqNo = Format(rowIndex, "00000")
            Erase mTemp
            vspGrid.GetText(2, rowIndex, mTemp)
            If (mTemp = "Checked" Or mTemp = "1") Then
                objUsers.ShowMenu = True
            Else
                objUsers.ShowMenu = False
            End If
            Erase mTemp
            vspGrid.GetText(3, rowIndex, mTemp)
            If (mTemp = "Checked" Or mTemp = "1") Then
                objUsers.CanAdd = True
            Else
                objUsers.CanAdd = False
            End If
            Erase mTemp
            vspGrid.GetText(4, rowIndex, mTemp)
            If (mTemp = "Checked" Or mTemp = "1") Then
                objUsers.CanEdit = True
            Else
                objUsers.CanEdit = False
            End If
            Erase mTemp
            vspGrid.GetText(5, rowIndex, mTemp)
            If (mTemp = "Checked" Or mTemp = "1") Then
                objUsers.CanDelete = True
            Else
                objUsers.CanDelete = False
            End If
            Erase mTemp
            vspGrid.GetText(6, rowIndex, mTemp)
            If (mTemp = "Checked" Or mTemp = "1") Then
                objUsers.CanPost = True
            Else
                objUsers.CanPost = False
            End If
            Erase mTemp
            vspGrid.GetText(7, rowIndex, mTemp)
            If (mTemp = "Checked" Or mTemp = "1") Then
                objUsers.CanPrint = True
            Else
                objUsers.CanPrint = False
            End If
            Erase mTemp
            vspGrid.GetText(8, rowIndex, mTemp)
            If (mTemp = "Checked" Or mTemp = "1") Then
                objUsers.CanPreview = True
            Else
                objUsers.CanPreview = False
            End If
            If AddMode Then
                objUsers.AddOn = Constants.ProjConst.SySDate
                objUsers.AddBy = "0001"
                'objBranch.AddBy = SysUserID
            ElseIf EditMode Then
                objUsers.EditOn = Constants.ProjConst.SySDate
                objUsers.EditBy = "0001"
                'objBranch.AddBy = SysUserID
            End If
        End If
    End Sub

    Private Function GetNewSeq() As String
        mSQL = "SELECT MAX(SeqNo) NewSeq FROM SECURITY Where UserID = " & _
               "'" & Trim(txtUserId.Text) & "'"
        mSQL = GetFldValue(mSQL, "NewSeq")
        If mSQL = "" Then
            mSQL = Format(1, "000")
        Else
            mSQL = Format(Val(mSQL) + 1, "000")
        End If
        GetNewSeq = mSQL
    End Function

    Private Sub btnBottom_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBottom.Click
        rowNum = dtMaster.Rows.Count - 1
        lblToolTip.Text = "Move To Last Record"
        lblToolTip.Text = "Move To Last Record"
        btnTop.Enabled = True
        btnPrevious.Enabled = True
        btnNext.Enabled = False
        btnBottom.Enabled = False
        Call LoadMaster()
        objUsers.UserID = Trim(txtUserID.Text)
        objUsers.UserName = Trim(txtUserName.Text)
        dtDetail = objUsers.LoadSecurity
        Call ClearGrid()
        Call LoadDetail()
    End Sub

    Private Sub btnTop_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTop.Click
        rowNum = 0
        btnTop.Enabled = False
        btnPrevious.Enabled = False
        btnNext.Enabled = True
        btnBottom.Enabled = True
        Call LoadMaster()
        objUsers.UserID = Trim(txtUserID.Text)
        objUsers.UserName = Trim(txtUserName.Text)
        dtDetail = objUsers.LoadSecurity()
        Call ClearGrid()
        Call LoadDetail()
        lblToolTip.Text = "Move To First Record"
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
        objUsers.UserID = Trim(txtUserID.Text)
        objUsers.UserName = Trim(txtUserName.Text)
        dtDetail = objUsers.LoadSecurity()
        Call ClearGrid()
        Call LoadDetail()
        lblToolTip.Text = "Move To Next Record"
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
        objUsers.UserID = Trim(txtUserID.Text)
        objUsers.UserName = Trim(txtUserName.Text)
        dtDetail = objUsers.LoadSecurity()
        Call ClearGrid()
        Call LoadDetail()
        lblToolTip.Text = "Move To Previous Record"
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        lblToolTip.Text = "Refresh Records"
        rowNum = dtMaster.Rows.Count - 1
        If rowNum >= 0 Then
            Call LoadMaster()
            objUsers.UserID = Trim(txtUserID.Text)
            objUsers.UserName = Trim(txtUserName.Text)
            dtDetail = objUsers.LoadSecurity()
            Call ClearGrid()
            Call LoadDetail()
            btnExit.Focus()
        Else
            MsgBox("No Record Found", MsgBoxStyle.Information)
            Call ClearAll()
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
            objUsers.DelUser()
            'objUsers.DelDBUser()
            dtMaster = objUsers.LoadUsers()
            rowNum = dtMaster.Rows.Count - 1
            If rowNum >= 0 Then
                Call LoadMaster()
                objUsers.UserID = Trim(txtUserID.Text)
                objUsers.UserName = Trim(txtUserName.Text)
                dtDetail = objUsers.LoadSecurity()
                Call LoadDetail()
                btnExit.Focus()
            Else
                MsgBox("No Record Found", MsgBoxStyle.Information)
                Call ClearAll()
            End If
        End If
    End Sub

    Private Sub btnFind_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFind.Click
        lblToolTip.Text = "Find A Record"
        ObjFind = New Grid_Help
        mOrder = 0

        strFind = "SELECT UserID,UserName FROM Users ORDER BY UserID"
        ObjFind.PMessage = "Users"
        ObjFind.sqlqueryFun = strFind
        ObjFind.ShowDialog()

        If ObjFind.PbOk = True Then
            Call ClearAll()
            txtUserID.Text = ObjFind.strPKfun & ""
            txtUserName.Text = ObjFind.sqlqueryFun & ""
            objUsers.UserID = Trim(txtUserID.Text)
            'dtMaster = objUsers.LoadUsers
            'Call LoadMaster()
            dtDetail = objUsers.FindUser()
            Call LoadDetail()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        lblToolTip.Text = "Cancel Last Action"
        Opt = MsgBox("Do you wish to Abort ?", MsgBoxStyle.YesNo)
        If Opt = MsgBoxResult.No Then
            txtUserName.Focus()
            Exit Sub
        End If
        If AddMode Then
            'dtMaster = objUsers.LoadMenu()
            dtMaster = objUsers.LoadUsers()
            'rowNum = dtMaster.Rows.Count - 1
            'Call LoadMaster()
            'Call LoadDetail()
            rowNum = dtMaster.Rows.Count - 1
            Call LoadMaster()
            objUsers.UserID = Trim(txtUserID.Text)
            objUsers.UserName = Trim(txtUserName.Text)
            dtDetail = objUsers.LoadSecurity()
            Call LoadDetail()
        Else
            Call LoadMaster()
            Call LoadDetail()
        End If
        Flag = True
        Call SetEntryMode()
        GpData.Enabled = False
        btnSave.Enabled = False
        btnCancel.Enabled = False
        vspGrid.BlockMode = True
        vspGrid.Enabled = False
    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim frmList As New frmRPT_List
        Constants.ProjConst.pPara = 19
        lblToolTip.Text = "Print Record(s)"
        frmRPT_PostedVoucher.Show()
    End Sub

    Private Sub txtUserID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUserID.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtUserName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUserName.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub GpData_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GpData.Enter

    End Sub
End Class