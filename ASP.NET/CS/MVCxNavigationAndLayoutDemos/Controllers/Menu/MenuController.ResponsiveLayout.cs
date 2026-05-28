using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class MenuController : DemoController {
        public ActionResult ResponsiveLayout() {
            return DemoView("ResponsiveLayout");
        }
        public ActionResult ResponsiveLayoutPage() {
            return View("ResponsiveLayoutPage");
        }
    }
}
