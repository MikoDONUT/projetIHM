Public Class ChoisirFruitEtLegumes
    Private Sub BtnRetour_Click(sender As Object, e As EventArgs) Handles BtnRetour.Click
        Me.Dispose()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim priceFruit As New Integer

        'Verifie si la checkBox est checker
        If CheckBox1.Checked = True Then
            'Ajoute le produit a la liste de produit correspondant a la liste 
            FormVoirListe.LstBoxProduit.Items.Add(Button1.Text)
            FormVoirListe.LstQuant.Items.Add(ComboBox1.SelectedItem.ToString)

            'Convertis les label (prix) et (combot box) en entier et les multiplie entre eux
            priceFruit += (Convert.ToInt16(LblPrixCarrote.Text) * Convert.ToInt16(ComboBox1.SelectedItem))

            'initialise le label total de la form viande au price total
            Label3.Text = priceFruit.ToString

            'Appel la procedure qui permet de calculer le prix total
            NouvelleListe.calcl(priceFruit)
        End If

        If CheckBox2.Checked = True Then
            FormVoirListe.LstBoxProduit.Items.Add(Button3.Text)
            FormVoirListe.LstQuant.Items.Add(ComboBox2.SelectedItem.ToString)

            priceFruit += (Convert.ToInt16(LblPrixPeche.Text) * Convert.ToInt16(ComboBox2.SelectedItem))
            Label3.Text = priceFruit.ToString
            NouvelleListe.calcl(priceFruit)
        End If

        If CheckBox3.Checked = True Then
            FormVoirListe.LstBoxProduit.Items.Add(Button3.Text)
            FormVoirListe.LstQuant.Items.Add(ComboBox3.SelectedItem.ToString)

            priceFruit += (Convert.ToInt16(LblPrixOrange.Text) * Convert.ToInt16(ComboBox3.SelectedItem))
            Label3.Text = priceFruit.ToString
            NouvelleListe.calcl(priceFruit)
        End If

        If CheckBox4.Checked = True Then
            FormVoirListe.LstBoxProduit.Items.Add(Button5.Text)
            FormVoirListe.LstQuant.Items.Add(ComboBox4.SelectedItem.ToString)

            priceFruit += (Convert.ToInt16(LblPrixCourgette.Text) * Convert.ToInt16(ComboBox4.SelectedItem))
            Label3.Text = priceFruit.ToString
            NouvelleListe.calcl(priceFruit)
        End If


    End Sub
End Class