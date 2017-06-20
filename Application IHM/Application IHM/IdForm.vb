Public Class IdForm
    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mdpBox.MaskInputRejected

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Si les text box ne sont pas remplis
        If PseudoBox.Text = "" Or mdpBox.Text = "" Then
            MsgBox("Erreur veuillez saisir les deux champs")

            'Si les text box sont correctement remplis
        Else
            MsgBox("Bienvenue " & PseudoBox.Text)
            Form1.LblPseudo.Text = PseudoBox.Text
            Me.Dispose()
            SeConnecter.Dispose()


            'Supprime tout les element de la list box
            Form1.ListProduit.Items.Clear()

            'Ajoute des element de l'inscrit
            Form1.ListProduit.Items.Add("Apperitif")
            Form1.ListProduit.Items.Add("Repas de famille")
            Form1.ListProduit.Items.Add("Soirees")
        End If
    End Sub
End Class