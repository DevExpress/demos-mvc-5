using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class RibbonController: DemoController {
        public override string Name { get { return "Ribbon"; } }

        public ActionResult Index() {
            return RedirectToAction("Features");
        }
    }
}
