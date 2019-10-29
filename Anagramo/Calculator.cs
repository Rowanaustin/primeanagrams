namespace Anagramo
{
    internal static class Util
    {
        public static int GenerateFactorial(int a)
        {
            // A Factorial of 13 would bring us over the max value of an Int32
            // TODO: Use ulong if the extra range is needed
            const int INPUT_MAX = 12;

            if (a >= 0 && a <= INPUT_MAX)
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
