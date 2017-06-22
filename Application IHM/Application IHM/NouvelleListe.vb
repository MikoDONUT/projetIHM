Public Class NouvelleListe
    Dim priceTot As Integer = 0
    Public btnSaveClicked As Boolean = False
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    'procedure servant a calculer le prix total des achats
    Public Sub calcl(price As Integer)
        priceTot += price
        Label3.Text = priceTot.ToString
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Form1.Label2.Text = "" Then
            IsEco.Text = ""
            ChoisirViande.Show()

            'modifier le label de viande a la valeur du text input
            ChoisirViande.Label1.Text = BoxNewList.Text

        ElseIf Form1.Label2.Text = "Economique" Then
            IsEco.Text = "Economique"
            FormOption.Show()
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnSurgelé.Click
        'Verifie si l'option eco est activer
        If Form1.Label2.Text = "" Then
            IsEco.Text = ""

            ChoisirSurgelés.Show()
            'modifier le label de surgeles a la valeur du text input
            ChoisirSurgelés.Label1.Text = BoxNewList.Text

        ElseIf Form1.Label2.Text = "Economique" Then
            IsEco.Text = "Economique"

        End If




    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Verifie si l'option eco est activer
        If Form1.Label2.Text = "" Then
            IsEco.Text = ""
            ChoisirFruitEtLegumes.Show()
            'modifier le label de fruit et legume a la valeur du text input
            ChoisirFruitEtLegumes.Label1.Text = BoxNewList.Text

        ElseIf Form1.Label2.Text = "Economique" Then
            IsEco.Text = "Economique"
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Verifie si l'option eco est activer
        If Form1.Label2.Text = "" Then
            IsEco.Text = ""
            ChoisirEpice.Show()
            'modifier le label de Epice a la valeur du text input
            ChoisirEpice.Label1.Text = BoxNewList.Text

        ElseIf Form1.Label2.Text = "Economique" Then
            IsEco.Text = "Economique"
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'Verifie si l'option eco est activer
        If Form1.Label2.Text = "" Then
            IsEco.Text = ""
            ChoisirProduitDuMonde.Show()
            'modifier le label de Produit du monde a la valeur du text input
            ChoisirProduitDuMonde.Label1.Text = BoxNewList.Text

        ElseIf Form1.Label2.Text = "Economique" Then
            IsEco.Text = "Economique"
        End If

    End Sub

    Private Sub BtnRetour_Click(sender As Object, e As EventArgs) Handles BtnRetour.Click
        'Verifie si la liste a bien ete enrengistrer avant de faire un retour
        If btnSaveClicked = True Then
            Me.Dispose()
        Else
            AvertissementSave.Show()
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        btnSaveClicked = True
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

    Private Sub NouvelleListe_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Verifie si la liste a bien ete enrengistrer avant de fermer la fenetre
        If Not btnSaveClicked Then
            e.Cancel = True
            AvertissementSave.Show() 'afficher un avertissement
        End If

    End Sub
    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        FormScann.Show()
    End Sub
End Class