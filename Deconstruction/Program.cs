
var book = new Book("CLR via C#", "Jeffrey Richter");

// Объявление
(string x, string y) = book;

// Присовение
string x1 = string.Empty;
string y1 = string.Empty;
(x1, y1) = book;

// C#10
string x2 = string.Empty;
(x2, string y2) = book;
Console.WriteLine(x2 + " от " + y2);

internal record Book(string Title, string Author);