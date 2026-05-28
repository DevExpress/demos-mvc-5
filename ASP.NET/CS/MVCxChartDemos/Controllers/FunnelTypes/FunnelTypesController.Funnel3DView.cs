using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class FunnelTypesController : DemoController {
        [HttpGet]
        public ActionResult Funnel3DView() {
            ChartFunnel3DDemoOptions options = new ChartFunnel3DDemoOptions() { Data = WebSiteVisitorsProvider.GetWebSiteVisitors(), HoleRadius = 90, PointDistance = 10, ShowLabels = true};
            return DemoView("Funnel3DView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Funnel3DView([Bind] ChartFunnel3DDemoOptions options) {
            options.Data = WebSiteVisitorsProvider.GetWebSiteVisitors();
            return DemoView("Funnel3DView", options);
        }
    }
}
