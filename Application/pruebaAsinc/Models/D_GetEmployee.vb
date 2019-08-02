Imports System.Data.SqlClient
Public Class D_GetEmployee
    Public Function getEmployee() As List(Of Employee)
        Dim test As New PV_TEAMCELLEntities
        Dim query = (From emp In test.Employee Select emp).ToList
        Return query
    End Function
End Class
