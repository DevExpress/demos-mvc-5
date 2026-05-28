using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FilteringAndSortingController: DemoController {
        public ActionResult FilterBuilder() {
            return DemoView("FilterBuilder", NorthwindDataProvider.GetProducts());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult FilterBuilder([Bind] FilterBuilderDemoOptions options) {
            FilterBuilderDemoHelper.Options = options;
            return DemoView("FilterBuilder", NorthwindDataProvider.GetProducts());
        }
        public ActionResult FilterBuilderPartial() {
            return PartialView("FilterBuilderPartial", NorthwindDataProvider.GetProducts());
        }
    }
}
