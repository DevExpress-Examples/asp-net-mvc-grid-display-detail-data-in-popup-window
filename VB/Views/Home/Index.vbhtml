@Code
    ViewBag.Title = "Index"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

@Html.Partial("MasterViewPartial", DisplayDetailInPopupWindow.Models.CustomerRepository.GetCustomers())
@Html.DevExpress().PopupControl(
    Sub(settings)
            settings.Name = "popup"
            settings.Width = System.Web.UI.WebControls.Unit.Pixel(800)
            settings.Height = System.Web.UI.WebControls.Unit.Pixel(200)
    End Sub).GetHtml()
