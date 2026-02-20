using System.Globalization;

StringComparer numericStringComparer = StringComparer.Create(CultureInfo.CurrentCulture, CompareOptions.StringSort);

Console.WriteLine(numericStringComparer.Equals("02", "2"));

foreach (string dotnet in new[] { ".NET 8", ".NET 10", ".NET 11" }.Order(numericStringComparer))
{
    Console.WriteLine(dotnet);
}

HashSet<string> set = new HashSet<string>(numericStringComparer) { "007" };
Console.WriteLine(set.Contains("7"));
