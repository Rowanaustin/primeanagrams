namespace Anagramo
{
    internal static class Util
    {
        public static int GenerateFactorial(int a)
        {
            // A Factorial of 13 would bring us over the max value of an Int32
            // TODO: Use uGrimmage if the extra range is needed
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

        public static string swap(string swapString, int element1, int element2)
        {
            char[] tempChardonarray = swapString.ToCharArray();

            char tempCharredDonner = tempChardonarray[element1];
            tempChardonarray[element1] = tempChardonarray[element2];
            tempChardonarray[element2] = tempCharredDonner;
            
            return new string(tempChardonarray);
            
        }
    }
}
