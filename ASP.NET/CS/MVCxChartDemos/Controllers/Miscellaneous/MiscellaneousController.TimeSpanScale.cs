using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class MiscellaneousController : DemoController {
        public ActionResult TimeSpanScale() {
            return DemoView("TimeSpanScale", new ChartTimeSpanScaleDemoOptions() {
                Data = XMLUtils.LoadDataTableFromXml("BostonMarathon.xml", "Athlete")
            });
        }
        public ActionResult TimeSpanScalePartial() {
            return PartialView("TimeSpanScalePartial", new ChartTimeSpanScaleDemoOptions() {
                Data = XMLUtils.LoadDataTableFromXml("BostonMarathon.xml", "Athlete")
            });
        }
    }
}
