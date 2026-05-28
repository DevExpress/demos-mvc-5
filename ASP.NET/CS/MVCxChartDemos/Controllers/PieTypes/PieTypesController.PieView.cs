using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class PieTypesController : DemoController {
        [HttpGet]
        public ActionResult PieView() {
            ChartPieDoughnutDemoOptions options = new ChartPieDoughnutDemoOptions() { Data = CountriesProvider.GetCountries(), ShowLabels = true };
            return DemoView("PieView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PieView([Bind] ChartPieDoughnutDemoOptions options) {
            options.Data = CountriesProvider.GetCountries();
            return DemoView("PieView", options);
        }
        public ActionResult PieViewPartial(ChartPieDoughnutDemoOptions options) {
            options.Data = CountriesProvider.GetCountries();
            return PartialView("PieViewPartial", options);
        }
    }
}
