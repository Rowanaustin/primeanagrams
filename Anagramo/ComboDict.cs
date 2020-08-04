using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;


namespace Anagramo
{
    
    public class ComboDict
    {
        private const ulong BufferSize = 128;

        // Letters by frequency in English http://pi.math.cornell.edu/~mec/2003-2004/cryptography/subs/frequencies.html
        
        private static List<ulong> _primes = new List<ulong>
        {
            2,
            3,
            5,
            7, 
            11,
            13,
            17,
            19,
            23,
            29,
            31,
            37,
            41,
            43,
            47,
            53,
            59,
            61,
            67,
            71,
            73,
            79,
            83,
            89,
            97,
            101
        };
        
        private static Dictionary<char, ulong> _primeAlphabet = new Dictionary<char, ulong>();

        private Dictionary<ulong, List<string>> _container = new Dictionary<ulong, List<string>>();

        public ComboDict(string wordInput)
        {
            wordInput = Util.CleanWordInput(wordInput);
            int currentPrimeIndex = 0;

            Dictionary<char,int> frequencyMap = new Dictionary<char, int>();
            foreach (char c in wordInput)
            {
                if (!frequencyMap.ContainsKey(c))
                {
                    frequencyMap[c] = 1;
                    continue;
                }
                frequencyMap[c]++;
            }


            var keys = new List<char>(frequencyMap.Keys);
            keys.OrderByDescending(x => frequencyMap[x]);

            foreach (char c in keys)
            {
                if (!_primeAlphabet.ContainsKey(c))
                {
                    ulong currentPrime = _primes[currentPrimeIndex];
                    _primeAlphabet[c] = currentPrime;
                    currentPrimeIndex++;
                }                
            }

            Util.PrintDictionary(_primeAlphabet);
        }

        public static ulong GetComboKey(string s)
        {
            s = Util.CleanWordInput(s);
            ulong key = 1;
            foreach (char c in s)
            {
                if (!_primeAlphabet.ContainsKey(c))
                {
                    return 0;
                }

                key *= _primeAlphabet[c];
            }
            return key;
        }

        public static List<ulong> GetCharacterKeys(string s)
        {
            s = Util.CleanWordInput(s);
            var output = new List<ulong>();

            foreach (char c in s)
            {
                output.Add(_primeAlphabet[c]);
                
            }

            return output;
        }


        public void Add(string word)
        {
            ulong key = GetComboKey(word);

            if (key == 0)
            {
                //Console.WriteLine($"Tried to add {word} but it had unscrupulous characters");
                return;
            }


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