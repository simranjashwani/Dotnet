
using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string Name { get; set; }
    public string Grade { get; set; }
    public int Age { get; set; }

}
public class LinqDemo
{
    public static void Run()
    {

        //    anonymous type


        var students = new List<Student>
        {
            new Student{Name ="Alice",Age=20, Grade="A"},
            new Student{Name ="bob",Age=21, Grade="A"},
            new Student{Name ="david",Age=30, Grade="A"},
            new Student{Name ="charlie",Age=40, Grade="A"}
        };
        //  type pf sql
        var olderStudents = from s in students
        where s.Age >=21
        select new {s.Name};
        // var olderStudents =students.Where(filter);
        foreach(var s in olderStudents) 
        {
            Console.WriteLine($"{s.Name} more than 21 years old.");
        }

        // fluid api form

        // var x= students
        // .Where(s => sbyte.Age >21)
        // .Select(s => new{s.Name})
        //  .FirstorDefault();
        //  Console.WriteLine($"{x.Name} is the first result");



    }
}

