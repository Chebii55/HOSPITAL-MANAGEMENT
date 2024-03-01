Public Class Form6
    Private Sub Btnexit_Click(sender As Object, e As EventArgs) Handles Btnexit.Click
        Me.Close()
    End Sub

    Private Sub BtnEnter_Click(sender As Object, e As EventArgs) Handles BtnEnter.Click
        Dim str(5) As String
        Dim itm As ListViewItem
        Dim dp As Date = DateTimePicker1.Value
        Dim dp2 As Date = DateTimePicker2.Value

        str(0) = txtpatientid.Text
        str(1) = txtnameoftablet.Text
        str(2) = txtadministration.Text
        str(3) = dp
        str(4) = dp2

        itm = New ListViewItem(str)
        ListView1.Items.Add(itm)
    End Sub
End Class