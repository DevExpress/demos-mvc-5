using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public class GridViewRowsDemosHelper {
        public const string ImageQueryKey = "DXImage";

        public static string GetEmployeeImageRouteUrl() {
            return DevExpressHelper.GetUrl(new {
                Controller = "Rows",
                Action = "EmployeeImage"
            });
        }
    }
}
