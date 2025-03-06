using Helpers;
using LeetCode.EasyProblems;

Console.Write("nums: ");
var nums = InputHelper.ParseToIntArray(Console.ReadLine());

var n = new Problem169().MajorityElement(nums);
Console.WriteLine(n);