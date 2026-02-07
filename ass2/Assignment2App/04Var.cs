using System;
// It allows us to use generic collection classes like List<T>, Dictionary<TKey, TValue>, etc., without writing their full names.
using System.Collections.Generic;
class VarExample
// var means “let the compiler decide the data type for me.”
{
       public static void Run()
       {
              var x =10;
              var name ="simran";
              
               var list = new List<string>();
              list.Add ("apple");

              Console.WriteLine(x);
              Console.WriteLine(name);
              Console.WriteLine(list.Count);

       }
}