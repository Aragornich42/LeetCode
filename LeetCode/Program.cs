using LeetCode.CustomProblems;
using Helpers;

var nums = Console.ReadLine();
var target = Console.ReadLine()!;
var result = new Problem1().TwoSum(InputHelper.ParseToIntArray(nums), int.Parse(target));
Console.WriteLine(string.Join(',', result));
