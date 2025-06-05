namespace Loops_Excercises2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            while (true)
            {
                // Console.WriteLine("Keep Entering a number or type OK to exit");
                //var line = Console.ReadLine();
                // if (line == "ok" || line == "OK")
                // {
                //     break;
                // }

                Console.WriteLine("Keep Entering a number or type OK to exit");
                var input = Console.ReadLine();
                if (input.ToLower() == "ok")
                {
                    break;
                }else
                {
                    var number = Convert.ToInt32(input);
                    sum = sum + number;
                }
            }
            Console.WriteLine("Total numbers added is  " + sum);

        }
    }
}
