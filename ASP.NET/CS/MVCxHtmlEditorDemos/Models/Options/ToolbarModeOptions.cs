using DevExpress.Web.ASPxHtmlEditor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExpress.Web.Demos {
    public class ToolbarModeOptions : BaseOptions {

        public string ToolbarModeString { get; set; }
        public bool IsRibbonOneLineMode { get { return ToolbarModeString == "OneLineRibbon"; } }
        public HtmlEditorToolbarMode ToolbarMode {
            get {
                if (string.IsNullOrEmpty(ToolbarModeString))
                    return HtmlEditorToolbarMode.Menu;
                return IsRibbonOneLineMode ? HtmlEditorToolbarMode.Ribbon : (HtmlEditorToolbarMode)Enum.Parse(typeof(HtmlEditorToolbarMode), ToolbarModeString);
            }
        }

        public static ToolbarModeOptions CreateDefault() {
            ToolbarModeOptions result = new ToolbarModeOptions();
            result.ToolbarModeString = HtmlEditorToolbarMode.Menu.ToString();
            result.Html = System.IO.File.ReadAllText(HttpContext.Current.Server.MapPath("~/Content/HtmlEditor/DemoHtml/ComboBox.html"));
            return result;
        }
    }
}
