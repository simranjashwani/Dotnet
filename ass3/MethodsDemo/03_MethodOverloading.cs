using System;
using System.Data;
// Method Overloading = multiple methods with the same name but different parameters.

// Return type alone cannot distinguish overloads.class

class Overloading
{
       public static int Add(int a,int b)
       {
              return a+b;
       }
       public static double Add (double a,double b)
       {
              return a+b;
       }
       public static decimal Add (decimal a, decimal b)
       {
              return a+b;
       }
       public static float Add(float a,float b)
       {
              return a+b;
       }
       public static void Run()
       {
              Console.WriteLine("method overloading ex");

              int sumInt =Add(4, 6);
              double sumDouble=Add(3.4, 7.8);
              decimal sumDecimal = Add(3.4m,88.9m);
              float sumFloat=Add (0.33f,4.50f);

              Console.WriteLine("Int Add:" +sumInt);
              Console.WriteLine("Double Add:" +sumDouble);
              Console.WriteLine("Decimal Add:" +sumDecimal);
              Console.WriteLine("Float Add:" +sumFloat);


       }
}