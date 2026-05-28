using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class PieTypesController : DemoController {
        [HttpGet]
        public ActionResult DoughnutPieView() {
            ChartPieDoughnutDemoOptions options = new ChartPieDoughnutDemoOptions() { Data = CountriesProvider.GetCountries(), HoleRadiusPercent = 60, ShowLabels = true};
            return DemoView("DoughnutPieView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DoughnutPieView([Bind] ChartPieDoughnutDemoOptions options) {
            options.Data = CountriesProvider.GetCountries();
            return DemoView("DoughnutPieView", options);
        }
        public ActionResult DoughnutPieViewPartial(ChartPieDoughnutDemoOptions options) {
            options.Data = CountriesProvider.GetCountries();
            return PartialView("DoughnutPieViewPartial", options);
        }
    }
}
