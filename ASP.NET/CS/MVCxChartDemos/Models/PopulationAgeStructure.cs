using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using DevExpress.Web.Demos.Charts;

namespace DevExpress.Web.Demos.Charts {
    public class AgeStructure {
        static DataTable ageStructureTable;
        static DataTable AgeStructureTable {
            get {
                if (ageStructureTable == null)
                    ageStructureTable = LoadPopulationAgeStructure();
                return ageStructureTable;
            }
        }

        static DataTable LoadPopulationAgeStructure() {  // data for end of 2016
            return XMLUtils.LoadDataTableFromXml("Population.xml", "Population");
        }
        public static IList GetDataByAgeAndGender() {
            return AgeStructureTable.AsEnumerable()
                .Select(row => new {
                    GenderAge = new GenderAgeInfo(row.Field<string>("Gender"), row.Field<string>("Age")),
                    Country = row.Field<string>("Country"),
                    Population = row.Field<long>("Population")
                }).ToList();
        }
        public static IList GetDataByMaleAge() {
            return AgeStructureTable.AsEnumerable()
                .Where(row => row.Field<string>("Gender") == "Male")
                .Select(row => new {
                    Age = row.Field<string>("Age"),
                    Country = row.Field<string>("Country"),
                    Population = row.Field<long>("Population")
                }).ToList();
        }
        public static IList GetDataByFemaleAge() {
            return AgeStructureTable.AsEnumerable()
                .Where(row => row.Field<string>("Gender") == "Female")
                .Select(row => new {
                    Age = row.Field<string>("Age"),
                    Country = row.Field<string>("Country"),
                    Population = row.Field<long>("Population")
                }).ToList();
        }
        internal static IList GetGenderAgeItemsWithPopulation() {
            return AgeStructureTable.AsEnumerable()
                .Select(row => new {
                    GenderAge = new GenderAgeInfo(row.Field<string>("Gender"), row.Field<string>("Age")),
                    Country = row.Field<string>("Country"),
                    Population = row.Field<long>("Population"),
                    PopulationString = row.Field<long>("Population").ToString("0,,.00")
                }).ToList();
        }
        public static IList GetPopulationAgeStructure() {
            return AgeStructureTable.AsEnumerable()
                .Select(row => new AgePopulation(row.Field<string>("Country"), row.Field<string>("Age"), row.Field<string>("Gender"), row.Field<long>("Population"))).ToList();
        }
    }
    public struct GenderAgeInfo {
        string gender;
        string age;

        public string Gender { get { return gender; } }
        public string Age { get { return age; } }

        public GenderAgeInfo(string gender, string age) {
            this.gender = gender;
            this.age = age;
        }
        public override string ToString() {
            return gender + ": " + age;
        }
    }
    public class AgePopulation {
        string name;
        string age;
        string gender;
        double population;

        public string Name { get { return name; } }
        public string Age { get { return age; } }
        public string Gender { get { return gender; } }
        public string GenderAgeKey { get { return gender.ToString() + ": " + age; } }
        public string CountryAgeKey { get { return name + ": " + age; } }
        public string CountryGenderKey { get { return name + ": " + gender.ToString(); } }
        public double Population { get { return population; } }

        public AgePopulation(string name, string age, string gender, double population) {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.population = population;
        }
    }

    public enum Gender {
        Male,
        Female
    }

    public static class PopulationAgeProvider {
        static IList<AgePopulation> GetAllPopulationAgeStructure() {
            string[] countries = new string[] { "United States", "Brazil", "Russia", "Japan", "Mexico", "Germany", "United Kingdom" };
            string[] ageCategories = new string[] { "0-14 years", "15-64 years", "65 years and older" };

            Dictionary<Gender, Dictionary<string, double[]>> population = new Dictionary<Gender, Dictionary<string, double[]>>();

            Dictionary<string, double[]> males = new Dictionary<string, double[]>();
            males.Add(ageCategories[0], new double[] { 29.956, 25.607, 13.493, 9.575, 17.306, 6.679, 5.816 });
            males.Add(ageCategories[1], new double[] { 90.354, 55.793, 48.983, 43.363, 30.223, 28.638, 19.622 });
            males.Add(ageCategories[2], new double[] { 14.472, 3.727, 5.802, 9.024, 1.927, 5.133, 3.864 });
            population.Add(Gender.Male, males);
            Dictionary<string, double[]> females = new Dictionary<string, double[]>();
            females.Add(ageCategories[0], new double[] { 28.597, 24.67, 12.971, 9.105, 16.632, 6.333, 5.519 });
            females.Add(ageCategories[1], new double[] { 91.827, 57.598, 52.14, 42.98, 31.868, 27.693, 19.228 });
            females.Add(ageCategories[2], new double[] { 20.362, 5.462, 12.61, 12.501, 2.391, 8.318, 5.459 });
            population.Add(Gender.Female, females);

            List<AgePopulation> result = new List<AgePopulation>();
            foreach (Gender gender in System.Enum.GetValues(typeof(Gender)))
                foreach (string ageCatregory in ageCategories)
                    for (int i = 0; i < countries.Length; i++)
                        result.Add(new AgePopulation(countries[i], ageCatregory, gender, population[gender][ageCatregory][i]));
            return result;
        }

        public static IList<AgePopulation> GetPopulationAgeStructure() {
            return GetAllPopulationAgeStructure();
        }
        public static IList<AgePopulation> GetPopulationMaleAgeStructure() {
            List<string> countries = new List<string> { "Japan", "Germany", "Russia", "United States" };
            countries.Sort();
            List<AgePopulation> result = new List<AgePopulation>();
            foreach (AgePopulation agePopulation in GetAllPopulationAgeStructure())
                if (countries.BinarySearch(agePopulation.Name) >= 0 && agePopulation.Gender == Gender.Male)
                    result.Add(agePopulation);
            return result;
        }

        public class AgePopulation {
            string name;
            string age;
            Gender gender;
            double population;

            public string Name { get { return name; } }
            public string Age { get { return age; } }
            public Gender Gender { get { return gender; } }
            public string GenderAgeKey { get { return gender.ToString() + ": " + age; } }
            public string CountryAgeKey { get { return name + ": " + age; } }
            public string CountryGenderKey { get { return name + ": " + gender.ToString(); } }
            public double Population { get { return population; } }

            public AgePopulation(string name, string age, Gender gender, double population) {
                this.name = name;
                this.age = age;
                this.gender = gender;
                this.population = population;
            }
        }
    }
}

