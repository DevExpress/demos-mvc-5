using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class RangeTypesController : DemoController {
        public override string Name { get { return "RangeTypes"; } }
        public ActionResult Index() {
            return RedirectToAction("RangeView");
        }
    }
}
