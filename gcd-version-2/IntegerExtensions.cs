using System;

namespace Gcd
{
    /// <summary>
    /// Provide methods with integers.
    /// </summary>
    public static class IntegerExtensions
    {
        /// <summary>
        /// Calculates GCD of two integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(int a, int b)
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

        /// <summary>
        /// Calculates GCD of three integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="c">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(int a, int b, int c)
        {
            if (a == 0 && b == 0 && c == 0)
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

            if (c == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(c));
            }

            a = Math.Abs(a);
            b = Math.Abs(b);
            c = Math.Abs(c);
            if (a == 0 && b == 0)
            {
                return c;
            }

            if (a == 0 && c == 0)
            {
                return b;
            }

            if (c == 0 && b == 0)
            {
                return a;
            }

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
                    break;
                }
            }

            while (true)
            {
                if (c > b)
                {
                    c = c - b;
                }
                else if (b > c)
                {
                    b = b - c;
                }
                else
                {
                    return b;
                }
            }
        }

        public static int MyGcd(int a, int b)
        {
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

        /// <summary>
        /// Calculates the GCD of integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="other">Other integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(int a, int b, params int[] other)
        {
            bool is_null = true;
            for (int i = 0; i < other.Length; i++)
            {
                if (other[i] != 0)
                {
                    is_null = false;
                }
            }

            if (is_null && a == 0 && b == 0)
            {
                throw new ArgumentException("All numbers cannot be 0 at the same time.");
            }

            a = MyGcd(a, b);
            for (int i = 0; i < other.Length; i++)
            {
                if (other[i] != 0)
                {
                    a = MyGcd(a, other[i]);
                }
            }

            return a;
        }

        public static int MyGcdByStein(int a, int b)
        {
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
            if (a % 2 == 0 && b % 2 == 0)
            {
                return 2 * MyGcdByStein(a / 2, b / 2);
            }
            else if (a % 2 == 0)
            {
                return MyGcdByStein(a / 2, b);
            }
            else if (b % 2 == 0)
            {
                return MyGcdByStein(a, b / 2);
            }
            else
            {
                return MyGcdByStein(Math.Abs(a - b), Math.Min(a, b));
            }
        }

        /// <summary>
        /// Calculates GCD of two integers [-int.MaxValue;int.MaxValue] by the Stein algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int GetGcdByStein(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("Two numbers cannot be 0 at the same time.");
            }

            return MyGcdByStein(a, b);
        }

        /// <summary>
        /// Calculates GCD of three integers [-int.MaxValue;int.MaxValue] by the Stein algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="c">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByStein(int a, int b, int c)
        {
            if (c == 0 && a == 0 && b == 0)
            {
                throw new ArgumentException("All numbers cannot be 0 at the same time.");
            }

            a = MyGcdByStein(a, b);
            a = MyGcdByStein(a, c);

            return a;
        }

        /// <summary>
        /// Calculates the GCD of integers [-int.MaxValue;int.MaxValue] by the Stein algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="other">Other integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByStein(int a, int b, params int[] other)
        {
            bool is_null = true;
            for (int i = 0; i < other.Length; i++)
            {
                if (other[i] != 0)
                {
                    is_null = false;
                }
            }

            if (is_null && a == 0 && b == 0)
            {
                throw new ArgumentException("All numbers cannot be 0 at the same time.");
            }

            a = MyGcdByStein(a, b);
            for (int i = 0; i < other.Length; i++)
            {
                if (other[i] != 0)
                {
                    a = MyGcdByStein(a, other[i]);
                }
            }

            return a;
        }

        /// <summary>
        /// Calculates GCD of two integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(out long elapsedTicks, int a, int b)
        {
            long milliseconds1 = DateTime.Now.Ticks;
            a = GetGcdByEuclidean(a, b);
            long milliseconds2 = DateTime.Now.Ticks;
            elapsedTicks = milliseconds2 - milliseconds1;
            return a;
        }

        /// <summary>
        /// Calculates GCD of three integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="c">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(out long elapsedTicks, int a, int b, int c)
        {
            long milliseconds1 = DateTime.Now.Ticks;
            a = GetGcdByEuclidean(a, b, c);
            long milliseconds2 = DateTime.Now.Ticks;
            elapsedTicks = milliseconds2 - milliseconds1;
            return a;
        }

        /// <summary>
        /// Calculates the GCD of integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in Ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="other">Other integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(out long elapsedTicks, int a, int b, params int[] other)
        {
            long milliseconds1 = DateTime.Now.Ticks;
            a = GetGcdByEuclidean(a, b, other);
            long milliseconds2 = DateTime.Now.Ticks;
            elapsedTicks = milliseconds2 - milliseconds1;
            return a;
        }

        /// <summary>
        /// Calculates GCD of two integers from [-int.MaxValue;int.MaxValue] by the Stein algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int GetGcdByStein(out long elapsedTicks, int a, int b)
        {
            long milliseconds1 = DateTime.Now.Ticks;
            a = GetGcdByStein(a, b);
            long milliseconds2 = DateTime.Now.Ticks;
            elapsedTicks = milliseconds2 - milliseconds1;
            return a;
        }

        /// <summary>
        /// Calculates GCD of three integers from [-int.MaxValue;int.MaxValue] by the Stein algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="c">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByStein(out long elapsedTicks, int a, int b, int c)
        {
            long milliseconds1 = DateTime.Now.Ticks;
            a = GetGcdByStein(a, b, c);
            long milliseconds2 = DateTime.Now.Ticks;
            elapsedTicks = milliseconds2 - milliseconds1;
            return a;
        }

        /// <summary>
        /// Calculates the GCD of integers from [-int.MaxValue;int.MaxValue] by the Stein algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in Ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="other">Other integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByStein(out long elapsedTicks, int a, int b, params int[] other)
        {
            long milliseconds1 = DateTime.Now.Ticks;
            a = GetGcdByStein(a, b, other);
            long milliseconds2 = DateTime.Now.Ticks;
            elapsedTicks = milliseconds2 - milliseconds1;
            return a;
        }
    }
}
