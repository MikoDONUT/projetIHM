﻿Public Class ChoisirProduitDuMonde
    Private Sub BtnRetour_Click(sender As Object, e As EventArgs) Handles BtnRetour.Click
        Me.Dispose()

    End Sub

    Private Sub ChoisirProduitDuMonde_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim priceProdMond As New Integer

        If CheckBox1.Checked = True Then
            FormVoirListe.LstBoxProduit.Items.Add(Button2.Text)

            priceProdMond += (Convert.ToInt16(LblPrixMms.Text) * Convert.ToInt16(ComboBox1.SelectedItem))

            Label3.Text = priceProdMond.ToString
            NouvelleListe.calcl(priceProdMond)
        End If

        If CheckBox2.Checked = True Then
            FormVoirListe.LstBoxProduit.Items.Add(Button3.Text)

            priceProdMond += (Convert.ToInt16(LblPrixBierre.Text) * Convert.ToInt16(ComboBox2.SelectedItem))
            Label3.Text = priceProdMond.ToString
            NouvelleListe.calcl(priceProdMond)
        End If

        If CheckBox3.Checked = True Then
            FormVoirListe.LstBoxProduit.Items.Add(Button3.Text)

            priceProdMond += (Convert.ToInt16(LblPrixGraine.Text) * Convert.ToInt16(ComboBox3.SelectedItem))
            Label3.Text = priceProdMond.ToString
            NouvelleListe.calcl(priceProdMond)
        End If

        If CheckBox4.Checked = True Then
            FormVoirListe.LstBoxProduit.Items.Add(Button5.Text)

            priceProdMond += (Convert.ToInt16(LblPrixgateaux.Text) * Convert.ToInt16(ComboBox4.SelectedItem))
            Label3.Text = priceProdMond.ToString
            NouvelleListe.calcl(priceProdMond)
        End If


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

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