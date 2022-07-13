using System;

namespace NextBiggerTask
{
    public static class NumberExtension
    {
        /// <summary>
        /// Finds the nearest largest integer consisting of the digits of the given positive integer number and null if no such number exists.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <returns>
        /// The nearest largest integer consisting of the digits  of the given positive integer and null if no such number exists.
        /// </returns>
        /// <exception cref="ArgumentException">Thrown when source number is less than 0.</exception>
        public static int? NextBiggerThan(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException($"Value of {nameof(number)} cannot be less zero.", nameof(number));
            }

            if (number == int.MaxValue)
            {
                return null;
            }

            int count = 0, number_copy = number;
            while (number_copy != 0)
            {
                count++;
                number_copy /= 10;
            }

            int new_number = 0, el = 1;
            for (int i = 0; i < count - 1; i++)
            {
                if (number % 10 > ((number / 10) % 10))
                {
                    new_number += ((number % 100) / 10) * el;
                    int kon = number % 10;
                    number /= 100;
                    number *= 10;
                    number += kon;

                    int[] mass = new int[i + 1];
                    for (int j = 0; j < i + 1; j++)
                    {
                        mass[j] = new_number % 10;
                        new_number /= 10;
                    }

                    Array.Sort(mass);
                    int el1 = 1;
                    for (int j = i; j >= 0; j--)
                    {
                        if (mass[j] == 0)
                        {
                            el *= 10;
                        }
                        else
                        {
                            new_number += mass[j] * el1;
                            el1 *= 10;
                        }
                    }

                    new_number = (number * el * 10) + new_number;
                    return new_number;
                }
                else
                {
                    new_number += (number % 10) * el;
                    number /= 10;
                }

                el *= 10;
            }

            return null;
        }
    }
}
