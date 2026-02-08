// Gives access to basic classes like Console, String, etc.
using System;
// Needed for collections like List<T>
using System.Collections.Generic;
// Provides Stopwatch for performance measurement.
using System.Diagnostics;
// Used to read files (CSV file reading).
using System.IO;
// Enables LINQ methods like Select, Where, Skip.
using System.Linq;
// Required for StringBuilder.
using System.Text;

namespace Assignment2App //Groups related classes together and avoids name conflicts.
{
       public record Person(string Name, int Age, string City); //record → immutable data structure
                                                                // Used to represent one row of CSV data
       public class ProgramExample
       {
              public static void Run()
              {
                     Console.WriteLine("ProgramExample.Run working!");
                     string[] csvLines =
                            {
                            "Name,Age,City",
                            "Simran,22,Bhopal",
                            "Aman,17,Indore",
                            "Riya,25,Pune",
                            "Rahul,16,Delhi"

                     };      
                     //Each string = one line of CSV First line = header Others = data rows
                            List<Person> people =csvLines  //Create a list of Person objects.
                            .Skip(1) //Skips header line (Name,Age,City).
                            .Select(line => //Converts each CSV line into a Person.
                            {
                            string[] parts =line.Split(','); //Splits line by comma into individual values.
                            return new Person (
                                   parts[0],//name
                                   int.Parse(parts[1]),//age converted into int
                                   parts[2] //city
                            );
                     })
                     .ToList();//Converts the result into List<Person>.
                    
                     // filter adults (Pattern Matching + LINQ)
                     List<Person> adults = people //Start from all people.
                     .Where(p => p is {Age: >= 18}) //Checks Age >= 18
                     .ToList();//Store result as a list.
                       Console.WriteLine("Adults (Age >= 18):");//Prints heading.
                       foreach (var person in adults) //Loops through adult list.
                     {
                            Console.WriteLine($"{person.Name} - {person.Age} - {person.City}"); //Prints person details
                     }
                          Console.WriteLine("-----------------------");

                          //String concatenation using + operator
                          Stopwatch sw1 = Stopwatch.StartNew();
                     
                     string result1 = "";
                     for (int i=0 ;i< 100_000; i++)
                     {
                            result1 = result1+1; //result1 += i;
                     }
                     sw1.Stop();
                     Console.WriteLine($"+ operator time:{sw1.ElapsedMilliseconds}ms");
                     // stringbuilder
                     Stopwatch sw2 =Stopwatch.StartNew();
                     StringBuilder sb= new StringBuilder();
                     for (int i = 0; i < 100_000; i++)
                     {
                            sb.Append(i);//Appends efficiently without creating new strings.

                     }
                     string result2 = sb.ToString();
                     sw2.Stop();
                     Console.WriteLine($"StringBuilder Time: {sw2.ElapsedMilliseconds} ms");
       }
       }
}