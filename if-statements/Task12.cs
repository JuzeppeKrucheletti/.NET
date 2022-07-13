namespace IfStatements
{
    public static class Task12
    {
        public static int DoSomething(int i)
        {
            if (i < -8)
            {
                i = i * i;
            }
            else if (i >= -5 && i < 5)
            {
                i = (i * i) - i;
            }
            else if (i >= 10)
            {
                i *= -i;
            }

            return i;
        }
    }
}
