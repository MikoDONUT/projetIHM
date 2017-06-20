Public Class ChoisirAutre
    Private Sub BtnRetour_Click(sender As Object, e As EventArgs) Handles BtnRetour.Click
        Me.Dispose()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim priceAutre As New Integer

        If CheckBox1.Checked = True Then
            FormVoirListe.ListBox1.Items.Add(Button2.Text)

            priceAutre += (Convert.ToInt16(LblPrixGob.Text) * Convert.ToInt16(ComboBox1.SelectedItem))

            Label3.Text = priceAutre.ToString
            NouvelleListe.calcl(priceAutre)
        End If

        If CheckBox2.Checked = True Then
            FormVoirListe.ListBox1.Items.Add(Button3.Text)

            priceAutre += (Convert.ToInt16(LblPrixPoussette.Text) * Convert.ToInt16(ComboBox2.SelectedItem))
            Label3.Text = priceAutre.ToString
            NouvelleListe.calcl(priceAutre)
        End If

        If CheckBox3.Checked = True Then
            FormVoirListe.ListBox1.Items.Add(Button3.Text)

            priceAutre += (Convert.ToInt16(LblPrixPorteClef.Text) * Convert.ToInt16(ComboBox3.SelectedItem))
            Label3.Text = priceAutre.ToString
            NouvelleListe.calcl(priceAutre)
        End If

        If CheckBox4.Checked = True Then
            FormVoirListe.ListBox1.Items.Add(Button5.Text)

            priceAutre += (Convert.ToInt16(LblPrixgum.Text) * Convert.ToInt16(ComboBox4.SelectedItem))
            Label3.Text = priceAutre.ToString
            NouvelleListe.calcl(priceAutre)
        End If


    End Sub

End Class