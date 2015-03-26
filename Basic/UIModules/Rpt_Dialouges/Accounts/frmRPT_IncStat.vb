Imports System.Data
Imports System.Data.SqlClient
Imports Basic.DAL
Imports Basic.DAL.Utils
Imports Basic.Constants.ProjConst

Public Class frmRPT_IncStat
    Inherits System.Windows.Forms.Form

    Dim objIncStat As New cIncStat

    Public SetFilter As Boolean
    Dim ObjFind As Grid_Help
    Dim strFind As String
    Dim SelFormula As String
    Dim STRFROMTO As String
    Dim StrFromDate As String
    Dim RepName As String

    Private Sub dtpDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub dtpDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtpDate.Validating
        If dtpDate.Text > SySDate Then
            MsgBox("Date Cannot Be Greater Than Current Date", vbInformation, SysCompany)
            e.Cancel = True
            dtpDate.Text = SySDate
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

    Private Sub txtStPageNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStPageNo.KeyDown
        ObjFind = New Grid_Help
        If e.KeyCode = Keys.F1 Then
            ObjFind.PMessage = "Branch"
            strFind = "SELECT MAX(PAGENO) AS PAGENO,MAX(HDR) AS HEADING FROM " & _
                      "PFTLOSS GROUP BY PAGENO"
            ObjFind.sqlqueryFun = strFind
            ObjFind.ShowDialog()

            If ObjFind.PbOk = True Then
                Me.txtStPageNo.Text = ObjFind.strPKfun & ""
                Me.LBLStPageNo.Text = ObjFind.sqlqueryFun & ""
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtEndPageNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEndPageNo.KeyDown
        ObjFind = New Grid_Help
        If e.KeyCode = Keys.F1 Then
            ObjFind.PMessage = "Branch"
            strFind = "SELECT MAX(PAGENO) AS PAGENO,MAX(HDR) AS HEADING FROM " & _
                      "PFTLOSS GROUP BY PAGENO"
            ObjFind.sqlqueryFun = strFind
            ObjFind.ShowDialog()

            If ObjFind.PbOk = True Then
                Me.txtEndPageNo.Text = ObjFind.strPKfun & ""
                Me.lblEndPageNo.Text = ObjFind.sqlqueryFun & ""
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtStPageNo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtStPageNo.Validating
        If Trim(txtStPageNo.Text) <> "" Then
            txtStPageNo.Text = Format(Val(Trim(txtStPageNo.Text)), "00")
            mSQL = "SELECT HDR FROM PFTLOSS WHERE PAGENO = '" & Trim(txtStPageNo.Text) & "'"
            mSQL = GetFldValue(mSQL, "HDR")
            LBLStPageNo.Text = mSQL
            If mSQL = "" Then
                MsgBox("No Record Found", vbInformation, SysCompany)
                txtStPageNo.Text = ""
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub txtEndPageNo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEndPageNo.Validating
        If Trim(txtEndPageNo.Text) <> "" Then
            txtEndPageNo.Text = Format(Val(Trim(txtEndPageNo.Text)), "00")
            mSQL = "SELECT HDR FROM PFTLOSS WHERE PAGENO = '" & Trim(txtEndPageNo.Text) & "'"
            mSQL = GetFldValue(mSQL, "HDR")
            lblEndPageNo.Text = mSQL
            If mSQL = "" Then
                MsgBox("No Record Found", vbInformation, SysCompany)
                txtEndPageNo.Text = ""
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

    Private Sub CallReport(ByVal mPara As Integer)

        StrFromDate = "AS ON " & Format(dtpDate.Value, "DD/MM/YYYY")

        SelFormula = "{PFTLOSS.PAGENO} >= '" & txtStPageNo.Text & "' " & _
                     "AND {PFTLOSS.PAGENO} <= '" & txtEndPageNo.Text & "'"

        If chkPrtNotes.Checked = True Then
            Me.Cursor = Cursors.WaitCursor
            objIncStat.DelDetail()
            If Trim(txtRefBrCode.Text) <> "000" Then
                Call Process_IncStat(txtStPageNo.Text, txtEndPageNo.Text, dtpDate.Value, True)
            Else
                'Call Process_IncStatAll(txtStPageNo.Text, txtEndPageNo.Text, dtpDate.Value, chkPrtNotes.Value)
            End If
            Me.Cursor = Cursors.Default
            RepName = "IncStat.Rpt"

            Dim path As String = RepPath & RepName

            Dim rptDoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc.Load(path)

            frmReport.Show()
            frmReport.ShowTransReport(rptDoc, "AccSys")
            RepName = "Notes.Rpt"

            Dim path1 As String = RepPath & RepName

            Dim rptDoc1 As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc1.Load(path1)

            frmReport.Show()
            frmReport.ShowTransReport(rptDoc1, "AccSys")
        End If
        ' ''** INCOME STATEMENT

        Me.Cursor = Cursors.WaitCursor
        objIncStat.DelDetail()
        If Trim(txtRefBrCode.Text) <> "000" Then
            Call Process_IncStat(txtStPageNo.Text, txtEndPageNo.Text, dtpDate.Value, False)
        Else
            'Call Process_IncStatAll(txtStPageNo.Text, txtEndPageNo.Text, dtpDate.Value, chkPrtNotes.Value)
        End If
        Me.Cursor = Cursors.Default
        RepName = "IncStat.Rpt"

        Dim path2 As String = RepPath & RepName

        Dim rptDoc2 As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptDoc2.Load(path2)

        frmReport.Show()
        frmReport.ShowTransReport(rptDoc2, "AccSys")
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub chkPrtNotes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkPrtNotes.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub frmRPT_IncStat_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        mPDefRep = False
    End Sub

    Private Sub frmRPT_IncStat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmMdi
        Me.Text = "Print Define Report"
        dtpDate.Text = SySDate
    End Sub

    Private Sub dtpDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDate.ValueChanged

    End Sub
End Class