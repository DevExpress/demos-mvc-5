using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class CommonController: DemoController {
        public override string Name { get { return "Common"; } }

        public ActionResult Index() {
            return RedirectToAction("Callbacks");
        }
    }
}
