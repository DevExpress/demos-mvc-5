using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FeaturesController : DemoController {
        public ActionResult SortingAndAutoFilter() {
            return DemoView("SortingAndAutoFilter");
        }
        public ActionResult SortingAndAutoFilterPartial() {
            return PartialView("SortingAndAutoFilterPartial");
        }
    }
}
