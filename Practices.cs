using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Serialization;

namespace InterviewQuestion;

public static class Practices
{
    /// <summary>
    /// Number Prime 
    /// </summary>
    /// <param name="Max"></param>
    public static void GetNumberPrime(int max)
    {
        for (int i = 2; i <= max; i++)
        {
            var prime = IsPrimeNumber(i);
            if (prime) Console.WriteLine("Number prime : {0}", i);
        }
    }

    static bool IsPrimeNumber(int i)
    {
        int count = 0;
        bool r = true;
        for (int j = 2; j <= i; j++)
        {
            if (i % j == 0) count++;
            if (count > 2)
            {
                r = false;
                break;
            }

        }
        return r;
    }


    /// <summary>
    /// Ger reverse string
    /// </summary>
    /// <param name="value"></param>
    public static void GetReverseString(string word)
    {
        char[] chars = word.ToCharArray();
        StringBuilder wordOut = new StringBuilder();
        int length = chars.Length - 1;
        for (int i = 0; i <= length; i++)
        {
            var v = chars[length - i].ToString();
            wordOut.Append(v);
        }
        Console.WriteLine("Reverse string : {0} - {1}", word, wordOut);
    }


    public static void GetReverseNumber(int number)
    {
        int nreverse = 0, nsource = number;

        while (nsource > 0)
        {
            nreverse = nreverse * 10;
            nreverse = nreverse + (nsource % 10);
            nsource = nsource / 10;
        }
        Console.WriteLine("Reverse number : {0} - {1}", number, nreverse);

    }

    /// <summary>
    /// Order array numeric min to max
    /// </summary>
    /// <param name="sourcenum"></param>
    /// <param name="numbers"></param>
    public static void GetSortArrayNumber(int[] sourcenum, int[] numbers)
    {
        for (int i = 0; i <= numbers.Length - 1; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                var a = numbers[i];
                var b = numbers[j];
                if (a > b)
                {
                    numbers[i] = b;
                    numbers[j] = a;
                }
            }
        }
        Console.WriteLine("Sort Array: {0} - {1} ", string.Join(",", sourcenum), "{ " + string.Join(",", numbers) + " }");
    }
}


