using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class PieTypesController : DemoController {
        public override string Name { get { return "PieTypes"; } }
        public ActionResult Index() {
            return RedirectToAction("PieView");
        }
    }
}
