Imports System.Data
Imports System.Data.SqlClient
Imports Basic.DAL
Imports Basic.DAL.Utils
Imports Basic.Constants.ProjConst


Public Class frmExportTB
    Inherits System.Windows.Forms.Form

    Dim objTBall As New cTrialBal

    Dim PODS As New DataSet
    Dim DtAcc As New DataTable
    Dim DaAcc As SqlDataAdapter
    Dim StrFromDate As String
    Dim objRow As Data.DataRow
    Dim tableName As String = "TBall"
    Dim dtTBall As New DataTable
    Dim dtBranch As New DataTable
    Dim dtCode As DataTable
    Dim Tbal As Double
    Dim Tdesc As String
    Dim rowNum As Integer
    Dim rowNum1 As Integer

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub FillGrid()

        Dim TmpStr As Object
        Dim mi As Integer
        Dim BrField As String
        Dim TbrCode As String
        Dim Tbal As Double
        Dim mBrCol As Integer
        Dim mBrRow As Integer
        Dim TotBalance As Double
        Dim TCode As String
        Dim TStr As String

        mi = 1
        fpSpread1.MaxRows = 1

        dtBranch = objTBall.LoadBranch()
        rowNum = dtBranch.Rows.Count

        If rowNum > 0 Then
            rowNum = 0
            fpSpread1.MaxCols = dtBranch.Rows.Count + 2
            fpSpread1.SetText(fpSpread1.MaxCols, 0, "Total")
            Do While rowNum < dtBranch.Rows.Count
                mi = mi + 1
                TmpStr = Trim(dtBranch.Rows(rowNum).Item("BrName").ToString)
                fpSpread1.SetText(mi, 0, TmpStr)
                rowNum = rowNum + 1
            Loop
        End If

        dtTBall = objTBall.GetAllTBal()
        rowNum1 = dtTBall.Rows.Count

        mBrRow = 1
        If rowNum1 > 0 Then
            rowNum1 = 0
            Do While rowNum1 < dtTBall.Rows.Count
                TotBalance = 0
                TCode = dtTBall.Rows(rowNum1).Item("Code").ToString
                Tdesc = dtTBall.Rows(rowNum1).Item("Description").ToString
                TStr = Trim(aStr2Code(TCode)) + "   " + Trim(Tdesc)
                fpSpread1.SetText(1, mBrRow, TStr)
                mBrCol = 1
                rowNum = 0
                Do While rowNum < dtBranch.Rows.Count
                    mBrCol = mBrCol + 1
                    TbrCode = dtBranch.Rows(rowNum).Item("BRCODE").ToString
                    BrField = "BRANCH" & TbrCode & ""
                    Tbal = dtTBall.Rows(rowNum1).Item(BrField).ToString
                    If Tbal > 0 Then
                        fpSpread1.SetText(mBrCol, mBrRow, Format(Tbal, NumFmt))
                    ElseIf Tbal < 0 Then
                        fpSpread1.SetText(mBrCol, mBrRow, Format(0 - Tbal, NumFmt1))
                    End If
                    TotBalance = TotBalance + Tbal
                    rowNum = rowNum + 1
                Loop
                If TotBalance > 0 Then
                    fpSpread1.SetText(fpSpread1.MaxCols, mBrRow, Format(TotBalance, NumFmt))
                ElseIf TotBalance < 0 Then
                    fpSpread1.SetText(fpSpread1.MaxCols, mBrRow, Format(0 - TotBalance, NumFmt1))
                End If
                mBrRow = mBrRow + 1
                rowNum1 = rowNum1 + 1
                fpSpread1.MaxRows = fpSpread1.MaxRows + 1
            Loop
        End If
    End Sub

    Private Sub frmExportTB_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call FillGrid()
    End Sub
End Class