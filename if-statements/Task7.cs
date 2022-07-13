namespace IfStatements
{
    public static class Task7
    {
        public static int DoSomething(bool b, int i)
        {
            if (b && Math.Abs(i) < 7)
            {
                i = 7 - i;
            }
            else if (!b && Math.Abs(i) >= 5)
            {
                i += 5;
            }

            return i;
        }
    }
}
