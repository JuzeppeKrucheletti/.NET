using System;

namespace LookingForArrayElements
{
    public static class FloatCounter
    {
        /// <summary>
        /// Searches an array of floats for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="rangeStart">One-dimensional, zero-based <see cref="Array"/> of the range starts.</param>
        /// <param name="rangeEnd">One-dimensional, zero-based <see cref="Array"/> of the range ends.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetFloatsCount(float[]? arrayToSearch, float[]? rangeStart, float[]? rangeEnd)
        {
            int summ = 0;
            if (arrayToSearch == null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (rangeStart == null)
            {
                throw new ArgumentNullException(nameof(rangeStart));
            }

            if (rangeEnd == null)
            {
                throw new ArgumentNullException(nameof(rangeEnd));
            }

            if (rangeStart.Length != rangeEnd.Length)
            {
                throw new ArgumentException(" ");
            }

            for (int j = 0; j < rangeStart.Length; j++)
            {
                if (rangeStart[j] > rangeEnd[j])
                {
                    throw new ArgumentException(" ");
                }
            }

            for (int i = 0; i < arrayToSearch.Length; i++)
            {
                for (int j = 0; j < rangeStart.Length; j++)
                {
                    if (arrayToSearch[i] <= rangeEnd[j] && arrayToSearch[i] >= rangeStart[j])
                    {
                        summ++;
                    }
                }
            }

            return summ;
        }

        /// <summary>
        /// Searches an array of floats for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="rangeStart">One-dimensional, zero-based <see cref="Array"/> of the range starts.</param>
        /// <param name="rangeEnd">One-dimensional, zero-based <see cref="Array"/> of the range ends.</param>
        /// <param name="startIndex">The zero-based starting index of the search.</param>
        /// <param name="count">The number of elements in the section to search.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetFloatsCount(float[]? arrayToSearch, float[]? rangeStart, float[]? rangeEnd, int startIndex, int count)
        {
            int summ = 0;
            if (arrayToSearch == null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (rangeStart == null)
            {
                throw new ArgumentNullException(nameof(rangeStart));
            }

            if (rangeEnd == null)
            {
                throw new ArgumentNullException(nameof(rangeEnd));
            }

            if (rangeStart.Length != rangeEnd.Length)
            {
                throw new ArgumentException(" ");
            }

            for (int j = 0; j < rangeStart.Length; j++)
            {
                if (rangeStart[j] > rangeEnd[j])
                {
                    throw new ArgumentException(" ");
                }
            }

            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            if (count > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }

            for (int i = startIndex; i < startIndex + count; i++)
            {
                for (int j = 0; j < rangeStart.Length; j++)
                {
                    if (arrayToSearch[i] <= rangeEnd[j] && arrayToSearch[i] >= rangeStart[j])
                    {
                        summ++;
                    }
                }
            }

            return summ;
        }
    }
}
