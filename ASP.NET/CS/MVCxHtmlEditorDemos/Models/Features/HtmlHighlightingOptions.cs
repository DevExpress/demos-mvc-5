using DevExpress.Web.ASPxHtmlEditor;

namespace DevExpress.Web.Demos {
    public class HtmlHighlightingOptions : BaseOptions {

        public bool ShowCollapseTagButtons { get; set; }
        public bool ShowLineNumbers { get; set; }
        public bool HighlightActiveLine { get; set; }
        public bool HighlightMatchingTags { get; set; }
        public bool EnableTagAutoClosing { get; set; }
        public bool EnableAutoCompletion { get; set; }
        public HtmlEditorHtmlEditingMode Mode { get; set; }

        public static HtmlHighlightingOptions CreateDefault() {
            HtmlHighlightingOptions result = new HtmlHighlightingOptions();
            result.Html = HtmlEditorFeaturesDemosHelper.GeHtmlContentByFileName("General.html");
            result.ActiveView = HtmlEditorView.Html;
            result.ShowCollapseTagButtons = true;
            result.ShowLineNumbers = true;
            result.HighlightActiveLine = true;
            result.HighlightMatchingTags = true;
            result.EnableTagAutoClosing = true;
            result.EnableAutoCompletion = true;
            result.Mode = HtmlEditorHtmlEditingMode.Advanced;
            return result;
        }
    }
}
