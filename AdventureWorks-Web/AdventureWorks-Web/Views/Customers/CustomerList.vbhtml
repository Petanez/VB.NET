@*The pageLayouts need to be in Views folder to be able to reference*@
@ModelType AdventureWorks.ViewModelLayer.CustomerViewModel
@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
    ViewBag.Title = "Customers"
End Code

<table class="table table-bordered table-striped">
    <thead>
        <tr>
            @*The headers for the rows*@
            <td>Customer ID</td>
            <td>Company Name</td>
            <td>First Name</td>
            <td>Last Name</td>
        </tr>
    </thead>
</table>

@For Each customer In Model.Customers
    @<tbody>
         <tr>
             @*The data for the rows*@
             <td>@customer.CustomerID</td>
             @*Also possible to do it like this the @Html helper class generates a HTML code for us. The ActionLink method builds an <a> tag.
            product.Name is the name of what we want to display,
            ProductDetail is the name of the method,
            The .id the anonymoys object in this case to pass to that method this .id is made up and it has to match the parameter name
            in the ProductsController ProductDetail Method
             *@
             <td>@Html.ActionLink(customer.CompanyName, "CustomerDetail", New With {.id = customer.CustomerID})</td>
             <td>@customer.FirstName</td>
             <td>@customer.LastName</td>
         </tr>
    </tbody>
Next