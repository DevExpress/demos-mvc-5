using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FeaturesController : DemoController {
        public ActionResult Tables() {
            return DemoView("Tables");
        }
        public ActionResult TablesPartial() {
            return PartialView("TablesPartial");
        }
    }
}
