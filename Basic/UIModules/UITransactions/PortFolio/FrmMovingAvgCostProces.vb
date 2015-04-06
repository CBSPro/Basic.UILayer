
Imports System.Data
Imports System.Data.SqlClient
Imports Basic.Constants.ProjConst
Imports Basic.DAL
Imports Basic.Reports
Imports Basic.DAL.Utils

Public Class FrmMovingAvgCostProces


    Private Sub cmbAllBrok_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cmbAllBrok.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub cmbBroker_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cmbBroker.KeyDown
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

    Private Sub dtpFromDate_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dtpFromDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub dtpToDate_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dtpToDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub RadioButton1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles RadioButton1.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub RadioButton2_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles RadioButton2.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub RadioButton3_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles RadioButton3.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub
End Class