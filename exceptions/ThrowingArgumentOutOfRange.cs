namespace Exceptions
{
    public static class ThrowingArgumentOutOfRange
    {
        public static bool CheckParameterAndThrowException1(int i)
        {
            if (i < 5 && i > -5)
            {
                return true;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(i));
            }
        }

        public static bool CheckParameterAndThrowException2(ulong l)
        {
            if (l <= 7)
            {
                return true;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(l));
            }
        }

        public static bool CheckParametersAndThrowException3(uint i, double d)
        {
            // TODO 1-3. Add the code to throw the ArgumentOutOfRangeException if the i and d arguments are outside the allowable range.
            if (i >= 5)
            {
                throw new ArgumentOutOfRangeException(nameof(i), "i should be in [0, 5) interval.");
            }
            else if (d > 1 || d < -1)
            {
                throw new ArgumentOutOfRangeException(nameof(d), "d should be in [-1.0, 1.0] interval.");
            }
            else
            {
                return true;
            }
        }

        public static bool CheckParametersAndThrowException4(long l, float f)
        {
            if (l < -9 || (l < 3 && l >= -3) || l >= 9)
            {
                throw new ArgumentOutOfRangeException(nameof(l), "l should be in [-9, -3) or [3, 9) intervals.");
            }
            else if (Math.Abs(f) > 0.3)
            {
                throw new ArgumentOutOfRangeException(nameof(f), "f should be in the (-0.3, 0.3) interval.");
            }
            else
            {
                return true;
            }
        }
    }
}
