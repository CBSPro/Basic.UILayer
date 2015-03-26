Imports System.Data
Imports System.Data.SqlClient
Imports Basic.DAL
Imports Basic.DAL.Utils
Imports Basic.Constants

Public Class frmRPT_PostedVoucher

    Dim objBrowseGL As New cBrowseGL

    Dim dtBrowseGL As New DataTable
    Dim ObjFind As Grid_Help
    Dim strFind As String
    Dim mReport As String
    Dim RepName As String
    Dim StrRepHdr1 As String
    Dim StrRepHdr2 As String
    Dim StrRepHdr3 As String
    Dim StrFilter As String
    Dim rowNum As Integer

    Private Sub frmRPT_PostedVoucher_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Constants.ProjConst.mPPstVouchers = False
    End Sub

    Private Sub frmRPT_PostedVoucher_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.MdiParent = frmMdi
        If Constants.ProjConst.pPara = 18 Then
            Call SetAccParam()
            Me.Text = "Posted Vouchers"
            Me.Height = 230
            GpSearch.Height = 117
            Label1.Visible = True
            Label2.Visible = True
            cboBranch.Visible = True
            cboType.Visible = True
            Label1.Top = 16
            cboBranch.Top = 13
            Label2.Top = 40
            cboType.Top = 37
            Label3.Top = 65
            Label3.Text = "Starting Voucher No."
            txtStartVNo.Top = 62
            Label4.Top = 88
            Label4.Text = "  Ending Voucher No."
            txtEndVNo.Top = 85
            btnPreview.Top = 121
            btnPrint.Top = 121
            btnClose.Top = 121
            dtBrowseGL = objBrowseGL.FillBranch
            rowNum = dtBrowseGL.Rows.Count - 1
            If rowNum >= 0 Then
                Call LoadBranch()
            End If
            dtBrowseGL = objBrowseGL.FillType
            rowNum = dtBrowseGL.Rows.Count - 1
            If rowNum >= 0 Then
                Call LoadType()
            End If
        ElseIf Constants.ProjConst.pPara = 19 Then
            Me.Text = "Users Maintenance"
            Label1.Visible = False
            Label2.Visible = False
            cboBranch.Visible = False
            cboType.Visible = False
            Label3.Top = 16
            Label3.Text = "Starting User ID"
            txtStartVNo.Top = 13
            Label4.Top = 40
            Label4.Text = "  Ending User ID"
            txtEndVNo.Top = 37
            GpSearch.Height = 70
            btnPreview.Top = 72
            btnPrint.Top = 72
            btnClose.Top = 72
            Me.Height = 180
        End If
    End Sub

    Sub LoadBranch()
        Dim mi As Integer

        'cboBranch.Items.Add("All")
        For mi = 0 To rowNum
            cboBranch.Items.Add(dtBrowseGL.Rows(mi).Item("BrCode") + " : " + dtBrowseGL.Rows(mi).Item("BrName"))
        Next
        'cboBranch.Items.IndexOf(1)
    End Sub

    Sub LoadType()
        Dim mi As Integer

        'cboType.Items.Add("All")
        For mi = 0 To rowNum
            cboType.Items.Add(dtBrowseGL.Rows(mi).Item("Type"))
        Next
    End Sub

    Private Sub txtStartVNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStartVNo.KeyDown
        ObjFind = New Grid_Help
        If e.KeyCode = Keys.F1 Then
            If Constants.ProjConst.pPara = 18 Then
                ObjFind.PMessage = "GLHead"
                strFind = "SELECT Vno,Refremarks FROM GLHead WHERE BrCode = " & _
                   "'" & Mid(cboBranch.Text, 1, 3) & "' And Type = '" & cboType.Text & "' " & _
                   "And Posted = 'Y' ORDER BY BrCode, Vno"
            ElseIf Constants.ProjConst.pPara = 19 Then
                ObjFind.PMessage = "Users"
                strFind = "SELECT UserID, UserName FROM Users ORDER BY UserID"
            End If
            ObjFind.sqlqueryFun = strFind
            ObjFind.ShowDialog()

            If ObjFind.PbOk = True Then
                Me.txtStartVNo.Text = ObjFind.strPKfun & ""
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtEndVNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEndVNo.KeyDown
        ObjFind = New Grid_Help
        If e.KeyCode = Keys.F1 Then
            If Constants.ProjConst.pPara = 18 Then
                ObjFind.PMessage = "GLHead"
                strFind = "SELECT Vno,Refremarks FROM GLHead WHERE BrCode = " & _
                   "'" & Mid(cboBranch.Text, 1, 3) & "' And Type = '" & cboType.Text & "' " & _
                   "And Posted = 'Y' ORDER BY BrCode, Vno"
            ElseIf Constants.ProjConst.pPara = 19 Then
                ObjFind.PMessage = "Users"
                strFind = "SELECT UserID, UserName FROM Users ORDER BY UserID"
            End If
            ObjFind.sqlqueryFun = strFind
            ObjFind.ShowDialog()

            If ObjFind.PbOk = True Then
                Me.txtEndVNo.Text = ObjFind.strPKfun & ""
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtStartVNo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtStartVNo.Validating
        If Trim(txtStartVNo.Text) <> "" Then
            If Constants.ProjConst.pPara = 18 Then
                mSQL = "SELECT VNo FROM GLHead WHERE BrCode = '" & Mid(cboBranch.Text, 1, 3) & "' " & _
                   "And Vno = '" & Trim(txtStartVNo.Text) & "' And Type = '" & cboType.Text & "' " & _
                   "And Posted = 'Y'"
                mSQL = GetFldValue(mSQL, "VNo")
            ElseIf Constants.ProjConst.pPara = 19 Then
                mSQL = "SELECT UserID, UserName FROM Users Where UserID = " & _
                       "'" & Trim(txtStartVNo.Text) & "'"
                mSQL = GetFldValue(mSQL, "UserID")
            End If
            If mSQL = "" Then
                MsgBox("No Record Found", vbInformation, Constants.ProjConst.SysCompany)
                txtStartVNo.Text = ""
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub txtEndVNo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEndVNo.Validating
        If Trim(txtEndVNo.Text) <> "" Then
            If Constants.ProjConst.pPara = 18 Then
                mSQL = "SELECT VNo FROM GLHead WHERE BrCode = '" & Mid(cboBranch.Text, 1, 3) & "' " & _
                   "And Vno = '" & Trim(txtEndVNo.Text) & "' And Type = '" & cboType.Text & "' " & _
                   "And Posted = 'Y'"
                mSQL = GetFldValue(mSQL, "VNo")
            ElseIf Constants.ProjConst.pPara = 19 Then
                mSQL = "SELECT UserID, UserName FROM Users Where UserID = " & _
                       "'" & Trim(txtEndVNo.Text) & "'"
                mSQL = GetFldValue(mSQL, "UserID")
            End If
            If mSQL = "" Then
                MsgBox("No Record Found", vbInformation, Constants.ProjConst.SysCompany)
                txtEndVNo.Text = ""
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub btnPreview_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Call CallReport(0)
    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Call CallReport(1)
    End Sub

    Sub CallReport(ByVal mPara As Integer)
        'Dim CReports As New Crystal.CrystalReport

        If Trim(txtStartVNo.Text) = "" Then
            MsgBox("Starting Value Can't be Empty", vbInformation, Constants.ProjConst.SysCompany)
            txtStartVNo.Focus()
            Exit Sub
        ElseIf Trim(txtEndVNo.Text) = "" Then
            MsgBox("Ending Value Can't be Empty", vbInformation, Constants.ProjConst.SysCompany)
            txtEndVNo.Focus()
            Exit Sub
        End If

        ' ''***************
        ' ''Report Printing
        ' ''***************

        If Constants.ProjConst.pPara = 18 Then
            If cboType.Text = "BR" Then
                Constants.ProjConst.RepTitle = "Bank Receipt Voucher"
            ElseIf cboType.Text = "BP" Then
                Constants.ProjConst.RepTitle = "Bank Payment Voucher"
            ElseIf cboType.Text = "CR" Then
                Constants.ProjConst.RepTitle = "Cash Receipt Voucher"
            ElseIf cboType.Text = "CP" Then
                Constants.ProjConst.RepTitle = "Cash Payment Voucher"
            ElseIf cboType.Text = "JV" Then
                Constants.ProjConst.RepTitle = "Journal Voucher"
            ElseIf cboType.Text = "GR" Then
                Constants.ProjConst.RepTitle = "Goods Receipt"
            ElseIf cboType.Text = "PR" Then
                Constants.ProjConst.RepTitle = "Purchase Return"
            ElseIf cboType.Text = "IS" Then
                Constants.ProjConst.RepTitle = "Issue"
            ElseIf cboType.Text = "IR" Then
                Constants.ProjConst.RepTitle = "Issue Return"
            ElseIf cboType.Text = "IF" Then
                Constants.ProjConst.RepTitle = "Sales"
            ElseIf cboType.Text = "FR" Then
                Constants.ProjConst.RepTitle = "Sales Return"
            ElseIf cboType.Text = "AD" Then
                Constants.ProjConst.RepTitle = "Adjustment"
            ElseIf cboType.Text = "FD" Then
                Constants.ProjConst.RepTitle = "Fixed Asset Addition"
            ElseIf cboType.Text = "MT" Then
                Constants.ProjConst.RepTitle = "Fixed Asset Maintenance"
            End If
            RepName = "GLVoucherPosted.Rpt"
        ElseIf Constants.ProjConst.pPara = 19 Then
            RepName = "UserMaintenance.Rpt"
        End If

        Dim path As String = Constants.ProjConst.RepPath & RepName

        Dim rptDoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptDoc.Load(path)

        'StrRepHdr1 = "From " & txtStart.Text & " To " & txtEnd.Text
        'StrRepHdr2 = ""

        If Constants.ProjConst.pPara = 18 Then
            rptDoc.SetParameterValue(0, Mid(cboBranch.Text, 1, 3))
            rptDoc.SetParameterValue(1, txtStartVNo.Text)
            rptDoc.SetParameterValue(2, txtEndVNo.Text)
            rptDoc.SetParameterValue(3, cboType.Text)
        ElseIf Constants.ProjConst.pPara = 19 Then
            rptDoc.SetParameterValue(0, txtStartVNo.Text)
            rptDoc.SetParameterValue(1, txtEndVNo.Text)
        End If
        If Constants.ProjConst.pPara = 18 Then
            rptDoc.SetParameterValue("@ComDetail", Trim(Mid(cboBranch.Text, 6, 50)))
            rptDoc.SetParameterValue("@RepTitle", Constants.ProjConst.RepTitle)
        End If
        frmReport.Show()
        frmReport.ShowTransReport(rptDoc, "AccSys")
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub cboBranch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboBranch.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub cboType_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboType.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtStartVNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStartVNo.TextChanged

    End Sub
End Class