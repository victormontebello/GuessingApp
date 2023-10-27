namespace NumberGuessingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
           
            int answer = rnd.Next(-50, 1000);
            string message;
            int count = 1;
            int number = 0;

            while  (number != answer)
            {
                message = "";
                number = int.Parse(Console.ReadLine());
                message = number == answer ? "YOU WIN" : message;
                message = number > answer ? "Is too high" : message;
                message = number < answer ? "Is too low" : message;

                    if(message == "YOU WIN") { Console.WriteLine($"{message} and you use {count} guesses"); }
                    else { Console.WriteLine(message); count++; }
            }

        }
    }
}