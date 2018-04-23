Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports DisplayDetailInPopupWindow.Models

Namespace DisplayDetailInPopupWindow.Controllers
	Public Class HomeController
		Inherits Controller
		Public Function Index() As ActionResult
			Return View()
		End Function
		<HttpPost> _
		Public Function MasterAction() As PartialViewResult
			Return PartialView("MasterViewPartial", CustomerRepository.GetCustomers())
		End Function
		Public Function DetailAction(ByVal _customerID As String) As ActionResult
			ViewData("customerID") = _customerID
			Return View("DetailView", ViewData("customerID"))
		End Function
		<HttpPost> _
		Public Function DetailPartialAction(ByVal _customerID As String) As PartialViewResult
			ViewData("customerID") = _customerID
			Return PartialView("DetailViewPartial", OrderRepository.GetOrders(_customerID))
		End Function
	End Class
End Namespace
