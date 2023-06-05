using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using System.Text;

[Route("ConstInterpolatedStrings")]
public static class ApiRoutes
{
    private const string ApiBase = "/api";

    public static class Library
    {
        private const string Base = ApiBase + "/library";
        public const string GetById = Base + "/{id:guid}";
        public const string GetByIdInterpolated = $"{Base}/ {{id: guid}}";
        public const string GetAll = Base;
        public const string Add = Base + "/{id:guid}";
    }
}

public class Programm
{
    public static void Main()
    {
        var a = 15;
        var b = 1;
        var c = $"Это A: {a}, а это B: {b}";

        c = string.Format("Это A: {0}, а это B: {1}", a, b);

        var handler = new DefaultInterpolatedStringHandler(28, 2);
        handler.AppendLiteral("Это A: ");
        handler.AppendFormatted(a);
        handler.AppendLiteral(", а это B: ");
        handler.AppendFormatted(b);
        c = handler.ToStringAndClear();

        MyInterpolatedStringHandler myHandler = $"Это A: {a}, а это B: {b}";
        Console.WriteLine(myHandler.GetString());
    }
}

[InterpolatedStringHandler]
public ref struct MyInterpolatedStringHandler
{
    private readonly StringBuilder _stringBuilder = new();
    public MyInterpolatedStringHandler(int literalLength, int formattedCount) { }
    public void AppendLiteral(string value) => _stringBuilder.Append(value);
    public void AppendFormatted<T>(T value)
    {
        /// правила форматирования (+условное выполнение +передача контекста)
        _stringBuilder.Append("\x1b[31;1m");
        _stringBuilder.Append(value);
        _stringBuilder.Append("\x1b[0m");
    }
    public string GetString() => _stringBuilder.ToString();
}