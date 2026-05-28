using System.Web.Mvc;
using DevExpress.Web.ASPxHtmlEditor;
using DevExpress.Web.Mvc;
using System.Collections.Generic;
using System.Threading;
namespace DevExpress.Web.Demos {
    public partial class ToolbarsAndUIController: DemoController {
        const string SessionName = "DocumentsDictionary";
        
        public ActionResult ExternalRibbon() {
            return DemoView("ExternalRibbon", DocumentsDictionary.Keys);
        }
        public ActionResult ExternalRibbonPartial() {
            if(DevExpressHelper.IsCallback)
                // Intentionally pauses server-side processing,
                // to demonstrate the Loading Panel functionality.
                Thread.Sleep(500);
            return PartialView("ExternalRibbonPartial");
        }
        public ActionResult ExternalRibbonHtmlContentLoad(bool saveChanges, string documentName) {
            Thread.Sleep(500);
            if(saveChanges)
                DocumentsDictionary[documentName] = HtmlEditorExtension.GetHtml("htmlEditor");
            return HtmlEditorExtension.GetCustomDataCallbackResult(DocumentsDictionary[documentName]);
        }

        public Dictionary<string, string> DocumentsDictionary {
            get {
                if(Session[SessionName] == null)
                    Session[SessionName] = CreateDocumentsDictionary();
                return (Dictionary<string, string>)Session[SessionName];
            }
        }
        Dictionary<string, string> CreateDocumentsDictionary() {
            return new Dictionary<string, string>() {
                {"Halloween", HtmlEditorFeaturesDemosHelper.GeHtmlContentByFileName("ComboBox.html")},
                {"Blueberry", HtmlEditorFeaturesDemosHelper.GeHtmlContentByFileName("Blueberry.htm", false)},
                {"Fragaria", HtmlEditorFeaturesDemosHelper.GeHtmlContentByFileName("General.html")},
                {"Mushroom", HtmlEditorFeaturesDemosHelper.GeHtmlContentByFileName("CustomToolbar.html")}
            };
        }
    }
}
