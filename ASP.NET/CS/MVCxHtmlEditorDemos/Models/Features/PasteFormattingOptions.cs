using DevExpress.Web.ASPxHtmlEditor;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DevExpress.Web.Demos {
    public class PasteFormattingOptions : BaseOptions {

        [Display(Name = "EnablePasteOptions")]
        public bool EnablePasteOptions { get; set; }
        [Display(Name = "PasteMode")]
        public HtmlEditorPasteMode PasteMode { get; set; }

        public static PasteFormattingOptions CreateDefault() {
            PasteFormattingOptions result = new PasteFormattingOptions();
            result.EnablePasteOptions = true;
            result.PasteMode = HtmlEditorPasteMode.SourceFormatting;
            result.Html = HtmlEditorFeaturesDemosHelper.GeHtmlContentByFileName("WebApp.html");
            return result;
        }
    }
}
