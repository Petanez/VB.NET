Imports System.Web.Mvc
Imports AdventureWorks.ViewModelLayer

Namespace Controllers
    '   ALL YOUR CONTROLLERS MUST ULTIMATELY INHERIT FROM THE CONTROLLER CLASS FROM MICROSOFT
    '   IN THE MAIN LAYOUT THIS CONTROLLER GETS MAPPED TO BY USING THE PRODUCTS CONTROLLER NAME IN THE HYPERLINK
    Public Class ProductsController
        Inherits Controller

        ' GET: Products
        '   YOUR CONTROLLER METHODS WILL GENERALLY RETURN AN ACTIONRESULT. THIS IS A SPECIAL TYPE WHICH CAN RENDER A VIEW, OR REDIRECT TO ANOTHER MVC PAGE
        Function ProductList() As ActionResult
            '   This ProductViewModel has to match with the ProductList.vbhtml @ModelType
            Dim vm As New ProductViewModel

            '   ON THE LOADPRODUCTS METHOD YOU CAN INSERT OPTIONAL STARTING PATH
            '   ON THE WEB WE NEED TO BE ABLE TO MAP TO WHERE WE INSTALL THIS WEBSITE SO SERVER.MAPPATH RETURNS THE ACTUAL DIRECTORY WHERE THIS WEBSITE IS LOCATED
            '   Server.MapPath() returns the psychical directory where your web application is running from
            '   Adding the ProductsFile value from the Web.config to the Server.MapPath() will result in the the correct directory
            vm.LoadProducts(Server.MapPath("/"))

            Return View(vm)
        End Function

        '   The Name of the page is the name of the method in your controller (ProductDetail.vbhtml)
        Function ProductDetail(ByVal id As Integer) As ActionResult
            Dim vm As New ProductViewModel

            '   The Entity Property was created in the ProductViewModel class to hold an instance of a single Product
            vm.LoadProduct(id, Server.MapPath("/"))

            Return View(vm)
        End Function
    End Class
End Namespace