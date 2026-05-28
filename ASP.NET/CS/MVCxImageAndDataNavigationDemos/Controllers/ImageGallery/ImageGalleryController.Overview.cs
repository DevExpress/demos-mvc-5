using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ImageGalleryController: DemoController {
        public ActionResult Overview() {
            return DemoView("Overview");
        }
        public ActionResult OverviewPartial() {
            return PartialView("OverviewPartial");
        }
    }
}
