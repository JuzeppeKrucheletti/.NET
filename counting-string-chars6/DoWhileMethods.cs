using System;

namespace CountingStringChars
{
    public static class DoWhileMethods
    {
        /// <summary>
        /// Returns a number of digits in a string.
        /// </summary>
        /// <param name="str">A <see cref="string"/> to search.</param>
        /// <returns>A number of digits in a string.</returns>
        public static int GetDigitCount(string? str)
        {
            int i = 0;
            int count = 0;
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (str == string.Empty)
            {
                return 0;
            }

            do
            {
                if (str[i] == '1' || str[i] == '2' || str[i] == '3' || str[i] == '4' || str[i] == '5' || str[i] == '6' || str[i] == '6' || str[i] == '7' || str[i] == '8' || str[i] == '9' || str[i] == '0')
                {
                    count++;
                }

                i++;
            }
            while (i < str.Length);
            return count;
        }

        /// <summary>
        /// Returns a number of letters in a string.
        /// </summary>
        /// <param name="str">A <see cref="string"/> to search.</param>
        /// <returns>A number of letters in a string.</returns>
        public static int GetLetterCount(string? str)
        {
            int i = 0;
            int count = 0;
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (str == string.Empty)
            {
                return 0;
            }

            do
            {
                if (str[i] == 'a' || str[i] == 'b' || str[i] == 'c' || str[i] == 'd' || str[i] == 'e' || str[i] == 'f')
                {
                    count++;
                }

                i++;
            }
            while (i < str.Length);
            return count;
        }

        /// <summary>
        /// Returns a number of digits in a string.
        /// </summary>
        /// <param name="str">A <see cref="string"/> to search.</param>
        /// <returns>A number of digits in a string.</returns>
        public static int GetDigitCountRecursive(string? str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return GetDigitCountRecursive(str, str.Length, 0);
        }

        /// <summary>
        /// Returns a number of letters in a string.
        /// </summary>
        /// <param name="str">A <see cref="string"/> to search.</param>
        /// <returns>A number of letters in a string.</returns>
        public static int GetLetterCountRecursive(string? str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return GetLetterCountRecursive(str, str.Length, 0);
        }

        private static int GetDigitCountRecursive(string str, int charsLeft, int counter)
        {
            if (charsLeft > 0)
            {
                return GetDigitCountRecursive(str, charsLeft - 1, char.IsDigit(str[^charsLeft]) ? counter + 1 : counter);
            }

            return counter;
        }

        private static int GetLetterCountRecursive(string str, int charsLeft, int counter)
        {
            if (charsLeft > 0)
            {
                return GetLetterCountRecursive(str, charsLeft - 1, char.IsLetter(str[^charsLeft]) ? counter + 1 : counter);
            }

            return counter;
        }
    }
}
