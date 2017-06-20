Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles BtnShare.Click


        share.Show()
        share.Label2.Text = ListProduit.SelectedItem
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        NouvelleListe.Show()

    End Sub

    Private Sub Btnoption_Click(sender As Object, e As EventArgs) Handles Btnoption.Click
        FormOption.Show()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListProduit.SelectedIndexChanged
        'Btn Partager
        If ListProduit.SelectedItem = "" Then
            BtnShare.Enabled = False
        Else
            BtnShare.Enabled = True
        End If

        'Btn Supprimer
        If ListProduit.SelectedItem = "" Then
            BtnRm.Enabled = False
        Else
            BtnRm.Enabled = True
        End If

        'Btn Voir
        If ListProduit.SelectedItem = "" Then
            BtnVoir.Enabled = False
        Else
            BtnVoir.Enabled = True
        End If



    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles BtnRm.Click
        ListProduit.Items.Remove(ListProduit.SelectedItem)
    End Sub

    Private Sub BtnVoir_Click(sender As Object, e As EventArgs) Handles BtnVoir.Click
        FormVoirListe.Show()
    End Sub
End Class
