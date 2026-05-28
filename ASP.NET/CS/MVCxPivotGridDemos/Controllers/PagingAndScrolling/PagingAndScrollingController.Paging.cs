using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PagingAndScrollingController: DemoController {

        [HttpGet]
        public ActionResult Paging() {
            Session["DemoOptions"] = new PivotGridPagingDemoOptions();
            return DemoView("Paging", NorthwindDataProvider.GetCustomerReports());
        }        
        public ActionResult PagingPartial() {
            return PartialView("PagingPartial", NorthwindDataProvider.GetCustomerReports());
        }
        public ActionResult PagingPartialCustom(PivotGridPagingDemoOptions options) {
            Session["DemoOptions"] = options;
            return PartialView("PagingPartial", NorthwindDataProvider.GetCustomerReports());
        }
    }
}
