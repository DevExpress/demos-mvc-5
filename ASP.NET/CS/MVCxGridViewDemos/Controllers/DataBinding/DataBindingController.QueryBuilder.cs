using System.Web.Mvc;
using System.Web.UI.WebControls;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class DataBindingController : DemoController {
        public ActionResult QueryBuilderControl() {
            return DemoView("QueryBuilderControl", GetGridDataSource());
        }
        public ActionResult QueryBuilderControlPartial() {
            return PartialView("QueryBuilderControlPartial", GetGridDataSource());
        }
        public ActionResult QueryBuilder() {
            var model = new QueryBuilderDemoModel {
                ConnectionParameters = QueryBuilderHelper.NorthwindConnectionParameters,
                SelectQuery = QueryBuilderHelper.LoadQuery(Session)
            };
            QueryBuilderHelper.HideTooltip(Session);
            return PartialView("QueryBuilder", model);
        }

        public ActionResult SaveQuery() {
            var query = QueryBuilderExtension.GetSaveCallbackResult("QueryBuilder");
            if(!string.IsNullOrEmpty(query.ErrorMessage)) {
                return Json(new { queryValidationError = query.ErrorMessage });
            } 
            Session[QueryBuilderHelper.SelectQueryKey] = query.ResultQuery;
            Session[QueryBuilderHelper.SelectCommandKey] = query.SelectStatement;
            return RedirectToAction("QueryBuilderControl");
        }

        SqlDataSource GetGridDataSource() {
            return new SqlDataSource(QueryBuilderHelper.NorthwindConnectionString, QueryBuilderHelper.LoadSelectCommand(Session));
        }
    }
}
