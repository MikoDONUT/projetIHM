Public Class EcoChoisirAutre

    Private Sub BtnRetour_Click(sender As Object, e As EventArgs) Handles BtnRetour.Click
            Me.Dispose()
        End Sub

        Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

            Dim priceAutre As New Integer

            'Verifie si la checkBox est checker
            If CheckBox1.Checked = True Then

            FormVoirListe.LstQuant.Items.Add(ComboBox1.SelectedItem.ToString)

                'Convertis les label (prix) et (combot box) en entier et les multiplie entre eux
                priceAutre += (Convert.ToInt16(LblPrixGob.Text) * Convert.ToInt16(ComboBox1.SelectedItem))

                'initialise le label total de la form viande au price total
                Label3.Text = priceAutre.ToString

                'Appel la procedure qui permet de calculer le prix total
                NouvelleListe.calcl(priceAutre)
            End If


        If CheckBox3.Checked = True Then
                FormVoirListe.LstBoxProduit.Items.Add(Button3.Text)
                FormVoirListe.LstQuant.Items.Add(ComboBox3.SelectedItem.ToString)

                priceAutre += (Convert.ToInt16(LblPrixPorteClef.Text) * Convert.ToInt16(ComboBox3.SelectedItem))
                Label3.Text = priceAutre.ToString
                NouvelleListe.calcl(priceAutre)
            End If



    End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            If ListBox1.Visible = True Then
                ListBox1.Visible = False
            Else
                ListBox1.Visible = True
            End If
        End Sub




End Class