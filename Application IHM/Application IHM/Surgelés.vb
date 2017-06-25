Public Class ChoisirSurgelés

    Private Sub BtnRetour_Click(sender As Object, e As EventArgs)
        Me.Dispose()

    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim priceSurg As New Integer

        If CheckBox1.Checked = True Then
            FormVoirListe.LstBoxProduit.Items.Add(Button2.Text)
            FormVoirListe.LstQuant.Items.Add(ComboBox1.SelectedItem.ToString)

            priceSurg += (Convert.ToInt16(LblPrixGlace.Text) * Convert.ToInt16(ComboBox1.SelectedItem))

            Label3.Text = priceSurg.ToString
            NouvelleListe.calcl(priceSurg)
        End If

        If CheckBox2.Checked = True Then
            FormVoirListe.LstBoxProduit.Items.Add(Button3.Text)
            FormVoirListe.LstQuant.Items.Add(ComboBox2.SelectedItem.ToString)

            priceSurg += (Convert.ToInt16(LblPrixCordon.Text) * Convert.ToInt16(ComboBox2.SelectedItem))
            Label3.Text = priceSurg.ToString
            NouvelleListe.calcl(priceSurg)
        End If

        If CheckBox3.Checked = True Then
            FormVoirListe.LstBoxProduit.Items.Add(Button3.Text)
            FormVoirListe.LstQuant.Items.Add(ComboBox3.SelectedItem.ToString)

            priceSurg += (Convert.ToInt16(LblPrixOignon.Text) * Convert.ToInt16(ComboBox3.SelectedItem))
            Label3.Text = priceSurg.ToString
            NouvelleListe.calcl(priceSurg)
        End If

        If CheckBox4.Checked = True Then
            FormVoirListe.LstBoxProduit.Items.Add(Button5.Text)
            FormVoirListe.LstQuant.Items.Add(ComboBox4.SelectedItem.ToString)

            priceSurg += (Convert.ToInt16(LblPrixFraise.Text) * Convert.ToInt16(ComboBox4.SelectedItem))
            Label3.Text = priceSurg.ToString
            NouvelleListe.calcl(priceSurg)
        End If
    End Sub

    Private Sub BtnRetour_Click_1(sender As Object, e As EventArgs) Handles BtnRetour.Click
        Me.Dispose()
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ListBox4.Visible = True Then
            ListBox4.Visible = False
        Else
            ListBox4.Visible = True
        End If
    End Sub


End Class