using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AppearanceCustomizationController: DemoController {
        public override string Name { get { return "AppearanceCustomization"; } }

        public ActionResult Index() {
            return View();
        }
    }
}
