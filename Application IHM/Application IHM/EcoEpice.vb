﻿Public Class EcoEpice

    Private Sub BtnRetour_Click(sender As Object, e As EventArgs) Handles BtnRetour.Click
            Me.Dispose()
        End Sub

        Private Sub ChoisirEpice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub

        Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
            Dim priceEpices As New Integer

            If CheckBox1.Checked = True Then
                FormVoirListe.LstBoxProduit.Items.Add(Button2.Text)

                priceEpices += (Convert.ToInt16(LblPrixCannelle.Text) * Convert.ToInt16(ComboBox1.SelectedItem))

                Label3.Text = priceEpices.ToString
                NouvelleListe.calcl(priceEpices)
            End If

            If CheckBox2.Checked = True Then
                FormVoirListe.LstBoxProduit.Items.Add(Button3.Text)

                priceEpices += (Convert.ToInt16(LblPrixPoivreB.Text) * Convert.ToInt16(ComboBox2.SelectedItem))
                Label3.Text = priceEpices.ToString
                NouvelleListe.calcl(priceEpices)
            End If

            If CheckBox3.Checked = True Then
                FormVoirListe.LstBoxProduit.Items.Add(Button3.Text)

                priceEpices += (Convert.ToInt16(LblPrixPoivreN.Text) * Convert.ToInt16(ComboBox3.SelectedItem))
                Label3.Text = priceEpices.ToString
                NouvelleListe.calcl(priceEpices)
            End If


    End Sub

        Private Sub LblPrixCordon_Click(sender As Object, e As EventArgs) Handles LblPrixPoivreB.Click

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


End Class