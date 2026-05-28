using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class GridLookupController: DemoController {
        public override string Name { get { return "GridLookup"; } }

        public ActionResult Index() {
            return RedirectToAction("AdvancedLookup");
        }
    }
}
