using static System.String;
using LeetCode;

namespace LeetCodeTests
{
    public class PrintFibonacci
    {
        [Fact]
        public void Execute_1()
        {
            var result = LeetCode.PrintFibonacci.Execute(10);
            Assert.Equal(result[0], 0);
            Assert.Equal(result[1], 1);
            Assert.Equal(result[2], 1);
            Assert.Equal(result[3], 2);
            Assert.Equal(result[4], 3);
            Assert.Equal(result[5], 5);
            Assert.Equal(result[6], 8);
            Assert.Equal(result[7], 13);
            Assert.Equal(result[8], 21);
            Assert.Equal(result[9], 34);
            Assert.Equal(result.Count(), 10);
            
        }
    }
}