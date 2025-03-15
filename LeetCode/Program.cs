using Helpers;
using LeetCode.EasyProblems;

Console.Write("Roman number: ");
var number = Console.ReadLine()!;

var n = new Problem13().RomanToInt(number);
Console.WriteLine(n);