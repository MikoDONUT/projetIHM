Public Class ChoisirViande
    Private Sub BtnRetour_Click(sender As Object, e As EventArgs) Handles BtnRetour.Click
        Me.Dispose()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim priceViande As New Integer

        'Verifie si la checkBox est checker
        If CheckBox1.Checked = True Then
            'Ajoute le produit a la liste de produit correspondant a la liste 
            FormVoirListe.LstBoxProduit.Items.Add(Button2.Text)
            FormVoirListe.LstQuant.Items.Add(ComboBox1.SelectedItem.ToString)

            'Convertis les label (prix) et (combot box) en entier et les multiplie entre eux
            priceViande += (Convert.ToInt16(LblPrixAgneaux.Text) * Convert.ToInt16(ComboBox1.SelectedItem))

            'initialise le label total de la form viande au price total
            Label3.Text = priceViande.ToString

            'Appel la procedure qui permet de calculer le prix total
            NouvelleListe.calcl(priceViande)
        End If

        If CheckBox2.Checked = True Then
            FormVoirListe.LstBoxProduit.Items.Add(Button3.Text)
            FormVoirListe.LstQuant.Items.Add(ComboBox2.SelectedItem.ToString)

            priceViande += (Convert.ToInt16(LblPrixAli.Text) * Convert.ToInt16(ComboBox2.SelectedItem))
            Label3.Text = priceViande.ToString
            NouvelleListe.calcl(priceViande)
        End If

        If CheckBox5.Checked = True Then
            FormVoirListe.LstBoxProduit.Items.Add(Button3.Text)
            FormVoirListe.LstQuant.Items.Add(ComboBox5.SelectedItem.ToString)

            priceViande += (Convert.ToInt16(LblPrixCochon.Text) * Convert.ToInt16(ComboBox5.SelectedItem))
            Label3.Text = priceViande.ToString
            NouvelleListe.calcl(priceViande)
        End If

        If CheckBox5.Checked = True Then
            FormVoirListe.LstBoxProduit.Items.Add(Button5.Text)
            FormVoirListe.LstQuant.Items.Add(ComboBox6.SelectedItem.ToString)


            priceViande += (Convert.ToInt16(LblPrixLapin.Text) * Convert.ToInt16(ComboBox6.SelectedItem))
            Label3.Text = priceViande.ToString
            NouvelleListe.calcl(priceViande)
        End If

        NouvelleListe.Label3.Text = priceViande.ToString


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.Visible = True Then
            ListBox1.Visible = False
        Else
            ListBox1.Visible = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListBox2.Visible = True Then
            ListBox2.Visible = False
        Else
            ListBox2.Visible = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ListBox3.Visible = True Then
            ListBox3.Visible = False
        Else
            ListBox3.Visible = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If ListBox4.Visible = True Then
            ListBox4.Visible = False
        Else
            ListBox4.Visible = True
        End If
    End Sub

End Class