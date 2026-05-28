using System;
using System.Collections.Generic;
using System.Web;
using System.Web.SessionState;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public class DataViewDemoHelper {
        const string EndlessPagingSessionName = "C84A24F1-B18A-8205-55C3-743D3FE5C16D";
        public static DataViewEndlessPagingMode EndlessPagingMode {
            get {
                if(Session[EndlessPagingSessionName] == null)
                    Session[EndlessPagingSessionName] = GridViewEditingMode.EditFormAndDisplayRow;
                return (DataViewEndlessPagingMode)Session[EndlessPagingSessionName];
            }
            set { HttpContext.Current.Session[EndlessPagingSessionName] = value; }
        }
        public static IList<string> EndlessPagingModeTextList {
            get {
                return new List<string>() {
                    Enum.GetName(typeof(DataViewEndlessPagingMode), DataViewEndlessPagingMode.OnClick),
                    Enum.GetName(typeof(DataViewEndlessPagingMode), DataViewEndlessPagingMode.OnScroll)
                };
            }
        }
        protected static HttpSessionState Session { get { return HttpContext.Current.Session; } }
        public static List<SelectListItem> GetSortFields() {
            return new List<SelectListItem>() {
                new SelectListItem() { Text = "(none)", Value = "", Selected = true },
                new SelectListItem() { Text = "Model", Value = "Model" },
                new SelectListItem() { Text = "Price", Value = "Price" }
            };
        }
        public static List<SelectListItem> GetSortOrders() {
            return new List<SelectListItem>() {
                new SelectListItem() { Text = "Ascending", Value = "", Selected = true },
                new SelectListItem() { Text = "Descending", Value = "DESC" }
            };
        }
    }
}
