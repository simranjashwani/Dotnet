using System;
using System.Collections.Generic;

class Persons
{
    public string Name { get; set; } = "";

    // Value equality
    public override bool Equals(object? obj)
    {
        return obj is Person p && p.Name == Name;
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode();
    }
}

class LogicalComparisonExample
{
    public static void Run()
    {
        // 1️⃣ Comparison + logical operators (&&)
        int x = 50;
        if (x > 0 && x < 100)
        {
            Console.WriteLine("x is in range");
        }

        // 2️⃣ Logical OR (||) and NOT (!)
        bool isReady = false;
        bool hasData = false;

        if (!(isReady || hasData))
        {
            Console.WriteLine("Not ready and no data");
        }

        // 3️⃣ Equality with string (value equality)
        string a = "hi";
        bool eq = a == "hi";
        Console.WriteLine($"String equality: {eq}");

        // 4️⃣ Reference vs value equality (custom class)
        Person p1 = new Person { Name = "Simran" };
        Person p2 = new Person { Name = "Simran" };

        Console.WriteLine($"Reference equality (==): {p1 == p2}");
        Console.WriteLine($"Value equality (Equals): {p1.Equals(p2)}");

        // 5️⃣ Why GetHashCode matters
        HashSet<Person> people = new HashSet<Person>();
        people.Add(p1);
        people.Add(p2);

        Console.WriteLine($"HashSet count: {people.Count}");
    }
}
