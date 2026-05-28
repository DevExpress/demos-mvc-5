using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExpress.Web.Demos.Charts {
    public static class CommentsInSite {
        public static List<Comment> GetCommentsValues() {
            string[] types = new string[] { "Negative", "Neutral", "Positive" };
            Dictionary<string, double[]> typeValues = new Dictionary<string, double[]>();
            typeValues.Add(types[0], new double[] { 13.0, 16.0, 12.0, 23.0, 19.0, 19.0, 7.0, 34.0, 21.0, 9.0, 5.0, 3.0 });
            typeValues.Add(types[1], new double[] { 120.0, 101.0, 91.0, 85.0, 101.0, 143.0, 145.0, 150.0, 111.0, 134.0, 107.0, 103.0 });
            typeValues.Add(types[2], new double[] { 47.0, 77.0, 45.0, 49.0, 63.0, 58.0, 56.0, 77.0, 105.0, 80.0, 91.0, 89.0 });

            DateTime startDate = new DateTime(2016, 1, 1);
            DateTime[] dates = new DateTime[12];
            for (int i = 0; i < dates.Length; i++)
                dates[i] = startDate.AddMonths(i);

            List<Comment> result = new List<Comment>(dates.Length);
            foreach (string type in types)
                for (int i = 0; i < dates.Length; i++)
                    result.Add(new Comment(type, dates[i], typeValues[type][i]));
            return result;
        }
    }

    public class Comment {
        string type;
        DateTime date;
        double value;

        public string Type { get { return type; } }
        public DateTime Date { get { return date; } }
        public double Value { get { return value; } }
        
        public Comment(string type, DateTime date, double value) {
            this.type = type;
            this.date = date;
            this.value = value;
        }
    }
}
