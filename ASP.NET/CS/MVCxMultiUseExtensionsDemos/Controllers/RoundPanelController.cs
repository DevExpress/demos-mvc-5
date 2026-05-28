using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class RoundPanelController: DemoController {
        public override string Name { get { return "RoundPanel"; } }

        public ActionResult Index() {
            return Features();
        }
    }
}
