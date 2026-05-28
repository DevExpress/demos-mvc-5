using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class RowsController : DemoController {
        public ActionResult Preview() {
            return DemoView("Preview", NorthwindDataProvider.GetEmployees());
        }
        public ActionResult PreviewPartial() {
            return PartialView("PreviewPartial", NorthwindDataProvider.GetEmployees());
        }
    }
}
