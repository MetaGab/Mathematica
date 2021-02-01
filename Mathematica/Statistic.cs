using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematica
{
    /// <summary>
    /// Statistic class to calculate descriptive statistic values
    /// </summary>
    static public class Statistic
    {
        /// <summary>
        /// Method to get the average of a set of numbers
        /// </summary>
        /// <param name="numberSet">Array of doubles</param>
        /// <returns>Average of the array numbers</returns>
        public static double GetAverage(double[] numberSet)
        {
            return Arithmetic.AddDecimalNumbers(numberSet) / numberSet.Length;
        }

        /// <summary>
        /// Method to get the median value of a set of numbers
        /// </summary>
        /// <param name="numberSet">Array of doubles</param>
        /// <returns>Median of the array numbers</returns>
        public static double GetMedian(double[] numberSet)
        {
            if (numberSet.Length % 2 == 0 && numberSet.Length>2) 
            {
                return GetAverage(new double[] { numberSet[numberSet.Length / 2], numberSet[(numberSet.Length / 2) -1] });
            }
            else if (numberSet.Length > 0)
            {
                return numberSet[(numberSet.Length -1)/ 2];
            }

            return 0;
        }

        /// <summary>
        /// Method to get the mode value of a set of numbers
        /// </summary>
        /// <param name="numberSet">Array of doubles</param>
        /// <returns>Mode of the array numbers</returns>
        public static double GetMode(double[] numberSet)
        {
            int maxRepetitions = 0, repetitions;
            double mode = 0;
            foreach (double numberToCheck in numberSet)
            {
                repetitions = 0;
                foreach (double number in numberSet)
                {
                    if (number == numberToCheck)
                    {
                        repetitions++;
                    }
                }
                if (repetitions > maxRepetitions)
                {
                    maxRepetitions = repetitions;
                    mode = numberToCheck;
                }
            }
            return mode;
        }
    }
}
