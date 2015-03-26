Imports CrystalDecisions.CrystalReports.Engine.ReportDocument
Imports CrystalDecisions.CrystalReports.engine
Imports CrystalDecisions.reportsource
Imports CrystalDecisions.shared
Imports CrystalDecisions.windows.forms
Imports Basic.Constants

Public Class frmReport
    Public Shared Company As Object = "Chartac Business Services (Pvt) Ltd."
    Public Sub ShowTransReport(ByVal rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument, ByVal rptCaption As String)
        Try

       
        Me.Text = rptCaption

        ' rptDoc.DataSourceConnections.Item(Constants.ProjConst.SysServer, Constants.ProjConst.SysDataBase, False).SetLogon(Constants.ProjConst.SysUser, Constants.ProjConst.SysPassword)

        'rptDoc.SetDatabaseLogon("sa", "sql,123")
            rptDoc.SetDatabaseLogon(Constants.ProjConst.SysUser, Constants.ProjConst.SysPassword)
            rptView.ReportSource = rptDoc ' Assign Report Source to CRV
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub rptView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rptView.Load

    End Sub
End Class