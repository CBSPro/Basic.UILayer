Imports Microsoft.Win32
Imports System.Windows.Forms
Imports System.Text
Imports System.Windows.Forms.VisualStyles.BorderType
Imports System.Data
Imports System.Data.SqlClient
Imports Basic.DAL
Imports Basic.Constants
'Imports Basic.UILayer
Imports Basic.DAL.Utils




Public Class frmMdi

    Dim objConnection As Object
    Dim objConst As Constants.ProjConst
    Dim objLogin As New cLogin
    Dim objUsers As New cUsers
    Dim objMenu As New cMenu

    Dim dtMenu As DataTable
    Dim rowNum As Integer
    Dim dtLogin As New DataTable
    Dim rowNum1 As Integer
    Dim dtSecurity As DataTable
    Dim rowNum2 As Integer
    Dim mSeqNo As Integer

    Private Sub miExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miExit.Click
        Me.Close()
    End Sub

    Private Sub miBranch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmBranch.ShowDialog()
        If Constants.ProjConst.mBranch = False Then
            Dim frmBrnch As New frmBranch
            frmBrnch.Show()
            frmBrnch.WindowState = FormWindowState.Normal
            Constants.ProjConst.mBranch = True
        Else
            frmBranch.WindowState = FormWindowState.Normal
        End If
        Call onMenuSecurity()
    End Sub


    Private Sub frmMdi_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'SysTime = TimeOfDay
        'SySDate = Now()
        Me.mnuFile.Enabled = True
        Me.mnuTransactions.Enabled = False
        Me.mnuBasicData.Enabled = False
        Me.mnuReports.Enabled = False
        Me.mnuAdmin.Enabled = False
        Call Main()
        Logged = False
        frmLogin.ShowDialog()

    End Sub

    Private Sub miAccount_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If Constants.ProjConst.mAccMaintanance = False Then
            frmAccounts.Show()
            frmAccounts.WindowState = FormWindowState.Normal
            Constants.ProjConst.mAccMaintanance = True
        Else
            frmAccounts.WindowState = FormWindowState.Normal
        End If
        Call onMenuSecurity()
    End Sub

    Private Sub miBudget_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If mBudget = False Then
        '    frmBudget.Show()
        '    frmBudget.WindowState = FormWindowState.Normal
        '    mBudget = True
        'Else
        '    frmBudget.WindowState = FormWindowState.Normal
        'End If
        'Call onMenuSecurity()
    End Sub

    Private Sub miDefRep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If mDefReport = False Then
        '    frmRepDefinition.Show()
        '    frmRepDefinition.WindowState = FormWindowState.Normal
        '    mDefReport = True
        'Else
        '    frmRepDefinition.WindowState = FormWindowState.Normal
        'End If
        'Call onMenuSecurity()
    End Sub

    Private Sub miBPVoucher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub miBRVoucher_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        'pParaJV = 5
        'Dim frmBnkRecpt As New frmRecPay
        ''frmRecPay.ShowDialog()
        'If mfrmBR = False Then
        '    frmBnkRecpt.Show()

        '    mfrmBR = True
        'Else
        '    frmBnkRecpt.WindowState = FormWindowState.Normal
        '    'End If
        '    Call onMenuSecurity()
    End Sub

   

    Private Sub smiGeneralLedger_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If mGLScr = False Then
        '    'temp comments
        '    'frmBrowseGL.Show()
        '    mGLScr = True
        'Else
        '    'frmBrowseGL.WindowState = FormWindowState.Normal
        'End If
        'Call onMenuSecurity()
    End Sub

    Private Sub smiACStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If mCStatus = False Then
        '    Constants.ProjConst.pPara = 9
        '    frmACStatus.Show()
        '    mCStatus = True
        'End If
        'Dim AccCStatus As New frmACStatus
        'AccCStatus.MdiParent = Me
        'Constants.ProjConst.pPara = 9
        'If mCStatus = False Then
        '    AccCStatus.Show()
        '    AccCStatus.WindowState = FormWindowState.Normal
        '    mCStatus = True
        'Else
        '    AccCStatus.WindowState = FormWindowState.Normal
        'End If
        'Call onMenuSecurity()
    End Sub

    Private Sub smiBBOnScreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim BBookScr As New frmACStatus
        'BBookScr.MdiParent = Me
        'Constants.ProjConst.pPara = 10
        'If mBBookScr = False Then
        '    BBookScr.Show()
        '    BBookScr.WindowState = FormWindowState.Normal
        '    mBBookScr = True
        'Else
        '    BBookScr.WindowState = FormWindowState.Normal
        'End If
        'Call onMenuSecurity()
    End Sub

    Private Sub smiCBOnScreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim CBookScr As New frmACStatus
        'CBookScr.MdiParent = Me
        'Constants.ProjConst.pPara = 11
        'If mCBookScr = False Then
        '    CBookScr.Show()
        '    CBookScr.WindowState = FormWindowState.Normal
        '    mCBookScr = True
        'Else
        '    CBookScr.WindowState = FormWindowState.Normal
        'End If
        'Call onMenuSecurity()
        'Constants.ProjConst.pPara = 11
        'frmACStatus.ShowDialog()
    End Sub

    'Private Sub miAccRep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If mAcCStatus = False Then
    '        Constants.ProjConst.pPara = 12
    '        frmRPT_CodesStat.Show()
    '        mAcCStatus = True
    '    End If
    '    Dim AcCStatus As New frmINV_Status
    '    AcCStatus.MdiParent = Me
    '    Constants.ProjConst.pPara = 12
    '    If mAcCStatus = False Then
    '        AcCStatus.Show()
    '        AcCStatus.WindowState = FormWindowState.Normal
    '        mAcCStatus = True
    '    Else
    '        AcCStatus.WindowState = FormWindowState.Normal
    '    End If
    '    Call onMenuSecurity()
    'End Sub

    'Private Sub miBankBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Constants.ProjConst.pPara = 13
    '    'frmRPT_CodesStat.ShowDialog()
    '    Dim BBook As New frmINV_Status
    '    BBook.MdiParent = Me
    '    Constants.ProjConst.pPara = 13
    '    If mBBook = False Then
    '        BBook.Show()
    '        BBook.WindowState = FormWindowState.Normal
    '        mBBook = True
    '    Else
    '        BBook.WindowState = FormWindowState.Normal
    '    End If
    '    Call onMenuSecurity()
    'End Sub

    'Private Sub miCashBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Constants.ProjConst.pPara = 14
    '    'frmRPT_CodesStat.ShowDialog()

    '    Dim CBook As New frmINV_Status
    '    CBook.MdiParent = Me
    '    Constants.ProjConst.pPara = 14
    '    If mCBook = False Then
    '        CBook.Show()
    '        mCBook = True
    '    Else
    '        CBook.WindowState = FormWindowState.Normal
    '    End If
    '    Call onMenuSecurity()
    'End Sub

    'Private Sub miSchedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If mSubLedg = False Then
    '        Constants.ProjConst.pPara = 15
    '        frmINV_Status.Show()
    '        frmINV_Status.WindowState = FormWindowState.Normal
    '        mSubLedg = True
    '    Else
    '        frmINV_Status.WindowState = FormWindowState.Normal
    '    End If
    '    Call onMenuSecurity()
    'End Sub

    'Private Sub miTrialBal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'If mTBal = False Then
    '    '    Constants.ProjConst.pPara = 16
    '    '    frmRPT_TrialBal.Show()
    '    '    'frmRPT_TrialBal.MdiParent = Me
    '    '    mTBal = True
    '    'End If
    '    Dim TBal As New frmRPT_TrialBal
    '    TBal.MdiParent = Me
    '    Constants.ProjConst.pPara = 16
    '    If mTBal = False Then
    '        TBal.Show()
    '        TBal.WindowState = FormWindowState.Normal
    '        mTBal = True
    '    Else
    '        TBal.WindowState = FormWindowState.Normal
    '    End If
    '    Call onMenuSecurity()
    'End Sub



    'Private Sub miActTrial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'If mATrial = False Then
    '    '    Constants.ProjConst.pPara = 17
    '    '    frmRPT_TrialBal.Show()
    '    '    mATrial = False
    '    'End If
    '    Dim ATrial As New frmRPT_TrialBal
    '    ATrial.MdiParent = Me
    '    Constants.ProjConst.pPara = 17
    '    If mATrial = False Then
    '        ATrial.Show()
    '        ATrial.WindowState = FormWindowState.Normal
    '        mATrial = True
    '    Else
    '        ATrial.WindowState = FormWindowState.Normal
    '    End If
    '    Call onMenuSecurity()
    'End Sub

    'Private Sub miPPVouchers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If mPPstVouchers = False Then
    '        Constants.ProjConst.pPara = 18
    '        frmRPT_PostedVoucher.Show()
    '        frmRPT_PostedVoucher.WindowState = FormWindowState.Normal
    '        mPPstVouchers = True
    '    Else
    '        frmRPT_PostedVoucher.WindowState = FormWindowState.Normal
    '    End If
    '    Call onMenuSecurity()
    'End Sub

    'Private Sub miEditPVouchers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miEditPVouchers.Click
    '    If mEPostVoch = False Then
    '        frmPostedPass.Show()
    '        frmPostedPass.WindowState = FormWindowState.Normal
    '        mEPostVoch = True
    '    Else
    '        frmPostedPass.WindowState = FormWindowState.Normal
    '    End If
    '    Call onMenuSecurity()
    'End Sub

   


    'Private Sub miLogOut_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles miLogOut.Click
    '    If Logged Then
    '        cConnectionManager.CloseConnection(objConnection)
    '    End If
    '    'Call MenuSet(Me, False)
    '    Me.mnuFile.Enabled = True
    '    Me.mnuTransactions.Enabled = False
    '    Me.mnuBasicData.Enabled = False
    '    Me.mnuReports.Enabled = False
    '    Me.mnuAdmin.Enabled = False
    '    Me.Text = SysCompany & " " & SysSystem
    '    Logged = False
    'End Sub

    Private Sub miLogIn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles miLogIn.Click

        frmLogin.ShowDialog()

    End Sub

    '    Private Sub miAging_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        If mAAnalysis = False Then
    '            frmRPT_Aging.Show()
    '            frmRPT_Aging.WindowState = FormWindowState.Normal
    '            mAAnalysis = True
    '        Else
    '            frmRPT_Aging.WindowState = FormWindowState.Normal
    '        End If
    '        Call onMenuSecurity()
    '    End Sub

    '    Private Sub miChangePassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miChangePassword.Click
    '        If mCPass = False Then
    '            frmChangePass.Show()
    '            frmChangePass.WindowState = FormWindowState.Normal
    '            mCPass = True
    '        Else
    '            frmChangePass.WindowState = FormWindowState.Normal
    '        End If
    '        Call onMenuSecurity()
    '    End Sub

   
    '    Private Sub miTBCrossTab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        If mTBalCross = False Then
    '            frmRPT_PrtTBall.Show()
    '            frmRPT_PrtTBall.WindowState = FormWindowState.Normal
    '            mTBalCross = True
    '        Else
    '            frmRPT_PrtTBall.WindowState = FormWindowState.Normal
    '        End If
    '    End Sub

    '    Private Sub miPDefRep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        If mPDefRep = False Then
    '            frmRPT_IncStat.Show()
    '            frmRPT_IncStat.WindowState = FormWindowState.Normal
    '            mPDefRep = True
    '        Else
    '            frmRPT_IncStat.WindowState = FormWindowState.Normal
    '        End If
    '        Call onMenuSecurity()
    '    End Sub

    '    Private Sub miPDRCrossTab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        If mPDefRefCross = False Then
    '            frmRPT_PrtStat.Show()
    '            frmRPT_PrtStat.WindowState = FormWindowState.Normal
    '            mPDefRefCross = True
    '        Else
    '            frmRPT_PrtStat.WindowState = FormWindowState.Normal
    '        End If
    '        Call onMenuSecurity()
    '    End Sub

  





    '    Private Sub ExportDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportDataToolStripMenuItem.Click
    '        Call ExportGL()
    '        Call onMenuSecurity()
    '    End Sub
    Private Sub ImportDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportDataToolStripMenuItem.Click
        Call ImportGl()
        Call onMenuSecurity()
    End Sub
    Private Sub ImportGl()
        Try
            Dim ExpPath As String

            If MsgBox("This will copy new records from specifed files " _
                     & vbCrLf & " Do you want to continue?", vbYesNo) = vbNo Then
                Exit Sub
            End If
            ExpPath = InputBox("Enter Data file Directory")

            If ExpPath = "" Then
                Exit Sub
            End If

            If ExpPath.Substring(ExpPath.Length - 1, 1) <> "\" Then
                ExpPath = ExpPath & "\"
            End If
            Dim status As String = ""
            Dim Dir As String = Trim(ExpPath)
            objConnection = cConnectionManager.GetConnection()
            Dim objDatabaseManager As IDatabaseManager
            Dim objDBParameters As New cDBParameterList
            objDatabaseManager = cDataBaseManager.GetDatabaseManager()
            objDatabaseManager.SetConnection(objConnection)

            objDBParameters.AddParameter("@Status", status, "nvearchar")
            objDBParameters.AddParameter("@Dir", Dir, "nvarchar")
            objDatabaseManager.ExecuteNonQuery("GL_Import", objDBParameters)
            cConnectionManager.CloseConnection(objConnection)
            'MessageBox.Show("Data imported Successfully", SysCompany, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub


    Private Sub ExportGL()
        Dim ExpPath As String

        If MsgBox(" This will copy un-transfered records into text files and mark un-trasnfered record as Transfered" _
                    & "" & vbCrLf & " Do you want to continue?", vbYesNo) = vbNo Then
            Exit Sub

        End If

        Dim DataPath, strCommand As String
        On Error GoTo errH

        'ExpPath = repPathArr(0) & "GLExport"

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)
        objDatabaseManager.ExecuteNonQuery("GL_Export", objDBParameters)

        'strCommand = "bcp " & SysDataBase & ".DBO.TEMPGLedg  OUT " & ExpPath & "\TEMPGLedg.Txt -c -t, -r\n -S " & SysServer & " -U " & SysUser & " -P " & SysPassword
        'Shell(strCommand, vbHide)

        'strCommand = "bcp " & SysDataBase & ".DBO.TEMPGLHead  OUT " & ExpPath & "\TEMPGLHead.Txt -c -t, -r\n -S " & SysServer & " -U " & SysUser & " -P " & SysPassword
        'Shell(strCommand, vbHide)

        'strCommand = "bcp " & SysDataBase & ".DBO.TEMPCodes  OUT " & ExpPath & "\TEMPCodes.Txt -c -t, -r\n -S " & SysServer & " -U " & SysUser & " -P " & SysPassword
        'Shell(strCommand, vbHide)



        MsgBox("Data files copied to " & ExpPath)

        Exit Sub

errH:
        'MsgBox(Err.Description, vbCritical, SysCompany)
        Err.Clear()
    End Sub
    Public Function FormOpen(ByRef thisForm As Form) As Boolean
        Return thisForm.Visible
    End Function
    Public Sub onMenuSecurity()
        Dim MenuOption As String
        Dim ShowHide As Boolean

        'objUsers.UserID = SysUserID

        dtSecurity = objUsers.GetSecurity
        rowNum2 = dtSecurity.Rows.Count - 1
        If rowNum2 >= 0 Then
            rowNum2 = 0
            Do While rowNum2 < dtSecurity.Rows.Count
                MenuOption = dtSecurity.Rows(rowNum2).Item("MenuName").ToString
                ShowHide = dtSecurity.Rows(rowNum2).Item("ShowMenu").ToString
                Call SetMenuSecurity(MenuOption, ShowHide)
                rowNum2 = rowNum2 + 1
            Loop
        End If
    End Sub
    Private Sub frmRPT_InvAging_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim miInvAging As New frmRPT_InvAging
        'miInvAging.Show()
    End Sub

    '    Private Sub AToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AToolStripMenuItem.Click
    '        pParaJV = 6
    '        Dim Bnkfrm As New frmRecPay
    '        frmRecPay.MdiParent = Me
    '        If mfrmBP = False Then
    '            'Bnkfrm.MdiParent = Me
    '            Bnkfrm.Show()
    '            mfrmBP = True
    '        Else
    '            Bnkfrm.WindowState = FormWindowState.Maximized
    '        End If
    '        Call onMenuSecurity()
    '    End Sub

    '    Private Sub DisposalNoteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        'Constants.ProjConst.pPara = 3
    '        'frmFADisposal.MdiParent = Me
    '        'If mfrmFADisposal = False Then
    '        '    frmFADisposal.Show()
    '        '    mfrmFADisposal = True
    '        'Else
    '        '    frmFADisposal.WindowState = FormWindowState.Maximized
    '        'End If
    '    End Sub

  

    '    Private Sub LocationCodesMaintenanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        'frmBranch.ShowDialog()
    '        If mBranch = False Then
    '            Dim frmBrnch As New frmBranch
    '            frmBrnch.Show()
    '            frmBrnch.WindowState = FormWindowState.Normal
    '            mBranch = True
    '        Else
    '            frmBranch.WindowState = FormWindowState.Normal
    '        End If
    '        Call onMenuSecurity()

    '    End Sub

    Private Sub AccountCodesMaintenanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountCodesMaintenanceToolStripMenuItem.Click
        If Constants.ProjConst.mAccMaintanance = False Then
            frmAccounts.Show()
            frmAccounts.WindowState = FormWindowState.Maximized
            Constants.ProjConst.mAccMaintanance = True
        Else
            frmAccounts.WindowState = FormWindowState.Maximized
        End If
        'Call onMenuSecurity()

    End Sub



   

  

  
    'Private Sub FixedAssetLedgerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Dim miFALedger As New frmRPT_FA_PReports
    '    'Constants.ProjConst.pPara = 1
    '    'miFALedger.Show()
    'End Sub

    'Private Sub FixedAssetToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Dim miFAAddition As New frmRPT_FA_PReports
    '    'Constants.ProjConst.pPara = 2
    '    'miFAAddition.Show()
    'End Sub

    'Private Sub FixedAssetAdjustmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Dim miFAAdjustment As New frmRPT_FA_PReports
    '    'Constants.ProjConst.pPara = 3
    '    'miFAAdjustment.Show()
    'End Sub

    'Private Sub FixedAssetTransferToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Dim miFATransfer As New frmRPT_FA_PReports
    '    'Constants.ProjConst.pPara = 4
    '    'miFATransfer.Show()
    'End Sub

    'Private Sub FixedAssetDisposalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Dim miFADisposal As New frmRPT_FA_PReports
    '    'Constants.ProjConst.pPara = 5
    '    'miFADisposal.Show()
    'End Sub

    'Private Sub FixedAssetDepricitionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Dim miFADepr As New frmRPT_FA_PReports
    '    'Constants.ProjConst.pPara = 7
    '    'miFADepr.Show()
    'End Sub

    'Private Sub FixedAssetScheduleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Dim miFASchedule As New frmRPT_FA_PReports
    '    'Constants.ProjConst.pPara = 6
    '    'miFASchedule.Show()
    'End Sub



    'Private Sub SalaryStructurePrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Constants.ProjConst.pPara = 13
    '    'frmRPT_Report.ShowDialog()

    'End Sub

    'Private Sub AllowancesDeductionsReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    'frmRPT_EmpAllowDed.ShowDialog()
    'End Sub

    'Private Sub EmployeeAdvancesLoadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Constants.ProjConst.pPara = 1
    '    'Constants.ProjConst.pPara = 19
    '    'frmRPT_Report.ShowDialog()
    'End Sub

    'Private Sub EmployeePromotionHistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Constants.ProjConst.pPara = 8
    '    'frmRPT_Report.ShowDialog()
    'End Sub

    'Private Sub EmployeeTransferHistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Constants.ProjConst.pPara = 9
    '    'frmRPT_Report.ShowDialog()
    'End Sub

    'Private Sub BranchWiseEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Constants.ProjConst.pPara = 1
    '    'frmRPT_HRTrans.ShowDialog()
    'End Sub

    'Private Sub EmployeeLeavesRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Constants.ProjConst.pPara = 11
    '    'frmRPT_Report.ShowDialog()

    'End Sub

    'Private Sub EmployeeTermiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Constants.ProjConst.pPara = 12
    '    'frmRPT_Report.ShowDialog()

    'End Sub

    'Private Sub BranchWiseEmployeeCountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Dim RepName As String
    '    'Dim StrRepHdr1 As String
    '    'Dim StrRepHdr2 As String

    '    'RepName = "BrWiseEmpCount.rpt"
    '    'Dim path As String = RepPath & RepName

    '    'Dim rptDoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    '    'rptDoc.Load(path)

    '    'SysCompany = " "
    '    'StrRepHdr1 = "6-A, Block H, Ancillary Building, Gulberg Heights, Gulberg II, Lahore"
    '    'StrRepHdr2 = "Branch Wise No. of Employees"

    '    'rptDoc.SetParameterValue("Company", SysCompany)
    '    ''rptDoc.SetParameterValue("Detail", StrRepHdr1)
    '    'rptDoc.SetParameterValue("Detail1", StrRepHdr2)
    '    'rptDoc.SetParameterValue("Detail2", "")

    '    'frmReport.Show()
    '    'frmReport.ShowTransReport(rptDoc, "JKD")

    'End Sub

    'Private Sub BranchWiseActiveEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Dim RepName As String
    '    'Dim StrRepHdr1 As String
    '    'Dim StrRepHdr2 As String

    '    'RepName = "BrWiseEmployee.rpt"
    '    'Dim path As String = RepPath & RepName

    '    'Dim rptDoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    '    'rptDoc.Load(path)

    '    'SysCompany = " "
    '    'StrRepHdr1 = "6-A, Block H, Ancillary Building, Gulberg Heights, Gulberg II, Lahore"
    '    'StrRepHdr2 = "Branch Wise Active Employees"

    '    'rptDoc.SetParameterValue(0, "NULL")
    '    'rptDoc.SetParameterValue(1, "NULL")
    '    'rptDoc.SetParameterValue("Company", SysCompany)
    '    ''rptDoc.SetParameterValue("Detail", StrRepHdr1)
    '    'rptDoc.SetParameterValue("Detail1", StrRepHdr2)
    '    'rptDoc.SetParameterValue("Detail2", "")

    '    'frmReport.Show()
    '    'frmReport.ShowTransReport(rptDoc, "JKD")

    'End Sub

    'Private Sub DesignationWiseEmployeeCountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Dim RepName As String
    '    'Dim StrRepHdr1 As String
    '    'Dim StrRepHdr2 As String

    '    'RepName = "DesigWiseEmpCount.rpt"
    '    'Dim path As String = RepPath & RepName

    '    'Dim rptDoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    '    'rptDoc.Load(path)

    '    'SysCompany = " "
    '    'StrRepHdr1 = "6-A, Block H, Ancillary Building, Gulberg Heights, Gulberg II, Lahore"
    '    'StrRepHdr2 = "Designation Wise No. of Employees"

    '    'rptDoc.SetParameterValue("Company", SysCompany)
    '    ''rptDoc.SetParameterValue("Detail", StrRepHdr1)
    '    'rptDoc.SetParameterValue("Detail1", StrRepHdr2)
    '    'rptDoc.SetParameterValue("Detail2", "")

    '    'frmReport.Show()
    '    'frmReport.ShowTransReport(rptDoc, "JKD")

    'End Sub

    'Private Sub EmployeeDetailReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Constants.ProjConst.pPara = 15
    '    'frmRPT_Report.ShowDialog()
    'End Sub

    'Private Sub SalaryTransferLetterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'frmRPT_Bank.ShowDialog()
    'End Sub

    'Private Sub EmployeeSalaryHistoryReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    ''Constants.ProjConst.pPara = 16
    '    'frmRPT_HistorySalary.ShowDialog()
    'End Sub

    'Private Sub AppointmentLetterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Constants.ProjConst.pPara = 17
    '    'frmRPT_Report.ShowDialog()
    'End Sub

    'Private Sub EmployeeOldAgeBenefitReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'frmRPT_EOAG.ShowDialog()
    'End Sub

    'Private Sub EmployeeSalarySheetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'frmRPT_Salary.ShowDialog()
    'End Sub


    'Private Sub BranchOfficeCodesMaintenanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    ''frmBranch.ShowDialog()
    '    'If mBranch = False Then
    '    '    Dim frmBrnch As New frmBranch
    '    '    frmBrnch.Show()
    '    '    frmBrnch.WindowState = FormWindowState.Normal
    '    '    mBranch = True
    '    'Else
    '    '    frmBranch.WindowState = FormWindowState.Normal
    '    'End If
    '    Call onMenuSecurity()
    'End Sub


    'Private Sub miStkStore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Constants.ProjConst.pPara = 12
    '    'Dim StkStore As New frmINV
    '    'StkStore.Show()
    'End Sub

    'Private Sub miStkStoreSum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Constants.ProjConst.pPara = 13
    '    'Dim StkStoreSum As New frmINV
    '    'StkStoreSum.Show()
    'End Sub

    'Private Sub miStkStoreBal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Constants.ProjConst.pPara = 14
    '    'Dim miStkStoreBal As New frmINV
    '    'miStkStoreBal.Show()
    'End Sub

    'Private Sub miCstkStoreBal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Constants.ProjConst.pPara = 15
    '    'Dim miCstkStoreBal As New frmINV
    '    'miCstkStoreBal.Show()
    'End Sub

    'Private Sub miStkMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Constants.ProjConst.pPara = 16
    '    'Dim miStkMove As New frmINV
    '    'miStkMove.Show()
    'End Sub

    'Private Sub miStkSum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Constants.ProjConst.pPara = 17
    '    'Dim miDocMove As New frmINV
    '    'miDocMove.Show()
    'End Sub

    'Private Sub miStkSumm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Constants.ProjConst.pPara = 18
    '    'Dim miStkSumm As New frmINV
    '    'miStkSumm.Show()
    'End Sub

    'Private Sub miStkSumNon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Constants.ProjConst.pPara = 19
    '    'Dim miStkSumNon As New frmINV
    '    'miStkSumNon.Show()
    'End Sub

    'Private Sub miStkPos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Constants.ProjConst.pPara = 20
    '    'Dim miStkPos As New frmINV
    '    'miStkPos.Show()
    'End Sub

    'Private Sub miCstkPos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Constants.ProjConst.pPara = 21
    '    'Dim miCstkPos As New frmINV
    '    'miCstkPos.Show()
    'End Sub

    'Private Sub miReorder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Constants.ProjConst.pPara = 22
    '    'Dim miReorder As New frmINV
    '    'miReorder.Show()
    'End Sub

    'Private Sub miReorderAbove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Constants.ProjConst.pPara = 23
    '    'Dim miReorderAbove As New frmINV
    '    'miReorderAbove.Show()
    'End Sub

    'Private Sub miSlMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Constants.ProjConst.pPara = 24
    '    'Dim miSlMove As New frmINV
    '    'miSlMove.Show()
    'End Sub

    'Private Sub miRateComp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Constants.ProjConst.pPara = 25
    '    'Dim miRateComp As New frmINV
    '    'miRateComp.Show()
    'End Sub

    'Private Sub miPurBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Constants.ProjConst.pPara = 25
    '    'Dim miPurBook As New frmINV_RPT_PurchaseDoc
    '    'miPurBook.Show()
    'End Sub

    'Private Sub InventoryAgingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Dim miInvAging As New frmRPT_InvAging
    '    'miInvAging.Show()
    'End Sub

    'Private Sub PurchaseOrderStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Constants.ProjConst.pPara = 26
    '    'Dim miPOStatus As New frmINV
    '    'miPOStatus.Show()
    'End Sub

    'Private Sub ListOfUnPostedTransactionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Dim michkUnPostedRec As New frmRPT_INV_PTransUnPosted
    '    'michkUnPostedRec.Show()
    'End Sub



    Private Sub miUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miUsers.Click
        If Constants.ProjConst.mUMaintenence = False Then
            Constants.ProjConst.pPara = 19
            frmUsers.Show()
            frmUsers.WindowState = FormWindowState.Normal
            Constants.ProjConst.mUMaintenence = True
        Else
            frmUsers.WindowState = FormWindowState.Normal
        End If
        Call onMenuSecurity()
    End Sub

    Private Sub miSetUPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miSetUPass.Click
        If Constants.ProjConst.mUPass = False Then
            frmChangeUPass.Show()
            frmChangeUPass.WindowState = FormWindowState.Normal
            Constants.ProjConst.mUPass = True
        Else
            frmChangeUPass.WindowState = FormWindowState.Normal
        End If
        Call onMenuSecurity()
    End Sub

    Private Sub miSysParms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miSysParms.Click
        If Constants.ProjConst.mSysParm = False Then
            frmSysParms.Show()
            frmSysParms.WindowState = FormWindowState.Maximized
            Constants.ProjConst.mSysParm = True
        Else
            frmSysParms.WindowState = FormWindowState.Normal
        End If
        Call onMenuSecurity()
    End Sub

    Private Sub BranchOfficeCodeMaintenanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BranchOfficeCodeMaintenanceToolStripMenuItem.Click
        'frmBranch.ShowDialog()
        If Constants.ProjConst.mBranch = False Then
            Dim frmBrnch As New frmBranch
            frmBrnch.Show()
            frmBrnch.WindowState = FormWindowState.Maximized
            Constants.ProjConst.mBranch = True
        Else
            frmBranch.WindowState = FormWindowState.Maximized
        End If
        Call onMenuSecurity()

    End Sub

    Private Sub BudgetAllocationMaintenanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BudgetAllocationMaintenanceToolStripMenuItem.Click
        If Constants.ProjConst.mBudget = False Then
            frmBudget.Show()
            frmBudget.WindowState = FormWindowState.Maximized
            Constants.ProjConst.mBudget = True
        Else
            frmBudget.WindowState = FormWindowState.Maximized
        End If
        Call onMenuSecurity()

    End Sub

    Private Sub DefinedReportsMaintenanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefinedReportsMaintenanceToolStripMenuItem.Click
        If Constants.ProjConst.mDefReport = False Then
            frmRepDefinition.Show()
            frmRepDefinition.WindowState = FormWindowState.Maximized
            Constants.ProjConst.mDefReport = True
        Else
            frmRepDefinition.WindowState = FormWindowState.Maximized
        End If
        Call onMenuSecurity()

    End Sub

    Private Sub miBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miBackup.Click
        If Constants.ProjConst.mBckDB = False Then
            frmBackUp.Show()
            frmBackUp.WindowState = FormWindowState.Normal
            Constants.ProjConst.mBckDB = True
        Else
            frmBackUp.WindowState = FormWindowState.Normal
        End If
        Call onMenuSecurity()

    End Sub

    Private Sub AToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AToolStripMenuItem.Click
        pParaJV = 6
        Dim Bnkfrm As New frmRecPay
        frmRecPay.MdiParent = Me
        If Constants.ProjConst.mfrmBP = False Then
            'Bnkfrm.MdiParent = Me
            Bnkfrm.Show()
            Constants.ProjConst.mfrmBP = True
        Else
            Bnkfrm.WindowState = FormWindowState.Maximized
        End If
        Call onMenuSecurity()
    End Sub

    Private Sub BankReceiptVoucherToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BankReceiptVoucherToolStripMenuItem.Click
        pParaJV = 5
        Dim frmBnkRecpt As New frmRecPay
        'frmRecPay.ShowDialog()
        If Constants.ProjConst.mfrmBR = False Then
            frmBnkRecpt.Show()

            Constants.ProjConst.mfrmBR = True
        Else
            frmBnkRecpt.WindowState = FormWindowState.Normal
        End If
        Call onMenuSecurity()
    End Sub

    Private Sub CashPaymentVoucherToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CashPaymentVoucherToolStripMenuItem.Click
        pParaJV = 8
        Dim frmBnkRecpt As New frmRecPay
        'frmRecPay.ShowDialog()
        If Constants.ProjConst.mfrmCP = False Then
            frmBnkRecpt.Show()
            Constants.ProjConst.mfrmCP = True
        Else
            frmBnkRecpt.WindowState = FormWindowState.Maximized
        End If
        Call onMenuSecurity()
    End Sub

    Private Sub CashReceiptVoucherToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CashReceiptVoucherToolStripMenuItem.Click
        pParaJV = 7
        Dim frmBnkRecpt As New frmRecPay
        'frmRecPay.ShowDialog()
        If Constants.ProjConst.mfrmCR = False Then
            frmBnkRecpt.Show()
            Constants.ProjConst.mfrmCR = True
        Else
            frmBnkRecpt.WindowState = FormWindowState.Normal
        End If
        Call onMenuSecurity()

    End Sub

    Private Sub JournalVoucherToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JournalVoucherToolStripMenuItem.Click
        Constants.ProjConst.pPara = 20
        If Constants.ProjConst.mfrmJV = False Then
            frmJV.MdiParent = Me
            frmJV.Show()
            Constants.ProjConst.mfrmJV = True
        Else
            frmJV.WindowState = FormWindowState.Normal
        End If
        Call onMenuSecurity()

    End Sub

    Private Sub BankBookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BankBookToolStripMenuItem.Click
        Constants.ProjConst.pPara = 13
        'frmRPT_CodesStat.ShowDialog()
        'Dim BBook As New frmINV_Status
        Dim BBook As New frmRPT_CodesStat
        BBook.MdiParent = Me
        Constants.ProjConst.pPara = 13
        If Constants.ProjConst.mBBook = False Then
            BBook.Show()
            BBook.WindowState = FormWindowState.Normal
            Constants.ProjConst.mBBook = True
        Else
            BBook.WindowState = FormWindowState.Normal
        End If
        Call onMenuSecurity()

    End Sub

    Private Sub CashBookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CashBookToolStripMenuItem.Click
        'Constants.ProjConst.pPara = 14
        'frmRPT_CodesStat.ShowDialog()

        Dim CBook As New frmRPT_CodesStat
        CBook.MdiParent = Me
        Constants.ProjConst.pPara = 14
        If Constants.ProjConst.mCBook = False Then
            CBook.Show()
            Constants.ProjConst.mCBook = True
        Else
            CBook.WindowState = FormWindowState.Normal
        End If
        Call onMenuSecurity()
    End Sub

    Private Sub TrialBalanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrialBalanceToolStripMenuItem.Click
        'If mTBal = False Then
        '    Constants.ProjConst.pPara = 16
        '    frmRPT_TrialBal.Show()
        '    'frmRPT_TrialBal.MdiParent = Me
        '    mTBal = True
        'End If
        Dim TBal As New frmRPT_TrialBal
        TBal.MdiParent = Me
        Constants.ProjConst.pPara = 16
        If Constants.ProjConst.mTBal = False Then
            TBal.Show()
            TBal.WindowState = FormWindowState.Normal
            Constants.ProjConst.mTBal = True
        Else
            TBal.WindowState = FormWindowState.Normal
        End If
        Call onMenuSecurity()

    End Sub

    Private Sub TrialBalanceCrossTabToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrialBalanceCrossTabToolStripMenuItem.Click
        If Constants.ProjConst.mTBalCross = False Then
            frmRPT_PrtTBall.Show()
            frmRPT_PrtTBall.WindowState = FormWindowState.Normal
            Constants.ProjConst.mTBalCross = True
        Else
            frmRPT_PrtTBall.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub ActivityTrialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActivityTrialToolStripMenuItem.Click
        'If mATrial = False Then
        '    Constants.ProjConst.pPara = 17
        '    frmRPT_TrialBal.Show()
        '    mATrial = False
        'End If
        Dim ATrial As New frmRPT_TrialBal
        ATrial.MdiParent = Me
        Constants.ProjConst.pPara = 17
        If Constants.ProjConst.mATrial = False Then
            ATrial.Show()
            ATrial.WindowState = FormWindowState.Normal
            Constants.ProjConst.mATrial = True
        Else
            ATrial.WindowState = FormWindowState.Normal
        End If
        Call onMenuSecurity()
    End Sub

    Private Sub AgingAnalysisToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgingAnalysisToolStripMenuItem.Click
        If Constants.ProjConst.mAAnalysis = False Then
            frmRPT_Aging.Show()
            frmRPT_Aging.WindowState = FormWindowState.Normal
            Constants.ProjConst.mAAnalysis = True
        Else
            frmRPT_Aging.WindowState = FormWindowState.Normal
        End If
        Call onMenuSecurity()

    End Sub

    Private Sub ScheduleForSubledgerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScheduleForSubledgerToolStripMenuItem.Click
        Dim SubLedg As New frmRPT_CodesStat
        SubLedg.MdiParent = Me
        Constants.ProjConst.pPara = 15
        If Constants.ProjConst.mSubLedg = False Then
            SubLedg.Show()
            SubLedg.WindowState = FormWindowState.Normal
            Constants.ProjConst.mSubLedg = True
        Else
            SubLedg.WindowState = FormWindowState.Normal
        End If
        Call onMenuSecurity()

    End Sub

    Private Sub PrintDefinedReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintDefinedReportsToolStripMenuItem.Click
        If Constants.ProjConst.mPDefRep = False Then
            frmRPT_IncStat.Show()
            frmRPT_IncStat.WindowState = FormWindowState.Normal
            Constants.ProjConst.mPDefRep = True
        Else
            frmRPT_IncStat.WindowState = FormWindowState.Normal
        End If
        Call onMenuSecurity()
    End Sub

    Private Sub PrintDefinedReportsCrossTabToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintDefinedReportsCrossTabToolStripMenuItem.Click
        If Constants.ProjConst.mPDefRefCross = False Then
            frmRPT_PrtStat.Show()
            frmRPT_PrtStat.WindowState = FormWindowState.Normal
            Constants.ProjConst.mPDefRefCross = True
        Else
            frmRPT_PrtStat.WindowState = FormWindowState.Normal
        End If
        Call onMenuSecurity()

    End Sub

    Private Sub PrintPostedVouchersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPostedVouchersToolStripMenuItem.Click
        If Constants.ProjConst.mPPstVouchers = False Then
            Constants.ProjConst.pPara = 18
            frmRPT_PostedVoucher.Show()
            frmRPT_PostedVoucher.WindowState = FormWindowState.Normal
            Constants.ProjConst.mPPstVouchers = True
        Else
            frmRPT_PostedVoucher.WindowState = FormWindowState.Normal
        End If
        Call onMenuSecurity()
    End Sub

    Private Sub BrowseGeneralLedgerOnScreenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseGeneralLedgerOnScreenToolStripMenuItem.Click
        If Constants.ProjConst.mGLScr = False Then
            'temp comments
            'frmBrowseGL.Show()
            Constants.ProjConst.mGLScr = True
        Else
            'frmBrowseGL.WindowState = FormWindowState.Normal
        End If
        Call onMenuSecurity()
    End Sub

    Private Sub ACCodeStatusOnScreenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ACCodeStatusOnScreenToolStripMenuItem.Click
        'If mCStatus = False Then
        '    Constants.ProjConst.pPara = 9
        '    frmACStatus.Show()
        '    mCStatus = True
        'End If
        Dim AccCStatus As New frmACStatus
        AccCStatus.MdiParent = Me
        Constants.ProjConst.pPara = 9
        If Constants.ProjConst.mCStatus = False Then
            AccCStatus.Show()
            AccCStatus.WindowState = FormWindowState.Normal
            Constants.ProjConst.mCStatus = True
        Else
            AccCStatus.WindowState = FormWindowState.Normal
        End If
        Call onMenuSecurity()
    End Sub

    Private Sub BankBookOnScreenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BankBookOnScreenToolStripMenuItem.Click
        Dim BBookScr As New frmACStatus
        BBookScr.MdiParent = Me
        Constants.ProjConst.pPara = 10
        If Constants.ProjConst.mBBookScr = False Then
            BBookScr.Show()
            BBookScr.WindowState = FormWindowState.Normal
            Constants.ProjConst.mBBookScr = True
        Else
            BBookScr.WindowState = FormWindowState.Normal
        End If
        Call onMenuSecurity()
    End Sub

    Private Sub CashBookOnScreenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CashBookOnScreenToolStripMenuItem.Click
        Dim CBookScr As New frmACStatus
        CBookScr.MdiParent = Me
        Constants.ProjConst.pPara = 11
        If Constants.ProjConst.mCBookScr = False Then
            CBookScr.Show()
            CBookScr.WindowState = FormWindowState.Normal
            Constants.ProjConst.mCBookScr = True
        Else
            CBookScr.WindowState = FormWindowState.Normal
        End If
        Call onMenuSecurity()
        'Constants.ProjConst.pPara = 11
        'frmACStatus.ShowDialog()
    End Sub

    Private Sub AccountCodeStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountCodeStatusToolStripMenuItem.Click
        'If mAcCStatus = False Then
        '    Constants.ProjConst.pPara = 12
        '    frmRPT_CodesStat.Show()
        '    mAcCStatus = True
        'End If
        Dim AcCStatus As New frmRPT_CodesStat
        AcCStatus.MdiParent = Me
        Constants.ProjConst.pPara = 12
        If Constants.ProjConst.mAcCStatus = False Then
            AcCStatus.Show()
            AcCStatus.WindowState = FormWindowState.Normal
            Constants.ProjConst.mAcCStatus = True
        Else
            AcCStatus.WindowState = FormWindowState.Normal
        End If
        Call onMenuSecurity()
    End Sub

    Private Sub FinancialTypeInformationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FinancialTypeInformationToolStripMenuItem.Click

        Dim FinTypeInfo As New FrmFinanInfo
        FinTypeInfo.MdiParent = Me
        If Constants.ProjConst.mFinanInfo = False Then
            FinTypeInfo.Show()
            FinTypeInfo.WindowState = FormWindowState.Normal
            Constants.ProjConst.mFinanInfo = True
        Else
            FinTypeInfo.WindowState = FormWindowState.Normal
        End If
        Call onMenuSecurity()
    End Sub

    Private Sub FinancialInstitutionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FinancialInstitutionToolStripMenuItem.Click
        Dim FinInstitusion As New FrmFinanInsInfo
        FinInstitusion.MdiParent = Me
        If Constants.ProjConst.mFinanInsInfo = False Then
            FinInstitusion.Show()
            FinInstitusion.WindowState = FormWindowState.Normal
            Constants.ProjConst.mFinanInsInfo = True
        Else
            FinInstitusion.WindowState = FormWindowState.Normal
        End If

        Call onMenuSecurity()
    End Sub

    Private Sub FundToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FundToolStripMenuItem.Click
        Dim Fund As New frmFund
        Fund.MdiParent = Me
        If Constants.ProjConst.mFund = False Then
            Fund.Show()
            Fund.WindowState = FormWindowState.Normal
            Constants.ProjConst.mFinanInsInfo = True
        Else
            Fund.WindowState = FormWindowState.Normal
        End If
        Call onMenuSecurity()
    End Sub

    Private Sub SectorInformationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SectorInformationToolStripMenuItem.Click
        Dim Sector As New frmSector
        Sector.MdiParent = Me
        If Constants.ProjConst.mSector = False Then
            Sector.Show()
            Sector.WindowState = FormWindowState.Normal
            Constants.ProjConst.mSector = True
        Else
            Sector.WindowState = FormWindowState.Normal
        End If
        Call onMenuSecurity()
    End Sub

    Private Sub GroupOfCompanyToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GroupOfCompanyToolStripMenuItem.Click
        Dim GrpOfCompany As New frmGroupOfcompany
        GrpOfCompany.MdiParent = Me
        If Constants.ProjConst.mGroupofCompany = False Then
            GrpOfCompany.Show()
            GrpOfCompany.WindowState = FormWindowState.Normal
            Constants.ProjConst.mGroupofCompany = True
        Else
            GrpOfCompany.WindowState = FormWindowState.Normal
        End If

        Call onMenuSecurity()
    End Sub

    Private Sub ScripToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ScripToolStripMenuItem.Click
        Dim Scrip As New frmScrip
        Scrip.MdiParent = Me
        If Constants.ProjConst.mScrip = False Then
            Scrip.Show()
            Scrip.WindowState = FormWindowState.Normal
            Constants.ProjConst.mScrip = True
        Else
            Scrip.WindowState = FormWindowState.Normal

        End If
        Call onMenuSecurity()
    End Sub

    Private Sub FutureScripToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FutureScripToolStripMenuItem.Click
        Dim FutureScrip As New frmFutureScrip
        FutureScrip.MdiParent = Me
        If Constants.ProjConst.mFutureScrip = False Then
            FutureScrip.Show()
            FutureScrip.WindowState = FormWindowState.Normal
            Constants.ProjConst.mFutureScrip = True
        Else
            FutureScrip.WindowState = FormWindowState.Normal
        End If
        Call onMenuSecurity()
    End Sub

    Private Sub FundWiseControlToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FundWiseControlToolStripMenuItem.Click
        Dim FundWiseControl As New frmFundWiseControl
        FundWiseControl.MdiParent = Me
        If Constants.ProjConst.mFundWiseControl = False Then
            FundWiseControl.Show()
            FundWiseControl.WindowState = FormWindowState.Normal
            Constants.ProjConst.mFundWiseControl = True
        Else
            FundWiseControl.WindowState = FormWindowState.Normal
        End If
        Call onMenuSecurity()
    End Sub

    Private Sub ScripIndexSetupToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ScripIndexSetupToolStripMenuItem.Click
        Dim ScripIndexsetup As New frmScripIndexSetup
        ScripIndexsetup.MdiParent = Me
        If Constants.ProjConst.mScripIndexsetup = False Then
            ScripIndexsetup.Show()
            ScripIndexsetup.WindowState = FormWindowState.Normal
            Constants.ProjConst.mScripIndexsetup = True
        Else
            ScripIndexsetup.WindowState = FormWindowState.Normal

        End If
        Call onMenuSecurity()
    End Sub
End Class