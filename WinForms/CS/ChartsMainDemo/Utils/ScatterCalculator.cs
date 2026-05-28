using System;
using System.Collections.Generic;

namespace DevExpress.XtraCharts.Demos {
    abstract class ScatterFunctionCalculatorBase {
        const int archimedeanSpiralIndex = 0;
        const int polarRoseIndex = 1;
        const int polarFoliumIndex = 2;
        const int spiralIntervalsCount = 72;
        const int roseIntervalsCount = 288;
        const int foliumSegmentIntervalsCount = 30;

        const double roseParameter = 7.0 / 4.0;
        const double foliumDistanceLimit = 3.0;

        protected abstract double NormalizeAngle(double angle);
        protected abstract double ToRadian(double angle);
        protected abstract double FromDegrees(double angle);

        List<SeriesPoint> FilterPointsByRange(List<SeriesPoint> points, double min, double max) {
            List<SeriesPoint> resultPoints = new List<SeriesPoint>();
            foreach(SeriesPoint point in points) {
                double pointValue = point.Values[0];
                if(pointValue <= max && pointValue >= min)
                    resultPoints.Add(point);
            }
            return resultPoints;
        }
        void CreatePolarFunctionPoints(double minAngleDegree, double maxAngleDegree, int intervalsCount, Func<double, double> function, List<SeriesPoint> points) {
            double minAngle = FromDegrees(minAngleDegree);
            double maxAngle = FromDegrees(maxAngleDegree);
            double angleStep = (maxAngle - minAngle) / intervalsCount;
            for(int pointIndex = 0; pointIndex <= intervalsCount; pointIndex++) {
                double angle = minAngle + pointIndex * angleStep;
                double angleRadians = ToRadian(angle);
                double distance = function(angleRadians);
                double normalAngle = NormalizeAngle(angle);
                points.Add(new SeriesPoint(normalAngle, distance));
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

        internal SeriesPoint[] GenerateScatterFunctionPoints(int index) {
            List<SeriesPoint> points = new List<SeriesPoint>();
            switch(index) {
                case archimedeanSpiralIndex:
                    CreatePolarFunctionPoints(0.0, 720.0, spiralIntervalsCount, ArchimedeanSpiralFunction, points);
                    break;
                case polarRoseIndex:
                    CreatePolarFunctionPoints(0.0, 1440.0, roseIntervalsCount, PolarRoseFunction, points);
                    break;
                case polarFoliumIndex:
                    CreatePolarFunctionPoints(120.0, 180.0, foliumSegmentIntervalsCount, PolarFoliumFunction, points);
                    CreatePolarFunctionPoints(0.0, 90.0, foliumSegmentIntervalsCount, PolarFoliumFunction, points);
                    CreatePolarFunctionPoints(270.0, 330.0, foliumSegmentIntervalsCount, PolarFoliumFunction, points);
                    points = FilterPointsByRange(points, 0.0, foliumDistanceLimit);
                    break;
            }
            return points.ToArray();
        }
    }

    class RadianScatterFunctionCalculator : ScatterFunctionCalculatorBase {
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

    class DegreeScatterFunctionCalculator : ScatterFunctionCalculatorBase {
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
}
