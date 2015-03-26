Public Class cVoucherDetail

    Dim objConnection As Object

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

    Public Function LoadAllMaster() As DataTable
        Dim dt As New DataTable

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@BrCode", BrCode, "char")
        objDBParameters.AddParameter("@Type", Type, "char")
        objDBParameters.AddParameter("@VNo", VNo, "char")

        dt = objDatabaseManager.GetDataTable("GL_MasterVoucher_Get", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)
        Return dt
    End Function

    Public Function LoadAllDetail() As DataTable
        Dim dt As New DataTable

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@BrCode", BrCode, "char")
        objDBParameters.AddParameter("@Type", Type, "char")
        objDBParameters.AddParameter("@VNo", VNo, "char")
        dt = objDatabaseManager.GetDataTable("GL_VoucherDetail_Get", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)
        Return dt
    End Function
End Class
