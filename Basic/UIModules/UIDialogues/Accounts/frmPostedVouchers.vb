Imports System.Data
Imports System.Data.SqlClient
Imports Basic.DAL
Imports Basic.DAL.Utils
Imports Basic.Constants.ProjConst


Public Class frmPostedVouchers
    Inherits System.Windows.Forms.Form

    Dim objPostedVouchers As New cPostedVouchers

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
    Dim Flag As Boolean
    Dim AddMode As Boolean
    Dim EditMode As Boolean
    Dim dtMaster As New DataTable
    Dim dtDetail As New DataTable
    Dim rowNum As Integer
    Dim rowNum1 As Integer

    Private Sub frmPostedVouchers_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ''
        GpData.Enabled = False
        Flag = True
        Call SetAccParam()
        Call SetEntryMode()
        btnSave.Enabled = False
        btnCancel.Enabled = False
        dtMaster = objPostedVouchers.LoadAllMaster()
        rowNum = dtMaster.Rows.Count - 1
        If rowNum >= 0 Then
            Call LoadMaster()
            objPostedVouchers.BrCode = lblBrCode.Text
            objPostedVouchers.Type = lblType.Text
            objPostedVouchers.VNo = lblVNo.Text
            dtDetail = objPostedVouchers.LoadAllDetail()
            'rowNum = dtDetail.Rows.Count - 1
            Call LoadDetail()
            btnExit.Focus()
        Else
            MsgBox("No Record Found", MsgBoxStyle.Information)
            Call ClearAll()
        End If
        vspGrid.Enabled = False
    End Sub

    Sub LoadMaster()
        Try
            lblBrCode.Text = dtMaster.Rows(rowNum).Item("BrCode")
            lblType.Text = dtMaster.Rows(rowNum).Item("Type")
            lblVNo.Text = dtMaster.Rows(rowNum).Item("VNo")
            dtpVDate.Text = dtMaster.Rows(rowNum).Item("VDate")
            txtPurpose.Text = dtMaster.Rows(rowNum).Item("RefRemarks")
            lblCompany.Text = "Recorded On : " & dtMaster.Rows(rowNum).Item("AddOn")
            lblBy.Text = "Recorded By : " & dtMaster.Rows(rowNum).Item("AddBy")
            lblToolTip.Text = "Close Form"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Sub LoadDetail()
        Dim mi As Integer
        Dim TotSum As Double
        'Dim Fld As String
        TotSum = 0

        Try
            ''
            rowNum1 = 0
            If dtDetail.Rows.Count > 0 Then
                vspGrid.MaxRows = 1
                vspGrid.SetText(1, 1, "")
                vspGrid.SetText(2, 1, "")
                vspGrid.SetText(3, 1, "")
                vspGrid.SetText(4, 1, "")
                vspGrid.SetText(5, 1, "")
                vspGrid.SetText(6, 1, "")
                vspGrid.SetText(7, 1, "")

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
                    End If
                    If Not IsDBNull(dtDetail.Rows(rowNum1).Item("Credit")) Then
                        mStr = dtDetail.Rows(rowNum1).Item("Credit").ToString
                        vspGrid.SetText(5, mi, Format(Val(mStr), "##,###,###,###.00"))
                    End If
                    mStr = dtDetail.Rows(rowNum1).Item("RfCode").ToString()
                    vspGrid.SetText(6, mi, aStr2Code(mStr))
                    mSQL = "Select Description From Codes " & _
                           "Where Code = '" & aCode2Str(mStr) & "'"
                    mStr = GetFldValue(mSQL, "Description")
                    vspGrid.SetText(7, mi, mStr)
                    If mi < dtDetail.Rows.Count Then
                        vspGrid.MaxRows = vspGrid.MaxRows + 1
                        rowNum1 = rowNum1 + 1
                    End If
                Next
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
        lblBrCode.Text = ""
        lblType.Text = ""
        lblVNo.Text = ""
        dtpVDate.Value = SySDate
        txtPurpose.Text = ""
        Call ClearGrid()
    End Sub

    Sub ClearGrid()
        Call vspGrid.ClearRange(1, 1, vspGrid.MaxCols, vspGrid.MaxRows, True)
        vspGrid.MaxRows = 1
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        lblToolTip.Text = "Edit Current Record"
        EditMode = True
        AddMode = False
        Flag = False
        Call SetEntryMode()
        GpData.Enabled = True
        dtpVDate.Focus()
        btnEdit.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
        vspGrid.Enabled = True
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        lblToolTip.Text = "Cancel Last Action"
        Opt = MsgBox("Do you wish to Abort ?", MsgBoxStyle.YesNo)
        If Opt = MsgBoxResult.No Then
            dtpVDate.Focus()
            Exit Sub
        End If
        If AddMode Then
            dtMaster = objPostedVouchers.LoadAllMaster()
            rowNum = dtMaster.Rows.Count - 1
            Flag = True
            Call SetEntryMode()
            Call LoadMaster()
            objPostedVouchers.BrCode = lblBrCode.Text
            objPostedVouchers.Type = lblType.Text
            objPostedVouchers.VNo = lblVNo.Text
            dtDetail = objPostedVouchers.LoadAllDetail()
            Call LoadDetail()
        Else
            Flag = True
            Call SetEntryMode()
            Call LoadMaster()
            Call LoadDetail()
        End If

        GpData.Enabled = False
        btnSave.Enabled = False
        btnCancel.Enabled = False
        vspGrid.Enabled = False
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        lblToolTip.Text = "Delete Current Record"
        Opt = MsgBox("Are You Sure To Delete Current Record", MsgBoxStyle.YesNo)
        If Opt = MsgBoxResult.Yes Then
            objPostedVouchers.DelVouchers()
            dtMaster = objPostedVouchers.LoadAllMaster()
            rowNum = dtMaster.Rows.Count - 1
            If rowNum >= 0 Then
                Call LoadMaster()
                objPostedVouchers.BrCode = lblBrCode.Text
                objPostedVouchers.Type = lblType.Text
                objPostedVouchers.VNo = lblVNo.Text
                dtDetail = objPostedVouchers.LoadAllDetail()
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

        'strFind = "SELECT BrCode,Vno, Cast(Vdate as Char(12)) As Date FROM " & tableName & _
        '          " WHERE Type = '" & mType & "' " & mOpen & _
        '          " ORDER BY BrCode,VNO"
        strFind = "SELECT BrCode+Type+VNo Vno, Cast(Vdate as Char(12)) As Date FROM " & tableName & _
                  " ORDER BY BrCode,Type,VNO"
        ObjFind.PMessage = "GLHead"
        ObjFind.sqlqueryFun = strFind
        ObjFind.ShowDialog()

        If ObjFind.PbOk = True Then
            Call ClearAll()
            lblBrCode.Text = Mid(ObjFind.strPKfun, 1, 3) & ""
            objPostedVouchers.BrCode = lblBrCode.Text
            objPostedVouchers.Type = Mid(ObjFind.strPKfun, 4, 2)
            objPostedVouchers.VNo = Mid(ObjFind.strPKfun, 6) & ""
            dtMaster = objPostedVouchers.LoadAllMaster
            Call LoadMaster()
            dtDetail = objPostedVouchers.LoadAllDetail()
            Call LoadDetail()
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        lblToolTip.Text = "Close Form"
        Me.Close()
    End Sub

    Private Sub btnTop_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTop.Click
        rowNum = 0
        btnTop.Enabled = False
        btnPrevious.Enabled = False
        btnNext.Enabled = True
        btnBottom.Enabled = True
        Call LoadMaster()
        objPostedVouchers.BrCode = lblBrCode.Text
        objPostedVouchers.Type = lblType.Text
        objPostedVouchers.VNo = lblVNo.Text
        dtDetail = objPostedVouchers.LoadAllDetail()
        Call ClearGrid()
        Call LoadDetail()
        lblToolTip.Text = "Move To First Record"
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
        objPostedVouchers.BrCode = lblBrCode.Text
        objPostedVouchers.Type = lblType.Text
        objPostedVouchers.VNo = lblVNo.Text
        dtDetail = objPostedVouchers.LoadAllDetail()
        Call ClearGrid()
        Call LoadDetail()
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
        objPostedVouchers.BrCode = lblBrCode.Text
        objPostedVouchers.Type = lblType.Text
        objPostedVouchers.VNo = lblVNo.Text
        dtDetail = objPostedVouchers.LoadAllDetail()
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
        End If
        Call LoadMaster()
        objPostedVouchers.BrCode = lblBrCode.Text
        objPostedVouchers.Type = lblType.Text
        objPostedVouchers.VNo = lblVNo.Text
        dtDetail = objPostedVouchers.LoadAllDetail()
        Call ClearGrid()
        Call LoadDetail()
        lblToolTip.Text = "Move To Previous Record"
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        lblToolTip.Text = "Refresh Records"
        dtMaster = objPostedVouchers.LoadAllMaster()
        rowNum = dtMaster.Rows.Count - 1
        If rowNum >= 0 Then
            Call LoadMaster()
            objPostedVouchers.BrCode = lblBrCode.Text
            objPostedVouchers.Type = lblType.Text
            objPostedVouchers.VNo = lblVNo.Text
            dtDetail = objPostedVouchers.LoadAllDetail()
            Call LoadDetail()
            btnExit.Focus()
        Else
            MsgBox("No Record Found", MsgBoxStyle.Information)
            Call ClearAll()
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim mi As Integer

        lblToolTip.Text = "Save Current Record"
        If CheckValidation() Then
            objPostedVouchers.getConnection()
            objPostedVouchers.BeginTransaction()
            Try
                SetDataMaster()
                objPostedVouchers.EditMaster()
                For mi = 1 To vspGrid.MaxRows
                    SetData(mi)
                    objPostedVouchers.EditDetail()
                Next
                Flag = True
                Call SetEntryMode()
                GpData.Enabled = False
                btnSave.Enabled = False
                btnCancel.Enabled = False
            Catch ex As Exception
                MsgBox(ex.Message)
                objPostedVouchers.RollBack()
            End Try
        End If
        vspGrid.Enabled = False
        objPostedVouchers.CommitTransction()
    End Sub

    Private Function CheckValidation() As Boolean
        If dtpVDate.Text = "" Then
            MsgBox("Please Enter Voucher Date", MsgBoxStyle.Information, SysCompany)
            dtpVDate.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub SetDataMaster()
        objPostedVouchers.BrCode = lblBrCode.Text
        objPostedVouchers.Type = lblType.Text
        objPostedVouchers.VNo = lblVNo.Text
        objPostedVouchers.VDate = GetDate(dtpVDate.Value, "dd-MMM-yyyy")
        objPostedVouchers.RefRemarks = Trim(txtPurpose.Text)
        If AddMode Then
            objPostedVouchers.AddOn = SySDate
            objPostedVouchers.AddBy = SysUserID
            'objBranch.AddBy = SysUserID
        ElseIf EditMode Then
            objPostedVouchers.EditOn = SySDate
            objPostedVouchers.EditBy = SysUserID
            'objBranch.AddBy = SysUserID
        End If
    End Sub

    Private Sub SetData(ByVal rowIndex As Integer)
        Dim mTemp As Object
        Dim mAmount As Double

        Erase mTemp
        vspGrid.GetText(1, rowIndex, mTemp)
        If mTemp <> "" Then
            objPostedVouchers.BrCode = lblBrCode.Text
            objPostedVouchers.Type = lblType.Text
            objPostedVouchers.VNo = lblVNo.Text
            objPostedVouchers.SeqNo = Format(rowIndex, "00000")
            objPostedVouchers.VDate = GetDate(dtpVDate.Value, "dd-MMM-yyyy")
            objPostedVouchers.Code = aCode2Str(mTemp)
            Erase mTemp
            vspGrid.GetText(3, rowIndex, mTemp)
            objPostedVouchers.Remarks = mTemp
            Erase mTemp
            vspGrid.GetText(4, rowIndex, mTemp)
            mAmount = Val(mTemp)
            If mAmount > 0 Then
                objPostedVouchers.Debit = Format(mAmount, "##,###,###,###.##")
            Else
                objPostedVouchers.Debit = "0.00"
            End If
            Erase mTemp
            vspGrid.GetText(5, rowIndex, mTemp)
            mAmount = Val(mTemp)
            If mAmount > 0 Then
                objPostedVouchers.Credit = Format(mAmount, "##,###,###,###.##")
            Else
                objPostedVouchers.Credit = "0.00"
            End If
            Erase mTemp
            vspGrid.GetText(6, rowIndex, mTemp)
            objPostedVouchers.RfCode = aCode2Str(mTemp)
        End If
    End Sub

    Private Sub dtpVDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpVDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtPurpose_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPurpose.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click

    End Sub

    Private Sub GpData_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GpData.Enter

    End Sub
End Class