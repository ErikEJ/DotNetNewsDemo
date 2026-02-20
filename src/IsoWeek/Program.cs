using System.Globalization;

Console.WriteLine(ISOWeek.GetWeekOfYear(new DateOnly(2024, 12, 31)));

Console.WriteLine(ISOWeek.GetWeekOfYear(new DateOnly(2025, 12, 31)));

Console.WriteLine(ISOWeek.GetWeekOfYear(new DateOnly(2026, 12, 31)));

Console.WriteLine(ISOWeek.GetYear(new DateOnly(2024, 1, 1)));
