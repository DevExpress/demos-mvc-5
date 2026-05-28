using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class DataController : DemoController {
        public override string Name { get { return "Data"; } }

        public ActionResult Index() {
            return RedirectToAction("DataBinding");
        }
    }
}
