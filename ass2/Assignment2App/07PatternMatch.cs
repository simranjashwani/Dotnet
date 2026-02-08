using System;


class Person
{
       public string Name { get; set; } = "";
       public int Age { get; set; }
}
class PatternExample
{
       public static void Run()
       {
              //  type pattern
              object o = 5;
              if (o is int i)
              {
                     Console.WriteLine($"type pattern :{i+1}");
              }
              // property pattern
              Person person = new Person{Name="Simran" , Age= 22};
              if (person is {Age:>=18 ,Name:var n })
              {
                     Console.WriteLine($"property pattern :{n}is an adult");
              }
              // switch expresion
              object?[] items ={10, "hello", 3.14, null};
              foreach(var item in items)
              {
                    Console.WriteLine($"Switch pattern: {Describe(item)}");
              }
       }
       static string Describe(object? obj ) => obj switch
       {
              null =>"none",
              int i =>$"int {i}",
              string s => $"str({s})",

               _=>"other"
       };
}

// Pattern matching allows C# to check a value’s shape, type, or properties and extract data in a safe and readable way.
// It is commonly used with is expressions and switch expressions.