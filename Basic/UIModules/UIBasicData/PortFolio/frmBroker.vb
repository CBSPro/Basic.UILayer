
Imports System.Data
Imports System.Data.SqlClient
Imports Basic.Constants.ProjConst
Imports Basic.DAL
Imports Basic.Reports
Imports Basic.DAL.Utils


Public Class frmBroker

    Dim objBroker As New cBroker
    Dim dtBroker As New DataTable


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

        txtAdress.Text = ""
        txtBrokerCode.Text = ""
        txtCFS.Text = ""
        txtDescription.Text = ""
        txtEmail.Text = ""
        txtFax.Text = ""
        txtsysCode.Text = ""
        txtIAS.Text = ""
        txtMnemo.Text = ""
        txtName.Text = ""
        txtEmail.Text = ""
        txtFax.Text = ""
        txtNCSS.Text = ""
        txtPhone.Text = ""
        txtsysCode.Text = ""
        txtSearch.Text = ""

    End Sub

    Private Sub frmBroker_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
        Me.MdiParent = frmMdi
        'GpACDef.Enabled = False
        Flag = True
        'Call SetAccParam()
        Call SetEntryMode()
        'GpStatus.Enabled = False
        'mskCode.Mask = aMaskCode
        dtBroker = objBroker.LoadAllCodes()
        'dtLookup = objBroker.LoadAllCodes()
        'mMenuStr = "Select ROW_NUMBER()OVER (ORDER BY Code) AS Row,Code,Description,AccType,Status," & _
        '            "CONVERT(varchar(13),OpenDate,106) As OpenDate from Codes"
        'Call MenuGridLoad(mMenuStr)
        rowNum = dtBroker.Rows.Count - 1
        If rowNum >= 0 Then
            ' Call LoadValue()
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

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        AddMode = True
        EditMode = False
        Flag = False
        'mskCode.Enabled = True
        Call SetEntryMode()
        btnSave.Enabled = True
        btnCancel.Enabled = True
        EmptyControls(Me)
        Call ClearAll()
        'GpStatus.Enabled = True
        'GpACDef.Enabled = True
        lblCompany.Text = "Recorded On " & Format(SySDate, "dd-MMM-yyyy")
        lblToolTip.Text = "Add New Record"
        lblBy.Text = "Recorded By : " & SysUserID
        txtBrokerCode.SelectionStart = 0
        txtBrokerCode.Focus()
    End Sub
    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        lblToolTip.Text = "Delete Current Record"
        Opt = MsgBox("Are You Sure To Delete Current Record", MsgBoxStyle.YesNo)
        If Opt = MsgBoxResult.Yes Then
            '    objBroker.Code = aCode2Str(mskCode.Text)
            objBroker.DelCode()
            Call ClearAll()
            If rowNum > 0 Then
                rowNum = rowNum - 1
                ' Call LoadValue()
            Else
                MsgBox("No Record Found", MsgBoxStyle.Information)
            End If
        End If
        dtBroker = objBroker.LoadAllCodes()
        rowNum = dtBroker.Rows.Count - 1
        'Call LoadValue()
        ''rowNum = dtBroker.Rows.Count - 1
        'Call MenuGridLoad(mMenuStr)
        rowNum = dtBroker.Rows.Count - 1
        Call SetButtonPrinciple()
        Call SetButtonPrinciple()
        Call SetButton()
    End Sub
    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        lblToolTip.Text = "Edit Current Record"
        EditMode = True
        AddMode = False
        Flag = False
        'mskCode.Enabled = True
        Call SetEntryMode()
        'GpStatus.Enabled = True
        'GpACDef.Enabled = True
        'mskCode.Enabled = False
        'txtDesc1.Focus()
        btnEdit.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
    End Sub
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        dtBroker = objBroker.LoadAllCodes()
        rowNum = dtBroker.Rows.Count - 1
        AddMode = False
        EditMode = False
        'mskCode.Enabled = False
        lblToolTip.Text = "Cancel Last Action"
        Opt = MsgBox("Do you wish to Abort ?", MsgBoxStyle.YesNo)
        If Opt = MsgBoxResult.No Then
            txtBrokerCode.Focus()
            Exit Sub
        End If
        'Call LoadValue()
        Flag = True
        Call SetEntryMode()
        'GpACDef.Enabled = False
        btnSave.Enabled = False
        btnCancel.Enabled = False
        'GpStatus.Enabled = False
        rowNum = dtBroker.Rows.Count - 1
        'Call MenuGridLoad(mMenuStr)
        rowNum = dtBroker.Rows.Count - 1
        Call SetButtonPrinciple()
        Call SetButtonPrinciple()
        Call SetButton()
        AddMode = False
        EditMode = False
    End Sub
    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        dtBroker = objBroker.LoadAllCodes()
        'Call MenuGridLoad(mMenuStr)
        rowNum = dtBroker.Rows.Count - 1
        'Call LoadValue()
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
            'frmList.ShowDialog()
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
            rowNum = dtBroker.Rows.Count - 1
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
        If rowNum < dtBroker.Rows.Count - 1 Then
            rowNum = rowNum + 1
            btnNext.Enabled = True
            btnBottom.Enabled = True
            btnPrevious.Enabled = True
            btnTop.Enabled = True
            Call SetButtonPrinciple()
            Call SetButton()
        Else
            rowNum = dtBroker.Rows.Count - 1
            btnNext.Enabled = False
            btnBottom.Enabled = False
            btnPrevious.Enabled = True
            btnTop.Enabled = True
        End If
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

    Private Sub frmBroker_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Constants.ProjConst.mBroker = False
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        lblToolTip.Text = "Close Form"
        Me.Close()
    End Sub

    Private Sub txtAdress_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtAdress.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub


    Private Sub txtBrokerCode_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBrokerCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtCFS_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCFS.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtDescription_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtDescription.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtEmail_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtEmail.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtFax_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtFax.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtIAS_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtIAS.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtMnemo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtMnemo.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtName_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtNCSS_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtNCSS.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtPhone_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtPhone.KeyDown
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

    
End Class