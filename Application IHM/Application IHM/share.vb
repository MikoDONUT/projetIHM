﻿Public Class share
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnEnvoyer.Click

        Form1.show()
        MsgBox("Vous avez partager votre liste avec un amis !")
        this.dispose

    End Sub
End Class