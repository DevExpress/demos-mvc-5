using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class MiscellaneousController : DemoController {
        public ActionResult HitTesting() {
            return DemoView("HitTesting", WeatherInLondon.GetWeatherHistory());
        }
    }
}
