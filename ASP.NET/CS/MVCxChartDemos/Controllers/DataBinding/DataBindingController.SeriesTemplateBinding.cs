using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class DataBindingController: DemoController {
        [HttpGet]
        public ActionResult SeriesTemplateBinding() {
            ChartSeriesTemplateBindingDemoOptions options = new ChartSeriesTemplateBindingDemoOptions() { Data = GDPofG7.GetData() };
            return DemoView("SeriesTemplateBinding", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SeriesTemplateBinding([Bind] ChartSeriesTemplateBindingDemoOptions options) {
            options.Data = GDPofG7.GetData();
            return DemoView("SeriesTemplateBinding", options);
        }
    }
}
