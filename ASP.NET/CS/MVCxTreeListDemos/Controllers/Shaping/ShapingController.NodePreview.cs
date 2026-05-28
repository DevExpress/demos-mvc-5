using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ShapingController : DemoController {
        public ActionResult NodePreview() {
            return DemoView("NodePreview", FishCatalog.GetData());
        }
        public ActionResult NodePreviewPartial() {
            return PartialView("NodePreviewPartial", FishCatalog.GetData());
        }
    }
}
