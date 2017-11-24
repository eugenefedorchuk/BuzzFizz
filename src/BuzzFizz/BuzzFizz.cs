namespace BuzzFizz
{
    public class BuzzFizz
    {
        public static string GetStringOutput(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "BuzzFizz";
            }

            if (number % 3 == 0)
            {
                return "Buzz";
            }

            if (number % 5 == 0)
            {
                return "Fizz";
            }

            return number.ToString();
        }
    }
}
