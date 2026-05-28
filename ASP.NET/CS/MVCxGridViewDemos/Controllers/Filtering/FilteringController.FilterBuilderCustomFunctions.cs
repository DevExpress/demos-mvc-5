using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FilteringController : DemoController {
        public ActionResult FilterBuilderCustomFunctions() {
            IsSalesDiscountFunction.Register();
            DoesNotBeginWithFunction.Register();
            IsWeekendFunction.Register();

            return DemoView("FilterBuilderCustomFunctions", NorthwindDemoDataProvider.GetInvoices());
        }
        public ActionResult FilterBuilderCustomFunctionsPartial() {
            return PartialView("FilterBuilderCustomFunctionsPartial", NorthwindDemoDataProvider.GetInvoices());
        }
    }
}

