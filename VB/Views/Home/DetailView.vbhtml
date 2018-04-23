@ModelType object
@Code
    ViewBag.Title = "DetailView"
End Code
@Html.Partial("DetailViewPartial", OrderRepository.GetOrders(Model.ToString()))
