using System.Configuration;
using System.Web;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
using DevExpress.Internal;

namespace DevExpress.Web.Demos {
    public static class QueryBuilderHelper {

        public const string ShowTooltipKey = "ShowTooltip";
        public const string SelectQueryKey = "SelectQuery";
        public const string SelectCommandKey = "SelectCommand";
        static readonly string DefaultSelectCommand =
    @"select [Suppliers].[CompanyName],[Suppliers].[ContactName],[Suppliers].[City],
    		[Suppliers].[Country],[Products].[ProductName],[Products].[UnitPrice]
    from [dbo].[Suppliers] [Suppliers]
    inner join [dbo].[Products] [Products] on [Products].[SupplierID] = [Suppliers].[SupplierID]";

        static SelectQuery GenerateDefaultQuery() {
            return SelectQueryFluentBuilder
                .AddTable("Suppliers")
                .SelectColumns("CompanyName", "ContactName", "City", "Country")
                .Join("Products", DevExpress.DataAccess.Sql.SqlJoinType.LeftOuter, "SupplierID", "SupplierID")
                .SelectColumns("ProductName", "UnitPrice")
                .Build("Query1");
        }

        public static string NorthwindConnectionString {
            get {
                string sqlExpressString = ConfigurationManager.ConnectionStrings["NorthwindConnectionString"].ConnectionString;
                return Utils.PatchConnectionStrings ? DbEngineDetector.PatchConnectionString(sqlExpressString) : sqlExpressString;
            }
        }

        public static CustomStringConnectionParameters NorthwindConnectionParameters {
            get {
                return new CustomStringConnectionParameters(NorthwindConnectionString + ";XpoProvider=MSSqlServer");
            }
        }

        public static SelectQuery LoadQuery(HttpSessionStateBase session) {
            return (session[SelectQueryKey] as SelectQuery) ?? GenerateDefaultQuery();
        }

        public static string LoadSelectCommand(HttpSessionStateBase session) {
            return (session[SelectCommandKey] as string) ?? DefaultSelectCommand;
        }

        public static void SaveQuery(string selectCommand, SelectQuery query, HttpSessionStateBase session) {
            session[SelectQueryKey] = query;
            session[SelectCommandKey] = selectCommand;
        }

        public static void HideTooltip(HttpSessionStateBase session) {
            session[ShowTooltipKey] = false;
        }

        public static bool NeedToShowTooltip(HttpSessionStateBase session) {
            var showTooltipValue = session[ShowTooltipKey];
            return showTooltipValue is bool ? (bool)showTooltipValue : true;
        }
    }
}
