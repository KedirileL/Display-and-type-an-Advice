Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Title As String
        Dim Advice1 As String
        Dim Advice2 As String
        Dim Advice3 As String

        Title = "Advice to Young People"
        Advice1 = txtAdvice1.Text
        Advice2 = txtAdvice2.Text
        Advice3 = txtAdvice3.Text

        MsgBox(Title & vbCrLf & vbCrLf & "1) " & Advice1 & vbNewLine &
               "2) " & Advice2 & vbCrLf & "3)" & Advice3)



    End Sub

End Class
