namespace Anagramo
{
    internal class Combinator
    {
        public string[] Combos(string inputWord)
        {
            int length = inputWord.Length;
            string[] output = new string[length];
            output[0] = inputWord;

            if (length == 1)
            {
                return output;
            }
            else
            {
                output = new string[length];

                for (int i=0;i<length;i++)
                {
                    int j = 0 + i;
                    int k = 1 - i;

                    char[] chars = new char[2]
                    {
                        inputWord[j],
                        inputWord[k]
                    };
                    
                    output[i] = new string(chars);
                }

                return output;
            }
        }
    }
}