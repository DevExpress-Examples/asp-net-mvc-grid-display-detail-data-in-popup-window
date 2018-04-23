using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DisplayDetailInPopupWindow.Models;

namespace DisplayDetailInPopupWindow.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }
        [HttpPost]
        public PartialViewResult MasterAction() {
            return PartialView("MasterViewPartial", CustomerRepository.GetCustomers());
        }
        public ActionResult DetailAction(string _customerID) {
            ViewData["customerID"] = _customerID;
            return View("DetailView", ViewData["customerID"]);
        }
        [HttpPost]
        public PartialViewResult DetailPartialAction(string _customerID) {
            ViewData["customerID"] = _customerID;
            return PartialView("DetailViewPartial", OrderRepository.GetOrders(_customerID));
        }
    }
}
