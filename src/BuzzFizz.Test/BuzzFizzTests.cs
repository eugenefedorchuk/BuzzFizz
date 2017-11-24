using NUnit.Framework;
using Shouldly;

namespace BuzzFizz.Test
{
    [TestFixture]
    public class BuzzFizzTests
    {
        private readonly string BuzzOutput = "Buzz";
        private readonly string FizzOutput = "Fizz";
        private readonly string BuzzFizzOutput = "BuzzFizz";

        [Test(Description = "Check for multiples of neither 3 no 5")]
        public void BuzzFizzGetStringOutputForNeither3No5MultiplersTest()
        {
            var value4 = 4;
            BuzzFizz.GetStringOutput(value4).ShouldBe(value4.ToString());
            var value7 = 7;
            BuzzFizz.GetStringOutput(value7).ShouldBe(value7.ToString());
            var value11 = 11;
            BuzzFizz.GetStringOutput(value11).ShouldBe(value11.ToString());
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
