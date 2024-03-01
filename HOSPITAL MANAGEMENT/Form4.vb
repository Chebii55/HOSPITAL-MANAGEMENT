Public Class Form4
    Private Sub Btnexit_Click(sender As Object, e As EventArgs) Handles Btnexit.Click
        Me.Close()
    End Sub

    Private Sub BtnEnter_Click(sender As Object, e As EventArgs) Handles BtnEnter.Click
        Dim str(4) As String
        Dim itm As ListViewItem

        str(0) = txtappointmentref.Text
        str(1) = txtpatientsnumber.Text
        str(2) = txtappointmentno.Text
        str(3) = txtdoctorsname.Text


        itm = New ListViewItem(str)
        ListView1.Items.Add(itm)
    End Sub
End Class