using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ExportingController : DemoController {
        public ActionResult Export() {
            return DemoView("Export", NorthwindDataProvider.GetProducts());
        }
        public ActionResult ExportPartial() {
            return PartialView("ExportPartial", NorthwindDataProvider.GetProducts());
        }
    }
}
