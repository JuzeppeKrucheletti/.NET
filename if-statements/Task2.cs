namespace IfStatements
{
    public static class Task2
    {
        public static int DoSomething1(int i)
        {
            int result = i;
            if (i < -5)
            {
                result = -i * i;
            }
            else if (i < 0)
            {
                result = -i;
            }

            return result;
        }

        public static int DoSomething2(int i)
        {
            if (i < -5)
            {
                i = -i * i;
            }
            else if (i < 0)
            {
                i = -i;
            }

            return i;
        }
    }
}
