using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematica
{
    /// <summary>
    /// Analytic geometry class for perations with points on a plane
    /// </summary>
    static public class AnalyticGeometry
    {
        /// <summary>
        /// Method to calculate distance between two points
        /// </summary>
        /// <param name="x1">The x value of the first point</param>
        /// <param name="y1">The y value of the first point</param>
        /// <param name="x2">The x value of the second point</param>
        /// <param name="y2">The y value of the second point</param>
        /// <returns>The distance between the two points</returns>
        static public double GetDistanceBetweenTwoPoints(double x1, double y1, double x2, double y2)
        {
            double deltaX = x2 - x1;
            double deltaY = y2 - y1;
            return Arithmetic.GetRootValue(2, (Arithmetic.ElevateToPower(deltaX, 2) + Arithmetic.ElevateToPower(deltaY, 2)));
        }

        /// <summary>
        /// Method to get the middle point between two points
        /// </summary>
        /// <param name="x1">The x value of the first point</param>
        /// <param name="y1">The y value of the first point</param>
        /// <param name="x2">The x value of the second point</param>
        /// <param name="y2">The y value of the second point</param>
        /// <returns>An array with the x,y coordinate of the middle point</returns>
        static public double[] GetMiddlePoint(double x1, double y1, double x2, double y2)
        {
            return new double[] {(x1+x2)/2, (y1+y2)/2 } ;
        }

        /// <summary>
        /// Method to get the slope of the line between two points
        /// </summary>
        /// <param name="x1">The x value of the first point</param>
        /// <param name="y1">The y value of the first point</param>
        /// <param name="x2">The x value of the second point</param>
        /// <param name="y2">The y value of the second point</param>
        /// <returns>The slope of the line</returns>
        static public double GetSlope(double x1, double y1, double x2, double y2)
        {
            double deltaX = x2 - x1;
            double deltaY = y2 - y1;
            return deltaY/deltaX;
        }

        /// <summary>
        /// Method to get the point between two points that divides with the ratio specified
        /// </summary>
        /// <param name="x1">The x value of the first point</param>
        /// <param name="y1">The y value of the first point</param>
        /// <param name="x2">The x value of the second point</param>
        /// <param name="y2">The y value of the second point</param>
        /// <param name="ratio">The ratio of the division</param>
        /// <returns>An array with the x,y coordinate of the divisor point</returns>
        static public double[] GetPointInRatio(double x1, double y1, double x2, double y2, double ratio)
        {
            double x = (x1 + ratio * x2) / (1 + ratio);
            double y = (y1 + ratio * y2) / (1 + ratio);
            return new double[] { x, y };
        }
        
    }
}
