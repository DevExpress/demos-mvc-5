using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class HintController : DemoController {
        public ActionResult ChoosingSeat() {
            return DemoView("ChoosingSeat");
        }
    }
}
