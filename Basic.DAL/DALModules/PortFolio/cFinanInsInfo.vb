Public Class cFinanInsInfo
    Dim objConnection As Object
    Dim objTransaction As SqlClient.SqlTransaction
    Dim objDatabaseManager As IDatabaseManager


    Dim dtLookup As DataTable
    Public InstCode As String
    Public InstName As String
    Public FinTypeCode As String
    Public Rating As String
    Public CompCode As String
    Public PrintOp As String
    Public BnkAccNo As String
    Public Descrip As String
    '===============================
    Public InsBranCode As String
    Public InsBrName As String

    Public InsBrAddres As String
    Public ContPer As String
    Public InsBrBnkAccNo As String
    Public Ph As String
    Public Email As String
    Public Fax As String
    Public Description As String
    Public BISPNo As String

    Public BICCode As String
    Public DepBnk As String
    Public SetBnk As String
    Public PrimDeal As String
    Public CounPart As String
    

    '===============================
    Public transfer As String
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



    'Public Sub LoadFirstRec()
    '    Dim dt As New DataTable

    '    objConnection = cConnectionManager.GetConnection()
    '    Dim objDatabaseManager As IDatabaseManager
    '    Dim objDBParameters As New cDBParameterList
    '    objDatabaseManager = cDataBaseManager.GetDatabaseManager()
    '    objDatabaseManager.SetConnection(objConnection)

    '    dt = objDatabaseManager.GetDataTable("PortFolio_GetFinType_All", objDBParameters)
    '    If dt.Rows.Count <> 0 Then

    '        InstCode = dt.Rows(0).Item("FinTypeCode")
    '        'TypeName = "" & dt.Rows(0).Item("TypeName")
    '        'TypeDescription = "" & dt.Rows(0).Item("TypeDescription")





    '        'AddOn = "" & Format(dt.Rows(0).Item("AddOn"), "dd-MMM-yyyy")
    '        'AddBy = "" & dt.Rows(0).Item("AddBy")
    '    End If
    'End Sub

    'Public Function LoadAllCodes() As DataTable
    '    Dim dt As New DataTable

    '    objConnection = cConnectionManager.GetConnection()
    '    Dim objDatabaseManager As IDatabaseManager
    '    Dim objDBParameters As New cDBParameterList
    '    objDatabaseManager = cDataBaseManager.GetDatabaseManager()
    '    objDatabaseManager.SetConnection(objConnection)


    '    dt = objDatabaseManager.GetDataTable("PortFolio_GetFinType_All", objDBParameters)
    '    cConnectionManager.CloseConnection(objConnection)
    '    Return dt
    'End Function
    'Public Sub LoadCode()
    '    Dim dt As New DataTable

    '    objConnection = cConnectionManager.GetConnection()
    '    Dim objDatabaseManager As IDatabaseManager
    '    Dim objDBParameters As New cDBParameterList
    '    objDatabaseManager = cDataBaseManager.GetDatabaseManager()
    '    objDatabaseManager.SetConnection(objConnection)

    '    objDBParameters.AddParameter("@FinTypeCode", FinTypeCode, "char")
    '    dt = objDatabaseManager.GetDataTable("PortFolio_FinType_Get", objDBParameters)
    '    If dt.Rows.Count <> 0 Then
    '        FinTypeCode = dt.Rows(0).Item("FinTypeCode")
    '        TypeName = "" & dt.Rows(0).Item("TypeName")

    '        TypeDescription = "" & dt.Rows(0).Item("TypeDescription")


    '    End If
    'End Sub

    'Public Sub DelFinTypeCode()

    '    objConnection = cConnectionManager.GetConnection()
    '    Dim objDatabaseManager As IDatabaseManager
    '    Dim objDBParameters As New cDBParameterList
    '    objDatabaseManager = cDataBaseManager.GetDatabaseManager()
    '    objDatabaseManager.SetConnection(objConnection)

    '    objDBParameters.AddParameter("@FinTypeCode", FinTypeCode, "char")

    '    objDatabaseManager.ExecuteNonQuery("PortFolio_FinType_Del", objDBParameters)
    '    cConnectionManager.CloseConnection(objConnection)

    'End Sub

    'Public Sub SaveFinTypeCode()

    '    objConnection = cConnectionManager.GetConnection()
    '    Dim objDatabaseManager As IDatabaseManager
    '    Dim objDBParameters As New cDBParameterList
    '    objDatabaseManager = cDataBaseManager.GetDatabaseManager()
    '    objDatabaseManager.SetConnection(objConnection)


    '    objDBParameters.AddParameter("@FinTypeCode", FinTypeCode, "char")

    '    objDBParameters.AddParameter("@TypeName", TypeName, "varchar")
    '    objDBParameters.AddParameter("@TypeDescription", TypeDescription, "varchar")


    '    objDBParameters.AddParameter("@AddOn", AddOn, "nvarchar")
    '    objDBParameters.AddParameter("@AddBy", AddBy, "nvarchar")

    '    objDatabaseManager.ExecuteNonQuery("PortFolio_FinType_Save", objDBParameters)
    '    cConnectionManager.CloseConnection(objConnection)

    'End Sub

    'Public Sub EditFinTypeCode()

    '    objConnection = cConnectionManager.GetConnection()
    '    Dim objDatabaseManager As IDatabaseManager
    '    Dim objDBParameters As New cDBParameterList
    '    objDatabaseManager = cDataBaseManager.GetDatabaseManager()
    '    objDatabaseManager.SetConnection(objConnection)


    '    objDBParameters.AddParameter("@FinTypeCode", FinTypeCode, "char")

    '    objDBParameters.AddParameter("@TypeName", TypeName, "varchar")
    '    objDBParameters.AddParameter("@TypeDescription", TypeDescription, "varchar")



    '    objDBParameters.AddParameter("@EditOn", EditOn, "nvarchar")
    '    objDBParameters.AddParameter("@EditBy", EditBy, "nvarchar")

    '    objDatabaseManager.ExecuteNonQuery("PortFolio_FinType_Edit", objDBParameters)
    '    cConnectionManager.CloseConnection(objConnection)

    'End Sub
    'Public Function GenFinTypeCode() As String
    '    Dim dt As New DataTable

    '    objConnection = cConnectionManager.GetConnection()
    '    Dim objDatabaseManager As IDatabaseManager
    '    Dim objDBParameters As New cDBParameterList
    '    objDatabaseManager = cDataBaseManager.GetDatabaseManager()
    '    objDatabaseManager.SetConnection(objConnection)

    '    dt = objDatabaseManager.GetDataTable("PortFolio_FinTypeCode_Gen", objDBParameters)
    '    If dt.Rows.Count <> 0 Then
    '        If Len(Trim(dt.Rows(0).Item(0))) = 1 Then
    '            Return "0" & CStr(dt.Rows(0).Item(0))
    '        Else
    '            Return CStr(dt.Rows(0).Item(0))
    '        End If
    '        'Else
    '        '    Return "0001"
    '    End If
    '    Return ""
    'End Function

End Class
