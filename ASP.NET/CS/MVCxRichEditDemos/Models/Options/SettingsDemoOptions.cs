using System.ComponentModel.DataAnnotations;
using System.Web;
using DevExpress.Web.ASPxRichEdit;

namespace DevExpress.Web.Demos {
    public class SettingsDemoOptions {
        const string SettingsDemoOptionsKey = "SettingsDemoOptions";
        public SettingsDemoOptions() {
            BehaviorSettings = new ASPxRichEditBehaviorSettings();
            DocumentCapabilitiesSettings = new ASPxRichEditDocumentCapabilitiesSettings();
        }

        public static SettingsDemoOptions Current {
            get {
                if(HttpContext.Current.Session[SettingsDemoOptionsKey] == null)
                    HttpContext.Current.Session[SettingsDemoOptionsKey] = new SettingsDemoOptions();
                return (SettingsDemoOptions)HttpContext.Current.Session[SettingsDemoOptionsKey];
            }
            set { HttpContext.Current.Session[SettingsDemoOptionsKey] = value; }
        }

        [Display(Name = "Behavior")]
        public ASPxRichEditBehaviorSettings BehaviorSettings { get; set; }
        [Display(Name = "Document Capabilities")]
        public ASPxRichEditDocumentCapabilitiesSettings DocumentCapabilitiesSettings { get; set; }
    }
}
