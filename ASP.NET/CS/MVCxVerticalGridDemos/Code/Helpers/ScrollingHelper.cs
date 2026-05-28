using System.Web;
using System.Web.SessionState;

namespace DevExpress.Web.Demos {
    public class ScrollingDemoHelper {

        const string ScrollingHelperSessionName = "CB61EF44-0967-48A6-9E85-FAEDC43F82C8";

        public static ScrollingDemoOptions Options {
            get {
                if(Session[ScrollingHelperSessionName] == null)
                    Session[ScrollingHelperSessionName] = new ScrollingDemoOptions();
                return (ScrollingDemoOptions)Session[ScrollingHelperSessionName];
            }
            set { Session[ScrollingHelperSessionName] = value; }
        }
        protected static HttpSessionState Session { get { return HttpContext.Current.Session; } }
    }
}
