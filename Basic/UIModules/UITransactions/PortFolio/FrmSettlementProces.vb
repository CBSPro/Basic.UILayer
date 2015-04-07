
Imports System.Data
Imports System.Data.SqlClient
Imports Basic.Constants.ProjConst
Imports Basic.DAL
Imports Basic.Reports
Imports Basic.DAL.Utils

Public Class FrmSettlementProces




    Private Sub CheckBox1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles CheckBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub cmbAllBrok_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cmbAllBrok.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub cmbAllSecu_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cmbAllSecu.KeyDown
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

    Private Sub cmbStatus_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cmbStatus.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    'Private Sub DateTimePicker1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles DateTimePicker1.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        SendKeys.Send("{Tab}")
    '    End If
    'End Sub

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
End Class