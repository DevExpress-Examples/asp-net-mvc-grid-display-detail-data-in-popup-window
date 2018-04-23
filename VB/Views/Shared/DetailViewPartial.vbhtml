@ModelType System.Data.DataTable

@Html.DevExpress().GridView(
    Sub(settings)
            settings.Name = "detailGrid"
            settings.CallbackRouteValues = New With {Key .Controller = "Home", Key .Action = "DetailPartialAction", Key ._customerID = ViewData("customerID")}
   
            settings.KeyFieldName = "OrderID"
            settings.Columns.Add("OrderID")
            settings.Columns.Add("CustomerID")
            settings.Columns.Add("Freight")
            settings.Columns.Add("ShipName")
            settings.Columns.Add("ShipAddress")
            settings.Columns.Add("ShipCity")
            settings.Columns.Add("ShipCountry")
            settings.Columns.Add("ShipPostalCode")
            settings.Columns.Add("ShippedDate")
    End Sub
).Bind(Model).GetHtml()