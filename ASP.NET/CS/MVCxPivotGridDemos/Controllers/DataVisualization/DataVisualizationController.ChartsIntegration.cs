using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class DataVisualizationController: DemoController {
        [HttpGet]
        public ActionResult ChartsIntegration() {
            Session["DemoOptions"] = new PivotGridChartIntegrationDemoOptions();
            return DemoView("ChartsIntegration", NorthwindDataProvider.GetSalesPerson());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChartsIntegration([Bind]PivotGridChartIntegrationDemoOptions options) {
            Session["DemoOptions"] = options;
            return DemoView("ChartsIntegration", NorthwindDataProvider.GetSalesPerson());
        }
        public ActionResult ChartsIntegrationPivotPartial() {
            return PartialView("ChartsIntegrationPivotPartial", NorthwindDataProvider.GetSalesPerson());
        }
        public ActionResult ChartsIntegrationChartPartial() {
            var chartModel = PivotGridExtension.GetDataObject(PivotGridDataOutputDemosHelper.PivotChartIntegrationSettings(), NorthwindDataProvider.GetSalesPerson());
            return PartialView("ChartsIntegrationChartPartial", chartModel);
        }
    }
}
