Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As Double
        Dim y As Double
        Dim r As Double
        x = Val(TextBox1.Text)
        y = Val(TextBox2.Text)
        r = (x ^ 2 + y ^ 2) ^ 0.5
        TextBox3.Text = r
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Double
        Dim y As Double
        Dim r As Double
        x = Val(TextBox1.Text)
        y = Val(TextBox2.Text)
        r = (x ^ 2 + y ^ 2) ^ 0.5
        TextBox3.Text = r.ToString("F2")
    End Sub
End Class
