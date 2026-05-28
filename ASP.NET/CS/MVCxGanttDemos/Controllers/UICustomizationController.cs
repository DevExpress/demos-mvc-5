using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class UICustomizationController : DemoController {
        public override string Name { get { return "UICustomization"; } }

        public ActionResult Index() {
            return RedirectToAction("ChartAppearance");
        }
    }
}
