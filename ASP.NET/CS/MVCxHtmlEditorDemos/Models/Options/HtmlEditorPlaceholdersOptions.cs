namespace DevExpress.Web.Demos {
    public class HtmlEditorPlaceholdersDemoOptions {
        public HtmlEditorPlaceholdersDemoOptions() {
            TemplateDocumentHtml = HtmlEditorFeaturesDemosHelper.GeHtmlContentByFileName("TemplateHtml.html");
            DocumentHtml = string.Empty;
            ListEditItems = new ListEditItemCollection();
        }
        public string TemplateDocumentHtml { get; set; }
        public string DocumentHtml { get; set; }
        public ListEditItemCollection ListEditItems { get; set; }
    }
}
