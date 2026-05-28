using System.Collections.Generic;
using System.Web;
using System.Web.SessionState;

namespace DevExpress.Web.Demos {
    public class PagerDemoHelper {
        const string PagerOptionsSessionName = "AABB4AB7-6684-4FEF-9D04-BAC95E586E32";

        public static PagerDemoOptions Options {
            get {
                if(Session[PagerOptionsSessionName] == null)
                    Session[PagerOptionsSessionName] = new PagerDemoOptions();
                return (PagerDemoOptions)Session[PagerOptionsSessionName];
            }
            set { Session[PagerOptionsSessionName] = value; }
        }
        protected static HttpSessionState Session { get { return HttpContext.Current.Session; } }
    }
}
