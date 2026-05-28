using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FeaturesController: DemoController {
        public override string Name { get { return "Features"; } }

        public ActionResult Index() {
            return RedirectToAction("Editors");
        }
    }
}
