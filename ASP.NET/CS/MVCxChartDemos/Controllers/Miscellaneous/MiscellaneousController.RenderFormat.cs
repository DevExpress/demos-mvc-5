using System.Web.Mvc;
using DevExpress.XtraCharts.Demos;

namespace DevExpress.Web.Demos.Charts {
    public partial class MiscellaneousController : DemoController {
        SeriesDataType ConvertViewToDataType(DevExpress.XtraCharts.ViewType view) {
            switch (view) {
                case XtraCharts.ViewType.Bubble:
                    return SeriesDataType.Bubble;
                case XtraCharts.ViewType.Funnel:
                case XtraCharts.ViewType.Pie:
                case XtraCharts.ViewType.Doughnut:
                    return SeriesDataType.Funnel;
                case XtraCharts.ViewType.CandleStick:
                case XtraCharts.ViewType.Stock:
                    return SeriesDataType.Financial;
                case XtraCharts.ViewType.RangeArea:
                case XtraCharts.ViewType.RangeBar:
                case XtraCharts.ViewType.SideBySideRangeBar:
                case XtraCharts.ViewType.RadarRangeArea:
                    return SeriesDataType.Range;
                default:
                    return SeriesDataType.ArgumentValue;
            }
        }

        [HttpGet]
        public ActionResult RenderFormat() {
            ChartRenderFormatOptions options = new ChartRenderFormatOptions();
            options.SeriesView = DevExpress.XtraCharts.ViewType.CandleStick;
            options.RenderFormat = XtraCharts.Web.RenderFormat.Svg;
            options.ShowLabels = true;
            options.DataType = ConvertViewToDataType(options.SeriesView);
            options.Data = SeriesDataGenerator.GenerateSeries(options.DataType);
            return DemoView("RenderFormat", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RenderFormat([Bind] ChartRenderFormatOptions options) {
            options.DataType = ConvertViewToDataType(options.SeriesView);
            options.Data = SeriesDataGenerator.GenerateSeries(options.DataType);
            return DemoView("RenderFormat", options);
        }
    }
}
