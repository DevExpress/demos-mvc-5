using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web.UI.WebControls;
using DevExpress.Drawing;
using DevExpress.Web.Mvc;
using DevExpress.XtraCharts;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;

namespace DevExpress.Web.Demos {
    public static class DocVariableDemoHelper {
        public static decimal GetCommonSales(string categoryName) {
            return GetSales(categoryName).Sum(s => s.ProductSales.Value);
        }
        public static Document GetDocumentWithChart(string categoryName) {
            DocumentImageSource chart = DocumentImageSource.FromStream(CreateChart(categoryName));
            RichEditDocumentServer richServer = new RichEditDocumentServer();
            richServer.Document.Images.Append(chart);
            return richServer.Document;
        }

        static IEnumerable<Sales_by_Category> GetSales(string categoryName) {
            using(var context = new NorthwindContext()) {
                return context.Sales_by_Categories.Where(s => s.CategoryName == categoryName).ToArray();
            }
        }

        static Stream CreateChart(string categoryName) {
            IEnumerable<Sales_by_Category> sales = GetSales(categoryName);
            ChartControlSettings settings = CreateChartSettings();
            MemoryStream stream = new MemoryStream();
            
            ChartControlExtension.ExportToImage(settings, sales, DXImageFormat.Png, stream);
            stream.Position = 0;
            return stream;
        }

        static ChartControlSettings CreateChartSettings() {
            ChartControlSettings settings = new ChartControlSettings();
            settings.Name = "Chart";
            settings.Width = Unit.Pixel(600);
            settings.Height = Unit.Pixel(400);
            settings.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            
            var series = new Series("Products", ViewType.Bar);
            series.ArgumentDataMember = "ProductName";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "ProductSales" });
            settings.Series.Add(series);
            return settings;
        }
    }
}
