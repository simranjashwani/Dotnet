//T? means the value type T is allowed to store null.
//T? allows value types to hold null, ?.
//prevents null reference exceptions, and ?? supplies default values.

// Nullable value types allow value types (such as int, double, bool) to store null using T?.
// The null-conditional operator (?.) safely accesses members and returns null if the object is null.
// The null-coalescing operator (??) provides a default value when the operand is null.

using System;
class NullableExample
{
       public static void Run()
       {
              // nullable value type n can store an int or null
              int? n = null;
              //  null-coalescing operator If n is null, value becomes -1
              int value = n ?? -1;
              // reference type 
              string? s = null;
              // null-conditional operator
              int? length = s?.Length;

              Console.WriteLine(value);
              Console.WriteLine(length);
       }
}