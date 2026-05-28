using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ColumnsController : DemoController {
        public ActionResult Bands() {
            return DemoView("Bands", NorthwindDataProvider.GetFullInvoices());
        }
        public ActionResult BandsPartial() {
            return PartialView("BandsPartial", NorthwindDataProvider.GetFullInvoices());
        }
    }
}
