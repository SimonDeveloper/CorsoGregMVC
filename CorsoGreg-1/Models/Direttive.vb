'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Namespace CorsoGreg_1

    Partial Public Class Direttive
        Public Property id As Integer
        Public Property direttiva_aggiornamenti As String
        Public Property direttiva_programmi As String
        Public Property direttiva_dll As String
        Public Property dominioImpersonation As String
        Public Property userImpersonation As String
        Public Property passImpersonation As String
    
        Public Overridable Property Procedure As ICollection(Of Procedure) = New HashSet(Of Procedure)
    
    End Class

End Namespace
