using System.Runtime.CompilerServices;

public class Program
{
    public static void Validate(bool condition, [CallerArgumentExpression("condition")] string? message = null)
    {
        if (!condition)
        {
            throw new InvalidOperationException($"Некорректный аргумент: <{message}>");
        }
    }

    public static void Main()
    {
        Validate(false);
    }
}