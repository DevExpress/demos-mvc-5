using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditingFeaturesController : DemoController {
        public ActionResult Styles() {
            return DemoView("Styles");
        }
        public ActionResult StylesPartial() {
            return PartialView("StylesPartial");
        }
    }
}
