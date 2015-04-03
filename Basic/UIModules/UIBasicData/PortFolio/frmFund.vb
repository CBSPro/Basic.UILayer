Imports System.Data
Imports System.Data.SqlClient
Imports Basic.Constants.ProjConst
Imports Basic.DAL
Imports Basic.Reports
Imports Basic.DAL.Utils

Public Class frmFund





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

        txtAccNo.Text = ""
        txtAccruedIntrestTFC.Text = ""
        txtAmortizationTFC.Text = ""
        txtAmortizationTFC.Text = ""
        txtBnkAdress.Text = ""
        txtCompcode.Text = ""
        txtCostCenter.Text = ""
        txtdbName.Text = ""
        txtdescription.Text = ""
        txtMnemoGL.Text = ""
        txtMnemonic.Text = ""
        txtName.Text = ""
        txtSaleLoad.Text = ""
        txtsysCodeGL.Text = ""
        txtsysCode.Text = ""
        txtSiteCode.Text = ""
        txtSearch.Text = ""



    End Sub


    Private Sub chkAcruedIntPIB_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles chkAcruedIntPIB.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub chkAmortizationPIB_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles chkAmortizationPIB.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub chkBrokerage_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles chkBrokerage.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub chkBrokeragePIB_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles chkBrokeragePIB.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub chkBrokerageTBill_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles chkBrokerageTBill.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub chkBrokerageTFC_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles chkBrokerageTFC.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub chkCVT_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles chkCVT.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub chkFED_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles chkFED.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub cmbCompany_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cmbCompany.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub cmbFundType_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cmbFundType.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub cmbType_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cmbType.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub dtGL_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dtGL.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub dtpStartDate_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dtpStartDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtAccNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtAccNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtAccruedIntrestTFC_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtAccruedIntrestTFC.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtAmortizationTFC_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtAmortizationTFC.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtBnkAdress_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBnkAdress.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtCompcode_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCompcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtCostCenter_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCostCenter.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtdbName_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtdbName.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtdesciptionGL_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtdesciptionGL.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtdescription_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtdescription.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtMnemoGL_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtMnemoGL.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtMnemonic_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtMnemonic.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtName_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtNameGL_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtNameGL.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtSaleLoad_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtSaleLoad.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtSiteCode_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtSiteCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtsysCode_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtsysCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtsysCodeGL_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtsysCodeGL.KeyDown
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



    Private Sub frmFund_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Constants.ProjConst.mFund = False
    End Sub
End Class