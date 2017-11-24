using System.Collections.Generic;
using NUnit.Framework;
using Shouldly;

namespace BuzzFizz.Test
{
    [TestFixture]
    public class BuzzFizzTests
    {
        private static readonly string BuzzOutput = "Buzz";
        private static readonly string FizzOutput = "Fizz";
        private static readonly string BuzzFizzOutput = BuzzOutput + FizzOutput;

        [Test(Description = "Check for multiples of neither 3 no 5")]
        public void BuzzFizzGetStringOutputForNeither3No5MultiplersTest()
        {
            var testNumbers = new List<int> {4, 7, 11};
            foreach (var testNumber in testNumbers)
            {
                BuzzFizz.GetStringOutput(testNumber).ShouldBe(testNumber.ToString());
            }
        }

        [Test(Description = "Check for multiples of 3")]
        public void BuzzFizzGetStringOutputFor3MultiplerTest()
        {
            BuzzFizz.GetStringOutput(3).ShouldBe(BuzzOutput);
            BuzzFizz.GetStringOutput(6).ShouldBe(BuzzOutput);
            BuzzFizz.GetStringOutput(9).ShouldBe(BuzzOutput);
        }

        [Test(Description = "Check for multiples of 5")]
        public void BuzzFizzGetStringOutputFor5MultiplerTest()
        {
            BuzzFizz.GetStringOutput(5).ShouldBe(FizzOutput);
            BuzzFizz.GetStringOutput(20).ShouldBe(FizzOutput);
            BuzzFizz.GetStringOutput(100).ShouldBe(FizzOutput);
        }

        [Test(Description = "Check for multiples of 3 and 5")]
        public void BuzzFizzGetStringOutputFor3And5MultiplersTest()
        {
            BuzzFizz.GetStringOutput(15).ShouldBe(BuzzFizzOutput);
            BuzzFizz.GetStringOutput(30).ShouldBe(BuzzFizzOutput);
            BuzzFizz.GetStringOutput(60).ShouldBe(BuzzFizzOutput);
        }
    }
}
