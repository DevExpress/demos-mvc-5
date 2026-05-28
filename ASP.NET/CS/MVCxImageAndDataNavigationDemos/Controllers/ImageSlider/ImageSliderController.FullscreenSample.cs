using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ImageSliderController : DemoController {
        public ActionResult FullscreenSample() {
            return DemoView("FullscreenSample");
        }
        public ActionResult FullscreenSamplePage() {
            object folder = "~/Content/Images/portraits";
            return View(folder);
        }
    }
}
