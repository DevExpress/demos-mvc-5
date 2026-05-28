using System.Web.Mvc;

namespace DevExpress.Web.Demos{
    public partial class DataBindingAndSummariesController: DemoController {
        public override string Name { get { return "DataBindingAndSummaries"; } }

        static DataBindingAndSummariesController() {
            EmailDataGenerator.Register();
        }

        public ActionResult Index() {
            return RedirectToAction("DataBinding");
        }
    }
}
