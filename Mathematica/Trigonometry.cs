using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematica
{
    /// <summary>
    /// Trigonometry class to calculate trigonometric functions
    /// </summary>
    public static class Trigonometry
    {
        /// <summary>
        /// Method to get the sine of an angle
        /// </summary>
        /// <param name="angle">Angle in radians</param>
        /// <returns>Sine of the angle</returns>
        public static double GetSin(double angle)
        {
            angle = GetEquivalentAngle(angle);
            double result = 0;
            for (int i = 0; i < 5; i++)
            {
                result += Arithmetic.ElevateToPower(-1, i) * Arithmetic.ElevateToPower(angle, 2 * i + 1) / Arithmetic.GetFactorial(2 * i + 1);
            }
            return result;
        }

        /// <summary>
        /// Method to get the cosine of an angle
        /// </summary>
        /// <param name="angle">Angle in radians</param>
        /// <returns>Cosine of the angle</returns>
        public static double GetCos(double angle)
        {
            angle = GetEquivalentAngle(angle);
            double result = 0;
            for (int i = 0; i < 5; i++)
            {
                result += Arithmetic.ElevateToPower(-1, i) * Arithmetic.ElevateToPower(angle, 2 * i) / Arithmetic.GetFactorial(2 * i);
            }
            return result;
        }

        /// <summary>
        /// Method to get the tangent of an angle
        /// </summary>
        /// <param name="angle">Angle in radians</param>
        /// <returns>Tangent of the angle</returns>
        public static double GetTan(double angle)
        {
            angle = GetEquivalentAngle(angle);
            return GetSin(angle) / GetCos(angle);
        }

        /// <summary>
        /// Method to get the cosecant of an angle
        /// </summary>
        /// <param name="angle">Angle in radians</param>
        /// <returns>Cosecant of the angle</returns>
        public static double GetCsc(double angle)
        {
            angle = GetEquivalentAngle(angle);
            return 1 / GetSin(angle);
        }

        /// <summary>
        /// Method to get the secant of an angle
        /// </summary>
        /// <param name="angle">Angle in radians</param>
        /// <returns>Secant of the angle</returns>
        public static double GetSec(double angle)
        {
            angle = GetEquivalentAngle(angle);
            return 1 / GetCos(angle);
        }

        /// <summary>
        /// Method to get the cotangent of an angle
        /// </summary>
        /// <param name="angle">Angle in radians</param>
        /// <returns>Cotangent of the angle</returns>
        public static double GetCot(double angle)
        {
            angle = GetEquivalentAngle(angle);
            return 1 / GetTan(angle);
        }

        /// <summary>
        /// Method to get the smallest equivalent angle
        /// </summary>
        /// <param name="angle">The angle to simplify</param>
        /// <returns>The angle simplified</returns>
        public static double GetEquivalentAngle(double angle)
        {
            while (Arithmetic.GetAbsoluteValue(angle) >= 2*Constants.PI)
            {
                angle -= 2 * Constants.PI * Arithmetic.GetSignOfNumber(angle);
            }
            return angle;
        }
    }
}
