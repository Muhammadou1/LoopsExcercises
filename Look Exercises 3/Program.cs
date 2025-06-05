namespace Look_Exercises_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to get its factor");
            var num = Convert.ToInt32(Console.ReadLine());
            var factor = 1;
            for (var i = 1; i <= num; i++)
            
                factor *= i;
                Console.WriteLine("The factor of {0} is {1}",num, factor);
        }


    }
}