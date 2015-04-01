
Imports System.Data
Imports System.Data.SqlClient
Imports Basic.Constants.ProjConst
Imports Basic.DAL
Imports Basic.Reports
Imports Basic.DAL.Utils


Public Class frmBroker





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




    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        'AddMode = True
        'EditMode = False
        'Flag = False
        'mskCode.Enabled = True
        'Call SetEntryMode()
        'btnSave.Enabled = True
        'btnCancel.Enabled = True
        'EmptyControls(Me)
        'Call ClearAll()
        'GpStatus.Enabled = True
        'GpACDef.Enabled = True
        'lblCompany.Text = "Recorded On " & Format(SySDate, "dd-MMM-yyyy")
        'lblToolTip.Text = "Add New Record"
        'lblBy.Text = "Recorded By : " & SysUserID
        'mskCode.SelectionStart = 0
        'mskCode.Focus()
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


    Private Sub btnTop_Click(sender As Object, e As System.EventArgs) Handles btnTop.Click
        If rowNum > 0 Then
            btnTop.Enabled = False
            btnPrevious.Enabled = False
            btnNext.Enabled = True
            btnBottom.Enabled = True
            'Call LoadValue()
            'lblToolTip.Text = "Move To First Record"
            'Call SetButtonPrinciple()
            'Call SetButton()
        End If
    End Sub
End Class