
Imports System.Data
Imports System.Data.SqlClient
Imports Basic.Constants.ProjConst
Imports Basic.DAL
Imports Basic.Reports
Imports Basic.DAL.Utils

Public Class FrmOrder


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

    End Sub

    Private Sub cmbClrType_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cmbClrType.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub


    Private Sub cmbCountParty_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cmbCountParty.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub cmbFund_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cmbFund.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub cmbSecu_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cmbSecu.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub cmbSetlMode_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cmbSetlMode.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub cmbSubType_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cmbSubType.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub cmbSymbol_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cmbSymbol.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub cmbTrade_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cmbTrade.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub cmbValidity_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cmbValidity.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub ComboBox6_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles ComboBox6.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub dtpOrderDate_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dtpOrderDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub dtpValidDate_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dtpValidDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtAmnt_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtAmnt.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtFaceVal_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtFaceVal.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtGOC_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtGOC.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtName_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtPrice_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtPrice.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtQty_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtRefNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtRefNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtRem_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtRem.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtSec_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtSec.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtUserDef_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtUserDef.KeyDown
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
            'rowNum = dtAccount.Rows.Count - 1
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
        ' If rowNum < dtAccount.Rows.Count - 1 Then
        rowNum = rowNum + 1
        btnNext.Enabled = True
        btnBottom.Enabled = True
        btnPrevious.Enabled = True
        btnTop.Enabled = True
        Call SetButtonPrinciple()
        Call SetButton()
        ' Else
        'rowNum = dtAccount.Rows.Count - 1
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

    Private Sub frmBroker_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Constants.ProjConst.mBroker = False
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        lblToolTip.Text = "Close Form"
        Me.Close()
    End Sub

    Private Sub GpData_Enter(sender As System.Object, e As System.EventArgs) Handles GpData.Enter

    End Sub
End Class