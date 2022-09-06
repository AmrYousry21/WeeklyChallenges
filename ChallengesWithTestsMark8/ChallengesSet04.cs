using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            
            foreach(int number in numbers) 
            {
                if (number % 2 == 0) 
                {
                    sum += number;
                }
                else 
                {
                    sum -= number;
                }
            }
            return sum; 
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int shortestLen = str1.Length;
            
            List<string> strList = new List<string>();
           
            strList.Add(str2);
            strList.Add(str3);
            strList.Add(str4);
            
            for (int i = 0; i < 3; i++) 
            {
                if (strList[i].Length < shortestLen) 
                {
                    shortestLen = strList[i].Length;
                }
            }
            
            return shortestLen;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int smallestnum = number1;

            List<int> numList = new List<int>();

            numList.Add(number2);
            numList.Add(number3);
            numList.Add(number4);

            for (int i = 0; i < 3; i++)
            {
                if (numList[i] < smallestnum)
                {
                    smallestnum = numList[i];
                }
            }

            return smallestnum;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            var expectedName = "TrueCoders";

            biz.Name = expectedName;
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            int counter = 0;

            if (sideLength1 + sideLength2 > sideLength3) 
            {
                counter++;
            }

            if (sideLength2 + sideLength3 > sideLength1)
            {
                counter++;
            }

            if (sideLength1 + sideLength3 > sideLength2)
            {
                counter++;
            }

            bool result = (counter == 3) ? result = true : result = false;
            return result;
        }

        public bool IsStringANumber(string input)
        {
            bool isDigit = false;

            if (input == null) { return false; }
            
            foreach(char c in input) 
            {
                if (char.IsNumber(c) || c == '-' || c == '.') 
                {
                    isDigit = true;
                }
                else 
                {
                    return false;
                }
            }
            return isDigit;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int counter = 0;

            foreach (object obj in objs)
            {
                if (obj == null)
                {
                    counter++;
                }
            }

            if (counter > objs.Length / 2)
            {
                return true;
            }
            return false;
        }

        public double AverageEvens(int[] numbers)
        {
            List<int> evenNums = new List<int>();
            double sum = 0;
            double average = 0;

            if (numbers == null) { return 0; }
            
            foreach(int num in numbers) 
            {
                if (num % 2 == 0) 
                {
                    sum += num;
                    evenNums.Add(num);
                    average = sum / evenNums.Count;
                }
            }
            

            return average;
        }

        public int Factorial(int number)
        {
            int factorial = 1;

            for (int i = number; i >= 1; i--) 
            {
                factorial *= i;
            }

            if (number < 0) 
            {
                throw new ArgumentOutOfRangeException("Number is a negative number");
            }

            return factorial;
        }
    }
}
