namespace IfStatements
{
    public static class Task10
    {
        public static int DoSomething(bool b1, bool b2, int i)
        {
            if (b1 && b2)
            {
                if (i <= 9 && i >= 2)
                {
                    i = 10 - i;
                }
                else if (i >= -9 && i <= -2)
                {
                    i += 5;
                }
                else if (i == 0)
                {
                    i = -1;
                }
            }

            if (b1 && !b2)
            {
                if (i <= 9 && i >= 2)
                {
                    i = 10 + i;
                }
                else if (i >= -9 && i <= -2)
                {
                    i = 5 - i;
                }
                else if (i == 0)
                {
                    i = -1;
                }
            }

            if (!b1 && b2)
            {
                if (Math.Abs(i) >= 10)
                {
                    i += 1;
                }
                else if (i == 0)
                {
                    i = 1;
                }
                else if (Math.Abs(i) < 5)
                {
                    i += 10;
                }
            }

            if (!b1 && !b2)
            {
                if (Math.Abs(i) >= 10)
                {
                    i -= 1;
                }
                else if (i == 0)
                {
                    i = -1;
                }
                else if (Math.Abs(i) < 5)
                {
                    i -= 10;
                }
            }

            return i;
        }
    }
}
