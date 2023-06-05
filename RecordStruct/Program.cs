
public class Book
{
    public string? Title { get; set; }
    public string? Author { get; set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }
}

public class Program
{
    public static void Main()
    {
        var book1 = new Book("CLR via C#", "Jeffrey Richter");
        Book book2 = new Book("CLR via C#", "Jeffrey Richter");

        Console.WriteLine("Проверка равенства: " + (book1 == book2));

        Console.WriteLine(book1.Title);
        book1.Title = "CLR via F#";
        //book1 = book1 with { Title = "CLR via F#" };
        Console.WriteLine(book1.Title);

        Console.WriteLine("ToString: " +  book1.ToString());
    }
}

public record class Book1(string Title, string Author);

public readonly record struct Book2(string Title, string Author);

public record Book3
{
    public Book3(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public string Title { get; init; }
    public string Author { get; init; }

    public override string ToString()
    {
        return base.ToString();
    }
}

public record PlayBook : Book3
{
    public PlayBook(string title, string author) : base(title, author)
    {
    }

    public override string ToString()
    {
        return base.ToString();
    }
}
