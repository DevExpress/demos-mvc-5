using System.Web.Mvc;
using System.Collections;

namespace DevExpress.Web.Demos {
    public partial class FeaturesController: DemoController {
        public override string Name { get { return "Features"; } }

        public ActionResult Index() {
            return RedirectToAction("Grouping");
        }
    }
}
