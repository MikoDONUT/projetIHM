Public Class EcoChoisirViande
    Private Sub BtnRetour_Click(sender As Object, e As EventArgs) Handles BtnRetour.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim priceViande As New Integer

        If CheckBox1.Checked = True Then
            FormVoirListe.LstBoxProduit.Items.Add(Button2.Text)

            priceViande += (Convert.ToInt16(LblPrixAgneaux.Text) * Convert.ToInt16(ComboBox1.SelectedItem))

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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ListBox3.Visible = True Then
            ListBox3.Visible = False
        Else
            ListBox3.Visible = True
        End If
    End Sub
End Class