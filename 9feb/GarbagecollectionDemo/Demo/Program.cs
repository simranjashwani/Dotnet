using System;
using System.Collections.ObjectModel;
using System.Net.Mail;

namespace GarbageCollectionDemo
{
    class Program
    {
        static void Main()

        {
            // Resource();
            // RecordDemo();
            // CollectionClassesDemo();
            DictionaryDemo();
        }
        public static void DictionaryDemo()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict["simran"] = 23;
            dict["alice"] = 23;
            dict["bob"] = 23;
            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp:key}:{kvp:value}");
            }



        }
        public static void CollectionClassesDemo()
        {
            List<int> marks = new List<int>(10);
        }

        public static void Resource()
        {
            var res1 = new Resource("Res1");
            var res2 = new Resource("Res2");

            res1 = null; // eligible for GC

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("GC completed");
        }

        public static void RecordDemo()
        {
            var temp1 = new Temp { Id = 1, Name = "Temp1" };
            var temp2 = new Temp { Id = 1, Name = "Temp1" };

            Console.WriteLine(temp1);
            Console.WriteLine(temp2);
            Console.WriteLine(temp1 == temp2); // TRUE (value equality)

            var temp3 = temp1 with { Id = 2 };
            Console.WriteLine(temp3);
        }
    }
}
