using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class SummaryController: DemoController {
        public override string Name { get { return "Summary"; } }
        
        public ActionResult Index() {
            return RedirectToAction("Summary");
        }
    }
}
