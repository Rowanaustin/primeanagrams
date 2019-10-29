namespace Anagramo
{
    internal static class Util
    {
        public static int GenerateFactorial(int a)
        {
            if (a >= 0 && a < 50)
            {
                int b = 1;
                for (int i = a; i > 1; i--)
                {
                    b *= i;
                }
                
                return b;
            }
            else
            {
                return 0;
            }
        }
    }
}
