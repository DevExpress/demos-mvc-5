using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class MasterDetailController: DemoController {
        public override string Name { get { return "MasterDetail"; } }

        public ActionResult Index() {
            return RedirectToAction("MasterDetail");
        }
    }
}
