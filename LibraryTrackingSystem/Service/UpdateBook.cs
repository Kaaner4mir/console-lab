class UpdateBook
{
    public static void Update()
    {
        Console.Clear();
        DataStore.List();

        int id = ConsoleHelper.GetInput<int>("\n🪪 Enter the ID of the book you want to update : ");

        var account = DataStore.ExampleBooks().FirstOrDefault(x => x.BookId == id);

        if (account == null)
        {
            ConsoleHelper.WriteColored("\n❓The book could not be found.");
            return;
        }

        Console.Clear();
        Menu.DisplayUpdateMenu();

        short choice = ConsoleHelper.GetInput<short>("\n👉 Select the operation you want to perform numerically : ");
        Console.WriteLine();

        switch (choice)
        {
            case 1:
                account.BookName = ConsoleHelper.GetInput<string>("🏷️ Book name: ");
                break;
            case 2:
                account.Author = ConsoleHelper.GetInput<string>("👤 Author: ");
                break;
            case 3:
                account.Publisher = ConsoleHelper.GetInput<string>("🌆 Publisher: ");
                break;
            case 4:
                account.PublicationYear = ConsoleHelper.GetInput<string>("📅 Publishing year: ");
                break;
            case 5:
                account.Genre = ConsoleHelper.GetInput<string>("🎭 Genre: ");
                break;
            case 6:
                account.Language = ConsoleHelper.GetInput<string>("🌐 Language: ");
                break;
            case 7:
                account.PageCount = ConsoleHelper.GetInput<string>("📆 Page count: ");
                break;
            default:
                ConsoleHelper.WriteColored("\n❓ The operation you want to perform could not be found!", ConsoleColor.Yellow);
                break;
        }

        ConsoleHelper.WriteColored("\n✅ Book information updated successfully.", ConsoleColor.Green);
    }
}
