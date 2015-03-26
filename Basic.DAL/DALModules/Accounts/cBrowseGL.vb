Public Class cBrowseGL

    Dim objConnection As Object

    Public BrCode As String
    Public BrName As String
    Public Type As String

    Public Function FillBranch() As DataTable
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

    Public Function FillType() As DataTable
        Dim dt As New DataTable

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        dt = objDatabaseManager.GetDataTable("GL_AllType_Get", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)
        Return dt
    End Function
End Class
