using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematica
{
    /// <summary>
    /// Volume class to get the volume of common shapes
    /// </summary>
    static public class Volume
    {
        /// <summary>
        /// Method to get the volume of a cube
        /// </summary>
        /// <param name="side">The length of a side of the cube</param>
        /// <returns>Volume of a cube</returns>
        public static double GetCubeVolume(double side)
        {
            return Arithmetic.ElevateToPower(side, 3);
        }

        /// <summary>
        /// Method to get the volume of a parallelepiped
        /// </summary>
        /// <param name="width">The width of the parallelepiped</param>
        /// <param name="length">The length of the parallelepiped</param>
        /// <param name="heigth">The height of the parallelepiped</param>
        /// <returns>Volume of the parallelepiped</returns>
        public static double GetParallelepipedVolume(double width, double length, double heigth)
        {
            return width * length * heigth;
        }

        /// <summary>
        /// Method to get the volume of a sphere
        /// </summary>
        /// <param name="radius">The length of the radius</param>
        /// <returns>Volume of the sphere</returns>
        public static double GetSphereVolume(double radius)
        {
            return 4.0 / 3.0 * Arithmetic.ElevateToPower(radius, 3) * Constants.PI;
        }

        /// <summary>
        /// Method to get the volume of a prism
        /// </summary>
        /// <param name="numSides">The number of sides of the base</param>
        /// <param name="sideLength">The side length of the sides of the base</param>
        /// <param name="apothem">The apothem of the base</param>
        /// <param name="height">The height of the prism</param>
        /// <returns>Volume of the prism</returns>
        public static double GetPrismVolume(int numSides, double sideLength, double apothem, double height)
        {
            return height * Area.GetRegularPolygonArea(numSides, sideLength, apothem);
        }

        /// <summary>
        /// Method to get the volume of a prism
        /// </summary>
        /// <param name="baseArea">The area of the base</param>
        /// <param name="height">The height of the prism</param>
        /// <returns>Volume of the prism</returns>
        public static double GetPrismVolume(double baseArea, double height)
        {
            return height * baseArea;
        }

        /// <summary>
        /// Method to get the volume of a pyramid
        /// </summary>
        /// <param name="numSides">The number of sides of the base</param>
        /// <param name="sideLength">The side length of the sides of the base</param>
        /// <param name="apothem">The apothem of the base</param>
        /// <param name="height">The height of the pyramid</param>
        /// <returns>Volume of the pyramid</returns>
        public static double GetPyramidVolume(int numSides, double sideLength, double apothem, double height)
        {
            return height * Area.GetRegularPolygonArea(numSides, sideLength, apothem)/3;
        }

        /// <summary>
        /// Method to get the volume of a pyramid
        /// </summary>
        /// <param name="baseArea">The area of the base</param>
        /// <param name="height">The height of the pyramid</param>
        /// <returns>Volume of the pyramid</returns>
        public static double GetPyramidVolume(double baseArea, double height)
        {
            return height * baseArea/3;
        }

        /// <summary>
        /// Method to get the volume of a cylinder
        /// </summary>
        /// <param name="radius">The radius of the base</param>
        /// <param name="height">The height of the cylinder</param>
        /// <returns>Volume of the cylinder</returns>
        public static double GetCylinderVolume(double radius, double height)
        {
            return height * Area.GetCircleArea(radius);
        }

        /// <summary>
        /// Method to get the volume of a cone
        /// </summary>
        /// <param name="radius">The radius of the base</param>
        /// <param name="height">The height of the cone</param>
        /// <returns>Volume of the cone</returns>
        public static double GetConeVolume(double radius, double height)
        {
            return height * Area.GetCircleArea(radius)/3;
        }
    }
}
