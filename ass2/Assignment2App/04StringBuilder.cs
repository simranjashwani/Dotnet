
using System.Text;
using System;

class StringBuilderExample
{
    public static void Run()
    {
        var sb = new StringBuilder();
        sb.Append("simran").AppendLine();
        sb.AppendFormat("{0} items", 5);

        string result = sb.ToString();
        Console.WriteLine(result);
    }
}




// using System;
// using System.Text;

// class StringBuilder
// {
//        public static void Run()
//        {
//               // Create a new empty StringBuilder object and store it in sb
// var sb = new StringBuilder();
// // Adds "Line1" to the StringBuilder
// // Does not create a new object (mutable)
// // Append() returns the same StringBuilder
// // AppendLine() adds a newline character
// sb.Append("simranjashwani").AppendLine();
// // What this does Appends formatted text
// // {0} is a placeholder
// // 5 replaces {0}
// sb.AppendFormat("{0} items", 5);
// // StringBuilder ≠ string
// // ToString() converts builder → final string
// string result = sb.ToString();
//  Console.WriteLine(result);
//         }
// }


// // The code demonstrates the use of StringBuilder for efficient string manipulation.
// // Append() and AppendLine() are used to add text, AppendFormat() adds formatted data, and ToString() /
// // converts the builder into a final string.
