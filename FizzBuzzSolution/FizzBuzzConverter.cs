namespace FizzBuzzSolution
{
    using System.Collections.Generic;
    using System.Linq;

    public class FizzBuzzConverter
    {
        public static string Convert(int i)
        {
            if ((i % 3 + i % 5) == 0)
            {
                return "FizzBuzz";
            }
            if (i % 3 == 0)
            {
                return "Fizz";
            }
            if (i % 5 == 0)
            {
                return "Buzz";
            }

            return i.ToString();
        }

        public static IEnumerable<string> GetAnswers()
        {
            return new string[100].Select(x => "1");
        }
    }
}
