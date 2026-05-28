using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class UploadControlController : DemoController {
        public override string Name { get { return "UploadControl"; } }

        public ActionResult Index() {
            return MultiFileSelection();
        }

        public ActionResult UploadedFilesContainer(bool useExtendedPopup) {
            ViewData["UseExtendedPopup"] = useExtendedPopup;
            return PartialView("UploadedFilesContainer");
        }
    }
}
