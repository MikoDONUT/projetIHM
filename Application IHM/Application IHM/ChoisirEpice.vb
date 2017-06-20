Public Class ChoisirEpice
    Private Sub BtnRetour_Click(sender As Object, e As EventArgs) Handles BtnRetour.Click
        Me.Dispose()
    End Sub

    Private Sub ChoisirEpice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim priceEpices As New Integer

        If CheckBox1.Checked = True Then
            FormVoirListe.ListBox1.Items.Add(Button2.Text)

            priceEpices += (Convert.ToInt16(LblPrixCannelle.Text) * Convert.ToInt16(ComboBox1.SelectedItem))

            Label3.Text = priceEpices.ToString
            NouvelleListe.calcl(priceEpices)
        End If

        If CheckBox2.Checked = True Then
            FormVoirListe.ListBox1.Items.Add(Button3.Text)

            priceEpices += (Convert.ToInt16(LblPrixPoivreB.Text) * Convert.ToInt16(ComboBox2.SelectedItem))
            Label3.Text = priceEpices.ToString
            NouvelleListe.calcl(priceEpices)
        End If

        If CheckBox3.Checked = True Then
            FormVoirListe.ListBox1.Items.Add(Button3.Text)

            priceEpices += (Convert.ToInt16(LblPrixPoivreN.Text) * Convert.ToInt16(ComboBox3.SelectedItem))
            Label3.Text = priceEpices.ToString
            NouvelleListe.calcl(priceEpices)
        End If

        If CheckBox4.Checked = True Then
            FormVoirListe.ListBox1.Items.Add(Button5.Text)

            priceEpices += (Convert.ToInt16(LblPrixOrigan.Text) * Convert.ToInt16(ComboBox4.SelectedItem))
            Label3.Text = priceEpices.ToString
            NouvelleListe.calcl(priceEpices)
        End If


    End Sub

    Private Sub LblPrixCordon_Click(sender As Object, e As EventArgs) Handles LblPrixPoivreB.Click

    End Sub
End Class