Public Class cAging

    Dim objConnection As Object

    Public Code As String
    Public BrCode As String
    Public SCode As String
    Public ECode As String
    Public AgDate As String
    Public VDate As String
    Public TotAmt As Double
    Public FstInt As String
    Public FstAmt As Double
    Public SndInt As String
    Public SndAmt As Double
    Public TrdInt As String
    Public TrdAmt As Double
    Public FurInt As String
    Public FurAmt As Double
    Public FveInt As String
    Public FveAmt As Double
    Public SixInt As String
    Public SixAmt As Double
    Public SvnInt As String
    Public SvnAmt As Double

    Private Tdays(8) As Integer
    Private Tval(8) As Double
    Private Tqty(8) As Double
    Dim TBalance As Double
    Dim Days As Integer
    Dim TSign As Integer
    Dim PaidAmt As Double
    Dim tCode As String
    Dim Lastrecno As String
    Dim Lastrectype As String
    Dim Lastrecdate As String
    Dim Lastrecqty As Double
    Dim Lastrecval As Double
    Dim tStoreCode As String
    Dim tItemCode As String
    Dim anDate As Date
    Dim Lastisuno As String
    Dim Lastisutype As String
    Dim Lastisudate As String
    Dim Lastisuqty As Double
    Dim Lastisuval As Double
    Dim Tbalq As Double
    Dim Tbalv As Double
    Dim Abalq As Double
    Dim Abalv As Double
    Dim Daysbalq As Double
    Dim Daysbalv As Double
    Dim StockRecordDate As Date
    Dim stockDocType As String

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

    Public Function GetCode() As DataTable
        Dim dt As New DataTable

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@SCode", SCode, "char")
        objDBParameters.AddParameter("@ECode", ECode, "char")

        dt = objDatabaseManager.GetDataTable("GL_Code_Get", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)
        Return dt
    End Function

    Public Function GetBalance() As DataTable
        Dim dt As New DataTable

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@BrCode", BrCode, "char")
        objDBParameters.AddParameter("@Code", Code, "char")
        objDBParameters.AddParameter("@VDate", VDate, "nvarchar")

        dt = objDatabaseManager.GetDataTable("GL_Balance_Get", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)
        Return dt
    End Function

    Public Sub SaveAging()

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@Code", Code, "char")
        objDBParameters.AddParameter("@AgDate", AgDate, "nvarchar")
        objDBParameters.AddParameter("@TotAmt", TotAmt, "double")
        objDBParameters.AddParameter("@FstInt", FstInt, "nvarchar")
        objDBParameters.AddParameter("@FstAmt", FstAmt, "double")
        objDBParameters.AddParameter("@SndInt", SndInt, "nvarchar")
        objDBParameters.AddParameter("@SndAmt", SndAmt, "double`")
        objDBParameters.AddParameter("@TrdInt", TrdInt, "nvarchar")
        objDBParameters.AddParameter("@TrdAmt", TrdAmt, "double")
        objDBParameters.AddParameter("@FurInt", FurInt, "nvarchar")
        objDBParameters.AddParameter("@FurAmt", FurAmt, "double")
        objDBParameters.AddParameter("@FveInt", FveInt, "nvarchar")
        objDBParameters.AddParameter("@FveAmt", FveAmt, "double`")
        objDBParameters.AddParameter("@SixInt", SixInt, "nvarchar")
        objDBParameters.AddParameter("@SixAmt", SixAmt, "double")
        objDBParameters.AddParameter("@SvnInt", SvnInt, "nvarchar")
        objDBParameters.AddParameter("@SvnAmt", SvnAmt, "double")

        objDatabaseManager.ExecuteNonQuery("GL_Aging_Save", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

    End Sub

    Public Sub DelAging()

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDatabaseManager.ExecuteNonQuery("GL_Agging_Del", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

    End Sub

End Class
