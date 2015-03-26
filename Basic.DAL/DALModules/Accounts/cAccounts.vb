Public Class cAccounts

    Dim objConnection As Object
    Dim objTransaction As SqlClient.SqlTransaction
    Dim objDatabaseManager As IDatabaseManager

    Public Code As String
    Public Description As String
    Public Desc2 As String
    Public Desc3 As String
    Public Status As String
    Public OpenDate As String
    Public CloseDate As String
    Public AccType As String
    Public Transmit As String
    Public Level As String
    Public AddOn As String
    Public AddBy As String
    Public EditOn As String
    Public EditBy As String
    Public PostOn As String
    Public PostBy As String
    Public PrintOn As String
    Public PrintBy As String
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

        dt = objDatabaseManager.GetDataTable("GL_AllCodes_Get", objDBParameters)
        If dt.Rows.Count <> 0 Then
            Code = dt.Rows(0).Item("Code")
            Description = "" & dt.Rows(0).Item("Description")
            Desc2 = "" & dt.Rows(0).Item("Desc2")
            Desc3 = "" & dt.Rows(0).Item("Desc3")
            Status = "" & dt.Rows(0).Item("Status")
            OpenDate = "" & Format(dt.Rows(0).Item("Opendate"), "dd-MMM-yyyy")
            CloseDate = "" & Format(dt.Rows(0).Item("Closedate"), "dd-MM-yyyy")
            AccType = "" & dt.Rows(0).Item("AccType")
            AddOn = "" & Format(dt.Rows(0).Item("AddOn"), "dd-MMM-yyyy")
            AddBy = "" & dt.Rows(0).Item("AddBy")
        End If
    End Sub

    Public Function LoadAllCodes() As DataTable
        Dim dt As New DataTable

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        dt = objDatabaseManager.GetDataTable("GL_AllCodes_Get", objDBParameters)
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

        objDBParameters.AddParameter("@Code", Code, "nvarchar")
        dt = objDatabaseManager.GetDataTable("GL_Code_Get", objDBParameters)
        If dt.Rows.Count <> 0 Then
            Code = dt.Rows(0).Item("Code")
            Description = "" & dt.Rows(0).Item("Description")
            Desc2 = "" & dt.Rows(0).Item("Desc2")
            Desc3 = "" & dt.Rows(0).Item("Desc3")
            Status = "" & dt.Rows(0).Item("Status")
            OpenDate = "" & Format(dt.Rows(0).Item("Opendate"), "dd-MMM-yyyy")
            CloseDate = "" & Format(dt.Rows(0).Item("Closedate"), "dd-MMM-yyyy")
            AccType = "" & dt.Rows(0).Item("AccType")
            AddOn = "" & Format(dt.Rows(0).Item("AddOn"), "dd-MMM-yyyy")
            AddBy = "" & dt.Rows(0).Item("AddBy")
        End If
    End Sub

    Public Sub DelCode()

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@ACCode", Code, "nvarchar")

        objDatabaseManager.ExecuteNonQuery("GL_Code_Del", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

    End Sub

    Public Sub SaveACCode()

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@Code", Code, "char")
        objDBParameters.AddParameter("@Description", Description, "nvarchar")
        objDBParameters.AddParameter("@Desc2", Desc2, "nvarchar")
        objDBParameters.AddParameter("@Desc3", Desc3, "nvarchar")
        objDBParameters.AddParameter("@Status", Status, "char")
        objDBParameters.AddParameter("@Transmit", Transmit, "char")
        objDBParameters.AddParameter("@OpenDate", OpenDate, "nvarchar")
        objDBParameters.AddParameter("@CloseDate", CloseDate, "nvarchar")
        objDBParameters.AddParameter("@AccType", AccType, "nvarchar")
        objDBParameters.AddParameter("@AddOn", AddOn, "nvarchar")
        objDBParameters.AddParameter("@AddBy", AddBy, "char")

        objDatabaseManager.ExecuteNonQuery("GL_Code_Save", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

    End Sub

    Public Sub EditACCode()

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@Code", Code, "nvarchar")
        objDBParameters.AddParameter("@Description", Description, "nvarchar")
        objDBParameters.AddParameter("@Desc2", Desc2, "nvarchar")
        objDBParameters.AddParameter("@Desc3", Desc3, "nvarchar")
        objDBParameters.AddParameter("@Status", Status, "nvarchar")
        objDBParameters.AddParameter("@OpenDate", OpenDate, "nvarchar")
        objDBParameters.AddParameter("@CloseDate", CloseDate, "nvarchar")
        objDBParameters.AddParameter("@AccType", AccType, "nvarchar")
        objDBParameters.AddParameter("@EditOn", EditOn, "nvarchar")
        objDBParameters.AddParameter("@EditBy", EditBy, "nvarchar")

        objDatabaseManager.ExecuteNonQuery("GL_Code_Edit", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

    End Sub

    Public Function LoadSelectCodes() As DataTable
        Dim dt As New DataTable

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@Level", Level, "nvarchar")

        dt = objDatabaseManager.GetDataTable("GL_CodeLevel_Get", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)
        Return dt
    End Function
End Class
