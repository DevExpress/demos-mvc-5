using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class DataProcessingController: DemoController {
        public override string Name { get { return "DataProcessing"; } }

        static DataProcessingController() {
            PivotGridServerModeDataGenerator.Register();
        }

        public ActionResult Index() {
            return RedirectToAction("DataBindingToLargeDatabase");
        }
    }
}
