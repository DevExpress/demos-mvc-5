namespace DevExpress.Web.Demos {
    public class HtmlEditorInsertMediaContentDemoOptions {
        public HtmlEditorInsertMediaContentDemoOptions() {
            AllowHTML5MediaElements = true;
            AllowObjectAndEmbedElements = true;
            AllowYouTubeVideoIFrames = true;
        }
        public bool AllowHTML5MediaElements { get; set; }
        public bool AllowObjectAndEmbedElements { get; set; }
        public bool AllowYouTubeVideoIFrames { get; set; }
    }
}
