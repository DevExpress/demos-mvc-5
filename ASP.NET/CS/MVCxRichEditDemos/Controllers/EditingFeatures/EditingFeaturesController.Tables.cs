using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditingFeaturesController : DemoController {
        public ActionResult Tables() {
            return DemoView("Tables");
        }
        public ActionResult TablesPartial() {
            return PartialView("TablesPartial");
        }
    }
}
