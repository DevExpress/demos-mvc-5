using System.Web.Mvc;
using DevExpress.Web.Mvc;
using DevExpress.Web.Office;

namespace DevExpress.Web.Demos {
    public partial class DocumentManagementController : DemoController {
        public ActionResult Settings() {
            return DemoView("Settings", SettingsDemoOptions.Current);
        }
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Settings([Bind] SettingsDemoOptions options) {
            SettingsDemoOptions.Current = options;
            string documentId = RichEditExtension.GetDocumentId("RichEdit");
            if(!string.IsNullOrEmpty(documentId))
                DocumentManager.FindDocument(documentId).Close();
            return DemoView("Settings", SettingsDemoOptions.Current);
        }
        public ActionResult SettingsPartial() {
            return PartialView("SettingsPartial", SettingsDemoOptions.Current);
        }
    }
}
