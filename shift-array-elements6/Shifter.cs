using System;

namespace ShiftArrayElements
{
    public static class Shifter
    {
        /// <summary>
        /// Shifts elements in a <see cref="source"/> array using <see cref="iterations"/> array for getting directions and iterations (see README.md for detailed instructions).
        /// </summary>
        /// <param name="source">A source array.</param>
        /// <param name="iterations">An array with iterations.</param>
        /// <returns>An array with shifted elements.</returns>
        /// <exception cref="ArgumentNullException">source array is null.</exception>
        /// <exception cref="ArgumentNullException">iterations array is null.</exception>
        public static int[] Shift(int[]? source, int[]? iterations)
        {
            if (iterations == null)
            {
                throw new ArgumentNullException(nameof(iterations));
            }

            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            for (int i = 0; i < iterations.Length; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    for (int k = 0; k < iterations[i]; k++)
                    {
                        int last = source[^1];
                        for (int j = source.Length - 1; j > 0; j--)
                        {
                            source[j] = source[j - 1];
                        }

                        source[0] = last;
                    }
                }
                else
                {
                    for (int k = 0; k < iterations[i]; k++)
                    {
                        int first = source[0];
                        for (int j = 0; j < source.Length - 1; j++)
                        {
                            source[j] = source[j + 1];
                        }

                        source[^1] = first;
                    }
                }
            }

            return source;
        }
    }
}
