using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FilteringController: DemoController {
        public override string Name { get { return "Filtering"; } }
        
        public ActionResult Index() {
            return RedirectToAction("SearchPanel");
        }
    }
}
