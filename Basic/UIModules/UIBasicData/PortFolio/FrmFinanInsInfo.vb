Imports System.Data
Imports System.Data.SqlClient
Imports Basic.Constants.ProjConst
Imports Basic.DAL
Imports Basic.Reports
Imports Basic.DAL.Utils

Public Class FrmFinanInsInfo





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

        txtAddr.Text = ""
        txtBankAc.Text = ""
        txtBankAccNo.Text = ""
        txtBic.Text = ""
        txtBranchName.Text = ""

    End Sub


    Private Sub txtDesc_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDesc.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub



    Private Sub CBCounter_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles CBCounter.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub cbDepositry_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cbDepositry.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub CBSettlement_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles CBSettlement.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub cmbComp_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cmbComp.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub cmbInstituteType_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cmbInstituteType.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub rbBank_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles rbBank.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub rbSGL_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles rbSGL.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtAddr_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtAddr.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtBankAc_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBankAc.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtBic_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBic.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtBranchName_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBranchName.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtContPer_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtContPer.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtDesc2_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtDesc2.KeyDown
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

    Private Sub txtIpsAccNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtIpsAccNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtName_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtPH_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtPH.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtrate_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtrate.KeyDown
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

    Private Sub txtSysCode2_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtSysCode2.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub
End Class