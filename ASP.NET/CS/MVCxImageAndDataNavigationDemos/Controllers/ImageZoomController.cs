using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ImageZoomController: DemoController {
        public override string Name { get { return "ImageZoom"; } }
        public ActionResult Index() {
            return RedirectToAction("Features");
        }
    }
}
