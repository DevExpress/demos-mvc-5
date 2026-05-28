using System.Web;
using System.Web.SessionState;

namespace DevExpress.Web.Demos {
    public class FixedRowsDemoHelper {

        const string FixedRowsHelperSessionName = "434B45FB-B184-49DF-B356-CD647047D24E";

        public static FixedRowsDemoOptions Options {
            get {
                if(Session[FixedRowsHelperSessionName] == null)
                    Session[FixedRowsHelperSessionName] = new FixedRowsDemoOptions();
                return (FixedRowsDemoOptions)Session[FixedRowsHelperSessionName];
            }
            set { Session[FixedRowsHelperSessionName] = value; }
        }
        protected static HttpSessionState Session { get { return HttpContext.Current.Session; } }
    }
}
