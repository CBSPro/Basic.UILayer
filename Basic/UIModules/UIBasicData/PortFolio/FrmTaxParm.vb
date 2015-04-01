Imports System.Data
Imports System.Data.SqlClient
Imports Basic.Constants.ProjConst
Imports Basic.DAL
Imports Basic.Reports
Imports Basic.DAL.Utils

Public Class FrmTaxParm






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
        txtSearch.Text = ""
        txtTaxAmnt.Text = ""
        txtTaxPercent.Text = ""

    End Sub


    Private Sub FrmTaxParm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub



    Private Sub txtSearch_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtTaxAmnt_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtTaxAmnt.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtTaxPercent_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtTaxPercent.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub
End Class