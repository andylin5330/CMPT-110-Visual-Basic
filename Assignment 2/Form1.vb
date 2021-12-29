Public Class Form1
    Dim Count As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Count += 1
        If Count > "9" Then
            digit_input.Text = Count Mod 10
        Else
            digit_input.Text = Count
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If integer_output.Text = "0" Then
            integer_output.Text = digit_input.Text
        Else
            integer_output.Text += digit_input.Text
        End If
        digit_input.Text = "0"
        Count = 0
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class

