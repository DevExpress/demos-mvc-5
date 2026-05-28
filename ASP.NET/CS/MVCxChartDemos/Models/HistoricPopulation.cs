using System.Collections.Generic;

namespace DevExpress.Web.Demos.Charts {
    public static class HistoricPopulationModel {
        public static IList<HistoricPopulation> GetData() {
            List<HistoricPopulation> historicPopulationList = new List<HistoricPopulation>() {
                new HistoricPopulation { Year = "1950", Population = 227 },
                new HistoricPopulation { Year = "1970", Population = 361 },
                new HistoricPopulation { Year = "1990", Population = 623 },
                new HistoricPopulation { Year = "2010", Population = 982 },
                new HistoricPopulation { Year = "2030", Population = 1416 }
            };
            return historicPopulationList;
        }
    }
    public class HistoricPopulation {
        public string Year { get; set; }
        public double Population { get; set; }
    }
}
