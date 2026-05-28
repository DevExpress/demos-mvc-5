using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class RatingControlController : DemoController {
        public override string Name { get { return "RatingControl"; } }

        public ActionResult Index() {
            return RedirectToAction("DataBinding");
        }
    }
}
