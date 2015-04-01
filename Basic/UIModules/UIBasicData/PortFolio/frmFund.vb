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
End Class