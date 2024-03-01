Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form1


    Private Sub Btnlogin_Click(sender As Object, e As EventArgs) Handles Btnlogin.Click
        If txtusername.Text = "admin" And txtpassword.Text = "admin" Then
            MsgBox("Log in Successful!!!", MsgBoxStyle.OkOnly, "Log in Form")
            Form2.Show()
            Me.Hide()



        Else
            MsgBox("Sorry Incorrect Password or Username. Try Again!")

        End If
    End Sub

    Private Sub Btnexit_Click(sender As Object, e As EventArgs) Handles Btnexit.Click
        Me.Close()
    End Sub
End Class
