using System.Web;
using System.Web.SessionState;

namespace DevExpress.Web.Demos {
    public class PagingAndScrollingHelper {
        const string PagingAndScrollingHelperSessionName = "F6A2EC85-70E0-47FE-BD56-9770C0D12D3A";

        public static PagingAndScrollingOptions Options {
            get {
                if(Session[PagingAndScrollingHelperSessionName] == null)
                    Session[PagingAndScrollingHelperSessionName] = new PagingAndScrollingOptions();
                return (PagingAndScrollingOptions)Session[PagingAndScrollingHelperSessionName];
            }
            set { Session[PagingAndScrollingHelperSessionName] = value; }
        }
        protected static HttpSessionState Session { get { return HttpContext.Current.Session; } }
    }
}
