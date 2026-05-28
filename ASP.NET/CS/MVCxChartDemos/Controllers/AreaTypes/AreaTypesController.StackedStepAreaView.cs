using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class AreaTypesController : DemoController {
        [HttpGet]
        public ActionResult StackedStepAreaView() {
            ChartStepAreaDemoOptions options = new ChartStepAreaDemoOptions() { Data = CommentsInSite.GetCommentsValues() };
            return DemoView("StackedStepAreaView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult StackedStepAreaView([Bind] ChartStepAreaDemoOptions options) {
            options.Data = CommentsInSite.GetCommentsValues();
            return DemoView("StackedStepAreaView", options);
        }
    }
}
