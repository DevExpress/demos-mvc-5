using System.Web;
using System.Web.SessionState;

namespace DevExpress.Web.Demos {
    public class BatchEditingDemoHelper {

        const string BatchEditingHelperSessionName = "07DE028B-56CC-47C3-96CF-DA39BE6B374E";

        public static BatchEditingDemoOptions Options {
            get {
                if(Session[BatchEditingHelperSessionName] == null)
                    Session[BatchEditingHelperSessionName] = new BatchEditingDemoOptions();
                return (BatchEditingDemoOptions)Session[BatchEditingHelperSessionName];
            }
            set { Session[BatchEditingHelperSessionName] = value; }
        }
        protected static HttpSessionState Session { get { return HttpContext.Current.Session; } }
    }
}
