using System.Web;
using System.Web.SessionState;

namespace DevExpress.Web.Demos {
    public class BatchEditingDemoHelper {

        const string BatchEditingHelperSessionName = "A8E558C7-66F3-4DB3-82C7-6C819DEF418F";

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
