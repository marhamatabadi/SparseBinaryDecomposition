using System.Diagnostics;
using System.Linq;

namespace SparseBinaryDecomposition.Test
{
    public class MainTest
    {
        [Theory]
        [InlineData([26, new int[] {5, 8, 9,10,16, 17, 18,21 }])]
        [InlineData([536870911, new int[] { 178956970, 357913941 }])]
        public void Solution_AnswerTest(int n, int[] expected)
        {
            int actual = Main.Solution(n);
            Assert.Contains(actual, expected);
        }


        [Fact]
        public void Solution_PerformanceTest()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 10000; i++) // Run function multiple times (adjust iterations)
            {
                int n = new Random().Next(int.MaxValue);
                Main.Solution(n);
            }
            stopwatch.Stop();
            double elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
            Assert.True(elapsedMilliseconds < 100, "elapsed Milliseconds Should be less then 100ms");

        }
    }
}