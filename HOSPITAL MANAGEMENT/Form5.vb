Public Class Form5
    Private Sub Btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub BtnEnter_Click(sender As Object, e As EventArgs) Handles BtnEnter.Click
        Dim str(5) As String
        Dim itm As ListViewItem

        str(0) = txtpatientname.Text
        str(1) = txtidno.Text
        str(2) = txtward.Text
        str(3) = txtpatientid.Text
        str(4) = txtappointmentno.Text

        itm = New ListViewItem(str)
        ListView1.Items.Add(itm)
    End Sub
End Class