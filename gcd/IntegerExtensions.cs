using System;

namespace GcdTask
{
    public static class IntegerExtensions
    {
        /// <summary>
        /// Calculates GCD of two integers from [-int.MaxValue;int.MaxValue]  by the Euclidean algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int FindGcd(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("Two numbers cannot be 0 at the same time.");
            }

            if (a == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a));
            }

            if (b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(b));
            }

            if (a == 0)
            {
                return Math.Abs(b);
            }

            if (b == 0)
            {
                return Math.Abs(a);
            }

            a = Math.Abs(a);
            b = Math.Abs(b);
            while (true)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else if (b > a)
                {
                   b = b - a;
                }
                else
                {
                    return a;
                }
            }
        }
    }
}
