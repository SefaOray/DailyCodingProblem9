using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DailyCodingProblem9
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Scans the array from the begging and end of the array to find the largest sum of non-adjacent numbers
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int GetLargestSumOfNonAdjacent(int[] numbers)
        {
            //Starts at -1 because we increase the start index at every scan iteration
            var startIndex = -1;
            var endIndex = numbers.Length - 1;

            //Stop when indexes adjacent to each other
            var atAdjacentIndex = false;

            var largest = 0;
            var secondLargest = 0;

            while(!atAdjacentIndex)
            {
                startIndex++;
                //Current number at start index
                var startCandidateNumber = numbers[startIndex];

                //Check if startCandidateNumber is the new largest or the secondLargest number
                if (startCandidateNumber > largest)
                {
                    secondLargest = largest;
                    largest = startCandidateNumber;
                }
                else if (startCandidateNumber > secondLargest)
                    secondLargest = startCandidateNumber;

                //We processed number at index (endIndex +1) and moved index to endIndex -1 
                if (endIndex - startIndex == 1)
                {
                    atAdjacentIndex = true;
                    break;
                }

                //Current number at end index
                var endCandidateNumber = numbers[endIndex];

                if (endCandidateNumber > largest)
                {
                    secondLargest = largest;
                    largest = endCandidateNumber;
                }
                else if (endCandidateNumber > secondLargest)
                    secondLargest = endCandidateNumber;

                
                endIndex--;

                if (endIndex - startIndex == 1)
                    atAdjacentIndex = true;
            }

            return largest + secondLargest;
        }
    }
}
