Public Class cPostedVouchers

    Dim objConnection As Object

    Public BrCode As String
    Public Type As String
    Public VNo As String
    Public SeqNo As String
    Public VDate As String
    Public RfCode As String
    Public RefRemarks As String
    Public Code As String
    Public Remarks As String
    Public Debit As Double
    Public Credit As Double
    Public Chequeno As String
    Public Chequedate As String
    Public AddOn As String
    Public AddBy As String
    Public EditOn As String
    Public EditBy As String
    Public PrintOn As String
    Public PrintBy As String
    Public PostOn As String
    Public PostBy As String

    Dim objTransaction As SqlClient.SqlTransaction
    Dim objDatabaseManager As IDatabaseManager
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
    Public Function LoadAllMaster() As DataTable
        Dim dt As New DataTable

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        'objDBParameters.AddParameter("@Type", Type, "char")
        dt = objDatabaseManager.GetDataTable("GL_AllMasterPV_Get", objDBParameters)
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
        dt = objDatabaseManager.GetDataTable("GL_AllDetailPV_Get", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)
        Return dt
    End Function

    Public Sub DelVouchers()

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
        objDBParameters.AddParameter("@RfCode", RfCode, "nvarchar")

        objDatabaseManager.ExecuteNonQuery("GL_DetailPV_Edit", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

    End Sub
End Class
