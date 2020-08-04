# PrimeAnagrams

An experimental anagram generation method using prime-factorisation techniques.

The program assigns prime numbers to each letter of the alphabet, allowing a word to be represented as the product of its prime letter values. As there is only a single true set of prime factors for any number, words with the same product will be anagrams of one another.

The program is not very efficient - there are plenty of 'better' ways to generate anagrams - but this solution was satisfyingly neat. One optimisation which was performed was to assign only the letters in the user's input phrase to the first N primes, which reduces the size of the numbers being used in calculations considerably.

A modern processor should be capable of returning anagrams for strings up to around 10 characters in length, although it may take a minute or so.
