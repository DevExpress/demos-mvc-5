using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class GroupingSortingController: DemoController {
        public override string Name { get { return "GroupingSorting"; } }

        public ActionResult Index() {
            return RedirectToAction("Sorting");
        }
    }
}
