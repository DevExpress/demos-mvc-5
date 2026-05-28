using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PanelController : DemoController {
        public ActionResult ResponsiveLayoutWithScrolling() {
            return DemoView("ResponsiveLayoutWithScrolling");
        }
        public ActionResult ResponsiveLayoutWithScrollingPage() {
            return View("ResponsiveLayoutWithScrollingPage");
        }
        public ActionResult ResponsiveLayoutWithScrollingDataViewPartial() {
            return PartialView("ResponsiveLayoutWithScrollingDataViewPartial");            
        }
    }
}
