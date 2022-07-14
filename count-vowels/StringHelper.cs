using System;

namespace VowelCountTask
{
    public static class StringHelper
    {
        /// <summary>
        /// Calculates the count of vowels in the source string.
        ///  'a', 'e', 'i', 'o', and 'u' are vowels.
        /// </summary>
        /// <param name="source">Source string.</param>
        /// <returns>Count of vowels in the given string.</returns>
        /// <exception cref="ArgumentException">Thrown when source string is null or empty.</exception>
        public static int GetCountOfVowel(string source)
        {
            int count = 0;
            if (source == null || source.Length == 0)
            {
                throw new ArgumentException(" ", nameof(source));
            }

            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] == 'a' || source[i] == 'o' || source[i] == 'i' || source[i] == 'e' || source[i] == 'u')
                {
                    count++;
                }
            }

            return count;
        }
    }
}
