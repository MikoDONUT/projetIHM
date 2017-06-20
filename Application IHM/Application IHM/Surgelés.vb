Public Class ChoisirSurgelés
    Private Sub Surgelés_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnRetour_Click(sender As Object, e As EventArgs)
        Me.Dispose()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim priceSurg As New Integer

        If CheckBox1.Checked = True Then
            FormVoirListe.ListBox1.Items.Add(Button2.Text)

            priceSurg += (Convert.ToInt16(LblPrixGlace.Text) * Convert.ToInt16(ComboBox1.SelectedItem))

            Label3.Text = priceSurg.ToString
            NouvelleListe.calcl(priceSurg)
        End If

        If CheckBox2.Checked = True Then
            FormVoirListe.ListBox1.Items.Add(Button3.Text)

            priceSurg += (Convert.ToInt16(LblPrixCordon.Text) * Convert.ToInt16(ComboBox2.SelectedItem))
            Label3.Text = priceSurg.ToString
            NouvelleListe.calcl(priceSurg)
        End If

        If CheckBox3.Checked = True Then
            FormVoirListe.ListBox1.Items.Add(Button3.Text)

            priceSurg += (Convert.ToInt16(LblPrixOignon.Text) * Convert.ToInt16(ComboBox3.SelectedItem))
            Label3.Text = priceSurg.ToString
            NouvelleListe.calcl(priceSurg)
        End If

        If CheckBox4.Checked = True Then
            FormVoirListe.ListBox1.Items.Add(Button5.Text)

            priceSurg += (Convert.ToInt16(LblPrixFraise.Text) * Convert.ToInt16(ComboBox4.SelectedItem))
            Label3.Text = priceSurg.ToString
            NouvelleListe.calcl(priceSurg)
        End If



    End Sub

    Private Sub BtnRetour_Click_1(sender As Object, e As EventArgs) Handles BtnRetour.Click
        Me.Dispose()
    End Sub
End Class