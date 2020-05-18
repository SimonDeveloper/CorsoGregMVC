Imports System.Web.Mvc
Imports CorsoGreg_1.CorsoGreg_1
Imports CorsoGreg_1.ViewModel

Namespace Controllers
    Public Class ApplicativiController
        Inherits Controller

        ' GET: Applicativi
        Function Index() As ActionResult
            Dim vm = GetApplicativi("")
            Return View(vm)
        End Function

        Function Dettaglio(ID As Integer) As ActionResult

        End Function

        'Function Update() As ActionResult

        'End Function

        'Function Insert() As ActionResult

        'End Function

        'Function Insert() As ActionResult

        'End Function

        Private Function GetApplicativi(whereClause As String) As List(Of ApplicativoViewModel)
            Dim ret As List(Of ApplicativoViewModel)
            If Not String.IsNullOrEmpty(whereClause) Then
                whereClause = $" WHERE {whereClause}"
            End If
            Using db As New FrameworkEntities
                ret = db.Database.SqlQuery(Of ApplicativoViewModel)($"select * from Menu.[Procedure] {whereClause}").ToList()
            End Using
            Return ret
        End Function
    End Class
End Namespace