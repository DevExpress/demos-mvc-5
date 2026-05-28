using System.ComponentModel.DataAnnotations;
using System.Web;

namespace DevExpress.Web.Demos {
    public class MailMergeViaDocumentServerOptions {
        public MailMergeViaDocumentServerOptions() {
            City = "London";
        }
        const string MailMergeViaDocumentServerOptionsKey = "MailMergeViaDocumentServerOptions";
        public static MailMergeViaDocumentServerOptions Current {
            get {
                if(HttpContext.Current.Session[MailMergeViaDocumentServerOptionsKey] == null)
                    HttpContext.Current.Session[MailMergeViaDocumentServerOptionsKey] = new MailMergeViaDocumentServerOptions();
                return (MailMergeViaDocumentServerOptions)HttpContext.Current.Session[MailMergeViaDocumentServerOptionsKey];
            }
            set { HttpContext.Current.Session[MailMergeViaDocumentServerOptionsKey] = value; }
        }
        [Display(Name = "City")]
        public string City { get; set; }
    }
}
