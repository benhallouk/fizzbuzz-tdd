namespace FizzBuzzSolution.UnitTests
{
    using NUnit.Framework;
    using System.Linq;

    [TestFixture]
    public class FizzBuzzShould
    {
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        [TestCase(6, "Fizz")]
        [TestCase(9, "Fizz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(30, "FizzBuzz")]
        [TestCase(60, "FizzBuzz")]
        [TestCase(5, "Buzz")]
        [TestCase(10, "Buzz")]
        public void ReturnAFizzBuzzValue(int inputNumber, string expectedResult)
        {
            Assert.AreEqual(expectedResult, FizzBuzzConverter.Convert(inputNumber));
        }

        [Test]
        public void CanGet100Answers()
        {
            Assert.AreEqual(100, FizzBuzzConverter.GetAnswers().Count());
        }

        [Test]
        public void ReturnAnswersWhereFirstItemIs1()
        {
            Assert.AreEqual("1", FizzBuzzConverter.GetAnswers().First());
        }

        [Test]
        public void ReturnsTheCorrectAnswers()
        {
            var correctAnswers = Enumerable.Range(1, 100).Select(FizzBuzzConverter.Convert);

            Assert.AreEqual(correctAnswers, FizzBuzzConverter.GetAnswers());
        }
    }
}
