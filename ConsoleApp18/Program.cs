using ConsoleApp18;
using System.Runtime.InteropServices;
using static ConsoleApp18.Elephant;

internal class Program
{
    static void Main(string[] args)
    {
        Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize= 33};
        Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };

        Console.WriteLine("Press 1 for lloyd, 2 for lucinda, 3 to swap");
        while (true)
        {
            char input = Console.ReadKey(true).KeyChar;
            Console.WriteLine($"you pressed {input}");
            if (input == '1')
            {
                Console.WriteLine("calling whoami for lloyd");
                lloyd.WhoAmI();
                lloyd.HearMessage("hi", lucinda);
            }
            else if (input == '2')
            {
                Console.WriteLine("calling whoami for lucinda");
                lucinda.WhoAmI();
            }
            else if (input == '3')
            {
                Elephant holder = new Elephant();
                holder = lloyd;
                lloyd = lucinda;
                lucinda = holder;
                Console.WriteLine("Reference swapped");
            }

            else if (input == '4')
            {
                lloyd = lucinda;
                lloyd.EarSize = 3333;
                lloyd.WhoAmI();
            }

            else if (input == 5)
            {
                lucinda.SpeakTo(lloyd, "Hi, Lloyd!");
            }

            else
            {
                return;
            }
            Console.WriteLine();
        }
    }
}