using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class OLAPController: DemoController {
        public override string Name { get { return "OLAP"; } }

        public ActionResult Index() {
            return RedirectToAction("OLAP");
        }
    }
}
