using Helpers;
using LeetCode.EasyProblems;

Console.Write("nums1: ");
var nums1 = InputHelper.ParseToIntArray(Console.ReadLine());
Console.Write("m: ");
var m = int.Parse(Console.ReadLine()!);
Console.Write("nums2: ");
var nums2 = InputHelper.ParseToIntArray(Console.ReadLine());
Console.Write("n: ");
var n = int.Parse(Console.ReadLine()!);

new Problem88().Merge(nums1, m, nums2, n);
Console.WriteLine(string.Join(',', nums1));