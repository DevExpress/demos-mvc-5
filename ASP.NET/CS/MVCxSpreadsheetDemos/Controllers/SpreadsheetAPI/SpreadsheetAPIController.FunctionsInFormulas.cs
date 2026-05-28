using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class SpreadsheetAPIController : DemoController {
        public ActionResult FunctionsInFormulas() {
            return DemoView("FunctionsInFormulas");
        }
        public ActionResult FunctionsInFormulasPartial() {
            return PartialView("FunctionsInFormulasPartial");
        }
    }
}
