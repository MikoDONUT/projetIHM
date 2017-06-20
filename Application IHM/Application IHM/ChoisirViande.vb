Public Class ChoisirViande
    Private Sub BtnRetour_Click(sender As Object, e As EventArgs) Handles BtnRetour.Click
        Me.Dispose()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles LblPrixAli.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim priceViande As New Integer

        If CheckBox1.Checked = True Then
            FormVoirListe.LstBoxProduit.Items.Add(Button2.Text)

            priceViande += (Convert.ToInt16(LblPrixAgneaux.Text) * Convert.ToInt16(ComboBox1.SelectedItem))

            Label3.Text = priceViande.ToString
            NouvelleListe.calcl(priceViande)
        End If

        If CheckBox2.Checked = True Then
            FormVoirListe.LstBoxProduit.Items.Add(Button3.Text)

            priceViande += (Convert.ToInt16(LblPrixAli.Text) * Convert.ToInt16(ComboBox2.SelectedItem))
            Label3.Text = priceViande.ToString
            NouvelleListe.calcl(priceViande)
        End If

        If CheckBox5.Checked = True Then
            FormVoirListe.LstBoxProduit.Items.Add(Button3.Text)

            priceViande += (Convert.ToInt16(LblPrixCochon.Text) * Convert.ToInt16(ComboBox5.SelectedItem))
            Label3.Text = priceViande.ToString
            NouvelleListe.calcl(priceViande)
        End If

        If CheckBox5.Checked = True Then
            FormVoirListe.LstBoxProduit.Items.Add(Button5.Text)

            priceViande += (Convert.ToInt16(LblPrixLapin.Text) * Convert.ToInt16(ComboBox6.SelectedItem))
            Label3.Text = priceViande.ToString
            NouvelleListe.calcl(priceViande)
        End If

        NouvelleListe.Label3.Text = priceViande.ToString


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub LblNomAgneau_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub LblPrixAgneaux_Click(sender As Object, e As EventArgs) Handles LblPrixAgneaux.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.Visible = True Then
            ListBox1.Visible = False
        Else
            ListBox1.Visible = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListBox2.Visible = True Then
            ListBox2.Visible = False
        Else
            ListBox2.Visible = True
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged

    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles LblPrixCochon.Click

    End Sub

    Private Sub ChoisirViande_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ListBox3.Visible = True Then
            ListBox3.Visible = False
        Else
            ListBox3.Visible = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If ListBox4.Visible = True Then
            ListBox4.Visible = False
        Else
            ListBox4.Visible = True
        End If
    End Sub
End Class