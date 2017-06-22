Public Class EcoProduitDuMonde

    Private Sub BtnRetour_Click(sender As Object, e As EventArgs) Handles BtnRetour.Click
        Me.Dispose()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
            Dim priceProdMond As New Integer

            If CheckBox1.Checked = True Then
            FormVoirListe.LstBoxProduit.Items.Add(Button2.Text)
            FormVoirListe.LstQuant.Items.Add(ComboBox1.SelectedItem.ToString)

            priceProdMond += (Convert.ToInt16(LblPrixMms.Text) * Convert.ToInt16(ComboBox1.SelectedItem))

                Label3.Text = priceProdMond.ToString
                NouvelleListe.calcl(priceProdMond)
            End If

            If CheckBox2.Checked = True Then
            FormVoirListe.LstBoxProduit.Items.Add(Button3.Text)
            FormVoirListe.LstQuant.Items.Add(ComboBox2.SelectedItem.ToString)

            priceProdMond += (Convert.ToInt16(LblPrixBierre.Text) * Convert.ToInt16(ComboBox2.SelectedItem))
                Label3.Text = priceProdMond.ToString
                NouvelleListe.calcl(priceProdMond)
            End If

            If CheckBox3.Checked = True Then
            FormVoirListe.LstBoxProduit.Items.Add(Button3.Text)
            FormVoirListe.LstQuant.Items.Add(ComboBox3.SelectedItem.ToString)

            priceProdMond += (Convert.ToInt16(LblPrixGraine.Text) * Convert.ToInt16(ComboBox3.SelectedItem))
                Label3.Text = priceProdMond.ToString
                NouvelleListe.calcl(priceProdMond)
            End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            If ListBox1.Visible = True Then
                ListBox1.Visible = False
            Else
                ListBox1.Visible = True
            End If

        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
            If ListBox2.Visible = True Then
                ListBox2.Visible = False
            Else
                ListBox2.Visible = True
            End If

        End Sub

        Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListBox3.Visible = True Then
            ListBox3.Visible = False
        Else
            ListBox3.Visible = True
        End If
    End Sub

    Private Sub EcoProduitDuMonde_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class