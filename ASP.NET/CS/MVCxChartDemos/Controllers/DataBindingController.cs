using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class DataBindingController: DemoController {
        public override string Name { get { return "DataBinding"; } }

        public ActionResult Index() {
            return RedirectToAction("SeriesBinding");
        }
    }
}
