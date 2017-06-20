Public Class FormOption
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub


    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxNuit.CheckedChanged

    End Sub

    Private Sub BtnAppliquer_Click(sender As Object, e As EventArgs) Handles BtnAppliquer.Click

        If CheckBoxNuit.Checked = True Then
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


            'changer la couleur du text
            Dim ctl As Control

            For Each ctl In Me.Controls
                If TypeOf ctl Is CheckBox Then
                    ctl.ForeColor = Color.White
                End If
            Next ctl

        ElseIf CheckBoxNuit.Checked = False Then

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

            Dim ctl As Control

            For Each ctl In Me.Controls
                If TypeOf ctl Is CheckBox Then
                    ctl.ForeColor = Color.Black
                End If
            Next ctl

        End If
    End Sub

    Private Sub BtnQuitter_Click(sender As Object, e As EventArgs) Handles BtnQuitter.Click
        Me.Dispose()
    End Sub
End Class