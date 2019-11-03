using System.Collections.Generic;

namespace Anagramo
{
    public class ComboDict
    {
        // Letters by frequency in English http://pi.math.cornell.edu/~mec/2003-2004/cryptography/subs/frequencies.html
        private static Dictionary<char, int> _primeAlphabet = new Dictionary<char, int>()
        {
            {'e', 2},
            {'t', 3},
            {'a', 5},
            {'o', 7},
            {'i', 11},
            {'n', 13},
            {'s', 17},
            {'r', 19},
            {'h', 23},
            {'d', 29},
            {'l', 31},
            {'u', 37},
            {'c', 41},
            {'m', 43},
            {'f', 47},
            {'y', 53},
            {'w', 59},
            {'g', 61},
            {'p', 67},
            {'b', 71},
            {'v', 73},
            {'k', 79},
            {'x', 83},
            {'q', 89},
            {'j', 97},
            {'z', 101},
        };

        private Dictionary<int, List<string>> _container = new Dictionary<int, List<string>>();

        internal static int GetComboKey(string s)
        {
            int key = 1;
            foreach (char c in s)
            {
                int prime = _primeAlphabet[c];
                key *= prime;
            }

            return key;
        }

        public void Add(string word)
        {
            int key = GetComboKey(word);

            if (!_container.ContainsKey(key))
            {
                _container[key] = new List<string>();
            }
            
            _container[GetComboKey(word)].Add(word);
        }

        public List<string> GetWordsByKey(int key)
        {
            if (_container.ContainsKey(key))
            {
                return _container[key];
            }
            else return null;
        }

        public List<string> GetWordsByWord(string word)
        {
            return GetWordsByKey(GetComboKey(word));
        }
    }
}