using System;
// Used to measure execution time to measure stopwatch

using System.Diagnostics;

using System.Text;

class StringvsStringBuilder
{
public static void Run()
       {
              const int iterations = 100_000;

              // string concatination: Joining two or more strings together to form a single string.
              Stopwatch sw1= Stopwatch.StartNew();
              string s= "";
              for(int i=0 ; i<iterations ; i++)
              {
                     s+=i;
              } 
              sw1.Stop();
              Console.WriteLine($"String concatination time : {sw1.ElapsedMilliseconds}ms");
               
              //  string builder 
                Stopwatch sw2 = Stopwatch.StartNew();
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < iterations; i++)
              {
                     sb.Append(i);
              }
               string result = sb.ToString();
               sw2.Stop();
               Console.WriteLine($"StringBuilder time :{sw2.ElapsedMilliseconds}ms");
                   }
}