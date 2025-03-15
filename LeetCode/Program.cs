using Helpers;
using LeetCode.EasyProblems;

Console.Write("prices: ");
var nums = InputHelper.ParseToIntArray(Console.ReadLine());

var n = new Problem121().MaxProfit(nums);
Console.WriteLine(n);