using System;
using System.Numerics;

class OperatorsExample
{
    public static void Run()
    {
        int a = 10, b = 3;

        Console.WriteLine(a + b);   // addition
       //  Console.WriteLine(a - b);   // subtraction
       //  Console.WriteLine(a * b);   // multiplication
       //  Console.WriteLine(a / b);   // integer division
       //  Console.WriteLine(a % b);   // modulo

        int numerator = 7;
        int denominator = 2;
        double ratio = (double)numerator / denominator;
        Console.WriteLine(ratio);

        checked
        {
//               Think of driving 🚗

// checked = speed camera (detects overspeeding)

// try–catch = airbag (protects you after crash)

// One detects, the other handles.
// checked enables overflow detection, while try–catch handles the exception raised due to overflow.
            try
            {
                int x = int.MaxValue;
                x += 1;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow detected");
            }
        }

        BigInteger big = BigInteger.Pow(10, 30);
        Console.WriteLine(big + 1);
    }
}
// using System;

// class Program
// {
//     static void Main()
//     {
//         try
//         {
//             checked
//             {
//                 int a = 10;
//                 int b = 3;

//                 int sum = a + b;
//                 Console.WriteLine("Sum: " + sum);

//                 int quotient = a / b;
//                 Console.WriteLine("Quotient: " + quotient);

//                 int remainder = a % b;
//                 Console.WriteLine("Remainder: " + remainder);

//                 int big = int.MaxValue;
//                 Console.WriteLine("Big value: " + big);

//                 big = big + 1;   // overflow happens here
//                 Console.WriteLine("After overflow: " + big);
//             }
//         }
//         catch (OverflowException)
//         {
//             Console.WriteLine("Overflow detected");
//         }
//     }
// }
