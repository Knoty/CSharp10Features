using System.Diagnostics.CodeAnalysis;

Func<string> helloWorld = () => "Указывать тип делегата необязательно!";
var newHelloWorld = () => "Указывать тип делегата необязательно!";
Console.WriteLine(newHelloWorld());
var text = () => null;

var concat = ([DisallowNull] string a, [DisallowNull] string b) => a + b;
var inc = [return: NotNullIfNotNull(nameof(s))] (int? s) => s.HasValue ? s++ : null;
