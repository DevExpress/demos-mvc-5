using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ClientSideAPIController: DemoController {
        public override string Name { get { return "ClientSideAPI"; } }

        public ActionResult Index() {
            return RedirectToAction("ManualPasteFormatting");
        }
    }
}
