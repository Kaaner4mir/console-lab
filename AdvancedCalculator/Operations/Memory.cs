class Memory
{
    static double _memory = 0;

    public static void Initializer()
    {
        try
        {
            Console.Clear();
            Menu.MemoryMenu();
            short choice = ConsoleHelper.GetInput<short>("\n👉 Select the action you want to perform : ");
            Console.WriteLine();

            switch (choice)
            {
                case 1: MemoryOperations("add"); break;
                case 2: MemoryOperations("subtract"); break;
                case 3: MemoryOperations("clear"); break;
                case 4: MemoryOperations("recall"); break;
                default: ConsoleHelper.WriteColored("\n❗ Invalid choice!", ConsoleColor.Red); break;
            }
        }
        catch (Exception exc)
        {
            ConsoleHelper.WriteColored($"\n⛔ Error : {exc.Message}", ConsoleColor.DarkRed);
        }
    }

    public static void MemoryOperations(string operationName)
    {
        switch (operationName.ToLower())
        {
            case "add":
                double addNum = ConsoleHelper.GetInput<double>("👉 Enter the number you want to add onto memory : ");
                _memory += addNum;
                ConsoleHelper.WriteColored($"\n💾 Memory updated: {_memory}", ConsoleColor.Green);
                break;

            case "subtract":
                double subNum = ConsoleHelper.GetInput<double>("👉 Enter the number you want to subtract from memory : ");
                _memory -= subNum;
                ConsoleHelper.WriteColored($"\n💾 Memory updated : {_memory}", ConsoleColor.Green);
                break;

            case "recall":
                ConsoleHelper.WriteColored($"💾 Memory : {_memory}", ConsoleColor.Green);
                break;

            case "clear":
                _memory = 0;
                ConsoleHelper.WriteColored($"💾 Memory cleared.", ConsoleColor.Green);
                break;

            default:
                ConsoleHelper.WriteColored("\n❗ Invalid memory operation!", ConsoleColor.Red);
                break;
        }
    }
}

