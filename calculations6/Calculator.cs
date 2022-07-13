using System;

namespace Calculations
{
    public static class Calculator
    {
        /// <summary>
        /// Calculate the following sum 1/1 + 1/2 + 1/3 + ... + 1/n, where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumOne(int n)
        {
            double summ = 0;
            double i = 1;
            while (i <= n)
            {
               summ += 1 / i;
               i++;
            }

            return summ;
        }

        /// <summary>
        /// Calculate the following sum
        /// 1/(1*2) - 1/(2*3) + 1/(3*4) + ... + (-1)^(n+1) / (n * (n + 1)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumTwo(int n)
        {
            double summ = 0, el = 1;
            double i = 1;
            while (i <= n)
            {
                summ += el / (i * (i + 1));
                el *= -1;
                i++;
            }

            return summ;
        }

        /// <summary>
        /// Calculate the following sum
        /// 1/1^5 + 1/2^5 + 1/3^5 + ... + 1/n^5, where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumThree(int n)
        {
            double summ = 0, el = 1;
            double i = 1;
            while (i <= n)
            {
                el = 1 / (i * i * i * i * i);
                summ += el;
                i++;
            }

            return summ;
        }

        /// <summary>
        /// Calculate the following sum
        /// 1/(3 * 3) + 1/(5 * 5) + 1/(7 * 7) + ... + 1/((2 * n + 1) * (2 * n + 1)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumFour(int n)
        {
            double summ = 0, el = 1;
            double i = 1;
            while (i <= n)
            {
                el = 1 / (((2 * i) + 1) * ((2 * i) + 1));
                summ += el;
                i++;
            }

            return summ;
        }

        /// <summary>
        /// Calculate the following product
        /// (1 + 1/(1 * 1)) * (1 + 1/(2 * 2)) * (1 + 1/(3 * 3)) * ... * (1 + 1/(n * n)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Product of elements.</returns>
        public static double GetProductOne(int n)
        {
            double summ = 1, el = 1;
            double i = 1;
            while (i <= n)
            {
                el = 1 + (1 / (i * i));
                summ *= el;
                i++;
            }

            return summ;
        }

        /// <summary>
        /// Calculate the following sum
        /// -1/3 + 1/5 - 1/7 + ... + (-1)^n / (2 * n + 1), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumFive(int n)
        {
            double summ = 0, el = 1;
            double i = 1;
            while (i <= n)
            {
                el *= -1;
                summ += el / ((2 * i) + 1);
                i++;
            }

            return summ;
        }

        /// <summary>
        /// Calculate the following sum
        /// 1!/1 + 2!/(1+1/2) + 3!/(1+1/2+1/3) + ... + 1*2*...* n/ (1+1/2+1/3+...+1/n), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumSix(int n)
        {
            double summ = 0, el = 0, fact = 1;
            double i = 1;
            while (i <= n)
            {
                el += 1 / i;
                fact *= i;
                summ += fact / el;
                i++;
            }

            return summ;
        }

        /// <summary>
        /// Calculate the following sum
        /// Sqrt(2 + Sqrt(2 + ... + Sqrt(2))), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumSeven(int n)
        {
            double summ = 0;
            for (int i = 0; i < n; i++)
            {
                summ += 2;
                summ = Math.Sqrt(summ);
            }

            return summ;
        }

        /// <summary>
        /// Calculate the following sum
        /// 1/sin(1) + 1/(sin(1)+sin(2)) + ...+  1/(sin(1)+sin(2)+...+sin(n)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumEight(int n)
        {
            double summ = 0, el = 0;
            for (double i = 1; i <= n; i++)
            {
                el += Math.Sin(i * Math.PI / 180);
                summ += 1 / el;
            }

            return summ;
        }
    }
}
