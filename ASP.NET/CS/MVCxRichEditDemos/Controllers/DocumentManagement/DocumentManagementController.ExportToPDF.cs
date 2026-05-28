using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class DocumentManagementController : DemoController {
        public ActionResult ExportToPDF() {
            return DemoView("ExportToPDF");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ExportFile() {
            if (IsExportAction())
                return RichEditExtension.ExportToPDF("RichEdit", "ExportedDocument");
            return ExportToPDFPartial();
        }
        public ActionResult ExportToPDFPartial() {
            return PartialView("ExportToPDFPartial");
        }
        bool IsExportAction() {
            return Request.Params["Export"] != null;
        }
    }
}
