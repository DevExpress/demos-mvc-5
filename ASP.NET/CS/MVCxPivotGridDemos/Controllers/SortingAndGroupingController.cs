using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class SortingAndGroupingController : DemoController {
        public override string Name { get { return "SortingAndGrouping"; } }

        public ActionResult Index() {
            return RedirectToAction("SortBySummary");
        }
    }
}
