Public Class ChoisirViande
    Private Sub BtnRetour_Click(sender As Object, e As EventArgs) Handles BtnRetour.Click
        Me.Dispose()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles LblPrixAli.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            FormVoirListe.ListBox1.Items.Add(LblNomAgneau.Text)
            Dim price As Integer
            price = (Convert.ToInt16(LblPrixAgneaux.Text) * Convert.ToInt16(ComboBox1.SelectedItem))
            Label3.Text = price.ToString
        End If

        If CheckBox2.Checked = True Then
            FormVoirListe.ListBox1.Items.Add(Label6.Text)
            Dim priceAli As Integer
            priceAli = (Convert.ToInt16(LblPrixAli.Text) * Convert.ToInt16(ComboBox2.SelectedItem))
            Label3.Text = priceAli.ToString
        End If



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
End Class