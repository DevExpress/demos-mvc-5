using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class HintController: DemoController {
        public override string Name { get { return "Hint"; } }

        public ActionResult Index() {
            return Features();
        }
    }
}
