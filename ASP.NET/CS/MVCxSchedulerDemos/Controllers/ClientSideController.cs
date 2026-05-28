using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ClientSideController: DemoController {
        public override string Name { get { return "ClientSide"; } }

        public ActionResult Index() {
            return RedirectToAction("AppointmentsSelection");
        }
    }
}
