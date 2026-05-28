using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AdaptivityController: DemoController {
        public override string Name { get { return "Adaptivity"; } }

        public ActionResult Index() {
            return View();
        }
    }
}
