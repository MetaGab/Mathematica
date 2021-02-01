using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematica
{
    /// <summary>
    /// Area class to calculate areas of common shapes
    /// </summary>
    static public class Area
    {
        /// <summary>
        /// Method to get the area of a square with its side
        /// </summary>
        /// <param name="side">The side of the square</param>
        /// <returns>Area of the square</returns>
        public static double GetSquareArea(double side)
        {
            return Arithmetic.ElevateToPower(side, 2);
        }

        /// <summary>
        /// Method to get the area of a parallelogram (such a rectangle)
        /// </summary>
        /// <param name="width">The width of the parallegoram</param>
        /// <param name="height">The height of the parallegoram</param>
        /// <returns>Area of the parallelogram</returns>
        public static double GetParallelogramArea(double width, double height)
        {
            return width * height;
        }

        /// <summary>
        /// Method to get the area of a triangle
        /// </summary>
        /// <param name="baseLength">The length of the base</param>
        /// <param name="height">The length of the height</param>
        /// <returns>Area of the triangle</returns>
        public static double GetTriangleArea(double baseLength, double height)
        {
            return baseLength * height / 2;
        }

        /// <summary>
        /// Method to get the area of a rhombus
        /// </summary>
        /// <param name="majorDiagonal">The length of the major diagonal</param>
        /// <param name="minorDiagonal">The length of the minor diagonal</param>
        /// <returns>Area of the rhombus</returns>
        public static double GetRhombusArea(double majorDiagonal, double minorDiagonal)
        {
            return majorDiagonal * minorDiagonal / 2;
        }

        /// <summary>
        /// Method to get the area of a trapezoid
        /// </summary>
        /// <param name="majorBase">The length of the major base</param>
        /// <param name="minorBase">The length of the minor base</param>
        /// <param name="height">The length of the height</param>
        /// <returns>Area of the trapezoid</returns>
        public static double GetTrapezoidArea(double majorBase, double minorBase, double height)
        {
            return (majorBase + minorBase) * height / 2;
        }

        /// <summary>
        /// Method to get the area of a cube
        /// </summary>
        /// <param name="length">The length of a side of the cube</param>
        /// <returns>Area of all the faces of the cube</returns>
        public static double GetCubeArea(double length)
        {
            return 6 * GetSquareArea(length);
        }

        /// <summary>
        /// Method to get the area of a parallelepiped
        /// </summary>
        /// <param name="width">The width of the parallelepiped</param>
        /// <param name="length">The length of the parallelepiped</param>
        /// <param name="heigth">The height of the parallelepiped</param>
        /// <returns>Area of all the faces of the parallelepiped</returns>
        public static double GetParallelepipedArea(double width, double length, double heigth)
        {
            return 2 * GetParallelogramArea(width, length) + 2 * GetParallelogramArea(length, heigth) + 2 * GetParallelogramArea(heigth, width); 
        }

        /// <summary>
        /// Method to get the area of a regular polygon
        /// </summary>
        /// <param name="numSides">Number of sides of the polygon</param>
        /// <param name="sideLength">The length of the side</param>
        /// <param name="apothem">The length of the apothem</param>
        /// <returns>Area of a regular polygon</returns>
        public static double GetRegularPolygonArea(int numSides, double sideLength, double apothem)
        {
            return Perimeter.GetRegularPolygonPerimeter(numSides, sideLength) * apothem / 2;
        }

        /// <summary>
        /// Method to get the area of a circle
        /// </summary>
        /// <param name="radius">The length of the radius</param>
        /// <returns>Area of a circle</returns>
        public static double GetCircleArea(double radius)
        {
            return Convert.ToDouble(Constants.PI) * Arithmetic.ElevateToPower(radius, 2);
        }

        /// <summary>
        /// Method to get the area of a ring
        /// </summary>
        /// <param name="majorRadius">The radius of the outer circle</param>
        /// <param name="minorRadius">The radius of the inner circle</param>
        /// <returns>Area of a ring</returns>
        public static double GetRingArea(double majorRadius, double minorRadius)
        {
            return GetCircleArea(majorRadius) - GetCircleArea(minorRadius);
        }

        /// <summary>
        /// Method to get the area of a circle sector
        /// </summary>
        /// <param name="radius">The length of the radius</param>
        /// <param name="angle">The angle of the circle sector</param>
        /// <returns>Area of a circle sector</returns>
        public static double GetCircleSectorArea(double radius, double angle)
        {
            return GetCircleArea(radius) * angle / (2 * Constants.PI);
        }
    }
}
