'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class City
    Public Property IdCiy As Integer
    Public Property Name As String
    Public Property IdCountry As Nullable(Of Integer)
    Public Property Estatus As Nullable(Of Boolean)

    Public Overridable Property Country As Country
    Public Overridable Property Provider As ICollection(Of Provider) = New HashSet(Of Provider)

End Class
