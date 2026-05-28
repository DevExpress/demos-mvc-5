using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class FunnelTypesController : DemoController {
        [HttpGet]
        public ActionResult FunnelView() {
            ChartFunnel2DDemoOptions options = new ChartFunnel2DDemoOptions() { Data = WebSiteVisitorsProvider.GetWebSiteVisitors(), HeightToWidthRatioAuto = false, ShowLabels = true };
            return DemoView("FunnelView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult FunnelView([Bind] ChartFunnel2DDemoOptions options) {
            options.Data = WebSiteVisitorsProvider.GetWebSiteVisitors();
            return DemoView("FunnelView", options);
        }
    }
}
