using System.Diagnostics.CodeAnalysis;

Func<string> helloWorld = () => "Hello world";
var newHelloWorld = () => "Hello world";
Console.WriteLine(newHelloWorld());
var text = () => null;

var concat = ([DisallowNull] string a, [DisallowNull] string b) => a + b;
var inc = [return: NotNullIfNotNull(nameof(s))] (int? s) => s.HasValue ? s++ : null;
