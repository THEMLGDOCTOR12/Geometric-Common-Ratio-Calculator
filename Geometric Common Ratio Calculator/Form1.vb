Public Class Form1
    Dim CmbBox As String
    Dim Percent As Double
    Dim Answer As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CmbBox = ComboBox1.Text
        Percent = TextBox1.Text
        If CmbBox = "Rise" Then
            Answer = 1 + Percent / 100
        End If
        If CmbBox = "Fall" Then
            Answer = 1 - Percent / 100
        End If
        Label1.Text = Answer
    End Sub
End Class
