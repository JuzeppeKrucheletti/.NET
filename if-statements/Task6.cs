namespace IfStatements
{
    public static class Task6
    {
        public static int DoSomething(int i)
        {
            if (i <= 3 && i > 0)
            {
                i -= i * i;
            }
            else if (i >= -3 && i < 0)
            {
                i = 3 * i;
            }

            return i;
        }
    }
}
