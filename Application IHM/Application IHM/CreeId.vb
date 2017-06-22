Public Class CreeId
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Verification si les champs sont remplis
        If TextBoxPseudo.Text = "" Or TextBoxMdp.Text = "" Or BoxNom.Text = "" Or BoxPrenom.Text = "" Or BoxAge.Text = "" Then
            MsgBox("Veuillez rentrer tout les champs")
        Else
            'Proposer a l'utilisateur de se connecter
            ValidationCreerCompte.LblPseudo.Text = TextBoxPseudo.Text
            ValidationCreerCompte.Show()
            Me.Dispose()
        End If

    End Sub

    Private Sub BoxNom_TextChanged(sender As Object, e As EventArgs) Handles BoxNom.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'boutton retour
        Me.Dispose()
    End Sub

End Class