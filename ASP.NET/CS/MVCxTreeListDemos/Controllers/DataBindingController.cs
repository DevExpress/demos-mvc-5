using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class DataBindingController : DemoController {
        public override string Name { get { return "DataBinding"; } }

        public ActionResult Index() {
            return RedirectToAction("DataBinding");
        }
    }
}
