using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematica
{
    /// <summary>
    /// Perimeter class to calculate perimeters of common shapes
    /// </summary>
    public static class Perimeter
    {
        /// <summary>
        /// Method to get the perimeter of any shape
        /// </summary>
        /// <param name="sides">Array with lengths of all sides</param>
        /// <returns>Perimeter of the shape</returns>
        public static double GetGenericPerimeter(double[] sides)
        {
            return Arithmetic.AddDecimalNumbers(sides);
        }

        /// <summary>
        /// Method to get the perimeter of a square
        /// </summary>
        /// <param name="side">The side of the square</param>
        /// <returns>Perimeter of a square</returns>
        public static double GetSquarePerimeter(double side)
        {
            return 4 * side;
        }

        /// <summary>
        /// Method to get the perimeter of a regular polygon
        /// </summary>
        /// <param name="numSides">Number of sides of the polygon</param>
        /// <param name="lengthSide">The length of the side</param>
        /// <returns>Perimeter of a regular polygon</returns>
        public static double GetRegularPolygonPerimeter(int numSides, double lengthSide)
        {
            return numSides * lengthSide;
        }

        /// <summary>
        /// Method to get the perimeter of a paralelogram (such as a rectangle)
        /// </summary>
        /// <param name="width">The length of the base</param>
        /// <param name="height">The length of the height</param>
        /// <returns>Perimeter of a paralelogram</returns>
        public static double GetParalelogramPerimeter(double width, double height)
        {
            return 2 * width + 2 * height;
        }

        /// <summary>
        /// Method to get the perimeter of a circle
        /// </summary>
        /// <param name="radius">The length of the radius</param>
        /// <returns>Perimeter of a circle</returns>
        public static double GetCirclePerimeter(double radius)
        {
            return 2 * Convert.ToDouble(Constants.PI) * radius;
        }
    }
}
