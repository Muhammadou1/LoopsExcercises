namespace LoopsExercises4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var number = rand.Next(1, 10);
            var guess = 0;

            Console.WriteLine("Write a number between 1 and 10 ");
            //Console.WriteLine("Secret is " + number);
            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine("Guess the number ");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess == number)
                {
                    Console.WriteLine("You won");
                    break;
                } else
                    Console.WriteLine("You Lost");
            }

            Console.WriteLine("Thank you for playing.");

        }
    }
}
