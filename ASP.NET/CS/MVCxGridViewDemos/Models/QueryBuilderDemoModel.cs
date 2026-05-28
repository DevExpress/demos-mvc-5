using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;

namespace DevExpress.Web.Demos {
    public class QueryBuilderDemoModel {
        public DataConnectionParametersBase ConnectionParameters { get; set; }
        public SelectQuery SelectQuery { get; set; }
    }
}
