Public Class cCustodian


    Dim objConnection As Object
    Dim objTransaction As SqlClient.SqlTransaction
    Dim objDatabaseManager As IDatabaseManager


    Public CustCode As String
    Public Description As String
    Public Name As String
    Public Address As String
    Public AddOn As String
    Public AddBy As String
    Public EditOn As String
    Public EditBy As String

    



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

        dt = objDatabaseManager.GetDataTable("PortFolio_GetCusto_All", objDBParameters)
        If dt.Rows.Count <> 0 Then

            CustCode = dt.Rows(0).Item("CustCode")
            Address = "" & dt.Rows(0).Item("Address")
            Description = "" & dt.Rows(0).Item("Description")
            Name = "" & dt.Rows(0).Item("Name")
           



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

        objDBParameters.AddParameter("@CustCode", CustCode, "nvarchar")
        dt = objDatabaseManager.GetDataTable("PortFolio_Custo_Get", objDBParameters)
        If dt.Rows.Count <> 0 Then
            CustCode = dt.Rows(0).Item("CustCode")
            Address = "" & dt.Rows(0).Item("Address")

            Name = "" & dt.Rows(0).Item("Name")
            Description = "" & dt.Rows(0).Item("Description")
          
        End If
    End Sub

    Public Sub DelCode()

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@CustCode", CustCode, "nvarchar")

        objDatabaseManager.ExecuteNonQuery("PortFolio_Custo_Del", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

    End Sub

    Public Sub SaveACCode()

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)


        objDBParameters.AddParameter("@CustCode", CustCode, "char")

        objDBParameters.AddParameter("@Address", Address, "varchar")
        objDBParameters.AddParameter("@Name", Name, "nvarchar")
     
        objDBParameters.AddParameter("@Description", Description, "nvarchar")
        objDBParameters.AddParameter("@AddOn", AddOn, "nvarchar")
        objDBParameters.AddParameter("@AddBy", AddBy, "nvarchar")

        objDatabaseManager.ExecuteNonQuery("GL_Code_Save", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

    End Sub

    Public Sub EditACCode()

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@CustCode", CustCode, "char")
        objDBParameters.AddParameter("@Address", Address, "varchar")

        objDBParameters.AddParameter("@Name", Name, "nvarchar")

        objDBParameters.AddParameter("@Description", Description, "nvarchar")
        objDBParameters.AddParameter("@EditOn", EditOn, "nvarchar")
        objDBParameters.AddParameter("@EditBy", EditBy, "nvarchar")

        objDatabaseManager.ExecuteNonQuery("GL_Code_Edit", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

    End Sub


End Class


