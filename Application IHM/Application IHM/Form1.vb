﻿Imports Application_IHM

Public Class Form1

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles BtnShare.Click
        share.Show()
        share.Label2.Text = ListProduit.SelectedItem
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

        'Btn Modifier
        If ListProduit.SelectedItem = "" Then
            BtnModif.Enabled = False
        Else
            BtnModif.Enabled = True
        End If


        'Btn finish
        If ListProduit.SelectedItem = "" Then
            ButtonFinish.Enabled = False
        Else
            ButtonFinish.Enabled = True
        End If

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles BtnRm.Click
        'Pour supprimer des items de la liste box
        MsgBox("Votre liste " & ListProduit.SelectedItem & " a bien ete supprimer")
        ListProduit.Items.Remove(ListProduit.SelectedItem)

    End Sub

    Private Sub BtnVoir_Click(sender As Object, e As EventArgs) Handles BtnVoir.Click
        'Pour voir les element d'une liste box
        FormVoirListe.Show()
        FormVoirListe.Label2.Text = ListProduit.SelectedItem

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SeConnecter.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        'Desactive le boutton nouvelle liste
        BtnNew.Enabled = False
        'Desactive le boutton logout
        Button2.Enabled = False

        'Active le boutton login
        Button1.Enabled = True



        'Vide la liste box
        ListProduit.Items.Clear()
        'Retire le pseudo du user 
        LblPseudo.Text = ""
        MsgBox("Vous avez ete deconnecter")
    End Sub

    Public Shared Widening Operator CType(v As FormOption) As Form1
        Throw New NotImplementedException()
    End Operator

    Private Sub ButtonFinish_Click(sender As Object, e As EventArgs) Handles ButtonFinish.Click
        Finish.Label4.Text = ListProduit.SelectedItem
        Finish.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Importer.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnModif.Click
        ModifierListe.Show()
        ModifierListe.Label1.Text = ListProduit.SelectedItem
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
