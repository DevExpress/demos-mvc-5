using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditingFeaturesController : DemoController {
        public ActionResult TextWithImages() {
            return DemoView("TextWithImages");
        }
        public ActionResult TextWithImagesPartial() {
            return PartialView("TextWithImagesPartial");
        }
    }
}
