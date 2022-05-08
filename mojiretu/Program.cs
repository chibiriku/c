//特定の条件で数値を表示
using System;

class Program
{
    static void Main()
    {
        var numberString = Console.ReadLine().Trim();
        var number = int.Parse(numberString);
        if(number >= 10)
        {
            Console.WriteLine(number);
        }

    }
}
