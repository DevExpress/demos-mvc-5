using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class DataViewController : DemoController {
        public override string Name { get { return "DataView"; } }

        public ActionResult Index() {
            return DataBinding();
        }
    }
}
