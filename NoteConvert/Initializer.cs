using System.Text;

class Initilazier
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        while (true)
        {
            Console.Clear();
            Console.Write("👉 Enter your grade : ");
            if (!double.TryParse(Console.ReadLine(), out double input)) { Console.WriteLine("\n❌ Invalid transaction"); continue; ; }

            if (input > 100 || input < 0) { Console.WriteLine("\nEnter a valid value"); continue; }

            double grade = input / 100 * 4;

            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n✅ Your grade : {grade}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
            Console.CursorVisible = true;
        }
    }
}
