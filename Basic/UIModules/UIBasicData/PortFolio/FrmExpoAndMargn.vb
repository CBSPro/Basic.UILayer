Imports System.Data
Imports System.Data.SqlClient
Imports Basic.Constants.ProjConst
Imports Basic.DAL
Imports Basic.Reports
Imports Basic.DAL.Utils

Public Class FrmExpoAndMargn


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
        txtAmnt.Text = ""
        txtDesc.Text = ""
        txtSearch.Text = ""
        txtsysCode.Text = ""

    End Sub


    Private Sub txtAmnt_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtAmnt.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtDesc_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtDesc.KeyDown
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

    Private Sub cmbFund_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cmbFund.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub cmbInstitute_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cmbInstitute.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub cmbInstituteType_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cmbInstituteType.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub cmbMode_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cmbMode.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub dtpValid_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dtpValid.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub
End Class