using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FeaturesController : DemoController {
        public ActionResult Formulas() {
            return DemoView("Formulas");
        }
        public ActionResult FormulasPartial() {
            return PartialView("FormulasPartial");
        }
    }
}
