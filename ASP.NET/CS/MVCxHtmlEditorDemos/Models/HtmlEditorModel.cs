using System.Collections.Generic;

namespace DevExpress.Web.Demos {
    public class HtmlEditorModel {
        public HtmlEditorModel(string html) : this(html, null) { }
        public HtmlEditorModel(string html, IEnumerable<string> cssFiles) {
            Html = html;
            CssFiles = cssFiles;
        }

        public string Html { get; set; }
        public IEnumerable<string> CssFiles { get; set; }
    }
}
