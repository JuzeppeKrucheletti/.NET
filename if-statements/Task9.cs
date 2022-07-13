namespace IfStatements
{
    public static class Task9
    {
        public static bool DoSomething(bool b, int i)
        {
            if (i == 4)
            {
                if (b)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (i == 8)
            {
                if (b)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            bool result = false;
            if (i != 0 && (Math.Abs(i) > 8 || Math.Abs(i) <= 4))
            {
                result = true;
            }

            return result;
        }
    }
}
