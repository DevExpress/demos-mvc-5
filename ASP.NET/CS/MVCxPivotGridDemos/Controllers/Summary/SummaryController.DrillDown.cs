using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class SummaryController : DemoController {
        public ActionResult DrillDown() {
            return DemoView("DrillDown", NorthwindDataProvider.GetCustomerReports());
        }
        public ActionResult DrillDownPivotGridPartial(bool? isResetGridViewPageIndex) {
            return PartialView("DrillDownPivotGridPartial", NorthwindDataProvider.GetCustomerReports());
        }
        public ActionResult DrillDownGridViewPartial(int? rowIndex, int? columnIndex, bool? isResetGridViewPageIndex) {
            object dataObject = null;
            if(rowIndex != null && columnIndex != null)
                dataObject = PivotGridExtension.CreateDrillDownDataSource(
                    PivotGridFeaturesDemosHelper.DrillDownPivotGridSettings,
                    NorthwindDataProvider.GetCustomerReports(), 
                    columnIndex.Value, rowIndex.Value
                );
            if(isResetGridViewPageIndex != null)
                ViewBag.IsResetGridViewPageIndex = isResetGridViewPageIndex.Value;
            return PartialView("DrillDownGridViewPartial", dataObject);
        }
    }
}
