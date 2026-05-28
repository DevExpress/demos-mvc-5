using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FeaturesController : DemoController {
        public ActionResult Images() {
            return DemoView("Images");
        }
        public ActionResult ImagesPartial() {
            return PartialView("ImagesPartial");
        }
    }
}
