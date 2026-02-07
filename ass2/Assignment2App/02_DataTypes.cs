using System;
class DataTypes
{
       public static void Run()
       {
              int age =22;
              string name = "simran";
              bool isDev=true;
              // $ is used for string interpolation to embed variables and expressions directly inside strings./
              // String interpolation means:Put variable values directly inside a string
              Console.WriteLine($"{name},{age},{isDev}");
       }
}