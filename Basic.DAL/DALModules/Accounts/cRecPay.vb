Public Class cRecPay

    Dim objConnection As Object
    Dim objTransaction As SqlClient.SqlTransaction
    Dim objDatabaseManager As IDatabaseManager

    Public BrCode As String
    Public Type As String
    Public VNo As String
    Public SeqNo As String
    Public VDate As String
    Public RfCode As String
    Public RefRemarks As String

    'Public RefTaxCode As String
    'Public TaxRate As String
    Public Code As String
    Public Remarks As String
    Public Debit As Double
    Public Credit As Double
    Public Chequeno As String
    Public Chequedate As String
    Public StDate As String
    Public EndDate As String
    Public Level As String
    Public AddOn As String
    Public AddBy As String
    Public EditOn As String
    Public EditBy As String
    Public PrintOn As String
    Public PrintBy As String
    Public PostOn As String
    Public PostBy As String
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
    Public Sub SaveMaster()

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@BrCode", BrCode, "nvarchar")
        objDBParameters.AddParameter("@Type", Type, "nvarchar")
        objDBParameters.AddParameter("@VNo", VNo, "nvarchar")
        objDBParameters.AddParameter("@VDate", VDate, "nvarchar")
        objDBParameters.AddParameter("@RfCode", RfCode, "nvarchar")
        'objDBParameters.AddParameter("@RefTaxCode", RefTaxCode, "nvarchar")
        'objDBParameters.AddParameter("@TaxRate", TaxRate, "nvarchar")
        objDBParameters.AddParameter("@RefRemarks", RefRemarks, "nvarchar")
        objDBParameters.AddParameter("@AddOn", AddOn, "nvarchar")
        objDBParameters.AddParameter("@AddBy", AddBy, "nvarchar")


        objDatabaseManager.ExecuteNonQuery("GL_Master_Save", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

    End Sub

    Public Sub SaveDetail()

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        
        objDBParameters.AddParameter("@BrCode", BrCode, "nvarchar")
        objDBParameters.AddParameter("@Type", Type, "nvarchar")
        objDBParameters.AddParameter("@VNo", VNo, "nvarchar")
        objDBParameters.AddParameter("@SeqNo", SeqNo, "nvarchar")
        objDBParameters.AddParameter("@VDate", VDate, "nvarchar")
        objDBParameters.AddParameter("@Code", Code, "nvarchar")
        objDBParameters.AddParameter("@RfCode", RfCode, "nvarchar")
        objDBParameters.AddParameter("@Remarks", Remarks, "nvarchar")
        objDBParameters.AddParameter("@Debit", Debit, "double")
        objDBParameters.AddParameter("@Credit", Credit, "double")
        objDBParameters.AddParameter("@Chequeno", Chequeno, "nvarchar")
        objDBParameters.AddParameter("@Chequedate", Chequedate, "nvarchar")

        objDatabaseManager.ExecuteNonQuery("GL_Detail_Save", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

    End Sub

    Public Sub EditMaster()

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@BrCode", BrCode, "nvarchar")
        objDBParameters.AddParameter("@Type", Type, "nvarchar")
        objDBParameters.AddParameter("@VNo", VNo, "nvarchar")
        objDBParameters.AddParameter("@VDate", VDate, "nvarchar")
        objDBParameters.AddParameter("@RfCode", RfCode, "nvarchar")
        'objDBParameters.AddParameter("@RefTaxCode", RefTaxCode, "nvarchar")
        'objDBParameters.AddParameter("@TaxRate", TaxRate, "nvarchar")
        objDBParameters.AddParameter("@RefRemarks", RefRemarks, "nvarchar")
        objDBParameters.AddParameter("@EditOn", EditOn, "nvarchar")
        objDBParameters.AddParameter("@EditBy", EditBy, "nvarchar")

        objDatabaseManager.ExecuteNonQuery("GL_Master_Eidt", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

    End Sub

    Public Sub EditDetail()
        'Delete(Voucher)Detail
        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@BrCode", BrCode, "nvarchar")
        objDBParameters.AddParameter("@Type", Type, "nvarchar")
        objDBParameters.AddParameter("@VNo", VNo, "nvarchar")
        'objDBParameters.AddParameter("@SeqNo", SeqNo, "nvarchar")
        'objDBParameters.AddParameter("@VDate", VDate, "nvarchar")
        'objDBParameters.AddParameter("@Code", Code, "nvarchar")
        'objDBParameters.AddParameter("@RfCode", RfCode, "nvarchar")
        'objDBParameters.AddParameter("@Remarks", Remarks, "nvarchar")
        'objDBParameters.AddParameter("@Debit", Debit, "double")
        'objDBParameters.AddParameter("@Credit", Credit, "double")
        'objDBParameters.AddParameter("@Chequeno", Chequeno, "nvarchar")
        'objDBParameters.AddParameter("@Chequedate", Chequedate, "nvarchar")

        objDatabaseManager.ExecuteNonQuery("GL_Detail_Edit", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

    End Sub

    Public Sub DelRecPay()

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@BrCode", BrCode, "nvarchar")
        objDBParameters.AddParameter("@Type", Type, "nvarchar")
        objDBParameters.AddParameter("@VNo", VNo, "nvarchar")

        objDatabaseManager.ExecuteNonQuery("GL_Voucher_Del", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

    End Sub

    Public Sub LoadRepDef()
        'Dim dt As New DataTable

        'objConnection = cConnectionManager.GetConnection()
        'Dim objDatabaseManager As IDatabaseManager
        'Dim objDBParameters As New cDBParameterList
        'objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        'objDatabaseManager.SetConnection(objConnection)

        'objDBParameters.AddParameter("@Pageno", Pageno, "nvarchar")
        'dt = objDatabaseManager.GetDataTable("Sp_GetRepDef", objDBParameters)
        'If dt.Rows.Count <> 0 Then
        '    Pageno = dt.Rows(dt.Rows.Count - 1).Item("Pageno")
        '    Hdr = "" & dt.Rows(dt.Rows.Count - 1).Item("Hdr")
        '    AddOn = "" & Format(dt.Rows(dt.Rows.Count - 1).Item("AddOn"), "dd-MMM-yyyy")
        '    AddBy = "" & dt.Rows(dt.Rows.Count - 1).Item("AddBy")
        'End If
    End Sub

    Public Function LoadAllMaster() As DataTable
        Dim dt As New DataTable

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@BrCode", BrCode, "char")
        objDBParameters.AddParameter("@Type", Type, "char")
        objDBParameters.AddParameter("@SDate", StDate, "nvarchar")
        objDBParameters.AddParameter("@EDate", EndDate, "nvarchar")
        objDBParameters.AddParameter("@Level", Level, "char")
      
        dt = objDatabaseManager.GetDataTable("GL_AllMaster_Get", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)
        Return dt
    End Function

    Public Function LoadMasterVoucher() As DataTable
        Dim dt As New DataTable

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@BrCode", BrCode, "char")
        objDBParameters.AddParameter("@Type", Type, "char")
        objDBParameters.AddParameter("@VNo", VNo, "char")

        dt = objDatabaseManager.GetDataTable("GL_Master_Get", objDBParameters)
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

        dt = objDatabaseManager.GetDataTable("GL_AllDetail_Get", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)
        Return dt
    End Function

    Public Function LoadSelectRecPay() As DataTable
        Dim dt As New DataTable

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@Type", Type, "char")
        objDBParameters.AddParameter("@StDate", StDate, "char")
        objDBParameters.AddParameter("@EndDate", EndDate, "char")
        objDBParameters.AddParameter("@Level", Level, "char")

        dt = objDatabaseManager.GetDataTable("GL_MasterLevel_Get", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)
        Return dt
    End Function
    
End Class
