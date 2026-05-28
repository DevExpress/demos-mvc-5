using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FeaturesController : DemoController {
        public ActionResult DataValidation() {
            return DemoView("DataValidation");
        }
        public ActionResult DataValidationPartial() {
            return PartialView("DataValidationPartial");
        }
    }
}
