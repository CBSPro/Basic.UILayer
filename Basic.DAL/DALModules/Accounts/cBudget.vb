Public Class cBudget

    Dim objConnection As Object

    Public BrCode As String
    Public Code As String
    Public Budget1 As Double
    Public Budget2 As Double
    Public Budget3 As Double
    Public Budget4 As Double
    Public Budget5 As Double
    Public Budget6 As Double
    Public Budget7 As Double
    Public Budget8 As Double
    Public Budget9 As Double
    Public Budget10 As Double
    Public Budget11 As Double
    Public Budget12 As Double
    Public AddOn As String
    Public AddBy As String
    Public EditOn As String
    Public EditBy As String
    Public PostOn As String
    Public PostBy As String
    Public PrintOn As String
    Public PrintBy As String

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
    Public Sub SaveBudget()

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@BrCode", BrCode, "nvarchar")
        objDBParameters.AddParameter("@Code", Code, "nvarchar")
        objDBParameters.AddParameter("@Budget1", Budget1, "numeric")
        objDBParameters.AddParameter("@Budget2", Budget2, "numeric")
        objDBParameters.AddParameter("@Budget3", Budget3, "numeric")
        objDBParameters.AddParameter("@Budget4", Budget4, "numeric")
        objDBParameters.AddParameter("@Budget5", Budget5, "numeric")
        objDBParameters.AddParameter("@Budget6", Budget6, "numeric")
        objDBParameters.AddParameter("@Budget7", Budget7, "numeric")
        objDBParameters.AddParameter("@Budget8", Budget8, "numeric")
        objDBParameters.AddParameter("@Budget9", Budget9, "numeric")
        objDBParameters.AddParameter("@Budget10", Budget10, "numeric")
        objDBParameters.AddParameter("@Budget11", Budget11, "numeric")
        objDBParameters.AddParameter("@Budget12", Budget12, "numeric")
        objDBParameters.AddParameter("@AddOn", AddOn, "nvarchar")
        objDBParameters.AddParameter("@AddBy", AddBy, "nvarchar")

        objDatabaseManager.ExecuteNonQuery("GL_Budget_Save", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

    End Sub

    Public Sub EditBudget()

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@BrCode", BrCode, "nvarchar")
        objDBParameters.AddParameter("@Code", Code, "nvarchar")
        objDBParameters.AddParameter("@Budget1", Budget1, "numeric")
        objDBParameters.AddParameter("@Budget2", Budget2, "numeric")
        objDBParameters.AddParameter("@Budget3", Budget3, "numeric")
        objDBParameters.AddParameter("@Budget4", Budget4, "numeric")
        objDBParameters.AddParameter("@Budget5", Budget5, "numeric")
        objDBParameters.AddParameter("@Budget6", Budget6, "numeric")
        objDBParameters.AddParameter("@Budget7", Budget7, "numeric")
        objDBParameters.AddParameter("@Budget8", Budget8, "numeric")
        objDBParameters.AddParameter("@Budget9", Budget9, "numeric")
        objDBParameters.AddParameter("@Budget10", Budget10, "numeric")
        objDBParameters.AddParameter("@Budget11", Budget11, "numeric")
        objDBParameters.AddParameter("@Budget12", Budget12, "numeric")
        objDBParameters.AddParameter("@EditOn", EditOn, "nvarchar")
        objDBParameters.AddParameter("@EditBy", EditBy, "nvarchar")

        objDatabaseManager.ExecuteNonQuery("GL_Budget_Edit", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

    End Sub

    Public Sub DelBranch()

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@BrCode", BrCode, "nvarchar")
        objDBParameters.AddParameter("@Code", Code, "nvarchar")

        objDatabaseManager.ExecuteNonQuery("GL_Budget_Del", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

    End Sub

    Public Sub LoadBudget()
        Dim dt As New DataTable

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@BrCode", BrCode, "nvarchar")
        objDBParameters.AddParameter("@Code", Code, "nvarchar")
        dt = objDatabaseManager.GetDataTable("GL_Budget_Get", objDBParameters)
        If dt.Rows.Count <> 0 Then
            BrCode = dt.Rows(0).Item("BrCode")
            Code = "" & dt.Rows(0).Item("Code")
            Budget1 = "" & dt.Rows(0).Item("Budget1")
            Budget2 = "" & dt.Rows(0).Item("Budget2")
            Budget3 = "" & dt.Rows(0).Item("Budget3")
            Budget4 = "" & dt.Rows(0).Item("Budget4")
            Budget5 = "" & dt.Rows(0).Item("Budget5")
            Budget6 = "" & dt.Rows(0).Item("Budget6")
            Budget7 = "" & dt.Rows(0).Item("Budget7")
            Budget8 = "" & dt.Rows(0).Item("Budget8")
            Budget9 = "" & dt.Rows(0).Item("Budget9")
            Budget10 = "" & dt.Rows(0).Item("Budget10")
            Budget11 = "" & dt.Rows(0).Item("Budget11")
            Budget12 = "" & dt.Rows(0).Item("Budget12")
            AddOn = "" & Format(dt.Rows(0).Item("AddOn"), "dd-MMM-yyyy")
            AddBy = "" & dt.Rows(0).Item("AddBy")
        End If
    End Sub

    Public Function LoadAllBudget() As DataTable
        Dim dt As New DataTable

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        dt = objDatabaseManager.GetDataTable("GL_AllBudget_Get", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)
        'If dt.Rows.Count <> 0 Then
        '    BrCode = dt.Rows(dt.Rows.Count - 1).Item("BrCode")
        '    Code = "" & dt.Rows(dt.Rows.Count - 1).Item("Code")
        '    Budget1 = "" & dt.Rows(dt.Rows.Count - 1).Item("Budget1")
        '    Budget2 = "" & dt.Rows(dt.Rows.Count - 1).Item("Budget2")
        '    Budget3 = "" & dt.Rows(dt.Rows.Count - 1).Item("Budget3")
        '    Budget4 = "" & dt.Rows(dt.Rows.Count - 1).Item("Budget4")
        '    Budget5 = "" & dt.Rows(dt.Rows.Count - 1).Item("Budget5")
        '    Budget6 = "" & dt.Rows(dt.Rows.Count - 1).Item("Budget6")
        '    Budget7 = "" & dt.Rows(dt.Rows.Count - 1).Item("Budget7")
        '    Budget8 = "" & dt.Rows(dt.Rows.Count - 1).Item("Budget8")
        '    Budget9 = "" & dt.Rows(dt.Rows.Count - 1).Item("Budget9")
        '    Budget10 = "" & dt.Rows(dt.Rows.Count - 1).Item("Budget10")
        '    Budget11 = "" & dt.Rows(dt.Rows.Count - 1).Item("Budget11")
        '    Budget12 = "" & dt.Rows(dt.Rows.Count - 1).Item("Budget12")
        '    AddOn = "" & Format(dt.Rows(dt.Rows.Count - 1).Item("AddOn"), "dd-MMM-yyyy")
        '    AddBy = "" & dt.Rows(dt.Rows.Count - 1).Item("AddBy")
        'End If
        Return dt
    End Function

    'Public Sub LoadFirstRec()
    '    Dim dt As New DataTable

    '    objConnection = cConnectionManager.GetConnection()
    '    Dim objDatabaseManager As IDatabaseManager
    '    Dim objDBParameters As New cDBParameterList
    '    objDatabaseManager = cDataBaseManager.GetDatabaseManager()
    '    objDatabaseManager.SetConnection(objConnection)

    '    dt = objDatabaseManager.GetDataTable("Sp_GetAllBudget", objDBParameters)
    '    If dt.Rows.Count <> 0 Then
    '        BrCode = dt.Rows(0).Item("BrCode")
    '        Code = "" & dt.Rows(0).Item("Code")
    '        Budget1 = "" & dt.Rows(0).Item("Budget1")
    '        Budget2 = "" & dt.Rows(0).Item("Budget2")
    '        Budget3 = "" & dt.Rows(0).Item("Budget3")
    '        Budget4 = "" & dt.Rows(0).Item("Budget4")
    '        Budget5 = "" & dt.Rows(0).Item("Budget5")
    '        Budget6 = "" & dt.Rows(0).Item("Budget6")
    '        Budget7 = "" & dt.Rows(0).Item("Budget7")
    '        Budget8 = "" & dt.Rows(0).Item("Budget8")
    '        Budget9 = "" & dt.Rows(0).Item("Budget9")
    '        Budget10 = "" & dt.Rows(0).Item("Budget10")
    '        Budget11 = "" & dt.Rows(0).Item("Budget11")
    '        Budget12 = "" & dt.Rows(0).Item("Budget12")
    '        AddOn = "" & Format(dt.Rows(0).Item("AddOn"), "dd-MMM-yyyy")
    '        AddBy = "" & dt.Rows(0).Item("AddBy")
    '    End If
    'End Sub
End Class
