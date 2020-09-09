@*This is a MVC 5 View Page with Layout (Razor)*@
@*Bring in the AdventureWorks.ViewModelLayer THE ADVENTUREWORKS-WEB(MAIN PROJECT) HAS TO HAVE A REFERENCE TO THESE DLLS
    ProductViewModel has to match the type in the ProductsController*@
@ModelType AdventureWorks.ViewModelLayer.ProductViewModel
@*@Code tells Razor that the next lines should be treated as visual basic code*@
@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
    ViewBag.Title = "Products"
End Code


<table class="table table-bordered table-striped">
    <thead>
        <tr>
            <th>Product ID</th>
            <th>Product Name</th>
            <th>Product Number</th>
            <th>Color</th>
            <th>Size</th>
            <th>Cost</th>
            <th>Price</th>
        </tr>
    </thead>

    @*The Model property in Razor is an instance of the ModelType you specified on line 1. In this case, it is an instance of the ProductViewModel*@
    @*Theres a Products collection in the ProductViewModel that we are looping through and each time it's putting a product into that variable that we've defined as product
        then we have our tbody, tr and td and we go through each value we wish to display in this table
            FIRST WE NEED TO GET THAT DATA LOADED AND WE DO THAT BY ADDING A CONTROLLER TO THE CONTROLLERS FOLDER*@

    @For Each product In Model.Products
        @<tbody>
            <tr>
                <td>@product.ProductID</td>
                <td>
                    @*Also possible to do it like this the @Html helper class generates a HTML code for us. The ActionLink method builds an <a> tag.
                        product.Name is the name of what we want to display,
                        ProductDetail is the name of the method,
                        The .id the anonymoys object in this case to pass to that method this .id is made up and it has to match the parameter name 
                        in the ProductsController ProductDetail Method
                        *@
                    @Html.ActionLink(product.Name, "ProductDetail",
                         New With {.id = product.ProductID})
                </td>
                <td>@product.ProductNumber</td>
                <td>@product.Color</td>
                <td>@product.Size</td>
                <td>@product.StandardCost</td>
                <td>@product.ListPrice</td>
            </tr>
        </tbody>
    Next
</table>