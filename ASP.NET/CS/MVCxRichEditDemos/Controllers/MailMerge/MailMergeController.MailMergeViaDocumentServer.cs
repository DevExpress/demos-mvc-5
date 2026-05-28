using System.Web.Mvc;
using DevExpress.XtraRichEdit;
using System.IO;
using DevExpress.Web.Office;

namespace DevExpress.Web.Demos {
    public partial class MailMergeController : DemoController {
        public ActionResult MailMergeViaDocumentServer() {
            return MailMergeViaDocumentServer(MailMergeViaDocumentServerOptions.Current);
        }

        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult MailMergeViaDocumentServer([Bind] MailMergeViaDocumentServerOptions options) {
            MailMergeViaDocumentServerOptions.Current = options;

            using(RichEditDocumentServer documentServer = new RichEditDocumentServer()) {
                documentServer.LoadDocument(Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, @"MailMergeTemplate.docx"));
                documentServer.Options.MailMerge.DataSource = NorthwindContextProvider.GetEmployeesByCity(options.City);
                MemoryStream stream = new MemoryStream();
                documentServer.MailMerge(stream, DocumentFormat.OpenXml);
                stream.Position = 0;
                DocumentManager.CloseDocument("mailMergeDocId");
                ViewBag.Document = stream;
            }
            return DemoView("MailMergeViaDocumentServer", MailMergeViaDocumentServerOptions.Current);
        }

        public ActionResult MailMergeViaDocumentServerPartial() {
            return DemoView("MailMergeViaDocumentServerPartial", MailMergeViaDocumentServerOptions.Current);
        }
    }
}
