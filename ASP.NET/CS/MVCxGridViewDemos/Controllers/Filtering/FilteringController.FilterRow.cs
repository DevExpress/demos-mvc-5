using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FilteringController: DemoController {
        public ActionResult FilterRow() {
            return DemoView("FilterRow", NorthwindDataProvider.GetProducts());
        }
        public ActionResult FilterRowPartial() {
            return PartialView("FilterRowPartial", NorthwindDataProvider.GetProducts());
        }
    }
}
