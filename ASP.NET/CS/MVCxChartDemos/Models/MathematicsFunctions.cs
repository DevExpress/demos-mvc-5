using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.Data.Utils;

namespace DevExpress.Web.Demos.Charts {
    public static class MathematicsFunctions {
        static double ToRadian(double angle) {
            return angle * Math.PI / 180.0;
        }
        static double LemniscateFunction(double m, double angle) {
            double cos = Math.Cos(m * ToRadian(90.0 + angle));
            return Math.Pow(Math.Abs(cos), m);
        }
        public static List<RealPoint> GetArchimedeanSpiralPoints() {
            List<RealPoint> points = new List<RealPoint>();
            for (int i = 0; i < 720; i += 10) {
                double t = (double)i / 180 * Math.PI;
                double x = t * Math.Cos(t);
                double y = t * Math.Sin(t);
                points.Add(new RealPoint(x, y));
            }
            return points;
        }
        public static List<RealPoint> GetCardioidPoints() {
            List<RealPoint> points = new List<RealPoint>();
            for (int i = 0; i < 360; i += 10) {
                double t = (double)i / 180 * Math.PI;
                double x = 10 * (2 * Math.Cos(t) - Math.Cos(2 * t));
                double y = 10 * (2 * Math.Sin(t) - Math.Sin(2 * t));
                points.Add(new RealPoint(x, y));
            }
            return points;
        }
        public static List<RealPoint> GetCartesianFoliumPoints() {
            List<RealPoint> points = new List<RealPoint>();
            for (int i = -30; i < 125; i += 5) {
                double t = Math.Tan((double)i / 180 * Math.PI);
                double x = 3 * (double)10 * t / (t * t * t + 1);
                double y = x * t;
                points.Add(new RealPoint(x, y));
            }
            return points;
        }
        public static List<RealPoint> GetLemniscatePoints() {
            int pointsCount = 72;
            int step = 360 / 72;
            double m = 2;
            List<RealPoint> points = new List<RealPoint>();
            for (int i = 0; i < pointsCount; i++)
                points.Add(new RealPoint(step * i, LemniscateFunction(m, step * i)));
            return points;
        }
        static RealPoint[] CalcRandomPoints(NonCryptographicRandom random, int count, int xMin, int xMax, int yMin, int yMax) {
            if (count > Math.Abs(xMax - xMin) * Math.Abs(yMax - yMin))
                throw new ArgumentException("Parameter \"count\" very large. Can't calculate unique random points.");
            RealPoint[] points = new RealPoint[count];
            for (int i = 0; i < points.Length; i++) {
                bool repeat;
                do {
                    repeat = false;
                    points[i].X = random.Next(xMin, xMax);
                    points[i].Y = random.Next(yMin, yMax);
                    for (int k = 0; k < i; k++)
                        if (points[k].X == points[i].X && points[k].Y == points[i].Y) {
                            repeat = true;
                            break;
                        }
                } while (repeat);
            }
            return points;
        }
        public static List<RealPointSeries> GetRandomPoints(NonCryptographicRandom random, int count, int xMin, int xMax, int yMin, int yMax, int z) {
            RealPoint[] points = CalcRandomPoints(random, count, xMin, xMax, yMin, yMax);
            List<RealPointSeries> list = new List<RealPointSeries>();
            for (int i = 0; i < points.Length; i++) {
                list.Add(new RealPointSeries(points[i].X, points[i].Y, z.ToString()));
            }
            return list;
        }
        public static List<RealPointSeries> GetRandomData() {
            NonCryptographicRandom random = NonCryptographicRandom.System;
            List<RealPointSeries> list = new List<RealPointSeries>();
            list.AddRange(GetRandomPoints(random, 20, 1, 8, 5, 12, 0));
            list.AddRange(GetRandomPoints(random, 20, 9, 16, 1, 8, 1));
            list.AddRange(GetRandomPoints(random, 20, 6, 13, 14, 21, 2));
            return list;
        }
        static List<RealPoint> GetPolarArchimedeanSpiralPoints(ScatterFunctionCalculatorBase calculator, ScatterRadarFunctions scatterFunction) {
            return calculator.GenerateScatterFunctionPoints(scatterFunction);
        }
        public static List<RealPoint> GetDegreeArchimedeanSpiralPoints(ScatterRadarFunctions scatterFunction) {
            return GetPolarArchimedeanSpiralPoints(new DegreesScatterFunctionCalculator(), scatterFunction);

        }
        public static List<RealPoint> GetRadianArchimedeanSpiralPoints(ScatterRadarFunctions scatterFunction) {
            return GetPolarArchimedeanSpiralPoints(new RadianScatterFunctionCalculator(), scatterFunction);
        }
        static double Function(double m, double angle) {
            double cos = Math.Cos(m * ToRadian(90.0 + angle));
            return Math.Pow(Math.Abs(cos), m);
        }
        static double GetLineFactor(PolarFunctions function) {
            switch (function) {
                case PolarFunctions.Circles:
                    return 1;
                case PolarFunctions.Cardioid:
                    return 0.5;
                default:
                    return 2;
            }
        }
        public static List<RealPoint> GenerateFunctionPoints(PolarFunctions function) {
            double m = GetLineFactor(function);
            int step = 5;
            List<RealPoint> points = new List<RealPoint>();
            for (int i = 0; i < 72; i++)
                points.Add(new RealPoint(step * i, Function(m, step * i)));
            return points;
        }
        public static List<RealRangePoint> GenerateRangeFunctionPoints(PolarFunctions function) {
            double m = GetLineFactor(function);
            int step = 5;
            List<RealRangePoint> points = new List<RealRangePoint>();
            for (int i = 0; i < 72; i++)
                points.Add(new RealRangePoint(step * i, Function(m, step * i), Function(0, step * i)));
            return points;
        }

        public static RealPoint[] GenerateCluster(NonCryptographicRandom random, int xPlus, int xMinus, int yPlus, int yMinus, int count) {
            RealPoint[] seriesPoints = new RealPoint[count];
            int deltaX = xMinus - xPlus;
            int deltaY = yMinus - yPlus;
            int centerX = xMinus / 2 + xPlus / 2;
            int centerY = yMinus / 2 + yPlus / 2;
            for(int i = 0; i < count; i++) {
                int half = i / 2 + 1;
                double ratio = Math.Max(2.1, (double)count / half);
                int xOffset = (int)(deltaX / ratio);
                int yOffset = (int)(deltaY / ratio);
                int delta = xMinus - xOffset - centerX;
                int rx, ry;
                do {
                    rx = random.Next(xPlus + xOffset, xMinus - xOffset);
                    ry = random.Next(yPlus + yOffset, yMinus - yOffset);
                }
                while(delta * delta < Math.Pow((centerX - rx), 2) + Math.Pow((centerY - ry), 2));
                seriesPoints[i] = new RealPoint(rx, ry);
            }
            return seriesPoints;
        }
    }

    public abstract class ScatterFunctionCalculatorBase {
        const int spiralIntervalsCount = 72;
        const int roseIntervalsCount = 288;
        const int foliumSegmentIntervalsCount = 30;
        const double roseParameter = 7.0 / 4.0;
        const double foliumDistanceLimit = 3.0;

        protected abstract double NormalizeAngle(double angle);
        protected abstract double ToRadian(double angle);
        protected abstract double FromDegrees(double angle);

        void CreatePolarFunctionPoints(double minAngleDegree, double maxAngleDegree, int intervalsCount, Func<double, double> function, List<RealPoint> points) {
            double minAngle = FromDegrees(minAngleDegree);
            double maxAngle = FromDegrees(maxAngleDegree);
            double angleStep = (maxAngle - minAngle) / (double)intervalsCount;
            for (int pointIndex = 0; pointIndex <= intervalsCount; pointIndex++) {
                double angle = minAngle + pointIndex * angleStep;
                double angleRadians = ToRadian(angle);
                double distance = function(angleRadians);
                double normalAngle = NormalizeAngle(angle);
                points.Add(new RealPoint(normalAngle, distance));
            }
        }
        double ArchimedeanSpiralFunction(double angleRadians) {
            return angleRadians;
        }
        double PolarRoseFunction(double angleRadians) {
            return Math.Max(0.0, Math.Sin(roseParameter * angleRadians));
        }
        double PolarFoliumFunction(double angleRadians) {
            double sin = Math.Sin(angleRadians);
            double cos = Math.Cos(angleRadians);
            return (3.0 * sin * cos) / (Math.Pow(sin, 3.0) + Math.Pow(cos, 3.0));
        }
        List<RealPoint> FilterPointsByRange(List<RealPoint> points, double min, double max) {
            List<RealPoint> resultPoints = new List<RealPoint>();
            foreach (RealPoint point in points) {
                double pointValue = point.Y;
                if (pointValue <= max && pointValue >= min)
                    resultPoints.Add(point);
            }
            return resultPoints;
        }

        public List<RealPoint> GenerateScatterFunctionPoints(ScatterRadarFunctions scatterFunction) {
            List<RealPoint> points = new List<RealPoint>();
            switch (scatterFunction) {
                case ScatterRadarFunctions.ArchimedeanSpiral:
                    CreatePolarFunctionPoints(0.0, 720.0, spiralIntervalsCount, ArchimedeanSpiralFunction, points);
                    break;
                case ScatterRadarFunctions.PolarRose:
                    CreatePolarFunctionPoints(0.0, 1440.0, roseIntervalsCount, PolarRoseFunction, points);
                    break;
                case ScatterRadarFunctions.PolarFolium:
                    CreatePolarFunctionPoints(120.0, 180.0, foliumSegmentIntervalsCount, PolarFoliumFunction, points);
                    CreatePolarFunctionPoints(0.0, 90.0, foliumSegmentIntervalsCount, PolarFoliumFunction, points);
                    CreatePolarFunctionPoints(270.0, 330.0, foliumSegmentIntervalsCount, PolarFoliumFunction, points);
                    points = FilterPointsByRange(points, 0.0, foliumDistanceLimit);
                    break;
            }
            return points;
        }
    }

    public class RadianScatterFunctionCalculator : ScatterFunctionCalculatorBase {
        protected override double NormalizeAngle(double angle) {
            return angle % (Math.PI * 2.0);
        }
        protected override double ToRadian(double angle) {
            return angle;
        }
        protected override double FromDegrees(double angle) {
            return angle * Math.PI / 180.0;
        }
    }

    public class DegreesScatterFunctionCalculator : ScatterFunctionCalculatorBase {
        protected override double NormalizeAngle(double angle) {
            return angle % 360;
        }
        protected override double ToRadian(double angle) {
            return angle * Math.PI / 180.0;
        }
        protected override double FromDegrees(double angle) {
            return angle;
        }
    }

    public struct RealPoint {
        double x;
        double y;

        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }

        public RealPoint(double x, double y) {
            this.x = x;
            this.y = y;
        }
    }

    public struct RealRangePoint {
        double argument;
        double value1;
        double value2;

        public double Argument { get { return argument; } }
        public double Value1 { get { return value1; } }
        public double Value2 { get { return value2; } }

        public RealRangePoint(double argument, double value1, double value2) {
            this.argument = argument;
            this.value1 = value1;
            this.value2 = value2;
        }
    }

    [Browsable(true)]
    public class RealPointSeries {
        RealPoint point;
        string z;

        public RealPoint Point {
            get { return point; }
            set { point = value; }
        }
        public double X { 
            get { return point.X; }
        }
        public double Y {
            get { return point.Y; }
        }

        public string Z {
            get { return z; }
        }
        public RealPointSeries(double x, double y, string z){
            Point = new RealPoint(x, y);
            this.z = "Population " + z;
        }
    }
}
