using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Drawing;

namespace DevExpress.Web.Demos {
    public class DocumentProtectionDemoOptions {
        public DocumentProtectionDemoOptions() {
            User = "lawyer@somecompany.com";
            Color = Color.FromArgb(255, 254, 213);
            BracketsColor = Color.FromArgb(164, 160, 0);
            Visibility = true;
        }
        const string DocumentProtectionDemoOptionsKey = "DocumentProtectionDemoOptions";
        public static DocumentProtectionDemoOptions Current {
            get {
                if(HttpContext.Current.Session[DocumentProtectionDemoOptionsKey] == null)
                    HttpContext.Current.Session[DocumentProtectionDemoOptionsKey] = new DocumentProtectionDemoOptions();
                return (DocumentProtectionDemoOptions)HttpContext.Current.Session[DocumentProtectionDemoOptionsKey];
            }
            set { HttpContext.Current.Session[DocumentProtectionDemoOptionsKey] = value; }
        }
        [Display(Name = "User")]
        public string User { get; set; }
        [Display(Name = "Color")]
        public Color Color { get; set; }
        [Display(Name = "Brackets Color")]
        public Color BracketsColor { get; set; }
        [Display(Name = "Visibility")]
        public bool Visibility { get; set; }
    }
}
