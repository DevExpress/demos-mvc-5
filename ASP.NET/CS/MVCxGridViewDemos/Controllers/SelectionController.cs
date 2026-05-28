using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class SelectionController: DemoController {
        public override string Name { get { return "Selection"; } }

        public ActionResult Index() {
            return RedirectToAction("RowSelection");
        }
    }
}
