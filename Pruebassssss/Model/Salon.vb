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

Partial Public Class Salon
    Public Property idSalon As Integer
    Public Property nombre As String

    Public Overridable Property DetalleSalonMaterias As ICollection(Of DetalleSalonMateria) = New HashSet(Of DetalleSalonMateria)
    Public Overridable Property DetalleSalonSeccions As ICollection(Of DetalleSalonSeccion) = New HashSet(Of DetalleSalonSeccion)

End Class
