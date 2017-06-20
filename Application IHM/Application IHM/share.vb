Public Class share
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click


    End Sub

    Public Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnEnvoyer.Click
        'si la liste box n'est pas selectionner
        If ListBox1.SelectedItem = "" Then
            MsgBox("Erreur ! Il faut selectionner un contact")
        Else
            Form1.Show()
            FormVoirListe.LstBoxPartager.Items.Add(ListBox1.SelectedItem)
            MsgBox("Vous avez partager votre liste avec " & ListBox1.SelectedItem)
        End If




    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Dispose()
    End Sub

    Private Sub share_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class