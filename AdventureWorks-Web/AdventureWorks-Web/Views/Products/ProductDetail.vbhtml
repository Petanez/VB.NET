@*The pageLayouts need to be in Views folder to be able to reference*@
@*This is a MVC 5 View Page with Layout (Razor) _Layout.vbhtml
    FIRST BRING IN THE ADVENTUREWORKS.VIEWMODELLAYER.PRODUCTVIEWMODEL
    -> we tell it what type of model we're going to create in our controller and pass into here so that we can
    access the data*@
@ModelType AdventureWorks.ViewModelLayer.ProductViewModel
@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
    'ViewBag.Title Is to display the title in the page
    ViewBag.Title = "Product Detail"
End Code

@*EVERY TIME YOU ADD A PAGE, WE NEED TO ADD THE CORRESPONDING METHOD IN OUR CONTROLLER. SO SINCE THIS IS UNDER THE PRODUCTS FOLDER
    , WE NEED TO GO TO THE PRODUCTS FOLDER -> PRODUCTSCONTROLLER AND ADD A PRODUCTDETAIL METHOD
    The name of the page is the name of the method in your controller*@
<div class="row">
    <div class="col-sm-3">Product ID</div>
    @*ProductViewModel Has an Entity Property which we can use to access properties of the ProductObject*@
    <div class="col-sm-9">@Model.Entity.ProductID</div>
</div>
<div class="row">
    <div class="col-sm-3">Product Name</div>
    <div class="col-sm-9">@Model.Entity.Name</div>
</div>
<div class="row">
    <div class="col-sm-3">Product Number</div>
    <div class="col-sm-9">@Model.Entity.ProductNumber</div>
</div>
<div class="row">
    <div class="col-sm-3">Color</div>
    <div class="col-sm-9">@Model.Entity.Color</div>
</div>
<div class="row">
    <div class="col-sm-3">Size</div>
    <div class="col-sm-6">@Model.Entity.Size</div>
</div>
<div class="row">
    <div class="col-sm-3">Weight</div>
    <div class="col-sm-9">@Model.Entity.Weight</div>
</div>
<div class="row">
    <div class="col-sm-3">Cost</div>
    <div class="col-sm-9">@Model.Entity.StandardCost</div>
</div>
<div class="row">
    <div class="col-sm-3">Price</div>
    <div class="col-sm-9">@Model.Entity.ListPrice</div>
</div>
<div class="row">
    <div class="col-sm-3">Sell Start Date</div>
    <div class="col-sm-9">@Model.Entity.SellStartDate</div>
</div>
<div class="row">
    <div class="col-sm-3">Sell End Date</div>
    <div class="col-sm-9">@Model.Entity.SellEndDate</div>
</div>
