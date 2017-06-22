Public Class Importer
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedItem = "ami 1" Then
            ListBox2.Items.Clear()
            ListBox2.Items.Add("Liste repas de famille")
            ListBox2.Items.Add("gouter en cours")
        End If

        If ListBox1.SelectedItem = "ami 2" Then
            ListBox2.Items.Clear()
            ListBox2.Items.Add("Liste repas de famille")
            ListBox2.Items.Add("gouter en cours")
        End If

        If ListBox1.SelectedItem = "ami 3" Then
            ListBox2.Items.Clear()
            ListBox2.Items.Add("Liste repas de famille")
            ListBox2.Items.Add("gouter en cours")
        End If

        If ListBox1.SelectedItem = "ami 4" Then
            ListBox2.Items.Clear()
            ListBox2.Items.Add("Liste repas de famille")
            ListBox2.Items.Add("gouter en cours")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.ListProduit.Items.Add(ListBox2.SelectedItem)
    End Sub
End Class