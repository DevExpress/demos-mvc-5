using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class AdvancedViewTypesController : DemoController {
        public override string Name { get { return "AdvancedViewTypes"; } }
        public ActionResult Index() {
            return RedirectToAction("CandleView");
        }
    }
}
