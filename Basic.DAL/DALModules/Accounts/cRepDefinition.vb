Public Class cRepDefinition

    Dim objConnection As Object

    Public Pageno As String
    Public mLineno As String
    Public Hdr As String
    Public Noteref As String
    Public Description As String
    Public Description1 As String
    Public mValue As String
    'Public Lbalance As Double
    'Public Cbalance As Double
    'Public Abalance As Double
    'Public Lbudget As Double
    'Public Cbudget As Double
    'Public Abudget As Double
    'Public Branch001 As Double
    'Public Branch002 As Double
    'Public Branch003 As Double
    'Public Branch004 As Double
    'Public Branch005 As Double
    'Public Branch006 As Double
    'Public Branch007 As Double
    'Public Branch008 As Double
    'Public Branch009 As Double
    'Public Branch010 As Double
    'Public Branch011 As Double
    'Public Branch012 As Double
    'Public Branch013 As Double
    'Public Branch014 As Double
    'Public Branch015 As Double
    'Public Branch016 As Double
    'Public Branch017 As Double
    'Public Branch018 As Double
    'Public Branch019 As Double
    'Public Branch020 As Double
    'Public Branch021 As Double
    'Public Branch022 As Double
    'Public Branch023 As Double
    'Public Branch024 As Double
    'Public Branch025 As Double
    'Public Branch026 As Double
    'Public Branch027 As Double
    'Public Branch028 As Double
    'Public Branch029 As Double
    'Public Branch030 As Double
    'Public Branch031 As Double
    'Public Branch032 As Double
    'Public Branch033 As Double
    'Public Branch034 As Double
    'Public Branch035 As Double
    'Public Branch036 As Double
    'Public Branch037 As Double
    'Public Branch038 As Double
    'Public Branch039 As Double
    'Public Branch040 As Double
    'Public Branch041 As Double
    'Public Branch042 As Double
    'Public Branch043 As Double
    'Public Branch044 As Double
    'Public Branch045 As Double
    'Public Branch046 As Double
    'Public Branch047 As Double
    'Public Branch048 As Double
    'Public Branch049 As Double
    'Public Branch050 As Double
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
    Public Sub SaveValues()

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@Pageno", Pageno, "nvarchar")
        objDBParameters.AddParameter("@mLineno", mLineno, "nvarchar")
        objDBParameters.AddParameter("@Hdr", Hdr, "nvarchar")
        objDBParameters.AddParameter("@Noteref", Noteref, "nvarchar")
        objDBParameters.AddParameter("@Description", Description, "nvarchar")
        objDBParameters.AddParameter("@Description1", Description1, "nvarchar")
        objDBParameters.AddParameter("@mValue", mValue, "nvarchar")
        objDBParameters.AddParameter("@AddOn", AddOn, "nvarchar")
        objDBParameters.AddParameter("@AddBy", AddBy, "nvarchar")

        objDatabaseManager.ExecuteNonQuery("GL_RepDef_Save", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

    End Sub

    Public Sub EditRepDef()

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@Pageno", Pageno, "nvarchar")
        objDBParameters.AddParameter("@mLineno", mLineno, "nvarchar")
        objDBParameters.AddParameter("@Hdr", Hdr, "nvarchar")
        objDBParameters.AddParameter("@Noteref", Noteref, "nvarchar")
        objDBParameters.AddParameter("@Description", Description, "nvarchar")
        objDBParameters.AddParameter("@Description1", Description1, "nvarchar")
        objDBParameters.AddParameter("@mValue", mValue, "nvarchar")
        objDBParameters.AddParameter("@EditOn", EditOn, "nvarchar")
        objDBParameters.AddParameter("@EditBy", EditBy, "nvarchar")

        objDatabaseManager.ExecuteNonQuery("GL_RepDef_Edit", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

    End Sub

    Public Sub DelRepDef()

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@Pageno", Pageno, "nvarchar")

        objDatabaseManager.ExecuteNonQuery("GL_RepDef_Del", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

    End Sub

    Public Sub LoadRepDef()
        Dim dt As New DataTable

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@Pageno", Pageno, "nvarchar")
        dt = objDatabaseManager.GetDataTable("GL_RepDef_Get", objDBParameters)
        If dt.Rows.Count <> 0 Then
            Pageno = dt.Rows(dt.Rows.Count - 1).Item("Pageno")
            Hdr = "" & dt.Rows(dt.Rows.Count - 1).Item("Hdr")
            AddOn = "" & Format(dt.Rows(dt.Rows.Count - 1).Item("AddOn"), "dd-MMM-yyyy")
            AddBy = "" & dt.Rows(dt.Rows.Count - 1).Item("AddBy")
        End If
    End Sub

    Public Function LoadAllMaster() As DataTable
        Dim dt As New DataTable

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        dt = objDatabaseManager.GetDataTable("GL_AllRepDefs_Get", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)
        'If dt.Rows.Count <> 0 Then
        '    Pageno = dt.Rows(dt.Rows.Count - 1).Item("Pageno")
        '    Hdr = "" & dt.Rows(dt.Rows.Count - 1).Item("Hdr")
        '    AddOn = "" & Format(dt.Rows(dt.Rows.Count - 1).Item("AddOn"), "dd-MMM-yyyy")
        '    AddBy = "" & dt.Rows(dt.Rows.Count - 1).Item("AddBy")
        'End If
        Return dt
    End Function

    Public Function LoadAllDetail() As DataTable
        Dim dt As New DataTable

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@Pageno", Pageno, "char")
        dt = objDatabaseManager.GetDataTable("GL_SubRepDefs_Get", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)
        Return dt
    End Function

    Public Sub LoadFirstRec()
        Dim dt As New DataTable

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        dt = objDatabaseManager.GetDataTable("GL_AllRepDefs_Get", objDBParameters)
        If dt.Rows.Count <> 0 Then
            Pageno = dt.Rows(0).Item("Pageno")
            Hdr = "" & dt.Rows(0).Item("Hdr")
            AddOn = "" & Format(dt.Rows(0).Item("AddOn"), "dd-MMM-yyyy")
            AddBy = "" & dt.Rows(0).Item("AddBy")
        End If
    End Sub

    Public Function GenPageNo() As String
        Dim dt As New DataTable

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        dt = objDatabaseManager.GetDataTable("GL_PageNo_Gen", objDBParameters)

        If Len(Trim(dt.Rows(0).Item(0))) = 1 Then
            Return "0" & CStr(dt.Rows(0).Item(0))
        End If
        Return ""
    End Function
   
End Class
