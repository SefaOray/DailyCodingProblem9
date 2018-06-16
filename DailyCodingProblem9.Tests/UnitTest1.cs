using System;
using Xunit;
using DailyCodingProblem9;

namespace DailyCodingProblem9.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 2,4,6,8 }, 12)]
        [InlineData(new int[] {5,1,1,5}, 10)]
        public void Test_largest_sum_NonAdjacent(int[] numbers, int expectedResult)
        {
            var result = Program.GetLargestSumOfNonAdjacent(numbers);

            Assert.Equal(expectedResult, result);
        }
    }
}
