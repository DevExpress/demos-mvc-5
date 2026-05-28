using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class CustomizationController : DemoController {
        public override string Name { get { return "Customization"; } }

        public ActionResult Index() {
            return RedirectToAction("Toolbar");
        }
    }
}
