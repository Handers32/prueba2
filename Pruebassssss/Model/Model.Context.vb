﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class ColegioEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=ColegioEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property Alumnoes() As DbSet(Of Alumno)
    Public Overridable Property AuxAlumnoGradoes() As DbSet(Of AuxAlumnoGrado)
    Public Overridable Property AuxMateriaGradoes() As DbSet(Of AuxMateriaGrado)
    Public Overridable Property AuxMateriaProfesors() As DbSet(Of AuxMateriaProfesor)
    Public Overridable Property Departamentoes() As DbSet(Of Departamento)
    Public Overridable Property DetalleSalonMaterias() As DbSet(Of DetalleSalonMateria)
    Public Overridable Property DetalleSalonSeccions() As DbSet(Of DetalleSalonSeccion)
    Public Overridable Property Gradoes() As DbSet(Of Grado)
    Public Overridable Property Materias() As DbSet(Of Materia)
    Public Overridable Property Profesors() As DbSet(Of Profesor)
    Public Overridable Property Rols() As DbSet(Of Rol)
    Public Overridable Property Salons() As DbSet(Of Salon)
    Public Overridable Property Seccions() As DbSet(Of Seccion)
    Public Overridable Property Usuarios() As DbSet(Of Usuario)
    Public Overridable Property Notas() As DbSet(Of Nota)

End Class