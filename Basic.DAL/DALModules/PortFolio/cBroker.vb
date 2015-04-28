Public Class cBroker

    Dim objConnection As Object
    Dim objTransaction As SqlClient.SqlTransaction
    Dim objDatabaseManager As IDatabaseManager


    Public BrokCode As String
    Public BrokSysCode As String
    Public Nemonic As String
    Public Name As String
    Public Addr As String
    Public Email As String
    Public CFS As String
    Public Fax As String
    Public IASAcNo As String
    Public DefFor As String
    Public NCCTradeCode As String
    Public Description As String
    Public PrimDeal As String
    Public Active As String
    Public ActiveTFC As String
    Public Associate As String



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



    Public Sub LoadFirstRec()
        Dim dt As New DataTable

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        dt = objDatabaseManager.GetDataTable("PortFolio_GetBrokersMaster", objDBParameters)
        If dt.Rows.Count <> 0 Then
            
            BrokCode = dt.Rows(0).Item("BrokCode")
            BrokSysCode = "" & dt.Rows(0).Item("BrokSysCode")
            Nemonic = "" & dt.Rows(0).Item("Nemonic")
            Name = "" & dt.Rows(0).Item("Name")
            Addr = "" & dt.Rows(0).Item("Addr")
            Email = "" & dt.Rows(0).Item("Email")
            CFS = "" & dt.Rows(0).Item("CFS")
            Fax = "" & dt.Rows(0).Item("Fax")
            IASAcNo = "" & dt.Rows(0).Item("IASAcNo")
            DefFor = "" & dt.Rows(0).Item("DefFor")
            NCCTradeCode = "" & dt.Rows(0).Item("NCCTradeCode")
            Description = "" & dt.Rows(0).Item("Description")
            PrimDeal = "" & dt.Rows(0).Item("PrimDeal")
            Active = "" & dt.Rows(0).Item("Active")
            ActiveTFC = "" & dt.Rows(0).Item("ActiveTFC")
            Associate = "" & dt.Rows(0).Item("Associate")



            'AddOn = "" & Format(dt.Rows(0).Item("AddOn"), "dd-MMM-yyyy")
            'AddBy = "" & dt.Rows(0).Item("AddBy")
        End If
    End Sub

    Public Function LoadAllCodes() As DataTable
        Dim dt As New DataTable

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        dt = objDatabaseManager.GetDataTable("PortFolio_GetBrokersMaster", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)
        Return dt
    End Function
    Public Sub LoadCode()
        Dim dt As New DataTable

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@BrokCode", BrokCode, "nvarchar")
        dt = objDatabaseManager.GetDataTable("GL_Code_Get", objDBParameters)
        If dt.Rows.Count <> 0 Then
            BrokCode = dt.Rows(0).Item("BrokCode")
            BrokSysCode = "" & dt.Rows(0).Item("BrokSysCode")
            Nemonic = "" & dt.Rows(0).Item("Nemonic")
            Name = "" & dt.Rows(0).Item("Name")
            Addr = "" & dt.Rows(0).Item("Addr")
            Email = "" & dt.Rows(0).Item("Email")
            CFS = "" & dt.Rows(0).Item("CFS")
            Fax = "" & dt.Rows(0).Item("Fax")
            IASAcNo = "" & dt.Rows(0).Item("IASAcNo")
            DefFor = "" & dt.Rows(0).Item("DefFor")
            NCCTradeCode = "" & dt.Rows(0).Item("NCCTradeCode")
            Description = "" & dt.Rows(0).Item("Description")
            PrimDeal = "" & dt.Rows(0).Item("PrimDeal")
            Active = "" & dt.Rows(0).Item("Active")
            ActiveTFC = "" & dt.Rows(0).Item("ActiveTFC")
            Associate = "" & dt.Rows(0).Item("Associate")
        End If
    End Sub

    Public Sub DelCode()

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@BrokCode", BrokCode, "nvarchar")

        objDatabaseManager.ExecuteNonQuery("PortFolio_Broker_Del", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

    End Sub

    Public Sub SaveACCode()

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)


        objDBParameters.AddParameter("@BrokCode", BrokCode, "char")
        objDBParameters.AddParameter("@BrokSysCode", BrokSysCode, "nvarchar")
        objDBParameters.AddParameter("@Nemonic", Nemonic, "nvarchar")
        objDBParameters.AddParameter("@Name", Name, "nvarchar")
        objDBParameters.AddParameter("@Addr", Addr, "char")
        objDBParameters.AddParameter("@Email", Email, "char")
        objDBParameters.AddParameter("@CFS", CFS, "nvarchar")
        objDBParameters.AddParameter("@Fax", Fax, "nvarchar")
        objDBParameters.AddParameter("@IASAcNo", IASAcNo, "nvarchar")
        objDBParameters.AddParameter("@DefFor", DefFor, "nvarchar")
        objDBParameters.AddParameter("@NCCTradeCode", NCCTradeCode, "nvarchar")
        objDBParameters.AddParameter("@Description", Description, "nvarchar")
        objDBParameters.AddParameter("@PrimDeal", PrimDeal, "nvarchar")
        objDBParameters.AddParameter("@Active", Active, "nvarchar")
        objDBParameters.AddParameter("@ActiveTFC", ActiveTFC, "nvarchar")
        objDBParameters.AddParameter("@Associate", Associate, "nvarchar")

        objDatabaseManager.ExecuteNonQuery("GL_Code_Save", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

    End Sub

    Public Sub EditACCode()

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@BrokCode", BrokCode, "char")
        objDBParameters.AddParameter("@BrokSysCode", BrokSysCode, "nvarchar")
        objDBParameters.AddParameter("@Nemonic", Nemonic, "nvarchar")
        objDBParameters.AddParameter("@Name", Name, "nvarchar")
        objDBParameters.AddParameter("@Addr", Addr, "char")
        objDBParameters.AddParameter("@Email", Email, "char")
        objDBParameters.AddParameter("@CFS", CFS, "nvarchar")
        objDBParameters.AddParameter("@Fax", Fax, "nvarchar")
        objDBParameters.AddParameter("@IASAcNo", IASAcNo, "nvarchar")
        objDBParameters.AddParameter("@DefFor", DefFor, "nvarchar")
        objDBParameters.AddParameter("@NCCTradeCode", NCCTradeCode, "nvarchar")
        objDBParameters.AddParameter("@Description", Description, "nvarchar")
        objDBParameters.AddParameter("@PrimDeal", PrimDeal, "nvarchar")
        objDBParameters.AddParameter("@Active", Active, "nvarchar")
        objDBParameters.AddParameter("@ActiveTFC", ActiveTFC, "nvarchar")
        objDBParameters.AddParameter("@Associate", Associate, "nvarchar")

        objDatabaseManager.ExecuteNonQuery("GL_Code_Edit", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

    End Sub

    
End Class
