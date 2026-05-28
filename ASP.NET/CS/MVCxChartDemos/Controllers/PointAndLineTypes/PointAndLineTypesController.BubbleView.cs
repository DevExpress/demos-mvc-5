using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class PointAndLineTypesController : DemoController {
        [HttpGet]
        public ActionResult BubbleView() {
            ChartBubbleDemoOptions options = new ChartBubbleDemoOptions() { Data = BubbleData.GetData(), Transparency = 90 };
            return DemoView("BubbleView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BubbleView([Bind] ChartBubbleDemoOptions options) {
            options.Data = BubbleData.GetData();
            return DemoView("BubbleView", options);
        }
    }
}
