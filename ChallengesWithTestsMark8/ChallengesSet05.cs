using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int num = 0;
            
            for (int i = startNumber; i < 1000; i++) 
            {
                if (i % n == 0 || i / n == 1) 
                {
                    num = i;
                    break;
                }
            }
            
            return num;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach(Business biz in businesses) 
            {
                if (biz.TotalRevenue == 0) 
                {
                    biz.Name = "CLOSED";
                }
            }   
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            bool ascend = false;

            if(numbers == null) { return false; }
            
            for (int i = 0; i < numbers.Length; i++) 
            {
                if(numbers[i+1] >= numbers[i]) 
                {
                    ascend = true;
                }

                else if (numbers[i + 1] < numbers[i])
                {
                    return false;
                }
            }
            return ascend;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;    

            if (numbers == null || numbers.Any() == false) { return 0; }
            
            for(int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i] % 2 == 0) 
                {
                    sum += numbers[i+1];
                }
            }

            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            string sentence = "";
          
            if (words == null) { return sentence; }
            
            for(int i = 0; i < words.Length; i++)
            {
                if (i < words.Length - 1 && !string.IsNullOrWhiteSpace(words[i])) 
                {
                    sentence += words[i].Trim() + " ";
                }
                if (i == words.Length - 1 && !string.IsNullOrWhiteSpace(words[i])) 
                {
                    sentence += words[i].Trim() + '.';
                }
            }
            return sentence.Trim();
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            List<double> result = new List<double>();

            if (elements == null) 
            {
                return result.ToArray();
            }
            
            for (int i = 0; i < elements.Count; i++) 
            {
                if((i +1) % 4 == 0) 
                {
                    result.Add(elements[i]);
                }
            }

            return result.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            bool different = false;

            for (int i = 0; i < nums.Length-1; i++) 
            {
                for(int j = 1; j < nums.Length; j++) 
                {
                        if (nums[i] + nums[j] == targetNumber)
                        {
                            different =  true;
                            goto loopEnd;
                        }
                        if (nums[i] < 0 || nums[j] < 0) 
                        {
                            different = false;
                        }
                }
               
            }
            loopEnd:
            return different;
        }
    }
}
