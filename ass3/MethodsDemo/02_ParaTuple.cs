using System;

class Calculation
{
    // Returns min and max using tuple
    public static (int min, int max) GetMinMax(int[] numbers)
    {
        int min = numbers[0];
        int max = numbers[0];

        foreach (var num in numbers)
        {
            if (num < min) min = num;
            if (num > max) max = num;
        }

        return (min, max);
    }

    // ref example
    public static void RefExample(ref int x)
    {
        x += 10;
    }

    // out example
    public static void OutExample(out int y)
    {
        y = 50;
    }

    // in example
    public static void InExample(in int z)
    {
        Console.WriteLine("Value of in variable: " + z);
    }

    // Run method to call all examples
    public static void Run()
    {
        // Tuple example
         int[] nums = { 7, 9, 6, 10 };

        // Call static GetMinMax method
        var result = GetMinMax(nums);
        Console.WriteLine("Min = " + result.min);
        Console.WriteLine("Max = " + result.max);

        // ref example
        int a = 5;
        RefExample(ref a);
        Console.WriteLine("After ref: " + a);

        // out example
        int b;
        OutExample(out b);
        Console.WriteLine("After out: " + b);

        // in example
        int c = 100;
        InExample(in c);
    }
}
// Tuple → (sum, product) → returns two values at once
// ref → modifies existing variable (a = 7 → 17)
// out → assigns value to uninitialized variable (b = 50)
// Run() → central method calling all examples
// Static methods → called directly without creating an object