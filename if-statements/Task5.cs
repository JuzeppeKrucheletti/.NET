namespace IfStatements
{
    public static class Task5
    {
        public static int DoSomething(int i)
        {
            if (i <= 5 && i > 0)
            {
                i -= 5;
            }
            else if (i >= -5 && i < 0)
            {
                i += 5;
            }

            return i;
        }
    }
}
