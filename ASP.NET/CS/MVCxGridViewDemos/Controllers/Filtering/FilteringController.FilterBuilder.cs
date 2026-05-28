using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FilteringController : DemoController {
        public ActionResult FilterBuilder() {
            ViewBag.FilterBuilderOptions = new FilterBuilderDemoOptions();
            return DemoView("FilterBuilder", NorthwindDataProvider.GetProducts());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult FilterBuilder([Bind] FilterBuilderDemoOptions options) {
            ViewBag.FilterBuilderOptions = options;
            return DemoView("FilterBuilder", NorthwindDataProvider.GetProducts());
        }
        public ActionResult FilterBuilderPartial(FilterBuilderDemoOptions options) {
            ViewBag.FilterBuilderOptions = options;
            return PartialView("FilterBuilderPartial", NorthwindDataProvider.GetProducts());
        }
    }
}

