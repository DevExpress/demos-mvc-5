using System.Collections.Generic;
using System.Drawing;
using DevExpress.Web.Mvc;
using DevExpress.XtraCharts;

namespace DevExpress.Web.Demos.Charts {
    public class TwoKeyColorizer : SeriesColorizerBase {
        char separator;
        Dictionary<string, int> firstKeys;
        Dictionary<string, int> secondaryKeys;
        PaletteEntry[] entries;

        public TwoKeyColorizer(char separator, Dictionary<string, int> firstKeys, Dictionary<string, int> secondaryKeys) {
            using (MVCxChartControl control = new MVCxChartControl()) {
                control.PaletteName = "Office";
                Palette palette = control.PaletteRepository[control.PaletteName];
                entries = control.GetPaletteEntries(secondaryKeys.Count * palette.Count);
            }
            this.separator = separator;
            this.firstKeys = firstKeys;
            this.secondaryKeys = secondaryKeys;
        }
        public override Color GetSeriesColor(object seriesKey, Palette palette) {
            string name = seriesKey.ToString();
            string[] keys = name.Split(separator);
            if (keys.Length == 2) {
                keys[1] = keys[1].TrimStart();
                int index1, index2;
                if (firstKeys.TryGetValue(keys[0], out index1) && secondaryKeys.TryGetValue(keys[1], out index2)) {
                    return entries[index1 + index2 * palette.Count].Color;
                }
            }
            return Color.Empty;
        }
        protected override ChartElement CreateObjectForClone() {
            return new TwoKeyColorizer(separator, firstKeys, secondaryKeys);
        }
    }

    public class MonthKeyProvider : IColorizerKeyProvider {
        object IColorizerKeyProvider.GetKey(object colorKey) {
            return string.Format("{0:MMMM}", colorKey);
        }
    }
}
