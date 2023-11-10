
using InterviewQuestion;

Console.WriteLine("Number prime, enter a number");
var num = Convert.ToInt32(Console.ReadLine());
Practices.GetNumberPrime(num);

Console.WriteLine("Reverse string, enter a word:");
var word = Convert.ToString(Console.ReadLine());
Practices.GetReverseString(word);

Console.WriteLine("Reverse number, enter a number:");
var number = Convert.ToInt32(Console.ReadLine());
Practices.GetReverseNumber(number);


Console.WriteLine("Sort numbers, example 1,5,3,8.. , ingrese el array :");
var str = Console.ReadLine();
string? strnumbers = string.IsNullOrEmpty(str) ? "5, 6, 4, 7, 3, 8, 2, 1" : Console.ReadLine();
string[] strings = strnumbers.Split(",");
int[] arraynumbers = Array.ConvertAll(strings, int.Parse);
int[] sourceArr = (int[])arraynumbers.Clone();
Practices.GetSortArrayNumber(sourceArr, arraynumbers);





