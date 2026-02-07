using System;
class StringExample
{
        public static void Run()
       {
            string template = $"User: {Environment.UserName}, Date:{DateTime.Today:d}"; 
            Console.WriteLine(template);
  }
}