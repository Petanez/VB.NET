@ModelType AdventureWorks.ViewModelLayer.CustomerViewModel
@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
    ViewBag.Title = "Customer Detail"
End Code

<div class="row">
    <div class="col-sm-3">Customer ID</div>
    <div class="col-sm-9">@Model.Entity.CustomerID</div>
</div>
<div class="row">
    <div class="col-sm-3">Company Name</div>
    <div class="col-sm-9">@Model.Entity.CompanyName</div>
</div>
<div class="row">
    <div class="col-sm-3">First Name</div>
    <div class="col-sm-9">@Model.Entity.FirstName</div>
</div>
<div class="row">
    <div class="col-sm-3">Last Name</div>
    <div class="col-sm-9">@Model.Entity.LastName</div>
</div>