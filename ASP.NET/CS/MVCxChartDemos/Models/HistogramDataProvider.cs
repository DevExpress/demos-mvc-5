using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DevExpress.Data.Utils;

namespace DevExpress.Web.Demos.Charts {
    public static class HistogramDataProvider {
        static HistogramData HistogramData {
            get { return (HistogramData)HttpContext.Current.Session["HistogramData"]; }
            set { HttpContext.Current.Session["HistogramData"] = value; }
        }

        public static HistogramData GetData() {
            if(HistogramData == null)
                HistogramData = new HistogramData(800);
            return HistogramData;
        }
        public static HistogramData GetNewData() {
            HistogramData = new HistogramData(800);
            return HistogramData;
        }
    }

    public class ClusterPoint {
        public RealPoint P1 { get; set; }
        public RealPoint P2 { get; set; }
        public RealPoint P3 { get; set; }
    }

    public class HistogramData {
        ClusterPoint[] points;
        public ClusterPoint[] Points { get { return points; } }

        public HistogramData(int count) {
            GenerateHistogramCluster(count);
        }

        void GenerateHistogramCluster(int count) {
            NonCryptographicRandom random = NonCryptographicRandom.Default;
            points = new ClusterPoint[count];
            RealPoint[] P1 = MathematicsFunctions.GenerateCluster(random, random.Next(20, 70), random.Next(120, 180), random.Next(0, 10), random.Next(70, 120), count);
            RealPoint[] P2 = MathematicsFunctions.GenerateCluster(random, random.Next(0, 10), random.Next(70, 120), random.Next(40, 80), random.Next(160, 200), count);
            RealPoint[] P3 = MathematicsFunctions.GenerateCluster(random, random.Next(60, 100), random.Next(160, 200), random.Next(40, 80), random.Next(160, 200), count);
            for(int i = 0; i < points.Length; i++)
                points[i] = new ClusterPoint() { P1 = P1[i], P2 = P2[i], P3 = P3[i] };
        }
    }
}
