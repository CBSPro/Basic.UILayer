Public Class cAccPost

    Dim objConnection As Object
    Dim objTransaction As SqlClient.SqlTransaction
    Dim objDatabaseManager As IDatabaseManager
    Public BrCode As String
    Public Type As String
    Public VNo As String
    Public StVoucher As String
    Public EndVoucher As String
    Public Posted As String
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

    Public Function FillVouchers() As DataTable
        Dim dt As New DataTable

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@Type", Type, "nvarchar")

        dt = objDatabaseManager.GetDataTable("GL_AllVouchers_Get", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)
        Return dt
    End Function

    Public Function PostAllVouchers() As DataTable
        Dim dt As New DataTable

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@BrCode", BrCode, "nvarchar")
        objDBParameters.AddParameter("@Type", Type, "nvarchar")
        objDBParameters.AddParameter("@StVoucher", StVoucher, "nvarchar")
        objDBParameters.AddParameter("@EndVoucher", EndVoucher, "nvarchar")

        dt = objDatabaseManager.GetDataTable("GL_AllVouchers_Post", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)
        Return dt
    End Function

    Public Function PostGLHead() As DataTable
        Dim dt As New DataTable

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@BrCode", BrCode, "nvarchar")
        objDBParameters.AddParameter("@Type", Type, "nvarchar")
        objDBParameters.AddParameter("@VNo", VNo, "nvarchar")
        objDBParameters.AddParameter("@Posted", Posted, "nvarchar")
        objDBParameters.AddParameter("@PostOn", PostOn, "nvarchar")
        objDBParameters.AddParameter("@PostBy", PostBy, "nvarchar")

        dt = objDatabaseManager.GetDataTable("GL_Head_Post", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

        Return dt
    End Function

    Public Function PostGLedg() As DataTable
        Dim dt As New DataTable

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@BrCode", BrCode, "nvarchar")
        objDBParameters.AddParameter("@Type", Type, "nvarchar")
        objDBParameters.AddParameter("@VNo", VNo, "nvarchar")
        objDBParameters.AddParameter("@Posted", Posted, "nvarchar")

        dt = objDatabaseManager.GetDataTable("GL_Detail_Post", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

        Return dt
    End Function
End Class
