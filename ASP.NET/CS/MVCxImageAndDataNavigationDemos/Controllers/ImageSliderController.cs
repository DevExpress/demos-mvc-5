using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ImageSliderController : DemoController {
        public override string Name { get { return "ImageSlider"; } }

        public ActionResult Index() {
            return RedirectToAction("Features");
        }
    }
}
