using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ExportingController : DemoController {
        public ActionResult Export() {
            return DemoView("Export", NorthwindDataProvider.GetInvoices());
        }
        public ActionResult ExportPartial() {
            return PartialView("ExportPartial", NorthwindDataProvider.GetInvoices());
        }
    }
}
