Imports System.Web.Mvc

Namespace Controllers
    Public Class DipendenteController
        Inherits Controller

        ' GET: Dipendente
        Function Anagrafica() As ActionResult
            Dim listaAnagrafica As New List(Of DipendenteViewModel)
            listaAnagrafica.Add(New DipendenteViewModel With {.Cognome = "Coppi", .Nome = "Gregorio"})
            listaAnagrafica.Add(New DipendenteViewModel With {.Cognome = "Cusimano", .Nome = "Simone"})

            Return View(listaAnagrafica)
        End Function
    End Class
End Namespace