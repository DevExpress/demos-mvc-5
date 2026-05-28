using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class AreaTypesController : DemoController {
        [HttpGet]
        public ActionResult FullStackedStepAreaView() {
            ChartStepAreaFullStckedDemoOptions options = new ChartStepAreaFullStckedDemoOptions() { Data = CommentsInSite.GetCommentsValues() };
            return DemoView("FullStackedStepAreaView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult FullStackedStepAreaView([Bind] ChartStepAreaFullStckedDemoOptions options) {
            options.Data = CommentsInSite.GetCommentsValues();
            return DemoView("FullStackedStepAreaView", options);
        }
    }
}
