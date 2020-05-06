Imports Microsoft.Ajax.Utilities

Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function

    Function ViewBella() As ActionResult
        Return View()
    End Function

    Function IlMilBelMetodoBindato() As ActionResult
        Return View()
    End Function

    Function IlMilBelMetodoBindatoCambioNome() As ActionResult
        Return View()
    End Function

End Class
