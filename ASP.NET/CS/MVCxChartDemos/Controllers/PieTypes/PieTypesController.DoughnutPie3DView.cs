using System.Web.Mvc;
using DevExpress.Web.Demos.Charts;

namespace DevExpress.Web.Demos.Charts {
    public partial class PieTypesController : DemoController {
        [HttpGet]
        public ActionResult DoughnutPie3DView() {
            ChartPieDoughnutDemoOptions options = new ChartPieDoughnutDemoOptions() { Data = CountriesProvider.GetCountries(), HoleRadiusPercent = 50, ShowLabels = true };
            return DemoView("DoughnutPie3DView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DoughnutPie3DView([Bind] ChartPieDoughnutDemoOptions options) {
            options.Data = CountriesProvider.GetCountries();
            return DemoView("DoughnutPie3DView", options);
        }
    }
}
