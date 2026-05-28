using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ExportingController : DemoController {
        public ActionResult ExportWithFormatConditions() {
            return DemoView("ExportWithFormatConditions", HomesDataProvider.Homes);
        }
        public ActionResult ExportWithFormatConditionsPartial() {
            return PartialView("ExportWithFormatConditionsPartial", HomesDataProvider.Homes);
        }
    }
}
