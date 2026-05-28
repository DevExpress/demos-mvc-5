using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class AreaTypesController : DemoController {
        [HttpGet]
        public ActionResult StackedArea3DView() {
            ChartArea3DDemoOptions options = new ChartArea3DDemoOptions() { Data = DevAV.GetSalesByLast10Years() };
            return DemoView("StackedArea3DView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult StackedArea3DView([Bind] ChartArea3DDemoOptions options) {
            options.Data = DevAV.GetSalesByLast10Years();
            return DemoView("StackedArea3DView", options);
        }
    }
}
