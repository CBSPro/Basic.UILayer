Public Class cScrip

    Dim objConnection As Object
    Dim objTransaction As SqlClient.SqlTransaction
    Dim objDatabaseManager As IDatabaseManager


    Public ScripCode As String
    Public ScripName As String
    Public Description As String

    Public SecCode As String
    Public TypeName As String
    Public TypeDescription As String
    Public SecurityCode As String
    Public GOCCode As String
    Public Symbol As String

    Public FaceVal As String
    Public AuthCap As String
    Public DelistDate As String
    Public GOC As String
    Public FutureTrade As String
    Public CDCELIG As String

    Public LisStkExch As String
    Public DD As String
    Public CompCode As String

            
    Public PaidUpCap As String


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



    Public Sub LoadFirstRec()
        Dim dt As New DataTable

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        dt = objDatabaseManager.GetDataTable("PortFolio_GetScrip_All", objDBParameters)
        If dt.Rows.Count <> 0 Then

            ScripCode = dt.Rows(0).Item("ScripCode")
            ScripName = "" & dt.Rows(0).Item("ScripName")
            Description = "" & dt.Rows(0).Item("Description")

            SecCode = "" & dt.Rows(0).Item("SecCode")
            SecurityCode = "" & dt.Rows(0).Item("SecurityCode")
            CompCode = "" & dt.Rows(0).Item("CompCode")
            GOCCode = "" & dt.Rows(0).Item("GOCCode")
            Symbol = "" & dt.Rows(0).Item("Symbol")
            FaceVal = "" & dt.Rows(0).Item("FaceVal")
            PaidUpCap = "" & dt.Rows(0).Item("PaidUpCap")
            AuthCap = "" & dt.Rows(0).Item("AuthCap")
            DelistDate = "" & dt.Rows(0).Item("DelistDate")
            GOC = "" & dt.Rows(0).Item("GOC")
            FutureTrade = "" & dt.Rows(0).Item("FutureTrade")
            CDCELIG = "" & dt.Rows(0).Item("CDCELIG")
            LisStkExch = "" & dt.Rows(0).Item("LisStkExch")
            DD = "" & dt.Rows(0).Item("DD")
          



            'AddOn = "" & Format(dt.Rows(0).Item("AddOn"), "dd-MMM-yyyy")
            'AddBy = "" & dt.Rows(0).Item("AddBy")
        End If
    End Sub

    Public Function LoadAllCodes() As DataTable
        Dim dt As New DataTable

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)


        dt = objDatabaseManager.GetDataTable("PortFolio_GetScrip_All", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)
        Return dt
    End Function
    Public Sub LoadCode()
        Dim dt As New DataTable

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@ScripCode", ScripCode, "char")
        dt = objDatabaseManager.GetDataTable("PortFolio_Scrip_Get", objDBParameters)
        If dt.Rows.Count <> 0 Then
            ScripCode = dt.Rows(0).Item("ScripCode")
            ScripName = "" & dt.Rows(0).Item("ScripName")
            Description = "" & dt.Rows(0).Item("Description")

            SecCode = "" & dt.Rows(0).Item("SecCode")
            SecurityCode = "" & dt.Rows(0).Item("SecurityCode")
            CompCode = "" & dt.Rows(0).Item("CompCode")
            GOCCode = "" & dt.Rows(0).Item("GOCCode")
            Symbol = "" & dt.Rows(0).Item("Symbol")
            FaceVal = "" & dt.Rows(0).Item("FaceVal")
            PaidUpCap = "" & dt.Rows(0).Item("PaidUpCap")
            AuthCap = "" & dt.Rows(0).Item("AuthCap")
            DelistDate = "" & dt.Rows(0).Item("DelistDate")
            GOC = "" & dt.Rows(0).Item("GOC")
            FutureTrade = "" & dt.Rows(0).Item("FutureTrade")
            CDCELIG = "" & dt.Rows(0).Item("CDCELIG")
            LisStkExch = "" & dt.Rows(0).Item("LisStkExch")
            DD = "" & dt.Rows(0).Item("DD")


        End If
    End Sub

    Public Sub DelCustoCode()

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)

        objDBParameters.AddParameter("@ScripCode", ScripCode, "char")

        objDatabaseManager.ExecuteNonQuery("PortFolio_Scrip_Del", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

    End Sub

    Public Sub SaveFinTypeCode()

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)


        objDBParameters.AddParameter("@ScripCode", ScripCode, "char")

        objDBParameters.AddParameter("@ScripName", ScripName, "varchar")
        objDBParameters.AddParameter("@Description", Description, "varchar")

        objDBParameters.AddParameter("@SecCode", SecCode, "char")
        objDBParameters.AddParameter("@SecurityCode", SecurityCode, "char")
        objDBParameters.AddParameter("@CompCode", CompCode, "char")
        objDBParameters.AddParameter("@GOCCode", GOCCode, "char")
        objDBParameters.AddParameter("@Symbol", Symbol, "varchar")

        objDBParameters.AddParameter("@FaceVal", FaceVal, "double")
        objDBParameters.AddParameter("@PaidUpCap", PaidUpCap, "double")


        objDBParameters.AddParameter("@AuthCap", AuthCap, "double")
        objDBParameters.AddParameter("@DelistDate", DelistDate, "varchar")
        objDBParameters.AddParameter("@GOC", GOC, "char")
        objDBParameters.AddParameter("@FutureTrade", FutureTrade, "char")

        objDBParameters.AddParameter("@CDCELIG", CDCELIG, "char")
        objDBParameters.AddParameter("@LisStkExch", LisStkExch, "char")
        objDBParameters.AddParameter("@DD", DD, "char")
      

        objDBParameters.AddParameter("@AddOn", AddOn, "nvarchar")
        objDBParameters.AddParameter("@AddBy", AddBy, "nvarchar")






        'objDatabaseManager.ExecuteNonQuery("GL_Code_Save", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

    End Sub

    Public Sub EditFinTypeCode()

        objConnection = cConnectionManager.GetConnection()
        Dim objDatabaseManager As IDatabaseManager
        Dim objDBParameters As New cDBParameterList
        objDatabaseManager = cDataBaseManager.GetDatabaseManager()
        objDatabaseManager.SetConnection(objConnection)



        objDBParameters.AddParameter("@ScripCode", ScripCode, "char")

        objDBParameters.AddParameter("@ScripName", ScripName, "varchar")
        objDBParameters.AddParameter("@Description", Description, "varchar")

        objDBParameters.AddParameter("@SecCode", SecCode, "char")
        objDBParameters.AddParameter("@SecurityCode", SecurityCode, "char")
        objDBParameters.AddParameter("@CompCode", CompCode, "char")
        objDBParameters.AddParameter("@GOCCode", GOCCode, "char")
        objDBParameters.AddParameter("@Symbol", Symbol, "varchar")

        objDBParameters.AddParameter("@FaceVal", FaceVal, "double")
        objDBParameters.AddParameter("@PaidUpCap", PaidUpCap, "double")


        objDBParameters.AddParameter("@AuthCap", AuthCap, "double")
        objDBParameters.AddParameter("@DelistDate", DelistDate, "varchar")
        objDBParameters.AddParameter("@GOC", GOC, "char")
        objDBParameters.AddParameter("@FutureTrade", FutureTrade, "char")

        objDBParameters.AddParameter("@CDCELIG", CDCELIG, "char")
        objDBParameters.AddParameter("@LisStkExch", LisStkExch, "char")
        objDBParameters.AddParameter("@DD", DD, "char")


        objDBParameters.AddParameter("@EditOn", EditOn, "nvarchar")
        objDBParameters.AddParameter("@EditBy", EditBy, "nvarchar")

        'objDatabaseManager.ExecuteNonQuery("GL_Code_Edit", objDBParameters)
        cConnectionManager.CloseConnection(objConnection)

    End Sub
End Class
