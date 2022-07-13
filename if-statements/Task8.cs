namespace IfStatements
{
    public static class Task8
    {
        public static bool DoSomething(bool b, int i)
        {
            bool result = false;
            if ((b && i != 0 && (Math.Abs(i) > 6 || Math.Abs(i) <= 3)) || (!b && i != 0 && (Math.Abs(i) > 6 || Math.Abs(i) < 3)))
            {
                result = true;
            }

            return result;
        }
    }
}
