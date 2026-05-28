using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class MiscellaneousController : DemoController {
        public ActionResult DrillDown() {
            ChartDrillDownDemoOptions options = new ChartDrillDownDemoOptions();
            options.Data = DevAV.GetTotalSales();
            return DemoView("DrillDown", options);
        }
        public ActionResult DrillDownPartial([Bind] ChartDrillDownDemoOptions options) {
            options.Data = DevAV.GetTotalSales();
            return PartialView("DrillDownPartial", options);
        }
    }
}
