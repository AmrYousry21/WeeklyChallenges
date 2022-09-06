using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach(bool val in vals) 
            {
                if(val == false) 
                {
                    return true; 
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int sum = 0;

            if (numbers == null) { return false; }    
            
            foreach(int n in numbers) 
            {
                if(n % 2 != 0) 
                {
                    sum += n;
                }
            }
            bool isOdd = (sum % 2 != 0) ? isOdd = true : isOdd = false;
            return isOdd;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {

            string lowerLetters = "qwertyuiopasdfghjklzxcvbnm";
            string upperletters = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string numbers = "1234567890";
            bool digit = false;
            bool isLower = false;
            bool isUpper = false;
            
            foreach (char c in password) 
            {
                if (lowerLetters.Contains(c.ToString()))
                {
                    isLower = true;
                    break;
                }
                if (upperletters.Contains(c.ToString())) 
                {
                    isUpper = true;
                    break;
                }
                if (numbers.Contains(c.ToString()))
                {
                    digit = true;
                    break;
                }

                if (digit == true && isLower == true && isUpper == true)
                {
                    return true;
                }
            }

           

            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[^1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            decimal result = (divisor == 0)  ? result = 0 : dividend / divisor;
            return result;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[^1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            List<int> result = new List<int>();
            for (int i = 0; i < 100; i++) 
            {
                if (i % 2 != 0) 
                {
                    result.Add(i);
                }
            }

            return result.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            int counter = 0;
            foreach(string word in words) 
            {
                words[counter] = word.ToUpper();
                counter++;
            }
        }
    }
}
