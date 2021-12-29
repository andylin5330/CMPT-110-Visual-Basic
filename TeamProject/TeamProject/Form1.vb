Public Class Form1
    Dim goal As Integer
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i As Integer = 0
        Dim a As String = CStr(TextBox3.Text)
        Dim space As Integer = 0
        Dim wordcount As Integer = 0
        goal = CInt(TextBox1.Text)
        For i = 0 To Len(a) - 1
            If i = Len(a) - 1 Then
                wordcount += 1
            End If
            If a(i) = " " Then
                space = space + 1
                wordcount = wordcount + 1
            End If
        Next
        TextBox2.Text = wordcount
        If goal < wordcount Then
            Form2.Show()
        Else
            Form3.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim input1 As String = CStr(TextBox4.Text)
        Dim filereader As String
        filereader = My.Computer.FileSystem.ReadAllText(input1)
        Dim i As Integer = 0
        Dim a As String = filereader
        Dim space As Integer = 0
        Dim wordcount As Integer = 0
        For i = 0 To Len(a) - 1
            If i = Len(a) - 1 Then
                wordcount += 1
            End If
            If a(i) = " " Then
                space = space + 1
                wordcount = wordcount + 1
            End If
        Next
        goal = CInt(TextBox1.Text)
        TextBox2.Text = wordcount
        If goal < wordcount Then
            Form2.Show()
        Else
            Form3.Show()
        End If
    End Sub
End Class
