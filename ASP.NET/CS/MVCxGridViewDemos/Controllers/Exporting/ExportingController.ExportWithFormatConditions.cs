using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ExportingController : DemoController {
        public ActionResult ExportWithFormatConditions() {
            return DemoView("ExportWithFormatConditions", NorthwindDataProvider.GetFullInvoices());
        }
        public ActionResult ExportWithFormatConditionsPartial() {
            return PartialView("ExportWithFormatConditionsPartial", NorthwindDataProvider.GetFullInvoices());
        }
    }
}
