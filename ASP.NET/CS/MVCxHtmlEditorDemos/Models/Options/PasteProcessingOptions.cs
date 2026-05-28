using DevExpress.Web.ASPxHtmlEditor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExpress.Web.Demos {
    public class PasteProcessingOptions : BaseOptions {

        public bool AllowSaveBinaryImageToServer { get; set; }
        public bool ProcessRtfContentPastingOnServer { get; set; }
        public string[] StyleAttributes { get; set; }
        public HtmlEditorFilterMode StyleAttributeFilterMode { get; set; }

        public static PasteProcessingOptions CreateDefault() {
            PasteProcessingOptions defaultOptions = new PasteProcessingOptions();
            defaultOptions.Html = HtmlEditorFeaturesDemosHelper.GeHtmlContentByFileName("Blueberry.htm", false);
            defaultOptions.AllowSaveBinaryImageToServer = false;
            defaultOptions.ProcessRtfContentPastingOnServer = true;
            defaultOptions.StyleAttributes = new string[] { "font-size", "font-family" };
            defaultOptions.StyleAttributeFilterMode = HtmlEditorFilterMode.WhiteList;
            return defaultOptions;
        }
    }
}
