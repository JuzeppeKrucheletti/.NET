using System;
using System.Text;

namespace ShuffleCharacters
{
    public static class StringExtension
    {
        /// <summary>
        /// Shuffles characters in source string according some rule.
        /// </summary>
        /// <param name="source">The source string.</param>
        /// <param name="count">The count of iterations.</param>
        /// <returns>Result string.</returns>
        /// <exception cref="ArgumentNullException">Source string is null.</exception>
        /// <exception cref="ArgumentException">Source string is empty or a white space.</exception>
        /// <exception cref="ArgumentException">Count of iterations is less than 0.</exception>
        public static string ShuffleChars(string? source, int count)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (source.Length == 0)
            {
                throw new ArgumentException(" ", nameof(source));
            }

            int count_space = 0;
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] == ' ' || source[i] == '\n' || source[i] == '\t' || source[i] == '\r')
                {
                    count_space++;
                }
            }

            if (source.Length == count_space)
            {
                throw new ArgumentException(" ", nameof(source));
            }

            if (count < 0)
            {
                throw new ArgumentException(" ", nameof(count));
            }

            int el = 0;
            string source1 = source;
            for (int i = 0; i < int.MaxValue; i++)
            {
                StringBuilder str1 = new StringBuilder(), str2 = new StringBuilder();
                for (int j = 0; j < source1.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        str1.Append(source1[j]);
                    }
                    else
                    {
                        str2.Append(source1[j]);
                    }
                }

                source1 = str1.ToString() + str2.ToString();
                if (source == source1)
                {
                    el = i + 1;
                    break;
                }
            }

            while (count - el >= 0)
            {
                count -= el;
            }

            for (int i = 0; i < count; i++)
            {
                StringBuilder str1 = new StringBuilder(), str2 = new StringBuilder();
                for (int j = 0; j < source.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        str1.Append(source[j]);
                    }
                    else
                    {
                        str2.Append(source[j]);
                    }
                }

                source = str1.ToString() + str2.ToString();
            }

            return source;
        }
    }
}
