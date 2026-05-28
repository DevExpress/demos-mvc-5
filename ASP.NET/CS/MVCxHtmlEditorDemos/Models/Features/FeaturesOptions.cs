using DevExpress.Utils;
using DevExpress.Web.ASPxHtmlEditor;
using DevExpress.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace DevExpress.Web.Demos {
    public class FeaturesOptions : BaseOptions {
        [Display(Name = "AllowScripts")]
        public bool AllowScripts { get; set; }
        [Display(Name = "AllowIFrames")]
        public bool AllowIFrames { get; set; }
        [Display(Name = "AllowFormElements")]
        public bool AllowFormElements { get; set; }
        [Display(Name = "AllowIdAttributes")]
        public bool AllowIdAttributes { get; set; }
        [Display(Name = "AllowStyleAttributes")]
        public bool AllowStyleAttributes { get; set; }
        [Display(Name = "AllowCustomColorsInColorPickers")]
        public bool AllowCustomColorsInColorPickers { get; set; }
        [Display(Name = "UpdateDeprecatedElements")]
        public bool UpdateDeprecatedElements { get; set; }
        [Display(Name = "UpdateBoldItalic")]
        public bool UpdateBoldItalic { get; set; }
        [Display(Name = "ResourcePathMode")]
        public ResourcePathMode ResourcePathMode { get; set; }
        [Display(Name = "AllowEditFullDocument")]
        public bool AllowEditFullDocument { get; set; }
        [Display(Name = "EnterMode")]
        public HtmlEditorEnterMode EnterMode { get; set; }
        [Display(Name = "AllowContextMenu")]
        public DefaultBoolean AllowContextMenu { get; set; }
        [Display(Name = "AllowedDocumentType")]
        public AllowedDocumentType AllowedDocumentType { get; set; }
        [Display(Name = "AllowDesignView")]
        public bool AllowDesignView { get; set; }
        [Display(Name = "AllowHtmlView")]
        public bool AllowHtmlView { get; set; }
        [Display(Name = "AllowPreview")]
        public bool AllowPreview { get; set; }

        public static FeaturesOptions CreateDefault() {
            FeaturesOptions result = new FeaturesOptions();
            result.UpdateDeprecatedElements = true;
            result.UpdateBoldItalic = true;
            result.EnterMode = HtmlEditorEnterMode.P;
            result.AllowContextMenu = DefaultBoolean.True;
            result.AllowDesignView = true;
            result.AllowHtmlView = true;
            result.AllowPreview = true;
            result.AllowIdAttributes = true;
            result.AllowStyleAttributes = true;
            result.ResourcePathMode = ResourcePathMode.NotSet;
            result.AllowCustomColorsInColorPickers = true;
            result.AllowEditFullDocument = false;
            result.AllowedDocumentType = AllowedDocumentType.XHTML;
            result.Html = HtmlEditorFeaturesDemosHelper.GeHtmlContentByFileName("General.html");
            return result;
        }
    }
}
