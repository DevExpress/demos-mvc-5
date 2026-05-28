using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class BarsAndUIController : DemoController {
        public override string Name { get { return "BarsAndUI"; } }

        public ActionResult Index() {
            return RedirectToAction("RibbonCustomization");
        }
    }
}
