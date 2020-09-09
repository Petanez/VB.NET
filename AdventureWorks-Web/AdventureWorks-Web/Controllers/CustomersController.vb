Imports System.Web.Mvc
Imports AdventureWorks.ViewModelLayer

Namespace Controllers
    Public Class CustomersController
        Inherits Controller

        ' GET: Customers
        Function CustomersList() As ActionResult
            Dim vm As New CustomerViewModel

            Console.WriteLine(Server.MapPath("/"))
            vm.LoadCustomers(Server.MapPath("/"))

            Return View(vm)
        End Function

        Function CustomerDetail(ByVal id As Integer) As ActionResult
            Dim vm As New CustomerViewModel

            vm.LoadCustomer(id, Server.MapPath("/"))

            Return View(vm)
        End Function
    End Class
End Namespace