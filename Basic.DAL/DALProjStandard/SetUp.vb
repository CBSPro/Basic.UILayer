
Imports System.Data.SqlClient
Imports Basic.DAL.Utils

Public Module SetUp

    ''Public Da As SqlDataAdapter
    ''Public Ds As New DataSet()
    ''Public Dt As New DataTable
    ''Public objRow As Data.DataRow
    ''Public Reader As SqlDataReader
    '======================
    
    '==============================
    Public StrConec As String
    Public sqlCon As New SqlConnection
    Public SqlTrans As SqlTransaction
    'Public SysDataBase As String
    'Public BuiltInUser As String
    'Public SysUserID As String
    'Public SysUser As String
    Public SysBrCode As String
    'Public SySDate As String
    Public SysTime As String
    'Public SysPassword As String
    'Public SysStatus As String
    'Public SysCompany As String
    'Public SysDsn As String
    'Public SysServer As String
    ' Public SysSystem As String
    'Public SysAddress1 As String
    'Public SysAddress2 As String
    Public SpUser As Boolean
    Public SpUsers As Integer
    Public MenuName As String
    'Public pPara As Integer
    Public pParaJV As Integer
    'Public SortSign As String
    Public Fld1 As String
    Public Fld2 As String
    Public FlagUser As Boolean
    'Public RepPath As String
    'Public RepTitle As String
    'Public AVIPath As String
    Public RepConn As String
    Public StValue As String
    Public EndValue As String
    Public mOrder As Integer
    Public mReport As Integer
    Public mTotRecs As String
    Public TRepType As String
    Public RepType As String
    Public mType As String
    Public mVno As String
    Public FlagDup As Boolean
    Public Logged As Boolean
    Public mRow As Integer
    Public RptBalBF As String
    Public RptBalCF As String
    Public strHeader As String
    Public strHeader1 As String
    Public strHeader2 As String
    Public strHeader3 As String
    Public Const SysPostedPass = "helloworld"

    ''
    'Public SDate As Date
    'Public EDate As Date
    'Public Branch As String
    'Public FltFirst As Boolean
    'Public FltSecond As Boolean
    'Public FltThird As Boolean
    'Public FltAll As Boolean
    'Public Fltpost As Boolean
    'Public FltUnpost As Boolean
    Public mShowMenu As Boolean
    Public FileAVI As Integer
    Public EmpIDParam As String
    ''Accounts Information
    Public StrCode As String
    Public StrTitle As String
    Public AccCode As String
    Public Opt As MsgBoxResult
    Public mSQL As String
    'Public repPathArr
    ''Error Messages
    Public Const ErrPK = -2147217873
    Public Const ErrLock = -2147217871
    Public Const ErrLockEdit = -2147217864
    Public Const ErrRfIntegrity = -2147217873
    Public Const ErrEfStstus = -2147467259

    'Public Sub Main()
    '    BuiltInUser = "SA"
    '    SysSystem = "ERP System"
    '    SysCompany = "Madni Poly Tex Pvt Ltd"
    '    SysAddress1 = ""
    '    SysAddress2 = ""
    '    SortSign = " *"
    '    RepTitle = "CBS"
    '    SySDate = GetDate(Now.Date, "dd-MMM-yyyy")
    '    RepPath = System.AppDomain.CurrentDomain.BaseDirectory()
    '    repPathArr = RepPath.Split("bin")
    '    RepPath = repPathArr(0) & "Reports\"
    '    AVIPath = "G:\Vb Projects\Professional Projects\Projects.Net\Accounts\AviFiles\"
    '    SysDsn = "ERP"
    '    'frmLogin.ShowDialog()
    'End Sub
End Module
