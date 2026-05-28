using System.Collections.Generic;
using System.Web;
using System.Web.SessionState;

namespace DevExpress.Web.Demos {

    public class GridViewEditingDemosHelper {
        static List<GridViewEditingMode> availableEditModesList;
        public static List<GridViewEditingMode> AvailableEditModesList {
            get {
                if(availableEditModesList == null)
                    availableEditModesList = new List<GridViewEditingMode> {
                        GridViewEditingMode.Inline,
                        GridViewEditingMode.EditForm,
                        GridViewEditingMode.EditFormAndDisplayRow,
                        GridViewEditingMode.PopupEditForm
                    };
                return availableEditModesList;
            }
        }
    }
}
