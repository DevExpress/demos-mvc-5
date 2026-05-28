using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class FunnelTypesController : DemoController {
        public override string Name { get { return "FunnelTypes"; } }
        public ActionResult Index() {
            return RedirectToAction("FunnelView");
        }
    }
}
