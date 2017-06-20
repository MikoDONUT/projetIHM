Public Class AvertissementSave
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NouvelleListe.btnSaveClicked = True
        Form1.ListProduit.Items.Add(NouvelleListe.BoxNewList.Text)
        MsgBox("Votre Liste a ete sauvegarder")
        Me.Close()
        NouvelleListe.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        NouvelleListe.btnSaveClicked = True 'Eviter une boucle infini
        Me.Close()
        NouvelleListe.Close()
    End Sub
End Class