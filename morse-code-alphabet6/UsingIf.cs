namespace MorseCodeAlphabet
{
    public static class UsingIf
    {
        public static string GetMorseCode(char c)
        {
            if (c == 'A' || c == 'a')
            {
                return ".-";
            }
            else if (c == 'B' || c == 'b')
            {
                return "-...";
            }
            else if (c == 'C' || c == 'c')
            {
                return "-.-.";
            }
            else if (c == 'D' || c == 'd')
            {
                return "-..";
            }
            else if (c == 'e' || c == 'E')
            {
                return ".";
            }
            else if (c == 'f' || c == 'F')
            {
                return "..-.";
            }
            else if (c == 'g' || c == 'G')
            {
                return "--.";
            }
            else if (c == 'h' || c == 'H')
            {
                return "....";
            }
            else if (c == 'i' || c == 'I')
            {
                return "..";
            }
            else if (c == 'j' || c == 'J')
            {
                return ".---";
            }
            else if (c == 'k' || c == 'K')
            {
                return "-.-";
            }
            else if (c == 'l' || c == 'L')
            {
                return ".-..";
            }
            else if (c == 'm' || c == 'M')
            {
                return "--";
            }
            else if (c == 'n' || c == 'N')
            {
                return "-.";
            }
            else if (c == 'o' || c == 'O')
            {
                return "---";
            }
            else if (c == 'p' || c == 'P')
            {
                return ".--.";
            }
            else if (c == 'q' || c == 'Q')
            {
                return "--.-";
            }
            else if (c == 'r' || c == 'R')
            {
                return ".-.";
            }
            else if (c == 's' || c == 'S')
            {
                return "...";
            }
            else if (c == 't' || c == 'T')
            {
                return "-";
            }
            else if (c == 'u' || c == 'U')
            {
                return "..-";
            }
            else if (c == 'v' || c == 'V')
            {
                return "...-";
            }
            else if (c == 'w' || c == 'W')
            {
                return ".--";
            }
            else if (c == 'x' || c == 'X')
            {
                return "-..-";
            }
            else if (c == 'y' || c == 'Y')
            {
                return "-.--";
            }
            else if (c == 'z' || c == 'Z')
            {
                return "--..";
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
