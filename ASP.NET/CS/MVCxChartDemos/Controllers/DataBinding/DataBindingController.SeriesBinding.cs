using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class DataBindingController : DemoController {
        [HttpGet]
        public ActionResult SeriesBinding() {
            ChartSeriesBindingDemoOptions options = new ChartSeriesBindingDemoOptions();
            string category = string.IsNullOrEmpty(options.Category) ? ChartSeriesBindingDemoOptions.DefaultCategory : options.Category;
            options.Data = NorthwindDataProvider.GetProducts(category);
            return DemoView("SeriesBinding", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SeriesBinding([Bind] ChartSeriesBindingDemoOptions options) {
            string category = string.IsNullOrEmpty(options.Category) ? ChartSeriesBindingDemoOptions.DefaultCategory : options.Category;
            options.Data = NorthwindDataProvider.GetProducts(category);
            return DemoView("SeriesBinding", options);
        }
    }
}
