namespace loopsExercises5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input numbers separated by commas");
            string input = Console.ReadLine();
            string[] numbers = input.Split(",");

            int max = Convert.ToInt32(numbers[0]);

            foreach (string str in numbers)
            {
                int number = Convert.ToInt32(str);
                if(number > max)
                    max = number;
            }
            Console.WriteLine("Max is " + max);
        }
    }
}
