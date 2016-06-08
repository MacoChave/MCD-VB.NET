Public Class Form1

    Private Sub btnMCD_Click(sender As Object, e As EventArgs) Handles btnMCD.Click

        Dim a As Integer = txtA.Text
        Dim b As Integer = txtB.Text

        Dim MCD As Integer = getMCD(a, b)
        txtMCD.Text = "MCD(" & a & "," & b & "): " & MCD

        txtA.Text = ""
        txtB.Text = ""

    End Sub

    Private Function getMCD(a As Integer, b As Integer) As Integer
        Dim r As Integer = a Mod b

        If r = 0 Then
            Return b
        Else
            Return getMCD(b, r)
        End If

    End Function

    Private Sub btnmcm_Click(sender As Object, e As EventArgs) Handles btnmcm.Click
        Dim a As Integer = txtA.Text
        Dim b As Integer = txtB.Text
        Dim MCD As Integer = getMCD(a, b)

        Dim mcm As Integer = (a * b) / MCD

        txtMCD.Text = "mcm(" & a & "," & b & "): " & mcm

        txtA.Text = ""
        txtB.Text = ""

    End Sub
End Class
