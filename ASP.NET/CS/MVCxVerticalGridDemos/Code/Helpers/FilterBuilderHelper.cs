using System.Web;
using System.Web.SessionState;

namespace DevExpress.Web.Demos {
    public class FilterBuilderDemoHelper {
        const string FilterBuilderOptionsSessionName = "10B3D706-7CAD-41D4-BB0D-3332A3037059";

        public static FilterBuilderDemoOptions Options {
            get {
                if(Session[FilterBuilderOptionsSessionName] == null)
                    Session[FilterBuilderOptionsSessionName] = new FilterBuilderDemoOptions();
                return (FilterBuilderDemoOptions)Session[FilterBuilderOptionsSessionName];
            }
            set { Session[FilterBuilderOptionsSessionName] = value; }
        }
        protected static HttpSessionState Session { get { return HttpContext.Current.Session; } }
    }
}
