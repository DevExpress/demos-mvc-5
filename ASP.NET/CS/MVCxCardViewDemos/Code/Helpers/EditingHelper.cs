using System.Collections.Generic;
using System.Web;
using System.Web.SessionState;

namespace DevExpress.Web.Demos {
    public class EditingDemosHelper {
        const string EditingModeSessionName = "E1D666FB-9692-4A88-A469-CE94D2458538";

        public static CardViewEditingMode EditMode {
            get {
                if(Session[EditingModeSessionName] == null)
                    Session[EditingModeSessionName] = CardViewEditingMode.EditForm;
                return (CardViewEditingMode)Session[EditingModeSessionName];
            }
            set { Session[EditingModeSessionName] = value; }
        }

        static List<CardViewEditingMode> availableEditModesList;
        public static List<CardViewEditingMode> AvailableEditModesList {
            get {
                if(availableEditModesList == null)
                    availableEditModesList = new List<CardViewEditingMode> {
                        CardViewEditingMode.EditForm,
                        CardViewEditingMode.PopupEditForm,
                    };
                return availableEditModesList;
            }
        }

        protected static HttpSessionState Session { get { return HttpContext.Current.Session; } }
    }
}
