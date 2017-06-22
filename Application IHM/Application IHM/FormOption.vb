Public Class FormOption

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Public Sub BtnAppliquer_Click(sender As Object, e As EventArgs) Handles BtnAppliquer.Click
        'Pour mode daltonien
        If RadioModeDaltonien.Checked = True Then
            'changer la couleur des form
            Me.BackColor = System.Drawing.Color.DarkGreen
            Form1.BackColor = System.Drawing.Color.DarkGreen
            ChoisirAutre.BackColor = System.Drawing.Color.DarkGreen
            ChoisirEpice.BackColor = System.Drawing.Color.DarkGreen
            ChoisirFruitEtLegumes.BackColor = System.Drawing.Color.DarkGreen
            ChoisirProduitDuMonde.BackColor = System.Drawing.Color.DarkGreen
            ChoisirSurgelés.BackColor = System.Drawing.Color.DarkGreen
            ChoisirViande.BackColor = System.Drawing.Color.DarkGreen
            NouvelleListe.BackColor = System.Drawing.Color.DarkGreen
            share.BackColor = System.Drawing.Color.DarkGreen

        End If

        'Pour mode nuit
        If RadioModeNuit.Checked = True Then
            'changer la couleur des form
            Me.BackColor = System.Drawing.Color.Black
            Form1.BackColor = System.Drawing.Color.Black
            ChoisirAutre.BackColor = System.Drawing.Color.Black
            ChoisirEpice.BackColor = System.Drawing.Color.Black
            ChoisirFruitEtLegumes.BackColor = System.Drawing.Color.Black
            ChoisirProduitDuMonde.BackColor = System.Drawing.Color.Black
            ChoisirSurgelés.BackColor = System.Drawing.Color.Black
            ChoisirViande.BackColor = System.Drawing.Color.Black
            NouvelleListe.BackColor = System.Drawing.Color.Black
            share.BackColor = System.Drawing.Color.Black

            RadioModeNuit.ForeColor = Color.White
            RadioModeDaltonien.ForeColor = Color.White

            'changer la couleur du text
            Dim ctl As Control

            For Each ctl In Me.Controls
                If TypeOf ctl Is CheckBox Then
                    ctl.ForeColor = Color.White
                End If
            Next ctl

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
        Form1.BackColor = System.Drawing.Color.White
        ChoisirAutre.BackColor = System.Drawing.Color.White
        ChoisirEpice.BackColor = System.Drawing.Color.White
        ChoisirFruitEtLegumes.BackColor = System.Drawing.Color.White
        ChoisirProduitDuMonde.BackColor = System.Drawing.Color.White
        ChoisirSurgelés.BackColor = System.Drawing.Color.White
        ChoisirViande.BackColor = System.Drawing.Color.White
        NouvelleListe.BackColor = System.Drawing.Color.White
        share.BackColor = System.Drawing.Color.White
        RadioModeNuit.ForeColor = Color.Black
        RadioModeDaltonien.ForeColor = Color.Black


        Dim ctl As Control

        For Each ctl In Me.Controls
            If TypeOf ctl Is CheckBox Then
                ctl.ForeColor = Color.Black
            End If
        Next ctl
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