#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;

class ArrayExample
{
    public static void Run()
    {
        int[] arr = { 1,2,3,4,5,6,7,8,9,10 };
        Console.WriteLine(arr[1]);

        List<int> list = new List<int> { 1,2,3,4,5,6,7,8,9,10 };
        list.Add(4);

        var evens = list.Where(x => x % 2 == 0);

        foreach (var e in evens)
        {
            Console.WriteLine(e);
        }
    }
}
