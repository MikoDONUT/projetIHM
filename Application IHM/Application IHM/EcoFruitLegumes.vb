Public Class EcoFruitLegumes

    Private Sub BtnRetour_Click(sender As Object, e As EventArgs) Handles BtnRetour.Click
            Me.Dispose()
        End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim priceFruit As New Integer

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
    End Sub

    Private Sub EcoFruitLegumes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class