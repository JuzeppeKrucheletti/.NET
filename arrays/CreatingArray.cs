using System;

namespace WorkingWithArrays
{
    public static class CreatingArray
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "Education purposes")]
        public static int[] CreateEmptyArrayOfIntegers()
        {
            return new int[0];
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "Education purposes")]
        public static bool[] CreateEmptyArrayOfBooleans()
        {
            bool[] array = { };
            return array;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "Education purposes")]
        public static string[] CreateEmptyArrayOfStrings()
        {
            return new string[] { };
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "Education purposes")]
        public static char[] CreateEmptyArrayOfCharacters()
        {
            return new char[] { };
        }

        public static double[] CreateEmptyArrayOfDoubles()
        {
            return Array.Empty<double>();
        }

        public static float[] CreateEmptyArrayOfFloats()
        {
            return Array.Empty<float>();
        }

        public static decimal[] CreateEmptyArrayOfDecimals()
        {
            return Array.Empty<decimal>();
        }

        public static int[] CreateArrayOfTenIntegersWithDefaultValues()
        {
            return new int[10];
        }

        public static bool[] CreateArrayOfTwentyBooleansWithDefaultValues()
        {
            return new bool[20];
        }

        public static string[] CreateArrayOfFiveEmptyStrings()
        {
            return new string[5];
        }

        public static char[] CreateArrayOfFifteenCharactersWithDefaultValues()
        {
            return new char[15];
        }

        public static double[] CreateArrayOfEighteenDoublesWithDefaultValues()
        {
            return new double[18];
        }

        public static float[] CreateArrayOfOneHundredFloatsWithDefaultValues()
        {
            return new float[100];
        }

        public static decimal[] CreateArrayOfOneThousandDecimalsWithDefaultValues()
        {
            return new decimal[1000];
        }

        public static int[] CreateIntArrayWithOneElement()
        {
            int[] arr = { 123_456 };
            return arr;
        }

        public static int[] CreateIntArrayWithTwoElements()
        {
            int[] arr = { 1_111_111, 9_999_999 };
            return arr;
        }

        public static int[] CreateIntArrayWithTenElements()
        {
            int[] arr = { 0, 4_234, 3_845, 2_942, 1_104, 9_794, 923_943, 7_537, 4_162, 10_134 };
            return arr;
        }

        public static bool[] CreateBoolArrayWithOneElement()
        {
            bool[] arr = { true };
            return arr;
        }

        public static bool[] CreateBoolArrayWithFiveElements()
        {
            bool[] arr = { true, false, true, false, true };
            return arr;
        }

        public static bool[] CreateBoolArrayWithSevenElements()
        {
            bool[] arr = { false, true, true, false, true, true, false };
            return arr;
        }

        public static string[] CreateStringArrayWithOneElement()
        {
            string[] arr = { "one" };
            return arr;
        }

        public static string[] CreateStringArrayWithThreeElements()
        {
            string[] arr = { "one", "two", "three" };
            return arr;
        }

        public static string[] CreateStringArrayWithSixElements()
        {
            string[] arr = { "one", "two", "three", "four", "five", "six" };
            return arr;
        }

        public static char[] CreateCharArrayWithOneElement()
        {
            char[] arr = { 'a' };
            return arr;
        }

        public static char[] CreateCharArrayWithThreeElements()
        {
            char[] arr = { 'a', 'b', 'c' };
            return arr;
        }

        public static char[] CreateCharArrayWithNineElements()
        {
            char[] arr = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'a' };
            return arr;
        }

        public static double[] CreateDoubleArrayWithOneElement()
        {
            double[] arr = { 1.12 };
            return arr;
        }

        public static double[] CreateDoubleWithFiveElements()
        {
            double[] arr = { 1.12, 2.23, 3.34, 4.45, 5.56 };
            return arr;
        }

        public static double[] CreateDoubleWithNineElements()
        {
            double[] arr = { 1.12, 2.23, 3.34, 4.45, 5.56, 6.67, 7.78, 8.89, 9.91 };
            return arr;
        }

        public static float[] CreateFloatArrayWithOneElement()
        {
            float[] arr = { 123_456_789.123456f };
            return arr;
        }

        public static float[] CreateFloatWithThreeElements()
        {
            float[] arr = { 1000000.123456f, 2223334444.123456f, 9999.999999f };
            return arr;
        }

        public static float[] CreateFloatWithFiveElements()
        {
            float[] arr = { 1.0123f, 20.012345f, 300.01234567f, 4_000.01234567f, 500_000.01234567f };
            return arr;
        }

        public static decimal[] CreateDecimalArrayWithOneElement()
        {
            decimal[] arr = { 10000.123456m };
            return arr;
        }

        public static decimal[] CreateDecimalWithFiveElements()
        {
            decimal[] arr = { 1_000.1234m, 100_000.2345m, 100_000.3456m, 1_000_000.456789m, 10_000_000.5678901m };
            return arr;
        }

        public static decimal[] CreateDecimalWithNineElements()
        {
            decimal[] arr = { 10.122112m, 200.233223m, 3_000.344334m, 40_000.455445m, 500_000.566556m, 6_000_000.677667m, 70_000_000.788778m, 800_000_000.899889m, 9_000_000_000.911991m };
            return arr;
        }
    }
}
