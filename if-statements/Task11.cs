namespace IfStatements
{
    public static class Task11
    {
        public static int DoSomething(bool b1, bool b2, int i)
        {
            if (b1 && b2)
            {
                if (i < 8 && i >= 4)
                {
                    i *= 2;
                }
                else if (i >= -8 && i < -4)
                {
                    i *= 3;
                }
                else if (i == 0)
                {
                    i = 1;
                }
            }

            if (b1 && !b2)
            {
                if (i <= 7 && i > 3)
                {
                    i = 10 - (i * 2);
                }
                else if (i > -7 && i <= -3)
                {
                    i = 10 + (i * 3);
                }
                else if (i == 0)
                {
                    i = -1;
                }
            }

            if (!b1 && b2)
            {
                if (i < -8)
                {
                    i -= i * i;
                }
                else if (i >= 8)
                {
                    i -= i * i;
                }
                else if (i == 0)
                {
                    i = 1;
                }
                else if (i <= 4 && i > -4)
                {
                    i = (i * i) - (i * i * i);
                }
            }

            if (!b1 && !b2)
            {
                if (i <= -7)
                {
                    i -= i * i * i;
                }
                else if (i > 7)
                {
                    i -= i * i * i;
                }
                else if (i == 0)
                {
                    i = 1;
                }
                else if (i < 3 && i >= -3)
                {
                    i = (i * i * i) - (i * i);
                }
            }

            return i;
        }
    }
}
