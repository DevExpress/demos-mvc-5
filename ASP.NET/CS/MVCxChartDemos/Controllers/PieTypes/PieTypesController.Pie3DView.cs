using System.Web.Mvc;
using DevExpress.Web.Demos.Charts;

namespace DevExpress.Web.Demos.Charts {
    public partial class PieTypesController : DemoController {
        [HttpGet]
        public ActionResult Pie3DView() {
            ChartPieDoughnutDemoOptions options = new ChartPieDoughnutDemoOptions() { Data = CountriesProvider.GetCountries(), ShowLabels = true };
            return DemoView("Pie3DView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Pie3DView([Bind] ChartPieDoughnutDemoOptions options) {
            options.Data = CountriesProvider.GetCountries();
            return DemoView("Pie3DView", options);
        }
    }
}
