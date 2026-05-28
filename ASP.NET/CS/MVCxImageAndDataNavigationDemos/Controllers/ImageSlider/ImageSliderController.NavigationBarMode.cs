using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ImageSliderController : DemoController {
        public ActionResult NavigationBarMode() {
            ViewData["VisibleItemsCount"] = 5;
            return DemoView("NavigationBarMode");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NavigationBarMode(int visibleItemsCount) {
            ViewData["VisibleItemsCount"] = visibleItemsCount;
            return DemoView("NavigationBarMode");
        }
    }
}
