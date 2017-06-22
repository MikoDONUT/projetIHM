Public Class ChoisirFruitEtLegumes
    Private Sub BtnRetour_Click(sender As Object, e As EventArgs) Handles BtnRetour.Click
        Me.Dispose()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim priceFruit As New Integer

        If CheckBox1.Checked = True Then
            FormVoirListe.LstBoxProduit.Items.Add(Button1.Text)

            priceFruit += (Convert.ToInt16(LblPrixCarrote.Text) * Convert.ToInt16(ComboBox1.SelectedItem))

            Label3.Text = priceFruit.ToString
            NouvelleListe.calcl(priceFruit)
        End If

        If CheckBox2.Checked = True Then
            FormVoirListe.LstBoxProduit.Items.Add(Button3.Text)

            priceFruit += (Convert.ToInt16(LblPrixPeche.Text) * Convert.ToInt16(ComboBox2.SelectedItem))
            Label3.Text = priceFruit.ToString
            NouvelleListe.calcl(priceFruit)
        End If

        If CheckBox3.Checked = True Then
            FormVoirListe.LstBoxProduit.Items.Add(Button3.Text)

            priceFruit += (Convert.ToInt16(LblPrixOrange.Text) * Convert.ToInt16(ComboBox3.SelectedItem))
            Label3.Text = priceFruit.ToString
            NouvelleListe.calcl(priceFruit)
        End If

        If CheckBox4.Checked = True Then
            FormVoirListe.LstBoxProduit.Items.Add(Button5.Text)

            priceFruit += (Convert.ToInt16(LblPrixCourgette.Text) * Convert.ToInt16(ComboBox4.SelectedItem))
            Label3.Text = priceFruit.ToString
            NouvelleListe.calcl(priceFruit)
        End If


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub LblPrixAgneaux_Click(sender As Object, e As EventArgs) Handles LblPrixCarrote.Click

    End Sub

    Private Sub ChoisirFruitEtLegumes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class