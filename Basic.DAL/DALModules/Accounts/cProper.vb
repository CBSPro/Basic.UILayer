Public Class cProper

    Public Function Proper(ByVal txtData As String) As String
        Dim Pos As Integer
        Dim Flag As Boolean
        For Pos = 0 To Len(txtData)
            If Mid(txtData, Pos + 1, 1) = " " Then
                Flag = True
            End If
            If Mid(txtData, Pos + 1, 1) <> " " Then
                If Pos = 0 Or Flag Then
                    txtData = Left(txtData, Pos) & Replace(txtData, Mid(txtData, Pos + 1, 1), UCase(Mid(txtData, Pos + 1, 1)), Pos + 1, 1)
                    Flag = False
                Else
                    txtData = Left(txtData, Pos) & Replace(txtData, Mid(txtData, Pos + 1, 1), LCase(Mid(txtData, Pos + 1, 1)), Pos + 1, 1)
                End If
            End If
        Next
        Proper = txtData
    End Function
End Class
