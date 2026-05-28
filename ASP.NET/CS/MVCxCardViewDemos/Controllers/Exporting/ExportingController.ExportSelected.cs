using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ExportingController : DemoController {
        public ActionResult ExportSelected() {
            return DemoView("ExportSelected", HomesDataProvider.Homes);
        }
        public ActionResult ExportSelectedPartial() {
            return PartialView("ExportSelectedPartial", HomesDataProvider.Homes);
        }
    }
}
