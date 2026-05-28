using System.Web.Mvc;

namespace DevExpress.Web.Demos{
    public partial class DataBindingController: DemoController {
        public override string Name { get { return "DataBinding"; } }

        static DataBindingController() {
            EmailDataGenerator.Register();
        }

        public ActionResult Index() {
            return RedirectToAction("DataBinding");
        }
    }
}
