using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null) { return false; }
            
            foreach(var w in words) 
            {
                if (!string.IsNullOrEmpty(w)) 
                {
                    if (ignoreCase && w.ToLower().Contains(word))
                    {
                        return true;
                    }
                    else if (ignoreCase == false && w.Contains(word))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        
        public bool IsPrimeNumber(int num)
        {
            int[] nums = new int[] { 3, 5, 7, 11 };

            if (num <= 0 || num == 1) 
            {
                return false;
            }

            
            if(num % 3 == 0 || num % 2 != 0 || num == 2) 
            {
                return true;
            }



            return false;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            throw new NotImplementedException();
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            throw new NotImplementedException();
        }
    }
}
