Public Class cTrialBal

    Dim objConnection As Object

    Public Code As String
    Public Description As String
    Public Level As String
    Public Branch001 As Double
    Public Branch002 As Double
    Public Branch003 As Double
    Public Branch004 As Double
    Public Branch005 As Double
    Public Branch006 As Double
    Public Branch007 As Double
    Public Branch008 As Double
    Public Branch009 As Double
    Public Branch010 As Double
    Public Branch011 As Double
    Public Branch012 As Double
    Public Branch013 As Double
    Public Branch014 As Double
    Public Branch015 As Double
    Public Branch016 As Double
    Public Branch017 As Double
    Public Branch018 As Double
    Public Branch091 As Double
    Public Branch020 As Double
    Public Branch021 As Double
    Public Branch022 As Double
    Public Branch023 As Double
    Public Branch024 As Double
    Public Branch025 As Double
    Public Branch026 As Double
    Public Branch027 As Double
    Public Branch028 As Double
    Public Branch029 As Double
    Public Branch030 As Double
    Public Branch031 As Double
    Public Branch032 As Double
    Public Branch033 As Double
    Public Branch034 As Double
    Public Branch035 As Double
    Public Branch036 As Double
    Public Branch037 As Double
    Public Branch038 As Double
    Public Branch039 As Double
    Public Branch040 As Double
    Public Branch041 As Double
    Public Branch042 As Double
    Public Branch043 As Double
    Public Branch044 As Double
    Public Branch045 As Double
    Public Branch046 As Double
    Public Branch047 As Double
    Public Branch048 As Double
    Public Branch049 As Double
    Public Branch050 As Double
    Public BranchName As String
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
    Public Sub DelTBall()

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDatabaseManager.ExecuteNonQuery("Sp_DelTBall", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

    End Sub

    Public Function LoadBranch() As DataTable
        Dim dt As New DataTable

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        dt = objDatabaseManager.GetDataTable("GL_BrName_Get", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)
        Return dt
    End Function

    Public Function LoadCodes() As DataTable
        Dim dt As New DataTable

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@Level", Level, "char")

        dt = objDatabaseManager.GetDataTable("GL_TBalCode_Get", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)
        Return dt
    End Function

    Public Function GetTBal() As DataTable
        Dim dt As New DataTable

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        dt = objDatabaseManager.GetDataTable("GL_TBal_Get", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)
        Return dt
    End Function

    Public Function GetAllTBal() As DataTable
        Dim dt As New DataTable

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        dt = objDatabaseManager.GetDataTable("GL_AllTBal_Get", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)
        Return dt
    End Function

    Public Sub SaveValues()

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@Code", Code, "nvarchar")
        objDBParameters.AddParameter("@Description", Description, "nvarchar")

        objDatabaseManager.ExecuteNonQuery("GL_TBal_Save", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

    End Sub

    Public Sub EditValues()

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@Code", Code, "nvarchar")
        objDBParameters.AddParameter("@Branch001", Branch001, "double")
        'objDBParameters.AddParameter("@BranchName", BranchName, "nvarchar")

        objDatabaseManager.ExecuteNonQuery("GL_TBal_Edit", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

    End Sub
End Class
