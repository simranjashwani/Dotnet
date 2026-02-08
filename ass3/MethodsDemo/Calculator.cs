using System;
using System.ComponentModel;
class Calculator
{
         // Instance method
       public static void Run()
       {
              int a=10;
              int b= 20;

              int sum = Add(a,b);
              int difference = substract(a,b);
              // int product = multiply (a,b);
              // int quotient =Divide (a,b); 

              Console.WriteLine("Addition =" + sum);
              Console.WriteLine("Substraction=" + difference);
              // Console.WriteLine("Division = " + quotient);
              // Console.WriteLine("Multiplication = " + product);
       }
        // Static method
       static int Add (int x ,int y)
       {
              return x+y;
       }
               // Expression-bodied method
       static int substract (int x, int y) =>x-y;
       // static int Multiply(int x, int y) => x * y;
}

//  static double Divide(int x, int y)
//     {
//         if (y == 0)
//         {
//             Console.WriteLine("Cannot divide by zero");
//             return 0;
//         }
//         return (double)x / y;
//     }
// }
// Instance method → belongs to an object, needs an instance to call.
// Static method → belongs to the class, called without creating an object.
// Expression-bodied method → short syntax for methods with a single expression, can be static or instance.