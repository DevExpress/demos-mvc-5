using System.Collections;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;
using System.Data;

namespace DevExpress.Web.Demos.Charts {
    public class GDPofG7 {
        public static IList GetData() {
            DataTable data = XMLUtils.LoadDataTableFromXml("GDPofG7.xml", "GDP");
            return data.AsEnumerable()
                .Where(row => row.Field<int>("Year") >= 2010)
                .Select(row => new {
                    Country = row.Field<string>("Country"),
                    Year = row.Field<int>("Year"),
                    Product = row.Field<double>("Product")
                }).ToList();
        }
    }
}
