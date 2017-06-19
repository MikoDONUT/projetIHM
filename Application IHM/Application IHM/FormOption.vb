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
            'changer la couleur de form
            Me.BackColor = System.Drawing.Color.Black
            'changer la couleur du text
            Dim ctl As Control

            For Each ctl In Me.Controls
                If TypeOf ctl Is CheckBox Then
                    ctl.ForeColor = Color.White
                End If
            Next ctl

        ElseIf CheckBoxNuit.Checked = False Then

            Me.BackColor = System.Drawing.Color.White

            Dim ctl As Control

            For Each ctl In Me.Controls
                If TypeOf ctl Is CheckBox Then
                    ctl.ForeColor = Color.Black
                End If
            Next ctl

        End If
    End Sub
End Class