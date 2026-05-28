using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ImageZoomController: DemoController {
        public ActionResult ImageZoomNavigator() {
            return DemoView("ImageZoomNavigator", new ImageZoomNavigatorOptions());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ImageZoomNavigator([Bind] ImageZoomNavigatorOptions options) {
            return DemoView("ImageZoomNavigator", options);
        }
    }

    public class ImageZoomNavigatorOptions {
        public ImageZoomNavigatorOptions() {
        }
        public ActiveItemChangeAction ActiveItemChangeAction { get; set; }
        public NavigationButtonVisibilityMode NavigationButtonVisibility { get; set; }
    }
}
