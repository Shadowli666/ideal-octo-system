Public Class student
    Public Property nombre As String
    Public Property apellido As String
    Public Property edad As Integer
    Public Function Validate() As List(Of String)
        Dim errors As New List(Of String)
        If String.IsNullOrWhiteSpace(nombre) Then
            errors.Add("Ingrese el primer nombre")
        End If
        If String.IsNullOrWhiteSpace(apellido) Then
            errors.Add("Ingrese el apellido")
        End If
        If edad <= 0 Then
            errors.Add("Ingrese una edad válida")
        End If
        Return errors
    End Function
End Class
