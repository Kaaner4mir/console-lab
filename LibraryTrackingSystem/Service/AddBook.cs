class AddBook
{
    public static void Add()
    {
        Console.Clear();

        string newBookName = ConsoleHelper.GetInput<string>("🏷️ Book name: ");
        string newAuthor = ConsoleHelper.GetInput<string>("👤 Author: ");
        string newPublisher = ConsoleHelper.GetInput<string>("🌆 Publisher: ");
        string newPublishingYear = ConsoleHelper.GetInput<string>("📅 Publishing year: ");
        string newGenre = ConsoleHelper.GetInput<string>("🎭 Genre: ");
        string newLanguage = ConsoleHelper.GetInput<string>("🌐 Language: ");
        string newPageCount = ConsoleHelper.GetInput<string>("📆 Page count: ");

        DataStore.books.Add(new Book()
        {
            BookId = Random.Shared.Next(100000, 999999),
            BookName = newBookName,
            Author = newAuthor,
            Publisher = newPublisher,
            PublicationYear = newPublishingYear,
            Genre = newGenre,
            Language = newLanguage,
            PageCount = newPageCount
        });

        ConsoleHelper.WriteColored($"\n✅ The book has been successfully added.", ConsoleColor.Green, false);
    }
}