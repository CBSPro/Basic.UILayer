Imports System.Data
Imports System.Data.SqlClient
Imports Basic.Constants.ProjConst
Imports Basic.DAL
Imports Basic.Reports
Imports Basic.DAL.Utils

Public Class frmScrip






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

        txtAuthorizeCapital.Text = ""
        txtCompCode.Text = ""
        txtDescription.Text = ""
        txtDescription.Text = ""
        txtFaceValue.Text = ""
        txtName.Text = ""
        txtPaidUpCapital.Text = ""
        txtSearch.Text = ""
        txtSecurityCode.Text = ""
        txtSymbol.Text = ""
        txtsysCode.Text = ""



    End Sub


    Private Sub frmScrip_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub chkCDCelig_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles chkCDCelig.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub chkDelisted_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles chkDelisted.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub chkFutureTrade_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles chkFutureTrade.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub chkGrpOfcomp_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles chkGrpOfcomp.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub chkListedinstock_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles chkListedinstock.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub chkTransactionReport_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles chkTransactionReport.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub cmbGroupofCompany_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cmbGroupofCompany.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub CmbSector_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles CmbSector.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub cmbSystemCode_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cmbSystemCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub dtpDelistedDate_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dtpDelistedDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtAuthorizeCapital_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtAuthorizeCapital.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtCompCode_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCompCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtDescription_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtDescription.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtFaceValue_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtFaceValue.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtName_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtPaidUpCapital_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtPaidUpCapital.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtSecurityCode_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtSecurityCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtSymbol_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtSymbol.KeyDown
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