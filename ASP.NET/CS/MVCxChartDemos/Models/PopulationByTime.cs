using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExpress.Web.Demos.Charts {
    public static class PopulationProvider {
        public static List<PopulationByTime> GetPopulationValues() {
            string[] regions = new string[] { "Europe", "Americas", "Africa" };
            DateTime[] dates = new DateTime[] { new DateTime(1950, 01, 01), new DateTime(1960, 01, 01), new DateTime(1970, 01, 01),
                new DateTime(1980, 01, 01), new DateTime(1990, 01, 01), new DateTime(2000, 01, 01), new DateTime(2010, 01, 01),
                new DateTime(2020, 01, 01), new DateTime(2030, 01, 01), new DateTime(2040, 01, 01), new DateTime(2050, 01, 01)};
            Dictionary<string, double[]> values = new Dictionary<string, double[]>();
            values.Add(regions[0], new double[] { 546, 605, 656, 694, 721, 730, 728, 721, 704, 680, 650 });
            values.Add(regions[1], new double[] { 332, 417, 513, 614, 721, 836, 935, 1027, 1110, 1178, 1231 });
            values.Add(regions[2], new double[] { 227, 283, 361, 471, 623, 797, 982, 1183, 1416, 1665, 1937 });

            List<PopulationByTime> result = new List<PopulationByTime>();
            foreach (string region in regions)
                for (int i = 0; i < dates.Length; i++)
                    result.Add(new PopulationByTime(region, dates[i], values[region][i]));
            return result;
        }
    }

    public class PopulationByTime {
        string region;
        DateTime date;
        double population;

        public string Region { get { return region; } }
        public DateTime Date { get { return date; } }
        public double Population { get { return population; } }

        public PopulationByTime(string region, DateTime date, double population) {
            this.region = region;
            this.date = date;
            this.population = population;
        }
    }
}
