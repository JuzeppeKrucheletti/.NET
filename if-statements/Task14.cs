namespace IfStatements
{
    public static class Task14
    {
        public static int DoSomething(bool b1, bool b2, int i)
        {
            if (b1 && b2)
            {
                if (i <= -5)
                {
                    i = 10 - (i * 2);
                }
                else if (i <= 5 && i > -5)
                {
                    i *= -2;
                }
                else if (i > 5)
                {
                    i = 10 - (i * 2);
                }
            }

            if (b1 && !b2)
            {
                if (i <= -5)
                {
                    i = i * i * i;
                }
                else if (i <= 5 && i > -5)
                {
                    i *= i;
                }
                else if (i > 5)
                {
                    i = i * i * i;
                }
            }

            if (!b1 && b2)
            {
                if (i < -9)
                {
                    i *= -1;
                }
                else if (i >= -7 && i < -3)
                {
                    i *= 10;
                }
                else if (i > 7)
                {
                    i *= -1;
                }
            }

            if (!b1 && !b2)
            {
                if (i < -9)
                {
                    i *= -1;
                }
                else if (i < 0 && i >= -3)
                {
                    i *= -100;
                }
                else if (i > 0 && i < 5)
                {
                    i *= -100;
                }
                else if (i > 7)
                {
                    i *= -1;
                }
            }

            return i;
        }
    }
}
