using System.Text;
using System.Web.UI.WebControls;

namespace DevExpress.Web.Demos {
    public static class ListBoxDemoHelper {
        static XmlDataSource data = new XmlDataSource();
        static string modelsXPath;

        public static ListEditSelectionMode SelectionMode { get; set; }
        public static bool EnableSelectAll { get; set; }

        public static XmlDataSource GetFeatures() {
            return GetData("//Features/*");
        }
        public static XmlDataSource GetModels() {
            return GetData(modelsXPath);
        }
        public static void LoadXmlDocument(string fileName) {
            data.DataFile = fileName;
        }
        public static void ResetFiltration() {
            modelsXPath = "//Model";
        }
        public static void FilterModels(string[] selectedFeatures) {
            ResetFiltration();
            StringBuilder sb = new StringBuilder(modelsXPath);
            for(int i = 0; i < selectedFeatures.Length; i++) {
                sb.Append(i == 0 ? "[" : " and ");
                sb.AppendFormat("@{0}=\"true\"", selectedFeatures[i]);
            }
            modelsXPath = sb.Append("]").ToString();
        }

        static XmlDataSource GetData(string xPath) {
            data.XPath = xPath;
            return data;
        }
    }
}
