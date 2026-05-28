using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    [ValidateInput(false)]
    public partial class AdaptivityController : DemoController {

        public override string Name { get { return "Adaptivity"; } }

        public ActionResult Index() {
            return RedirectToAction("ScrollPicker");
        }
    }
}
