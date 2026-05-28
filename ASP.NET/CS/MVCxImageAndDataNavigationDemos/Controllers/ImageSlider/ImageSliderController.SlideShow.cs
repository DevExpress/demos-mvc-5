using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ImageSliderController : DemoController {
        public ActionResult SlideShow() {
            return DemoView("SlideShow", new ImageSliderSlideShowDemoOptions());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SlideShow([Bind] ImageSliderSlideShowDemoOptions options) {
            return DemoView("SlideShow", options);
        }
    }
}
