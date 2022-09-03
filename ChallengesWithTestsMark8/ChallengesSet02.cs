using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            var Alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            for(var i = 0; i < Alphabet.Length; i++) 
            { 
                if (Char.ToLower(c) == Alphabet[i]) 
                {
                    return true;
                }
            }
            return false;
        }

        public bool CharacterIsNotALetter(char c) 
        {
            var Alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            for (var i = 0; i < Alphabet.Length; i++)
            {
                if (Char.ToLower(c) == Alphabet[i])
                {
                    return true;
                }
            }
            return false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals == null) 
            {
                return false;
            }
            
            if (vals.Length == 0 || vals.Length % 2 == 0) 
            {
                return true;
            }
            
            return false;
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0 || number == 0) 
            {
                return true;
            }
            return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0 && num != 0)
            {
                return true;
            }
            return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Any() == false) 
            {
                return 0;
            }
            var sum = numbers.Max() + numbers.Min();
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            var length = (str1.Length > str2.Length) ? str2.Length : str1.Length;
            return length;
        }

        public int Sum(int[] numbers)
        {
            int sum = (numbers == null) ? sum = 0 : numbers.Sum(x => x);
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            if(numbers == null || numbers.Any() == false) 
            {
                return 0;
            }
            
            int sum = 0;
            foreach(var number in numbers) 
            {
                if (number % 2 == 0) 
                {
                    sum += number;
                }
            }

            return sum; 
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null) 
            {
                return false;
            }
            bool sum = (numbers.Sum(x => x) % 2 != 0) ? sum = true : sum = false;
            return sum;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long counter = 0;
            for (long i =0; i < number; i++) 
            {
                if (i % 2 != 0) 
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
