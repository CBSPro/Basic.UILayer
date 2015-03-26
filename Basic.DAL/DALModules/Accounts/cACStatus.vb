Public Class cACStatus

    Dim objConnection As Object
    Dim cSqlDatabaseManager As Object
    Dim objTransaction As SqlClient.SqlTransaction
    Dim objDatabaseManager As IDatabaseManager
    Public BrCode As String
    Public BrName As String
    Public Type As String
    Public VNo As String
    Public SeqNo As String
    Public VDate As String
    Public Code As String
    Public Description As String
    Public Remarks As String
    Public RfCode As String
    Public Chequeno As String
    Public Chequedate As String
    Public Posted As String
    Public OpBal As Double
    Public Debit As Double
    Public Credit As Double
    Public StDate As String
    Public EnDate As String
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

    Public Function FillGrid() As DataTable
        Dim dt As New DataTable

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        'objDBParameters.AddParameter("@EnDate", EnDate, "varchar")
        'objDBParameters.AddParameter("@StDate", StDate, "varchar")
        'objDBParameters.AddParameter("@SCode", Code, "char")
        'objDBParameters.AddParameter("@ECode", Code, "char")
        'objDBParameters.AddParameter("@BrCode", BrCode, "char")

        objDBParameters.AddParameter("@BrCode", BrCode, "char")
        objDBParameters.AddParameter("@SCode", Code, "char")
        objDBParameters.AddParameter("@ECode", Code, "char")
        objDBParameters.AddParameter("@StDate", StDate, "varchar")
        objDBParameters.AddParameter("@EnDate", EnDate, "varchar")




        dt = objDatabaseManager.GetDataTable("GL_GetAcc_Status", objDBParameters)
        'dt = cSqlDatabaseManager.GetDataTable("Sp_GetACStatus", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)
        Return dt
    End Function
End Class
