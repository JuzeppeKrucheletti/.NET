﻿using System;

namespace LookingForArrayElements
{
    public static class DecimalCounter
    {
        /// <summary>
        /// Searches an array of decimals for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="ranges">One-dimensional, zero-based <see cref="Array"/> of range arrays.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetDecimalsCount(decimal[]? arrayToSearch, decimal[]?[]? ranges)
        {
            int summ = 0;
            if (arrayToSearch == null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (ranges == null)
            {
                throw new ArgumentNullException(nameof(ranges));
            }

            for (int j = 0; j < ranges.Length; j++)
            {
                if (ranges[j] == null)
                {
                    throw new ArgumentNullException(nameof(ranges));
                }
            }

            for (int j = 0; j < ranges.Length; j++)
            {
                    if (ranges[j]!.Length != 2 && ranges[j]!.Length != 0)
                    {
                        throw new ArgumentException(" ");
                    }
            }

            for (int i = 0; i < arrayToSearch.Length; i++)
            {
                for (int j = 0; j < ranges.Length; j++)
                {
                    if (ranges[j]?.Length == 2 && arrayToSearch[i] <= ranges[j]?[1] && arrayToSearch[i] >= ranges[j]?[0])
                    {
                        summ++;
                        break;
                    }
                }
            }

            return summ;
        }

        /// <summary>
        /// Searches an array of decimals for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="ranges">One-dimensional, zero-based <see cref="Array"/> of range arrays.</param>
        /// <param name="startIndex">The zero-based starting index of the search.</param>
        /// <param name="count">The number of elements in the section to search.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetDecimalsCount(decimal[]? arrayToSearch, decimal[]?[]? ranges, int startIndex, int count)
        {
            int summ = 0;
            if (arrayToSearch == null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (ranges == null)
            {
                throw new ArgumentNullException(nameof(ranges));
            }

            for (int j = 0; j < ranges.Length; j++)
            {
                if (ranges[j] == null)
                {
                    throw new ArgumentNullException(nameof(ranges), "Method throws ArgumentNullException in case one of the ranges is null.");
                }
            }

            for (int j = 0; j < ranges.Length; j++)
            {
                if (ranges[j]?.Length != 2 && ranges[j]?.Length != 0)
                {
                    throw new ArgumentException("Method throws ArgumentException in case the length of one of the ranges is less or greater than 2.");
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

            for (int j = 0; j < ranges.Length; j++)
            {
                if (ranges[j]?.Length != 0 && ranges[j]?[0] > ranges[j]?[1])
                {
                    throw new ArgumentException(" ", nameof(ranges));
                }
            }

            for (int i = startIndex; i < startIndex + count; i++)
            {
                for (int j = 0; j < ranges.Length; j++)
                {
                    if (ranges[j]?.Length == 2 && arrayToSearch[i] <= ranges[j]?[1] && arrayToSearch[i] >= ranges[j]?[0])
                    {
                        summ++;
                        break;
                    }
                }
            }

            return summ;
        }
    }
}
