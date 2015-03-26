Public Class cBranch

    Dim objConnection As Object

    Public BrCode As String
    Public BrName As String
    Public Addr1 As String
    Public Addr2 As String
    Public Addr3 As String
    Public Phone1 As String
    Public Phone2 As String
    Public Fax As String
    Public Email As String
    Public Opdate As String
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
    Public Sub SaveBranch()

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@BrCode", BrCode, "nvarchar")
        objDBParameters.AddParameter("@BrName", BrName, "nvarchar")
        objDBParameters.AddParameter("@Addr1", Addr1, "nvarchar")
        objDBParameters.AddParameter("@Addr2", Addr2, "nvarchar")
        objDBParameters.AddParameter("@Addr3", Addr3, "nvarchar")
        objDBParameters.AddParameter("@Phone1", Phone1, "nvarchar")
        objDBParameters.AddParameter("@Phone2", Phone2, "nvarchar")
        objDBParameters.AddParameter("@Fax", Fax, "nvarchar")
        objDBParameters.AddParameter("@Email", Email, "nvarchar")
        objDBParameters.AddParameter("@Opdate", Opdate, "nvarchar")
        objDBParameters.AddParameter("@AddOn", AddOn, "nvarchar")
        objDBParameters.AddParameter("@AddBy", AddBy, "nvarchar")

        objDatabaseManager.ExecuteNonQuery("GL_Branch_Save", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

    End Sub

    Public Sub EditBranch()

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@BrCode", BrCode, "nvarchar")
        objDBParameters.AddParameter("@BrName", BrName, "nvarchar")
        objDBParameters.AddParameter("@Addr1", Addr1, "nvarchar")
        objDBParameters.AddParameter("@Addr2", Addr2, "nvarchar")
        objDBParameters.AddParameter("@Addr3", Addr3, "nvarchar")
        objDBParameters.AddParameter("@Phone1", Phone1, "nvarchar")
        objDBParameters.AddParameter("@Phone2", Phone2, "nvarchar")
        objDBParameters.AddParameter("@Fax", Fax, "nvarchar")
        objDBParameters.AddParameter("@Email", Email, "nvarchar")
        objDBParameters.AddParameter("@Opdate", Opdate, "nvarchar")
        objDBParameters.AddParameter("@EditOn", EditOn, "nvarchar")
        objDBParameters.AddParameter("@EditBy", EditBy, "nvarchar")

        objDatabaseManager.ExecuteNonQuery("GL_Branch_Edit", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

    End Sub

    Public Sub DelBranch()

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@BrCode", BrCode, "nvarchar")

        objDatabaseManager.ExecuteNonQuery("GL_Branch_Del", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

    End Sub

    Public Function LoadBranch() As DataTable
        Dim dt As New DataTable

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@BrCode", BrCode, "nvarchar")
        dt = objDatabaseManager.GetDataTable("Sp_GetBranch", objDBParameters)

        Return dt
    End Function

    Public Function LoadAllBranch() As DataTable
        Dim dt As New DataTable

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        dt = objDatabaseManager.GetDataTable("GL_AllBranchs_Get", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)
        Return dt
    End Function

    Public Function GenBrCode() As String
        Dim dt As New DataTable

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        dt = objDatabaseManager.GetDataTable("GL_BranchCode_Gen", objDBParameters)
        If dt.Rows.Count <> 0 Then
            If (dt Is Nothing And dt.Rows.Count <= 1) Then
                Return "001"
            ElseIf Len(Trim(dt.Rows(0).Item(0))) = 1 Then
                Return "00" & CStr(dt.Rows(0).Item(0))
            ElseIf Len(Trim(dt.Rows(0).Item(0))) = 2 Then
                Return "0" & CStr(dt.Rows(0).Item(0))
            Else
                Return CStr(dt.Rows(0).Item(0))
            End If
            'Else
            '    Return "0001"
        End If
            Return ""
    End Function
End Class
