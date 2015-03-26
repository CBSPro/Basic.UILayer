Imports System.Data
Imports System.Data.SqlClient
Imports Basic.DAL
Imports Basic.DAL.Utils
Imports Basic.Constants


Public Class frmRPT_PTrans

    Dim objBrowseGL As New cBrowseGL

    Dim dtBrowseGL As New DataTable
    Dim ObjFind As Grid_Help
    Dim strFind As String
    Public mReport As String
    Public mBranch As String
    Public BranchName As String
    Public mVno As String
    Dim RepName As String
    Dim StrRepHdr1 As String
    Dim StrRepHdr2 As String
    Dim StrRepHdr3 As String
    Dim StrFilter As String
    Dim rowNum As Integer

    Sub LoadBranch()
        Dim mi As Integer

        'cboBranch.Items.Add("All")
        For mi = 0 To rowNum
            cboBranch.Items.Add(dtBrowseGL.Rows(mi).Item("BrCode") + " : " + dtBrowseGL.Rows(mi).Item("BrName"))
        Next
        cboBranch.Items.IndexOf(0)
    End Sub

    Private Sub frmRPT_PTrans_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'mReport = pPara
        If mReport = 5 Then
            mType = "BR"
            Label3.Text = "Starting Voucher No."
            Label4.Text = "  Ending Voucher No."
        ElseIf mReport = 6 Then
            mType = "BP"
            Label3.Text = "Starting Voucher No."
            Label4.Text = "  Ending Voucher No."
        ElseIf mReport = 7 Then
            mType = "CR"
            Label3.Text = "Starting Voucher No."
            Label4.Text = "  Ending Voucher No."
        ElseIf mReport = 8 Then
            mType = "CP"
            Label3.Text = "Starting Voucher No."
            Label4.Text = "  Ending Voucher No."
        ElseIf mReport = 20 Then
            mType = "JV"
            Label3.Text = "Starting Voucher No."
            Label4.Text = "  Ending Voucher No."
            'ElseIf mReport = 13 Then
            '    mType = "SV"
            '    Label3.Text = "Starting Voucher No."
            '    Label4.Text = "  Ending Voucher No."
        End If
        cboBranch.SelectedText = Constants.ProjConst.mcboBranch
        dtBrowseGL = objBrowseGL.FillBranch
        rowNum = dtBrowseGL.Rows.Count - 1
        If rowNum >= 0 Then
            Call LoadBranch()
        End If
        'If cboBranch.SelectedIndex = -1 Then
        cboBranch.SelectedIndex = 0
        'End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtStartVNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStartVNo.KeyDown
        ObjFind = New Grid_Help
        If e.KeyCode = Keys.F1 Then
            ObjFind.PMessage = "GLHead"
            strFind = "SELECT Vno,Refremarks FROM GLHead WHERE BrCode = " & _
               "'" & Mid(cboBranch.Text, 1, 3) & "' And Type = '" & mType & "' " & _
               "ORDER BY BrCode, Vno"
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
            ObjFind.PMessage = "GLHead"
            strFind = "SELECT Vno,Refremarks FROM GLHead WHERE BrCode = " & _
               "'" & Mid(cboBranch.Text, 1, 3) & "' And Type = '" & mType & "' " & _
               "ORDER BY BrCode, Vno"
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
            mSQL = "SELECT VNo FROM GLHead WHERE BrCode = '" & Mid(cboBranch.Text, 1, 3) & "' " & _
                   "And Vno = '" & Trim(txtStartVNo.Text) & "' And Type = '" & mType & "'"
            mSQL = GetFldValue(mSQL, "VNo")
            If mSQL = "" Then
                MsgBox("No Record Found", vbInformation, Constants.ProjConst.SysCompany)
                txtStartVNo.Text = ""
                txtEndVNo.Text = ""
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub txtEndVNo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEndVNo.Validating
        If Trim(txtEndVNo.Text) <> "" Then
            mSQL = "SELECT VNo FROM GLHead WHERE BrCode = '" & Mid(cboBranch.Text, 1, 3) & "' " & _
                   "And Vno = '" & Trim(txtEndVNo.Text) & "' And Type = '" & mType & "'"
            mSQL = GetFldValue(mSQL, "VNo")
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

        If cboBranch.Text = "" Then
            MsgBox("Branch Can't be Empty", vbInformation, Constants.ProjConst.SysCompany)
            cboBranch.Focus()
            Exit Sub
        ElseIf Trim(txtStartVNo.Text) = "" Then
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

        Select Case mReport

            Case 5
                If chkValidation.Checked = False Then
                    RepName = "GLVoucher.Rpt"
                    Constants.ProjConst.RepTitle = "Bank Receipt Voucher"
                Else
                    RepName = "GLValidate.Rpt"
                    Constants.ProjConst.RepTitle = "Bank Receipt Voucher Validation"
                End If
            Case 6
                If chkValidation.Checked = False Then
                    RepName = "GLVoucher.Rpt"
                    Constants.ProjConst.RepTitle = "Bank Payment Voucher"
                Else
                    RepName = "GLValidate.Rpt"
                    Constants.ProjConst.RepTitle = "Bank Payment Voucher Validation"
                End If
            Case 7
                If chkValidation.Checked = False Then
                    RepName = "GLVoucher.Rpt"
                    Constants.ProjConst.RepTitle = "Cash Receipt Voucher"
                Else
                    RepName = "GLValidate.Rpt"
                    Constants.ProjConst.RepTitle = "Cash Receipt Voucher Validation"
                End If
            Case 8
                If chkValidation.Checked = False Then
                    RepName = "GLVoucher.Rpt"
                    Constants.ProjConst.RepTitle = "Cash Payment Voucher"
                Else
                    RepName = "GLValidate.Rpt"
                    Constants.ProjConst.RepTitle = "Cash Payment Voucher Validation"
                End If
            Case 20
                'If chkValidation.Checked = False Then
                RepName = "GLVoucher.rpt"
                Constants.ProjConst.RepTitle = "Journal Voucher"
                'Else
                '    RepName = "GLValidate.Rpt"
                '    Constants.ProjConst.RepTitle = "Journal Voucher Validation"
                'End If
                'Case 13
                '    If chkValidation.Checked = False Then
                '        RepName = "GLVoucher.Rpt"
                '        Constants.ProjConst.RepTitle = "Salary Voucher"
                '    Else
                '        RepName = "GLValidate.Rpt"
                '        Constants.ProjConst.RepTitle = "Salary Voucher Validation"
                '    End If
            Case 0
                RepName = "GLVoucher.rpt"
        End Select

        Dim path As String = Constants.ProjConst.RepPath & RepName
        Dim rptDoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptDoc.Load(path)


        'StrRepHdr1 = "From " & txtStartVNo.Text & " To " & txtEndVNo.Text
        'StrRepHdr2 = ""

        StrRepHdr1 = Constants.ProjConst.SysCompany
        
        Dim obj As Object
        obj = Trim(Constants.ProjConst.SysCompany)
        Try
         
            rptDoc.SetParameterValue(0, Mid(cboBranch.Text, 1, 3))
            rptDoc.SetParameterValue(1, txtStartVNo.Text)
            rptDoc.SetParameterValue(2, txtEndVNo.Text)
            rptDoc.SetParameterValue(3, mType)
            rptDoc.SetParameterValue(4, Trim(Mid(cboBranch.Text, 6, 50)))
            rptDoc.SetParameterValue(5, Constants.ProjConst.RepTitle)
            frmReport.Refresh()
            frmReport.Show()
            frmReport.ShowTransReport(rptDoc, "AccSys")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.DefaultButton1, Constants.ProjConst.SysCompany)
        End Try
        End Sub

    Private Sub cboBranch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboBranch.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub chkValidation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkValidation.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub txtStartVNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStartVNo.TextChanged

    End Sub

    Private Sub txtStartVNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStartVNo.LostFocus
        txtEndVNo.Text = txtStartVNo.Text
    End Sub
    Public Sub rptPreview(ByVal sender As Object, ByVal e As System.EventArgs)
        Select Case mReport

            Case 5
                If chkValidation.Checked = False Then
                    RepName = "GLVoucher.Rpt"
                    Constants.ProjConst.RepTitle = "Bank Receipt Voucher"
                Else
                    RepName = "GLValidate.Rpt"
                    Constants.ProjConst.RepTitle = "Bank Receipt Voucher Validation"
                End If
            Case 6
                If chkValidation.Checked = False Then
                    RepName = "GLVoucher.Rpt"
                    Constants.ProjConst.RepTitle = "Bank Payment Voucher"
                Else
                    RepName = "GLValidate.Rpt"
                    Constants.ProjConst.RepTitle = "Bank Payment Voucher Validation"
                End If
            Case 7
                If chkValidation.Checked = False Then
                    RepName = "GLVoucher.Rpt"
                    Constants.ProjConst.RepTitle = "Cash Receipt Voucher"
                Else
                    RepName = "GLValidate.Rpt"
                    Constants.ProjConst.RepTitle = "Cash Receipt Voucher Validation"
                End If
            Case 8
                If chkValidation.Checked = False Then
                    RepName = "GLVoucher.Rpt"
                    Constants.ProjConst.RepTitle = "Cash Payment Voucher"
                Else
                    RepName = "GLValidate.Rpt"
                    Constants.ProjConst.RepTitle = "Cash Payment Voucher Validation"
                End If
            Case 20
                'If chkValidation.Checked = False Then
                RepName = "GLVoucher.rpt"
                Constants.ProjConst.RepTitle = "Journal Voucher"
            Case 0
                RepName = "GLVoucher.rpt"
        End Select

        Dim path As String = Constants.ProjConst.RepPath & RepName
        Dim rptDoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptDoc.Load(path)

        Dim obj As Object
        obj = Trim(Constants.ProjConst.SysCompany)
        Try

            rptDoc.SetParameterValue(0, Mid(mBranch, 1, 3))
            rptDoc.SetParameterValue(1, mVno)
            rptDoc.SetParameterValue(2, mVno)
            rptDoc.SetParameterValue(3, mType)
            rptDoc.SetParameterValue(4, BranchName)
            rptDoc.SetParameterValue(5, Constants.ProjConst.RepTitle)


            'rptDoc.SetParameterValue("BranchName", BranchName)
            'rptDoc.SetParameterValue("Constants.ProjConst.RepTitle", Constants.ProjConst.RepTitle)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.DefaultButton1, Constants.ProjConst.SysCompany)
        End Try
        frmReport.Refresh()
        frmReport.Show()
        frmReport.ShowTransReport(rptDoc, "AccSys")
    End Sub
    'End Sub
End Class