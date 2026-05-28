using System.ComponentModel.DataAnnotations;
using System.Web;

namespace DevExpress.Web.Demos {
    public class ContextMenuCustomizationDemoOptions {
        public ContextMenuCustomizationDemoOptions() {
            ShowContextMenu = true;
            ShowDefaultItems = false;
        }
        const string ContextMenuCustomizationDemoOptionsKey = "ContextMenuCustomizationDemoOptions";
        public static ContextMenuCustomizationDemoOptions Current {
            get {
                if(HttpContext.Current.Session[ContextMenuCustomizationDemoOptionsKey] == null)
                    HttpContext.Current.Session[ContextMenuCustomizationDemoOptionsKey] = new ContextMenuCustomizationDemoOptions();
                return (ContextMenuCustomizationDemoOptions)HttpContext.Current.Session[ContextMenuCustomizationDemoOptionsKey];
            }
            set { HttpContext.Current.Session[ContextMenuCustomizationDemoOptionsKey] = value; }
        }
        
        [Display(Name = "ShowContextMenu")]
        public bool ShowContextMenu { get; set; }
        [Display(Name = "ShowDefaultItems")]
        public bool ShowDefaultItems { get; set; }
    }
}
