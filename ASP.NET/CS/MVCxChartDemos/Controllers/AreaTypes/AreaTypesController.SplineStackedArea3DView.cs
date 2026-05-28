using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class AreaTypesController : DemoController {
        [HttpGet]
        public ActionResult SplineStackedArea3DView() {
            ChartArea3DDemoOptions options = new ChartArea3DDemoOptions() { Data = DevAV.GetSalesByLast10Years() };
            return DemoView("SplineStackedArea3DView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SplineStackedArea3DView([Bind] ChartArea3DDemoOptions options) {
            options.Data = DevAV.GetSalesByLast10Years();
            return DemoView("SplineStackedArea3DView", options);
        }
    }
}
