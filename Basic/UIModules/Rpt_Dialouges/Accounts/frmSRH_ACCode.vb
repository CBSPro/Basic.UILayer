Imports System.Data
Imports System.Data.SqlClient
Imports Basic.DAL.Utils
Imports Basic.Constants.ProjConst

Public Class frmSRH_ACCode
    Inherits System.Windows.Forms.Form

    Public SetFilter As Boolean

    Private Sub frmSRH_ACCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rdbAll.Checked = True
        rdbFirst.Checked = False
        rdbSecond.Checked = False
        rdbThird.Checked = False
    End Sub

    Private Sub btnOk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOk.Click
        SetFilter = True
        If rdbAll.Checked = True Then
            FltAll = True
        Else
            FltAll = False
        End If
        If rdbFirst.Checked = True Then
            FltFirst = True
        Else
            FltFirst = False
        End If
        If rdbSecond.Checked = True Then
            FltSecond = True
        Else
            FltSecond = False
        End If
        If rdbThird.Checked = True Then
            FltThird = True
        Else
            FltThird = False
        End If
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        SetFilter = False
        Me.Close()
    End Sub

    Private Sub rdbFirst_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbFirst.Click
        If rdbFirst.Checked = True Then
            rdbAll.Checked = False
            rdbSecond.Checked = False
            rdbThird.Checked = False
        End If
    End Sub

    Private Sub rdbSecond_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbSecond.Click
        If rdbSecond.Checked = True Then
            rdbAll.Checked = False
            rdbFirst.Checked = False
            rdbThird.Checked = False
        End If
    End Sub

    Private Sub rdbThird_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbThird.Click
        If rdbThird.Checked = True Then
            rdbAll.Checked = False
            rdbFirst.Checked = False
            rdbSecond.Checked = False
        End If
    End Sub

    Private Sub rdbAll_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbAll.Click
        If rdbAll.Checked = True Then
            rdbFirst.Checked = False
            rdbSecond.Checked = False
            rdbThird.Checked = False
        End If
    End Sub
End Class