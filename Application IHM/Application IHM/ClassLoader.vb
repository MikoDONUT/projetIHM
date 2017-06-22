Imports Application_IHM

Public Class ClassLoader
    Private Delegate Sub DoubleFunction(ByVal D As Double)

    Public Sub DisplayPercentage(Value As Double)
        If Me.InvokeRequired Then
            Dim TempFunction As New DoubleFunction(AddressOf DisplayPercentage)
            Me.Invoke(TempFunction, Value)
        Else
            Me.PercentageLabel.text = Value
        End If
    End Sub

    Private Function PercentageLabel() As Object
        Throw New NotImplementedException()
    End Function

    Private Sub Invoke(tempFunction As DoubleFunction, value As Double)
        Throw New NotImplementedException()
    End Sub

    Private Function InvokeRequired() As Boolean
        Throw New NotImplementedException()
    End Function
End Class
