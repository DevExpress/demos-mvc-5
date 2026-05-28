using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ApplicationScenariosController : DemoController {
        public ActionResult DynamicSheetGeneration() {
            LoanAmortizationScheduleProvider.InitializeParameters();
            return DemoView("DynamicSheetGeneration", LoanAmortizationScheduleProvider.Parameters);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DynamicSheetGeneration([Bind] LoanAmortizationScheduleParameters parameters) {
            LoanAmortizationScheduleProvider.Parameters = parameters;
            return DemoView("DynamicSheetGeneration", parameters);
        }
        public ActionResult DynamicSheetGenerationPartial() {
            return PartialView("DynamicSheetGenerationPartial");
        }
    }
}
