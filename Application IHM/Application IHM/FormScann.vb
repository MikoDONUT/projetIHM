Public Class FormScann
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim random As New Random
        Dim PriceArticle As New Integer
        ' Dim Loader As ClassLoader

        ' Loader.DisplayPercentage(1.5)
        PriceArticle = random.Next(5, 100)


        System.Threading.Thread.Sleep(1000)
        MsgBox("Votre article coute" & PriceArticle)
    End Sub

    Private Sub BtnRetour_Click(sender As Object, e As EventArgs) Handles BtnRetour.Click
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        System.Threading.Thread.Sleep(1000)
        MsgBox("Votre article a ete enrengistrer")
    End Sub
End Class