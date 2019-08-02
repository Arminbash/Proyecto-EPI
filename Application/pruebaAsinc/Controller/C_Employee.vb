Imports Models
Public Class C_Employee
    Dim dao As New D_GetEmployee
    Public Function getEmployee() As List(Of Employee)
        Return dao.getEmployee
    End Function
End Class
