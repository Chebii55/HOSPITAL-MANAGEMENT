Imports System.Net.Mail
Imports System.Text.RegularExpressions

Public Class Form3
    Private Sub Btnexit_Click(sender As Object, e As EventArgs) Handles Btnexit.Click
        Me.Close()
    End Sub

    Private Sub btnenter_Click(sender As Object, e As EventArgs) Handles BtnEnter.Click
        Dim str(6) As String
        Dim itm As ListViewItem
        Dim gen As String
        If rbmale.Checked = True Then
            gen = "Male"


        ElseIf rbfemale.Checked = True Then
            gen = "Female"

        Else
            gen = "Transgender"

        End If


        str(0) = txtname.Text
        str(1) = txtphoneno.Text
        str(2) = txtemail.Text
        str(3) = txtemployeeno.Text
        str(4) = cbrole.Text
        str(5) = gen
        itm = New ListViewItem(str)
        ListView1.Items.Add(itm)
    End Sub

    Private Sub cbrole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbrole.SelectedIndexChanged

    End Sub




End Class