using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class MasterDetailController : DemoController {
        public ActionResult MasterDetail() {
            return DemoView("MasterDetail", NorthwindDataProvider.GetCustomers());
        }
        public ActionResult MasterDetailMasterPartial() {
            return PartialView("MasterDetailMasterPartial", NorthwindDataProvider.GetCustomers());
        }
        public ActionResult MasterDetailDetailPartial(string customerID) {
            ViewData["CustomerID"] = customerID;
            return PartialView("MasterDetailDetailPartial", NorthwindDataProvider.GetInvoices(customerID));
        }
    }
}
