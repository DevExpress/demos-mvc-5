using System;
using System.Collections;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;
using DevExpress.Data;
using DevExpress.Data.Filtering;
using DevExpress.Data.Linq;
using DevExpress.Data.Linq.Helpers;

namespace DevExpress.Web.Demos {
    public static class Headphones {
        public static IEnumerable GetData(string sortField, string sortOrder) {
            var dataSource = HeadphonesDataProvider.Headphones;
            if(!string.IsNullOrEmpty(sortField)) {
                if(sortOrder == "DESC")
                    dataSource = sortField == "Model" ?
                        dataSource.OrderByDescending(x => x.Model).ToList() :
                        dataSource.OrderByDescending(x => x.Price).ToList();
                else
                    dataSource = sortField == "Model" ?
                        dataSource.OrderBy(x => x.Model).ToList() :
                        dataSource.OrderBy(x => x.Price).ToList();
            }
            return dataSource;
        }
    }
}
