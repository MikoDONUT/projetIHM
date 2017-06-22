Public Class IdForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'boutton retour
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Si les text box ne sont pas remplis
        If PseudoBox.Text = "" Or mdpBox.Text = "" Then
            MsgBox("Erreur veuillez saisir les deux champs")

            'Si les text box sont correctement remplis
        Else
            MsgBox("Bienvenue " & PseudoBox.Text)

            'Changement du titre de la form de depart
            Form1.Label1.Text = "Mes listes"

            'Desactiver le boutton login de la form d'acceuil
            Form1.Button1.Enabled = False

            'Activer le boutton logout et nouvelle liste de la form d'acceuil
            Form1.Button2.Enabled = True
            Form1.BtnNew.Enabled = True

            'Administrie le pseudo au label de la form d'acceuil
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