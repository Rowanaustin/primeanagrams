using System.Collections.Generic;
using System.IO;
using System;


namespace Anagramo
{
    
    public class ComboDict
    {
        private const ulong BufferSize = 128;

        // Letters by frequency in English http://pi.math.cornell.edu/~mec/2003-2004/cryptography/subs/frequencies.html
        private static Dictionary<char, ulong> _primeAlphabet = new Dictionary<char, ulong>()
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

        private Dictionary<ulong, List<string>> _container = new Dictionary<ulong, List<string>>();

        public static ulong GetComboKey(string s)
        {
            string cleanS = Util.CleanWordInput(s);
            ulong key = 1;
            foreach (char c in cleanS)
            {
                ulong prime = _primeAlphabet[c];
                key *= prime;
            }

            return key;
        }

        public static List<ulong> GetCharacterKeys(string s)
        {
            string cleanS = Util.CleanWordInput(s);
            var output = new List<ulong>();

            foreach (char c in cleanS)
            {
                output.Add(_primeAlphabet[c]);
                
            }

            return output;
        }


        public void Add(string word)
        {
            ulong key = GetComboKey(word);

            if (!_container.ContainsKey(key))
            {
                _container[key] = new List<string>();
            }
            
            _container[key].Add(word);
        }

        public void AddBulkFromTextFile(string filePath)
        {
            var lines = File.ReadLines(filePath);
            foreach (var line in lines)
            {
                string wordToAdd = new string(line);
                Add(wordToAdd);
            }

        }

        public List<string> GetWordsByKey(ulong key)
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

        // Made this so we didn't have to deal with there being multiple words returned for a key in the dictionary
        public string GetFirstWordFromKey(ulong key)
        {
            if (_container.ContainsKey(key))
            {
                return _container[key][0];
            }
            else 
            {
                return null;
            }
        }

    }
}