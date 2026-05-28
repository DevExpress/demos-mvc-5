using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FocusingAndSelectionController: DemoController {
        public override string Name { get { return "FocusingAndSelection"; } }

        public ActionResult Index() {
            return RedirectToAction("Selection");
        }
    }
}
