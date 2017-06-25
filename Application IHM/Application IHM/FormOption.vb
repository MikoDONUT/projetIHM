Public Class FormOption

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Public Sub BtnAppliquer_Click(sender As Object, e As EventArgs) Handles BtnAppliquer.Click
        'Pour mode daltonien

        If RadioModeDaltonien.Checked = True Then
            'changer la couleur des form
            Me.BackColor = System.Drawing.Color.DarkGreen
            AvertissementSave.BackColor = System.Drawing.Color.DarkGreen
            Form1.BackColor = System.Drawing.Color.DarkGreen
            ChoisirAutre.BackColor = System.Drawing.Color.DarkGreen
            ChoisirEpice.BackColor = System.Drawing.Color.DarkGreen
            ChoisirFruitEtLegumes.BackColor = System.Drawing.Color.DarkGreen
            ChoisirProduitDuMonde.BackColor = System.Drawing.Color.DarkGreen
            ChoisirSurgelés.BackColor = System.Drawing.Color.DarkGreen
            ChoisirViande.BackColor = System.Drawing.Color.DarkGreen
            EcoChoisirAutre.BackColor = System.Drawing.Color.DarkGreen
            EcoChoisirViande.BackColor = System.Drawing.Color.DarkGreen
            EcoEpice.BackColor = System.Drawing.Color.DarkGreen
            EcoFruitLegumes.BackColor = System.Drawing.Color.DarkGreen
            EcoProduitDuMonde.BackColor = System.Drawing.Color.DarkGreen
            EcoSurgele.BackColor = System.Drawing.Color.DarkGreen
            Finish.BackColor = System.Drawing.Color.DarkGreen
            FormScann.BackColor = System.Drawing.Color.DarkGreen
            FormVoirListe.BackColor = System.Drawing.Color.DarkGreen
            IdForm.BackColor = System.Drawing.Color.DarkGreen
            Importer.BackColor = System.Drawing.Color.DarkGreen
            ModifierListe.BackColor = System.Drawing.Color.DarkGreen
            NouvelleListe.BackColor = System.Drawing.Color.DarkGreen
            SeConnecter.BackColor = System.Drawing.Color.DarkGreen
            share.BackColor = System.Drawing.Color.DarkGreen
            ValidationCreerCompte.BackColor = System.Drawing.Color.DarkGreen

        End If

        'Pour mode nuit

        If RadioModeNuit.Checked = True Then
            'changer la couleur des form
            Me.BackColor = System.Drawing.Color.Black
            AvertissementSave.BackColor = System.Drawing.Color.Black
            Form1.BackColor = System.Drawing.Color.Black
            ChoisirAutre.BackColor = System.Drawing.Color.Black
            ChoisirEpice.BackColor = System.Drawing.Color.Black
            ChoisirFruitEtLegumes.BackColor = System.Drawing.Color.Black
            ChoisirProduitDuMonde.BackColor = System.Drawing.Color.Black
            ChoisirSurgelés.BackColor = System.Drawing.Color.Black
            ChoisirViande.BackColor = System.Drawing.Color.Black
            EcoChoisirAutre.BackColor = System.Drawing.Color.Black
            EcoChoisirViande.BackColor = System.Drawing.Color.Black
            EcoEpice.BackColor = System.Drawing.Color.Black
            EcoFruitLegumes.BackColor = System.Drawing.Color.Black
            EcoProduitDuMonde.BackColor = System.Drawing.Color.Black
            EcoSurgele.BackColor = System.Drawing.Color.Black
            Finish.BackColor = System.Drawing.Color.Black
            FormScann.BackColor = System.Drawing.Color.Black
            FormVoirListe.BackColor = System.Drawing.Color.Black
            IdForm.BackColor = System.Drawing.Color.Black
            Importer.BackColor = System.Drawing.Color.Black
            ModifierListe.BackColor = System.Drawing.Color.Black
            NouvelleListe.BackColor = System.Drawing.Color.Black
            SeConnecter.BackColor = System.Drawing.Color.Black
            share.BackColor = System.Drawing.Color.Black
            ValidationCreerCompte.BackColor = System.Drawing.Color.Black

            RadioModeNuit.ForeColor = Color.White
            RadioModeDaltonien.ForeColor = Color.White

            'changer la couleur du text
            'Dans me
            Dim ctl As Control

            For Each ctl In Me.Controls
                If TypeOf ctl Is CheckBox Then
                    ctl.ForeColor = Color.White
                End If
            Next ctl


            'Dans Autre
            Dim ctlAutre As Control

            For Each ctlAutre In ChoisirAutre.Controls
                If TypeOf ctlAutre Is Label Then
                    ctlAutre.ForeColor = Color.White
                End If
            Next ctlAutre

            'Dans autre eco
            Dim ctlAutreEco As Control

            For Each ctlAutreEco In EcoChoisirAutre.Controls
                If TypeOf ctlAutreEco Is Label Then
                    ctlAutreEco.ForeColor = Color.White
                End If
            Next ctlAutreEco


            'Dans epice
            Dim ctlEpice As Control

            For Each ctlEpice In ChoisirEpice.Controls
                If TypeOf ctlEpice Is Label Then
                    ctlEpice.ForeColor = Color.White
                End If
            Next ctlEpice

            'Dans epice eco

            Dim ctlEpiceEco As Control

            For Each ctlEpiceEco In EcoEpice.Controls
                If TypeOf ctlEpiceEco Is Label Then
                    ctlEpiceEco.ForeColor = Color.White
                End If
            Next ctlEpiceEco


            'Dans Fruit et legume
            Dim ctlFruit As Control

            For Each ctlFruit In ChoisirFruitEtLegumes.Controls
                If TypeOf ctlFruit Is Label Then
                    ctlFruit.ForeColor = Color.White
                End If
            Next ctlFruit

            'Dans fruit eco
            Dim ctlFruitEco As Control

            For Each ctlFruitEco In EcoFruitLegumes.Controls
                If TypeOf ctlFruitEco Is Label Then
                    ctlFruitEco.ForeColor = Color.White
                End If
            Next ctlFruitEco

            'Dans produit du monde
            Dim ctlProduit As Control

            For Each ctlProduit In ChoisirProduitDuMonde.Controls
                If TypeOf ctlProduit Is Label Then
                    ctlProduit.ForeColor = Color.White
                End If
            Next ctlProduit

            'Dans produit eco
            Dim ctlProduitEco As Control

            For Each ctlProduitEco In EcoProduitDuMonde.Controls
                If TypeOf ctlProduitEco Is Label Then
                    ctlProduitEco.ForeColor = Color.White
                End If
            Next ctlProduitEco

            'Dans viande
            Dim ctlViande As Control

            For Each ctlViande In ChoisirViande.Controls
                If TypeOf ctlViande Is Label Then
                    ctlViande.ForeColor = Color.White
                End If
            Next ctlViande

            'Dans Viande eco
            Dim ctlViandeEco As Control

            For Each ctlViandeEco In EcoChoisirViande.Controls
                If TypeOf ctlViandeEco Is Label Then
                    ctlViandeEco.ForeColor = Color.White
                End If
            Next ctlViandeEco

            'Surgeles
            Dim ctlSurgele As Control

            For Each ctlSurgele In ChoisirSurgelés.Controls
                If TypeOf ctlSurgele Is Label Then
                    ctlSurgele.ForeColor = Color.White
                End If
            Next ctlSurgele


            'Eco Surgeles
            Dim ctlSurgeleEco As Control

            For Each ctlSurgeleEco In EcoSurgele.Controls
                If TypeOf ctlSurgeleEco Is Label Then
                    ctlSurgeleEco.ForeColor = Color.White
                End If
            Next ctlSurgeleEco

            'Page avertissement 
            Dim ctlAverti As Control

            For Each ctlAverti In AvertissementSave.Controls
                If TypeOf ctlAverti Is Label Then
                    ctlAverti.ForeColor = Color.White
                End If
            Next ctlAverti

        End If



        'Pour mode economique
        If CheckBoxEco.Checked = True Then
            Form1.Label2.Text = "Economique"
        End If


    End Sub

    Private Sub BtnQuitter_Click(sender As Object, e As EventArgs) Handles BtnQuitter.Click
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Pour retablir par defaut
        Me.BackColor = System.Drawing.Color.White
        AvertissementSave.BackColor = System.Drawing.Color.White
        Form1.BackColor = System.Drawing.Color.White
        ChoisirAutre.BackColor = System.Drawing.Color.White
        ChoisirEpice.BackColor = System.Drawing.Color.White
        ChoisirFruitEtLegumes.BackColor = System.Drawing.Color.White
        ChoisirProduitDuMonde.BackColor = System.Drawing.Color.White
        ChoisirSurgelés.BackColor = System.Drawing.Color.White
        ChoisirViande.BackColor = System.Drawing.Color.White
        EcoChoisirAutre.BackColor = System.Drawing.Color.White
        EcoChoisirViande.BackColor = System.Drawing.Color.White
        EcoEpice.BackColor = System.Drawing.Color.White
        EcoFruitLegumes.BackColor = System.Drawing.Color.White
        EcoProduitDuMonde.BackColor = System.Drawing.Color.White
        EcoSurgele.BackColor = System.Drawing.Color.White
        Finish.BackColor = System.Drawing.Color.White
        FormScann.BackColor = System.Drawing.Color.White
        FormVoirListe.BackColor = System.Drawing.Color.White
        IdForm.BackColor = System.Drawing.Color.White
        Importer.BackColor = System.Drawing.Color.White
        ModifierListe.BackColor = System.Drawing.Color.White
        NouvelleListe.BackColor = System.Drawing.Color.White
        SeConnecter.BackColor = System.Drawing.Color.White
        share.BackColor = System.Drawing.Color.White
        ValidationCreerCompte.BackColor = System.Drawing.Color.White
        RadioModeNuit.ForeColor = Color.Black
        RadioModeDaltonien.ForeColor = Color.Black


        'Retablir la couleur du text
        'Dans me
        Dim ctl As Control

        For Each ctl In Me.Controls
            If TypeOf ctl Is CheckBox Then
                ctl.ForeColor = Color.Black
            End If
        Next ctl


        'Dans Autre
        Dim ctlAutre As Control

        For Each ctlAutre In ChoisirAutre.Controls
            If TypeOf ctlAutre Is Label Then
                ctlAutre.ForeColor = Color.Black
            End If
        Next ctlAutre

        'Dans autre eco
        Dim ctlAutreEco As Control

        For Each ctlAutreEco In EcoChoisirAutre.Controls
            If TypeOf ctlAutreEco Is Label Then
                ctlAutreEco.ForeColor = Color.Black
            End If
        Next ctlAutreEco


        'Dans epice
        Dim ctlEpice As Control

        For Each ctlEpice In ChoisirEpice.Controls
            If TypeOf ctlEpice Is Label Then
                ctlEpice.ForeColor = Color.Black
            End If
        Next ctlEpice

        'Dans epice eco

        Dim ctlEpiceEco As Control

        For Each ctlEpiceEco In EcoEpice.Controls
            If TypeOf ctlEpiceEco Is Label Then
                ctlEpiceEco.ForeColor = Color.Black
            End If
        Next ctlEpiceEco


        'Dans Fruit et legume
        Dim ctlFruit As Control

        For Each ctlFruit In ChoisirFruitEtLegumes.Controls
            If TypeOf ctlFruit Is Label Then
                ctlFruit.ForeColor = Color.Black
            End If
        Next ctlFruit

        'Dans fruit eco
        Dim ctlFruitEco As Control

        For Each ctlFruitEco In EcoFruitLegumes.Controls
            If TypeOf ctlFruitEco Is Label Then
                ctlFruitEco.ForeColor = Color.Black
            End If
        Next ctlFruitEco

        'Dans produit du monde
        Dim ctlProduit As Control

        For Each ctlProduit In ChoisirProduitDuMonde.Controls
            If TypeOf ctlProduit Is Label Then
                ctlProduit.ForeColor = Color.Black
            End If
        Next ctlProduit

        'Dans produit eco
        Dim ctlProduitEco As Control

        For Each ctlProduitEco In EcoProduitDuMonde.Controls
            If TypeOf ctlProduitEco Is Label Then
                ctlProduitEco.ForeColor = Color.Black
            End If
        Next ctlProduitEco

        'Dans viande
        Dim ctlViande As Control

        For Each ctlViande In ChoisirViande.Controls
            If TypeOf ctlViande Is Label Then
                ctlViande.ForeColor = Color.Black
            End If
        Next ctlViande

        'Dans Viande eco
        Dim ctlViandeEco As Control

        For Each ctlViandeEco In EcoChoisirViande.Controls
            If TypeOf ctlViandeEco Is Label Then
                ctlViandeEco.ForeColor = Color.Black
            End If
        Next ctlViandeEco


        'Surgeles
        Dim ctlSurgele As Control

        For Each ctlSurgele In ChoisirSurgelés.Controls
            If TypeOf ctlSurgele Is Label Then
                ctlSurgele.ForeColor = Color.Black
            End If
        Next ctlSurgele


        'Eco Surgeles
        Dim ctlSurgeleEco As Control

        For Each ctlSurgeleEco In EcoSurgele.Controls
            If TypeOf ctlSurgeleEco Is Label Then
                ctlSurgeleEco.ForeColor = Color.Black
            End If
        Next ctlSurgeleEco

        'page averti
        Dim ctlAverti As Control

        For Each ctlAverti In AvertissementSave.Controls
            If TypeOf ctlAverti Is Label Then
                ctlAverti.ForeColor = Color.Black
            End If
        Next ctlAverti


        'Retablis les checkbox a false
        If RadioModeNuit.Checked = True Then
            RadioModeNuit.Checked = False
        End If
        If RadioModeDaltonien.Checked = True Then
            RadioModeDaltonien.Checked = False
        End If

        'Retablis le mode non economique
        Form1.Label2.Text = ""

    End Sub

End Class