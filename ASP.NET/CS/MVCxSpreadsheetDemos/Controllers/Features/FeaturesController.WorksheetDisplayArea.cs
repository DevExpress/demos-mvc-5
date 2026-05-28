using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FeaturesController : DemoController {
        public ActionResult WorksheetDisplayArea() {
            return DemoView("WorksheetDisplayArea");
        }
        public ActionResult WorksheetDisplayAreaPartial() {
            return PartialView("WorksheetDisplayAreaPartial");
        }
    }
}
