using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FeaturesController: DemoController {
        public ActionResult Printing() {
            return DemoView("Printing");
        }
        public ActionResult PrintingPartial() {
            return PartialView("PrintingPartial");
        }
    }
}
