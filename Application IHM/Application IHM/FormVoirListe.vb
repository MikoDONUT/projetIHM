Public Class FormVoirListe
    Private Sub BtnRetour_Click(sender As Object, e As EventArgs) Handles BtnRetour.Click
        Me.Dispose()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstBoxProduit.SelectedIndexChanged
        If LstBoxProduit.SelectedItem = "" Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LstBoxProduit.Items.Remove(LstBoxProduit.SelectedItem)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LstBoxPartager.Items.Remove(LstBoxPartager.SelectedItem)
    End Sub
End Class