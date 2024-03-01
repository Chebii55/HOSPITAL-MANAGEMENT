Imports System.DirectoryServices.ActiveDirectory
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form8
    Private Sub Btnexit_Click(sender As Object, e As EventArgs) Handles Btnexit.Click
        Me.Close()
    End Sub

    Private Sub BtnEnter_Click(sender As Object, e As EventArgs) Handles BtnEnter.Click
        Dim str(5) As String
        Dim itm As ListViewItem
        Dim gen As String
        If rdmale.Checked = True Then
            gen = "Male"


        ElseIf rdfemale.Checked = True Then
            gen = "Female"

        Else
            gen = "Transgender"

        End If
        str(0) = txtwardname.Text
        str(1) = txtcapacity.Text
        str(2) = gen
        str(3) = txtailment.Text
        str(4) = txtpatienid.Text

        itm = New ListViewItem(str)
        ListView1.Items.Add(itm)
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class