Imports System.Data
Imports System.Data.SqlClient
Imports Basic.DAL
Imports Basic.DAL.Utils
Imports Basic.Constants.ProjConst

Public Class frmSRH_Vouchers
    Inherits System.Windows.Forms.Form

    Public SetFilter As Boolean
    Dim ObjFind As Grid_Help
    Dim strFind As String


    Private Sub frmSRH_Vouchers_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        rdbAll.Checked = True
        rdbPosted.Checked = False
        rdbUnposted.Checked = False
        dtpStartDate.Text = SySDate
        dtpEndDate.Text = SySDate
        txtRefBrCode.Text = GetFldValue("Select BrCode From SysParms", "BrCode")
        lblBrName.Text = GetFldValue("Select BrName From Branch Where BrCode = '" & Trim(txtRefBrCode.Text) & "'", "BrName")
    End Sub

    Private Sub dtpStartDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtpStartDate.Validating
        If dtpStartDate.Value > SySDate Then
            MsgBox("Starting Date Cannot Be Greater Than Current Date", vbInformation, SysCompany)
            e.Cancel = True
            dtpStartDate.Text = SySDate
        End If
    End Sub

    Private Sub dtpEndDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtpEndDate.Validating
        If dtpEndDate.Value > SySDate Then
            'If SySDate >= dtpEndDate.Text Then
            MsgBox("Ending Date Cannot Be Greater Than Current Date", vbInformation, SysCompany)
            e.Cancel = True
            dtpEndDate.Text = SySDate
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        SetFilter = False
        Me.Close()
    End Sub

    Private Sub btnOk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOk.Click
        SetFilter = True
        If rdbAll.Checked = True Then
            FltAll = True
        Else
            FltAll = False
        End If
        If rdbPosted.Checked = True Then
            Fltpost = True
        Else
            Fltpost = False
        End If
        If rdbUnposted.Checked = True Then
            FltUnpost = True
        Else
            FltUnpost = False
        End If
        Branch = Trim(txtRefBrCode.Text)
        SDate = dtpStartDate.Text
        EDate = dtpEndDate.Text
        Me.Close()
    End Sub

    Private Sub rdbAll_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbAll.Click
        If rdbAll.Checked = True Then
            rdbPosted.Checked = False
            rdbUnposted.Checked = False
        End If
    End Sub

    Private Sub rdbPosted_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbPosted.Click
        If rdbPosted.Checked = True Then
            rdbAll.Checked = False
            rdbUnposted.Checked = False
        End If
    End Sub

    Private Sub rdbUnposted_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbUnposted.Click
        If rdbUnposted.Checked = True Then
            rdbPosted.Checked = False
            rdbAll.Checked = False
        End If
    End Sub

    Private Sub txtRefBrCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRefBrCode.KeyDown
        ObjFind = New Grid_Help
        If e.KeyCode = Keys.F1 Then
            ObjFind.PMessage = "Branch"
            strFind = "SELECT BrCode,BrName FROM Branch Order By BrCode"
            ObjFind.sqlqueryFun = strFind
            ObjFind.ShowDialog()

            If ObjFind.PbOk = True Then
                Me.txtRefBrCode.Text = ObjFind.strPKfun & ""
                Me.lblBrName.Text = ObjFind.sqlqueryFun & ""
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtRefBrCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtRefBrCode.Validating
        If Trim(txtRefBrCode.Text) <> "" Then
            txtRefBrCode.Text = Format(Val(Trim(txtRefBrCode.Text)), "000")
            mSQL = "SELECT BrName FROM Branch WHERE BrCode = '" & Trim(txtRefBrCode.Text) & "'"
            mSQL = GetFldValue(mSQL, "BrName")
            lblBrName.Text = mSQL
            If mSQL = "" Then
                MsgBox("No Record Found", vbInformation, SysCompany)
                txtRefBrCode.Text = ""
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub dtpStartDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpStartDate.ValueChanged

    End Sub
End Class