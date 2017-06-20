Public Class NouvelleListe
    Dim priceTot As Integer = 0
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    'procedure servant a calculer le prix total des achats
    Public Sub calcl(price As Integer)
        priceTot += price
        Label3.Text = priceTot.ToString
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ChoisirViande.Show()
        'modifier le label de viande a la valeur du text input
        ChoisirViande.Label1.Text = BoxNewList.Text

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnSurgelé.Click
        ChoisirSurgelés.Show()
        'modifier le label de surgeles a la valeur du text input
        ChoisirSurgelés.Label1.Text = BoxNewList.Text

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ChoisirFruitEtLegumes.Show()
        'modifier le label de fruit et legume a la valeur du text input
        ChoisirFruitEtLegumes.Label1.Text = BoxNewList.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ChoisirEpice.Show()
        'modifier le label de Epice a la valeur du text input
        ChoisirEpice.Label1.Text = BoxNewList.Text
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ChoisirProduitDuMonde.Show()
        'modifier le label de Produit du monde a la valeur du text input
        ChoisirProduitDuMonde.Label1.Text = BoxNewList.Text
    End Sub

    Private Sub BtnRetour_Click(sender As Object, e As EventArgs) Handles BtnRetour.Click
        Me.Dispose()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.ListProduit.Items.Add(BoxNewList.Text)
        MsgBox("Votre Liste a ete sauvegarder")
    End Sub

    Private Sub BoxtxtNew_TextChanged(sender As Object, e As EventArgs) Handles BoxNewList.TextChanged

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ChoisirAutre.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub NouvelleListe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class