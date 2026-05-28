using DevExpress.Data.Internal;
using DevExpress.XtraPivotGrid.Data;

namespace DevExpress.Web.Demos {
    public class PivotGridOLAPDemosHelper {
        const string OLAPInfoURL = "https://docs.devexpress.com/AspNet/7257/aspnet-webforms-controls/pivot-grid/binding-to-data/olap-data-source/binding-to-olap-data-sources#olapproviders";

        static PivotGridOLAPDemosHelper() {
            OLAPMetaGetter.Initialize(new OLAPProviderEnumerator());
        }

        public static string OLAPConnectionString {
            get { 
                if(!OLAPMetaGetter.IsProviderAvailable)
                    return null;
                return @"Provider=msolap;Initial Catalog=Northwind;Cube Name=Northwind;Data Source=|DataDirectory|\Northwind.cub;";
            }
        }
        public static string NoProviderErrorString {
            get {
                return "To run this demo, you should have data providers used for Analysis Services connections installed on your system.<br />" +
                       "See <a href=\"" + OLAPInfoURL + "\">OLAP Requirements and Limitations</a> for details.";
            }
        }
    }
}
