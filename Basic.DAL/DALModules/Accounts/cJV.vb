Public Class cJV

    Dim objConnection As Object
    Dim objTransaction As SqlClient.SqlTransaction
    Dim objDatabaseManager As IDatabaseManager
    Public BrCode As String
    Public Type As String
    Public VNo As String
    Public SeqNo As String
    Public VDate As String
    Public RefCode As String
    Public RefRemarks As String
    Public Code As String
    Public Remarks As String

    Public Debit As Double
    Public Credit As Double
    Public StDate As String
    Public EndDate As String
    Public Posted As String
    Public Level As String
    Public AddOn As String
    Public AddBy As String
    Public EditOn As String
    Public EditBy As String
    Public PrintOn As String
    Public PrintBy As String
    Public PostOn As String
    Public PostBy As String

#Region " Transaction Specific Functions"

    Sub New()
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objConnection = cConnectionManager.GetConnection()
        objDatabaseManager.SetConnection(objConnection)
    End Sub

    Sub BeginTransaction(Optional ByVal TransactionName As String = "")
        If (TransactionName <> "") Then
            objDatabaseManager.BeginTransaction(TransactionName)
        Else
            objDatabaseManager.BeginTransaction()
        End If
    End Sub

    Sub CommitTransction()
        objDatabaseManager.CommitTransction()
    End Sub

    Sub RollBack()
        objDatabaseManager.RollBack()
    End Sub

    Public Sub getConnection()
        objConnection = cConnectionManager.GetConnection()
    End Sub

    Public Sub closeConnection()
        cConnectionManager.CloseConnection(objConnection)
    End Sub

#End Region

    Public Sub SaveMaster()


        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)
        objDatabaseManager.SetTransaction(objTransaction)

        objDBParameters.AddParameter("@BrCode", BrCode, "nvarchar")
        objDBParameters.AddParameter("@Type", Type, "nvarchar")
        objDBParameters.AddParameter("@VNo", VNo, "nvarchar")
        objDBParameters.AddParameter("@VDate", VDate, "nvarchar")
        'objDBParameters.AddParameter("@RefCode", RefCode, "nvarchar")
        objDBParameters.AddParameter("@RefRemarks", RefRemarks, "nvarchar")
        objDBParameters.AddParameter("@AddOn", AddOn, "nvarchar")
        objDBParameters.AddParameter("@AddBy", AddBy, "nvarchar")

        objDatabaseManager.ExecuteNonQuery("GL_MasterJV_Save", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

    End Sub
    Public Sub CreateJVInGLHead()

        'Create JV For Payroll

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@BrCode", BrCode, "nvarchar")
        objDBParameters.AddParameter("@Type", Type, "nvarchar")
        objDBParameters.AddParameter("@VNo", VNo, "nvarchar")
        objDBParameters.AddParameter("@VDate", VDate, "nvarchar")
        objDBParameters.AddParameter("@RefRemarks", RefRemarks, "nvarchar")
        objDBParameters.AddParameter("@Posted", Posted, "nvarchar")
        objDBParameters.AddParameter("@AddOn", AddOn, "nvarchar")
        objDBParameters.AddParameter("@AddBy", AddBy, "nvarchar")

        objDatabaseManager.ExecuteNonQuery("HR_GLHead_Save", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

    End Sub
    Public Sub SaveDetail()

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)
        objDatabaseManager.SetTransaction(objTransaction)

        objDBParameters.AddParameter("@BrCode", BrCode, "nvarchar")
        objDBParameters.AddParameter("@Type", Type, "nvarchar")
        objDBParameters.AddParameter("@VNo", VNo, "nvarchar")
        objDBParameters.AddParameter("@SeqNo", SeqNo, "nvarchar")
        objDBParameters.AddParameter("@VDate", VDate, "nvarchar")
        objDBParameters.AddParameter("@Code", Code, "nvarchar")
        objDBParameters.AddParameter("@Remarks", Remarks, "nvarchar")
        objDBParameters.AddParameter("@Debit", Debit, "double")
        objDBParameters.AddParameter("@Credit", Credit, "double")

        objDatabaseManager.ExecuteNonQuery("GL_DetailJV_Save", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

    End Sub

    Public Sub CreateJVInGLedg()

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@BrCode", BrCode, "nvarchar")
        objDBParameters.AddParameter("@Type", Type, "nvarchar")
        objDBParameters.AddParameter("@VNo", VNo, "nvarchar")
        objDBParameters.AddParameter("@SeqNo", SeqNo, "nvarchar")
        objDBParameters.AddParameter("@VDate", VDate, "nvarchar")
        objDBParameters.AddParameter("@Code", Code, "nvarchar")
        objDBParameters.AddParameter("@Remarks", Remarks, "nvarchar")
        objDBParameters.AddParameter("@Debit", Debit, "double")
        objDBParameters.AddParameter("@Credit", Credit, "double")
        objDBParameters.AddParameter("@Posted", Posted, "nvarchar")

        objDatabaseManager.ExecuteNonQuery("HR_GLedg_Save", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

    End Sub

    Public Sub EditMaster()

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@BrCode", BrCode, "nvarchar")
        objDBParameters.AddParameter("@Type", Type, "nvarchar")
        objDBParameters.AddParameter("@VNo", VNo, "nvarchar")
        objDBParameters.AddParameter("@VDate", VDate, "nvarchar")
        'objDBParameters.AddParameter("@RefCode", RefCode, "nvarchar")
        objDBParameters.AddParameter("@RefRemarks", RefRemarks, "nvarchar")
        objDBParameters.AddParameter("@EditOn", EditOn, "nvarchar")
        objDBParameters.AddParameter("@EditBy", EditBy, "nvarchar")

        objDatabaseManager.ExecuteNonQuery("GL_MasterJV_Edit", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

    End Sub

    Public Sub EditDetail()

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@BrCode", BrCode, "nvarchar")
        objDBParameters.AddParameter("@Type", Type, "nvarchar")
        objDBParameters.AddParameter("@VNo", VNo, "nvarchar")
        objDBParameters.AddParameter("@SeqNo", SeqNo, "nvarchar")
        objDBParameters.AddParameter("@VDate", VDate, "nvarchar")
        objDBParameters.AddParameter("@Code", Code, "nvarchar")
        objDBParameters.AddParameter("@Remarks", Remarks, "nvarchar")
        objDBParameters.AddParameter("@Debit", Debit, "double")
        objDBParameters.AddParameter("@Credit", Credit, "double")

        objDatabaseManager.ExecuteNonQuery("GL_DetailJV_Edit", objDBParameters)
        'cConnectionManager.CloseConnection(objConnection)

    End Sub

    Public Sub DelRecPay()

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@BrCode", BrCode, "nvarchar")
        objDBParameters.AddParameter("@Type", Type, "nvarchar")
        objDBParameters.AddParameter("@VNo", VNo, "nvarchar")

        objDatabaseManager.ExecuteNonQuery("GL_Voucher_Del", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

    End Sub

    Public Function LoadAllMaster() As DataTable
        Dim dt As New DataTable

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@BrCode", BrCode, "char")
        objDBParameters.AddParameter("@SDate", StDate, "nVarchar")
        objDBParameters.AddParameter("@EDate", EndDate, "nVarchar")
        objDBParameters.AddParameter("@Type", Type, "char")

        dt = objDatabaseManager.GetDataTable("GL_AllMasterJV_Get", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)
        Return dt
    End Function

    Public Function LoadMasterVoucher() As DataTable
        Dim dt As New DataTable

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@BrCode", BrCode, "char")
        objDBParameters.AddParameter("@Type", Type, "char")
        objDBParameters.AddParameter("@VNo", VNo, "char")

        dt = objDatabaseManager.GetDataTable("GL_MasterJV_Get", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)
        Return dt
    End Function

    Public Function LoadAllDetail() As DataTable
        Dim dt As New DataTable

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@BrCode", BrCode, "char")
        objDBParameters.AddParameter("@Type", Type, "char")
        objDBParameters.AddParameter("@VNo", VNo, "char")

        dt = objDatabaseManager.GetDataTable("GL_AllDetailJV_Get", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)
        Return dt
    End Function

    Public Function LoadSelectJV() As DataTable
        Dim dt As New DataTable

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@Type", Type, "char")
        objDBParameters.AddParameter("@StDate", StDate, "char")
        objDBParameters.AddParameter("@EndDate", EndDate, "char")
        objDBParameters.AddParameter("@Level", Level, "char")

        dt = objDatabaseManager.GetDataTable("GL_JV_Print", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)
        Return dt
    End Function
    Public Sub CreateVoucherInGLHead()

        'Create Voucher For Integration...

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@BrCode", BrCode, "nvarchar")
        objDBParameters.AddParameter("@Type", Type, "nvarchar")
        objDBParameters.AddParameter("@VNo", VNo, "nvarchar")
        objDBParameters.AddParameter("@VDate", VDate, "nvarchar")
        objDBParameters.AddParameter("@RefRemarks", RefRemarks, "nvarchar")
        objDBParameters.AddParameter("@Posted", Posted, "nvarchar")
        objDBParameters.AddParameter("@AddOn", AddOn, "nvarchar")
        objDBParameters.AddParameter("@AddBy", AddBy, "nvarchar")

        objDatabaseManager.ExecuteNonQuery("HR_GLHead_Save", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

    End Sub

    Public Sub CreateVoucherInGLedg()

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@BrCode", BrCode, "nvarchar")
        objDBParameters.AddParameter("@Type", Type, "nvarchar")
        objDBParameters.AddParameter("@VNo", VNo, "nvarchar")
        objDBParameters.AddParameter("@SeqNo", SeqNo, "nvarchar")
        objDBParameters.AddParameter("@VDate", VDate, "nvarchar")
        objDBParameters.AddParameter("@Code", Code, "nvarchar")
        objDBParameters.AddParameter("@Remarks", Remarks, "nvarchar")
        objDBParameters.AddParameter("@Debit", Debit, "double")
        objDBParameters.AddParameter("@Credit", Credit, "double")
        objDBParameters.AddParameter("@Posted", Posted, "nvarchar")

        objDatabaseManager.ExecuteNonQuery("HR_GLedg_Save", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

    End Sub


End Class
