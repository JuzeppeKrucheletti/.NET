namespace IfStatements
{
    public static class Task13
    {
        public static int DoSomething(bool b, int i)
        {
            if (b)
            {
                if (i < -8 || (i >= -4 && i < 0))
                {
                    i += 5;
                }
                else if (i == 0)
                {
                    i = 10;
                }
                else if (i <= 3 && i > 0)
                {
                    i -= 5;
                }
                else if (i > 3)
                {
                    i *= -1;
                }
            }
            else
            {
                if (i <= -5 || i > 5)
                {
                    i *= -1;
                }
                else
                {
                    i = 10 - i;
                }
            }

            return i;
        }
    }
}
