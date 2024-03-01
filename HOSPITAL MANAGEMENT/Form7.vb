Public Class Form7
    Private Sub Btnexit_Click(sender As Object, e As EventArgs) Handles Btnexit.Click
        Me.Close()
    End Sub

    Private Sub BtnEnter_Click(sender As Object, e As EventArgs) Handles BtnEnter.Click
        Dim str(5) As String
        Dim itm As ListViewItem

        str(0) = txtpatientname.Text
        str(1) = txtphoneno.Text
        str(2) = txtpayment.Text
        str(3) = txtamount.Text
        str(4) = txtbalance.Text

        itm = New ListViewItem(str)
        ListView1.Items.Add(itm)
    End Sub
End Class