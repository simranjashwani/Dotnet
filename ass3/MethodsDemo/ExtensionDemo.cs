using System;
public class Employee
{
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public Employee(int ID, string FirstName, string LastName, int Age)
    {
        this.ID = ID;  //used to point to reffer to the current abject of the class
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.Age = Age;
    }
    public void Print()
    {
        Console.WriteLine($"ID: {this.ID}, Name: {this.FirstName} {this.LastName}, Age: {this.Age}");
    }
}

public static class EmployeeExtension
{
    public static void NewFunction(this Employee x)
    {
        x.Age = x.Age * 2;

    }


}

//add new method to existing class withod modifying its source code