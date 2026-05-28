using System.Web.Mvc;
using DevExpress.Web.Mvc;
using DevExpress.Web.Office;

namespace DevExpress.Web.Demos {
    public partial class DocumentManagementController : DemoController {
        public ActionResult DocumentProtection() {
            return DemoView("DocumentProtection", DocumentProtectionDemoOptions.Current);
        }
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult DocumentProtection([Bind] DocumentProtectionDemoOptions options) {
            DocumentProtectionDemoOptions.Current = options;
            string documentId = RichEditExtension.GetDocumentId("RichEdit");
            if(!string.IsNullOrEmpty(documentId))
                DocumentManager.FindDocument(documentId).Close();
            return DemoView("DocumentProtection", DocumentProtectionDemoOptions.Current);
        }
        public ActionResult DocumentProtectionPartial() {
            return PartialView("DocumentProtectionPartial", DocumentProtectionDemoOptions.Current);
        }
    }
}
