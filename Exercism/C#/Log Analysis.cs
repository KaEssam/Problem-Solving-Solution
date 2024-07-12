using System;
using System.Linq;

public static class LogAnalysis
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string s, string d) => s.Split(d).Last();

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string s, string c1, string c2) => s.Split(c2).First().Split(c1).Last();

    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string s) => s.SubstringAfter(": ");

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string s) => s.SubstringBetween("[", "]");
}
